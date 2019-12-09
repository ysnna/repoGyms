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
        MY_DB mydb = new MY_DB();
        EMPLOYEEs employee = new EMPLOYEEs();
        string sql;
        private void btCreate_Click(object sender, EventArgs e)
        {
            NewEmployeeUC dt = new NewEmployeeUC() { Width = 1414, Height = 798 };
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
            sql = @"EXEC proLOADEmp";
            DataTable dt = mydb.createTable(sql);
            dgvListEmployee.DataSource = dt;
            dgvListEmployee.RowTemplate.Height = 40;
            dgvListEmployee.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvListEmployee.AllowUserToAddRows = false;
            dgvListEmployee.EditMode = DataGridViewEditMode.EditProgrammatically;
            DataGridViewImageColumn pict = new DataGridViewImageColumn();
            pict = (DataGridViewImageColumn)dgvListEmployee.Columns[2];
            pict.ImageLayout = DataGridViewImageCellLayout.Zoom;

            int index = dgvListEmployee.CurrentCell.RowIndex;
            string id = dgvListEmployee.Rows[index].Cells[0].Value.ToString();
            //byte[] picPD;
            //picPD = (byte[])dgvListEmployee.Rows[index].Cells[2].Value;
            //MemoryStream pic = new MemoryStream(picPD);
            //this.picAva.Image = Image.FromStream(pic);
            EMPLOYEEs.EmployeeID = id;
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
            //byte[] picPD;
            //picPD = (byte[])dgvListEmployee.Rows[index].Cells[2].Value;
            //MemoryStream pic = new MemoryStream(picPD);
            //this.picAva.Image = Image.FromStream(pic);
            EMPLOYEEs.EmployeeID = id;
            string group = dgvListEmployee.Rows[index].Cells[1].Value.ToString();

        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            cbGroupName.Text = "";
            loadEmloyee();
        }

        private void cbGroupName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {

        }
        public DataTable searchGroup()
        {
            DataTable dt = new DataTable();
            if (cbGroupName.Text == "Salesman")
            {
                dt = employee.getEmployeebyGroupID("01");
            }
            else if (cbGroupName.Text == "Personal Trainer")
            {
                dt = employee.getEmployeebyGroupID("02");
            }
            else
            {
                string sql3 = @"EXEC proLOADEmp";
                dt = mydb.createTable(sql);
            }
            picAva.Image = picAva.BackgroundImage;
            lbUsername.Text = "Username";
            return dt;
        }
    }
}