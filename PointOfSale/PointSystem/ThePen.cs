using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointSystem
{
   public  class ThePen
    {

        static DataManager DbManager = new DataManager();
        public static void Writer(string action, int Debit, int Cridet, double amunt, string descrip)
        {

            #region "  ^^^^  AccountDaily   الدفتـــر الاســـــتاذ "
            // ----
            DbManager = new DataManager();
            Db.AccountDailyRow ActOut = DbManager.ShopData.AccountDaily.NewAccountDailyRow();

            ActOut.Action = action;
            ActOut.TotalIn = amunt; ;
            ActOut.TotalOut = 0f;
            ActOut.TheDate = DateTime.Now;
            ActOut.Monthly = DateTime.Now.Month + "/" + DateTime.Now.Year;
            ActOut.Yearly = DateTime.Now.Year.ToString();
            ActOut.AccountID = Debit;

            DbManager.ShopData.AccountDaily.AddAccountDailyRow(ActOut);
            DbManager.SaveChanges();
            //==============
            //---
            DbManager = new DataManager();
            Db.AccountDailyRow ActIn = DbManager.ShopData.AccountDaily.NewAccountDailyRow();

            ActIn.Action = action;
            ActIn.TotalIn = 0f;
            ActIn.TotalOut = amunt;
            ActIn.TheDate = DateTime.Now;
            ActIn.Monthly = DateTime.Now.Month + "/" + DateTime.Now.Year;
            ActIn.Yearly = DateTime.Now.Year.ToString();
            ActIn.AccountID = Cridet;

            DbManager.ShopData.AccountDaily.AddAccountDailyRow(ActIn);
            DbManager.SaveChanges();

            #endregion

            #region "   ^^^^^ DayNote   دفتــــر اليـــــــوميه   "

            DbManager = new DataManager();
            Db.DayNoteRow Dy = DbManager.ShopData.DayNote.NewDayNoteRow();

            Dy.Action = action;
            Dy.FromAccount = Debit;
            Dy.ToAccount = Cridet;
            Dy.Total = amunt;
            Dy.Description = descrip;
            Dy.DateOfProcess = DateTime.Now;

            DbManager.ShopData.DayNote.AddDayNoteRow(Dy);
            DbManager.SaveChanges();

            #endregion
        }


        ~ThePen() { }
        public void Dispose()
        {
            GC.SuppressFinalize(this);

        }



    }
}
