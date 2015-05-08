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

namespace PointSystem.EmployeeForms
{
    public partial class ManageEmployeeFrm : RadForm
    {
        public ManageEmployeeFrm()
        {
            InitializeComponent();
        }
        static DataManager DbManager = new DataManager();

        public static List<Db.EmployeesRow> GetAllEmployees()
        {
            DbManager = new DataManager();
            List<Db.EmployeesRow> GetAll = (from emp
                                            in DbManager.ShopData.Employees
                                            orderby emp.EmployeeName ascending
                                            where emp.Status == "Active"
                                            select emp).ToList();
            return GetAll;
        }


        void PopulaetDgv()
        {
            DbManager = new DataManager();
            List<Db.EmployeesRow> LstEmployeess = GetAllEmployees();


            DgvEmployees.Rows.Clear();
            LstEmployeess.ForEach(emp => { 
                            DgvEmployees.Rows.Add(
                                emp.ID.ToString(),
                                emp.EmployeeName,
                                emp.Address,
                                emp.Phone,
                                emp.Salary.ToString(),
                                emp.StartWorkAt.ToShortDateString()

                    );
            });
           
            
        }
 
        private void ManageEmployeeFrm_Load(object sender, EventArgs e)
        {
            PopulaetDgv();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddEmployeeFrm frm = new AddEmployeeFrm();
            frm.ShowDialog();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            ManageEmployeeFrm_Load(sender, e);
        }

        private void MasterTemplate_CommandCellClick(object sender, EventArgs e)
        {
            int col = this.DgvEmployees.CurrentCell.ColumnIndex;
        

            Db.EmployeesRow rw = EmployeesCmd.GetById(int.Parse(DgvEmployees.CurrentRow.Cells[0].Value.ToString()));
            if (col.ToString() == "6")
            {
                EditEmployeeFrm frm = new EditEmployeeFrm();

                frm.TargetEmployee = rw;
                frm.ShowDialog();
            }

            if (col.ToString() == "7")
            {

                if (MessageBox.Show("هـــــل تريـــــد الحـــــذف بالفـــعل   ؟  ", "حــــــذف",
                   MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1,
                   MessageBoxOptions.RtlReading |
                   MessageBoxOptions.RightAlign) == System.Windows.Forms.DialogResult.OK)
                {
                    EmployeesCmd.DeleteEmployee(rw);
                    _Alert.Information("حـــــذف", "تـــــم الحــــذف");
                }

                ManageEmployeeFrm_Load(sender, e);
            }
        }
    }
}
