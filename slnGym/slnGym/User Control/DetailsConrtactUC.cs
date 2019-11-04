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

        private void DetailsConrtactUC_Load(object sender, EventArgs e)
        {
            loadDGV();
        }
        public void loadDGV() // Vẽ màu vô đây nha
        {
            dgvDetailCon.RowTemplate.Height = 50;
            dgvDetailCon.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvDetailCon.AllowUserToAddRows = false;
            dgvDetailCon.EditMode = DataGridViewEditMode.EditProgrammatically;
            //Hàm xử lý Databliding
            DetailContract dc;
            DataTable dt = new DataTable();
            DETAILCONTRACT db = new DETAILCONTRACT();
            dt = db.getDetailConTractDGV();
            int i = 0;
            while (i < dt.Rows.Count) {
                dc = new DetailContract();
                dc.ConID = dt.Rows[i][0].ToString();
                dc.servicePackName = dt.Rows[i][2].ToString();
                dc.DateStart = Convert.ToDateTime(dt.Rows[i][4]);
                dc.DateEnd = Convert.ToDateTime(dt.Rows[i][5]);
                dc.IDreceipt = dt.Rows[i][6].ToString();
                dc.price = Convert.ToDecimal(dt.Rows[i][7]);
                dc.ID_Mem = dt.Rows[i][1].ToString() ;
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
            //dgvDetailCon.Rows[0].Cells["ConID"].Value = dt.Rows[0]["ConID"].ToString();
        }
        void checkOldNew()
        {
           
        }

        private void dgvDetailCon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DetailContract dc = new DetailContract();
            //int index = dgvDetailCon.CurrentCell.RowIndex;
            //txtNameSeller.Text = dc.EmpID.ToString();
        }
    }
}
  
