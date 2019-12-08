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

        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            cbGroupName.Text = "";
        }

        private void cbGroupName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}