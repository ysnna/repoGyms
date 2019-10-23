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
    public partial class AccountMemberUC : UserControl
    {
        public AccountMemberUC()
        {
            InitializeComponent();
        }

        private void AccountMemberUC_Load(object sender, EventArgs e)
        {
            groupBoxEdit.Visible = false;
            txtPass.Enabled = false;
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

        private void picAvaEdit_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
                picAvaEdit.Image = Image.FromFile(open.FileName);
        }

     
    }
}