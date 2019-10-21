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
    public partial class ListMachine : UserControl
    {
        public ListMachine()
        {
            InitializeComponent();
        }

        #region properties
        private string _name;
        private string _amount;
        private string _info;
        private Image _picture;

        public Image Picture
        {
            get { return _picture; }
            set { _picture = value; picMachine.Image = value; }
        }

        public string Info
        {
            get { return _info; }
            set { _info = value; lbDescription.Text = value; }
        }

        public string NameMachine
        {
            get { return _name; }
            set { _name = value; lbName.Text = value; }
        }

        public string Amount
        {
            get { return _amount; }
            set { _amount = value; lbAmount.Text = value; }
        }

        #endregion

        private void ListMachine_Load(object sender, EventArgs e)
        {
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.WrapContents = false;
        }
    }
}