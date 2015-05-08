namespace PointSystem.CustomersForms
{
    partial class ManageCustomersFrm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCustomersFrm));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.RefreshBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.PrintBtn = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.CustomerGridView = new Telerik.WinControls.UI.RadGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddBtn,
            this.toolStripSeparator1,
            this.RefreshBtn,
            this.toolStripSeparator2,
            this.PrintBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(766, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddBtn
            // 
            this.AddBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddBtn.Image")));
            this.AddBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(54, 22);
            this.AddBtn.Text = "اضافة";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Image = ((System.Drawing.Image)(resources.GetObject("RefreshBtn.Image")));
            this.RefreshBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RefreshBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(55, 22);
            this.RefreshBtn.Text = "تحديث";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // PrintBtn
            // 
            this.PrintBtn.Image = ((System.Drawing.Image)(resources.GetObject("PrintBtn.Image")));
            this.PrintBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.PrintBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(55, 22);
            this.PrintBtn.Text = "طباعة";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 367);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(766, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.CustomerGridView);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.HeaderAlignment = Telerik.WinControls.UI.HeaderAlignment.Center;
            this.radGroupBox1.HeaderText = "بيانات الزبائن";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 25);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(766, 342);
            this.radGroupBox1.TabIndex = 2;
            this.radGroupBox1.Text = "بيانات الزبائن";
            this.radGroupBox1.ThemeName = "TelerikMetroBlue";
            // 
            // CustomerGridView
            // 
            this.CustomerGridView.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CustomerGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.CustomerGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerGridView.Font = new System.Drawing.Font("Tahoma", 8F);
            this.CustomerGridView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CustomerGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CustomerGridView.Location = new System.Drawing.Point(2, 18);
            // 
            // CustomerGridView
            // 
            this.CustomerGridView.MasterTemplate.AllowAddNewRow = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "ID";
            gridViewTextBoxColumn1.HeaderText = "الرقم";
            gridViewTextBoxColumn1.Name = "ID";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.HeaderText = "column2";
            gridViewTextBoxColumn2.Name = "column2";
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.HeaderText = "column3";
            gridViewTextBoxColumn3.Name = "column3";
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.HeaderText = "column4";
            gridViewTextBoxColumn4.Name = "column4";
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = "column5";
            gridViewCommandColumn1.Name = "column5";
            gridViewCommandColumn2.EnableExpressionEditor = false;
            gridViewCommandColumn2.HeaderText = "column6";
            gridViewCommandColumn2.Name = "column6";
            this.CustomerGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewCommandColumn1,
            gridViewCommandColumn2});
            this.CustomerGridView.Name = "CustomerGridView";
            this.CustomerGridView.ReadOnly = true;
            this.CustomerGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CustomerGridView.Size = new System.Drawing.Size(762, 322);
            this.CustomerGridView.TabIndex = 0;
            this.CustomerGridView.ThemeName = "TelerikMetroBlue";
            // 
            // ManageCustomersFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(766, 389);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ManageCustomersFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCustomersFrm";
            this.ThemeName = "TelerikMetroBlue";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
        private System.Windows.Forms.ToolStripButton AddBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton RefreshBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton PrintBtn;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGridView CustomerGridView;
    }
}