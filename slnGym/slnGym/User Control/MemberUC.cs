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

        private void MemberUC_Load(object sender, EventArgs e)
        {
            mem.loadDGVMem(dgvMembers);
        }
    }
}