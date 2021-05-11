using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTIS_Vulcan_Canning.Controls.Reprinting
{
    public partial class cntrlItem : UserControl
    {
        public string code { get; set; }
        public bool selected { get; set; }
        ucSelectItem parent { get; set; }
        public cntrlItem(string _code, ucSelectItem _parent)
        {
            InitializeComponent();
            code = _code;
            parent = _parent;
        }
        private void cntrlItem_Load(object sender, EventArgs e)
        {
            lblItemCode.Text = code;
        }
        private void pnlBack_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void lblItemCode_Click(object sender, EventArgs e)
        {
            try
            {
                selected = true;
                pnlBack.BackColor = Color.LightBlue;
                lblItemCode.BackColor = Color.LightBlue;
                foreach (cntrlItem item in parent.pnlItems.Controls)
                {
                    if (item != this)
                    {
                        item.selected = false;
                        item.pnlBack.BackColor = Color.White;
                        item.lblItemCode.BackColor = Color.White;
                    }

                }
            }
            catch (Exception)
            {

            }
        }

        private void pnlBack_Click(object sender, EventArgs e)
        {
            try
            {
                selected = true;
                pnlBack.BackColor = Color.LightBlue;
                lblItemCode.BackColor = Color.LightBlue;
                foreach (cntrlItem item in parent.pnlItems.Controls)
                {
                    if (item != this)
                    {
                        item.selected = false;
                        item.pnlBack.BackColor = Color.White;
                        item.lblItemCode.BackColor = Color.White;
                    }

                }
            }
            catch (Exception)
            {

            }
        }
    }
}
