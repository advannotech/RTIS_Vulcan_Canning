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

namespace RTIS_Vulcan_Canning.Controls.Printing
{
    public partial class ucEnterQty : UserControl
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
        public ucEnterQty(Panel _parent, Form1 _main)
        {
            InitializeComponent();
            parent = _parent;
            main = _main;
        }

        private void ucEnterQty_Load(object sender, EventArgs e)
        {
            this.Size = parent.Size;
            lblItem.Text = GlobalVars.itemCode;
            lblDesc.Text = GlobalVars.itemDesc;
            lblRCode.Text = GlobalVars.rmCode;
            lblLotNumber.Text = GlobalVars.lotNumber;

            cntrlNumPad num = new cntrlNumPad();
            num.Dock = DockStyle.Right;
            pnlKeyPad.Controls.Add(num);

            getRItemDesc();
        }
        public void getRItemDesc()
        {
            try
            {
                string itemDesc = Client.getRItemDesc(GlobalVars.rmCode);
                switch (itemDesc.Split('*')[0])
                {
                    case "1":
                        itemDesc = itemDesc.Remove(0, 2);
                        GlobalVars.rmDesc = itemDesc;
                        lblRDesc.Text = GlobalVars.rmDesc;
                        break;
                    case "0":
                        itemDesc = itemDesc.Remove(0, 2);
                        msg = new frmMsg("The following server side issue was encountered:", itemDesc, GlobalVars.msgState.Error);
                        msg.ShowDialog();
                        break;
                    case "-1":
                        itemDesc = itemDesc.Remove(0, 3);
                        errMsg = itemDesc.Split('|')[0];
                        errInfo = itemDesc.Split('|')[1];
                        ExHandler.showErrorStr(errMsg, errInfo);
                        break;
                    case "-2":
                        itemDesc = itemDesc.Remove(0, 2);
                        msg = new frmMsg("A connection level error has occured", itemDesc, GlobalVars.msgState.Error);
                        msg.ShowDialog();
                        break;
                    default:
                        st = new StackTrace(0, true);
                        msgStr = "Unexpected error while retreiving item information";
                        errInfo = "Unexpected error while retreiving item information" + Environment.NewLine + "Data Returned:" + Environment.NewLine + itemDesc;
                        ExHandler.showErrorST(st, msgStr, errInfo);
                        break;
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
                ucConfimProduct conProd = new ucConfimProduct(parent, main);
                GlobalVars.lastControl = conProd;
                main.pnlMain.Controls.Clear();
                main.pnlMain.Controls.Add(conProd);
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
                string labelInfo = Client.recordCanningOut(GlobalVars.rmCode + "|" + GlobalVars.rmDesc + "|" + GlobalVars.qty + "|" + GlobalVars.unq + "|" + GlobalVars.itemCode + "|" + GlobalVars.itemDesc + "|" + GlobalVars.lotNumber + "|" + txtQty.Text + "|" + GlobalVars.userName);
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
                        printLabel.Parameters["_Qty"].Value = txtQty.Text;
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

                        msg = new frmMsg("Success", "The canned catalysts have been recorded", GlobalVars.msgState.Success);
                        msg.ShowDialog();

                        ucScanTag scanTag = new ucScanTag(parent, main);
                        GlobalVars.lastControl = scanTag;
                        main.pnlMain.Controls.Clear();
                        main.pnlMain.Controls.Add(scanTag);
                        break;                  
                    case "-1":
                        labelInfo = labelInfo.Remove(0, 3);
                        errMsg = labelInfo.Split('|')[0];
                        errInfo = labelInfo.Split('|')[1];
                        ExHandler.showErrorStr(errMsg, errInfo);
                        break;
                    case "-2":
                        labelInfo = labelInfo.Remove(0, 2);
                        msg = new frmMsg("A connection level error has occured", labelInfo, GlobalVars.msgState.Error);
                        msg.ShowDialog();
                        break;
                    default:
                        st = new StackTrace(0, true);
                        msgStr = "Unexpected error while retreiving pallet list for job";
                        errInfo = "Unexpected error while retreiving pallet list for job" + Environment.NewLine + "Data Returned:" + Environment.NewLine + labelInfo;
                        ExHandler.showErrorST(st, msgStr, errInfo);
                        break;
                }
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }

        private void txtQty_Click(object sender, EventArgs e)
        {
            GlobalVars.focusedEdit = txtQty;
        }
    }
}
