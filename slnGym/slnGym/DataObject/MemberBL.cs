using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using slnGym.DataObject;
using slnGym.Layer;
using System.Data.SqlClient;
using System.Data;

namespace slnGym.DataObject
{
    public class MemberBL
    {
        public void LoadDGVPackage(DataGridView dgv, string idKH) 
        {
            dgv.RowTemplate.Height = 50;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgv.AllowUserToAddRows = false;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            //
            SERVICEPACKs ser = new SERVICEPACKs();
            DataTable dt = new DataTable();
            dt = ser.getPackageDGV(idKH);
            dgv.DataSource = dt;
            dgv.Refresh();
        }
        public void loadDGVProduct(DataGridView dgv, string id)
        {
            dgv.RowTemplate.Height = 50;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgv.AllowUserToAddRows = false;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;

            PRODUCTs ser = new PRODUCTs();
            DataTable dt = new DataTable();
            dt = ser.getPRODUCTDGV(id);
            dgv.DataSource = dt;
            dgv.Refresh();
        }
        public void loadDGVPT(DataGridView dgv, string id)
        {
            dgv.RowTemplate.Height = 50;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgv.AllowUserToAddRows = false;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;

            EMPLOYEEs ser = new EMPLOYEEs();
            DataTable dt = new DataTable();
            dt = ser.getPTbyMemID(id);
            dgv.DataSource = dt;
            dgv.Refresh();
        }
    }
}