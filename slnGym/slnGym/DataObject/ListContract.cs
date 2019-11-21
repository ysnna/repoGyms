using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnGym.DataObject
{
    class ListContract
    {
        public int idPT { set; get; } 
        public int idPackage { set; get; }
        public string dateStart { set; get; }
        public int dateDischarge { set; get; }
        public decimal status { set; get; }
    }
}