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

        public Db.CustomersRow TargetCustomer { get; set; }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                _Alert.Warning("لايجــوز ترك الاسم فارغ");
                return;
            }
            else
            {


                AccountsCmd.ChangeAccountName(TargetCustomer.AccountID, txtName.Text);
                //=====================================================================
                TargetCustomer.Address = txtAddress.Text;
                TargetCustomer.CustomerName = txtName.Text;
                TargetCustomer.Phone = txtPhone.Text;

                CustomersCmd.EditCustomer(TargetCustomer);

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
    }
}
