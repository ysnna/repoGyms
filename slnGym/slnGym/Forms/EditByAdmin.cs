using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using slnGym.Layer;
using slnGym.DataObject;
using System.IO;
namespace slnGym.Forms
{
    public partial class EditByAdmin : Form
    {
        public EditByAdmin()
        {
            InitializeComponent();
        }
        TempBL temp = new TempBL();
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

        }

        private void EditByAdmin_Load(object sender, EventArgs e)
        {
            temp.loadDGVTEMP(dgvMembers);
        }

        private void dgvMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string index = dgvMembers.CurrentRow.Cells[0].Value.ToString();
            DataTable dt = new DataTable();
            dt = temp.loadInfoOld(index);
            lbFname.Text = dt.Rows[0][1].ToString();
            lbLname.Text = dt.Rows[0][2].ToString();
            lbBirthday.Text = dt.Rows[0][4].ToString();
            lbAddress.Text = dt.Rows[0][5].ToString();

            if (dt.Rows[0][6].ToString() == "True")
            {
                lbGender.Text = "Female";
            }
            else lbGender.Text = "Male";
            lbPhone.Text = dt.Rows[0][7].ToString();
            lbIDCard.Text = dt.Rows[0][8].ToString();
            //byte[] picPD;
            //picPD = (byte[])dt.Rows[0][3];
            //MemoryStream pic = new MemoryStream(picPD);
            //this.picAvaEdit.Image = Image.FromStream(pic);
        }
        void hightlight()
        {
            if (lbFname.Text != dgvMembers.CurrentRow.Cells[1].ToString())
            {
                lbFname.BackColor = Color.Red;
            }
            else lbFname.BackColor = Color.Black;
            //
            if (lbLname.Text != dgvMembers.CurrentRow.Cells[2].ToString())
            {
                lbLname.BackColor = Color.Red;
            }
            else lbLname.BackColor = Color.Black;
            //
            if (lbBirthday.Text != dgvMembers.CurrentRow.Cells[4].ToString())
            {
                lbBirthday.BackColor = Color.Red;
            }
            else lbBirthday.BackColor = Color.Black;
            //
            if (lbPhone.Text != dgvMembers.CurrentRow.Cells[7].ToString())
            {
                lbPhone.BackColor = Color.Red;
            }
            else lbPhone.BackColor = Color.Black;
            //
            if (lbIDCard.Text != dgvMembers.CurrentRow.Cells[8].ToString())
            {
                lbIDCard.BackColor = Color.Red;
            }
            else lbIDCard.BackColor = Color.Black;
            //
            if (lbAddress.Text != dgvMembers.CurrentRow.Cells[5].ToString())
            {
                lbAddress.BackColor = Color.Red;
            }
            else lbAddress.BackColor = Color.Black;
        }
    } 
}
