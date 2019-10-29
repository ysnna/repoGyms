using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnGym.DataObject
{
    class ListMachine
    {
        #region properties
        private string _name;
        private string _amount;
        private string _info;
        private Image _picture;

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

        public string Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        #endregion
        public ListMachine(string name, string info, string amount, Image image)
        {
            this.Info = info;
            this.NameMachine = name;
            this.Amount = amount;
            this.Picture = image;
        }
    }
}