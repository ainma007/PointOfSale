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
            List<Db.AccountsRow> GetAll = (from c in DbManager.ShopData.Accounts
                                           select c).ToList();
            return GetAll;
        }

        public static Db.AccountsRow GetAccountsByID(int actid)
        {
            Db.AccountsRow GetOne = (from c in DbManager.ShopData.Accounts
                                     where c.ID == actid
                                     select c).Single();
            return GetOne;
        }

        public static void ChangeAccountName(int AcctId, string NewName)
        {
            Db.AccountsRow act = (from a in DbManager.ShopData.Accounts
                                  where a.ID == AcctId
                                  select a).Single();
            act.AccountName = NewName;
            DbManager.SaveChanges();
        }

        public static List<Db.AccountDailyRow> GetAllDaily()
        {
            List<Db.AccountDailyRow> q = (from c in DbManager.ShopData.AccountDaily
                                          select c).ToList();
            return q;
        }
        public static List<Db.AccountDailyRow> GetAllDailyByDate(DateTime dat)
        {
            List<Db.AccountDailyRow> q = (from c in DbManager.ShopData.AccountDaily
                                          where c.TheDate == dat
                                          select c).ToList();
            return q;
        }

        public static List<Db.AccountDailyRow> GetAllDailyByID_Date(int XID, DateTime dat)
        {
            List<Db.AccountDailyRow> q = (from c in DbManager.ShopData.AccountDaily
                                          where c.TheDate == dat && c.AccountID == XID
                                          select c).ToList();
            return q;
        }

        public static List<Db.AccountDailyRow> GetAllDailyByAccountName(string AcctName)
        {
            Db.AccountsRow rw = (from c in DbManager.ShopData.Accounts
                                 where c.AccountName == AcctName
                                 select c).Single();

            List<Db.AccountDailyRow> LstDays = (from c in DbManager.ShopData.AccountDaily
                                                where c.AccountID == rw.ID
                                                select c).ToList();
            return LstDays;
        }



        public static bool NewAccount(Db.AccountsRow rw)
        {
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
            var lst = (from c in DbManager.ShopData.AccountDaily
                       where c.AccountID == AcctId
                       select c).ToList();


            double SumIn = 0;
            double SumOut = 0;
            double Balance = 0;
            foreach (var item in lst)
            {
                SumIn += item.TotalIn;
                SumOut += item.TotalOut;
            }
            Balance = Math.Round(SumIn - SumOut, 1);
            return Math.Abs(Balance);
        }


    }
}
