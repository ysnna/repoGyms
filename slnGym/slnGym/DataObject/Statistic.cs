using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnGym.DataObject
{
    public class Statistic
    {
        public DateTime Date { set; get; }
        public string Group { set; get; }
        public int Amount { set; get; }
        public decimal Total { set; get; }
        public string Status { set; get; }
    }
}