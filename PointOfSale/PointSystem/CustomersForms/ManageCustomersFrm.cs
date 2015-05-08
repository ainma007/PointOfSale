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
                                                                                  });
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

        private void MasterTemplate_CommandCellClick(object sender, EventArgs e)
        {
            int col = this.DgvCustomers.CurrentCell.ColumnIndex;
            // int row = this.DgvUsers.CurrentCell.RowIndex;

            Db.CustomersRow rw = CustomersCmd.GetById(int.Parse(DgvCustomers.CurrentRow.Cells[0].Value.ToString()));

            if (col.ToString() == "4")
            {

                EditCustomersFrm frm = new EditCustomersFrm();

                frm.TargetCustomer = rw;
                frm.ShowDialog();
            }

            if (col.ToString() == "5")
            {


                if (MessageBox.Show("هـــــل تريـــــد الحـــــذف بالفـــعل   ؟  ", "حــــــذف",
                  MessageBoxButtons.OKCancel,
                  MessageBoxIcon.Question,
                  MessageBoxDefaultButton.Button1,
                  MessageBoxOptions.RtlReading |
                  MessageBoxOptions.RightAlign) == System.Windows.Forms.DialogResult.OK)
                {

                    Db.CustomersRow c = DbManager.ShopData.Customers.Where(b => b.ID == rw.ID).Single();
                    //   c.Status = "DisActive";
                    DbManager.ShopData.Customers.RemoveCustomersRow(c);
                    DbManager.SaveChanges();
                    _Alert.Information("حـــــذف", "تـــــم الحــــذف");
                   
                    PopulateDgv();
                }
            }
        }
    }
}
