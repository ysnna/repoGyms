using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnGym.DataObject
{
    class ListMachine
    {
        #region properties
        private string _name;
        private int _amount;
        private string _info;
        private Image _picture;
        public static int Width = 425;
        public static int Height = 425;
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public Image Picture
        {
            get { return _picture; }
            set { _picture = value; }
        }

        public string Info
        {
            get { return _info; }
            set { _info = value; }
        }

        public string NameMachine
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        #endregion
        public ListMachine(int id, string name, string info, int amount, Image image)
        {
            this.ID = id;
            this.Info = info;
            this.NameMachine = name;
            this.Amount = amount;
            this.Picture = image;
        }
        public ListMachine(DataRow row)
        {
            this.ID= Convert.ToInt32(row["macID"]);
            this.Amount = Convert.ToInt32(row["amount"]);
            this.Info = row["infor"].ToString();
            this.NameMachine = row["macName"].ToString();
            byte[] picPD;
            picPD = (byte[])row["picture"];
            MemoryStream pic = new MemoryStream(picPD);
            this.Picture = Image.FromStream(pic);
        }
    }
}