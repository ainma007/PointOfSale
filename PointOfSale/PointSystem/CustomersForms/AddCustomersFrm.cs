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

namespace PointSystem.CustomersForms
{
    public partial class AddCustomersFrm : RadForm
    {
        public AddCustomersFrm()
        {
            InitializeComponent();
        }

        static DataManager DbManager = new DataManager();

        private void AddCustomersFrm_Load(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                Alert.Warning("أدخل أسم العميـــل للضروره");
                return;

            }

            try
            {
                if (txtName.Text != "")
                {

                    Db.CustomersRow c = GetByName(txtName.Text);
                    Alert.Warning("موجود");
                    ClearTxt();
                    return;
                }

            }
            catch (Exception)
            {


                if (txtName.Text != "")
                {

                    // Create Account :
                    DbManager = new DataManager();
                    Db.AccountsRow CustomerAct = DbManager.ShopData.Accounts.NewAccountsRow();
                    CustomerAct.AccountName = txtName.Text;
                    CustomerAct.Description = "Customer";
                    CustomerAct.AccountCategoryID = 4;

                    DbManager.ShopData.Accounts.AddAccountsRow(CustomerAct);
                    DbManager.SaveChanges();
                    // Satrt Save 
                    DbManager = new DataManager();
                    Db.CustomersRow c = DbManager.ShopData.Customers.NewCustomersRow();
                    c.CustomerName = txtName.Text;
                    c.Address = txtAddress.Text;
                    c.Phone = txtPhone.Text;
                    c.AccountID = CustomerAct.ID;
                    c.Status = "Active";
                    DbManager.ShopData.Customers.AddCustomersRow(c);
                    DbManager.SaveChanges();

                    // Phone =====================================================

                    DbManager = new DataManager();
                    Db.PhonesRow ph = DbManager.ShopData.Phones.NewPhonesRow();
                    ph.PName = txtName.Text;
                    ph.Phone = txtPhone.Text;
                    ph.PersonID = CustomerAct.ID;
                    DbManager.ShopData.Phones.AddPhonesRow(ph);
                    DbManager.SaveChanges();


                    Alert.Information("حـــــفظ", "تـــــم الحــــــفظ بنجـــــاح");
                 
                    ClearTxt();

                }
                else
                {
                    Alert.Warning("أدخل أسم العميـــل للضروره");

                    return;
                }
            }
        }
        _Alert Alert = new _Alert();
        void ClearTxt()
        {
            txtName.Text = ""; txtAddress.Text = ""; txtPhone.Text = ""; txtName.Focus();
        }


        #region "                 "

        public List<Db.CustomersRow> GetAllCustomers()
        {
            DbManager = new DataManager();
            List<Db.CustomersRow> GetAll = DbManager.ShopData.Customers.Where(c => c.Status == "Active").ToList();

            return GetAll;
        }

    


   

        public Db.CustomersRow GetByName(string cstname)
        {
            DbManager = new DataManager();
            Db.CustomersRow c = DbManager.ShopData.Customers.Where(b => b.CustomerName == cstname && b.Status == "Active").Single();
            return c;
        }


        #endregion 

        private void AddCustomersFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Alert.Dispose();
        }


    }
}
