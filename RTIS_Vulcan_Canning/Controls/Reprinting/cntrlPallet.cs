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
    public partial class cntrlPallet : UserControl
    {
        public string code { get; set; }
        public string lot { get; set; }
        public string qty { get; set; }
        public string rCode { get; set; }
        public string pallet { get; set; }
        public string rDesc { get; set; }
        public bool selected { get; set; }
        ucSelectPallet parent { get; set; }
        public cntrlPallet(string _code, string _lot, string _qty, string _rCode, string _pallet, string _rDesc, ucSelectPallet _parent)
        {
            InitializeComponent();
            code = _code;
            lot = _lot;
            qty = _qty;
            rCode = _rCode;
            pallet = _pallet;
            rDesc = _rDesc;
            parent = _parent;
        }

        private void cntrlPallet_Load(object sender, EventArgs e)
        {
            lblItemCode.Text = code;
            lblLotNumber.Text = lot;
            lblQty.Text = qty;
            lblCanned.Text = rCode;
            lblPallet.Text = pallet;
        }

        private void lblItemCodeH_Click(object sender, EventArgs e)
        {
            try
            {
                selected = true;
                this.BackColor = Color.LightBlue;
                foreach (cntrlPallet item in parent.pnlItems.Controls)
                {
                    if (item != this)
                    {
                        item.selected = false;
                        item.BackColor = Color.White;
                    }

                }
            }
            catch (Exception)
            {

            }
        }

        private void lblLotH_Click(object sender, EventArgs e)
        {
            try
            {
                selected = true;
                this.BackColor = Color.LightBlue;
                foreach (cntrlPallet item in parent.pnlItems.Controls)
                {
                    if (item != this)
                    {
                        item.selected = false;
                        item.BackColor = Color.White;
                    }

                }
            }
            catch (Exception)
            {

            }
        }

        private void lblQtyH_Click(object sender, EventArgs e)
        {
            try
            {
                selected = true;
                this.BackColor = Color.LightBlue;
                foreach (cntrlPallet item in parent.pnlItems.Controls)
                {
                    if (item != this)
                    {
                        item.selected = false;
                        item.BackColor = Color.White;
                    }

                }
            }
            catch (Exception)
            {

            }
        }

        private void lblRawH_Click(object sender, EventArgs e)
        {
            try
            {
                selected = true;
                this.BackColor = Color.LightBlue;
                foreach (cntrlPallet item in parent.pnlItems.Controls)
                {
                    if (item != this)
                    {
                        item.selected = false;
                        item.BackColor = Color.White;
                    }

                }
            }
            catch (Exception)
            {

            }
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {
            try
            {
                selected = true;
                this.BackColor = Color.LightBlue;
                foreach (cntrlPallet item in parent.pnlItems.Controls)
                {
                    if (item != this)
                    {
                        item.selected = false;
                        item.BackColor = Color.White;
                    }

                }
            }
            catch (Exception)
            {

            }
        }

        private void lblItemCode_Click(object sender, EventArgs e)
        {
            try
            {
                selected = true;
                this.BackColor = Color.LightBlue;
                foreach (cntrlPallet item in parent.pnlItems.Controls)
                {
                    if (item != this)
                    {
                        item.selected = false;
                        item.BackColor = Color.White;
                    }

                }
            }
            catch (Exception)
            {

            }
        }

        private void lblLotNumber_Click(object sender, EventArgs e)
        {
            try
            {
                selected = true;
                this.BackColor = Color.LightBlue;
                foreach (cntrlPallet item in parent.pnlItems.Controls)
                {
                    if (item != this)
                    {
                        item.selected = false;
                        item.BackColor = Color.White;
                    }

                }
            }
            catch (Exception)
            {

            }
        }

        private void lblQty_Click(object sender, EventArgs e)
        {
            try
            {
                selected = true;
                this.BackColor = Color.LightBlue;
                foreach (cntrlPallet item in parent.pnlItems.Controls)
                {
                    if (item != this)
                    {
                        item.selected = false;
                        item.BackColor = Color.White;
                    }

                }
            }
            catch (Exception)
            {

            }
        }

        private void lblCanned_Click(object sender, EventArgs e)
        {
            try
            {
                selected = true;
                this.BackColor = Color.LightBlue;
                foreach (cntrlPallet item in parent.pnlItems.Controls)
                {
                    if (item != this)
                    {
                        item.selected = false;
                        item.BackColor = Color.White;
                    }

                }
            }
            catch (Exception)
            {

            }
        }

        private void lblPallet_Click(object sender, EventArgs e)
        {
            try
            {
                selected = true;
                this.BackColor = Color.LightBlue;
                foreach (cntrlPallet item in parent.pnlItems.Controls)
                {
                    if (item != this)
                    {
                        item.selected = false;
                        item.BackColor = Color.White;
                    }

                }
            }
            catch (Exception)
            {

            }
        }
    }
}
