using PointSystem.Accounting;
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
    public partial class EditSupplierFrm : RadForm
    {
        public EditSupplierFrm()
        {
            InitializeComponent();
        }
        public Db.SuppliersRow TargetSupplier { get; set; }
        static DataManager DbManager = new DataManager();
        private void EditSupplierFrm_Load(object sender, EventArgs e)
        {
            txtSupplierName.Text = TargetSupplier.SupplierName;
            txtAddress.Text = TargetSupplier.Address;
            txtPhone.Text = TargetSupplier.Phone;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (txtSupplierName.Text == "")
            {
                MessageBox.Show("لا يجوز ترك الاسم فارغ", "تنبيه");
                return;
            }


            AccountsCmd.ChangeAccountName(TargetSupplier.AccountID, txtSupplierName.Text);

            TargetSupplier.SupplierName = txtSupplierName.Text;
            TargetSupplier.Address = txtAddress.Text;
            TargetSupplier.Phone = txtPhone.Text;
            EditSupplier(TargetSupplier);

            //=======================================================
            try
            {
                // Edit Phone 
                DbManager = new DataManager();
                Db.PhonesRow ph = DbManager.ShopData.Phones.NewPhonesRow();

                ph = DbManager.ShopData.Phones.Where(i => i.PersonID == TargetSupplier.AccountID).Single();

                ph.PName = txtSupplierName.Text;
                ph.Phone = txtPhone.Text;
                DbManager.SaveChanges();
            }
            catch (Exception)
            {
            }
          

            AccountsCmd.ChangeAccountName(TargetSupplier.AccountID, txtSupplierName.Text);



            _Alert.Information("تــم الحــــــفظ بنجــاح");
      
            this.Hide();
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.TextKeyPress(txtPhone , sender , e) ;
        }

        private static bool EditSupplier(Db.SuppliersRow sup)
        {
            DbManager = new DataManager();
            Db.SuppliersRow Rw = DbManager.ShopData.Suppliers.NewSuppliersRow();

                    Rw = DbManager.ShopData.Suppliers.Where(u => u.ID == sup.ID).Single();
                    Rw.SupplierName = sup.SupplierName;
                    Rw.Address = sup.Address;
                    Rw.Phone = sup.Phone;

            DbManager.SaveChanges();
            return true;
        }

    }
}
