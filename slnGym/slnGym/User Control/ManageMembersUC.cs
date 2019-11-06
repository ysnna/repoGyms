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
    public partial class ManageMembersUC : UserControl
    {
        public ManageMembersUC()
        {
            InitializeComponent();
        }
        MemberBL mem = new MemberBL();
        private void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvProduct.DataSource = null;
            string index = dgvMembers.CurrentRow.Cells[0].Value.ToString();
            //MessageBox.Show(index);
            mem.LoadDGVPackage(dgvPackage,index);
            mem.loadDGVProduct(dgvProduct,index);
            mem.loadDGVPT(dgvPT, index);
        }

        private void ManageMembersUC_Load(object sender, EventArgs e)
        {
           mem.loadDGVMem(dgvMembers);
        }
        //Hàm xử lý
        
    }
}
