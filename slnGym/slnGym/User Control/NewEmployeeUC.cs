using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using slnGym.Layer;

namespace slnGym.User_Control
{
    public partial class NewEmployeeUC : UserControl
    {
        public NewEmployeeUC()
        {
            InitializeComponent();
        }

        private int GenderCheck = 0;

        private void btAdd_Click(object sender, EventArgs e)
        {
            addNewEmp();
            this.Dispose();
        }

        private void cbGroupName_TextChanged(object sender, EventArgs e)
        {
            disGroupname();
        }
        private void txtGroupID_TextChanged(object sender, EventArgs e)
        {
            disUsername();
            displayPass();
        }

        private void NewEmployeeUC_Load(object sender, EventArgs e)
        {
            disGroupID();
            disGroupname();
           // disUsername();
            //displayPass();
        }

        private void picAvaEdit_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
                picAvaEdit.Image = Image.FromFile(open.FileName);
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            lbIDEmployee.Text = txtUsername.Text;
        }
        //Hàm xử lý
        void disGroupID()
        {
            GROUPEMPLOYEE grEmp = new GROUPEMPLOYEE();
            cbGroupName.DataSource = grEmp.getGROUPEMP();
            cbGroupName.DisplayMember = "groupName";
            cbGroupName.ValueMember ="groupID";

        } //Cập nhật group ID tự động
        void disGroupname()
        {
            if (cbGroupName.Text.ToString() == "Salesman")
            {
                txtGroupID.Text = "01";
            }
            else txtGroupID.Text = "02";
        }//Cập nhật groupID tự động
        void displayPass()
        {
            NewEmployeeBL newEmp = new NewEmployeeBL();
            if (txtGroupID.Text == "01")
            {
                txtPass.Text = newEmp.SetPass();
            }
            else txtPass.Text = newEmp.SetPassPT();
        }//Cập nhật pass tự động
        void disUsername()
        {
            LOGIN newEmp = new LOGIN();
           
            NewEmployeeBL newID = new NewEmployeeBL();
            //txtUsername.Text = "nv" + (dt.Rows.Count + 1).ToString();
            if (txtGroupID.Text == "01")
            {
                txtUsername.Text = newID.existsEmpID(txtGroupID.Text);
            }else txtUsername.Text = newID.existsPTID(txtGroupID.Text);
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
            if (IsNumber(txtPhone.Text) && (txtPhone.Text != null) && (txtPhone.Text).Length == 10)
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
                if (IsNumber(txtIDCard.Text) && (txtIDCard.Text != null) && (txtIDCard.Text).Length == 10)
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
           
            int sal = 0;
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
            }
            catch (Exception) { }

            if (verif())
            {
                MemoryStream picture = new MemoryStream();
                picAvaEdit.Image.Save(picture, picAvaEdit.Image.RawFormat);
                if (emp.insertEmployee(empID, groupid, picture, Fname, Lname, bdate, Add, Gen, phone, sal, IDcard) && addAccount())
                    MessageBox.Show("okokokoko");
                else
                    MessageBox.Show("Please insert information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        } // Insert nhan vien moi
        bool addAccount() // insert empID thanh Account
        {
            Layer.LOGIN lg = new Layer.LOGIN();
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