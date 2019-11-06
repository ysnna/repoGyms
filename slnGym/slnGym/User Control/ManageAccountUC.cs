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

namespace slnGym.User_Control
{
    public partial class ManageAccountUC : UserControl
    {
        public ManageAccountUC()
        {
            InitializeComponent();
        }

        AccountBL account = new AccountBL();

        private void ManageAccountUC_Load(object sender, EventArgs e)
        {
            loadAccountLog();
        }
        public void loadAccountLog()
        {
            dgvAccount.DataSource = account.getACCOUNTLog();
            dgvAccount.RowTemplate.Height = 50;
            dgvAccount.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvAccount.AllowUserToAddRows = false;
            dgvAccount.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}