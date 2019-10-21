using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnGym.AddForm
{
    public partial class PrintPreview : Form
    {
        public PrintPreview()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrintPreview_Load(object sender, EventArgs e)
        {
            flowLayoutPanel.Location = new Point(8, 54);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddForm.Form2 form = new AddForm.Form2();
            form.ShowDialog();
        }
    }
}