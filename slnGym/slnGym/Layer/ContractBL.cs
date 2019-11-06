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

namespace slnGym.Layer
{
    public class ContractBL
    {
        EMPLOYEEs emp = new EMPLOYEEs();
        DETAILCONTRACT con = new DETAILCONTRACT();
        MEMBERs mem = new MEMBERs();
        public void loadDGVContract(DataGridView dgv)
        {
            dgv.RowTemplate.Height = 50;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgv.AllowUserToAddRows = false;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            DataTable dt = new DataTable();
            dt = con.getDetailConTractDGV();
            dgv.DataSource = dt;

        }
        public void disPlayID(TextBox txt,DataGridView dgv)
        {
            txt.Text = null;
            txt.Text = dgv.CurrentRow.Cells[1].Value.ToString();
        }
        public void disPlayCusName(TextBox txt, string cusID)
        {
            txt.Text = null;
            DataTable dt = new DataTable();
            dt = mem.getMemberbyID(cusID);
            txt.Text = dt.Rows[0][1].ToString() + " " + dt.Rows[0][2].ToString();
        }
        public void disPlayEmpID(TextBox txt, DataGridView dgv)
        {
            txt.Text = null;
            txt.Text = dgv.CurrentRow.Cells[3].Value.ToString();
        }
        public void disPlayEmpName(TextBox txt, string empID)
        {
            txt.Text = null;
            DataTable dt = new DataTable();
            dt = emp.getEmployeebyID(empID);
            txt.Text = dt.Rows[0][3].ToString() + " " + dt.Rows[0][4].ToString();
        }
    }
}
