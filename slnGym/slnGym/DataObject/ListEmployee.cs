using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnGym.DataObject
{
    class ListEmployee
    {
        #region PROPERTIES
        private string _fname;
        private string _lname;
        private string _bdate;
        private string _phone;
        private string _address;
        private string _idcard;
        private string _group;
        private string _salary;
        private string _gender;
        private Image _ava;
        private string _id;
        public string Password { get; set; }

        public string EmployeeID
        {
            get { return _id; }
            set { _id = value; }
        }

        public Image Ava
        {
            get { return _ava; }
            set { _ava = value; }
        }

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public string Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public string Group
        {
            get { return _group; }
            set { _group = value; }
        }

        public string IDCard
        {
            get { return _idcard; }
            set { _idcard = value; }
        }


        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string BDate
        {
            get { return _bdate; }
            set { _bdate = value; }
        }


        public string LName
        {
            get { return _lname; }
            set { _lname = value; }

        }

        public string FName
        {
            get { return _fname; }
            set { _fname = value; }
        }
        #endregion
    }
}