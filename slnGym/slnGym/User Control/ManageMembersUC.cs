﻿using System;
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

        MemberBL mem = new MemberBL();
        MEMBERs member = new MEMBERs();
        LOGIN log = new LOGIN();
        TempBL temp = new TempBL();
        string getID = "";
        private void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvProduct.DataSource = null;
            string index = dgvMembers.CurrentRow.Cells[0].Value.ToString();
            //MessageBox.Show(index);
            mem.LoadDGVPackage(dgvPackage, index);
            mem.loadDGVProduct(dgvProduct, index);
            mem.loadDGVPT(dgvPT, index);
            getID = index;
            txtMember.Text = dgvMembers.CurrentRow.Cells[1].Value.ToString() + " " + dgvMembers.CurrentRow.Cells[2].Value.ToString();
        }

        private void btRefreshMember_Click(object sender, EventArgs e)
        {
            loadDGVMem();
            checkTEMP();
        }

        private void btCreateContract_Click(object sender, EventArgs e)
        {
            if (getID != "")
            {
                member.updateAccpuntMember(getID, "Đã duyệt");
                log.updateAccount(getID, 2, null);
                MessageBox.Show("Approved");
                loadDGVMem();
            }
        }
        private void ManageMembersUC_Load(object sender, EventArgs e)
        {
            loadDGVMem();
            checkTEMP();
        }

        //Ham xu ly
        public void loadDGVMem() //Format lại cột BDate của Member (#FORMAT)
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
        }

        void checkTEMP()
        {
            if (temp.existCheck())
            {
                btnMessage.Text = temp.RequestCount().ToString();
            }
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            EditByAdmin edit = new EditByAdmin();
            edit.ShowDialog();
        }

        private void txtSearchMembers_KeyUp(object sender, KeyEventArgs e)
        {
            MEMBERs mem = new MEMBERs();
            dgvMembers.DataSource = mem.searchMember(txtSearchMembers.Text);
        }
    }
}