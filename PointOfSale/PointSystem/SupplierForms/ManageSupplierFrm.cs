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
    public partial class ManageSupplierFrm : RadForm
    {
        public ManageSupplierFrm()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddSupplierFrm FRM = new AddSupplierFrm();
            FRM.ShowDialog();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            PopulateDgv();
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {

        }

        static DataManager DbManager = new DataManager();
 

        void PopulateDgv()
        {
            DbManager = new DataManager();
            List<Db.SuppliersRow> AllSuppliers = DbManager.ShopData.Suppliers.ToList();
           DgvSuppliers.Rows.Clear();
            AllSuppliers.ForEach(sup =>
            {
                DgvSuppliers.Rows.Add(new string[] { sup.ID.ToString(), sup.SupplierName, sup.Phone, sup.Address, sup.AccountID.ToString() });

            });

        }

        private void ManageSupplierFrm_Load(object sender, EventArgs e)
        {

            PopulateDgv();
        }

        private void MasterTemplate_CommandCellClick(object sender, EventArgs e)
        {

            int col = this.DgvSuppliers.CurrentCell.ColumnIndex;


            Db.SuppliersRow rw = GetSupplierById(int.Parse(DgvSuppliers.CurrentRow.Cells[0].Value.ToString()));
            if (col.ToString() == "5")
            {
                EditSupplierFrm frm = new EditSupplierFrm();

                frm.TargetSupplier = rw;
                frm.ShowDialog();
            }

            if (col.ToString() == "6")
            {

                if (MessageBox.Show("هـــــل تريـــــد الحـــــذف بالفـــعل   ؟  ", "حــــــذف",
                   MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1,
                   MessageBoxOptions.RtlReading |
                   MessageBoxOptions.RightAlign) == System.Windows.Forms.DialogResult.OK)
                {
                    Db.SuppliersRow Delrw = GetSupplierById(int.Parse(DgvSuppliers.CurrentRow.Cells[0].Value.ToString()));

                    DbManager.ShopData.Suppliers.RemoveSuppliersRow(Delrw);
                    DbManager.SaveChanges();
                    _Alert.Information("حـــــذف", "تـــــم الحــــذف");
                    ManageSupplierFrm_Load(sender, e);
                }
            }
        }
        private static Db.SuppliersRow GetSupplierById(int xid)
        {

            DbManager = new DataManager();
            Db.SuppliersRow GetHim = DbManager.ShopData.Suppliers.Where(s => s.ID == xid).Single();

            return GetHim;
        }
    }
}
