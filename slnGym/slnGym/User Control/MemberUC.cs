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
using System.IO;

namespace slnGym.User_Control
{
    public partial class MemberUC : UserControl
    {
        public MemberUC()
        {
            InitializeComponent();
        }

        MemberBL mem = new MemberBL();
        MEMBERs getmem = new MEMBERs();

        public object EditMembers { get; private set; }

        private void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvProduct.DataSource = null;
            string inde = dgvMembers.CurrentRow.Cells[0].Value.ToString();
            
            //MessageBox.Show(index);
            mem.LoadDGVPackage(dgvPackage, inde);
            mem.loadDGVProduct(dgvProduct, inde);
            btEditMachine.Enabled = true;

            string index = dgvMembers.CurrentRow.Cells[0].Value.ToString();
            DataTable dt = new DataTable();
            dt = getmem.getMemberbyID(index);
            GetEditMember.FName = dt.Rows[0][1].ToString();
            GetEditMember.LName = dt.Rows[0][2].ToString();
            GetEditMember.Address = dt.Rows[0][5].ToString();
            GetEditMember.Birthday = Convert.ToDateTime(dt.Rows[0][4].ToString());
            GetEditMember.IDCard = dt.Rows[0][8].ToString();
            GetEditMember.Phone = dt.Rows[0][7].ToString();
            GetEditMember.Gender =dt.Rows[0][6].ToString();
            GetEditMember.IDMember = index;
            try
            {
                byte[] picPD;
                picPD = (byte[])dt.Rows[0][3];
                MemoryStream pic = new MemoryStream(picPD);
                GetEditMember.Picture = Image.FromStream(pic);
            }
            catch { }
        }
       
        private void MemberUC_Load(object sender, EventArgs e)
        {
            btEditMachine.Enabled = false;
            loadDGVMem();
        }

        private void btRefreshMember_Click(object sender, EventArgs e)
        {
            loadDGVMem();
        }

        private void btEditMachine_Click(object sender, EventArgs e)
        {
            EditMemberUC editMember = new EditMemberUC();
            editMember.ShowDialog();
        }

        private void dgvMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string index = dgvMembers.CurrentRow.Cells[0].Value.ToString();
            DataTable dt = new DataTable();
            dt = getmem.getMemberbyID(index);
            GetEditMember.FName = dt.Rows[0][1].ToString();
            GetEditMember.LName = dt.Rows[0][2].ToString();
            GetEditMember.Address = dt.Rows[0][5].ToString();
            GetEditMember.Birthday = Convert.ToDateTime( dt.Rows[0][4].ToString());
            GetEditMember.IDCard = dt.Rows[0][8].ToString();
            GetEditMember.Phone = dt.Rows[0][7].ToString();
            GetEditMember.Gender = dt.Rows[0][6].ToString();
            GetEditMember.IDMember = index;
            try
            {
                byte[] picPD;
                picPD = (byte[])dt.Rows[0][3];
                MemoryStream pic = new MemoryStream(picPD);
                GetEditMember.Picture = Image.FromStream(pic);
            } 
            catch { }
            btEditMachine.Enabled = true;
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

        private void txtSearchMembers_KeyUp(object sender, KeyEventArgs e)
        {
            dgvMembers.DataSource = getmem.searchEmployee(txtSearchMembers.Text);
        }
    }
}