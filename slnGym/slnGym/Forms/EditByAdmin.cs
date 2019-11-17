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
        MEMBERs mem = new MEMBERs();
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Approve();
        }

        private void EditByAdmin_Load(object sender, EventArgs e)
        {
            temp.loadDGVTEMP(dgvMembers);
            btCancel.Enabled = false;
            btnAccept.Enabled = false;
        }

        private void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
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
            btCancel.Enabled = true;
            btnAccept.Enabled = true;
            //hightlight();
        }

        void hightlight()
        {
            if (lbFname.Text != dgvMembers.CurrentRow.Cells[1].ToString())
            {
                lbFname.ForeColor = Color.Firebrick;
            }
            else lbFname.ForeColor = Color.Black;
            //
            if (lbLname.Text != dgvMembers.CurrentRow.Cells[2].ToString())
            {
                lbLname.ForeColor = Color.Firebrick;
            }
            else lbLname.ForeColor = Color.Black;
            //
            if (lbBirthday.Text != dgvMembers.CurrentRow.Cells[4].ToString())
            {
                lbBirthday.ForeColor = Color.Firebrick;
            }
            else lbBirthday.ForeColor = Color.Black;
            //
            if (lbPhone.Text != dgvMembers.CurrentRow.Cells[7].ToString())
            {
                lbPhone.ForeColor = Color.Firebrick;
            }
            else lbPhone.ForeColor = Color.Black;
            //
            if (lbIDCard.Text != dgvMembers.CurrentRow.Cells[8].ToString())
            {
                lbIDCard.ForeColor = Color.Firebrick;
            }
            else lbIDCard.ForeColor = Color.Black;
            //
            if (lbAddress.Text != dgvMembers.CurrentRow.Cells[5].ToString())
            {
                lbAddress.ForeColor = Color.Firebrick;
            }
            else lbAddress.ForeColor = Color.Black;
        }

        void Approve()
        {
            string note = "Đã duyệt";
            string index = dgvMembers.CurrentRow.Cells[0].Value.ToString();
            string fname = dgvMembers.CurrentRow.Cells[1].Value.ToString();
            string lname = dgvMembers.CurrentRow.Cells[2].Value.ToString();
            byte[] picPD;
            picPD = (byte[])dgvMembers.CurrentRow.Cells[3].Value;
            MemoryStream pic = new MemoryStream(picPD);
            DateTime bdate = Convert.ToDateTime(dgvMembers.CurrentRow.Cells[4].Value);
            string add = dgvMembers.CurrentRow.Cells[5].Value.ToString();
            string phone = dgvMembers.CurrentRow.Cells[7].Value.ToString();
            int idcard = Convert.ToInt32(dgvMembers.CurrentRow.Cells[8].Value);
            int gender = Convert.ToInt32(dgvMembers.CurrentRow.Cells[6].Value);
            if (mem.updateMembers(index, fname, lname, pic, bdate, add, gender, phone, idcard, note))
            {
                mem.deleteTEMP(index);
                MessageBox.Show("Đã duyệt thành công");
                temp.loadDGVTEMP(dgvMembers);
            }
            else MessageBox.Show("Đã có lỗi trong quá trình xử lý, vui lòng thử lại");
        }
        void notApprove()
        {
            string index = dgvMembers.CurrentRow.Cells[0].Value.ToString();
            mem.deleteTEMP(index);
            temp.loadDGVTEMP(dgvMembers);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            notApprove();
        }
    }
}