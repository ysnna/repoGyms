namespace slnGym.User_Control
{
    partial class ManageMembersUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageMembersUC));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btRefreshMember = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvPackage = new System.Windows.Forms.DataGridView();
            this.btSearch = new System.Windows.Forms.PictureBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtMember = new System.Windows.Forms.TextBox();
            this.txtSearchMembers = new System.Windows.Forms.TextBox();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.dgvPT = new System.Windows.Forms.DataGridView();
            this.btCreateContract = new System.Windows.Forms.Button();
            this.btnMessage = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPT)).BeginInit();
            this.SuspendLayout();
            // 
            // btRefreshMember
            // 
            this.btRefreshMember.BackColor = System.Drawing.Color.Transparent;
            this.btRefreshMember.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btRefreshMember.BackgroundImage")));
            this.btRefreshMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btRefreshMember.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btRefreshMember.FlatAppearance.BorderSize = 3;
            this.btRefreshMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRefreshMember.Font = new System.Drawing.Font("Sitka Subheading", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRefreshMember.ForeColor = System.Drawing.Color.White;
            this.btRefreshMember.Location = new System.Drawing.Point(573, 14);
            this.btRefreshMember.Name = "btRefreshMember";
            this.btRefreshMember.Size = new System.Drawing.Size(39, 39);
            this.btRefreshMember.TabIndex = 143;
            this.btRefreshMember.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRefreshMember.UseVisualStyleBackColor = false;
            this.btRefreshMember.Click += new System.EventHandler(this.btRefreshMember_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox4.Controls.Add(this.dgvProduct);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.DarkGreen;
            this.groupBox4.Location = new System.Drawing.Point(725, 499);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(686, 296);
            this.groupBox4.TabIndex = 145;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Products";
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.AllowUserToResizeColumns = false;
            this.dgvProduct.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProduct.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProduct.Location = new System.Drawing.Point(6, 37);
            this.dgvProduct.Name = "dgvProduct";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvProduct.RowHeadersVisible = false;
            this.dgvProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvProduct.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvProduct.Size = new System.Drawing.Size(674, 252);
            this.dgvProduct.TabIndex = 156;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.dgvPackage);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DarkGreen;
            this.groupBox3.Location = new System.Drawing.Point(7, 499);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(712, 296);
            this.groupBox3.TabIndex = 144;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Packages";
            // 
            // dgvPackage
            // 
            this.dgvPackage.AllowUserToAddRows = false;
            this.dgvPackage.AllowUserToDeleteRows = false;
            this.dgvPackage.AllowUserToResizeColumns = false;
            this.dgvPackage.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPackage.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvPackage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPackage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPackage.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPackage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvPackage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackage.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPackage.Location = new System.Drawing.Point(6, 37);
            this.dgvPackage.Name = "dgvPackage";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPackage.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvPackage.RowHeadersVisible = false;
            this.dgvPackage.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPackage.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvPackage.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPackage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPackage.Size = new System.Drawing.Size(700, 252);
            this.dgvPackage.TabIndex = 155;
            // 
            // btSearch
            // 
            this.btSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSearch.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSearch.BackgroundImage")));
            this.btSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSearch.Location = new System.Drawing.Point(525, 16);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(39, 35);
            this.btSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btSearch.TabIndex = 148;
            this.btSearch.TabStop = false;
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Green;
            this.label22.Location = new System.Drawing.Point(22, 59);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(93, 27);
            this.label22.TabIndex = 150;
            this.label22.Text = "Member";
            // 
            // txtMember
            // 
            this.txtMember.AcceptsTab = true;
            this.txtMember.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMember.BackColor = System.Drawing.Color.Honeydew;
            this.txtMember.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMember.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtMember.Location = new System.Drawing.Point(17, 89);
            this.txtMember.Name = "txtMember";
            this.txtMember.ReadOnly = true;
            this.txtMember.Size = new System.Drawing.Size(252, 35);
            this.txtMember.TabIndex = 151;
            // 
            // txtSearchMembers
            // 
            this.txtSearchMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchMembers.BackColor = System.Drawing.Color.MintCream;
            this.txtSearchMembers.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMembers.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtSearchMembers.Location = new System.Drawing.Point(275, 14);
            this.txtSearchMembers.Name = "txtSearchMembers";
            this.txtSearchMembers.PasswordChar = '*';
            this.txtSearchMembers.Size = new System.Drawing.Size(292, 39);
            this.txtSearchMembers.TabIndex = 152;
            // 
            // dgvMembers
            // 
            this.dgvMembers.AllowUserToAddRows = false;
            this.dgvMembers.AllowUserToDeleteRows = false;
            this.dgvMembers.AllowUserToResizeColumns = false;
            this.dgvMembers.AllowUserToResizeRows = false;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMembers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMembers.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Sitka Display", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMembers.Location = new System.Drawing.Point(275, 59);
            this.dgvMembers.Name = "dgvMembers";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Sitka Display", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMembers.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgvMembers.RowHeadersVisible = false;
            this.dgvMembers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMembers.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvMembers.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMembers.Size = new System.Drawing.Size(1130, 434);
            this.dgvMembers.TabIndex = 153;
            this.dgvMembers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMembers_CellClick);
            // 
            // dgvPT
            // 
            this.dgvPT.AllowUserToAddRows = false;
            this.dgvPT.AllowUserToDeleteRows = false;
            this.dgvPT.AllowUserToResizeColumns = false;
            this.dgvPT.AllowUserToResizeRows = false;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPT.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle29;
            this.dgvPT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPT.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dgvPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPT.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPT.Location = new System.Drawing.Point(17, 130);
            this.dgvPT.Name = "dgvPT";
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPT.RowHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.dgvPT.RowHeadersVisible = false;
            this.dgvPT.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPT.RowsDefaultCellStyle = dataGridViewCellStyle32;
            this.dgvPT.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPT.Size = new System.Drawing.Size(252, 363);
            this.dgvPT.TabIndex = 156;
            // 
            // btCreateContract
            // 
            this.btCreateContract.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btCreateContract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btCreateContract.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btCreateContract.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btCreateContract.FlatAppearance.BorderSize = 3;
            this.btCreateContract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCreateContract.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreateContract.ForeColor = System.Drawing.Color.SeaGreen;
            this.btCreateContract.Location = new System.Drawing.Point(1268, 8);
            this.btCreateContract.Name = "btCreateContract";
            this.btCreateContract.Size = new System.Drawing.Size(137, 55);
            this.btCreateContract.TabIndex = 157;
            this.btCreateContract.Text = "Approve";
            this.btCreateContract.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCreateContract.UseVisualStyleBackColor = false;
            this.btCreateContract.Click += new System.EventHandler(this.btCreateContract_Click);
            // 
            // btnMessage
            // 
            this.btnMessage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMessage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMessage.BackgroundImage")));
            this.btnMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMessage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMessage.FlatAppearance.BorderSize = 3;
            this.btnMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMessage.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessage.ForeColor = System.Drawing.Color.Snow;
            this.btnMessage.Location = new System.Drawing.Point(206, 8);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(63, 55);
            this.btnMessage.TabIndex = 158;
            this.btnMessage.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnMessage.UseVisualStyleBackColor = false;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // ManageMembersUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.btnMessage);
            this.Controls.Add(this.dgvPT);
            this.Controls.Add(this.txtMember);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.btRefreshMember);
            this.Controls.Add(this.txtSearchMembers);
            this.Controls.Add(this.dgvMembers);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btCreateContract);
            this.Name = "ManageMembersUC";
            this.Size = new System.Drawing.Size(1414, 798);
            this.Load += new System.EventHandler(this.ManageMembersUC_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btRefreshMember;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox btSearch;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtMember;
        private System.Windows.Forms.TextBox txtSearchMembers;
        public System.Windows.Forms.DataGridView dgvMembers;
        public System.Windows.Forms.DataGridView dgvProduct;
        public System.Windows.Forms.DataGridView dgvPackage;
        public System.Windows.Forms.DataGridView dgvPT;
        private System.Windows.Forms.Button btCreateContract;
        private System.Windows.Forms.Button btnMessage;
    }
}
