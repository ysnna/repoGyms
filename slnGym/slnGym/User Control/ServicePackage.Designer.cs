namespace slnGym.User_Control
{
    partial class ServicePackage
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
            this.dgvServicePackage = new System.Windows.Forms.DataGridView();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicePackage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvServicePackage
            // 
            this.dgvServicePackage.AllowUserToAddRows = false;
            this.dgvServicePackage.AllowUserToDeleteRows = false;
            this.dgvServicePackage.AllowUserToResizeColumns = false;
            this.dgvServicePackage.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServicePackage.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvServicePackage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvServicePackage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvServicePackage.BackgroundColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServicePackage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvServicePackage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicePackage.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvServicePackage.Location = new System.Drawing.Point(59, 209);
            this.dgvServicePackage.Name = "dgvServicePackage";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServicePackage.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvServicePackage.RowHeadersVisible = false;
            this.dgvServicePackage.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServicePackage.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvServicePackage.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServicePackage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvServicePackage.Size = new System.Drawing.Size(584, 462);
            this.dgvServicePackage.TabIndex = 82;
            // 
            // cbClass
            // 
            this.cbClass.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Items.AddRange(new object[] {
            "Yoga",
            "Gym",
            "Dance",
            "Fitness",
            "Aerobic"});
            this.cbClass.Location = new System.Drawing.Point(253, 160);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(237, 39);
            this.cbClass.TabIndex = 83;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(63, 162);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(184, 37);
            this.label.TabIndex = 84;
            this.label.Text = "Quick search";
            // 
            // ServicePackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.Controls.Add(this.label);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.dgvServicePackage);
            this.Name = "ServicePackage";
            this.Size = new System.Drawing.Size(1445, 727);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicePackage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvServicePackage;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label label;
    }
}
