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
            addNewEmp();
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
            string phone = "";
            if (IsNumber(txtPhone.Text) && (txtPhone.Text != null) && (txtPhone.Text).Length < 10)
            {
                phone = txtPhone.Text.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng số điện thoại");
                return false;
            }

            int IDcard = 0;
            try
            {
                if (IsNumber(txtIDCard.Text) && (txtIDCard.Text != null) && (txtIDCard.Text).Length < 10)
                {
                    IDcard = Convert.ToInt32(txtIDCard.Text.TrimEnd());
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng CMND");
                    return false;
                }
            }
            catch (Exception) { }
            finally {
                MessageBox.Show("Vui Long Nhap Dung CMND");
            };
            int sal=0;
            try
            {
                
                if (IsNumber(txtSalary.Text) && txtSalary.Text != null)
                {
                    sal = Convert.ToInt32(txtSalary.Text.TrimEnd());
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập lương");
                    return false;
                }
            }catch(Exception) { }
            
            
            if (verif())
            {
                MemoryStream picture = new MemoryStream();
                picAvaEdit.Image.Save(picture, picAvaEdit.Image.RawFormat);
                if (emp.insertEmployee(empID, groupid, picture, Fname, Lname, bdate, Add, Gen, phone, sal, IDcard)&& addAccount())
                    MessageBox.Show("okokokoko");
                else
                MessageBox.Show("Please insert information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
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

        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        bool verif()
        {
            if ((txtAddress.Text.Trim() == "")
                || (txtFname.Text.Trim() == "")
                || (txtIDCard.Text.Trim() == "")
                || (txtLname.Text.Trim() == "")
                || (txtPhone.Text.Trim() == "")
               || (txtSalary.Text.Trim() == "" || (picAvaEdit.Image == null)))
                return false;
            return true;
        }
    }
}
