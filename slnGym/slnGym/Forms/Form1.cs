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
            //socket = new SocketManager();
        }

        SocketManager socket;
        Layer.EMPLOYEEs emp = new Layer.EMPLOYEEs();
        Layer.CONTRACTs contract = new CONTRACTs();
        Layer.MEMBERs mem = new MEMBERs();
        Layer.SERVICEPACKs sv = new SERVICEPACKs();
        Layer.LOGIN log = new Layer.LOGIN();
        Layer.DETAILCONTRACT detailContract = new Layer.DETAILCONTRACT();
        Layer.RECEIPTs rc = new Layer.RECEIPTs();
        Layer.DETAILCONTRACT dtCont = new Layer.DETAILCONTRACT();
        Layer.AccountBL accountLog = new Layer.AccountBL();
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
                accountLog.updateAccount(SysLOG.UserName, SysLOG.DateLogin, SysLOG.DateLogout, SysLOG.Status);
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
            //// TODO: This line of code loads data into the 'dBMSMembers.tblMEMBERS' table. You can move, or remove it, as needed.
            //this.tblMEMBERSTableAdapter.Fill(this.dBMSMembers.tblMEMBERS);
            //// TODO: This line of code loads data into the 'dBMSServicePack.tblSERVICEPACK' table. You can move, or remove it, as needed.
            this.tblSERVICEPACKTableAdapter.Fill(this.dBMSServicePack.tblSERVICEPACK);
            datePickerEnd.Value = datePickerStart.Value.AddMonths(Convert.ToInt32(numericMonth.Value));
            dateEndRenew.Value = dateStartRenew.Value.AddMonths(Convert.ToInt32(numericRenew.Value));
            dateEndNew.Value = dateStartNew.Value.AddMonths(Convert.ToInt32(numericNew.Value));
            dateEndCommon.Value = dateStartCommon.Value.AddMonths(Convert.ToInt32(numericCommon.Value));
            panelChat.Visible = false;
            loadMember();
            //home
            loadMachine();
            loadProduct();

            
            dgvServicePack.RowTemplate.Height = 60;
            dgvServicePack.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvServicePack.AllowUserToAddRows = false;
            dgvServicePack.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvServicePack.DataSource = sv.getSERVICE();

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
            getIP();
            logoutToolStripMenuItem.Visible = false;
            managerToolStripMenuItem.Enabled = false;
            
        }
        void loadMember()
        {
            DataTable dt = new DataTable();
            dgvSearchMember.DataSource= mem.getMemberF1();
            dgvMemberComon.DataSource = mem.getMemberF1();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NeedLogin();
            refreshCommon();
            RefreshUC();
            getListContract.Clear();
            listContractBindingSource.Clear();
            SysLOG.DateLogout = DateTime.Now.ToString();
            accountLog.updateAccount(SysLOG.UserName, SysLOG.DateLogin, SysLOG.DateLogout, SysLOG.Status);
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

        public void loadInFoPT()
        {
            dgvInforPT.RowTemplate.Height = 40;
            dgvInforPT.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvInforPT.AllowUserToAddRows = false;
            dgvInforPT.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        public void loadServicePackage()
        {
            dgvServicePack.DataSource = sv.getSERVICE();
            dgvServicePack.RowTemplate.Height = 60;
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

            DataTable empDT = new DataTable();
            txtIDSeller.Text = GLOBAL.username.ToUpper();
            empDT = emp.getEmployeebyID(GLOBAL.username);
            if (empDT.Rows.Count > 0)
            {
                txtNameSeller.Text = empDT.Rows[0][3].ToString() + " " + empDT.Rows[0][4].ToString();
            }
            else txtNameSeller.Text = "Admin";
            //Lấy KH và Contract ID tự động
            ContractBL conbl = new ContractBL();
            txtIDContract.Text = conbl.loadIDContract();
            txtIDMember.Text = conbl.loadIDMEMBER();
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

            #region Create member
            if (!verif())
            {
                GETMember.IDMember = txtUserID.Text;
                GETMember.Password = txtPassword.Text;
                GETMember.FName = txtFname.Text;
                GETMember.LName = txtLname.Text;
                GETMember.Birthday = dateTimePickerBdate.Value;
                GETMember.Picture = picAvaEdit.Image;
                GETMember.Address = txtAddress.Text;
                GETMember.Gender = "Male";
                if (radioFemale.Checked == true)
                    GETMember.Gender = "Female";
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
            }
            
            
            #endregion
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
            string tag = dgvPackage.Rows[numrow].Cells[4].Value.ToString();
            dgvPT.DataSource = sv.getNamePTbyPackage(tag);
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

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //socket.IP = GLOBAL.IPV4;
            //byte[] message = Encoding.ASCII.GetBytes("Test Server");
            //if (socket.ConnectServer())
            //{
            //    socket.CreateServer();
            //    Thread listenThread = new Thread(() =>
            //    {
            //        while (true)
            //        {
            //            Thread.Sleep(500);
            //            try
            //            {
            //                Listen();
            //                break;
            //            }
            //            catch
            //            {

            //            }
            //        }
            //    });
            //    listenThread.IsBackground = true;
            //    listenThread.Start();
            //}
            //else
            //{
            //    Thread listenThread = new Thread(() =>
            //    {
            //        Listen();
            //    });
            //    listenThread.IsBackground = true;
            //    listenThread.Start();
            //    socket.Send("Thông tin từ client");
            //}
        }

        private void btCloseChat_Click(object sender, EventArgs e)
        {
            panelChat.Visible = false;
        }

        private void userLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //tess.Text = GLOBAL.username;
            //panelChat.BringToFront();
            //panelChat.Visible = true;
            //if (GLOBAL.username == "admin")
            //{
            //    serverStart();
            //}
            //else clientConnect();
        }

        private TcpClient client;
        public StreamReader STR;
        public StreamWriter STW;
        public string recieve;
        public String TextToSend;

        void getIP()
        {
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());

            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    GLOBAL.IPV4 = address.ToString();
                }
            }
        }

        private void btSendMessage_Click(object sender, EventArgs e)
        {
            if (txtMessage.Text != "")
            {
                TextToSend = txtMessage.Text;
                backgroundWorker2.RunWorkerAsync();
            }
            txtMessage.Text = "";
        }

        public void serverStart()
        {
            TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(GLOBAL.Port));
            listener.Start();
            client = listener.AcceptTcpClient();
            STR = new StreamReader(client.GetStream());
            STW = new StreamWriter(client.GetStream());
            STW.AutoFlush = true;

            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.WorkerSupportsCancellation = true;
        }

        public void clientConnect()
        {
            client = new TcpClient();
            IPEndPoint IpEnd = new IPEndPoint(IPAddress.Parse(GLOBAL.IPV4), int.Parse(GLOBAL.Port));

            try
            {
                client.Connect(IpEnd);

                if (client.Connected)
                {
                    txtChatScreen.AppendText("Connected to server" + "\r\n");
                    STW = new StreamWriter(client.GetStream());
                    STR = new StreamReader(client.GetStream());
                    STW.AutoFlush = true;
                    backgroundWorker1.RunWorkerAsync();
                    backgroundWorker2.WorkerSupportsCancellation = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    recieve = STR.ReadLine();
                    this.txtChatScreen.Invoke(new MethodInvoker(delegate ()
                    {
                        txtChatScreen.AppendText("Admin: " + recieve + "\r\n");
                    }));
                    recieve = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Server not found", "Cannot connect to server");
                    txtMessage.ReadOnly = true;
                    btSendMessage.Enabled = false;
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (client.Connected)
            {
                STW.WriteLine(TextToSend);
                this.txtChatScreen.Invoke(new MethodInvoker(delegate ()
                {
                    txtChatScreen.AppendText("NV: " + TextToSend + "\r\n");
                }));
            }
            else
            {
                MessageBox.Show("Sending failed");
            }
            backgroundWorker2.CancelAsync();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (GLOBAL.username != "")
            {
                SysLOG.DateLogout = DateTime.Now.ToString();
                accountLog.updateAccount(SysLOG.UserName, SysLOG.DateLogin, SysLOG.DateLogout, SysLOG.Status);
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
            dgvSearchMember.DataSource = mem.getRenewMember();
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
            DataTable dt = mem.getMemberbyID(GETMember.IDMember);
            GETMember.FName = dt.Rows[0][1].ToString();
            GETMember.LName = dt.Rows[0][2].ToString();
            GETMember.Address = dt.Rows[0][5].ToString();
            GETMember.Gender = dt.Rows[0][6].ToString();
            GETMember.Phone = dt.Rows[0][7].ToString();
            GETMember.Note = dt.Rows[0][9].ToString();
        }

        private void txtSearchContract_KeyUp(object sender, KeyEventArgs e)
        {
            dgvSearchMember.DataSource = mem.searchRenewMember(txtSearchContract.Text);
        }

        private void dgvSearchMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvSearchMember.CurrentCell.RowIndex;
            GETMember.IDMember = dgvSearchMember.Rows[index].Cells[0].Value.ToString();
            txtIsMember.Text = GETMember.IDMember;
            ContractBL conbl = new ContractBL();
            txtIsContract.Text = conbl.loadIDContract();
            loadDVG(dgvSearchContract);
            dgvSearchContract.DataSource = mem.getRenewMemberByID(GETMember.IDMember);
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
            string tag = dgvPackageNewContract.Rows[numrow].Cells[4].Value.ToString();
            dgvPTNewContract.DataSource = sv.getNamePTbyPackage(tag);
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
            dgvMemberComon.DataSource = mem.searchRenewMember(txtCheckComon.Text);
        }

        public void loadMemberToCommon()
        {
            loadDVG(dgvMemberComon);
            dgvMemberComon.DataSource = mem.getRenewMember();
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
            dgvPackageComon.DataSource = mem.getMemberbyPackage(GETMember.IDMember);

            DataTable dt = mem.getMemberbyID(GETMember.IDMember);
            txtFNameMemberCommon.Text = dt.Rows[0][1].ToString();
            txtLNameCommon.Text = dt.Rows[0][2].ToString();
            txtIDCardCommon.Text = dt.Rows[0][8].ToString();
            string gender =dt.Rows[0][6].ToString();
            if (gender == "Female")
            {
                radioFemaleCommon.Checked = true;
            }
            radioMaleCommon.Checked = true;
            txtPhoneCommon.Text = dt.Rows[0][7].ToString();
            txtNoteCommon.Text = dt.Rows[0][9].ToString();
            dateTimeBirthdayCommon.Value = Convert.ToDateTime(dt.Rows[0][4]);
            txtAddressCommon.Text = dt.Rows[0][5].ToString();
            try
            {
                byte[] picPD;
                picPD = (byte[])dt.Rows[0][3];
                MemoryStream pic = new MemoryStream(picPD);
                this.picAvatarCommon.Image = Image.FromStream(pic);
            }
            catch
            { }
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
                MessageBox.Show("Complete");
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

        private void dgvServicePack_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadInFoPT();
            int index = dgvServicePack.CurrentCell.RowIndex;
            string tag = dgvPackage.Rows[index].Cells[4].Value.ToString();
            dgvInforPT.DataSource = sv.getNamePTbyPackage(tag);
        }

        private void dgvInforPT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvInforPT.CurrentCell.RowIndex;
            string idPT = dgvInforPT.Rows[index].Cells[0].Value.ToString();
            DataTable dt = emp.getEmployeebyID(idPT);
            if (dt.Rows.Count > 0)
            {
                byte[] pic;
                pic = (byte[])dt.Rows[0][2];
                MemoryStream picedit = new MemoryStream(pic);
                picAva.Image = Image.FromStream(picedit);
                lbName.Text = dt.Rows[0][3].ToString() + " " + dt.Rows[0][4].ToString();
                lbGender.Text = dt.Rows[0][7].ToString();
                lbBdate.Text =Convert.ToDateTime(dt.Rows[0][5]).ToShortDateString();
            }
            DataTable data = emp.getPTbyID(idPT);
            if (data.Rows.Count > 0)
            {
                tbLiteracy.Text = data.Rows[0][1].ToString();
                lbExperience.Text = data.Rows[0][2].ToString();
                tbCertificate.Text = data.Rows[0][3].ToString();
                lbAchievements.Text = data.Rows[0][4].ToString();
            }
        }
    }
}