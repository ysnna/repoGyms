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
    public partial class DisplayMembersUC : UserControl
    {
        public DisplayMembersUC()
        {
            InitializeComponent();
        }

        private void DisplayMembersUC_Load(object sender, EventArgs e)
        {
            homeUCMember.Location = new Point(2, 2);
            accountMemberUC.Location = new Point(2, 2);
            homeUCMember.BringToFront();
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            panelClick.BringToFront();
            panelClick.Height = btHome.Height;
            panelClick.Top = btHome.Top;
            homeUCMember.BringToFront();
        }

        private void btAccount_Click(object sender, EventArgs e)
        {
            panelClick.BringToFront();
            panelClick.Height = btHome.Height;
            panelClick.Top = btHome.Top;
            accountMemberUC.BringToFront();
        }
    }
}