using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace slnGym.DataObject
{
    public class DetailContract
    {
        public string ConID { get; set; }

        public string ID_Mem { get; set; }
        
        public string servicePackName { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }

        public string State { get; set; } // tình trạng hợp đồng còn hay hết hạn
        public string IDreceipt { get; set; }
        public string  EmpID { get; set; }
        public decimal price { get; set; } // giá tiền cua hop đồng
        public string oldnew { get; set; } // Member mới hay cũ

    }
}
