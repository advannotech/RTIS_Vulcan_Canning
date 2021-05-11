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
using DevExpress.XtraReports.UI;
using System.Threading;

namespace RTIS_Vulcan_Canning.Controls.Reprinting
{
    public partial class ucSelectPallet : UserControl
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

        string dataLines = string.Empty;
        bool dataPulled = false;

        string palletNo = string.Empty;
        string qty = string.Empty;

        public ucSelectPallet(Panel _parent, Form1 _main)
        {
            InitializeComponent();
            parent = _parent;
            main = _main;
        }

        private void ucSelectPallet_Load(object sender, EventArgs e)
        {
            this.Size = parent.Size;
            getItemPallets();
            if (pnlItems.Height < pnlParent.Height)
            {
                vsbFG.Visible = false;
                pnlItems.Dock = DockStyle.Fill;
                tblHeader.Width = pnlItems.Width;
                //Point p = pnlItems.Location;
                //p.Y = tblHeader.Location.Y;
                //tblHeader.Location = p;
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
        public void getItemPallets()
        {
            try
            {
                string lots = Client.getReprintPalletList(GlobalVars.RPitemCode + "|" + GlobalVars.RPlotNumber);
                switch (lots.Split('*')[0])
                {
                    case "1":
                        lots = lots.Remove(0, 2);
                        string[] allLots = lots.Split('~');
                        foreach (string item in allLots)
                        {
                            if (item != string.Empty)
                            {
                                cntrlPallet pallet = new cntrlPallet(item.Split('|')[0], item.Split('|')[1], item.Split('|')[2], item.Split('|')[3], item.Split('|')[4], item.Split('|')[5], this);
                                pallet.Dock = DockStyle.Top;
                                pnlItems.Controls.Add(pallet);
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
        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {

                bool found = false;
                foreach (cntrlPallet item in pnlItems.Controls)
                {
                    if (item.selected == true)
                    {
                        found = true;
                        palletNo = item.pallet;
                        qty = item.qty;
                        GlobalVars.rmCode = item.rCode;
                        GlobalVars.rmDesc = item.rDesc;
                    }
                }

                if (found)
                {
                    beginPrint();
                }
                else
                {
                    msg = new frmMsg("No Pallet Selected", "Please select a pallet to continue", GlobalVars.msgState.Error);
                    msg.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }
        public void beginPrint()
        {
            ppnlWait.BringToFront();
            dataPulled = false;
            Application.DoEvents();
            tmrItems.Start();
            Thread thread = new Thread(getPrintInfo);
            thread.Start();
        }
        public void getPrintInfo()
        {
            try
            {
                dataLines = Client.reprintCanningLabel(GlobalVars.RPitemCode + "|" + GlobalVars.RPlotNumber + "|" + qty);
                dataPulled = true;
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }
        public void doPrint()
        {
            try
            {
                if (dataPulled == true)
                {
                    tmrItems.Stop();
                    string labelInfo = dataLines;
                    switch (labelInfo.Split('*')[0])
                    {
                        case "1":
                            string unq = labelInfo.Split('~')[1];
                            labelInfo = labelInfo.Remove(0, 2).Split('~')[0];


                            string itemCode = labelInfo.Split('|')[0];
                            string barcode = labelInfo.Split('|')[1];
                            string simpleCode = labelInfo.Split('|')[2];
                            string binLocation = labelInfo.Split('|')[3];
                            string description1 = labelInfo.Split('|')[4];
                            string description2 = labelInfo.Split('|')[5];
                            string description3 = labelInfo.Split('|')[6];
                            string group = labelInfo.Split('|')[7];

                            XtraReport printLabel = GlobalVars.canningTag;
                            printLabel.Parameters["_ItemCode"].Value = itemCode;
                            printLabel.Parameters["_Lot"].Value = GlobalVars.lotNumber;
                            printLabel.Parameters["_Qty"].Value = qty;
                            printLabel.Parameters["_RT2D"].Value = unq;
                            printLabel.Parameters["_barcode"].Value = barcode;
                            printLabel.Parameters["_bin"].Value = binLocation;
                            printLabel.Parameters["_Date"].Value = DateTime.Now.ToString("yyyy-MM-dd");
                            printLabel.Parameters["_Description1"].Value = description1;
                            printLabel.Parameters["_Description2"].Value = description2;
                            printLabel.Parameters["_Description3"].Value = description3;
                            printLabel.Parameters["_Group"].Value = group;
                            printLabel.Parameters["_SimpleCode"].Value = simpleCode;
                            printLabel.Parameters["_rmCode"].Value = GlobalVars.rmCode;
                            printLabel.Parameters["_rmDesc"].Value = GlobalVars.rmDesc;
                            printLabel.CreateDocument();
                            ReportPrintTool prtTool = new ReportPrintTool(printLabel);
                            prtTool.PrinterSettings.Copies = Convert.ToInt16(1);
                            prtTool.Print(GlobalVars.Printer);

                            ppnlWait.SendToBack();
                            msg = new frmMsg("Success", "The label has been reprinted", GlobalVars.msgState.Success);
                            msg.ShowDialog();
                            break;
                        case "-1":
                            ppnlWait.SendToBack();
                            labelInfo = labelInfo.Remove(0, 3);
                            errMsg = labelInfo.Split('|')[0];
                            errInfo = labelInfo.Split('|')[1];
                            ExHandler.showErrorStr(errMsg, errInfo);
                            break;
                        case "-2":
                            ppnlWait.SendToBack();
                            labelInfo = labelInfo.Remove(0, 2);
                            msg = new frmMsg("A connection level error has occured", labelInfo, GlobalVars.msgState.Error);
                            msg.ShowDialog();
                            break;
                        default:
                            ppnlWait.SendToBack();
                            st = new StackTrace(0, true);
                            msgStr = "Unexpected error while retreiving pallet list for job";
                            errInfo = "Unexpected error while retreiving pallet list for job" + Environment.NewLine + "Data Returned:" + Environment.NewLine + labelInfo;
                            ExHandler.showErrorST(st, msgStr, errInfo);
                            break;
                    }
                }
                
            }
            catch (Exception ex)
            {
                tmrItems.Stop();
                ppnlWait.SendToBack();
                ExHandler.showErrorEx(ex);
            }
        }
        private void tmrItems_Tick(object sender, EventArgs e)
        {
            doPrint();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                ucSelectLot lot = new ucSelectLot(parent, main);
                GlobalVars.lastControl = lot;
                main.pnlMain.Controls.Clear();
                main.pnlMain.Controls.Add(lot);
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }

        private void ppnlWait_Click(object sender, EventArgs e)
        {

        }
    }
}
