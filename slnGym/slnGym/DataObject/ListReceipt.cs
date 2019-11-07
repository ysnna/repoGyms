using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnGym.DataObject
{
    class ListReceipt
    {
        public int idBrand { set; get; } //idBrand
        public int idService { set; get; }
        public string name { set; get; }
        public decimal discount { set; get; }
        public decimal price { set; get; }
    }
}