using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointSystem.EmployeeForms
{
  public   class EmployeesCmd
    {

        static DataManager DbManager = new DataManager();

        #region "  Searching Data     "
        public static List<Db.EmployeesRow> GetAllEmployees()
        {
            DbManager = new DataManager();

            List<Db.EmployeesRow> GetAll = (from emp
                                            in DbManager.ShopData.Employees
                                            orderby emp.EmployeeName ascending
                                            select emp).ToList();
            return GetAll;
        }

        public static Db.EmployeesRow GetById(int xid)
        {
            DbManager = new DataManager();

            Db.EmployeesRow rw = (from emp
                                  in DbManager.ShopData.Employees
                                  where emp.ID == xid
                                  select emp).Single();
            return rw;
        }
        public static Db.EmployeesRow GetByName(string empname)
        {

            DbManager = new DataManager();
            Db.EmployeesRow rw = (from emp
                                  in DbManager.ShopData.Employees
                                  where emp.EmployeeName == empname
                                  select emp).Single();
            return rw;
        }

        #endregion


        public static bool EditEmployee(Db.EmployeesRow emptb)
        {


            Db.EmployeesRow emp = DbManager.ShopData.Employees.Where(ep => ep.ID == emptb.ID).Single();

            emp.EmployeeName = emptb.EmployeeName;
            emp.Address = emptb.Address;
            emp.Phone = emptb.Phone;
            emp.Status = emptb.Status;
            emp.Salary = Convert.ToDouble(emptb.Salary);
            emp.StartWorkAt = emptb.StartWorkAt;

            DbManager.SaveChanges();
            return true;

        }
        public static Db.EmployeesRow DeleteEmployee(Db.EmployeesRow emptb)
        {

            DbManager = new DataManager();
            Db.EmployeesRow emp = DbManager.ShopData.Employees.Where(ep => ep.ID == emptb.ID).Single();
            DbManager.ShopData.Employees.RemoveEmployeesRow(emp);
            DbManager.SaveChanges();
            return emp;

        }


    }
}
