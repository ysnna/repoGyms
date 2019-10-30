namespace slnGym.User_Control
{
    partial class ManageEmployeeUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageEmployeeUC));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btCreate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btRefresh = new System.Windows.Forms.Button();
            this.picAva = new System.Windows.Forms.PictureBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbGroupName = new System.Windows.Forms.ComboBox();
            this.dgvListEmployee = new System.Windows.Forms.DataGridView();
            this.btSearch = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.editEmployeeUC = new slnGym.User_Control.EditEmployeeUC();
            this.newEmployeeUC = new slnGym.User_Control.NewEmployeeUC();
            ((System.ComponentModel.ISupportInitialize)(this.picAva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // btCreate
            // 
            this.btCreate.BackColor = System.Drawing.Color.Transparent;
            this.btCreate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCreate.BackgroundImage")));
            this.btCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btCreate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCreate.Font = new System.Drawing.Font("Sitka Subheading", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreate.ForeColor = System.Drawing.Color.White;
            this.btCreate.Location = new System.Drawing.Point(941, 58);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(54, 45);
            this.btCreate.TabIndex = 188;
            this.btCreate.UseVisualStyleBackColor = false;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Transparent;
            this.btDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btDelete.BackgroundImage")));
            this.btDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelete.Font = new System.Drawing.Font("Sitka Subheading", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.ForeColor = System.Drawing.Color.White;
            this.btDelete.Location = new System.Drawing.Point(1061, 58);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(51, 45);
            this.btDelete.TabIndex = 187;
            this.btDelete.UseVisualStyleBackColor = false;
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.Color.Transparent;
            this.btEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btEdit.BackgroundImage")));
            this.btEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEdit.Font = new System.Drawing.Font("Sitka Subheading", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.ForeColor = System.Drawing.Color.White;
            this.btEdit.Location = new System.Drawing.Point(1001, 58);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(54, 45);
            this.btEdit.TabIndex = 186;
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btRefresh.BackgroundImage")));
            this.btRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btRefresh.FlatAppearance.BorderSize = 3;
            this.btRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRefresh.Font = new System.Drawing.Font("Sitka Subheading", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRefresh.ForeColor = System.Drawing.Color.White;
            this.btRefresh.Location = new System.Drawing.Point(1069, 123);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(43, 44);
            this.btRefresh.TabIndex = 185;
            this.btRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRefresh.UseVisualStyleBackColor = false;
            // 
            // picAva
            // 
            this.picAva.BackColor = System.Drawing.Color.Transparent;
            this.picAva.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picAva.BackgroundImage")));
            this.picAva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picAva.Location = new System.Drawing.Point(941, 218);
            this.picAva.Name = "picAva";
            this.picAva.Size = new System.Drawing.Size(232, 276);
            this.picAva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAva.TabIndex = 127;
            this.picAva.TabStop = false;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbUsername.Location = new System.Drawing.Point(1189, 291);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(147, 37);
            this.lbUsername.TabIndex = 129;
            this.lbUsername.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(1189, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 36);
            this.label1.TabIndex = 128;
            this.label1.Text = "Username";
            // 
            // cbGroupName
            // 
            this.cbGroupName.BackColor = System.Drawing.Color.Honeydew;
            this.cbGroupName.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGroupName.ForeColor = System.Drawing.Color.DarkGreen;
            this.cbGroupName.FormattingEnabled = true;
            this.cbGroupName.Location = new System.Drawing.Point(1134, 62);
            this.cbGroupName.Margin = new System.Windows.Forms.Padding(8);
            this.cbGroupName.Name = "cbGroupName";
            this.cbGroupName.Size = new System.Drawing.Size(229, 41);
            this.cbGroupName.TabIndex = 125;
            // 
            // dgvListEmployee
            // 
            this.dgvListEmployee.AllowUserToAddRows = false;
            this.dgvListEmployee.AllowUserToDeleteRows = false;
            this.dgvListEmployee.AllowUserToResizeColumns = false;
            this.dgvListEmployee.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListEmployee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvListEmployee.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvListEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListEmployee.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvListEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListEmployee.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListEmployee.Location = new System.Drawing.Point(18, 16);
            this.dgvListEmployee.Name = "dgvListEmployee";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListEmployee.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvListEmployee.RowHeadersVisible = false;
            this.dgvListEmployee.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListEmployee.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvListEmployee.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvListEmployee.Size = new System.Drawing.Size(888, 765);
            this.dgvListEmployee.TabIndex = 190;
            // 
            // btSearch
            // 
            this.btSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSearch.BackColor = System.Drawing.Color.MintCream;
            this.btSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSearch.BackgroundImage")));
            this.btSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSearch.Location = new System.Drawing.Point(1320, 125);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(40, 40);
            this.btSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btSearch.TabIndex = 191;
            this.btSearch.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.MintCream;
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtSearch.Location = new System.Drawing.Point(1134, 123);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '*';
            this.txtSearch.Size = new System.Drawing.Size(229, 44);
            this.txtSearch.TabIndex = 192;
            // 
            // editEmployeeUC
            // 
            this.editEmployeeUC.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.editEmployeeUC.Location = new System.Drawing.Point(0, 0);
            this.editEmployeeUC.Name = "editEmployeeUC";
            this.editEmployeeUC.Size = new System.Drawing.Size(1414, 798);
            this.editEmployeeUC.TabIndex = 193;
            // 
            // newEmployeeUC
            // 
            this.newEmployeeUC.AutoSize = true;
            this.newEmployeeUC.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.newEmployeeUC.Location = new System.Drawing.Point(0, 0);
            this.newEmployeeUC.Name = "newEmployeeUC";
            this.newEmployeeUC.Size = new System.Drawing.Size(1414, 798);
            this.newEmployeeUC.TabIndex = 194;
            this.newEmployeeUC.Visible = false;
            // 
            // ManageEmployeeUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.picAva);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListEmployee);
            this.Controls.Add(this.cbGroupName);
            this.Controls.Add(this.btCreate);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.newEmployeeUC);
            this.Controls.Add(this.editEmployeeUC);
            this.Name = "ManageEmployeeUC";
            this.Size = new System.Drawing.Size(1414, 798);
            this.Load += new System.EventHandler(this.ManageEmployeeUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.PictureBox picAva;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbGroupName;
        public System.Windows.Forms.DataGridView dgvListEmployee;
        private System.Windows.Forms.PictureBox btSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private EditEmployeeUC editEmployeeUC;
        private NewEmployeeUC newEmployeeUC;
    }
}
