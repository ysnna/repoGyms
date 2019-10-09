using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnGym.User_Control
{
    public partial class DisplayAdminUC : UserControl
    {
        public DisplayAdminUC()
        {
            InitializeComponent();
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            panelClick.BringToFront();
            panelClick.Height = btHome.Height;
            panelClick.Top = btHome.Top;
            homeUCAdmin.BringToFront();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            panelClick.BringToFront();
            panelClick.Height = btLogin.Height;
            panelClick.Top = btLogin.Top;
        }

        private void btEmployee_Click(object sender, EventArgs e)
        {
            panelClick.BringToFront();
            panelClick.Height = btEmployee.Height;
            panelClick.Top = btEmployee.Top;
        }

        private void btMember_Click(object sender, EventArgs e)
        {
            panelClick.BringToFront();
            panelClick.Height = btMember.Height;
            panelClick.Top = btMember.Top;
        }

        private void btContract_Click(object sender, EventArgs e)
        {
            panelClick.BringToFront();
            panelClick.Height = btContract.Height;
            panelClick.Top = btContract.Top;
        }

        private void btReceipt_Click(object sender, EventArgs e)
        {
            panelClick.BringToFront();
            panelClick.Height = btReceipt.Height;
            panelClick.Top = btReceipt.Top;
        }

        private void btStatistic_Click(object sender, EventArgs e)
        {
            panelClick.BringToFront();
            panelClick.Height = btStatistic.Height;
            panelClick.Top = btStatistic.Top;
        }

        private void DisplayAdminUC_Load(object sender, EventArgs e)
        {
            panelAdmin.Location = new Point(3, 3);
            panelClick.Height = btHome.Height;
            homeUCAdmin.BringToFront();
            
        }
    }
}