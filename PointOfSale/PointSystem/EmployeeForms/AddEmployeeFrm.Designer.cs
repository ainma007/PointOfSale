namespace PointSystem.EmployeeForms
{
    partial class AddEmployeeFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.EmployeeAdresstextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EmployeeSalarytextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmployeNametextBox = new System.Windows.Forms.TextBox();
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.EmployeeStartDateTimePicker = new Telerik.WinControls.UI.RadDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeStartDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم الموظف:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "تاريخ العمل:";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.EmployeeStartDateTimePicker);
            this.radGroupBox1.Controls.Add(this.AddBtn);
            this.radGroupBox1.Controls.Add(this.EmployeeAdresstextBox);
            this.radGroupBox1.Controls.Add(this.label4);
            this.radGroupBox1.Controls.Add(this.EmployeeSalarytextBox);
            this.radGroupBox1.Controls.Add(this.label3);
            this.radGroupBox1.Controls.Add(this.EmployeNametextBox);
            this.radGroupBox1.Controls.Add(this.label2);
            this.radGroupBox1.Controls.Add(this.label1);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderAlignment = Telerik.WinControls.UI.HeaderAlignment.Center;
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(335, 185);
            this.radGroupBox1.TabIndex = 2;
            this.radGroupBox1.ThemeName = "TelerikMetroBlue";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(219, 141);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(110, 34);
            this.AddBtn.TabIndex = 5;
            this.AddBtn.Text = "اضافة";
            this.AddBtn.ThemeName = "Office2013Light";
            // 
            // EmployeeAdresstextBox
            // 
            this.EmployeeAdresstextBox.Location = new System.Drawing.Point(12, 104);
            this.EmployeeAdresstextBox.Name = "EmployeeAdresstextBox";
            this.EmployeeAdresstextBox.Size = new System.Drawing.Size(246, 20);
            this.EmployeeAdresstextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "العنوان:";
            // 
            // EmployeeSalarytextBox
            // 
            this.EmployeeSalarytextBox.Location = new System.Drawing.Point(166, 77);
            this.EmployeeSalarytextBox.Name = "EmployeeSalarytextBox";
            this.EmployeeSalarytextBox.Size = new System.Drawing.Size(92, 20);
            this.EmployeeSalarytextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "الراتب:";
            // 
            // EmployeNametextBox
            // 
            this.EmployeNametextBox.Location = new System.Drawing.Point(12, 19);
            this.EmployeNametextBox.Name = "EmployeNametextBox";
            this.EmployeNametextBox.Size = new System.Drawing.Size(246, 20);
            this.EmployeNametextBox.TabIndex = 1;
            // 
            // EmployeeStartDateTimePicker
            // 
            this.EmployeeStartDateTimePicker.CustomFormat = "";
            this.EmployeeStartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EmployeeStartDateTimePicker.Location = new System.Drawing.Point(167, 47);
            this.EmployeeStartDateTimePicker.Name = "EmployeeStartDateTimePicker";
            this.EmployeeStartDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EmployeeStartDateTimePicker.Size = new System.Drawing.Size(91, 21);
            this.EmployeeStartDateTimePicker.TabIndex = 3;
            this.EmployeeStartDateTimePicker.TabStop = false;
            this.EmployeeStartDateTimePicker.Text = "08/05/2015";
            this.EmployeeStartDateTimePicker.ThemeName = "Office2013Light";
            this.EmployeeStartDateTimePicker.Value = new System.DateTime(2015, 5, 8, 17, 39, 6, 429);
            // 
            // AddEmployeeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(335, 185);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "AddEmployeeFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEmployeeFrm";
            this.ThemeName = "TelerikMetroBlue";
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeStartDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
        private Telerik.WinControls.UI.RadButton AddBtn;
        private System.Windows.Forms.TextBox EmployeeAdresstextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EmployeeSalarytextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EmployeNametextBox;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
        private Telerik.WinControls.UI.RadDateTimePicker EmployeeStartDateTimePicker;
    }
}