using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using RTIS_Vulcan_Canning.Forms;
using RTIS_Vulcan_Canning.Classes;

namespace RTIS_Vulcan_Canning.Controls.Printing
{
    public partial class ucConfimProduct : UserControl
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
        public ucConfimProduct(Panel _parent, Form1 _main)
        {
            InitializeComponent();
            parent = _parent;
            main = _main;
        }

        private void ucConfimProduct_Load(object sender, EventArgs e)
        {
            this.Size = parent.Size;
            getItems();
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
        public void getItems()
        {
            try 
            {
                string items = Client.getCanningProducts(GlobalVars.rmCode);
                switch (items.Split('*')[0])
                {
                    case "1":
                        items = items.Remove(0, 2);
                        string[] allItems = items.Split('~');
                        foreach (string item in allItems)
                        {
                            if (item != string.Empty)
                            {
                                string code = item.Split('|')[0];
                                string desc = item.Split('|')[1];
                                
                                cntrlProduct PalletItem = new cntrlProduct(code, desc, this);
                                PalletItem.Dock = DockStyle.Top;
                                pnlItems.Controls.Add(PalletItem);
                            }
                        }
                        break;
                    case "0":
                        items = items.Remove(0, 2);
                        msg = new frmMsg("The following server side issue was encountered:", items, GlobalVars.msgState.Error);
                        msg.ShowDialog();
                        break;
                    case "-1":
                        items = items.Remove(0, 3);
                        errMsg = items.Split('|')[0];
                        errInfo = items.Split('|')[1];
                        ExHandler.showErrorStr(errMsg, errInfo);
                        break;
                    case "-2":
                        items = items.Remove(0, 2);
                        msg = new frmMsg("A connection level error has occured", items, GlobalVars.msgState.Error);
                        msg.ShowDialog();
                        break;
                    default:
                        st = new StackTrace(0, true);
                        msgStr = "Unexpected error while retreiving pallet list for job";
                        errInfo = "Unexpected error while retreiving pallet list for job" + Environment.NewLine + "Data Returned:" + Environment.NewLine + items;
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                bool found = false;
                foreach (cntrlProduct item in pnlItems.Controls)
                {
                    if (item.selected == true)
                    {
                        found = true;
                        GlobalVars.itemCode = item.itemCode;
                        GlobalVars.itemDesc = item.itemDesc;
                    }
                }

                if (found == true)
                {
                    ucEnterQty jobQty = new ucEnterQty(parent, main);
                    main.pnlMain.Controls.Clear();
                    main.pnlMain.Controls.Add(jobQty);
                }
                else
                {
                    msg = new frmMsg("Cannot Continue", "Please select a PGM", GlobalVars.msgState.Error);
                    msg.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                ucScanTag scanTag = new ucScanTag(parent, main);
                GlobalVars.lastControl = scanTag;
                main.pnlMain.Controls.Clear();
                main.pnlMain.Controls.Add(scanTag);
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }
    }
}
