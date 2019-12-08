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
            disTime();
        }

        private void dgvContracts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string index = dgvContracts.CurrentRow.Cells[0].Value.ToString();
            designDGV(dgvDetailsContract);
        }
        private void DetailsConrtactUC_Load(object sender, EventArgs e)
        {
            //loadDGV();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
         
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
    }
}