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
        }

        private void btAccount_Click(object sender, EventArgs e)
        {
            panelClick.BringToFront();
            panelClick.Height = btAccount.Height;
            panelClick.Top = btAccount.Top;
            accountEmployeeUC.BringToFront();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            panelClick.BringToFront();
            panelClick.Height = loginUC.Height;
            panelClick.Top = loginUC.Top;
            loginUC.BringToFront();
        }
    }
}