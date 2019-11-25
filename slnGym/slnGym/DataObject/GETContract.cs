using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnGym.DataObject
{
    class GETContract
    {
        public static string IDContract { get; set; }
        public static DateTime Start { get; set; }
        public static DateTime End { get; set; }
        public static int Period { get; set; }
        public static int IDPackage { get; set; }
        public static string NamePackage { get; set; }
        public static decimal Price { get; set; }
        public static string IDPT { get; set; }
        public static string NamePT { get; set; }
        public static string Remain { get; set; }
        public static List<ListContract> listContracts { get; set; }
        public static string ISRENEW { get; set; } //renew, addnew, new
    }
}