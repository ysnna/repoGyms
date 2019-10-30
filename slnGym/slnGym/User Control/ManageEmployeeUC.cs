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
    public partial class ManageEmployeeUC : UserControl
    {
        public ManageEmployeeUC()
        {
            InitializeComponent();
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            newEmployeeUC.BringToFront();
            newEmployeeUC.Visible = true;
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            editEmployeeUC.BringToFront();
            editEmployeeUC.Visible = true;
        }

        private void ManageEmployeeUC_Load(object sender, EventArgs e)
        {
            newEmployeeUC.Visible = false;
            editEmployeeUC.Visible = false;
        }
    }
}