using Shopping.Accounting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shopping.Employees
{
    public partial class FrmEditEmployee : Form
    {
        public FrmEditEmployee()
        {
            InitializeComponent();
        }

        static DataManager DbManager = new DataManager();
        _Alert Alert = new _Alert();
        Helper xHelper = new Helper();
 
        public Db.EmployeesRow TargetEmployee { get; set; }

        private void FrmEditEmployee_Load(object sender, EventArgs e)
        {
            txtName.Text = TargetEmployee.EmployeeName;
            txtAddess.Text = TargetEmployee.Address;
            txtPhone.Text = TargetEmployee.Phone;
            txtSalary.Text = TargetEmployee.Salary.ToString();
            WorkPicker.Text  = TargetEmployee.StartWorkAt.ToString ();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtSalary.Text == "") 
            {
                Alert .Attention ("تنبـــــيه","أدخـــــل الاســــم والراتب للضرورة");
                return; 
            }
            //===================================================================================
          
            Db.EmployeesRow x = DbManager.ShopData.Employees.NewEmployeesRow();

                    x = DbManager.ShopData.Employees.Where(c => c.ID == TargetEmployee.ID).Single();
                    x.EmployeeName = txtName.Text;
                    x.Address = txtAddess.Text;
                    x.Phone = txtPhone.Text;
                    x.Salary = Convert.ToDouble(txtSalary.Text);
                    x.StartWorkAt = WorkPicker.Value;

            DbManager.SaveChanges();
            x = null;
            //==================================================================================
          //  AccountsCmd.ChangeAccountName(TargetEmployee.AccountID, txtName.Text);
            //---------------------------------------------------------------------------------
            try
            {
            Db.PhonesRow ph = DbManager.ShopData.Phones.NewPhonesRow();
          
            ph = DbManager.ShopData.Phones.Where(p => p.PName  ==  TargetEmployee .EmployeeName  ).SingleOrDefault();
            ph.Phone = txtPhone.Text;
            ph.PName = txtName.Text;

            DbManager.SaveChanges();
            ph = null;
            }
            catch (Exception)
            {
            }
         
            //==================================================================================
            this.Hide();
        }

        #region "     TextBoxes Events      "
        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            xHelper.TextKeyPress(txtSalary, sender, e);
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            xHelper.TextKeyPressWithoutDot(txtPhone, e);
        }

        #endregion 

        private void FrmEditEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Alert.Dispose();
          
            xHelper.Dispose();
           
        }


    }
}
