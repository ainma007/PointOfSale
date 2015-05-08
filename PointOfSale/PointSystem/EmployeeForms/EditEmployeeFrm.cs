using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace PointSystem.EmployeeForms
{
    public partial class EditEmployeeFrm : RadForm
    {
        public EditEmployeeFrm()
        {
            InitializeComponent();
        }
        static DataManager DbManager = new DataManager();
        public Db.EmployeesRow TargetEmployee { get; set; }
        private void EditEmployeeFrm_Load(object sender, EventArgs e)
        {
                    txtName.Text = TargetEmployee.EmployeeName;
                    txtAddress.Text = TargetEmployee.Address;
                    txtPhone.Text = TargetEmployee.Phone;
                    txtSalary.Text = TargetEmployee.Salary.ToString();
                    WorkPicker.Text = TargetEmployee.StartWorkAt.ToString();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtSalary.Text == "")
            {
                _Alert.Attention("تنبـــــيه", "أدخـــــل الاســــم والراتب للضرورة");
                return;
            }
            //===================================================================================
            DbManager = new DataManager();
            Db.EmployeesRow x = DbManager.ShopData.Employees.NewEmployeesRow();

                        x = DbManager.ShopData.Employees.Where(c => c.ID == TargetEmployee.ID).Single();
                        x.EmployeeName = txtName.Text;
                        x.Address = txtAddress.Text;
                        x.Phone = txtPhone.Text;
                        x.Salary = Convert.ToDouble(txtSalary.Text);
                        x.StartWorkAt = WorkPicker.Value;

            DbManager.SaveChanges();

            //==================================================================================
            //  AccountsCmd.ChangeAccountName(TargetEmployee.AccountID, txtName.Text);
            //---------------------------------------------------------------------------------
            try
            {
                Db.PhonesRow ph = DbManager.ShopData.Phones.NewPhonesRow();

                ph = DbManager.ShopData.Phones.Where(p => p.PName == TargetEmployee.EmployeeName).SingleOrDefault();
                ph.Phone = txtPhone.Text;
                ph.PName = txtName.Text;

                DbManager.SaveChanges();
            }
            catch (Exception)
            {
            }

            this.Hide();
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.TextKeyPress(txtSalary, sender, e);
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.TextKeyPressWithoutDot(txtPhone, e);
        }
    }
}
