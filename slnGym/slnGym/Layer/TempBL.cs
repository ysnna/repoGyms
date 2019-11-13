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
    public class TempBL
    {
        MEMBERs mem = new MEMBERs();
       public bool existCheck()
        {
            if ( mem.getTEMP().Rows.Count >0)
            {
                return true;
            }
            return false;
        }
        public int RequestCount()
        {
            int count =0;
            if (mem.getTEMP().Rows.Count > 0)
            {
                count = mem.getTEMP().Rows.Count;
               
            }
            return count;
        }
        public void loadDGVTEMP(DataGridView dgv)
        {
            dgv.RowTemplate.Height = 50;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgv.AllowUserToAddRows = false;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;

            dgv.DataSource = mem.getTEMP();
            
            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            pic = (DataGridViewImageColumn)dgv.Columns[3];
            pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
       public DataTable loadInfoOld(string ID)
        {
            DataTable dt = new DataTable();
            dt = mem.getMemberbyID(ID);
            return dt;
        }
    }
}
