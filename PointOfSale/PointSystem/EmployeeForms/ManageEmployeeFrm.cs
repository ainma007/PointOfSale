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

        public  List<Db.EmployeesRow> GetAllEmployees()
        {
            DbManager = new DataManager();
            List<Db.EmployeesRow> GetAll =
                                            DbManager.ShopData.Employees.Where(emp => emp.Status == "Active").ToList();
                                           
                                          
                                          
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


        public  Db.EmployeesRow GetById(int xid)
        {
            DbManager = new DataManager();

            Db.EmployeesRow rw =
                                 DbManager.ShopData.Employees.Where(emp => emp.ID == xid).Single();

            return rw;
        }
  

        private void MasterTemplate_CommandCellClick(object sender, EventArgs e)
        {
            int col = this.DgvEmployees.CurrentCell.ColumnIndex;
        

            Db.EmployeesRow rw =GetById(int.Parse(DgvEmployees.CurrentRow.Cells[0].Value.ToString()));
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
                    DeleteEmployee(rw);
                    Alert.Information("حـــــذف", "تـــــم الحــــذف");
                }

                ManageEmployeeFrm_Load(sender, e);
            }
        }

        public static Db.EmployeesRow DeleteEmployee(Db.EmployeesRow emptb)
        {

            DbManager = new DataManager();
            Db.EmployeesRow emp = DbManager.ShopData.Employees.Where(ep => ep.ID == emptb.ID).Single();
            DbManager.ShopData.Employees.RemoveEmployeesRow(emp);
            DbManager.SaveChanges();
            return emp;

        }
        
        _Alert Alert = new _Alert();

        private void ManageEmployeeFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Alert.Dispose();
        }

        private void DgvEmployees_Click(object sender, EventArgs e)
        {

        }
    }
}
