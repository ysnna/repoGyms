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
using System.Data.SqlClient;
namespace slnGym.DataObject
{
    public class MemberBL
    {
        public void loadDGVMem(DataGridView dgv) //Format lại cột BDate của Member (#FORMAT)
        {
            
            dgv.RowTemplate.Height = 50;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgv.AllowUserToAddRows = false;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            MEMBERs mem = new MEMBERs();
            DataTable dt = new DataTable();
            dt = mem.getAllMEMBERS();
            dgv.DataSource = dt;
        }
        public void LoadDGVPackage(DataGridView dgv ,string idKH) //#FORMAT dgv cho đẹp
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
        public void loadDGVProduct(DataGridView dgv,string id)
        {
            dgv.RowTemplate.Height = 50;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgv.AllowUserToAddRows = false;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            //

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
            //

            EMPLOYEEs ser = new EMPLOYEEs();       
            DataTable dt = new DataTable();
            dt = ser.getPTbyMemID(id);
            dgv.DataSource = dt;
            dgv.Refresh();
        }
    }
}
