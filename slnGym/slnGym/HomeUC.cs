using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnGym
{
    public partial class HomeUC : UserControl
    {
        public HomeUC()
        {
            InitializeComponent();
        }

        private void btMachine_Click(object sender, EventArgs e)
        {
            pictureBoxClass.SendToBack();
            pictureBoxProduct.SendToBack();
        }

        private void HomeUC_Load(object sender, EventArgs e)
        {
            pictureBoxProduct.SendToBack();
            pictureBoxClass.SendToBack();
        }

        private void btProduct_Click(object sender, EventArgs e)
        {
            pictureBoxClass.SendToBack();
            pictureBoxMachine.SendToBack();
        }

        private void btClass_Click(object sender, EventArgs e)
        {
            pictureBoxMachine.SendToBack();
            pictureBoxProduct.SendToBack();
        }

        private void btAddMachine_Click(object sender, EventArgs e)
        {
            AddForm.AddMachines addMachines = new AddForm.AddMachines();
            addMachines.ShowDialog();
        }
    }
}