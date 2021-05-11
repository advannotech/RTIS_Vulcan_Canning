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
using RTIS_Vulcan_Canning.Controls.Printing;

namespace RTIS_Vulcan_Canning.Controls
{
    public partial class ucScanTag : UserControl
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
        public ucScanTag(Panel _parent, Form1 _main)
        {
            InitializeComponent();
            parent = _parent;
            main = _main;
        }

        private void ucScanTag_Load(object sender, EventArgs e)
        {
            this.Size = parent.Size;
            txtItem.Focus();
        }

        private void txtItem_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtItem.Text != string.Empty)
                    {
                        if (txtItem.Text.Contains("(") && txtItem.Text.Contains(")"))
                        {
                            GlobalVars.rmCode = Barcodes.GetItemCode(txtItem.Text);
                            GlobalVars.lotNumber = Barcodes.GetItemLot(txtItem.Text);
                            GlobalVars.qty = Barcodes.GetItemQty(txtItem.Text);
                            GlobalVars.unq = Barcodes.GetUniqCode(txtItem.Text);

                            ucConfimProduct scan = new ucConfimProduct(parent, main);
                            main.pnlMain.Controls.Clear();
                            main.pnlMain.Controls.Add(scan);
                        }
                        else
                        {
                            txtItem.Text = string.Empty;
                            msg = new frmMsg("Cannot get barcode information", "Pleass can a valid pallet tag", GlobalVars.msgState.Error);
                            msg.ShowDialog();
                            txtItem.Focus();
                        }
                    }
                    else
                    {
                        txtItem.Text = string.Empty;
                        msg = new frmMsg("Cannot get barcode information", "Pleass can a valid pallet tag", GlobalVars.msgState.Error);
                        msg.ShowDialog();
                        txtItem.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                txtItem.Text = string.Empty;
                txtItem.Focus();
                ExHandler.showErrorEx(ex);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                ucLogin login = new ucLogin(parent, main);
                GlobalVars.lastControl = login;
                main.pnlMain.Controls.Clear();
                main.pnlMain.Controls.Add(login);
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }
    }
}
