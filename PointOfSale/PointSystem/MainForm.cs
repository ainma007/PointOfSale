using PointSystem.CustomersForms;
using PointSystem.EmployeeForms;
using PointSystem.SupplierForms;
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

namespace PointSystem
{
    public partial class MainForm : RadForm
    {
        public MainForm()
        {
            InitializeComponent();
            xHelper.SetKeyboardLanguage("ar-SA"); 

            #region "      Load Home Informations          "
            try
            {
                DbManager = new DataManager();
                InformationsClass.Home = (from c in DbManager.ShopData.Home
                                          select c).Single();

            }
            catch (Exception)
            {
            }

            #endregion 
        }

        Helper xHelper = new Helper();
        #region "      Create Main Categories For Accounts            "
        static DataManager DbManager = new DataManager();
        void CreateAccountCategories()
        {
            DbManager = new DataManager();

            List<string> LstCategoriestName = new List<string>();
            LstCategoriestName.AddRange(new string[] { "النقدية", "الأصول", "الموردين", "العملاء", "الدائنين" });

            //===============================================================================
            List<string> LstCategoriesDescription = new List<string>();
            LstCategoriesDescription.AddRange(new string[] { "النقدية", "الأصول", "الموردين", "العملاء", "الدائنين" });

            //===============================================================================
            int count = (from c in DbManager.ShopData.AccountCategories select c.ID).Count();
            if (count == 0)
            {

                for (int i = 0; i <= 4; i++)
                {

                    DbManager = new DataManager();
                    Db.AccountCategoriesRow rw = DbManager.ShopData.AccountCategories.NewAccountCategoriesRow();
                    rw.CategoryName = LstCategoriestName[i];
                    rw.Description = LstCategoriesDescription[i];
                    DbManager.ShopData.AccountCategories.AddAccountCategoriesRow(rw);
                    DbManager.SaveChanges();
                }

                AddAccounts();

            }



        }
        void AddAccounts()
        {
            DbManager = new DataManager();
            Db.AccountsRow act1 = DbManager.ShopData.Accounts.NewAccountsRow();
            act1.AccountName = "رأس المال";
            act1.Description = "حساب رأس المال";
            act1.AccountCategoryID = 1;
            DbManager.ShopData.Accounts.AddAccountsRow(act1);
            DbManager.SaveChanges();

            //=============================
            DbManager = new DataManager();
            Db.AccountsRow act2 = DbManager.ShopData.Accounts.NewAccountsRow();
            act2.AccountName = "الصندوق";
            act2.Description = "حساب الصندوق";
            act2.AccountCategoryID = 1;
            DbManager.ShopData.Accounts.AddAccountsRow(act2);
            DbManager.SaveChanges();

            //===========================
            DbManager = new DataManager();
            Db.AccountsRow act3 = DbManager.ShopData.Accounts.NewAccountsRow();
            act3.AccountName = "البنك";
            act3.Description = "حساب البنك";
            act3.AccountCategoryID = 1;
            DbManager.ShopData.Accounts.AddAccountsRow(act3);
            DbManager.SaveChanges();
            //==============================

            DbManager = new DataManager();
            Db.AccountsRow act4 = DbManager.ShopData.Accounts.NewAccountsRow();
            act4.AccountName = "المشتريات";
            act4.Description = "حساب المشتريات";
            act4.AccountCategoryID = 1;
            DbManager.ShopData.Accounts.AddAccountsRow(act4);
            DbManager.SaveChanges();

            //=============================
            DbManager = new DataManager();
            Db.AccountsRow act5 = DbManager.ShopData.Accounts.NewAccountsRow();
            act5.AccountName = "المبيعات";
            act5.Description = "حساب المبيعات";
            act5.AccountCategoryID = 1;
            DbManager.ShopData.Accounts.AddAccountsRow(act5);
            DbManager.SaveChanges();

            //===========================
            DbManager = new DataManager();
            Db.AccountsRow act6 = DbManager.ShopData.Accounts.NewAccountsRow();
            act6.AccountName = "المصروفات";
            act6.Description = "حساب المصروفات";
            act6.AccountCategoryID = 1;
            DbManager.ShopData.Accounts.AddAccountsRow(act6);
            DbManager.SaveChanges();
            //===========================
            DbManager = new DataManager();
            Db.AccountsRow act7 = DbManager.ShopData.Accounts.NewAccountsRow();
            act7.AccountName = "أوراق الدفع";
            act7.Description = "أوراق الدفع";
            act7.AccountCategoryID = 1;
            DbManager.ShopData.Accounts.AddAccountsRow(act7);
            DbManager.SaveChanges();

        }

        #endregion 
        private void MainForm_Load(object sender, EventArgs e)
        {

            CreateAccountCategories();

            Helper.EditAssetsPrice_Yearly();
        }

        private void CustomersBtn_Click(object sender, EventArgs e)
        {
            ManageCustomersFrm frm = new ManageCustomersFrm();
            frm.ShowDialog();
        }

        private void EmployeesBtn_Click(object sender, EventArgs e)
        {
            ManageEmployeeFrm frm = new ManageEmployeeFrm();
            frm.ShowDialog();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            ManageSupplierFrm frm = new ManageSupplierFrm();
            frm.ShowDialog();
        }
    }
}
