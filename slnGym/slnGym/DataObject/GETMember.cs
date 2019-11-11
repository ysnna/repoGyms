using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnGym.DataObject
{
    class GETMember
    {
        public static string IDMember { get; set; }
        public static string Password { get; set; }
        public static string FName { get; set; }
        public static string LName { get; set; }
        public static int Gender { get; set; }
        public static int IDCard { get; set; }
        public static DateTime Birthday { get; set; }
        public static Image Picture { get; set; }
        public static string Phone { get; set; }
        public static string Address { get; set; }
        public static string Note = "Chờ duyệt";
    }
}