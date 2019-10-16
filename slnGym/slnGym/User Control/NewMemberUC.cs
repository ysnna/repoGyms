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
    public partial class NewMemberUC : UserControl
    {
        public NewMemberUC()
        {
            InitializeComponent();
        }

        private void NewMemberUC_Load(object sender, EventArgs e)
        {
            radioMale.Checked = true;
        }

        private void btResfresh_Click(object sender, EventArgs e)
        {
            RefreshUC();
        }

        void RefreshUC()
        {
            txtFname.Text = "";
            txtLname.Text = "";
            txtIDCard.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtNote.Text = "";
            txtUserID.Text = "";
            txtPassword.Text = "";
            radioFemale.Checked = false;
            radioMale.Checked = true;
            dateTimePickerBdate.Value = DateTime.Now;
            picAvaEdit.Image = picAvaEdit.BackgroundImage;
        }

        private void btInvoice_Click(object sender, EventArgs e)
        {

        }

        private void picAvaEdit_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
                picAvaEdit.Image = Image.FromFile(open.FileName);
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            txtUserID.Text = "@" + txtPhone.Text;
            txtPassword.Text = txtPhone.Text;
        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {
            txtNamePartyMember.Text = txtLname.Text + " " + txtFname.Text;
        }

        private void txtLname_TextChanged(object sender, EventArgs e)
        {
            txtNamePartyMember.Text = txtLname.Text + " " + txtFname.Text;
        }
    }
}