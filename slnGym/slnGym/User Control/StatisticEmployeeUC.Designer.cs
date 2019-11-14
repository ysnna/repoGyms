namespace slnGym.User_Control
{
    partial class StatisticEmployeeUC
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label47 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.dgvStatistic = new System.Windows.Forms.DataGridView();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.numericYearAVG = new System.Windows.Forms.NumericUpDown();
            this.txtTotalProduct = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.statisticBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYearAVG)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statisticBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label47
            // 
            this.label47.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.ForeColor = System.Drawing.Color.Navy;
            this.label47.Location = new System.Drawing.Point(130, 151);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(563, 31);
            this.label47.TabIndex = 215;
            this.label47.Text = "date start, end, brand, amount, total (VND), status";
            // 
            // label43
            // 
            this.label43.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.Color.Navy;
            this.label43.Location = new System.Drawing.Point(335, 48);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(37, 33);
            this.label43.TabIndex = 214;
            this.label43.Text = "to";
            // 
            // label42
            // 
            this.label42.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.Navy;
            this.label42.Location = new System.Drawing.Point(59, 48);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(76, 33);
            this.label42.TabIndex = 213;
            this.label42.Text = "From";
            // 
            // dgvStatistic
            // 
            this.dgvStatistic.AllowUserToAddRows = false;
            this.dgvStatistic.AllowUserToDeleteRows = false;
            this.dgvStatistic.AllowUserToResizeColumns = false;
            this.dgvStatistic.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStatistic.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStatistic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStatistic.AutoGenerateColumns = false;
            this.dgvStatistic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStatistic.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStatistic.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.groupDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgvStatistic.DataSource = this.statisticBindingSource;
            this.dgvStatistic.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvStatistic.Location = new System.Drawing.Point(59, 99);
            this.dgvStatistic.Name = "dgvStatistic";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStatistic.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStatistic.RowHeadersVisible = false;
            this.dgvStatistic.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStatistic.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStatistic.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStatistic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvStatistic.Size = new System.Drawing.Size(1439, 751);
            this.dgvStatistic.TabIndex = 212;
            // 
            // dateTo
            // 
            this.dateTo.CalendarForeColor = System.Drawing.Color.ForestGreen;
            this.dateTo.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dateTo.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTo.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTo.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTo.Location = new System.Drawing.Point(377, 42);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(171, 41);
            this.dateTo.TabIndex = 211;
            // 
            // dateFrom
            // 
            this.dateFrom.CalendarForeColor = System.Drawing.Color.ForestGreen;
            this.dateFrom.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dateFrom.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateFrom.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateFrom.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFrom.Location = new System.Drawing.Point(137, 42);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(172, 41);
            this.dateFrom.TabIndex = 210;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(1545, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 33);
            this.label1.TabIndex = 216;
            this.label1.Text = "Total ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(1545, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 33);
            this.label3.TabIndex = 218;
            this.label3.Text = "Amount products";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(1545, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 33);
            this.label4.TabIndex = 219;
            this.label4.Text = "Amount packages";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.Navy;
            this.radioButton1.Location = new System.Drawing.Point(1543, 126);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(106, 36);
            this.radioButton1.TabIndex = 220;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Today";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.Navy;
            this.radioButton2.Location = new System.Drawing.Point(1655, 126);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(117, 36);
            this.radioButton2.TabIndex = 221;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Month";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // numericYearAVG
            // 
            this.numericYearAVG.BackColor = System.Drawing.Color.Honeydew;
            this.numericYearAVG.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericYearAVG.ForeColor = System.Drawing.Color.Navy;
            this.numericYearAVG.Location = new System.Drawing.Point(1778, 126);
            this.numericYearAVG.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericYearAVG.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericYearAVG.Name = "numericYearAVG";
            this.numericYearAVG.Size = new System.Drawing.Size(77, 41);
            this.numericYearAVG.TabIndex = 222;
            this.numericYearAVG.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtTotalProduct
            // 
            this.txtTotalProduct.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtTotalProduct.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalProduct.ForeColor = System.Drawing.Color.Navy;
            this.txtTotalProduct.Location = new System.Drawing.Point(1761, 201);
            this.txtTotalProduct.Name = "txtTotalProduct";
            this.txtTotalProduct.Size = new System.Drawing.Size(94, 41);
            this.txtTotalProduct.TabIndex = 223;
            this.txtTotalProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Navy;
            this.textBox1.Location = new System.Drawing.Point(1761, 358);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 41);
            this.textBox1.TabIndex = 224;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Navy;
            this.textBox2.Location = new System.Drawing.Point(1631, 278);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(224, 41);
            this.textBox2.TabIndex = 225;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Navy;
            this.textBox3.Location = new System.Drawing.Point(1631, 437);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(224, 41);
            this.textBox3.TabIndex = 227;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(1545, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 33);
            this.label5.TabIndex = 226;
            this.label5.Text = "Total ";
            // 
            // groupBox9
            // 
            this.groupBox9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox9.Controls.Add(this.lbTotal);
            this.groupBox9.Controls.Add(this.label49);
            this.groupBox9.Controls.Add(this.label54);
            this.groupBox9.Controls.Add(this.label55);
            this.groupBox9.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.ForeColor = System.Drawing.Color.DarkGreen;
            this.groupBox9.Location = new System.Drawing.Point(1520, 494);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(379, 187);
            this.groupBox9.TabIndex = 228;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "_________________________";
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.Crimson;
            this.lbTotal.Location = new System.Drawing.Point(40, 54);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(89, 36);
            this.lbTotal.TabIndex = 229;
            this.lbTotal.Text = "= ???";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.ForeColor = System.Drawing.Color.DarkGreen;
            this.label49.Location = new System.Drawing.Point(-807, 619);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(176, 37);
            this.label49.TabIndex = 81;
            this.label49.Text = "Group name";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.ForeColor = System.Drawing.Color.DarkGreen;
            this.label54.Location = new System.Drawing.Point(-772, 692);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(141, 37);
            this.label54.TabIndex = 80;
            this.label54.Text = "Group ID";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.ForeColor = System.Drawing.Color.DarkGreen;
            this.label55.Location = new System.Drawing.Point(-333, 635);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(100, 37);
            this.label55.TabIndex = 82;
            this.label55.Text = "Salary";
            // 
            // statisticBindingSource
            // 
            this.statisticBindingSource.DataSource = typeof(slnGym.DataObject.Statistic);
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 83;
            // 
            // groupDataGridViewTextBoxColumn
            // 
            this.groupDataGridViewTextBoxColumn.DataPropertyName = "Group";
            this.groupDataGridViewTextBoxColumn.HeaderText = "Group";
            this.groupDataGridViewTextBoxColumn.Name = "groupDataGridViewTextBoxColumn";
            this.groupDataGridViewTextBoxColumn.Width = 99;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 115;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.Width = 86;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 98;
            // 
            // StatisticEmployeeUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtTotalProduct);
            this.Controls.Add(this.numericYearAVG);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label47);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.dgvStatistic);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.groupBox9);
            this.Name = "StatisticEmployeeUC";
            this.Size = new System.Drawing.Size(1912, 905);
            this.Load += new System.EventHandler(this.StatisticEmployeeUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYearAVG)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statisticBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        public System.Windows.Forms.DataGridView dgvStatistic;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.NumericUpDown numericYearAVG;
        private System.Windows.Forms.TextBox txtTotalProduct;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource statisticBindingSource;
    }
}
