using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnGym
{
    static class GLOBAL
    {
        //Lấy ID khách hàng
        public static string IPV4 = "192.168.43.252";            //"192.168.43.252";
        public static string Port = "5588";
        public static string IDKH = "";
        public static string getID(string id)
        {
            IDKH = id;
            return IDKH;
        }
        //Lấy username
        public static string username = "";
        public static string GetUsername(string user)
        {
            username = user;
            return username;
        }

    }
}