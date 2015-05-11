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

namespace PointSystem.SupplierForms
{
    public partial class AddSupplierFrm : RadForm
    {
        public AddSupplierFrm()
        {
            InitializeComponent();
        }
        static DataManager DbManager = new DataManager();
        public int AcctId { get; set; }
        private void AddSupplierFrm_Load(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            DbManager = new DataManager();

            try
            {
                if (txtSupplierName.Text == "") { return; }
                Db.SuppliersRow GetHim = GetSupplierByName(txtSupplierName.Text);
                Alert.Attention ("موجود بالفــعل");
                return;
            }
            catch (Exception)
            {
                //====================================================================
                AcctId = 0;
                DbManager = new DataManager();
                Db.AccountsRow SupplierAct = DbManager.ShopData.Accounts.NewAccountsRow();
                    SupplierAct.AccountName = txtSupplierName.Text;
                    SupplierAct.Description = "Supplier";
                    SupplierAct.AccountCategoryID = 3;
                DbManager.ShopData.Accounts.AddAccountsRow(SupplierAct);
                DbManager.SaveChanges();
                AcctId = SupplierAct.ID;
                //====================================================================
                DbManager = new DataManager();
                Db.SuppliersRow Suplr = DbManager.ShopData.Suppliers.NewSuppliersRow();
                    Suplr.SupplierName = txtSupplierName.Text;
                    Suplr.Address = txtAddress.Text;
                    Suplr.Phone = txtPhone.Text;
                    Suplr.AccountID = AcctId;
                    Suplr.Status = "Active";
                DbManager.ShopData.Suppliers.AddSuppliersRow(Suplr);
                DbManager.SaveChanges();


                //======================================================================
                // Phone 
                DbManager = new DataManager();
                Db.PhonesRow ph = DbManager.ShopData.Phones.NewPhonesRow();

                    ph.PName = txtSupplierName.Text;
                    ph.Phone = txtPhone.Text;
                    ph.PersonID = Suplr.AccountID;

                DbManager.ShopData.Phones.AddPhonesRow(ph);
                DbManager.SaveChanges();
                Alert.Information("تــم الحــــــفظ بنجــاح");
             
            }
        }

        private static List<Db.SuppliersRow> GetAllSuppliers()
        {
            List<Db.SuppliersRow> GetAll = DbManager.ShopData.Suppliers.ToList();
            return GetAll;
        }

        private static Db.SuppliersRow GetSupplierByName(string nam)
        {
            DbManager = new DataManager();
            Db.SuppliersRow GetHim = DbManager.ShopData.Suppliers.Where(s => s.SupplierName == nam).Single();

            return GetHim;
        }

  
        void broom()
        {
            txtSupplierName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
       
            txtSupplierName.Focus();
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            xHelper.TextKeyPressWithoutDot(txtPhone, e);
        }

        private void radGroupBox1_Click(object sender, EventArgs e)
        {

        }

        Helper xHelper = new Helper();
        _Alert Alert = new _Alert();

        private void AddSupplierFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            xHelper.Dispose();
            Alert.Dispose();
        }

    

    }
}
