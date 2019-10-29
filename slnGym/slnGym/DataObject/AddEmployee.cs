using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnGym.DataObject
{
    class AddEmployee
    {
        #region Properties
        private string _fname;
        private string _lname;
        private string _idcard;
        private string _bdate;
        private string _phone;
        private string _address;
        private int _gender;
        private string _groupID;
        private string _salary;

        public string Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public string GroupID
        {
            get { return _groupID; }
            set { _groupID = value; }
        }

        public int Gender
        {
            get { return _gender; }
            set { _gender = value; }
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

        public string Bdate
        {
            get { return _bdate; }
            set { _bdate = value; }
        }

        public string Idcard
        {
            get { return _idcard; }
            set { _idcard = value; }
        }

        public string Lname
        {
            get { return _lname; }
            set { _lname = value; }
        }

        public string Fname
        {
            get { return _fname; }
            set { _fname = value; }
        }
        #endregion
    }
}