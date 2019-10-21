using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace slnGym.AddForm
{
    public partial class AddMachines : Form
    {
        public AddMachines()
        {
            InitializeComponent();
        }

        Class.ADDMACHINES machine = new Class.ADDMACHINES();

        private void picMachine_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
                picMachine.Image = Image.FromFile(open.FileName);
        }

        void ClearForm()
        {
            txtInfo.Text = "";
            txtName.Text = "";
            numericUpDown.Value = 0;
            picMachine.Image = picMachine.BackgroundImage;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            //if (verif())
            //{
                MemoryStream pic = new MemoryStream();
                picMachine.Image.Save(pic, picMachine.Image.RawFormat);
                string name = txtName.Text;
                string info = txtInfo.Text;
                int amount = Convert.ToInt32(numericUpDown.Value);
                try
                {
                    if (machine.insertMACHINE(name, pic, info, amount))
                    {
                        MessageBox.Show("Add to database is successful", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                    }
                    else MessageBox.Show("Bug rồi");
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            //}
        }

        bool verif()
        {
            if ((txtInfo.Text.Trim() == "") || (txtName.Text.Trim() == "")
                || (picMachine.Image == null))
                return false;
            return true;
        }
    }
}