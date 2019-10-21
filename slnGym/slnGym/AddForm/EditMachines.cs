using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace slnGym.AddForm
{
    public partial class EditMachines : Form
    {
        public EditMachines()
        {
            InitializeComponent();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {

        }

        private void picMachine_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
                picMachine.Image = Image.FromFile(open.FileName);
        }
    }
}