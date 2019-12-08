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
using slnGym.Layer;
using slnGym.Forms;
namespace slnGym.User_Control
{
    public partial class ManageMembersUC : UserControl
    {
        public ManageMembersUC()
        {
            InitializeComponent();
        }

        string getID = "";

        private void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvProduct.DataSource = null;
            string index = dgvMembers.CurrentRow.Cells[0].Value.ToString();
            getID = index;
            txtMember.Text = dgvMembers.CurrentRow.Cells[1].Value.ToString() + " " + dgvMembers.CurrentRow.Cells[2].Value.ToString();
        }
        private void btRefreshMember_Click(object sender, EventArgs e)
        {
            loadDGVMem();
        }
        private void btCreateContract_Click(object sender, EventArgs e)
        {
            if (getID != "")
            {
                //UPDATE MEMBER "ĐÃ DUYỆT" VÀ USERID = 2
                MessageBox.Show("Approved");
                loadDGVMem();
            }
        }
        private void ManageMembersUC_Load(object sender, EventArgs e)
        {
            loadDGVMem();
        }

        public void loadDGVMem() //Format lại cột BDate của Member (#FORMAT)
        {
            dgvMembers.RowTemplate.Height = 50;
            dgvMembers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.EditMode = DataGridViewEditMode.EditProgrammatically;
           
            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            pic = (DataGridViewImageColumn)dgvMembers.Columns[3];
            pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
            //foreach (DataGridViewRow row in dgvMembers.Rows)
            //{
            //    if (row.Cells["note"].Value.ToString() == "Chờ duyệt")
            //    {
            //        row.DefaultCellStyle.BackColor = Color.Khaki;
            //    }
            //    else
            //    {
            //        row.DefaultCellStyle.BackColor = Color.MediumSeaGreen;
            //    }
            //}
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            EditByAdmin edit = new EditByAdmin();
            edit.ShowDialog();
        }

        private void txtSearchMembers_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}