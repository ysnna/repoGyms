using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using slnGym.Layer;
using System.IO;

namespace slnGym.User_Control
{
    public partial class EditEmployeeUC : UserControl
    {
        public EditEmployeeUC()
        {
            InitializeComponent();
        }

        EMPLOYEEs employee = new EMPLOYEEs();
        LOGIN log = new LOGIN();
        int gender = 1;

        public void updateEmployee()
        {
            DataTable dt = new DataTable();
            dt = employee.getEmployeebyID(EMPLOYEEs.EmployeeID);
            lbIDEmployee.Text = EMPLOYEEs.EmployeeID;
            txtFname.Text = dt.Rows[0][3].ToString();
            txtLname.Text = dt.Rows[0][4].ToString();
            txtIDCard.Text = dt.Rows[0][10].ToString();
            dateTimePickerBdate.Value = Convert.ToDateTime(dt.Rows[0][5].ToString());
            txtPhone.Text = dt.Rows[0][8].ToString();
            txtAddress.Text = dt.Rows[0][6].ToString();
            txtSalary.Text = dt.Rows[0][9].ToString();
            txtUsername.Text = EMPLOYEEs.EmployeeID;
            DataTable data = log.getAccountbyUser(EMPLOYEEs.EmployeeID);
            txtPass.Text = data.Rows[0][1].ToString();
            string gr = dt.Rows[0][1].ToString();
           // MessageBox.Show(gr.ToString());
            if (gr == "01")
            {
                cbGroupName.Text = "Salesman";
                txtGroupID.Text = "01";
            }
            else
            {
                txtGroupID.Text = "02";
                cbGroupName.Text = "Personal Trainer";
            }
            gender = Convert.ToInt32(dt.Rows[0][7]);
            if (gender == 1)
                radioFemaleEdit.Checked = true;
            else radioMaleEdit.Checked = true;
            byte[] picPD;
            picPD = (byte[])dt.Rows[0][2];
            MemoryStream pic = new MemoryStream(picPD);
            this.picAvaEdit.Image = Image.FromStream(pic);
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            MemoryStream pic = new MemoryStream();
            picAvaEdit.Image.Save(pic, picAvaEdit.Image.RawFormat);
            employee.updateEmployeeAD(EMPLOYEEs.EmployeeID, txtGroupID.Text, pic, txtFname.Text, txtLname.Text, dateTimePickerBdate.Value, txtAddress.Text, gender, txtPhone.Text, Convert.ToInt32(txtSalary.Text), txtIDCard.Text);
            MessageBox.Show("complete");
            this.Dispose();
        }

        private void EditEmployeeUC_Load(object sender, EventArgs e)
        {
            updateEmployee();
            loadGroupEmployee();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void picAvaEdit_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
                picAvaEdit.Image = Image.FromFile(open.FileName);
        }

        public void loadGroupEmployee()
        {
            GROUPEMPLOYEE grEmp = new GROUPEMPLOYEE();
            cbGroupName.DataSource = grEmp.getGROUPEMP();
            cbGroupName.DisplayMember = "groupName";
            cbGroupName.ValueMember = "groupID";
        }

        private void cbGroupName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGroupName.Text.ToString() == "Salesman")
            {
                txtGroupID.Text = "01";
            }
            else txtGroupID.Text = "02";
        }
    }
}