using Shopping.Accounting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shopping.Customers
{
    public partial class FrmEditCustomers : Form
    {
        public FrmEditCustomers()
        {
            InitializeComponent();
        }
        static DataManager DbManager = new DataManager();
        Helper xHelper = new Helper();
        _Alert Alert = new _Alert();

        public void ChangeAccountName(int AcctId, string NewName)
        {
            Db.AccountsRow act = DbManager.ShopData.Accounts.Where(c => c.ID == AcctId).Single();

            act.AccountName = NewName;
            DbManager.SaveChanges();
        }



       
        public Db.CustomersRow TargetCustomer { get; set; }
        private void FrmEditCustomers_Load(object sender, EventArgs e)
        {
            txtAddress.Text = TargetCustomer.Address;
            txtName.Text = TargetCustomer.CustomerName;
            txtPhone.Text = TargetCustomer.Phone;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
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
                


                Db.CustomersRow c = DbManager.ShopData.Customers.Where(b => b.ID == TargetCustomer .ID  ).Single();
                c.Address = txtAddress.Text;
                c.CustomerName = txtName.Text;
                c.Phone = txtPhone.Text;
                DbManager.SaveChanges();



      

                //---------------------------------------------------------------------------------
                try
                {
             
                Db.PhonesRow ph = DbManager.ShopData.Phones.NewPhonesRow();
                ph = DbManager.ShopData.Phones.Where(p => p.PersonID == TargetCustomer .AccountID  ).Single();
                ph.Phone = txtPhone.Text;
                ph.PName = txtName.Text;
                DbManager.SaveChanges();
                }
                catch (Exception)
                {
                }
               
                this.Hide();
            }
        }


        public bool EditCustomer(Db.CustomersRow cst)
        {
          
            Db.CustomersRow c = DbManager.ShopData.Customers.Where(b => b.ID == cst.ID && b.Status == "Active").Single();
            c.CustomerName = cst.CustomerName;
            c.Address = cst.Address;
            c.Phone = cst.Phone;
            c.Status = cst.Status;
            DbManager.SaveChanges();
            return true;
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            xHelper.TextKeyPressWithoutDot(txtPhone, e);
        }

        private void FrmEditCustomers_FormClosing(object sender, FormClosingEventArgs e)
        {
            Alert.Dispose();
        
            xHelper.Dispose();
       

        }


    }
}
