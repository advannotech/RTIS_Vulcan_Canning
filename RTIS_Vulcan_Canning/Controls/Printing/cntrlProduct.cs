using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTIS_Vulcan_Canning.Controls.Printing
{
    public partial class cntrlProduct : UserControl
    {
        public string itemCode { get; set; }
        public string itemDesc { get; set; }
        public bool selected { get; set; }
        ucConfimProduct parent { get; set; }
        public cntrlProduct(string _itemCode, string _itemDesc, ucConfimProduct _parent)
        {
            InitializeComponent();
            itemCode = _itemCode;
            itemDesc = _itemDesc;
        }
        private void cntrlProduct_Load(object sender, EventArgs e)
        {
            lblItemCode.Text = itemCode;
            lblItemDesc.Text = itemDesc;
        }

        private void lblItemCode_Click(object sender, EventArgs e)
        {
            try
            {
                selected = true;
                tlpMain.BackColor = Color.LightBlue;
                pnlBack.BackColor = Color.LightBlue;

                foreach (cntrlProduct item in parent.pnlItems.Controls)
                {
                    if (item != this)
                    {
                        item.selected = false;
                        item.tlpMain.BackColor = Color.White;
                        item.pnlBack.BackColor = Color.White;
                    }

                }
            }
            catch (Exception)
            {

            }
        }

        private void lblItemDesc_Click(object sender, EventArgs e)
        {
            try
            {
                selected = true;
                tlpMain.BackColor = Color.LightBlue;
                pnlBack.BackColor = Color.LightBlue;

                foreach (cntrlProduct item in parent.pnlItems.Controls)
                {
                    if (item != this)
                    {
                        item.selected = false;
                        item.tlpMain.BackColor = Color.White;
                        item.pnlBack.BackColor = Color.White;
                    }

                }
            }
            catch (Exception)
            {

            }
        }
    }
}
