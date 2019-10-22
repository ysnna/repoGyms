using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using slnGym.Layer;

namespace slnGym.User_Control
{
    public partial class DisplayEmployeesUC : UserControl
    {
        public DisplayEmployeesUC()
        {
            InitializeComponent();
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            panelClick.BringToFront();
            panelClick.Height = btHome.Height;
            panelClick.Top = btHome.Top;
            homeUC.BringToFront();
        }

        private void DisplayEmployeesUC_Load(object sender, EventArgs e)
        {
            panelClick.BringToFront();
            panelClick.Height = btHome.Height;
            panelClick.Top = btHome.Top;
            homeUC.BringToFront();
            accountEmployeeUC.Location = new Point(362, 3);
            homeUC.Location = new Point(362, 3);
            newMemberUC.Location = new Point(362, 3);
            detailsConrtactUC.Location = new Point(362, 3);
            receiptUC.Location = new Point(362, 3);
        }
        
        private void btAccount_Click(object sender, EventArgs e)
        {
            panelClick.BringToFront();
            panelClick.Height = btAccount.Height;
            panelClick.Top = btAccount.Top;
            //AccountEmployeeUC account = new AccountEmployeeUC(GLOBAL.username);
            //account.Location = new Point(362, 3);
            //account.BringToFront();

            accountEmployeeUC.BringToFront();
            //accountEmployeeUC(GLOBAL.username);
            //this.accountEmployeeUC(GLOBAL.username);
            this.accountEmployeeUC.reload();
        }

        private void btNNewMember_Click(object sender, EventArgs e)
        {
            panelClick.BringToFront();
            panelClick.Height = btNNewMember.Height;
            panelClick.Top = btNNewMember.Top;
            newMemberUC.BringToFront();
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
            detailsConrtactUC.BringToFront();
        }

        private void btReceipt_Click(object sender, EventArgs e)
        {
            panelClick.BringToFront();
            panelClick.Height = btReceipt.Height;
            panelClick.Top = btReceipt.Top;
            receiptUC.BringToFront();
        }

        private void btStatistic_Click(object sender, EventArgs e)
        {
            panelClick.BringToFront();
            panelClick.Height = btStatistic.Height;
            panelClick.Top = btStatistic.Top;
        }
    }
}