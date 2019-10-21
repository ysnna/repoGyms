using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

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
            populateItems();
        }

        User_Control.ListMachine[] listMachines = new User_Control.ListMachine[5];

        private void populateItems()
        {
            for (int i = 0; i < listMachines.Length; i++)
            {
                listMachines[i] = new User_Control.ListMachine();
                listMachines[i].Size = new Size(848, 257);
                listMachines[i].NameMachine = "Máy chạy bộ điện";
                listMachines[i].Amount = "10 máy";
                listMachines[i].Info = "Đứng ở vành đai hai bên, chọn tốc độ ban đầu để khởi động. Sau đó tăng từ từ chậm rãi\nTrước khi ngừng khoảng 5 phút thì giảm tốc độ\nLưu ý: không được tắt máy đột ngột, vì khiến máy dễ hỏng và làm bạn dễ vấp ngã";
                if (flowLayoutPanel.Controls.Count < 0)
                    flowLayoutPanel.Controls.Clear();
                else flowLayoutPanel.Controls.Add(listMachines[i]);
            }
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

        List<Control> listControls = new List<Control>();

        private void btAddMachine_Click(object sender, EventArgs e)
        {
            User_Control.ListMachine addList = new User_Control.ListMachine();
            addList.Size = new Size(848, 257);
            addList.NameMachine = txtName.Text;
            addList.Amount = numericUpDown.Value.ToString() + " máy";
            addList.Info = txtInfoMachine.Text;
            addList.Picture = picZoomMachine.Image;
            flowLayoutPanel.Controls.Add(addList);
            refresh();
        }
        void refresh()
        {
            picZoomMachine.Image = null;
            txtInfoMachine.Text = "";
            txtName.Text = "";
            numericUpDown.Value = 1;
        }
        private void picture_Click(object sender, EventArgs e)
        {
            //PictureBox pic = (PictureBox)sender;
            //Process.Start((string)pic.Tag.ToString());
            picZoomMachine = (PictureBox)sender;
        }
        private void btEditMachine_Click(object sender, EventArgs e)
        {
            AddForm.EditMachines editMachines = new AddForm.EditMachines();
            editMachines.ShowDialog();

        }

        private void btRemoveMachine_Click(object sender, EventArgs e)
        {

        }

        private void btRemoveAll_Click(object sender, EventArgs e)
        {
            foreach (Control control in flowLayoutPanel.Controls)
            {
                listControls.Add(control);
            }
            foreach (Control control in listControls)
            {
                flowLayoutPanel.Controls.Remove(control);
                control.Dispose();
            }

            //foreach (User_Control.ListMachine listMachine in flowLayoutPanel.Controls)
            //{
            //    flowLayoutPanel.Controls.Remove(listMachine);
            //    listMachine.Dispose();
            //}
        }

        private void picMachine_MouseClick(object sender, MouseEventArgs e)
        {
            MouseEventArgs ms = (MouseEventArgs)e;
            if (e.Button == System.Windows.Forms.MouseButtons.Right) { MessageBox.Show("Right click"); }
            if (e.Button == System.Windows.Forms.MouseButtons.Left) { MessageBox.Show("Left click"); }
        }

        private void btUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
                picZoomMachine.Image = Image.FromFile(open.FileName);
        }
    }
}