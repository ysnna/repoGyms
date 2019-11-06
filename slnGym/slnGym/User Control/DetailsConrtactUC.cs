using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using slnGym.DataObject;
using slnGym.Layer;

namespace slnGym.User_Control
{
    public partial class DetailsConrtactUC : UserControl
    {
        public DetailsConrtactUC()
        {
            InitializeComponent();
        }

        private void btShowAll_Click(object sender, EventArgs e)
        {

        }

        private void dgvDetailCon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            displayInfo();
        }

        private void DetailsConrtactUC_Load(object sender, EventArgs e)
        {
            loadDGV();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (!searchMemID())
            {
                searchConID();
            }
        }
        //Hàm xử lý hiển thị phía trên DGV
        public void loadDGV() // Vẽ màu vô đây nha (#FORMAT)
        {
            dgvDetailCon.RowTemplate.Height = 50;
            dgvDetailCon.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvDetailCon.AllowUserToAddRows = false;
            dgvDetailCon.EditMode = DataGridViewEditMode.EditProgrammatically;
            //Hàm xử lý Databinding
            DetailContract dc;
            DataTable dt = new DataTable();
            DETAILCONTRACT db = new DETAILCONTRACT();
            dt = db.getDetailConTractDGV();
            int i = 0;
            while (i < dt.Rows.Count)
            {
                dc = new DetailContract();
                dc.ConID = dt.Rows[i][0].ToString();
                dc.servicePackName = dt.Rows[i][2].ToString();
                dc.DateStart = Convert.ToDateTime(dt.Rows[i][4]);
                dc.DateEnd = Convert.ToDateTime(dt.Rows[i][5]);
                dc.IDreceipt = dt.Rows[i][6].ToString();
                dc.price = Convert.ToDecimal(dt.Rows[i][7]);
                dc.ID_Mem = dt.Rows[i][1].ToString();
                dc.EmpID = dt.Rows[i][3].ToString();
                TimeSpan time = DateTime.Now - dc.DateEnd;
                if (time.Days < 0)
                {
                    dc.State = "CÒN HẠN";
                    //DataGridView row = dgvDetailCon.Rows[i];
                    //dgvDetailCon.Rows.Cells[4].Style.BackColor = Color.Tomato;
                }
                else dc.State = "HẾT HẠN";
                dc.oldnew = "null";
                detailContractBindingSource.Add(dc);
                i++;
            }
        }
        string getEmpID()
        {
            string empID = null;
            empID = dgvDetailCon.CurrentRow.Cells[7].Value.ToString();
            return empID;
        }

        string disEmpName(string empID)
        {
            string empName = null;
            EMPLOYEEs emp = new EMPLOYEEs();
            DataTable dt = new DataTable();
            dt = emp.getEmployeebyID(empID);
            empName = dt.Rows[0][3].ToString() + " " + dt.Rows[0][4].ToString();
            return empName;
        }
        string getPTID()
        {
            CONTRACTs con = new CONTRACTs();
            string ptID = null;
            ptID = dgvDetailCon.CurrentRow.Cells[1].Value.ToString();
            DataTable dt = new DataTable();
            dt = con.getContractByCUSID(ptID);
            ptID = dt.Rows[0][2].ToString();
            return ptID;
        }
        string getMemName()
        {
            string memName = null;
            CONTRACTs con = new CONTRACTs();
            MEMBERs mem = new MEMBERs();
            string memID = null;
            memID = dgvDetailCon.CurrentRow.Cells[1].Value.ToString();
            DataTable dt = new DataTable();
            dt = mem.getMemberbyID(memID);
            memName = dt.Rows[0][1].ToString() + " " + dt.Rows[0][2].ToString();
            return memName;
        }
        void displayInfo()
        {
            txtNameSeller.Text = disEmpName(getEmpID());
            txtPTname.Text = disEmpName(getPTID());
            lbMemberName.Text = getMemName();
            lbStartDate.Text = Convert.ToDateTime(dgvDetailCon.CurrentRow.Cells[3].Value).ToShortDateString();
            lbEndDate.Text = Convert.ToDateTime(dgvDetailCon.CurrentRow.Cells[4].Value).ToShortDateString();
            disTime();
        }

        void disTime()
        {
            int i = (Convert.ToDateTime(lbEndDate.Text) - DateTime.Now).Days;
            if (i > 0)
            {
                lbTimeRemaining.Text = i.ToString() + " Days";
            }
            else lbTimeRemaining.Text = "Expirated";
        }
        void searchConID()
        {
            string searchValue = txtSearch.Text.ToUpper();

            dgvDetailCon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dgvDetailCon.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        break;
                    }
                    else
                    {
                        row.Selected = false;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        //Search
        bool searchMemID()
        {
            string searchValue = txtSearch.Text.ToLower();
            int flag = 0;
            dgvDetailCon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dgvDetailCon.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        flag = 1;
                        break;
                    }
                    else
                    {
                        row.Selected = false;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            if (flag == 0)
            {
                return false;
            }
            return true;
        }
    }
}