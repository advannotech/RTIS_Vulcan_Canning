namespace RTIS_Vulcan_Canning.Controls.Reprinting
{
    partial class cntrlPallet
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblItemCode = new DevExpress.XtraEditors.LabelControl();
            this.lblLotNumber = new DevExpress.XtraEditors.LabelControl();
            this.lblQty = new DevExpress.XtraEditors.LabelControl();
            this.lblCanned = new DevExpress.XtraEditors.LabelControl();
            this.lblPallet = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.04762F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.04762F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.80952F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.04762F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.04762F));
            this.tableLayoutPanel1.Controls.Add(this.lblLotNumber, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblItemCode, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblQty, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCanned, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPallet, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1120, 102);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblItemCode
            // 
            this.lblItemCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemCode.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblItemCode.Appearance.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemCode.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblItemCode.Appearance.Options.UseBackColor = true;
            this.lblItemCode.Appearance.Options.UseFont = true;
            this.lblItemCode.Appearance.Options.UseForeColor = true;
            this.lblItemCode.Appearance.Options.UseTextOptions = true;
            this.lblItemCode.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblItemCode.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblItemCode.Location = new System.Drawing.Point(5, 5);
            this.lblItemCode.Margin = new System.Windows.Forms.Padding(4);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(204, 92);
            this.lblItemCode.TabIndex = 95;
            this.lblItemCode.Text = "[ItemCode]";
            this.lblItemCode.Click += new System.EventHandler(this.lblItemCode_Click);
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
            this.lblLotNumber.Location = new System.Drawing.Point(218, 5);
            this.lblLotNumber.Margin = new System.Windows.Forms.Padding(4);
            this.lblLotNumber.Name = "lblLotNumber";
            this.lblLotNumber.Size = new System.Drawing.Size(204, 92);
            this.lblLotNumber.TabIndex = 94;
            this.lblLotNumber.Text = "[LotNumber]";
            this.lblLotNumber.Click += new System.EventHandler(this.lblLotNumber_Click);
            // 
            // lblQty
            // 
            this.lblQty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQty.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblQty.Appearance.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblQty.Appearance.Options.UseBackColor = true;
            this.lblQty.Appearance.Options.UseFont = true;
            this.lblQty.Appearance.Options.UseForeColor = true;
            this.lblQty.Appearance.Options.UseTextOptions = true;
            this.lblQty.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblQty.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblQty.Location = new System.Drawing.Point(431, 5);
            this.lblQty.Margin = new System.Windows.Forms.Padding(4);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(257, 92);
            this.lblQty.TabIndex = 93;
            this.lblQty.Text = "[Qty]";
            this.lblQty.Click += new System.EventHandler(this.lblQty_Click);
            // 
            // lblCanned
            // 
            this.lblCanned.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCanned.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblCanned.Appearance.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanned.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCanned.Appearance.Options.UseBackColor = true;
            this.lblCanned.Appearance.Options.UseFont = true;
            this.lblCanned.Appearance.Options.UseForeColor = true;
            this.lblCanned.Appearance.Options.UseTextOptions = true;
            this.lblCanned.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblCanned.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCanned.Location = new System.Drawing.Point(697, 5);
            this.lblCanned.Margin = new System.Windows.Forms.Padding(4);
            this.lblCanned.Name = "lblCanned";
            this.lblCanned.Size = new System.Drawing.Size(204, 92);
            this.lblCanned.TabIndex = 92;
            this.lblCanned.Text = "[ItemCanned]";
            this.lblCanned.Click += new System.EventHandler(this.lblCanned_Click);
            // 
            // lblPallet
            // 
            this.lblPallet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPallet.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblPallet.Appearance.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPallet.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPallet.Appearance.Options.UseBackColor = true;
            this.lblPallet.Appearance.Options.UseFont = true;
            this.lblPallet.Appearance.Options.UseForeColor = true;
            this.lblPallet.Appearance.Options.UseTextOptions = true;
            this.lblPallet.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblPallet.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblPallet.Location = new System.Drawing.Point(910, 5);
            this.lblPallet.Margin = new System.Windows.Forms.Padding(4);
            this.lblPallet.Name = "lblPallet";
            this.lblPallet.Size = new System.Drawing.Size(205, 92);
            this.lblPallet.TabIndex = 97;
            this.lblPallet.Text = "[Pallet]";
            this.lblPallet.Click += new System.EventHandler(this.lblPallet_Click);
            // 
            // cntrlPallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "cntrlPallet";
            this.Size = new System.Drawing.Size(1120, 102);
            this.Load += new System.EventHandler(this.cntrlPallet_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public DevExpress.XtraEditors.LabelControl lblItemCode;
        public DevExpress.XtraEditors.LabelControl lblLotNumber;
        public DevExpress.XtraEditors.LabelControl lblQty;
        public DevExpress.XtraEditors.LabelControl lblCanned;
        public DevExpress.XtraEditors.LabelControl lblPallet;
    }
}
