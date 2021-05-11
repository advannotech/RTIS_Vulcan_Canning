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
using RTIS_Vulcan_Canning.Controls.Reprinting;

namespace RTIS_Vulcan_Canning.Controls.General
{
    public partial class ucMenu : UserControl
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
        public ucMenu(Panel _parent, Form1 _main)
        {
            InitializeComponent();
            parent = _parent;
            main = _main;
        }
        private void ucMenu_Load(object sender, EventArgs e)
        {
            this.Size = parent.Size;
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                ucScanTag scan = new ucScanTag(parent, main);
                main.pnlMain.Controls.Clear();
                main.pnlMain.Controls.Add(scan);
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }

        private void btnReprint_Click(object sender, EventArgs e)
        {
            try
            {
                ucSelectItem select = new ucSelectItem(parent, main);
                main.pnlMain.Controls.Clear();
                main.pnlMain.Controls.Add(select);
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }

        private void btnLogoff_Click(object sender, EventArgs e)
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
