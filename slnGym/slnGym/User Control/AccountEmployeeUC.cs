using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using slnGym.DataObject;
using System.IO;

namespace slnGym.User_Control
{
    public partial class AccountEmployeeUC : UserControl
    {
        public AccountEmployeeUC()
        {
            InitializeComponent();
        }

        private void AccountEmployeeUC_Load(object sender, EventArgs e)
        {
            groupBoxEdit.Visible = false;

        }

        private void btChangePass_Click(object sender, EventArgs e)
        {
            Forms.ChangePassword change = new Forms.ChangePassword();
            change.ShowDialog();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (groupBoxEdit.Visible == true)
                groupBoxEdit.Visible = false;
            else
            {
                groupBoxEdit.Visible = true;
                loadEdit();
            }
        }

        Layer.EMPLOYEEs emp = new Layer.EMPLOYEEs();
        MY_DB mydb = new MY_DB();
        Layer.LOGIN log = new Layer.LOGIN();

        public void reload()
        {
            #region CLOSE
            /*
            DataTable dt = new DataTable();
            dt = log.getAccountbyUser(GLOBAL.username);
            txtPass.Text = dt.Rows[0][1].ToString();
            DataTable empDT = new DataTable();
            empDT = emp.getEmployeebyID(GLOBAL.username);

            if (empDT.Rows.Count > 0)
            {
                lbID.Text = empDT.Rows[0][0].ToString();
                lbGroup.Text = empDT.Rows[0][1].ToString();
                try
                {
                    byte[] picPD;
                    picPD = (byte[])empDT.Rows[0][2];
                    MemoryStream pic = new MemoryStream(picPD);
                    this.picAva.Image = Image.FromStream(pic);
                }
                catch
                {
                    MessageBox.Show("Vui lòng cập nhật đủ thông tin cá nhân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                lbFname.Text = empDT.Rows[0][3].ToString();
                lbLname.Text = empDT.Rows[0][4].ToString();
                lbBirthday.Text = Convert.ToDateTime(empDT.Rows[0][5]).ToShortDateString();
                lbAddress.Text = empDT.Rows[0][6].ToString();
                if (Convert.ToInt32(empDT.Rows[0][7]) == 1)
                    lbGender.Text = "Nữ";
                else lbGender.Text = "Nam";
                lbPhone.Text = empDT.Rows[0][8].ToString();
                lbSalary.Text = empDT.Rows[0][9].ToString();
                lbIDCard.Text = empDT.Rows[0][10].ToString();
            }
            else
            {
                // MessageBox.Show(GLOBAL.username);
            }
            mydb.closeConnection();*/
            #endregion

        }

        public void loadEdit()
        {
            txtFname.Text = lbFname.Text;
            txtLname.Text = lbLname.Text;
            txtAddress.Text = lbAddress.Text;
            txtPhone.Text = lbPhone.Text;
            txtIDCard.Text = lbIDCard.Text;
            dateTimePickerBdate.Text = lbBirthday.Text;
            if (lbGender.Text == "Nữ")
                radioFemaleEdit.Checked = true;
            else radioMaleEdit.Checked = true;
            picAvaEdit.Image = picAva.Image;
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
            MemoryStream pic = new MemoryStream();
            picAvaEdit.Image.Save(pic, picAvaEdit.Image.RawFormat);
            int gender = 1;
            if (radioMaleEdit.Checked == true) gender = 0;

            #region CLOSE
            /*if (emp.updateEmployee(GLOBAL.username, pic, Convert.ToDateTime(dateTimePickerBdate.Value), txtAddress.Text, gender, txtPhone.Text))
            {
                MessageBox.Show("Edited", "Edited..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.reload();
            }
            else MessageBox.Show("Edited fail", "Edited..", MessageBoxButtons.OK, MessageBoxIcon.Error);*/
            #endregion
        }
    }
}