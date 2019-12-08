using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using slnGym.Layer;

namespace slnGym.User_Control
{
    public partial class NewEmployeeUC : UserControl
    {
        public NewEmployeeUC()
        {
            InitializeComponent();
        }

        private int GenderCheck = 0;
        //Load & Event
        private void btAdd_Click(object sender, EventArgs e)
        {
            
            this.Dispose();
        }

        private void cbGroupName_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void txtGroupID_TextChanged(object sender, EventArgs e)
        {

        }
        private void NewEmployeeUC_Load(object sender, EventArgs e)
        {

        }

        private void picAvaEdit_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
                picAvaEdit.Image = Image.FromFile(open.FileName);
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            lbIDEmployee.Text = txtUsername.Text;
        }
        
        void GenderChecked()
        {
            if (radioMaleEdit.Checked)
            {
                GenderCheck = 1;
            }
        }

        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        bool verif()
        {
            if (txtAddress.Text.Trim() == ""
                || txtFname.Text.Trim() == ""
                || txtIDCard.Text.Trim() == ""
                || txtLname.Text.Trim() == ""
                || txtPhone.Text.Trim() == ""
               || txtSalary.Text.Trim() == ""  )
                return false;
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}