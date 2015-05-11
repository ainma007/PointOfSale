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

namespace PointSystem.CustomersForms
{
    public partial class EditCustomersFrm : RadForm
    {
        public EditCustomersFrm()
        {
            InitializeComponent();
        }


        static DataManager DbManager = new DataManager();
        _Alert Alert = new _Alert();
      
        public Db.CustomersRow TargetCustomer { get; set; }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                Alert.Warning("لايجــوز ترك الاسم فارغ");
                return;
            }
            else
            {


               ChangeAccountName(TargetCustomer.AccountID, txtName.Text);
                //=====================================================================
                TargetCustomer.Address = txtAddress.Text;
                TargetCustomer.CustomerName = txtName.Text;
                TargetCustomer.Phone = txtPhone.Text;

               EditCustomer(TargetCustomer);

                //---------------------------------------------------------------------------------
                try
                {
                    DbManager = new DataManager();
                    Db.PhonesRow ph = DbManager.ShopData.Phones.NewPhonesRow();
                    ph = DbManager.ShopData.Phones.Where(p => p.PersonID == TargetCustomer.AccountID).Single();
                    ph.Phone = txtPhone.Text;
                    ph.PName = txtName.Text;
                    DbManager.SaveChanges();
                }
                catch (Exception)
                {
                }
                //==================================================================================
                this.Hide();
            }
        }

        private void EditCustomersFrm_Load(object sender, EventArgs e)
        {
            txtAddress.Text = TargetCustomer.Address;
            txtName.Text = TargetCustomer.CustomerName;
            txtPhone.Text = TargetCustomer.Phone;
        }


        public bool EditCustomer(Db.CustomersRow cst)
        {
            DbManager = new DataManager();
            Db.CustomersRow c = DbManager.ShopData.Customers.Where(b => b.ID == cst.ID && b.Status == "Active").Single();
            c.CustomerName = cst.CustomerName;
            c.Address = cst.Address;
            c.Phone = cst.Phone;
            c.Status = cst.Status;
            DbManager.SaveChanges();
            return true;
        }

        private void EditCustomersFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Alert.Dispose();
           
        }

        public void ChangeAccountName(int AcctId, string NewName)
        {
            DbManager = new DataManager();

            Db.AccountsRow act = DbManager.ShopData.Accounts.Where(a => a.ID == AcctId).Single();

            act.AccountName = NewName;
            DbManager.SaveChanges();
        }

    }
}
