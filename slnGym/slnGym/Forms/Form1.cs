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
using System.Text.RegularExpressions;

namespace slnGym.Forms
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        Layer.EMPLOYEEs emp = new Layer.EMPLOYEEs();
        Layer.CONTRACTs contract = new CONTRACTs();
        Layer.MEMBERs mem = new MEMBERs();
        Layer.SERVICEPACKs sv = new SERVICEPACKs();

        //Event Click & Load
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
           // txtUserID.Text = "@" + txtPhone.Text;
        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {
            txtNamePartyMember.Text = txtFname.Text + " " + txtLname.Text;
        }

        private void txtLname_TextChanged(object sender, EventArgs e)
        {
            txtNamePartyMember.Text = txtFname.Text + " " + txtLname.Text;
            txtPassword.Text = convertToUnSign3(txtLname.Text.Trim()).ToLower() + txtIDMember.Text;
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {

            }
            else if (tabControl.SelectedIndex == 1)
            {
                this.receiptUC.Visible = false;
                createMemberLoad();
                loadContract();
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

        public void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'packageDataSet.SERVICEPACK' table. You can move, or remove it, as needed.
            this.sERVICEPACKTableAdapter.Fill(this.packageDataSet.SERVICEPACK);
            loadMachine();
            loadProduct();
            loadServicePackage();
            loadContract();
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

        //ham xu ly 
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
                    this.flowLayoutMachine.Controls.Add(bt);
                    this.flowLayoutMachine.Refresh();
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
            dgvServicePack.DataSource = sv.getSERVICE();
            dgvServicePack.RowTemplate.Height = 70;
            dgvServicePack.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvServicePack.AllowUserToAddRows = false;
            dgvServicePack.EditMode = DataGridViewEditMode.EditProgrammatically;
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

        public void loadContract()
        {
            dgvPackage.RowTemplate.Height = 40;
            dgvPackage.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvPackage.AllowUserToAddRows = false;
            dgvPackage.EditMode = DataGridViewEditMode.EditProgrammatically;
            
            DataTable empDT = new DataTable();
            DataTable dtcontract = new DataTable();
            DataTable dtmem = new DataTable();

            txtIDSeller.Text = GLOBAL.username;
            empDT = emp.getEmployeebyID(GLOBAL.username);
            if (empDT.Rows.Count > 0)
            {
                txtNameSeller.Text = empDT.Rows[0][3].ToString() + " " + empDT.Rows[0][4].ToString();
            }

            dtcontract = contract.getCONTRACTS();
            int countRowContract = dtcontract.Rows.Count;
            if (countRowContract < 10)
            {
                txtIDContract.Text = "CONT0" + (countRowContract + 1).ToString();
            }
            else txtIDContract.Text = "CONT" + (countRowContract + 1).ToString();

            dtmem = mem.getAllMEMBERS();
            int countRowMember = dtmem.Rows.Count;
            txtIDMember.Text = "kh" + (countRowMember + 1).ToString();
            txtUserID.Text = txtIDMember.Text;

        }

        public void loadPTbyTag()
        {
            dgvPT.RowTemplate.Height = 40;
            dgvPT.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvPT.AllowUserToAddRows = false;
            dgvPT.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvPackage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadPTbyTag();
            int numrow = dgvPackage.CurrentCell.RowIndex;
            string tag = dgvPackage.Rows[numrow].Cells[3].Value.ToString();
            dgvPT.DataSource = sv.getNamePTbyPackage(tag);
            txtPackage.Text= dgvPackage.Rows[numrow].Cells[1].Value.ToString();
        }

        public static string convertToUnSign3(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
    }
}