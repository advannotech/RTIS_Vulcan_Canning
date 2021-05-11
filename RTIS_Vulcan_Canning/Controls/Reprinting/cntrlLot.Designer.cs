namespace RTIS_Vulcan_Canning.Controls.Reprinting
{
    partial class cntrlLot
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBack = new System.Windows.Forms.Panel();
            this.lblLotNumber = new DevExpress.XtraEditors.LabelControl();
            this.pnlBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBack
            // 
            this.pnlBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBack.Controls.Add(this.lblLotNumber);
            this.pnlBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBack.Location = new System.Drawing.Point(0, 0);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(1082, 105);
            this.pnlBack.TabIndex = 1;
            this.pnlBack.Click += new System.EventHandler(this.pnlBack_Click);
            // 
            // lblLotNumber
            // 
            this.lblLotNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLotNumber.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblLotNumber.Appearance.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLotNumber.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblLotNumber.Appearance.Options.UseBackColor = true;
            this.lblLotNumber.Appearance.Options.UseFont = true;
            this.lblLotNumber.Appearance.Options.UseForeColor = true;
            this.lblLotNumber.Appearance.Options.UseTextOptions = true;
            this.lblLotNumber.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblLotNumber.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblLotNumber.Location = new System.Drawing.Point(3, 4);
            this.lblLotNumber.Margin = new System.Windows.Forms.Padding(4);
            this.lblLotNumber.Name = "lblLotNumber";
            this.lblLotNumber.Size = new System.Drawing.Size(1073, 95);
            this.lblLotNumber.TabIndex = 87;
            this.lblLotNumber.Text = "[LotNumber]";
            this.lblLotNumber.Click += new System.EventHandler(this.lblLotNumber_Click);
            // 
            // cntrlLot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlBack);
            this.Name = "cntrlLot";
            this.Size = new System.Drawing.Size(1082, 105);
            this.Load += new System.EventHandler(this.cntrlLot_Load);
            this.pnlBack.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBack;
        public DevExpress.XtraEditors.LabelControl lblLotNumber;
    }
}
