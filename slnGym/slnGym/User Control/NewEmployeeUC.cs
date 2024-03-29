﻿using System;
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

        private string GenderCheck = "Female";
        //Load & Event
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
            //disUsername();
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
            }
            else txtUsername.Text = newID.existsPTID(txtGroupID.Text);
        }//Cập nhật usernametự động
        void GenderChecked()
        {
            if (radioMaleEdit.Checked)
            {
                GenderCheck = "Male";
            }
        }
        void addNewEmp()
        {
            EMPLOYEEs emp = new EMPLOYEEs();
            string groupid = txtGroupID.Text.Trim();
            string empID = txtUsername.Text.Trim();
            string Fname = txtFname.Text.Trim();
            string Lname = txtLname.Text.Trim();
            DateTime bdate = dateTimePickerBdate.Value;
            string Add = txtAddress.Text.TrimEnd();
            string Gen = GenderCheck;
            string phone = "";
            if (IsNumber(txtPhone.Text) && (txtPhone.Text != null) && (txtPhone.Text).Length == 10)
            {
                phone = txtPhone.Text.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng số điện thoại");
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
                    MessageBox.Show("Please insert the Salary");

                }
            }
            catch (Exception) { }

            if (verif())
            {
               
                    MemoryStream picture = new MemoryStream();
                try
                {
                    picAvaEdit.Image.Save(picture, picAvaEdit.Image.RawFormat);
                }
                catch(Exception Exc)
                {
                    MessageBox.Show("Please insert an Avatar");
                }
                if (emp.insertEmployee(empID, groupid, picture, Fname, Lname, bdate, Add, Gen, phone, sal, IDcard) && addAccount())
                    MessageBox.Show("New Employee has been Created!");
                else
                    MessageBox.Show("Please insert information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              
            }
            
        } // Insert nhan vien moi
        bool addAccount() // insert empID thanh Account
        {
            Layer.LOGIN lg = new Layer.LOGIN();
            string pass = txtPass.Text;
            string username = txtUsername.Text;
            string id = txtGroupID.Text;
            if (lg.insertLogin(username, pass, id,null))
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
    }
}