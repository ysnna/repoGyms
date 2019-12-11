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
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Net.NetworkInformation;
using System.Threading;

namespace slnGym.Forms
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        ListContract listContract = new ListContract();
        List<ListContract> getListContract = new List<ListContract>();
        User_Control.AccountEmployeeUC dt = new User_Control.AccountEmployeeUC() { Width = 1912, Height = 905 };

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
            btInvoikeCheck();
        }

        private void btResfresh_Click(object sender, EventArgs e)
        {
            RefreshUC();
            getListContract.Clear();
            listContractBindingSource.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GLOBAL.username != "")
            {
                SysLOG.DateLogout = DateTime.Now.ToString();
                ///
                ///accountLog.updateAccount(SysLOG.UserName, SysLOG.DateLogin, SysLOG.DateLogout, SysLOG.Status);
                ///
            }
            this.Close();
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

        private void btReset_Click(object sender, EventArgs e)
        {
            txtIDPT.Text = "";
            txtPT.Text = "";
        }

        private void tabControl_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {

            }
            else if (tabControl.SelectedIndex == 1)
            {

                createMemberLoad();
                loadContract();
                groupBoxNewContract.Visible = false;
                groupBoxRenew.Visible = false;
            }
            else
            {
                //loadAccount();
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login(this);
            login.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbDateTime.Text = DateTime.Now.ToString("dddd, dd MMM yyyy HH:mm:ss");
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            datePickerEnd.Value = datePickerStart.Value.AddMonths(Convert.ToInt32(numericMonth.Value));
            dateEndRenew.Value = dateStartRenew.Value.AddMonths(Convert.ToInt32(numericRenew.Value));
            dateEndNew.Value = dateStartNew.Value.AddMonths(Convert.ToInt32(numericNew.Value));
            dateEndCommon.Value = dateStartCommon.Value.AddMonths(Convert.ToInt32(numericCommon.Value));
           
            //home
            loadMachine();
            loadProduct();
            loadServicePackage();
            //contract
            loadContract();
            loadDetailsContract();
            loadMembers();
            //renew
            loadMemberToRenew();
            loadPackageToRenew();
            //common
            loadMemberToCommon();
            //loadStatistic();
            NeedLogin();

            logoutToolStripMenuItem.Visible = false;
            managerToolStripMenuItem.Enabled = false;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NeedLogin();
            refreshCommon();
            RefreshUC();
            getListContract.Clear();
            listContractBindingSource.Clear();
            SysLOG.DateLogout = DateTime.Now.ToString();
            ///accountLog.updateAccount(SysLOG.UserName, SysLOG.DateLogin, SysLOG.DateLogout, SysLOG.Status);
            ///
            ///
            loginToolStripMenuItem.Visible = true;
            logoutToolStripMenuItem.Visible = false;
            managerToolStripMenuItem.Enabled = true;
        }

        private void managerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administration administration = new Administration(this);
            administration.ShowDialog();
        }

        //HÀM XỬ LÝ
        public void loadMachine()
        {
            flowLayoutMachine.Controls.Clear();
            List<ListMachine> listMachines = new List<ListMachine>();
            string sql = @"EXEC proLOADMachines";
            DataTable dt = mydb.createTable(sql);
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
        MY_DB mydb = new MY_DB();
        public void loadProduct()
        {
            flowLayoutProduct.Controls.Clear();
            List<ListProduct> listProducts = new List<ListProduct>();
            string sql = @"EXEC proLOADProduct";
            DataTable dt = mydb.createTable(sql);
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
            flowLayoutProduct.Controls.Clear();
            List<ListProduct> listProducts = new List<ListProduct>();
            string sql = @"EXEC proLOADService";
            DataTable dt = mydb.createTable(sql);
            dgvServicePack.DataSource = dt;
            dgvServicePack.RowTemplate.Height = 60;
            dgvServicePack.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvServicePack.AllowUserToAddRows = false;
            dgvServicePack.EditMode = DataGridViewEditMode.EditProgrammatically;
            ////dgvServicePack.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void RefreshUC()
        {
            txtFname.Text = "";
            txtLname.Text = "";
            txtIDCard.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtNote.Text = "";
            txtNamePartyMember.Text = "";
            txtPassword.Text = "";
            radioFemale.Checked = false;
            radioMale.Checked = true;
            dateTimePickerBdate.Value = DateTime.Now;
            picAvaEdit.Image = picAvaEdit.BackgroundImage;
            numericMonth.Value = 1;
            datePickerStart.Value = DateTime.Now;
            datePickerEnd.Value = datePickerStart.Value.AddMonths(Convert.ToInt32(numericMonth.Value));
            txtPackage.Text = "";
            txtNamePack.Text = "";
            txtIDPT.Text = "";
            txtPT.Text = "";
        }

        public void loadContract()
        {
            dgvPackage.RowTemplate.Height = 40;
            dgvPackage.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvPackage.AllowUserToAddRows = false;
            dgvPackage.EditMode = DataGridViewEditMode.EditProgrammatically;

            txtIDSeller.Text = GLOBAL.username.ToUpper();
            ///
            ///
            ///
            ////else txtNameSeller.Text = "Admin";
            ///
            ///Lấy KH và Contract ID tự động
            ///
            ///
            txtUserID.Text = txtIDMember.Text;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                loadListContract();
                listContract = new ListContract();
                listContract.idPT = txtIDPT.Text;
                listContract.idPackage = Convert.ToInt32(txtPackage.Text);
                listContract.namePackage = txtNamePack.Text;
                listContract.dateStart = Convert.ToDateTime(datePickerStart.Value);
                listContract.dateDischarge = Convert.ToDateTime(datePickerEnd.Value);
                listContract.status = numericMonth.Value.ToString() + " Month(s)";
                listContract.period = Convert.ToInt32(numericMonth.Value);
                listContract.price = GETContract.Price;
                getListContract.Add(listContract);
                listContractBindingSource.Add(listContract);
            }
            catch (Exception E)
            {
                MessageBox.Show("Vui Long Nhap Thông Tin Huấn Luyện Viên! ");
            }
            finally
            {


            }
        }

        public void CreateContract()
        {
            if (!verif())
            {
                #region Create member
                GETMember.IDMember = txtUserID.Text;
                GETMember.Password = txtPassword.Text;
                GETMember.FName = txtFname.Text;
                GETMember.LName = txtLname.Text;
                GETMember.Birthday = dateTimePickerBdate.Value;
                GETMember.Picture = picAvaEdit.Image;
                GETMember.Address = txtAddress.Text;
                GETMember.Gender = 0;
                if (radioFemale.Checked == true)
                    GETMember.Gender = 1;
                GETMember.Phone = txtPhone.Text;
                if (txtIDCard.Text != null)
                {
                    GETMember.IDCard = Convert.ToInt32(txtIDCard.Text);
                }
                else GETMember.IDCard = 0;
                GETMember.Note = txtNote.Text;
                #endregion

                #region Create Contract
                GETContract.IDContract = txtIDContract.Text;
                GETContract.listContracts = getListContract;
                #endregion
            }
        }

        public void loadDetailsContract()
        {
            User_Control.DetailsConrtactUC dt = new User_Control.DetailsConrtactUC() { Width = 1912, Height = 905 };
            this.tabDetailsContract.Controls.Add(dt);
        }

        public void loadMembers()
        {
            User_Control.MemberUC dt = new User_Control.MemberUC() { Width = 1912, Height = 905 };
            this.tabMember.Controls.Add(dt);
        }

        public void loadStatistic()
        {
            //User_Control.StatisticEmployeeUC dt = new User_Control.StatisticEmployeeUC() { Width = 1912, Height = 905 };
            //this.tabStatistic.Controls.Add(dt);
        }

        public void loadAccount()
        {
            this.tabAccount.Controls.Add(dt);
            dt.reload();
        }

        public void loadPTbyTag()
        {
            dgvPT.RowTemplate.Height = 40;
            dgvPT.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvPT.AllowUserToAddRows = false;
            dgvPT.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        public void loadListContract()
        {
            dgvListContract.RowTemplate.Height = 40;
            dgvListContract.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvListContract.AllowUserToAddRows = false;
            dgvListContract.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvPackage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadPTbyTag();
            int numrow = dgvPackage.CurrentCell.RowIndex;
            string tag = dgvPackage.Rows[numrow].Cells[3].Value.ToString();
            ///
            ////dgvPT.DataSource = sv.getNamePTbyPackage(tag);
            ///
            txtPackage.Text = dgvPackage.Rows[numrow].Cells[0].Value.ToString();
            txtNamePack.Text = dgvPackage.Rows[numrow].Cells[1].Value.ToString();
            GETContract.Price = Convert.ToDecimal(dgvPackage.Rows[numrow].Cells[2].Value);
            GETContract.NamePackage = txtNamePack.Text;
        }

        public static string convertToUnSign3(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }

        public void reloadDGVPacket()
        {
            ///
            ///
            ///

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

        public void NeedLogin()
        {
            tabControlManager.Enabled = false;
            this.tabAccount.Controls.Remove(dt);
        }

        public void AccessSuccess()
        {
            tabControlManager.Enabled = true;
            if (GLOBAL.username != "admin")
                loadAccount();
            loadContract();
        }

        bool verif()
        {
            try
            {
                MemoryStream picture = new MemoryStream();
                picAvaEdit.Image.Save(picture, picAvaEdit.Image.RawFormat);
            }
            catch (Exception Ex)
            {
                return true;
            }
            
            if (txtFname.Text.Trim() == "" || txtLname.Text.Trim() == "" ||
                txtIDCard.Text.Trim() == "" || txtPhone.Text.Trim() == "" ||
                txtAddress.Text.Trim() == "" )
                return true;
            else 
                return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (GLOBAL.username != "")
            {
                SysLOG.DateLogout = DateTime.Now.ToString();
                ///
                ///accountLog.updateAccount(SysLOG.UserName, SysLOG.DateLogin, SysLOG.DateLogout, SysLOG.Status);
                ///
            }
            this.Close();
        }

        private void dgvListContract_DoubleClick(object sender, EventArgs e)
        {
            int index = dgvListContract.CurrentCell.RowIndex;
            if (dgvListContract.SelectedRows.Count > 0)
            {
                dgvListContract.Rows.RemoveAt(dgvListContract.CurrentRow.Index);
                getListContract.Remove(listContract);
            }
        }

        public void loadDVG(DataGridView dataGridView)
        {
            dataGridView.RowTemplate.Height = 40;
            dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridView.AllowUserToAddRows = false;
            dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        public void loadMemberToRenew()
        {
            loadDVG(dgvSearchMember);
            ///
            ///dgvSearchMember.DataSource = mem.getRenewMember();
            ///
        }

        public void loadPackageToRenew()
        {
            dgvPackageNewContract.RowTemplate.Height = 40;
            dgvPackageNewContract.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvPackageNewContract.AllowUserToAddRows = false;
            dgvPackageNewContract.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        public void getInfoMember()
        {
            ///
            ////DataTable dt = mem.getMemberbyID(GETMember.IDMember);
            ///
        }

        private void txtSearchContract_KeyUp(object sender, KeyEventArgs e)
        {
            ////dgvSearchMember.DataSource = mem.searchRenewMember(txtSearchContract.Text);
            ///
        }

        private void dgvSearchMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvSearchMember.CurrentCell.RowIndex;
            GETMember.IDMember = dgvSearchMember.Rows[index].Cells[0].Value.ToString();
            txtIsMember.Text = GETMember.IDMember;
            ///
            ///
            ///
            loadDVG(dgvSearchContract);
            ///
            ////dgvSearchContract.DataSource = mem.getRenewMemberByID(GETMember.IDMember);
            ///
        }

        private void dgvSearchContract_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvSearchContract.CurrentCell.RowIndex;
            GETContract.IDContract = dgvSearchContract.Rows[index].Cells[0].Value.ToString();
            GETContract.IDPT = dgvSearchContract.Rows[index].Cells[1].Value.ToString();
            GETContract.IDPackage = Convert.ToInt32(dgvSearchContract.Rows[index].Cells[2].Value);
            GETContract.NamePackage = dgvSearchContract.Rows[index].Cells[3].Value.ToString();
            GETContract.Price = Convert.ToDecimal(dgvSearchContract.Rows[index].Cells[6].Value);
            GETContract.Start = Convert.ToDateTime(dateStartRenew.Value);
            GETContract.End = Convert.ToDateTime(dateEndRenew.Value);
        }

        private void dgvRenew_DoubleClick(object sender, EventArgs e)
        {
            int index = dgvRenew.CurrentCell.RowIndex;
            if (dgvRenew.SelectedRows.Count > 0)
            {
                dgvRenew.Rows.RemoveAt(dgvRenew.CurrentRow.Index);
                getListContract.Remove(listContract);
            }
        }

        private void btAddRenew_Click(object sender, EventArgs e)
        {
            loadDVG(dgvRenew);
            listContract = new ListContract();
            listContract.idPT = GETContract.IDPT;
            listContract.idPackage = GETContract.IDPackage;
            listContract.namePackage = GETContract.NamePackage;
            listContract.dateStart = GETContract.Start;
            listContract.dateDischarge = GETContract.End;
            listContract.status = numericRenew.Value.ToString() + " Month(s)";
            listContract.period = Convert.ToInt32(numericRenew.Value);
            listContract.price = GETContract.Price;
            getListContract.Add(listContract);
            listContractBindingSource.Add(listContract);
        }

        private void numericRenew_ValueChanged(object sender, EventArgs e)
        {
            dateEndRenew.Value = dateStartRenew.Value.AddMonths(Convert.ToInt32(numericRenew.Value));
        }

        private void dateStartRenew_ValueChanged(object sender, EventArgs e)
        {
            dateEndRenew.Value = dateStartRenew.Value.AddMonths(Convert.ToInt32(numericRenew.Value));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Renew")
            {
                groupBoxRenew.Visible = true;
                groupBoxNewContract.Visible = false;
                GETContract.ISRENEW = "renew";
            }
            else
            {
                groupBoxNewContract.Visible = true;
                groupBoxRenew.Visible = false;
                GETContract.ISRENEW = "addnew";
            }
            getListContract.Clear();
            listContractBindingSource.Clear();
        }

        private void btInvoiceRenew_Click(object sender, EventArgs e)
        {
            if (GETContract.IDContract == "" || GETMember.IDMember == "")
            {
                MessageBox.Show("Please choose a package you want to renew!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                GETContract.listContracts = getListContract;
                getInfoMember();
                MessageBox.Show("complete");
                User_Control.ReceiptUC receiptUC = new User_Control.ReceiptUC() { Width = 1912, Height = 905 };
                this.tabRenew.Controls.Add(receiptUC);
                receiptUC.BringToFront();
            }
        }

        private void dgvPackageNewContract_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvPTNewContract.RowTemplate.Height = 40;
            dgvPTNewContract.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvPTNewContract.AllowUserToAddRows = false;
            dgvPTNewContract.EditMode = DataGridViewEditMode.EditProgrammatically;

            int numrow = dgvPackageNewContract.CurrentCell.RowIndex;
            string tag = dgvPackageNewContract.Rows[numrow].Cells[3].Value.ToString();
            ///
            ////dgvPTNewContract.DataSource = sv.getNamePTbyPackage(tag);
            ///
            txtIDPackageNewContract.Text = dgvPackageNewContract.Rows[numrow].Cells[0].Value.ToString();
            txtNamePackageNewContract.Text = dgvPackageNewContract.Rows[numrow].Cells[1].Value.ToString();
            GETContract.Price = Convert.ToDecimal(dgvPackageNewContract.Rows[numrow].Cells[2].Value);
            GETContract.NamePackage = txtNamePackageNewContract.Text;
        }

        private void dgvPTNewContract_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = dgvPTNewContract.CurrentCell.RowIndex;
            txtIDPTNewContract.Text = dgvPTNewContract.Rows[numrow].Cells[0].Value.ToString();
            txtNamePTNewContract.Text = dgvPTNewContract.Rows[numrow].Cells[1].Value.ToString() + ' ' + dgvPTNewContract.Rows[numrow].Cells[2].Value.ToString();
        }

        private void numericNew_ValueChanged(object sender, EventArgs e)
        {
            dateEndNew.Value = dateStartNew.Value.AddMonths(Convert.ToInt32(numericNew.Value));
        }

        private void dateStartNew_ValueChanged(object sender, EventArgs e)
        {
            dateEndNew.Value = dateStartNew.Value.AddMonths(Convert.ToInt32(numericNew.Value));
        }

        private void btAddNewPackage_Click(object sender, EventArgs e)
        {
            loadDVG(dgvNewContract);
            listContract = new ListContract();
            listContract.idPT = txtIDPTNewContract.Text;
            listContract.idPackage = Convert.ToInt32(txtIDPackageNewContract.Text);
            listContract.namePackage = txtNamePackageNewContract.Text;
            listContract.dateStart = Convert.ToDateTime(dateStartNew.Value);
            listContract.dateDischarge = Convert.ToDateTime(dateEndNew.Value);
            listContract.status = numericNew.Value.ToString() + " Month(s)";
            listContract.period = Convert.ToInt32(numericNew.Value);
            listContract.price = GETContract.Price;
            GETContract.Start = Convert.ToDateTime(dateStartNew.Value);
            GETContract.End = Convert.ToDateTime(dateEndNew.Value);
            getListContract.Add(listContract);
            listContractBindingSource.Add(listContract);
        }

        private void dgvNewContract_DoubleClick(object sender, EventArgs e)
        {
            int index = dgvNewContract.CurrentCell.RowIndex;
            if (dgvNewContract.SelectedRows.Count > 0)
            {
                dgvNewContract.Rows.RemoveAt(dgvNewContract.CurrentRow.Index);
                getListContract.Remove(listContract);
            }
        }

        private void btInvoiceNewContract_Click(object sender, EventArgs e)
        {
            if (txtIsContract.Text == "" || txtIsMember.Text == "")
            {
                MessageBox.Show("Please fill ID member and ID contract", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                GETContract.IDContract = txtIsContract.Text;
                GETContract.listContracts = getListContract;
                getInfoMember();
                MessageBox.Show("complete");
                User_Control.ReceiptUC receiptUC = new User_Control.ReceiptUC() { Width = 1912, Height = 905 };
                this.tabRenew.Controls.Add(receiptUC);
                receiptUC.BringToFront();
            }
        }

        private void txtCheckComon_KeyUp(object sender, KeyEventArgs e)
        {
            ///
            ////dgvMemberComon.DataSource = mem.searchRenewMember(txtCheckComon.Text);
            ///
        }

        public void loadMemberToCommon()
        {
            loadDVG(dgvMemberComon);
            ///
            ////dgvMemberComon.DataSource = mem.getRenewMember();
            ///
        }

        bool verifCommon()
        {
            if (txtFNameMemberCommon.Text.Trim() == "" || txtLNameCommon.Text.Trim() == null || txtIDCardCommon.Text.Trim() == null ||
                txtPhoneCommon.Text.Trim() == "" || txtAddressCommon.Text.Trim() == null)
                return false;
            else return true ;
        }

        private void comboPackage_SelectedIndexChanged(object sender, EventArgs e)
        {
            getListContract.Clear();
            listContractBindingSource.Clear();

            if (comboPackage.Text == "Renew")
            {
                GETContract.Start = Convert.ToDateTime(dateStartCommon.Value);
                GETContract.Period = Convert.ToInt32(numericCommon.Value);
                GETContract.ISRENEW = "recommon";
                groupBoxCheckComon.Visible = true;
            }
            else if (comboPackage.Text == "Buy packages")
            {
                GETContract.Start = Convert.ToDateTime(dateStartCommon.Value);
                GETContract.Period = Convert.ToInt32(numericCommon.Value);
                GETContract.ISRENEW = "buypackages";
                groupBoxCheckComon.Visible = false;
            }
            else
            {
                GETContract.ISRENEW = "buyproducts";
                groupBoxCheckComon.Visible = true;
            }
        }

        private void dateStartCommon_ValueChanged(object sender, EventArgs e)
        {
            dateEndCommon.Value = dateStartCommon.Value.AddMonths(Convert.ToInt32(numericCommon.Value));
        }

        private void numericCommon_ValueChanged(object sender, EventArgs e)
        {
            dateEndCommon.Value = dateStartCommon.Value.AddMonths(Convert.ToInt32(numericCommon.Value));
        }

        private void dateEndCommon_ValueChanged(object sender, EventArgs e)
        {
            dateStartCommon.Value = dateEndCommon.Value.AddMonths(Convert.ToInt32(numericCommon.Value) * (-1));
        }

        private void btRefreshCommon_Click(object sender, EventArgs e)
        {
            refreshCommon();
        }
        
        private void btToInvoiceCommon_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream picture = new MemoryStream();
                picAvatarCommon.Image.Save(picture, picAvatarCommon.Image.RawFormat);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Vui lòng nhập hình ảnh!");
            }
             if (!IsNumber(txtPhoneCommon.Text) || !IsNumber(txtIDCardCommon.Text))
            {
                MessageBox.Show("Please Insert Numberic!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!verifCommon())
            {
                MessageBox.Show("Please fill information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                getInfoMember();
                MessageBox.Show("complete");
                User_Control.ReceiptUC receiptUC = new User_Control.ReceiptUC() { Width = 1912, Height = 905 };
                this.tabPackage.Controls.Add(receiptUC);
                receiptUC.BringToFront();
            }
        }

        private void dgvMemberComon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvMemberComon.CurrentCell.RowIndex;
            GETMember.IDMember = dgvMemberComon.Rows[index].Cells[0].Value.ToString();
            txtIDMemberCommon.Text = GETMember.IDMember;
            loadDVG(dgvPackageComon);

            ///
            ////dgvPackageComon.DataSource = mem.getMemberbyPackage(GETMember.IDMember);
            ///
        }

        private void txtLNameCommon_TextChanged(object sender, EventArgs e)
        {
            txtPasswordCommon.Text = convertToUnSign3(txtLNameCommon.Text.Trim()).ToLower() + txtIDMemberCommon.Text;
        }

        private void picAvatarCommon_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
                picAvatarCommon.Image = Image.FromFile(open.FileName);
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

        void btInvoikeCheck()
        {
            if (txtNamePack.Text.Trim() == "" || txtPT.Text.Trim() == "")
            {
                MessageBox.Show("Please choose your Package", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!IsNumber(txtPhone.Text) || !IsNumber(txtIDCard.Text))
            {
                MessageBox.Show("Please Insert Numberic!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif() == true)
            {
                MessageBox.Show("Please Insert More Infomation!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("completeasdsasd");
                CreateContract();
                GETContract.ISRENEW = "new";
                User_Control.ReceiptUC receiptUC = new User_Control.ReceiptUC() { Width = 1912, Height = 905 };
                this.tabNewMember.Controls.Add(receiptUC);
                receiptUC.BringToFront();
            }
        }

        void refreshCommon()
        {
            txtFNameMemberCommon.Text = "";
            txtLNameCommon.Text = "";
            txtIDCardCommon.Text = "";
            radioMaleCommon.Checked = true;
            txtPhoneCommon.Text = "";
            txtNoteCommon.Text = "";
            dateTimeBirthdayCommon.Value = DateTime.Now;
            txtAddressCommon.Text = "";
            picAvatarCommon.Image = picAvatarCommon.BackgroundImage;
            dateStartCommon.Value = DateTime.Now;
            numericCommon.Value = 1;
            dateEndCommon.Value = dateStartCommon.Value.AddMonths(Convert.ToInt32(numericCommon.Value));
            comboPackage.Text = "---Select category---";
            txtPasswordCommon.Text = "";
            txtIDMemberCommon.Text = "";
            getListContract.Clear();
            listContractBindingSource.Clear();
        }

        private void flowLayoutProduct_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}