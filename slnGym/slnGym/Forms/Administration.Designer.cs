namespace slnGym.Forms
{
    partial class Administration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administration));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tabAccount = new System.Windows.Forms.TabPage();
            this.tabEmployee = new System.Windows.Forms.TabPage();
            this.manageEmployeeUC = new slnGym.User_Control.ManageEmployeeUC();
            this.tabContract = new System.Windows.Forms.TabPage();
            this.manageContracts = new slnGym.User_Control.ManageContracts();
            this.tabMember = new System.Windows.Forms.TabPage();
            this.manageMembersUC = new slnGym.User_Control.ManageMembersUC();
            this.tabServices = new System.Windows.Forms.TabPage();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMachine = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btRefreshMachin = new System.Windows.Forms.Button();
            this.btDeleteMachine = new System.Windows.Forms.Button();
            this.txtAddDescriptionMachine = new System.Windows.Forms.TextBox();
            this.btEditMachine = new System.Windows.Forms.Button();
            this.numericAddMachine = new System.Windows.Forms.NumericUpDown();
            this.picAddMachine = new System.Windows.Forms.PictureBox();
            this.btSaveMachine = new System.Windows.Forms.Button();
            this.txtAddNameMachine = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.dgvMachines = new System.Windows.Forms.DataGridView();
            this.tabProduct = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btRefreshProduct = new System.Windows.Forms.Button();
            this.btDeleteProduct = new System.Windows.Forms.Button();
            this.picAddProduct = new System.Windows.Forms.PictureBox();
            this.btEditProduct = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.btAddProduct = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.txtAddCostProduct = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtAddNameProduct = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.dvgProducts = new System.Windows.Forms.DataGridView();
            this.tabPackage = new System.Windows.Forms.TabPage();
            this.dgvPackages = new System.Windows.Forms.DataGridView();
            this.groupPackage = new System.Windows.Forms.GroupBox();
            this.dgvTag = new System.Windows.Forms.DataGridView();
            this.groupWorkIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupWorkNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gROUPWORKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupWorkDataSet = new slnGym.GroupWorkDataSet();
            this.btRefreshMachine = new System.Windows.Forms.Button();
            this.txtAddTagPT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btDeletePackage = new System.Windows.Forms.Button();
            this.btSavePackage = new System.Windows.Forms.Button();
            this.btEditPackage = new System.Windows.Forms.Button();
            this.txtAddDescriptionPack = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAddCostPack = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAddNamePack = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabStatistic = new System.Windows.Forms.TabPage();
            this.statisticsUC = new slnGym.User_Control.StatisticsUC();
            this.gROUPWORKTableAdapter = new slnGym.GroupWorkDataSetTableAdapters.GROUPWORKTableAdapter();
            this.tabAdmin.SuspendLayout();
            this.tabEmployee.SuspendLayout();
            this.tabContract.SuspendLayout();
            this.tabMember.SuspendLayout();
            this.tabServices.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabMachine.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAddMachine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddMachine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachines)).BeginInit();
            this.tabProduct.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProducts)).BeginInit();
            this.tabPackage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackages)).BeginInit();
            this.groupPackage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUPWORKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWorkDataSet)).BeginInit();
            this.tabStatistic.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAdmin
            // 
            this.tabAdmin.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabAdmin.Controls.Add(this.tabAccount);
            this.tabAdmin.Controls.Add(this.tabEmployee);
            this.tabAdmin.Controls.Add(this.tabContract);
            this.tabAdmin.Controls.Add(this.tabMember);
            this.tabAdmin.Controls.Add(this.tabServices);
            this.tabAdmin.Controls.Add(this.tabStatistic);
            this.tabAdmin.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabAdmin.ItemSize = new System.Drawing.Size(20, 100);
            this.tabAdmin.Location = new System.Drawing.Point(0, 0);
            this.tabAdmin.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tabAdmin.Multiline = true;
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(1522, 806);
            this.tabAdmin.TabIndex = 2;
            this.tabAdmin.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabAdmin_DrawItem);
            this.tabAdmin.Click += new System.EventHandler(this.tabAdmin_Click);
            // 
            // tabAccount
            // 
            this.tabAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabAccount.ForeColor = System.Drawing.Color.DarkGreen;
            this.tabAccount.Location = new System.Drawing.Point(104, 4);
            this.tabAccount.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Size = new System.Drawing.Size(1414, 798);
            this.tabAccount.TabIndex = 5;
            this.tabAccount.Text = " Accounts   ";
            // 
            // tabEmployee
            // 
            this.tabEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabEmployee.Controls.Add(this.manageEmployeeUC);
            this.tabEmployee.ForeColor = System.Drawing.Color.DarkGreen;
            this.tabEmployee.Location = new System.Drawing.Point(104, 4);
            this.tabEmployee.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Size = new System.Drawing.Size(1414, 798);
            this.tabEmployee.TabIndex = 2;
            this.tabEmployee.Text = " Employees   ";
            // 
            // manageEmployeeUC
            // 
            this.manageEmployeeUC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.manageEmployeeUC.Location = new System.Drawing.Point(0, 0);
            this.manageEmployeeUC.Name = "manageEmployeeUC";
            this.manageEmployeeUC.Size = new System.Drawing.Size(1414, 798);
            this.manageEmployeeUC.TabIndex = 187;
            // 
            // tabContract
            // 
            this.tabContract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabContract.Controls.Add(this.manageContracts);
            this.tabContract.ForeColor = System.Drawing.Color.DarkGreen;
            this.tabContract.Location = new System.Drawing.Point(104, 4);
            this.tabContract.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tabContract.Name = "tabContract";
            this.tabContract.Size = new System.Drawing.Size(1414, 798);
            this.tabContract.TabIndex = 3;
            this.tabContract.Text = " Contracts   ";
            // 
            // manageContracts
            // 
            this.manageContracts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.manageContracts.Location = new System.Drawing.Point(0, 0);
            this.manageContracts.Name = "manageContracts";
            this.manageContracts.Size = new System.Drawing.Size(1414, 798);
            this.manageContracts.TabIndex = 0;
            // 
            // tabMember
            // 
            this.tabMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabMember.Controls.Add(this.manageMembersUC);
            this.tabMember.ForeColor = System.Drawing.Color.DarkGreen;
            this.tabMember.Location = new System.Drawing.Point(104, 4);
            this.tabMember.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tabMember.Name = "tabMember";
            this.tabMember.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tabMember.Size = new System.Drawing.Size(1414, 798);
            this.tabMember.TabIndex = 1;
            this.tabMember.Text = " Members   ";
            // 
            // manageMembersUC
            // 
            this.manageMembersUC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.manageMembersUC.Location = new System.Drawing.Point(0, 0);
            this.manageMembersUC.Name = "manageMembersUC";
            this.manageMembersUC.Size = new System.Drawing.Size(1414, 798);
            this.manageMembersUC.TabIndex = 0;
            // 
            // tabServices
            // 
            this.tabServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabServices.Controls.Add(this.tabControl);
            this.tabServices.Location = new System.Drawing.Point(104, 4);
            this.tabServices.Name = "tabServices";
            this.tabServices.Size = new System.Drawing.Size(1414, 798);
            this.tabServices.TabIndex = 6;
            this.tabServices.Text = " Services  ";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabMachine);
            this.tabControl.Controls.Add(this.tabProduct);
            this.tabControl.Controls.Add(this.tabPackage);
            this.tabControl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1418, 802);
            this.tabControl.TabIndex = 0;
            // 
            // tabMachine
            // 
            this.tabMachine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabMachine.Controls.Add(this.groupBox8);
            this.tabMachine.Controls.Add(this.dgvMachines);
            this.tabMachine.Location = new System.Drawing.Point(4, 36);
            this.tabMachine.Name = "tabMachine";
            this.tabMachine.Padding = new System.Windows.Forms.Padding(3);
            this.tabMachine.Size = new System.Drawing.Size(1410, 762);
            this.tabMachine.TabIndex = 0;
            this.tabMachine.Text = " Machines ";
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox8.Controls.Add(this.btRefreshMachin);
            this.groupBox8.Controls.Add(this.btDeleteMachine);
            this.groupBox8.Controls.Add(this.txtAddDescriptionMachine);
            this.groupBox8.Controls.Add(this.btEditMachine);
            this.groupBox8.Controls.Add(this.numericAddMachine);
            this.groupBox8.Controls.Add(this.picAddMachine);
            this.groupBox8.Controls.Add(this.btSaveMachine);
            this.groupBox8.Controls.Add(this.txtAddNameMachine);
            this.groupBox8.Controls.Add(this.label50);
            this.groupBox8.Controls.Add(this.label48);
            this.groupBox8.Font = new System.Drawing.Font("Sitka Display", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.ForeColor = System.Drawing.Color.DarkGreen;
            this.groupBox8.Location = new System.Drawing.Point(997, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(408, 752);
            this.groupBox8.TabIndex = 101;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Information";
            // 
            // btRefreshMachin
            // 
            this.btRefreshMachin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btRefreshMachin.BackColor = System.Drawing.Color.Transparent;
            this.btRefreshMachin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btRefreshMachin.BackgroundImage")));
            this.btRefreshMachin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btRefreshMachin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btRefreshMachin.FlatAppearance.BorderSize = 3;
            this.btRefreshMachin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRefreshMachin.Font = new System.Drawing.Font("Sitka Subheading", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRefreshMachin.ForeColor = System.Drawing.Color.Wheat;
            this.btRefreshMachin.Location = new System.Drawing.Point(153, 59);
            this.btRefreshMachin.Name = "btRefreshMachin";
            this.btRefreshMachin.Size = new System.Drawing.Size(51, 47);
            this.btRefreshMachin.TabIndex = 119;
            this.btRefreshMachin.UseVisualStyleBackColor = false;
            this.btRefreshMachin.Click += new System.EventHandler(this.btRefreshMachin_Click);
            // 
            // btDeleteMachine
            // 
            this.btDeleteMachine.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btDeleteMachine.BackColor = System.Drawing.Color.Transparent;
            this.btDeleteMachine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btDeleteMachine.BackgroundImage")));
            this.btDeleteMachine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btDeleteMachine.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btDeleteMachine.FlatAppearance.BorderSize = 3;
            this.btDeleteMachine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeleteMachine.Font = new System.Drawing.Font("Sitka Subheading", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteMachine.ForeColor = System.Drawing.Color.Wheat;
            this.btDeleteMachine.Location = new System.Drawing.Point(210, 57);
            this.btDeleteMachine.Name = "btDeleteMachine";
            this.btDeleteMachine.Size = new System.Drawing.Size(51, 47);
            this.btDeleteMachine.TabIndex = 118;
            this.btDeleteMachine.UseVisualStyleBackColor = false;
            this.btDeleteMachine.Click += new System.EventHandler(this.btDeleteMachine_Click);
            // 
            // txtAddDescriptionMachine
            // 
            this.txtAddDescriptionMachine.AcceptsTab = true;
            this.txtAddDescriptionMachine.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAddDescriptionMachine.BackColor = System.Drawing.Color.Honeydew;
            this.txtAddDescriptionMachine.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddDescriptionMachine.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtAddDescriptionMachine.Location = new System.Drawing.Point(127, 386);
            this.txtAddDescriptionMachine.Multiline = true;
            this.txtAddDescriptionMachine.Name = "txtAddDescriptionMachine";
            this.txtAddDescriptionMachine.Size = new System.Drawing.Size(248, 257);
            this.txtAddDescriptionMachine.TabIndex = 103;
            // 
            // btEditMachine
            // 
            this.btEditMachine.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btEditMachine.BackColor = System.Drawing.Color.Transparent;
            this.btEditMachine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btEditMachine.BackgroundImage")));
            this.btEditMachine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btEditMachine.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btEditMachine.FlatAppearance.BorderSize = 3;
            this.btEditMachine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditMachine.Font = new System.Drawing.Font("Sitka Subheading", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditMachine.ForeColor = System.Drawing.Color.Wheat;
            this.btEditMachine.Location = new System.Drawing.Point(267, 56);
            this.btEditMachine.Name = "btEditMachine";
            this.btEditMachine.Size = new System.Drawing.Size(51, 47);
            this.btEditMachine.TabIndex = 117;
            this.btEditMachine.UseVisualStyleBackColor = false;
            this.btEditMachine.Click += new System.EventHandler(this.btEditMachine_Click);
            // 
            // numericAddMachine
            // 
            this.numericAddMachine.BackColor = System.Drawing.Color.Honeydew;
            this.numericAddMachine.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericAddMachine.ForeColor = System.Drawing.Color.DarkGreen;
            this.numericAddMachine.Location = new System.Drawing.Point(315, 287);
            this.numericAddMachine.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericAddMachine.Name = "numericAddMachine";
            this.numericAddMachine.Size = new System.Drawing.Size(60, 39);
            this.numericAddMachine.TabIndex = 101;
            this.numericAddMachine.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // picAddMachine
            // 
            this.picAddMachine.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picAddMachine.BackColor = System.Drawing.Color.Transparent;
            this.picAddMachine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picAddMachine.BackgroundImage")));
            this.picAddMachine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picAddMachine.Location = new System.Drawing.Point(127, 119);
            this.picAddMachine.Name = "picAddMachine";
            this.picAddMachine.Size = new System.Drawing.Size(182, 207);
            this.picAddMachine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddMachine.TabIndex = 100;
            this.picAddMachine.TabStop = false;
            this.picAddMachine.Click += new System.EventHandler(this.picAddMachine_Click);
            // 
            // btSaveMachine
            // 
            this.btSaveMachine.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btSaveMachine.BackColor = System.Drawing.Color.Transparent;
            this.btSaveMachine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSaveMachine.BackgroundImage")));
            this.btSaveMachine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSaveMachine.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btSaveMachine.FlatAppearance.BorderSize = 3;
            this.btSaveMachine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSaveMachine.Font = new System.Drawing.Font("Sitka Subheading", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSaveMachine.ForeColor = System.Drawing.Color.Wheat;
            this.btSaveMachine.Location = new System.Drawing.Point(324, 54);
            this.btSaveMachine.Name = "btSaveMachine";
            this.btSaveMachine.Size = new System.Drawing.Size(51, 52);
            this.btSaveMachine.TabIndex = 97;
            this.btSaveMachine.UseVisualStyleBackColor = false;
            this.btSaveMachine.Click += new System.EventHandler(this.btSaveMachine_Click);
            // 
            // txtAddNameMachine
            // 
            this.txtAddNameMachine.AcceptsTab = true;
            this.txtAddNameMachine.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAddNameMachine.BackColor = System.Drawing.Color.Honeydew;
            this.txtAddNameMachine.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddNameMachine.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtAddNameMachine.Location = new System.Drawing.Point(127, 341);
            this.txtAddNameMachine.Name = "txtAddNameMachine";
            this.txtAddNameMachine.Size = new System.Drawing.Size(248, 39);
            this.txtAddNameMachine.TabIndex = 86;
            // 
            // label50
            // 
            this.label50.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.ForeColor = System.Drawing.Color.Green;
            this.label50.Location = new System.Drawing.Point(38, 343);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(77, 31);
            this.label50.TabIndex = 85;
            this.label50.Text = "Name";
            // 
            // label48
            // 
            this.label48.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.ForeColor = System.Drawing.Color.Green;
            this.label48.Location = new System.Drawing.Point(34, 119);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(91, 31);
            this.label48.TabIndex = 89;
            this.label48.Text = "Picture";
            // 
            // dgvMachines
            // 
            this.dgvMachines.AllowUserToAddRows = false;
            this.dgvMachines.AllowUserToDeleteRows = false;
            this.dgvMachines.AllowUserToResizeColumns = false;
            this.dgvMachines.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMachines.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMachines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMachines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMachines.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMachines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMachines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMachines.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMachines.Location = new System.Drawing.Point(6, 6);
            this.dgvMachines.Name = "dgvMachines";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMachines.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMachines.RowHeadersVisible = false;
            this.dgvMachines.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMachines.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMachines.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMachines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMachines.Size = new System.Drawing.Size(985, 752);
            this.dgvMachines.TabIndex = 100;
            this.dgvMachines.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMachines_CellClick);
            // 
            // tabProduct
            // 
            this.tabProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabProduct.Controls.Add(this.groupBox5);
            this.tabProduct.Controls.Add(this.dvgProducts);
            this.tabProduct.Location = new System.Drawing.Point(4, 36);
            this.tabProduct.Name = "tabProduct";
            this.tabProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduct.Size = new System.Drawing.Size(1410, 762);
            this.tabProduct.TabIndex = 1;
            this.tabProduct.Text = " Products ";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox5.Controls.Add(this.btRefreshProduct);
            this.groupBox5.Controls.Add(this.btDeleteProduct);
            this.groupBox5.Controls.Add(this.picAddProduct);
            this.groupBox5.Controls.Add(this.btEditProduct);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.btAddProduct);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.txtAddCostProduct);
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Controls.Add(this.txtAddNameProduct);
            this.groupBox5.Controls.Add(this.label29);
            this.groupBox5.Font = new System.Drawing.Font("Sitka Display", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.DarkGreen;
            this.groupBox5.Location = new System.Drawing.Point(997, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(408, 750);
            this.groupBox5.TabIndex = 97;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Information";
            // 
            // btRefreshProduct
            // 
            this.btRefreshProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btRefreshProduct.BackColor = System.Drawing.Color.Transparent;
            this.btRefreshProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btRefreshProduct.BackgroundImage")));
            this.btRefreshProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btRefreshProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btRefreshProduct.FlatAppearance.BorderSize = 3;
            this.btRefreshProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRefreshProduct.Font = new System.Drawing.Font("Sitka Subheading", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRefreshProduct.ForeColor = System.Drawing.Color.Wheat;
            this.btRefreshProduct.Location = new System.Drawing.Point(140, 62);
            this.btRefreshProduct.Name = "btRefreshProduct";
            this.btRefreshProduct.Size = new System.Drawing.Size(51, 47);
            this.btRefreshProduct.TabIndex = 111;
            this.btRefreshProduct.UseVisualStyleBackColor = false;
            this.btRefreshProduct.Click += new System.EventHandler(this.btRefreshProduct_Click);
            // 
            // btDeleteProduct
            // 
            this.btDeleteProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btDeleteProduct.BackColor = System.Drawing.Color.Transparent;
            this.btDeleteProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btDeleteProduct.BackgroundImage")));
            this.btDeleteProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btDeleteProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btDeleteProduct.FlatAppearance.BorderSize = 3;
            this.btDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeleteProduct.Font = new System.Drawing.Font("Sitka Subheading", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteProduct.ForeColor = System.Drawing.Color.Wheat;
            this.btDeleteProduct.Location = new System.Drawing.Point(197, 59);
            this.btDeleteProduct.Name = "btDeleteProduct";
            this.btDeleteProduct.Size = new System.Drawing.Size(51, 47);
            this.btDeleteProduct.TabIndex = 110;
            this.btDeleteProduct.UseVisualStyleBackColor = false;
            this.btDeleteProduct.Click += new System.EventHandler(this.btDeleteProduct_Click);
            // 
            // picAddProduct
            // 
            this.picAddProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picAddProduct.BackColor = System.Drawing.Color.Transparent;
            this.picAddProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picAddProduct.BackgroundImage")));
            this.picAddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picAddProduct.Location = new System.Drawing.Point(128, 236);
            this.picAddProduct.Name = "picAddProduct";
            this.picAddProduct.Size = new System.Drawing.Size(171, 163);
            this.picAddProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddProduct.TabIndex = 100;
            this.picAddProduct.TabStop = false;
            this.picAddProduct.Click += new System.EventHandler(this.picAddProduct_Click);
            // 
            // btEditProduct
            // 
            this.btEditProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btEditProduct.BackColor = System.Drawing.Color.Transparent;
            this.btEditProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btEditProduct.BackgroundImage")));
            this.btEditProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btEditProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btEditProduct.FlatAppearance.BorderSize = 3;
            this.btEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditProduct.Font = new System.Drawing.Font("Sitka Subheading", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditProduct.ForeColor = System.Drawing.Color.Wheat;
            this.btEditProduct.Location = new System.Drawing.Point(254, 59);
            this.btEditProduct.Name = "btEditProduct";
            this.btEditProduct.Size = new System.Drawing.Size(51, 47);
            this.btEditProduct.TabIndex = 109;
            this.btEditProduct.UseVisualStyleBackColor = false;
            this.btEditProduct.Click += new System.EventHandler(this.btEditProduct_Click);
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Green;
            this.label26.Location = new System.Drawing.Point(305, 178);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(71, 31);
            this.label26.TabIndex = 98;
            this.label26.Text = "VND";
            // 
            // btAddProduct
            // 
            this.btAddProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btAddProduct.BackColor = System.Drawing.Color.Transparent;
            this.btAddProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAddProduct.BackgroundImage")));
            this.btAddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btAddProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btAddProduct.FlatAppearance.BorderSize = 3;
            this.btAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddProduct.Font = new System.Drawing.Font("Sitka Subheading", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddProduct.ForeColor = System.Drawing.Color.Wheat;
            this.btAddProduct.Location = new System.Drawing.Point(311, 55);
            this.btAddProduct.Name = "btAddProduct";
            this.btAddProduct.Size = new System.Drawing.Size(58, 54);
            this.btAddProduct.TabIndex = 97;
            this.btAddProduct.UseVisualStyleBackColor = false;
            this.btAddProduct.Click += new System.EventHandler(this.btAddProduct_Click);
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Green;
            this.label27.Location = new System.Drawing.Point(35, 236);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(91, 31);
            this.label27.TabIndex = 89;
            this.label27.Text = "Picture";
            // 
            // txtAddCostProduct
            // 
            this.txtAddCostProduct.AcceptsTab = true;
            this.txtAddCostProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAddCostProduct.BackColor = System.Drawing.Color.Honeydew;
            this.txtAddCostProduct.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddCostProduct.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtAddCostProduct.Location = new System.Drawing.Point(128, 175);
            this.txtAddCostProduct.Name = "txtAddCostProduct";
            this.txtAddCostProduct.Size = new System.Drawing.Size(171, 39);
            this.txtAddCostProduct.TabIndex = 88;
            this.txtAddCostProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Green;
            this.label28.Location = new System.Drawing.Point(35, 178);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(64, 31);
            this.label28.TabIndex = 87;
            this.label28.Text = "Cost";
            // 
            // txtAddNameProduct
            // 
            this.txtAddNameProduct.AcceptsTab = true;
            this.txtAddNameProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAddNameProduct.BackColor = System.Drawing.Color.Honeydew;
            this.txtAddNameProduct.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddNameProduct.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtAddNameProduct.Location = new System.Drawing.Point(128, 115);
            this.txtAddNameProduct.Name = "txtAddNameProduct";
            this.txtAddNameProduct.Size = new System.Drawing.Size(241, 39);
            this.txtAddNameProduct.TabIndex = 86;
            // 
            // label29
            // 
            this.label29.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.Green;
            this.label29.Location = new System.Drawing.Point(35, 118);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(77, 31);
            this.label29.TabIndex = 85;
            this.label29.Text = "Name";
            // 
            // dvgProducts
            // 
            this.dvgProducts.AllowUserToAddRows = false;
            this.dvgProducts.AllowUserToDeleteRows = false;
            this.dvgProducts.AllowUserToResizeColumns = false;
            this.dvgProducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dvgProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvgProducts.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dvgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dvgProducts.Location = new System.Drawing.Point(6, 6);
            this.dvgProducts.Name = "dvgProducts";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dvgProducts.RowHeadersVisible = false;
            this.dvgProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgProducts.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dvgProducts.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dvgProducts.Size = new System.Drawing.Size(985, 750);
            this.dvgProducts.TabIndex = 84;
            this.dvgProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgProducts_CellClick);
            // 
            // tabPackage
            // 
            this.tabPackage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPackage.Controls.Add(this.dgvPackages);
            this.tabPackage.Controls.Add(this.groupPackage);
            this.tabPackage.Location = new System.Drawing.Point(4, 36);
            this.tabPackage.Name = "tabPackage";
            this.tabPackage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPackage.Size = new System.Drawing.Size(1410, 762);
            this.tabPackage.TabIndex = 2;
            this.tabPackage.Text = " Packages ";
            // 
            // dgvPackages
            // 
            this.dgvPackages.AllowUserToAddRows = false;
            this.dgvPackages.AllowUserToDeleteRows = false;
            this.dgvPackages.AllowUserToResizeColumns = false;
            this.dgvPackages.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPackages.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPackages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPackages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPackages.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPackages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackages.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPackages.Location = new System.Drawing.Point(6, 6);
            this.dgvPackages.Name = "dgvPackages";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPackages.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvPackages.RowHeadersVisible = false;
            this.dgvPackages.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPackages.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvPackages.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPackages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPackages.Size = new System.Drawing.Size(983, 750);
            this.dgvPackages.TabIndex = 98;
            this.dgvPackages.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPackages_CellClick);
            // 
            // groupPackage
            // 
            this.groupPackage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupPackage.Controls.Add(this.dgvTag);
            this.groupPackage.Controls.Add(this.btRefreshMachine);
            this.groupPackage.Controls.Add(this.txtAddTagPT);
            this.groupPackage.Controls.Add(this.label1);
            this.groupPackage.Controls.Add(this.btDeletePackage);
            this.groupPackage.Controls.Add(this.btSavePackage);
            this.groupPackage.Controls.Add(this.btEditPackage);
            this.groupPackage.Controls.Add(this.txtAddDescriptionPack);
            this.groupPackage.Controls.Add(this.label11);
            this.groupPackage.Controls.Add(this.txtAddCostPack);
            this.groupPackage.Controls.Add(this.label10);
            this.groupPackage.Controls.Add(this.txtAddNamePack);
            this.groupPackage.Controls.Add(this.label8);
            this.groupPackage.Controls.Add(this.label12);
            this.groupPackage.Font = new System.Drawing.Font("Sitka Display", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPackage.ForeColor = System.Drawing.Color.DarkGreen;
            this.groupPackage.Location = new System.Drawing.Point(995, 6);
            this.groupPackage.Name = "groupPackage";
            this.groupPackage.Size = new System.Drawing.Size(408, 750);
            this.groupPackage.TabIndex = 96;
            this.groupPackage.TabStop = false;
            this.groupPackage.Text = "Information";
            // 
            // dgvTag
            // 
            this.dgvTag.AllowUserToAddRows = false;
            this.dgvTag.AllowUserToDeleteRows = false;
            this.dgvTag.AllowUserToResizeColumns = false;
            this.dgvTag.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTag.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvTag.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvTag.AutoGenerateColumns = false;
            this.dgvTag.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTag.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Sitka Display", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTag.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvTag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTag.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.groupWorkIDDataGridViewTextBoxColumn,
            this.groupWorkNameDataGridViewTextBoxColumn});
            this.dgvTag.DataSource = this.gROUPWORKBindingSource;
            this.dgvTag.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTag.Location = new System.Drawing.Point(5, 495);
            this.dgvTag.Name = "dgvTag";
            this.dgvTag.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Sitka Display", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTag.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvTag.RowHeadersVisible = false;
            this.dgvTag.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTag.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvTag.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTag.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTag.Size = new System.Drawing.Size(403, 255);
            this.dgvTag.TabIndex = 109;
            // 
            // groupWorkIDDataGridViewTextBoxColumn
            // 
            this.groupWorkIDDataGridViewTextBoxColumn.DataPropertyName = "groupWorkID";
            this.groupWorkIDDataGridViewTextBoxColumn.HeaderText = "ID Group";
            this.groupWorkIDDataGridViewTextBoxColumn.Name = "groupWorkIDDataGridViewTextBoxColumn";
            this.groupWorkIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.groupWorkIDDataGridViewTextBoxColumn.Width = 141;
            // 
            // groupWorkNameDataGridViewTextBoxColumn
            // 
            this.groupWorkNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.groupWorkNameDataGridViewTextBoxColumn.DataPropertyName = "groupWorkName";
            this.groupWorkNameDataGridViewTextBoxColumn.HeaderText = "Name Group";
            this.groupWorkNameDataGridViewTextBoxColumn.Name = "groupWorkNameDataGridViewTextBoxColumn";
            this.groupWorkNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gROUPWORKBindingSource
            // 
            this.gROUPWORKBindingSource.DataMember = "GROUPWORK";
            this.gROUPWORKBindingSource.DataSource = this.groupWorkDataSet;
            // 
            // groupWorkDataSet
            // 
            this.groupWorkDataSet.DataSetName = "GroupWorkDataSet";
            this.groupWorkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btRefreshMachine
            // 
            this.btRefreshMachine.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btRefreshMachine.BackColor = System.Drawing.Color.Transparent;
            this.btRefreshMachine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btRefreshMachine.BackgroundImage")));
            this.btRefreshMachine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btRefreshMachine.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btRefreshMachine.FlatAppearance.BorderSize = 3;
            this.btRefreshMachine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRefreshMachine.Font = new System.Drawing.Font("Sitka Subheading", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRefreshMachine.ForeColor = System.Drawing.Color.Wheat;
            this.btRefreshMachine.Location = new System.Drawing.Point(152, 49);
            this.btRefreshMachine.Name = "btRefreshMachine";
            this.btRefreshMachine.Size = new System.Drawing.Size(51, 47);
            this.btRefreshMachine.TabIndex = 108;
            this.btRefreshMachine.UseVisualStyleBackColor = false;
            this.btRefreshMachine.Click += new System.EventHandler(this.btRefreshMachine_Click);
            // 
            // txtAddTagPT
            // 
            this.txtAddTagPT.AcceptsTab = true;
            this.txtAddTagPT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAddTagPT.BackColor = System.Drawing.Color.Honeydew;
            this.txtAddTagPT.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddTagPT.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtAddTagPT.Location = new System.Drawing.Point(185, 238);
            this.txtAddTagPT.Name = "txtAddTagPT";
            this.txtAddTagPT.Size = new System.Drawing.Size(190, 39);
            this.txtAddTagPT.TabIndex = 100;
            this.txtAddTagPT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(29, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 31);
            this.label1.TabIndex = 99;
            this.label1.Text = "Tag PT";
            // 
            // btDeletePackage
            // 
            this.btDeletePackage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btDeletePackage.BackColor = System.Drawing.Color.Transparent;
            this.btDeletePackage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btDeletePackage.BackgroundImage")));
            this.btDeletePackage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btDeletePackage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btDeletePackage.FlatAppearance.BorderSize = 3;
            this.btDeletePackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeletePackage.Font = new System.Drawing.Font("Sitka Subheading", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeletePackage.ForeColor = System.Drawing.Color.Wheat;
            this.btDeletePackage.Location = new System.Drawing.Point(209, 49);
            this.btDeletePackage.Name = "btDeletePackage";
            this.btDeletePackage.Size = new System.Drawing.Size(51, 47);
            this.btDeletePackage.TabIndex = 107;
            this.btDeletePackage.UseVisualStyleBackColor = false;
            this.btDeletePackage.Click += new System.EventHandler(this.btDeletePackage_Click);
            // 
            // btSavePackage
            // 
            this.btSavePackage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btSavePackage.BackColor = System.Drawing.Color.Transparent;
            this.btSavePackage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSavePackage.BackgroundImage")));
            this.btSavePackage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSavePackage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btSavePackage.FlatAppearance.BorderSize = 3;
            this.btSavePackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSavePackage.Font = new System.Drawing.Font("Sitka Subheading", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSavePackage.ForeColor = System.Drawing.Color.Wheat;
            this.btSavePackage.Location = new System.Drawing.Point(323, 42);
            this.btSavePackage.Name = "btSavePackage";
            this.btSavePackage.Size = new System.Drawing.Size(67, 60);
            this.btSavePackage.TabIndex = 97;
            this.btSavePackage.UseVisualStyleBackColor = false;
            this.btSavePackage.Click += new System.EventHandler(this.btSavePackage_Click);
            // 
            // btEditPackage
            // 
            this.btEditPackage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btEditPackage.BackColor = System.Drawing.Color.Transparent;
            this.btEditPackage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btEditPackage.BackgroundImage")));
            this.btEditPackage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btEditPackage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btEditPackage.FlatAppearance.BorderSize = 3;
            this.btEditPackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditPackage.Font = new System.Drawing.Font("Sitka Subheading", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditPackage.ForeColor = System.Drawing.Color.Wheat;
            this.btEditPackage.Location = new System.Drawing.Point(266, 49);
            this.btEditPackage.Name = "btEditPackage";
            this.btEditPackage.Size = new System.Drawing.Size(51, 47);
            this.btEditPackage.TabIndex = 105;
            this.btEditPackage.UseVisualStyleBackColor = false;
            this.btEditPackage.Click += new System.EventHandler(this.btEditPackage_Click);
            // 
            // txtAddDescriptionPack
            // 
            this.txtAddDescriptionPack.AcceptsTab = true;
            this.txtAddDescriptionPack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAddDescriptionPack.BackColor = System.Drawing.Color.Honeydew;
            this.txtAddDescriptionPack.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddDescriptionPack.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtAddDescriptionPack.Location = new System.Drawing.Point(185, 297);
            this.txtAddDescriptionPack.Multiline = true;
            this.txtAddDescriptionPack.Name = "txtAddDescriptionPack";
            this.txtAddDescriptionPack.Size = new System.Drawing.Size(190, 192);
            this.txtAddDescriptionPack.TabIndex = 90;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Green;
            this.label11.Location = new System.Drawing.Point(29, 300);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 31);
            this.label11.TabIndex = 89;
            this.label11.Text = "Description";
            // 
            // txtAddCostPack
            // 
            this.txtAddCostPack.AcceptsTab = true;
            this.txtAddCostPack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAddCostPack.BackColor = System.Drawing.Color.Honeydew;
            this.txtAddCostPack.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddCostPack.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtAddCostPack.Location = new System.Drawing.Point(185, 177);
            this.txtAddCostPack.Name = "txtAddCostPack";
            this.txtAddCostPack.Size = new System.Drawing.Size(190, 39);
            this.txtAddCostPack.TabIndex = 88;
            this.txtAddCostPack.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Green;
            this.label10.Location = new System.Drawing.Point(29, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 31);
            this.label10.TabIndex = 87;
            this.label10.Text = "Cost";
            // 
            // txtAddNamePack
            // 
            this.txtAddNamePack.AcceptsTab = true;
            this.txtAddNamePack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAddNamePack.BackColor = System.Drawing.Color.Honeydew;
            this.txtAddNamePack.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddNamePack.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtAddNamePack.Location = new System.Drawing.Point(185, 117);
            this.txtAddNamePack.Name = "txtAddNamePack";
            this.txtAddNamePack.Size = new System.Drawing.Size(188, 39);
            this.txtAddNamePack.TabIndex = 86;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(29, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 31);
            this.label8.TabIndex = 85;
            this.label8.Text = "Name";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Green;
            this.label12.Location = new System.Drawing.Point(89, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 31);
            this.label12.TabIndex = 98;
            this.label12.Text = "(VND)";
            // 
            // tabStatistic
            // 
            this.tabStatistic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabStatistic.Controls.Add(this.statisticsUC);
            this.tabStatistic.ForeColor = System.Drawing.Color.DarkGray;
            this.tabStatistic.Location = new System.Drawing.Point(104, 4);
            this.tabStatistic.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tabStatistic.Name = "tabStatistic";
            this.tabStatistic.Size = new System.Drawing.Size(1414, 798);
            this.tabStatistic.TabIndex = 4;
            this.tabStatistic.Text = " Statistics   ";
            // 
            // statisticsUC
            // 
            this.statisticsUC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.statisticsUC.Location = new System.Drawing.Point(0, 0);
            this.statisticsUC.Name = "statisticsUC";
            this.statisticsUC.Size = new System.Drawing.Size(1414, 798);
            this.statisticsUC.TabIndex = 0;
            // 
            // gROUPWORKTableAdapter
            // 
            this.gROUPWORKTableAdapter.ClearBeforeFill = true;
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1523, 806);
            this.Controls.Add(this.tabAdmin);
            this.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.MaximizeBox = false;
            this.Name = "Administration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administration";
            this.Load += new System.EventHandler(this.Administration_Load);
            this.tabAdmin.ResumeLayout(false);
            this.tabEmployee.ResumeLayout(false);
            this.tabContract.ResumeLayout(false);
            this.tabMember.ResumeLayout(false);
            this.tabServices.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabMachine.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAddMachine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddMachine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachines)).EndInit();
            this.tabProduct.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProducts)).EndInit();
            this.tabPackage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackages)).EndInit();
            this.groupPackage.ResumeLayout(false);
            this.groupPackage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUPWORKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWorkDataSet)).EndInit();
            this.tabStatistic.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAdmin;
        private System.Windows.Forms.TabPage tabMember;
        private System.Windows.Forms.TabPage tabEmployee;
        private System.Windows.Forms.TabPage tabContract;
        private System.Windows.Forms.TabPage tabAccount;
        private System.Windows.Forms.TabPage tabStatistic;
        private System.Windows.Forms.TabPage tabServices;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMachine;
        private System.Windows.Forms.TabPage tabProduct;
        private System.Windows.Forms.TabPage tabPackage;
        private System.Windows.Forms.GroupBox groupPackage;
        private System.Windows.Forms.TextBox txtAddDescriptionPack;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAddCostPack;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAddNamePack;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btDeletePackage;
        private System.Windows.Forms.Button btEditPackage;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btSavePackage;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btAddProduct;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtAddCostProduct;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtAddNameProduct;
        private System.Windows.Forms.Label label29;
        public System.Windows.Forms.DataGridView dvgProducts;
        private System.Windows.Forms.Button btDeleteProduct;
        private System.Windows.Forms.Button btEditProduct;
        private System.Windows.Forms.PictureBox picAddProduct;
        private System.Windows.Forms.Button btDeleteMachine;
        private System.Windows.Forms.Button btEditMachine;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtAddDescriptionMachine;
        private System.Windows.Forms.NumericUpDown numericAddMachine;
        private System.Windows.Forms.PictureBox picAddMachine;
        private System.Windows.Forms.Button btSaveMachine;
        private System.Windows.Forms.TextBox txtAddNameMachine;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label48;
        public System.Windows.Forms.DataGridView dgvMachines;
        private User_Control.ManageEmployeeUC manageEmployeeUC;
        private User_Control.ManageContracts manageContracts;
        private User_Control.ManageMembersUC manageMembersUC;
        private User_Control.StatisticsUC statisticsUC;
        public System.Windows.Forms.DataGridView dgvPackages;
        private System.Windows.Forms.TextBox txtAddTagPT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRefreshMachine;
        private System.Windows.Forms.Button btRefreshProduct;
        private System.Windows.Forms.Button btRefreshMachin;
        public System.Windows.Forms.DataGridView dgvTag;
        private GroupWorkDataSet groupWorkDataSet;
        private System.Windows.Forms.BindingSource gROUPWORKBindingSource;
        private GroupWorkDataSetTableAdapters.GROUPWORKTableAdapter gROUPWORKTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupWorkIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupWorkNameDataGridViewTextBoxColumn;
    }
}