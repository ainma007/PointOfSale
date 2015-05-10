namespace PointSystem.SupplierForms
{
    partial class EditSupplierFrm
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
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label supplierNameLabel;
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.SaveBtn = new Telerik.WinControls.UI.RadButton();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            addressLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            supplierNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // addressLabel
            // 
            addressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(252, 72);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(42, 13);
            addressLabel.TabIndex = 4;
            addressLabel.Text = "العنوان:";
            // 
            // phoneLabel
            // 
            phoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(249, 46);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(59, 13);
            phoneLabel.TabIndex = 2;
            phoneLabel.Text = "رقم الهاتف:";
            // 
            // supplierNameLabel
            // 
            supplierNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            supplierNameLabel.AutoSize = true;
            supplierNameLabel.Location = new System.Drawing.Point(246, 19);
            supplierNameLabel.Name = "supplierNameLabel";
            supplierNameLabel.Size = new System.Drawing.Size(63, 13);
            supplierNameLabel.TabIndex = 0;
            supplierNameLabel.Text = "اسم المورد:";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.SaveBtn);
            this.radGroupBox1.Controls.Add(addressLabel);
            this.radGroupBox1.Controls.Add(this.txtAddress);
            this.radGroupBox1.Controls.Add(phoneLabel);
            this.radGroupBox1.Controls.Add(this.txtPhone);
            this.radGroupBox1.Controls.Add(supplierNameLabel);
            this.radGroupBox1.Controls.Add(this.txtSupplierName);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(317, 174);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.ThemeName = "TelerikMetroBlue";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBtn.Location = new System.Drawing.Point(160, 111);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(110, 34);
            this.SaveBtn.TabIndex = 5;
            this.SaveBtn.Text = "حفظ";
            this.SaveBtn.ThemeName = "TelerikMetroBlue";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(19, 69);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(227, 20);
            this.txtAddress.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.Location = new System.Drawing.Point(113, 43);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(133, 20);
            this.txtPhone.TabIndex = 2;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSupplierName.Location = new System.Drawing.Point(19, 17);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(227, 20);
            this.txtSupplierName.TabIndex = 1;
            // 
            // EditSupplierFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(317, 174);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "EditSupplierFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditSupplierFrm";
            this.ThemeName = "TelerikMetroBlue";
            this.Load += new System.EventHandler(this.EditSupplierFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton SaveBtn;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtSupplierName;
        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;

    }
}