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

        private void Form1_Load(object sender, EventArgs e)
        {
            displayAdminUC.Location = new Point(0, 0);
            displayEmployeesUC.Location = new Point(0, 0);
            displayMembersUC.Location = new Point(0, 0);
            displayPTsUC.Location = new Point(0, 0);
            loginUC.Location = new Point(0, 0);
            loginUC.BringToFront();
            btSignIn.BringToFront();
            btSignUp.BringToFront();
        }

        private void btSignIn_Click(object sender, EventArgs e)
        {
            displayAdminUC.BringToFront();
        }

        private void btSignUp_Click(object sender, EventArgs e)
        {
            
        }
    }
}