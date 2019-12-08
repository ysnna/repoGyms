using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using slnGym.Layer;
using System.IO;

namespace slnGym.User_Control
{
    public partial class EditEmployeeUC : UserControl
    {
        public EditEmployeeUC()
        {
            InitializeComponent();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            MemoryStream pic = new MemoryStream();
            picAvaEdit.Image.Save(pic, picAvaEdit.Image.RawFormat);
           
            this.Dispose();
        }

        private void EditEmployeeUC_Load(object sender, EventArgs e)
        {
            loadGroupEmployee();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void picAvaEdit_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
                picAvaEdit.Image = Image.FromFile(open.FileName);
        }

        public void loadGroupEmployee()
        {
            GROUPEMPLOYEE grEmp = new GROUPEMPLOYEE();
            cbGroupName.DataSource = grEmp.getGROUPEMP();
            cbGroupName.DisplayMember = "groupName";
            cbGroupName.ValueMember = "groupID";
        }

        private void cbGroupName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGroupName.Text.ToString() == "Salesman")
            {
                txtGroupID.Text = "01";
            }
            else txtGroupID.Text = "02";
        }
    }
}