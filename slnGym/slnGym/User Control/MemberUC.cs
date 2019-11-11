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

namespace slnGym.User_Control
{
    public partial class MemberUC : UserControl
    {
        public MemberUC()
        {
            InitializeComponent();
        }

        MemberBL mem = new MemberBL();

        private void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvProduct.DataSource = null;
            string index = dgvMembers.CurrentRow.Cells[0].Value.ToString();
            //MessageBox.Show(index);
            mem.LoadDGVPackage(dgvPackage, index);
            mem.loadDGVProduct(dgvProduct, index);
        }
        public void loadDGVMem() 
        {
            dgvMembers.RowTemplate.Height = 50;
            dgvMembers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.EditMode = DataGridViewEditMode.EditProgrammatically;
            
            MEMBERs mem = new MEMBERs();
            DataTable dt = new DataTable();
            dt = mem.getAllMEMBERS();
            dgvMembers.DataSource = dt;
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
        private void MemberUC_Load(object sender, EventArgs e)
        {
            loadDGVMem();
        }

        private void btRefreshMember_Click(object sender, EventArgs e)
        {
            loadDGVMem();
        }
    }
}