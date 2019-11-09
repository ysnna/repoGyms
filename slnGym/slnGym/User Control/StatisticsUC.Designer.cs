namespace slnGym.User_Control
{
    partial class StatisticsUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticsUC));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btCreateChart = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.chartStatistic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.numericYearAVG = new System.Windows.Forms.NumericUpDown();
            this.numericMonthAVG = new System.Windows.Forms.NumericUpDown();
            this.label63 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.txtTotalPackage = new System.Windows.Forms.TextBox();
            this.txtTotalProduct = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.dgvStatistic = new System.Windows.Forms.DataGridView();
            this.lbYearAVG = new System.Windows.Forms.Label();
            this.lbMonthAVG = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.statisticBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistic)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericYearAVG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMonthAVG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btCreateChart
            // 
            this.btCreateChart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btCreateChart.BackColor = System.Drawing.Color.White;
            this.btCreateChart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCreateChart.BackgroundImage")));
            this.btCreateChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btCreateChart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btCreateChart.FlatAppearance.BorderSize = 3;
            this.btCreateChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCreateChart.Font = new System.Drawing.Font("Sitka Subheading", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreateChart.ForeColor = System.Drawing.Color.Wheat;
            this.btCreateChart.Location = new System.Drawing.Point(1307, 206);
            this.btCreateChart.Name = "btCreateChart";
            this.btCreateChart.Size = new System.Drawing.Size(95, 60);
            this.btCreateChart.TabIndex = 203;
            this.btCreateChart.UseVisualStyleBackColor = false;
            this.btCreateChart.Click += new System.EventHandler(this.btCreateChart_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightGreen;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Maroon;
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(1414, 48);
            this.textBox2.TabIndex = 202;
            this.textBox2.Text = "Total of sales for today to current date ... : ";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateTo
            // 
            this.dateTo.CalendarForeColor = System.Drawing.Color.ForestGreen;
            this.dateTo.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dateTo.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTo.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTo.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTo.Location = new System.Drawing.Point(318, 63);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(159, 39);
            this.dateTo.TabIndex = 201;
            // 
            // dateFrom
            // 
            this.dateFrom.CalendarForeColor = System.Drawing.Color.ForestGreen;
            this.dateFrom.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dateFrom.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateFrom.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateFrom.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFrom.Location = new System.Drawing.Point(101, 63);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(159, 39);
            this.dateFrom.TabIndex = 200;
            // 
            // cbCategory
            // 
            this.cbCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbCategory.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbCategory.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.ForeColor = System.Drawing.Color.DarkGreen;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "All",
            "Days",
            "Months",
            "Products",
            "Packages",
            "Years"});
            this.cbCategory.Location = new System.Drawing.Point(536, 63);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(8);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(243, 39);
            this.cbCategory.TabIndex = 199;
            this.cbCategory.Text = "-- Select category --";
            // 
            // chartStatistic
            // 
            chartArea2.Name = "ChartArea1";
            this.chartStatistic.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartStatistic.Legends.Add(legend2);
            this.chartStatistic.Location = new System.Drawing.Point(790, 271);
            this.chartStatistic.Name = "chartStatistic";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartStatistic.Series.Add(series2);
            this.chartStatistic.Size = new System.Drawing.Size(612, 485);
            this.chartStatistic.TabIndex = 198;
            this.chartStatistic.Text = "chart";
            // 
            // groupBox9
            // 
            this.groupBox9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox9.Controls.Add(this.numericYearAVG);
            this.groupBox9.Controls.Add(this.numericMonthAVG);
            this.groupBox9.Controls.Add(this.label63);
            this.groupBox9.Controls.Add(this.label62);
            this.groupBox9.Controls.Add(this.label61);
            this.groupBox9.Controls.Add(this.label59);
            this.groupBox9.Controls.Add(this.label58);
            this.groupBox9.Controls.Add(this.txtTotalPackage);
            this.groupBox9.Controls.Add(this.txtTotalProduct);
            this.groupBox9.Controls.Add(this.label57);
            this.groupBox9.Controls.Add(this.label56);
            this.groupBox9.Controls.Add(this.label49);
            this.groupBox9.Controls.Add(this.label54);
            this.groupBox9.Controls.Add(this.label55);
            this.groupBox9.Font = new System.Drawing.Font("Sitka Display", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.ForeColor = System.Drawing.Color.DarkGreen;
            this.groupBox9.Location = new System.Drawing.Point(790, 44);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(511, 222);
            this.groupBox9.TabIndex = 204;
            this.groupBox9.TabStop = false;
            // 
            // numericYearAVG
            // 
            this.numericYearAVG.BackColor = System.Drawing.Color.Honeydew;
            this.numericYearAVG.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericYearAVG.ForeColor = System.Drawing.Color.DarkGreen;
            this.numericYearAVG.Location = new System.Drawing.Point(394, 152);
            this.numericYearAVG.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numericYearAVG.Minimum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.numericYearAVG.Name = "numericYearAVG";
            this.numericYearAVG.Size = new System.Drawing.Size(86, 39);
            this.numericYearAVG.TabIndex = 151;
            this.numericYearAVG.Value = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            // 
            // numericMonthAVG
            // 
            this.numericMonthAVG.BackColor = System.Drawing.Color.Honeydew;
            this.numericMonthAVG.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericMonthAVG.ForeColor = System.Drawing.Color.DarkGreen;
            this.numericMonthAVG.Location = new System.Drawing.Point(250, 152);
            this.numericMonthAVG.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericMonthAVG.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericMonthAVG.Name = "numericMonthAVG";
            this.numericMonthAVG.Size = new System.Drawing.Size(54, 39);
            this.numericMonthAVG.TabIndex = 148;
            this.numericMonthAVG.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label63
            // 
            this.label63.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.ForeColor = System.Drawing.Color.Green;
            this.label63.Location = new System.Drawing.Point(322, 154);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(73, 31);
            this.label63.TabIndex = 150;
            this.label63.Text = "Years";
            // 
            // label62
            // 
            this.label62.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.ForeColor = System.Drawing.Color.Green;
            this.label62.Location = new System.Drawing.Point(164, 154);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(88, 31);
            this.label62.TabIndex = 149;
            this.label62.Text = "Month";
            // 
            // label61
            // 
            this.label61.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.ForeColor = System.Drawing.Color.Green;
            this.label61.Location = new System.Drawing.Point(36, 154);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(100, 31);
            this.label61.TabIndex = 147;
            this.label61.Text = "Average";
            // 
            // label59
            // 
            this.label59.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.ForeColor = System.Drawing.Color.Green;
            this.label59.Location = new System.Drawing.Point(409, 103);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(71, 31);
            this.label59.TabIndex = 146;
            this.label59.Text = "VND";
            // 
            // label58
            // 
            this.label58.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.ForeColor = System.Drawing.Color.Green;
            this.label58.Location = new System.Drawing.Point(409, 48);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(71, 31);
            this.label58.TabIndex = 145;
            this.label58.Text = "VND";
            // 
            // txtTotalPackage
            // 
            this.txtTotalPackage.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtTotalPackage.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPackage.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtTotalPackage.Location = new System.Drawing.Point(170, 98);
            this.txtTotalPackage.Name = "txtTotalPackage";
            this.txtTotalPackage.Size = new System.Drawing.Size(233, 41);
            this.txtTotalPackage.TabIndex = 144;
            this.txtTotalPackage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalProduct
            // 
            this.txtTotalProduct.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtTotalProduct.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalProduct.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtTotalProduct.Location = new System.Drawing.Point(170, 43);
            this.txtTotalProduct.Name = "txtTotalProduct";
            this.txtTotalProduct.Size = new System.Drawing.Size(233, 41);
            this.txtTotalProduct.TabIndex = 143;
            this.txtTotalProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label57
            // 
            this.label57.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.ForeColor = System.Drawing.Color.Green;
            this.label57.Location = new System.Drawing.Point(36, 103);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(112, 31);
            this.label57.TabIndex = 142;
            this.label57.Text = "Packages";
            // 
            // label56
            // 
            this.label56.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.ForeColor = System.Drawing.Color.Green;
            this.label56.Location = new System.Drawing.Point(36, 48);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(110, 31);
            this.label56.TabIndex = 141;
            this.label56.Text = "Products";
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
            // dgvStatistic
            // 
            this.dgvStatistic.AllowUserToAddRows = false;
            this.dgvStatistic.AllowUserToDeleteRows = false;
            this.dgvStatistic.AllowUserToResizeColumns = false;
            this.dgvStatistic.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStatistic.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStatistic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStatistic.AutoGenerateColumns = false;
            this.dgvStatistic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStatistic.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStatistic.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvStatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.groupDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgvStatistic.DataSource = this.statisticBindingSource;
            this.dgvStatistic.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvStatistic.Location = new System.Drawing.Point(12, 108);
            this.dgvStatistic.Name = "dgvStatistic";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStatistic.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvStatistic.RowHeadersVisible = false;
            this.dgvStatistic.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStatistic.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvStatistic.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStatistic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvStatistic.Size = new System.Drawing.Size(768, 648);
            this.dgvStatistic.TabIndex = 205;
            // 
            // lbYearAVG
            // 
            this.lbYearAVG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbYearAVG.AutoSize = true;
            this.lbYearAVG.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYearAVG.ForeColor = System.Drawing.Color.Crimson;
            this.lbYearAVG.Location = new System.Drawing.Point(638, 759);
            this.lbYearAVG.Name = "lbYearAVG";
            this.lbYearAVG.Size = new System.Drawing.Size(114, 26);
            this.lbYearAVG.TabIndex = 212;
            this.lbYearAVG.Text = "avgYearly";
            // 
            // lbMonthAVG
            // 
            this.lbMonthAVG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbMonthAVG.AutoSize = true;
            this.lbMonthAVG.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonthAVG.ForeColor = System.Drawing.Color.Crimson;
            this.lbMonthAVG.Location = new System.Drawing.Point(214, 759);
            this.lbMonthAVG.Name = "lbMonthAVG";
            this.lbMonthAVG.Size = new System.Drawing.Size(135, 26);
            this.lbMonthAVG.TabIndex = 211;
            this.lbMonthAVG.Text = "avgMonthly";
            // 
            // label64
            // 
            this.label64.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.ForeColor = System.Drawing.Color.Crimson;
            this.label64.Location = new System.Drawing.Point(467, 759);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(165, 27);
            this.label64.TabIndex = 210;
            this.label64.Text = "Average Yearly:";
            // 
            // label60
            // 
            this.label60.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.ForeColor = System.Drawing.Color.Crimson;
            this.label60.Location = new System.Drawing.Point(23, 759);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(185, 27);
            this.label60.TabIndex = 208;
            this.label60.Text = "Average Monthly:";
            // 
            // label43
            // 
            this.label43.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.Color.Green;
            this.label43.Location = new System.Drawing.Point(276, 69);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(36, 31);
            this.label43.TabIndex = 207;
            this.label43.Text = "to";
            // 
            // label42
            // 
            this.label42.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.Green;
            this.label42.Location = new System.Drawing.Point(23, 69);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(72, 31);
            this.label42.TabIndex = 206;
            this.label42.Text = "From";
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
            // StatisticsUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.lbYearAVG);
            this.Controls.Add(this.lbMonthAVG);
            this.Controls.Add(this.label64);
            this.Controls.Add(this.label60);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.dgvStatistic);
            this.Controls.Add(this.btCreateChart);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.chartStatistic);
            this.Controls.Add(this.groupBox9);
            this.Name = "StatisticsUC";
            this.Size = new System.Drawing.Size(1414, 798);
            this.Load += new System.EventHandler(this.StatisticsUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistic)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericYearAVG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMonthAVG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCreateChart;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatistic;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.NumericUpDown numericYearAVG;
        private System.Windows.Forms.NumericUpDown numericMonthAVG;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.TextBox txtTotalPackage;
        private System.Windows.Forms.TextBox txtTotalProduct;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        public System.Windows.Forms.DataGridView dgvStatistic;
        private System.Windows.Forms.Label lbYearAVG;
        private System.Windows.Forms.Label lbMonthAVG;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource statisticBindingSource;
    }
}
