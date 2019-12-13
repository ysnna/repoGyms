using slnGym.DataObject;
using slnGym.Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace slnGym.Forms
{
    public partial class EditMemberUC : Form
    {
        public EditMemberUC()
        {
            InitializeComponent();
        }
        MEMBERs mem = new MEMBERs();
        private void Form2_Load(object sender, EventArgs e)
        {
            loadInfo();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void loadInfo()
        {
            try
            {
                txtFname.Text = GetEditMember.FName;
                txtLname.Text = GetEditMember.LName;
                txtIDCard.Text = GetEditMember.IDCard;
                txtPhone.Text = GetEditMember.Phone;
                txtAddress.Text = GetEditMember.Address;
                lbID.Text = GetEditMember.IDMember;
                dateTimePickerBdate.Value = GetEditMember.Birthday;
                picAvaEdit.Image = GetEditMember.Picture;
                if (GetEditMember.Gender == "Male")
                {
                    radioMaleEdit.Checked = true;
                }
                else radioFemaleEdit.Checked = true;
            }
            catch { }
        }
        private void picAvaEdit_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
                picAvaEdit.Image = Image.FromFile(open.FileName);
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            string gender = "Female";
            if (radioMaleEdit.Checked)
            {
                gender = "Male";
            }
            string note = "Chờ duyệt";
            
            MemoryStream picture = new MemoryStream();
            picAvaEdit.Image.Save(picture, picAvaEdit.Image.RawFormat);
            string id = GetEditMember.IDMember;
            string Fname = txtFname.Text;
            string Lname = txtLname.Text;
            int IDcard = Convert.ToInt32(txtIDCard.Text);
            string phone = txtPhone.Text;
            string add = txtAddress.Text;
            DateTime Bdate = dateTimePickerBdate.Value;
            if (mem.insertTemporary(id, Lname, Fname, picture ,Bdate, add, gender, phone, IDcard, note))
            {
               // mem.updateMembers(id, Lname, Fname, Bdate, add, gender, phone, IDcard, note);
                MessageBox.Show("Your request has been sent");
                this.Close();
            }
        }
    }
}