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
        LOGIN log = new LOGIN();
        private void ManageAccountUC_Load(object sender, EventArgs e)
        {
            loadAccountLog();
            loadListAccount();
            btBlock.Enabled = false;
        }
        public void loadAccountLog()
        {
            dgvAccount.DataSource = account.getACCOUNTLog();
            dgvAccount.RowTemplate.Height = 50;
            dgvAccount.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvAccount.AllowUserToAddRows = false;
            dgvAccount.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvAccount.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        public void loadListAccount()
        {
            dgvListAccount.DataSource = log.getListAccount();
            dgvListAccount.RowTemplate.Height = 50;
            dgvListAccount.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvListAccount.AllowUserToAddRows = false;
            dgvListAccount.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvListAccount.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        string getUser;
        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btBlock.Enabled = true;
            getUser= dgvAccount.CurrentRow.Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadAccountLog();
        }

        private void btBlock_Click(object sender, EventArgs e)
        {
            DataTable dt = log.getUserID(getUser);
            if (Convert.ToInt32(dt.Rows[0][0]) == 5)
                log.updateAccount(getUser, 2, "");
            log.updateAccount(getUser, 5, "Blocked");
            loadListAccount();
        }

        private void dgvListAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btBlock.Enabled = true;
            getUser = dgvListAccount.CurrentRow.Cells[0].Value.ToString();
        }
    }
}