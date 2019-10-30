using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using slnGym.Layer;
using slnGym.DataObject;

namespace slnGym.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {
                //loadMachine();
                //loadProduct();
                //this.loadServicePackage();
            }
            else if (tabControl.SelectedIndex == 1)
            {
                this.receiptUC.Visible = false;
                createMemberLoad();
            }
            else
            {
                this.accountEmployeeUC.reload();
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbDateTime.Text = DateTime.Now.ToString("dddd, dd MMM yyyy HH:mm:ss");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadMachine();
            loadProduct();
            loadServicePackage();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void managerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administration administration = new Administration();
            administration.ShowDialog();
        }

        public void loadMachine()
        {
            flowLayoutMachine.Controls.Clear();
            List<ListMachine> listMachines = new List<ListMachine>();
            ADDMACHINES mc = new ADDMACHINES();
            DataTable dt = new DataTable();
            dt = mc.getMACHINE();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    ListMachine machine = new ListMachine(item);
                    listMachines.Add(machine);
                }
                foreach (ListMachine item in listMachines)
                {
                    Button bt = new Button() { Width = ListMachine.Width, Height = ListMachine.Height };
                    bt.Font = new Font("Times New Roman", 22F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                    bt.ForeColor = Color.Navy;
                    bt.BackColor = flowLayoutMachine.BackColor;
                    bt.BackgroundImage = item.Picture;
                    bt.BackgroundImageLayout = ImageLayout.Zoom;
                    bt.FlatAppearance.BorderColor = Color.Navy;
                    bt.FlatAppearance.BorderSize = 5;
                    bt.FlatStyle = FlatStyle.Flat;
                    bt.Text = item.NameMachine;
                    bt.TextAlign = ContentAlignment.BottomCenter;
                    bt.Tag = item;
                    flowLayoutMachine.Controls.Add(bt);
                    flowLayoutMachine.Refresh();
                }
            }
        }

        public void loadProduct()
        {
            flowLayoutProduct.Controls.Clear();
            List<ListProduct> listProducts = new List<ListProduct>();
            PRODUCTs pd = new PRODUCTs();
            DataTable dt = new DataTable();
            dt = pd.getPRODUCTS();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    ListProduct product = new ListProduct(item);
                    listProducts.Add(product);
                }
                foreach (ListProduct item in listProducts)
                {
                    Button bt = new Button() { Width = ListProduct.Width, Height = ListProduct.Height };
                    bt.Font = new Font("Times New Roman", 22F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                    bt.ForeColor = Color.Navy;
                    bt.BackColor = flowLayoutProduct.BackColor;
                    bt.BackgroundImage = item.picture;
                    bt.BackgroundImageLayout = ImageLayout.Zoom;
                    bt.FlatAppearance.BorderColor = Color.Navy;
                    bt.FlatAppearance.BorderSize = 5;
                    bt.FlatStyle = FlatStyle.Flat;
                    bt.Text = item.Name;
                    bt.TextAlign = ContentAlignment.BottomCenter;
                    bt.Tag = item;
                    flowLayoutProduct.Controls.Add(bt);
                    flowLayoutProduct.Refresh();
                }
            }
        }

        public void loadServicePackage()
        {
            listServices.Items.Clear();
            Layer.SERVICEPACKs sv = new Layer.SERVICEPACKs();
            DataTable dt = new DataTable();
            dt = sv.getSERVICE();
            int i = 0;
            foreach (DataRow item in dt.Rows)
            {
                listServices.Items.Add(item[0].ToString());
                listServices.Items[i].SubItems.Add(item[1].ToString());
                listServices.Items[i].SubItems.Add(item[2].ToString());
                listServices.Items[i].SubItems.Add(item[3].ToString());
                i++;
            }
        }

        private void btInvoice_Click(object sender, EventArgs e)
        {
            this.receiptUC.BringToFront();
            this.receiptUC.Visible = true;
        }

        private void btResfresh_Click(object sender, EventArgs e)
        {
            RefreshUC();
        }

        public void RefreshUC()
        {
            txtFname.Text = "";
            txtLname.Text = "";
            txtIDCard.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtNote.Text = "";
            txtUserID.Text = "";
            txtPassword.Text = "";
            radioFemale.Checked = false;
            radioMale.Checked = true;
            dateTimePickerBdate.Value = DateTime.Now;
            picAvaEdit.Image = picAvaEdit.BackgroundImage;
        }

        public void createMemberLoad()
        {
            radioMale.Checked = true;
        }

        private void picAvaEdit_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
                picAvaEdit.Image = Image.FromFile(open.FileName);
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            txtUserID.Text = "@" + txtPhone.Text;
            txtPassword.Text = txtPhone.Text;
        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {
            txtNamePartyMember.Text = txtLname.Text + " " + txtFname.Text;
        }

        private void txtLname_TextChanged(object sender, EventArgs e)
        {
            txtNamePartyMember.Text = txtLname.Text + " " + txtFname.Text;
        }

    }
}