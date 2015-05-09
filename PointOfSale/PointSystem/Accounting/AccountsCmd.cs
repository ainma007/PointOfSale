using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointSystem.Accounting
{
    public class AccountsCmd
    {


        static DataManager DbManager = new DataManager();

        public static List<Db.AccountsRow> GetAllAccounts()
        {
            DbManager = new DataManager();
            List<Db.AccountsRow> GetAll = DbManager.ShopData.Accounts.ToList();
                                         
            return GetAll;
        }

        public static Db.AccountsRow GetAccountsByID(int actid)
        {
            DbManager = new DataManager();

            Db.AccountsRow GetOne =  DbManager.ShopData.Accounts.Where (c=> c.ID == actid).Single ();
                                  
            return GetOne;
        }

        public static void ChangeAccountName(int AcctId, string NewName)
        {
            DbManager = new DataManager();

            Db.AccountsRow act = DbManager.ShopData.Accounts.Where (a=> a.ID == AcctId).Single ();
                             
            act.AccountName = NewName;
            DbManager.SaveChanges();
        }

        public static List<Db.AccountDailyRow> GetAllDaily()
        {
            DbManager = new DataManager();
            List<Db.AccountDailyRow> q = DbManager.ShopData.AccountDaily.ToList();
                                         
            return q;
        }
        public static List<Db.AccountDailyRow> GetAllDailyByDate(DateTime dat)
        {
            DbManager = new DataManager();
            List<Db.AccountDailyRow> q = DbManager.ShopData.AccountDaily.Where (c=> c.TheDate == dat).ToList ();
                                     
            return q;
        }

        public static List<Db.AccountDailyRow> GetAllDailyByID_Date(int XID, DateTime dat)
        {

            DbManager = new DataManager();
            List<Db.AccountDailyRow> q = DbManager.ShopData.AccountDaily.Where (c=> c.TheDate == dat && c.AccountID == XID).ToList ();
                                       
            return q;
        }

        public static List<Db.AccountDailyRow> GetAllDailyByAccountName(string AcctName)
        {

            DbManager = new DataManager();
            Db.AccountsRow rw =  DbManager.ShopData.Accounts.Where (c=> c.AccountName == AcctName).Single ();
                               

            List<Db.AccountDailyRow> LstDays = DbManager.ShopData.AccountDaily.Where (c=> c.AccountID == rw.ID).ToList ();
                                               
            return LstDays;
        }



        public static bool NewAccount(Db.AccountsRow rw)
        {
            DbManager = new DataManager();
            Db.AccountsRow CustomerAct = DbManager.ShopData.Accounts.NewAccountsRow();
            CustomerAct.AccountName = rw.AccountName;
            CustomerAct.Description = rw.Description;
            CustomerAct.AccountCategoryID = rw.AccountCategoryID;
            DbManager.ShopData.Accounts.AddAccountsRow(CustomerAct);
            DbManager.SaveChanges();
            return true;

        }

        public static double Balance(int AcctId)
        {

            DbManager = new DataManager();
            List<Db.AccountDailyRow> lst = DbManager.ShopData.AccountDaily.Where(c => c.AccountID == AcctId).ToList();
                   
            double SumIn = 0;
            double SumOut = 0;
            double Balance = 0;

            lst.ForEach(item => { SumIn += item.TotalIn; SumOut += item.TotalOut; });
     
            Balance = Math.Round(SumIn - SumOut, 1);
            return Math.Abs(Balance);
        }


    }
}
