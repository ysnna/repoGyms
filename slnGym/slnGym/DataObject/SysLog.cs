using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnGym.DataObject
{
    public class SysLOG
    {
        public static string UserName = "";
        public static string Password = "";
        public static string DateLogin = "";
        public static string DateLogout = "";
        public static string Status = "";
        public static bool Online = false;

        public SysLOG(string usrname, string password, string datelogin, string datelogout, string status)
        {
            UserName = usrname;
            Password = password;
            DateLogin = datelogin;
            DateLogout = datelogout;
            Status = status;
        }
    }
}