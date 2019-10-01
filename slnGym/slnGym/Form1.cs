using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnGym
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loginUC.Location = new Point(350, 0);
            homeUC.Location = new Point(350, 0);
            panelView.Location = new Point(-3, 0);
            panelView.Size = new Size(350, 900);
            panelClick.BringToFront();
            panelClick.Height = btHome.Height;
            panelClick.Top = btHome.Top;
            homeUC.BringToFront();
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            panelClick.BringToFront();
            panelClick.Height = btHome.Height;
            panelClick.Top = btHome.Top;
            homeUC.BringToFront();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            panelClick.BringToFront();
            panelClick.Height = btLogin.Height;
            panelClick.Top = btLogin.Top;
            loginUC.BringToFront();
            btSignIn.BringToFront();
            btSignUp.BringToFront();
        }
    }
}