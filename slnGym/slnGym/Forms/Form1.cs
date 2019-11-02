﻿using System;
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
using System.IO;

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
        Layer.LOGIN log = new Layer.LOGIN();
        Layer.DETAILCONTRACT detailContract = new Layer.DETAILCONTRACT();
        Layer.RECEIPTs rc = new Layer.RECEIPTs();
        Layer.DETAILCONTRACT dtCont = new Layer.DETAILCONTRACT();

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
            CreateContract();
            MessageBox.Show("complete");
            this.receiptUC.BringToFront();
            this.receiptUC.Visible = true;
        }

        public void CreateContract()
        {

            #region Create account
            //try..catch
            if (log.insertLogin(txtUserID.Text.Trim(), txtPassword.Text.Trim(), "2"))
            {
                MessageBox.Show("Added account", "Added..", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Add account fail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            #endregion

            #region Create member
            string id = txtUserID.Text;
            string fname = txtFname.Text;
            string lname = txtLname.Text;
            MemoryStream pic = new MemoryStream();
            picAvaEdit.Image.Save(pic, picAvaEdit.Image.RawFormat);
            DateTime bdate = dateTimePickerBdate.Value;
            string address = txtAddress.Text;
            int gender = 0;
            if (radioFemale.Checked == true)
                gender = 1;
            string phone = txtPhone.Text;
            int idCard = Convert.ToInt32(txtIDCard.Text);
            string note = txtNote.Text;
            if (fname != null && lname != null && pic != null && address != null && phone != null && idCard != '\0')
            {
                if(mem.insertMembers(id, lname, fname, bdate, address, gender, phone, idCard, note))
                    MessageBox.Show("Added Member", "Added..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Added member fail", "Added..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Please insert information", "Added..", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            #endregion

            #region Create Contract
            string idCont = txtIDContract.Text;
            string empID = txtIDSeller.Text;
            string ptID = txtIDPT.Text;
            int idPack = Convert.ToInt32(txtPackage.Text);
            DateTime dateStart = datePickerStart.Value;
            DateTime dateEnd = datePickerEnd.Value;
            string status = "Member";

            if (contract.insertCONTRACTS(idCont, id, ptID, idPack, dateStart, dateEnd, status))
            {
                MessageBox.Show("Added contract", "Added..", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Added contract fail", "Added..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            #endregion

            #region Create DetailsContract
            //DataTable dtReceipt = rc.getRECEIPT();
            //string reID;
            //if (dtReceipt.Rows.Count < 10) reID = "IVC0" + (dtReceipt.Rows.Count + 1).ToString();
            //else reID = "IVC" + (dtReceipt.Rows.Count + 1).ToString();
            //if (dtCont.insertDETAILCON(idCont, empID, reID))
            //{
            //    MessageBox.Show("Added details contract", "Added..", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else MessageBox.Show("Added details contract fail", "Added..", MessageBoxButtons.OK, MessageBoxIcon.Error);

            DataTable dtReceipt = rc.getRECEIPT();
            string reID="IVC03";
            //if (dtReceipt.Rows.Count < 10) reID = "IVC03" + (dtReceipt.Rows.Count + 1).ToString();
            //else reID = "IVC" + (dtReceipt.Rows.Count + 1).ToString();
            if (dtCont.insertDETAILCON("CONT03","nv1", reID))
            {
                MessageBox.Show("Added details contract", "Added..", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Added details contract fail", "Added..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            #endregion
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
            // TODO: This line of code loads data into the 'pTTagDataSet.EMPLOYEE' table. You can move, or remove it, as needed.
            this.eMPLOYEETableAdapter.Fill(this.pTTagDataSet.EMPLOYEE);
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
            Administration administration = new Administration(this);
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
            txtPackage.Text = dgvPackage.Rows[numrow].Cells[0].Value.ToString();
            txtNamePack.Text = dgvPackage.Rows[numrow].Cells[1].Value.ToString();
        }

        public static string convertToUnSign3(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
        public void reloadDGVPacket()
        {
            Layer.SERVICEPACKs sv = new Layer.SERVICEPACKs();
            dgvPackage.DataSource = sv.getSERVICE();
            this.loadServicePackage();
            dgvPackage.Refresh();
            this.Refresh();
        }
        public void reloadDGVProduct()
        {
            loadProduct();
            this.Refresh();
        }
        public void reloadDGVMachines()
        {
            loadMachine();
            this.Refresh();
        }

        private void dgvPT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = dgvPT.CurrentCell.RowIndex;
            txtIDPT.Text = dgvPT.Rows[numrow].Cells[0].Value.ToString();
            txtPT.Text = dgvPT.Rows[numrow].Cells[1].Value.ToString() + ' ' + dgvPT.Rows[numrow].Cells[2].Value.ToString();
        }

        private void datePickerStart_ValueChanged(object sender, EventArgs e)
        {
            datePickerEnd.Value = datePickerStart.Value.AddMonths(Convert.ToInt32(numericMonth.Value));
        }
        private void numericMonth_ValueChanged(object sender, EventArgs e)
        {
            datePickerEnd.Value = datePickerStart.Value.AddMonths(Convert.ToInt32(numericMonth.Value));
        }

        private void btCreateContract_Click(object sender, EventArgs e)
        {
            if (dtCont.insertDETAILCON("CONT03", "nv1", "IVC03"))
            {
                MessageBox.Show("Added details contract", "Added..", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Added details contract fail", "Added..", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}