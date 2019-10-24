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
        //Ham xu ly nut
        private void cbGroupName_TextChanged_1(object sender, EventArgs e)
        {
            disGroupname();
        }
        private void picAvaEdit_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
                picAvaEdit.Image = Image.FromFile(open.FileName);
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            if (addNewEmp())
            {
                if (addAccount())
                    MessageBox.Show("Thêm Nhân Viên Thành Công, Có thể đăng nhập");
                else
                    MessageBox.Show("Thêm Nhân Viên Thành Công, Sai Đăng Nhập");
            }
            else MessageBox.Show("Không THêm Được Nhân Viên");
        }
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            lbIDEmployee.Text = txtUsername.Text;
        }
        //Xử lý hàm
        void disGroupID()
        {
            GROUPEMPLOYEE grEmp = new GROUPEMPLOYEE();
            cbGroupName.DataSource = grEmp.getGROUPEMP();
            cbGroupName.DisplayMember = "groupName";
            cbGroupName.ValueMember = "groupID";

        } //Cập nhật group ID tự động
        void disGroupname()
        {
            if (cbGroupName.Text.ToString() == "Salesman")
            {
                txtGroupID.Text = "1";
            }
            else txtGroupID.Text = "2";
        }//Cập nhật groupname tự động
        void displayPass()
        {
            
            NewEmployeeBL newEmp = new NewEmployeeBL();
            txtPass.Text = newEmp.SetPass();
        }//Cập nhật pass tự động
        void disUsername()
        {
            NewEmployeeBL newEmp = new NewEmployeeBL();
            txtUsername.Text = newEmp.UserName();
        }//Cập nhật usernametự động
        void GenderChecked()
        {
            if (radioMaleEdit.Checked)
            {
                GenderCheck = 1;
            }
        }
        bool addNewEmp()
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
            int IDcard = Convert.ToInt32(txtIDCard.Text.TrimEnd());
            int sal = Convert.ToInt32(txtSalary.Text.TrimEnd());
            MemoryStream picture = new MemoryStream();
            picAvaEdit.Image.Save(picture, picAvaEdit.Image.RawFormat);
            if (emp.insertEmployee(empID, groupid, picture, Fname, Lname, bdate, Add, Gen, phone, sal, IDcard))
                MessageBox.Show("okokokoko");
            return true;
           
            
        } // Insert nhan vien moi
        bool addAccount() // insert empID thanh Account
        {
            LOGIN lg = new LOGIN();
            string pass = txtPass.Text;
            string username = txtUsername.Text;
            string id = txtGroupID.Text;
            if (lg.insertLogin(username, pass, id))
                return true;
            return false;
        }

    }
}
