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
        MY_DB mydb = new MY_DB();
        //Load & Event
        private void btAdd_Click(object sender, EventArgs e)
        {
            MemoryStream picture = new MemoryStream();
            if (verif())
            {    
                try
                {
                    picAvaEdit.Image.Save(picture, picAvaEdit.Image.RawFormat);
                }
                catch (Exception Exc)
                {
                    MessageBox.Show("Please insert an Avatar");
                    return;
                }
            }
        
            checkCondition();
            string groupid =  txtGroupID.Text.Trim();
            string empID = txtUsername.Text.Trim();
            string Fname = txtFname.Text.Trim();
            string Lname = txtLname.Text.Trim();
            DateTime bdate = dateTimePickerBdate.Value;
            string Add = txtAddress.Text.TrimEnd();
            string Gen = "";
            if (radioMaleEdit.Checked == true)
            {
                Gen = radioMaleEdit.Text;
            }
            else Gen = radioFemaleEdit.Text;
            string IDcard = txtIDCard.Text.TrimEnd();
            string phone = txtPhone.Text;
            int sal = 0;
            if (txtSalary.Text != "")
            {
             sal = Convert.ToInt32(txtSalary.Text.TrimEnd());
            }
            string statement = "insert";
            string sql = @"exec proINSERTEMP '"+empID+"','"+groupid+"', '"+picture.ToArray()+"', N'"+Fname+"',N'"+Lname+"', '"+bdate+"', N'"+Add+"', '" + Gen + "','" + phone + "', '" + sal + "', '" + IDcard + "'";
            mydb.executeQuery(sql);
            string sql1 = @"EXEC proINSUPACCOUNT  '"+empID+"','"+txtPass.Text.ToString()+"',"+ Convert.ToInt32(txtGroupID.Text.Trim()) + ",' ', '"+statement+"'";
            mydb.executeQuery(sql1);
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
            if (txtAddress.Text.Trim() == ""
                || txtFname.Text.Trim() == ""
                || txtIDCard.Text.Trim() == ""
                || txtLname.Text.Trim() == ""
                || txtPhone.Text.Trim() == ""
               || txtSalary.Text.Trim() == ""  )
                return false;
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
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
            }
            else txtUsername.Text = newID.existsPTID(txtGroupID.Text);
        }//Cập nhật usernametự động
        void checkCondition()
        {
            EMPLOYEEs emp = new EMPLOYEEs();

            if (IsNumber(txtPhone.Text) && (txtPhone.Text != null) && (txtPhone.Text).Length == 10)
            {

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng số điện thoại");
                return;
            }
            try
            {
                if (IsNumber(txtIDCard.Text) && (txtIDCard.Text != null) && (txtIDCard.Text).Length == 10)
                {

                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng CMND");
                    return;
                }
            }
            catch (Exception) { }

            try
            {
                if (IsNumber(txtSalary.Text) && txtSalary.Text != null)
                {

                }
                else
                {
                    MessageBox.Show("Please insert the Salary");
                    return;
                }
            }
            catch (Exception) { }
        }
           
    }
}