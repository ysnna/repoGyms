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
            notApprove();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Approve();
        }

        private void EditByAdmin_Load(object sender, EventArgs e)
        {
            temp.loadDGVTEMP(dgvMembers);
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
            hightlight();
            //byte[] picPD;
            //picPD = (byte[])dt.Rows[0][3];
            //MemoryStream pic = new MemoryStream(picPD);
            //this.picAvaEdit.Image = Image.FromStream(pic);
        }

        void hightlight()
        {
            if (lbFname.Text != dgvMembers.CurrentRow.Cells[1].ToString())
            {
                lbFname.ForeColor = Color.Red;
            }
            else lbFname.ForeColor = Color.Black;
            //
            if (lbLname.Text != dgvMembers.CurrentRow.Cells[2].ToString())
            {
                lbLname.ForeColor = Color.Red;
            }
            else lbLname.ForeColor = Color.Black;
            //
            if (lbBirthday.Text != dgvMembers.CurrentRow.Cells[4].ToString())
            {
                lbBirthday.ForeColor = Color.Red;
            }
            else lbBirthday.ForeColor = Color.Black;
            //
            if (lbPhone.Text != dgvMembers.CurrentRow.Cells[7].ToString())
            {
                lbPhone.ForeColor = Color.Red;
            }
            else lbPhone.ForeColor = Color.Black;
            //
            if (lbIDCard.Text != dgvMembers.CurrentRow.Cells[8].ToString())
            {
                lbIDCard.ForeColor = Color.Red;
            }
            else lbIDCard.ForeColor = Color.Black;
            //
            if (lbAddress.Text != dgvMembers.CurrentRow.Cells[5].ToString())
            {
                lbAddress.ForeColor = Color.Red;
            }
            else lbAddress.ForeColor = Color.Black;
        }
        void Approve()
        {
            string note = "Đã duyệt";
            string index = dgvMembers.CurrentRow.Cells[0].Value.ToString();
            string fname = dgvMembers.CurrentRow.Cells[1].Value.ToString();
            string lname = dgvMembers.CurrentRow.Cells[2].Value.ToString();
            DateTime bdate = Convert.ToDateTime(dgvMembers.CurrentRow.Cells[4].Value);
            string add = dgvMembers.CurrentRow.Cells[5].Value.ToString();
            string phone = dgvMembers.CurrentRow.Cells[7].Value.ToString();
            int idcard = Convert.ToInt32(dgvMembers.CurrentRow.Cells[8].Value);
            int gender = Convert.ToInt32(dgvMembers.CurrentRow.Cells[6].Value);
            if (mem.updateMembers(index, lname, fname, bdate, add, gender, phone, idcard, note))
            {
                MessageBox.Show("Đã duyệt thành công");
                mem.deleteTEMP(index);
            }
            else MessageBox.Show("Đã có lỗi trong quá trình xử lý, vui lòng thử lại");
        }
        void notApprove()
        {
            string note = "Từ Chối";
            string index = dgvMembers.CurrentRow.Cells[0].Value.ToString();
            string fname = dgvMembers.CurrentRow.Cells[1].Value.ToString();
            string lname = dgvMembers.CurrentRow.Cells[2].Value.ToString();
            DateTime bdate = Convert.ToDateTime(dgvMembers.CurrentRow.Cells[4].Value);
            string add = dgvMembers.CurrentRow.Cells[5].Value.ToString();
            string phone = dgvMembers.CurrentRow.Cells[7].Value.ToString();
            int idcard = Convert.ToInt32(dgvMembers.CurrentRow.Cells[8].Value);
            int gender = Convert.ToInt32(dgvMembers.CurrentRow.Cells[6].Value);
            if (mem.updateMembers(index, lname, fname, bdate, add, gender, phone, idcard, note))
            {
                MessageBox.Show("Đã duyệt thành công");
                mem.deleteTEMP(index);
            }
            else MessageBox.Show("Đã có lỗi trong quá trình xử lý, vui lòng thử lại");
        }
    } 
}
