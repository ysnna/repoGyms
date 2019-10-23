using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using slnGym.Class;
using slnGym.Layer;
using System.IO;
namespace slnGym.User_Control
{
    public partial class NewEmployeeUC : UserControl
    {
       
       
        private int GenderCheck = 0;
        void GenderChecked()
        {
            if (radioMaleEdit.Checked)
            {
                GenderCheck = 1;
            }
        }
        
        public NewEmployeeUC()
        {
            InitializeComponent();
        }
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
            set { _salary = value; txtSalary.Text = value; }
        }

        public string GroupID
        {
            get { return _groupID; }
            set { _groupID = value; txtGroupID.Text = value; }
        }

        public int Gender
        {
            get { return _gender; }
            set { _gender = value; GenderCheck = value; }
        }


        public string Address
        {
            get { return _address; }
            set { _address = value; txtAddress.Text = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; txtPhone.Text = value; }
        }

        public string Bdate
        {
            get { return _bdate; }
            set { _bdate = value; dateTimePickerBdate.Text = value; }
        }

        public string Idcard
        {
            get { return _idcard; }
            set { _idcard = value; txtIDCard.Text = value; }
        }

        public string Lname
        {
            get { return _lname; }
            set { _lname = value; txtLname.Text = value; }
        }

        public string Fname
        {
            get { return _fname; }
            set { _fname = value; txtFname.Text = value; }
        }



        #endregion
        private void NewEmployeeUC_Load(object sender, EventArgs e)
        {
            disGroupID();
            disGroupname();
            
            disUsername();
            displayPass();
        }
        private void cbGroupName_TextChanged_1(object sender, EventArgs e)
        {
            disGroupname();
        }
        //Xử lý hàm
        void disGroupID()
        {
            GROUPEMPLOYEE grEmp = new GROUPEMPLOYEE();
            cbGroupName.DataSource = grEmp.getGROUPEMP();
            cbGroupName.DisplayMember = "groupName";
            cbGroupName.ValueMember = "groupID";
            
        }
        void disGroupname()
        {     
                if (cbGroupName.Text.ToString() == "Salesman")
                {
                    txtGroupID.Text = "1";
                }
               else txtGroupID.Text = "2";
        }
        void displayPass()
        {
            NewEmployeeBL newEmp = new NewEmployeeBL();
            txtPass.Text =newEmp.SetPass();
        }
         void disUsername()
        {
            NewEmployeeBL newEmp = new NewEmployeeBL();
            txtUsername.Text = newEmp.UserName();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            EMPLOYEEs emp = new EMPLOYEEs();
            string groupid = txtGroupID.Text.Trim();
            string empID = txtUsername.Text.Trim();
            string Fname = txtFname.Text.Trim();
            string Lname = txtLname.Text.Trim();
            DateTime bdate = dateTimePickerBdate.Value;
            string Add = txtAddress.Text.TrimEnd();
            int Gen = GenderCheck;
            string phone = txtPhone.Text.TrimEnd();
            int IDcard = Convert.ToInt32( txtIDCard.Text.TrimEnd());
            int sal = Convert.ToInt32( txtSalary.Text.TrimEnd());
            MemoryStream picture = new MemoryStream();
            picAvaEdit.Image = Image.FromStream(picture);
            if (
            emp.insertEmployee(empID, groupid, picture, Fname, Lname, bdate, Add, Gen, phone, sal, IDcard))
                MessageBox.Show("okokokoko");
            else MessageBox.Show("kkkkkkk");
        }

        private void picAvaEdit_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
                picAvaEdit.Image = Image.FromFile(open.FileName);
        }
    }
}
