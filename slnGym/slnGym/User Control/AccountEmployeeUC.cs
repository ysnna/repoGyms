using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnGym.User_Control
{
    public partial class AccountEmployeeUC : UserControl
    {
        public AccountEmployeeUC()
        {
            InitializeComponent();
        }

        private void btChangePass_Click(object sender, EventArgs e)
        {
            AddForm.ChangePassword change = new AddForm.ChangePassword();
            change.ShowDialog();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            groupBoxEdit.Visible = true;
        }

        private void AccountEmployeeUC_Load(object sender, EventArgs e)
        {
            txtPass.Enabled = false;
            groupBoxEdit.Visible = false;
        }
    }
}