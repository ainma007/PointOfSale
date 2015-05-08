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
    public partial class ManageCustomersFrm : RadForm
    {
        public ManageCustomersFrm()
        {
            InitializeComponent();
        }


        static DataManager DbManager = new DataManager();
        void PopulateDgv()
        {
            DbManager = new DataManager();

            DgvCustomers.DataSource = null;
            List<Db.CustomersRow> LstCustomers = DbManager.ShopData.Customers.ToList();

            DgvCustomers.Rows.Clear();

                 LstCustomers.ForEach(cst =>
                        {
                            DgvCustomers.Rows.Add(new string[]{  cst.ID.ToString(),
                                                                     cst.CustomerName,
                                                                          cst.Address, 
                                                                               cst.Phone,
                                                                                  cst.AccountID.ToString()  });
                        });

        }



        private void ManageCustomersFrm_Load(object sender, EventArgs e)
        {
            PopulateDgv();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddCustomersFrm frm = new AddCustomersFrm();
            frm.ShowDialog();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            ManageCustomersFrm_Load(sender, e);
        }
    }
}
