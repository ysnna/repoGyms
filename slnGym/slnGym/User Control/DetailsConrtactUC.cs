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

        private void dgvDetailsContract_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            displayInfo();
            disTime();
            
        }
        private void dgvContracts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string index = dgvContracts.CurrentRow.Cells[0].Value.ToString();
            designDGV(dgvDetailsContract);
            loadDGVDetails(index);
            //TimeSpan Day = DateTime.Now - dgvDetailsContract.CurrentRow.Cells[].Value;
            //if (Day.Days > 0)
            //{
            //   .State = "Còn hạn";
            //}
            //else dc.State = "Hết hạn";
            

        }
        private void DetailsConrtactUC_Load(object sender, EventArgs e)
        {
            loadDGV();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
         
        }
        //Hàm xử lý hiển thị phía trên DGV
       
        string getEmpID()
        {
            string empID = null;
            empID = dgvContracts.CurrentRow.Cells[3].Value.ToString();
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
   
        string getMemName()
        {
            string memName = null;
            MEMBERs mem = new MEMBERs();
            string memID = null;
            memID = dgvContracts.CurrentRow.Cells[1].Value.ToString();
            DataTable dt = new DataTable();
            dt = mem.getMemberbyID(memID);
            memName = dt.Rows[0][1].ToString() + " " + dt.Rows[0][2].ToString();
            return memName;
        }
        void displayInfo()
        {
            txtNameSeller.Text = disEmpName(getEmpID());
            //txtPTname.Text = disEmpName(getPTID());
            lbMemberName.Text = getMemName();
            lbStartDate.Text = Convert.ToDateTime(dgvDetailsContract.CurrentRow.Cells[2].Value).ToShortDateString();
            lbEndDate.Text = Convert.ToDateTime(dgvDetailsContract.CurrentRow.Cells[3].Value).ToShortDateString();
            
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
       
        public void loadDGV() // Vẽ màu vô đây nha (#FORMAT)
        {
            designDGV(dgvContracts);
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
                dc.ID_Mem = dt.Rows[i][1].ToString();

                dc.IDreceipt = dt.Rows[i][2].ToString();
                dc.EmpID = dt.Rows[i][3].ToString().ToUpper();

                try
                {
                    detailContractBindingSource.Add(dc);
                }
                catch
                {

                }
                i++;
            }
        }
        void loadDGVDetails(string conID)
        {
            designDGV(dgvDetailsContract);            
            DataTable dt = new DataTable();
            DETAILCONTRACT db = new DETAILCONTRACT();
            dt = db.getDetailByConID(conID);
            dgvDetailsContract.DataSource = dt;
            dgvDetailsContract.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        //Search

        bool searchMemID()
        {
            string searchValue = txtSearch.Text.ToUpper();
            int flag = 0;
            dgvContracts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dgvDetailsContract.Rows)
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
        void searchConID()
        {
            string searchValue = txtSearch.Text.ToUpper();

        }
        void designDGV(DataGridView dgv)
        {
            dgv.RowTemplate.Height = 50;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgv.AllowUserToAddRows = false;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}