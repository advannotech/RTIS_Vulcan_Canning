namespace RTIS_Vulcan_Canning.Controls.Reprinting
{
    partial class ucSelectPallet
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
            this.components = new System.ComponentModel.Container();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.pnlParent = new System.Windows.Forms.Panel();
            this.tblHeader = new System.Windows.Forms.TableLayoutPanel();
            this.lblLotNumber = new DevExpress.XtraEditors.LabelControl();
            this.lblItemCode = new DevExpress.XtraEditors.LabelControl();
            this.lblQty = new DevExpress.XtraEditors.LabelControl();
            this.lblCanned = new DevExpress.XtraEditors.LabelControl();
            this.lblPallet = new DevExpress.XtraEditors.LabelControl();
            this.pnlItems = new System.Windows.Forms.Panel();
            this.vsbFG = new DevExpress.XtraEditors.VScrollBar();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.tmrItems = new System.Windows.Forms.Timer(this.components);
            this.ppnlWait = new DevExpress.XtraWaitForm.ProgressPanel();
            this.pnlParent.SuspendLayout();
            this.tblHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl13
            // 
            this.labelControl13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Appearance.Options.UseForeColor = true;
            this.labelControl13.Appearance.Options.UseTextOptions = true;
            this.labelControl13.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl13.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl13.Location = new System.Drawing.Point(4, 4);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(1217, 100);
            this.labelControl13.TabIndex = 108;
            this.labelControl13.Text = "Select Item Pallet to Reprint";
            // 
            // pnlParent
            // 
            this.pnlParent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlParent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlParent.Controls.Add(this.pnlItems);
            this.pnlParent.Controls.Add(this.vsbFG);
            this.pnlParent.Location = new System.Drawing.Point(6, 187);
            this.pnlParent.Name = "pnlParent";
            this.pnlParent.Size = new System.Drawing.Size(1210, 551);
            this.pnlParent.TabIndex = 109;
            // 
            // tblHeader
            // 
            this.tblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblHeader.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblHeader.ColumnCount = 5;
            this.tblHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.04762F));
            this.tblHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.04762F));
            this.tblHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.80952F));
            this.tblHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.04762F));
            this.tblHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.04762F));
            this.tblHeader.Controls.Add(this.lblLotNumber, 1, 0);
            this.tblHeader.Controls.Add(this.lblItemCode, 0, 0);
            this.tblHeader.Controls.Add(this.lblQty, 2, 0);
            this.tblHeader.Controls.Add(this.lblCanned, 3, 0);
            this.tblHeader.Controls.Add(this.lblPallet, 4, 0);
            this.tblHeader.Location = new System.Drawing.Point(6, 93);
            this.tblHeader.Name = "tblHeader";
            this.tblHeader.RowCount = 1;
            this.tblHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tblHeader.Size = new System.Drawing.Size(1113, 94);
            this.tblHeader.TabIndex = 86;
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
            this.lblLotNumber.Location = new System.Drawing.Point(216, 5);
            this.lblLotNumber.Margin = new System.Windows.Forms.Padding(4);
            this.lblLotNumber.Name = "lblLotNumber";
            this.lblLotNumber.Size = new System.Drawing.Size(202, 84);
            this.lblLotNumber.TabIndex = 94;
            this.lblLotNumber.Text = "Lot Number";
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
            this.lblItemCode.Size = new System.Drawing.Size(202, 84);
            this.lblItemCode.TabIndex = 95;
            this.lblItemCode.Text = "Item Code";
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
            this.lblQty.Location = new System.Drawing.Point(427, 5);
            this.lblQty.Margin = new System.Windows.Forms.Padding(4);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(255, 84);
            this.lblQty.TabIndex = 93;
            this.lblQty.Text = "Qty";
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
            this.lblCanned.Location = new System.Drawing.Point(691, 5);
            this.lblCanned.Margin = new System.Windows.Forms.Padding(4);
            this.lblCanned.Name = "lblCanned";
            this.lblCanned.Size = new System.Drawing.Size(202, 84);
            this.lblCanned.TabIndex = 92;
            this.lblCanned.Text = "Item Canned";
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
            this.lblPallet.Location = new System.Drawing.Point(902, 5);
            this.lblPallet.Margin = new System.Windows.Forms.Padding(4);
            this.lblPallet.Name = "lblPallet";
            this.lblPallet.Size = new System.Drawing.Size(206, 84);
            this.lblPallet.TabIndex = 97;
            this.lblPallet.Text = "Pallet Used";
            // 
            // pnlItems
            // 
            this.pnlItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlItems.AutoSize = true;
            this.pnlItems.Location = new System.Drawing.Point(3, 5);
            this.pnlItems.Name = "pnlItems";
            this.pnlItems.Size = new System.Drawing.Size(1109, 541);
            this.pnlItems.TabIndex = 85;
            // 
            // vsbFG
            // 
            this.vsbFG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vsbFG.Location = new System.Drawing.Point(1119, 4);
            this.vsbFG.Margin = new System.Windows.Forms.Padding(4);
            this.vsbFG.Name = "vsbFG";
            this.vsbFG.Opacity = 1F;
            this.vsbFG.Size = new System.Drawing.Size(89, 545);
            this.vsbFG.TabIndex = 1;
            this.vsbFG.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbFG_Scroll);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.Appearance.BackColor = System.Drawing.Color.Teal;
            this.btnBack.Appearance.Font = new System.Drawing.Font("Calibri", 18F);
            this.btnBack.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnBack.Appearance.Options.UseBackColor = true;
            this.btnBack.Appearance.Options.UseFont = true;
            this.btnBack.Appearance.Options.UseForeColor = true;
            this.btnBack.Location = new System.Drawing.Point(6, 745);
            this.btnBack.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnBack.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnBack.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(222, 101);
            this.btnBack.TabIndex = 111;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Appearance.BackColor = System.Drawing.Color.Teal;
            this.btnNext.Appearance.Font = new System.Drawing.Font("Calibri", 18F);
            this.btnNext.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnNext.Appearance.Options.UseBackColor = true;
            this.btnNext.Appearance.Options.UseFont = true;
            this.btnNext.Appearance.Options.UseForeColor = true;
            this.btnNext.Location = new System.Drawing.Point(993, 745);
            this.btnNext.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnNext.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnNext.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(222, 101);
            this.btnNext.TabIndex = 112;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tmrItems
            // 
            this.tmrItems.Tick += new System.EventHandler(this.tmrItems_Tick);
            // 
            // ppnlWait
            // 
            this.ppnlWait.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ppnlWait.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ppnlWait.Appearance.Options.UseBackColor = true;
            this.ppnlWait.AppearanceCaption.Options.UseTextOptions = true;
            this.ppnlWait.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ppnlWait.BarAnimationElementThickness = 2;
            this.ppnlWait.Caption = "";
            this.ppnlWait.Description = "";
            this.ppnlWait.Location = new System.Drawing.Point(0, 0);
            this.ppnlWait.Margin = new System.Windows.Forms.Padding(4);
            this.ppnlWait.Name = "ppnlWait";
            this.ppnlWait.Size = new System.Drawing.Size(1225, 862);
            this.ppnlWait.TabIndex = 113;
            this.ppnlWait.Text = "progressPanel1";
            this.ppnlWait.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Line;
            this.ppnlWait.Click += new System.EventHandler(this.ppnlWait_Click);
            // 
            // ucSelectPallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tblHeader);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlParent);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.ppnlWait);
            this.Name = "ucSelectPallet";
            this.Size = new System.Drawing.Size(1225, 866);
            this.Load += new System.EventHandler(this.ucSelectPallet_Load);
            this.pnlParent.ResumeLayout(false);
            this.pnlParent.PerformLayout();
            this.tblHeader.ResumeLayout(false);
            this.tblHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl13;
        private System.Windows.Forms.Panel pnlParent;
        public System.Windows.Forms.Panel pnlItems;
        private DevExpress.XtraEditors.VScrollBar vsbFG;
        internal DevExpress.XtraEditors.SimpleButton btnBack;
        internal DevExpress.XtraEditors.SimpleButton btnNext;
        private System.Windows.Forms.TableLayoutPanel tblHeader;
        public DevExpress.XtraEditors.LabelControl lblLotNumber;
        public DevExpress.XtraEditors.LabelControl lblItemCode;
        public DevExpress.XtraEditors.LabelControl lblQty;
        public DevExpress.XtraEditors.LabelControl lblCanned;
        public DevExpress.XtraEditors.LabelControl lblPallet;
        private System.Windows.Forms.Timer tmrItems;
        private DevExpress.XtraWaitForm.ProgressPanel ppnlWait;
    }
}
