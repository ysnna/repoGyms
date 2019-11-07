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
        public static string UserName { get; set; }
        public static string Password { get; set; }
        public static DateTime DateLogin { get; set; }
        public static string DateLogout = "";
        public static string Status = "";
        public static bool Online = false;

        public SysLOG(string usrname, string password, DateTime datelogin, string datelogout, string status)
        {
            UserName = usrname;
            Password = password;
            DateLogin = datelogin;
            DateLogout = datelogout;
            Status = status;
        }

        public SysLOG(DataRow row)
        {
            UserName = row["username"].ToString();
            Password = row["password"].ToString();
            Status = row["status"].ToString();
            DateLogin = Convert.ToDateTime(row["loginDate"]);
            if (row["logoutDate"].ToString() != "")
                DateLogout = row["logoutDate"].ToString();
            else
                DateLogout = null;
        }
    }
}