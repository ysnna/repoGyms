using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnGym.User_Control
{
    public partial class AccountEmployeeUC : UserControl
    {
        public AccountEmployeeUC()
        {
            InitializeComponent();
        }

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

        public string EmployeeID
        {
            get { return _id; }
            set { _id = value; lbID.Text = value; }
        }

        public Image Ava
        {
            get { return _ava; }
            set { _ava = value; picAva.Image = value; }
        }

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; lbGender.Text = value; }
        }

        public string Salary
        {
            get { return _salary; }
            set { _salary = value; lbSalary.Text = value; }
        }

        public string Group
        {
            get { return _group; }
            set { _group = value; lbGroup.Text = value; }
        }

        public string IDCard
        {
            get { return _idcard; }
            set { _idcard = value; lbIDCard.Text = value; }
        }


        public string Address
        {
            get { return _address; }
            set { _address = value; lbAddress.Text = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; lbPhone.Text = value; }
        }

        public string BDate
        {
            get { return _bdate; }
            set { _bdate = value; lbBirthday.Text = value; }
        }


        public string LName
        {
            get { return _lname; }
            set { _lname = value; lbLname.Text = value; }

        }

        public string FName
        {
            get { return _fname; }
            set { _fname = value; lbFname.Text = value; }
        }
        #endregion

        private void AccountEmployeeUC_Load(object sender, EventArgs e)
        {
            txtPass.Enabled = false;
            groupBoxEdit.Visible = false;
        }

        private void btChangePass_Click(object sender, EventArgs e)
        {
            Forms.ChangePassword change = new Forms.ChangePassword();
            change.ShowDialog();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            groupBoxEdit.Visible = true;
        }
        Layer.EMPLOYEEs emp = new Layer.EMPLOYEEs();
        MY_DB mydb = new MY_DB();

        public void reload()
        {
            DataTable empDT = new DataTable();
            empDT = emp.getEmployeebyID(GLOBAL.username);
            if (empDT.Rows.Count > 0)
            {
                EmployeeID = empDT.Rows[0][0].ToString();
                Group = empDT.Rows[0][1].ToString();
                //empUC.Ava = empDT.Rows[0][2];
                FName = empDT.Rows[0][3].ToString();
                LName = empDT.Rows[0][4].ToString();
                BDate = empDT.Rows[0][5].ToString();
                Address = empDT.Rows[0][6].ToString();
                Gender = empDT.Rows[0][7].ToString();
                Phone = empDT.Rows[0][8].ToString();
                Salary = empDT.Rows[0][9].ToString();
                IDCard = empDT.Rows[0][10].ToString();
            }
            else MessageBox.Show("bug");
            mydb.closeConnection();
        }

        private void picAvaEdit_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
                picAvaEdit.Image = Image.FromFile(open.FileName);
        }

        private void btSave_Click(object sender, EventArgs e)
        {

        }
    }
}