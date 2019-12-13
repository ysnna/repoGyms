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
    public partial class ManageEmployeeUC : UserControl
    {
        public ManageEmployeeUC()
        {
            InitializeComponent();
        }

        EMPLOYEEs employee = new EMPLOYEEs();
        LOGIN log = new LOGIN();

        private void btCreate_Click(object sender, EventArgs e)
        {
            NewEmployeeUC dt = new NewEmployeeUC() { Width = 1414, Height = 798 };
            //dt.reload();
            this.Controls.Add(dt);
            dt.BringToFront();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            EditEmployeeUC editEmployeeUC = new EditEmployeeUC() { Width = 1414, Height = 798 };
            this.Controls.Add(editEmployeeUC);
            editEmployeeUC.BringToFront();
        }

        private void ManageEmployeeUC_Load(object sender, EventArgs e)
        {
            loadEmloyee();
        }
        public void loadEmloyee()
        {
            dgvListEmployee.DataSource = employee.getAllEMPLOYEE();
            dgvListEmployee.RowTemplate.Height = 40;
            dgvListEmployee.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvListEmployee.AllowUserToAddRows = false;
            dgvListEmployee.EditMode = DataGridViewEditMode.EditProgrammatically;
            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            pic = (DataGridViewImageColumn)dgvListEmployee.Columns[2];
            pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void dgvListEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvListEmployee.RowTemplate.Height = 40;
            dgvListEmployee.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvListEmployee.AllowUserToAddRows = false;
            dgvListEmployee.EditMode = DataGridViewEditMode.EditProgrammatically;
            DataGridViewImageColumn pict = new DataGridViewImageColumn();
            pict = (DataGridViewImageColumn)dgvListEmployee.Columns[2];
            pict.ImageLayout = DataGridViewImageCellLayout.Zoom;

            DataTable dtemp = searchGroup();
            int index = dgvListEmployee.CurrentCell.RowIndex;
            string id = dgvListEmployee.Rows[index].Cells[0].Value.ToString();
            lbUsername.Text = id;
            byte[] picPD;
            picPD = (byte[])dgvListEmployee.Rows[index].Cells[2].Value;
            MemoryStream pic = new MemoryStream(picPD);
            this.picAva.Image = Image.FromStream(pic);
            EMPLOYEEs.EmployeeID = id;
            //string group = dgvListEmployee.Rows[index].Cells[1].Value.ToString();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            cbGroupName.Text = "";
            DataTable dt = searchGroup();
            dgvListEmployee.DataSource = dt;
        }

        private void cbGroupName_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = searchGroup();
            dgvListEmployee.DataSource = dt;
        }
        
        public DataTable searchGroup()
        {
            DataTable dt = new DataTable();
            if (cbGroupName.Text == "Salesman")
            {
                dt = employee.getEmployeebyGroupID("01");
            }
            else if(cbGroupName.Text == "Personal Trainer")
            {
                dt = employee.getEmployeebyGroupID("02");
            }
            else
            {
                dt = employee.getAllEMPLOYEE();
            }
            picAva.Image = picAva.BackgroundImage;
            lbUsername.Text = "Username";
            return dt;
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            dgvListEmployee.DataSource = employee.searchEmployee(txtSearch.Text);
        }
    }
}