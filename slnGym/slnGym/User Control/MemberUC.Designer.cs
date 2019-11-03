namespace slnGym.User_Control
{
    partial class MemberUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberUC));
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.btSearch = new System.Windows.Forms.PictureBox();
            this.txtSearchMembers = new System.Windows.Forms.TextBox();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listProductsHistory = new System.Windows.Forms.ListView();
            this.btRefreshMember = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.listPackagesHistory = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSearch)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMembers
            // 
            this.dgvMembers.AllowUserToAddRows = false;
            this.dgvMembers.AllowUserToDeleteRows = false;
            this.dgvMembers.AllowUserToResizeColumns = false;
            this.dgvMembers.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMembers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMembers.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Sitka Display", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMembers.Location = new System.Drawing.Point(974, 101);
            this.dgvMembers.Name = "dgvMembers";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Sitka Display", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMembers.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvMembers.RowHeadersVisible = false;
            this.dgvMembers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMembers.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvMembers.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMembers.Size = new System.Drawing.Size(905, 767);
            this.dgvMembers.TabIndex = 163;
            this.dgvMembers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMembers_CellClick);
            // 
            // btSearch
            // 
            this.btSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSearch.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSearch.BackgroundImage")));
            this.btSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSearch.Location = new System.Drawing.Point(1837, 58);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(39, 35);
            this.btSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btSearch.TabIndex = 158;
            this.btSearch.TabStop = false;
            // 
            // txtSearchMembers
            // 
            this.txtSearchMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchMembers.BackColor = System.Drawing.Color.MintCream;
            this.txtSearchMembers.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMembers.ForeColor = System.Drawing.Color.Navy;
            this.txtSearchMembers.Location = new System.Drawing.Point(1587, 56);
            this.txtSearchMembers.Name = "txtSearchMembers";
            this.txtSearchMembers.PasswordChar = '*';
            this.txtSearchMembers.Size = new System.Drawing.Size(292, 39);
            this.txtSearchMembers.TabIndex = 162;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Transaction history";
            this.columnHeader9.Width = 245;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Cost";
            this.columnHeader8.Width = 130;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Discount";
            this.columnHeader7.Width = 110;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Name";
            this.columnHeader6.Width = 156;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "No";
            this.columnHeader5.Width = 70;
            // 
            // listProductsHistory
            // 
            this.listProductsHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listProductsHistory.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listProductsHistory.BackgroundImageTiled = true;
            this.listProductsHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listProductsHistory.Font = new System.Drawing.Font("UTM Aptima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listProductsHistory.ForeColor = System.Drawing.Color.Navy;
            this.listProductsHistory.FullRowSelect = true;
            this.listProductsHistory.GridLines = true;
            this.listProductsHistory.HideSelection = false;
            this.listProductsHistory.Location = new System.Drawing.Point(6, 38);
            this.listProductsHistory.Name = "listProductsHistory";
            this.listProductsHistory.Size = new System.Drawing.Size(914, 382);
            this.listProductsHistory.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listProductsHistory.TabIndex = 132;
            this.listProductsHistory.UseCompatibleStateImageBehavior = false;
            this.listProductsHistory.View = System.Windows.Forms.View.Details;
            // 
            // btRefreshMember
            // 
            this.btRefreshMember.BackColor = System.Drawing.Color.Transparent;
            this.btRefreshMember.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btRefreshMember.BackgroundImage")));
            this.btRefreshMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btRefreshMember.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btRefreshMember.FlatAppearance.BorderSize = 3;
            this.btRefreshMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRefreshMember.Font = new System.Drawing.Font("Sitka Subheading", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRefreshMember.ForeColor = System.Drawing.Color.White;
            this.btRefreshMember.Location = new System.Drawing.Point(1542, 56);
            this.btRefreshMember.Name = "btRefreshMember";
            this.btRefreshMember.Size = new System.Drawing.Size(39, 39);
            this.btRefreshMember.TabIndex = 154;
            this.btRefreshMember.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRefreshMember.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox4.Controls.Add(this.listProductsHistory);
            this.groupBox4.Font = new System.Drawing.Font("Sitka Display", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Navy;
            this.groupBox4.Location = new System.Drawing.Point(37, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(931, 426);
            this.groupBox4.TabIndex = 156;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Products";
            // 
            // cbClass
            // 
            this.cbClass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbClass.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbClass.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClass.ForeColor = System.Drawing.Color.Navy;
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(974, 60);
            this.cbClass.Margin = new System.Windows.Forms.Padding(8);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(252, 35);
            this.cbClass.TabIndex = 164;
            this.cbClass.Text = "-- Select group name --";
            // 
            // listPackagesHistory
            // 
            this.listPackagesHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listPackagesHistory.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listPackagesHistory.BackgroundImageTiled = true;
            this.listPackagesHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader10,
            this.columnHeader11});
            this.listPackagesHistory.Font = new System.Drawing.Font("UTM Aptima", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPackagesHistory.ForeColor = System.Drawing.Color.Navy;
            this.listPackagesHistory.FullRowSelect = true;
            this.listPackagesHistory.GridLines = true;
            this.listPackagesHistory.HideSelection = false;
            this.listPackagesHistory.Location = new System.Drawing.Point(6, 38);
            this.listPackagesHistory.Name = "listPackagesHistory";
            this.listPackagesHistory.Size = new System.Drawing.Size(914, 383);
            this.listPackagesHistory.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listPackagesHistory.TabIndex = 136;
            this.listPackagesHistory.UseCompatibleStateImageBehavior = false;
            this.listPackagesHistory.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            this.columnHeader1.Width = 66;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 154;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Discount";
            this.columnHeader3.Width = 116;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cost";
            this.columnHeader4.Width = 113;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Start date";
            this.columnHeader10.Width = 225;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Expiration date";
            this.columnHeader11.Width = 233;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.listPackagesHistory);
            this.groupBox3.Font = new System.Drawing.Font("Sitka Display", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Navy;
            this.groupBox3.Location = new System.Drawing.Point(37, 448);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(931, 427);
            this.groupBox3.TabIndex = 155;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Packages";
            // 
            // MemberUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.dgvMembers);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.txtSearchMembers);
            this.Controls.Add(this.btRefreshMember);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.ForeColor = System.Drawing.Color.Navy;
            this.Name = "MemberUC";
            this.Size = new System.Drawing.Size(1912, 905);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSearch)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.PictureBox btSearch;
        private System.Windows.Forms.TextBox txtSearchMembers;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView listProductsHistory;
        private System.Windows.Forms.Button btRefreshMember;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.ListView listPackagesHistory;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}
