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

        public void updateEmployee()
        {
            DataTable dt = new DataTable();
            dt = employee.getEmployeebyID(EMPLOYEEs.EmployeeID);
            txtFname.Text = dt.Rows[0][3].ToString();
            txtLname.Text= dt.Rows[0][4].ToString();
            txtIDCard.Text= dt.Rows[0][10].ToString();
            dateTimePickerBdate.Value= Convert.ToDateTime(dt.Rows[0][5].ToString());
            txtPhone.Text= dt.Rows[0][8].ToString();
            txtAddress.Text= dt.Rows[0][6].ToString();
            txtSalary.Text= dt.Rows[0][9].ToString();
            txtUsername.Text = EMPLOYEEs.EmployeeID;
            DataTable data = log.getAccountbyUser(EMPLOYEEs.EmployeeID);
            txtPass.Text = data.Rows[0][1].ToString();
            string gr= data.Rows[0][1].ToString();
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
            int gender=Convert.ToInt32(dt.Rows[0][7].ToString());
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

            this.Dispose();
        }

        private void EditEmployeeUC_Load(object sender, EventArgs e)
        {
            updateEmployee();
        }
    }
}