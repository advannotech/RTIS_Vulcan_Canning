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
    public partial class cntrlLot : UserControl
    {
        public string code { get; set; }
        public bool selected { get; set; }
        ucSelectLot parent { get; set; }
        public cntrlLot(string _code, ucSelectLot _parent)
        {
            InitializeComponent();
            code = _code;
            parent = _parent;
        }

        private void cntrlLot_Load(object sender, EventArgs e)
        {
            lblLotNumber.Text = code;
        }

        private void lblLotNumber_Click(object sender, EventArgs e)
        {
            try
            {
                selected = true;
                pnlBack.BackColor = Color.LightBlue;
                lblLotNumber.BackColor = Color.LightBlue;
                foreach (cntrlLot item in parent.pnlItems.Controls)
                {
                    if (item != this)
                    {
                        item.selected = false;
                        item.pnlBack.BackColor = Color.White;
                        item.lblLotNumber.BackColor = Color.White;
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
                lblLotNumber.BackColor = Color.LightBlue;
                foreach (cntrlLot item in parent.pnlItems.Controls)
                {
                    if (item != this)
                    {
                        item.selected = false;
                        item.pnlBack.BackColor = Color.White;
                        item.lblLotNumber.BackColor = Color.White;
                    }

                }
            }
            catch (Exception)
            {

            }
        }
    }
}
