using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shopping
{
   public  class InformationsClass
    {
        public static  Db.HomeRow  Home { get; set; }
        public static Db.UsersRow  CurrentUser { get; set; }

        public static  bool IsConnected()
        {
            bool xStatus = false;
            xStatus = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
            if (xStatus == true) { xStatus = true; } else { xStatus = false; } return xStatus;
        }


    }



}
