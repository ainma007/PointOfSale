using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointSystem.CustomersForms
{
   public  class CustomersCmd
    {

        static DataManager DbManager = new DataManager();


        public static List<Db.CustomersRow> GetAllCustomers()
        {
            DbManager = new DataManager();
            List<Db.CustomersRow> GetAll =  DbManager.ShopData.Customers.Where (c=> c.Status == "Active").ToList ();
                                      
            return GetAll;
        }

        public static bool EditCustomer(Db.CustomersRow cst)
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


        public static Db.CustomersRow GetById(int cstid)
        {
            DbManager = new DataManager();
            Db.CustomersRow c = DbManager.ShopData.Customers.Where(b => b.ID == cstid && b.Status == "Active").Single();
            return c;
        }

        public static Db.CustomersRow GetByName(string cstname)
        {
            DbManager = new DataManager();
            Db.CustomersRow c = DbManager.ShopData.Customers.Where(b => b.CustomerName == cstname && b.Status == "Active").Single();
            return c;
        }


    }
}
