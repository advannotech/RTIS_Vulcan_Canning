namespace RTIS_Vulcan_Canning.Controls.Printing
{
    partial class cntrlProduct
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblItemDesc = new DevExpress.XtraEditors.LabelControl();
            this.lblItemCode = new DevExpress.XtraEditors.LabelControl();
            this.pnlBack.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBack
            // 
            this.pnlBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBack.Controls.Add(this.tlpMain);
            this.pnlBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBack.Location = new System.Drawing.Point(0, 0);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(1082, 105);
            this.pnlBack.TabIndex = 0;
            // 
            // tlpMain
            // 
            this.tlpMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.lblItemDesc, 0, 0);
            this.tlpMain.Controls.Add(this.lblItemCode, 0, 0);
            this.tlpMain.Location = new System.Drawing.Point(4, 4);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Size = new System.Drawing.Size(1073, 98);
            this.tlpMain.TabIndex = 0;
            // 
            // lblItemDesc
            // 
            this.lblItemDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemDesc.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblItemDesc.Appearance.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemDesc.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblItemDesc.Appearance.Options.UseBackColor = true;
            this.lblItemDesc.Appearance.Options.UseFont = true;
            this.lblItemDesc.Appearance.Options.UseForeColor = true;
            this.lblItemDesc.Appearance.Options.UseTextOptions = true;
            this.lblItemDesc.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblItemDesc.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblItemDesc.Location = new System.Drawing.Point(540, 4);
            this.lblItemDesc.Margin = new System.Windows.Forms.Padding(4);
            this.lblItemDesc.Name = "lblItemDesc";
            this.lblItemDesc.Size = new System.Drawing.Size(529, 90);
            this.lblItemDesc.TabIndex = 87;
            this.lblItemDesc.Text = "[Desc]";
            this.lblItemDesc.Click += new System.EventHandler(this.lblItemDesc_Click);
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
            this.lblItemCode.Location = new System.Drawing.Point(4, 4);
            this.lblItemCode.Margin = new System.Windows.Forms.Padding(4);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(528, 90);
            this.lblItemCode.TabIndex = 86;
            this.lblItemCode.Text = "[Code]";
            this.lblItemCode.Click += new System.EventHandler(this.lblItemCode_Click);
            // 
            // cntrlProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlBack);
            this.Name = "cntrlProduct";
            this.Size = new System.Drawing.Size(1082, 105);
            this.Load += new System.EventHandler(this.cntrlProduct_Load);
            this.pnlBack.ResumeLayout(false);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBack;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        public DevExpress.XtraEditors.LabelControl lblItemDesc;
        public DevExpress.XtraEditors.LabelControl lblItemCode;
    }
}
