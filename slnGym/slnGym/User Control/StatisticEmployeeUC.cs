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
    public partial class StatisticEmployeeUC : UserControl
    {
        public StatisticEmployeeUC()
        {
            InitializeComponent();
        }

        Statistic statistic = new Statistic();
        STATISTICS STATISTICS = new STATISTICS();

        private void StatisticEmployeeUC_Load(object sender, EventArgs e)
        {
            loadStatistic();
        }
        public void loadStatistic()
        {
            dgvStatistic.RowTemplate.Height = 50;
            dgvStatistic.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvStatistic.AllowUserToAddRows = false;
            dgvStatistic.EditMode = DataGridViewEditMode.EditProgrammatically;

            DataTable dtP = STATISTICS.getSTATISTIC(1);
            int lenght = dtP.Rows.Count;
            DataTable dtPr = STATISTICS.getSTATISTIC(2);
            int lenghtPR = dtPr.Rows.Count;
            if (lenght > 0 && lenghtPR > 0)
            {
                for (int i = 0; i < lenght; i++)
                {
                    statistic = new Statistic();
                    statistic.Group = "Package";
                    statistic.Date = Convert.ToDateTime(dtP.Rows[i][0]);
                    statistic.Amount = Convert.ToInt32(dtP.Rows[i][2]);
                    statistic.Total = Convert.ToDecimal(dtP.Rows[i][3]);
                    statistic.Status = null;
                    statisticBindingSource.Add(statistic);
                    if (i < lenghtPR)
                    {
                        statistic = new Statistic();
                        statistic.Group = "Product";
                        statistic.Date = Convert.ToDateTime(dtPr.Rows[i][0]);
                        statistic.Amount = Convert.ToInt32(dtPr.Rows[i][2]);
                        statistic.Total = Convert.ToDecimal(dtPr.Rows[i][3]);
                        statistic.Status = null;
                        statisticBindingSource.Add(statistic);
                    }
                }
            }
            // dgvStatistic.Sort = "repceiptDate ASC";
        }
    }
}
