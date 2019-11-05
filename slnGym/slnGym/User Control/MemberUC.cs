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
using slnGym.DataObject;
namespace slnGym.User_Control
{
    public partial class MemberUC : UserControl
    {
        //Load & Event
        public MemberUC()
        {
            InitializeComponent();
        }

        private void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvProduct.DataSource = null;
            string index = dgvMembers.CurrentRow.Cells[0].Value.ToString();
            //MessageBox.Show(index);
            LoadDGVPackage(index);
            loadDGVProduct(index);
        }

        private void MemberUC_Load(object sender, EventArgs e)
        {
            loadDGVMem();
        }


        //hàm xử lý
        void LoadDGVPackage(string idKH) //#FORMAT dgv cho đẹp
        {
            dgvPackage.RowTemplate.Height = 50;
            dgvPackage.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvPackage.AllowUserToAddRows = false;
            dgvPackage.EditMode = DataGridViewEditMode.EditProgrammatically;
            //
            SERVICEPACKs ser = new SERVICEPACKs();
            DataTable dt = new DataTable();
            dt = ser.getPackageDGV(idKH);
            dgvPackage.DataSource = dt;
            dgvPackage.Refresh();
        }
        void loadDGVProduct(string id)
        {
            dgvProduct.RowTemplate.Height = 50;
            dgvProduct.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvProduct.AllowUserToAddRows = false;
            dgvProduct.EditMode = DataGridViewEditMode.EditProgrammatically;
            //
            
            PRODUCTs ser = new PRODUCTs();
            DataTable dt = new DataTable();
            dt = ser.getPRODUCTDGV(id);
            dgvProduct.DataSource = dt;
            dgvProduct.Refresh();
        }
        void loadDGVMem() //Format lại cột BDate của Member (#FORMAT)
        {
            dgvMembers.RowTemplate.Height = 50;
            dgvMembers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.EditMode = DataGridViewEditMode.EditProgrammatically;
            MEMBERs mem = new MEMBERs();
            DataTable dt = new DataTable();
            dt = mem.getAllMEMBERS();
            dgvMembers.DataSource = dt;
        }
    }
}