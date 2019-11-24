using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnGym.DataObject
{
    class ListContract
    {
        public string idPT { set; get; } 
        public int idPackage { set; get; }
        public string namePackage { get; set; }
        public DateTime dateStart { set; get; }
        public DateTime dateDischarge { set; get; }
        public string status { set; get; }
        public int period { get; set; }
        public decimal price { get; set; }
        
    }
}