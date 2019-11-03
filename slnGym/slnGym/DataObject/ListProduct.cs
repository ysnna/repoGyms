using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Data;

namespace slnGym.DataObject
{
    class ListProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public Image picture { get; set; }
        public static int Width = 425;
        public static int Height = 425;
        public ListProduct(int id, string name, decimal cost, Image pic)
        {
            this.Id = id;
            this.Name = name;
            this.Cost = cost;
            this.picture = pic;
        }
        public ListProduct(DataRow row)
        {
            this.Id = Convert.ToInt32(row["productID"]);
            this.Name = row["productName"].ToString();
            this.Cost = Convert.ToDecimal(row["productCost"].ToString());
            //byte[] picPD;
            //picPD = (byte[])row["picture"];
            //MemoryStream pic = new MemoryStream(picPD);
            //this.picture = Image.FromStream(pic);
        }
    }
}