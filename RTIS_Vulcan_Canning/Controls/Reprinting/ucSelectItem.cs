using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RTIS_Vulcan_Canning.Forms;
using System.Diagnostics;
using RTIS_Vulcan_Canning.Classes;
using RTIS_Vulcan_Canning.Controls.General;

namespace RTIS_Vulcan_Canning.Controls.Reprinting
{
    public partial class ucSelectItem : UserControl
    {
        #region Error handling
        public frmMsg msg;
        public string errMsg;
        public string errInfo;

        StackTrace st;
        string msgStr = string.Empty;
        string infoStr = string.Empty;
        #endregion

        public Form1 main;
        Panel parent;

        public ucSelectItem(Panel _parent, Form1 _main)
        {
            InitializeComponent();
            parent = _parent;
            main = _main;
        }

        private void ucSelectItem_Load(object sender, EventArgs e)
        {
            this.Size = parent.Size;
            getItemCodes();
            if (pnlItems.Height < pnlParent.Height)
            {
                vsbFG.Visible = false;
                pnlItems.Dock = DockStyle.Fill;
            }
            else
            {
                vsbFG.Visible = true;
                vsbFG.BringToFront();
                pnlItems.Parent = pnlParent;
                pnlItems.Height = pnlItems.Height + 80;
                vsbFG.Maximum = pnlItems.Height - pnlParent.Height;
                vsbFG.LargeChange = vsbFG.Maximum / 6;
            }
        }
        public void getItemCodes()
        {
            try
            {
                string lots = Client.getReprintItemList();
                switch (lots.Split('*')[0])
                {
                    case "1":
                        lots = lots.Remove(0, 2);
                        string[] allLots = lots.Split('~');
                        foreach (string item in allLots)
                        {
                            if (item != string.Empty)
                            {
                                cntrlItem lot = new cntrlItem(item, this);
                                lot.Dock = DockStyle.Top;
                                pnlItems.Controls.Add(lot);
                            }
                        }
                        break;
                    case "0":
                        lots = lots.Remove(0, 2);
                        msg = new frmMsg("The following server side issue was encountered:", lots, GlobalVars.msgState.Error);
                        msg.ShowDialog();
                        break;
                    case "-1":
                        lots = lots.Remove(0, 3);
                        errMsg = lots.Split('|')[0];
                        errInfo = lots.Split('|')[1];
                        ExHandler.showErrorStr(errMsg, errInfo);
                        break;
                    case "-2":
                        lots = lots.Remove(0, 2);
                        msg = new frmMsg("A connection level error has occured", lots, GlobalVars.msgState.Error);
                        msg.ShowDialog();
                        break;
                    default:
                        st = new StackTrace(0, true);
                        msgStr = "Unexpected error while retreiving warehouse transfer processes";
                        errInfo = "Unexpected error while retreiving warehouse transfer processes" + Environment.NewLine + "Data Returned:" + Environment.NewLine + lots;
                        break;
                }
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }

        private void vsbFG_Scroll(object sender, ScrollEventArgs e)
        {
            Point p = pnlItems.Location;
            p.Y = 0 - e.NewValue;
            pnlItems.Location = p;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                ucMenu menu = new ucMenu(parent, main);
                GlobalVars.lastControl = menu;
                main.pnlMain.Controls.Clear();
                main.pnlMain.Controls.Add(menu);
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                bool found = false;
                foreach (cntrlItem item in pnlItems.Controls)
                {
                    if (item.selected == true)
                    {
                        found = true;
                        GlobalVars.RPitemCode = item.code;
                    }
                }

                if (found)
                {
                    ucSelectLot select = new ucSelectLot(parent, main);
                    main.pnlMain.Controls.Clear();
                    main.pnlMain.Controls.Add(select);
                }
                else
                {
                    msg = new frmMsg("No Item Selected", "Please select an item to continue", GlobalVars.msgState.Error);
                    msg.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }
    }
}
