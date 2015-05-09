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
    public partial class AddEmployeeFrm : RadForm
    {
        public AddEmployeeFrm()
        {
            InitializeComponent();
        }

        static DataManager DbManager = new DataManager();

        public static List<Db.EmployeesRow> GetAllEmployees()
        {
            DbManager = new DataManager();
            List<Db.EmployeesRow> GetAll = DbManager.ShopData.Employees.Where(emp => emp.Status == "Active").ToList();
            return GetAll;
        }


        
 


        private void AddEmployeeFrm_Load(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "" || txtSalary.Text == "")
                {
                    _Alert.Attention("تنبـــــيه", "أدخـــــل الاســــم والراتب للضرورة");
                    return;
                }
                //============================================================
                Db.EmployeesRow emp = EmployeesCmd.GetByName(txtName.Text);
                _Alert.Attention("تنــــيه", "موجــــود بالفـعل");
                ClearTxt(); return;
            }
            catch (Exception)
            {
                DbManager = new DataManager();
                Db.EmployeesRow emp = DbManager.ShopData.Employees.NewEmployeesRow();
                emp.EmployeeName = txtName.Text;
                emp.Address = txtAddress.Text;
                emp.Phone = txtPhone.Text;
                emp.StartWorkAt = WorkPicker.Value;
                emp.Salary = Convert.ToDouble(txtSalary.Text);
              
                emp.Status = "Active";
                DbManager.ShopData.Employees.AddEmployeesRow(emp);
                DbManager.SaveChanges();
                //==================================================================
                // Phone 
                DbManager = new DataManager();
                Db.PhonesRow ph = DbManager.ShopData.Phones.NewPhonesRow();
                ph.PName = txtName.Text;
                ph.Phone = txtPhone.Text;
              
                DbManager.ShopData.Phones.AddPhonesRow(ph);
                DbManager.SaveChanges();

                //==================================================================
                _Alert.Information("حـــــــفظ", "تــم الحــــــفظ بنجــاح");

                ClearTxt();
         
            }
        }

   

        void ClearTxt()
        {
            txtAddress.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtSalary.Text = "";
           
            txtName.Focus();
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
