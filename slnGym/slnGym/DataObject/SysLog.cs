using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnGym.DataObject
{
    public class SysLog
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime DateLogin { get; set; }
        public DateTime? DateLogout { get; set; }
        public string Status { get; set; }

        public SysLog(string usrname, string password, DateTime datelogin, DateTime datelogout, string status)
        {
            this.UserName = usrname;
            this.Password = password;
            this.DateLogin = datelogin;
            this.DateLogout = datelogout;
            this.Status = status;
        }

        public SysLog(DataRow row)
        {
            this.UserName = row["username"].ToString();
            this.Password = row["password"].ToString();
            this.Status = row["status"].ToString();
            this.DateLogin = Convert.ToDateTime(row["loginDate"]);
            if (row["logoutDate"].ToString() != "")
                this.DateLogout = Convert.ToDateTime(row["logoutDate"]);
            else
                this.DateLogout = null;
        }
    }
}