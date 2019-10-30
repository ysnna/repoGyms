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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listPT = new System.Windows.Forms.ListView();
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btRefreshMember = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listProductsHistory = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listPackagesHistory = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btSearch = new System.Windows.Forms.PictureBox();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtMember = new System.Windows.Forms.TextBox();
            this.txtSearchMembers = new System.Windows.Forms.TextBox();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // listPT
            // 
            this.listPT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listPT.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listPT.BackgroundImageTiled = true;
            this.listPT.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader16,
            this.columnHeader12});
            this.listPT.Font = new System.Drawing.Font("UTM Aptima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPT.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listPT.FullRowSelect = true;
            this.listPT.GridLines = true;
            this.listPT.HideSelection = false;
            this.listPT.Location = new System.Drawing.Point(17, 185);
            this.listPT.Name = "listPT";
            this.listPT.Size = new System.Drawing.Size(252, 308);
            this.listPT.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listPT.TabIndex = 146;
            this.listPT.UseCompatibleStateImageBehavior = false;
            this.listPT.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "ID";
            this.columnHeader16.Width = 75;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "PT name";
            this.columnHeader12.Width = 172;
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
            this.btRefreshMember.Location = new System.Drawing.Point(1068, 14);
            this.btRefreshMember.Name = "btRefreshMember";
            this.btRefreshMember.Size = new System.Drawing.Size(39, 39);
            this.btRefreshMember.TabIndex = 143;
            this.btRefreshMember.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRefreshMember.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox4.Controls.Add(this.listProductsHistory);
            this.groupBox4.Font = new System.Drawing.Font("Sitka Display", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.DarkGreen;
            this.groupBox4.Location = new System.Drawing.Point(802, 488);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(609, 307);
            this.groupBox4.TabIndex = 145;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Products";
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
            this.listProductsHistory.Font = new System.Drawing.Font("UTM Aptima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listProductsHistory.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listProductsHistory.FullRowSelect = true;
            this.listProductsHistory.GridLines = true;
            this.listProductsHistory.HideSelection = false;
            this.listProductsHistory.Location = new System.Drawing.Point(6, 38);
            this.listProductsHistory.Name = "listProductsHistory";
            this.listProductsHistory.Size = new System.Drawing.Size(597, 263);
            this.listProductsHistory.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listProductsHistory.TabIndex = 132;
            this.listProductsHistory.UseCompatibleStateImageBehavior = false;
            this.listProductsHistory.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "No";
            this.columnHeader5.Width = 56;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Name";
            this.columnHeader6.Width = 148;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Discount";
            this.columnHeader7.Width = 92;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Cost";
            this.columnHeader8.Width = 115;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Transaction history";
            this.columnHeader9.Width = 181;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.listPackagesHistory);
            this.groupBox3.Font = new System.Drawing.Font("Sitka Display", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DarkGreen;
            this.groupBox3.Location = new System.Drawing.Point(7, 488);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(789, 307);
            this.groupBox3.TabIndex = 144;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Packages";
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
            this.listPackagesHistory.Font = new System.Drawing.Font("UTM Aptima", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPackagesHistory.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listPackagesHistory.FullRowSelect = true;
            this.listPackagesHistory.GridLines = true;
            this.listPackagesHistory.HideSelection = false;
            this.listPackagesHistory.Location = new System.Drawing.Point(6, 38);
            this.listPackagesHistory.Name = "listPackagesHistory";
            this.listPackagesHistory.Size = new System.Drawing.Size(777, 263);
            this.listPackagesHistory.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listPackagesHistory.TabIndex = 136;
            this.listPackagesHistory.UseCompatibleStateImageBehavior = false;
            this.listPackagesHistory.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            this.columnHeader1.Width = 56;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 152;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Discount";
            this.columnHeader3.Width = 92;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cost";
            this.columnHeader4.Width = 113;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Start date";
            this.columnHeader10.Width = 178;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Expiration date";
            this.columnHeader11.Width = 180;
            // 
            // btSearch
            // 
            this.btSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSearch.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSearch.BackgroundImage")));
            this.btSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSearch.Location = new System.Drawing.Point(1363, 16);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(39, 35);
            this.btSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btSearch.TabIndex = 148;
            this.btSearch.TabStop = false;
            // 
            // cbClass
            // 
            this.cbClass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbClass.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbClass.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClass.ForeColor = System.Drawing.Color.DarkGreen;
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(17, 59);
            this.cbClass.Margin = new System.Windows.Forms.Padding(8);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(252, 35);
            this.cbClass.TabIndex = 149;
            this.cbClass.Text = "-- Select group name --";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Green;
            this.label22.Location = new System.Drawing.Point(21, 105);
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
            this.txtMember.Location = new System.Drawing.Point(17, 135);
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
            this.txtSearchMembers.Location = new System.Drawing.Point(1113, 14);
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
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMembers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMembers.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Display", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMembers.Location = new System.Drawing.Point(280, 59);
            this.dgvMembers.Name = "dgvMembers";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Sitka Display", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMembers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMembers.RowHeadersVisible = false;
            this.dgvMembers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMembers.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMembers.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMembers.Size = new System.Drawing.Size(1125, 434);
            this.dgvMembers.TabIndex = 153;
            // 
            // ManageMembersUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.dgvMembers);
            this.Controls.Add(this.txtMember);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.listPT);
            this.Controls.Add(this.btRefreshMember);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtSearchMembers);
            this.Name = "ManageMembersUC";
            this.Size = new System.Drawing.Size(1414, 798);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listPT;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Button btRefreshMember;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView listProductsHistory;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView listPackagesHistory;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.PictureBox btSearch;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtMember;
        private System.Windows.Forms.TextBox txtSearchMembers;
        public System.Windows.Forms.DataGridView dgvMembers;
    }
}
