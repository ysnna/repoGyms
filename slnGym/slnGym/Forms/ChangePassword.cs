using slnGym.Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnGym.Forms
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!confirmPass())
            { MessageBox.Show("Wrong Pass", "InFo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            {
                ChangePass();
                this.Close();
            }

        }

        bool confirmPass()
        {
            if (txtOldPassword.Text != CheckPass())
            {
                return false;
            }
            return true;
        }

        public string CheckPass()
        {
            return null;
        }

        void ChangePass()
        {
            string pass = txtNewPassword.Text;
            string oldpass = txtOldPassword.Text;
            string newpass = txtNewPassword.Text;
            if (newpass != null && pass == txtConfirmPassword.Text)
            {
                if (txtOldPassword.Text == CheckPass())
                {
                    ///update pass
                    ///
                    ///
                    MessageBox.Show("Your Password was Changed", "InFo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}