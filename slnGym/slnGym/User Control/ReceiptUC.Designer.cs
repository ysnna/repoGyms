namespace slnGym.User_Control
{
    partial class ReceiptUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptUC));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDiscount = new System.Windows.Forms.ComboBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.groupPayment = new System.Windows.Forms.GroupBox();
            this.btPayment = new System.Windows.Forms.Button();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtOthers = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btPrintInvoice = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMemIDInvoide = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbDatePayment = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.dgvCheckInvoice = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label0 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtNameMember = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.listViewProducts = new System.Windows.Forms.ListView();
            this.label13 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbTimePayment = new System.Windows.Forms.Label();
            this.groupPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckInvoice)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 37);
            this.label2.TabIndex = 178;
            this.label2.Text = "Others";
            // 
            // cbDiscount
            // 
            this.cbDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbDiscount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiscount.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDiscount.ForeColor = System.Drawing.Color.DimGray;
            this.cbDiscount.FormattingEnabled = true;
            this.cbDiscount.Items.AddRange(new object[] {
            "%",
            "VND"});
            this.cbDiscount.Location = new System.Drawing.Point(175, 123);
            this.cbDiscount.Margin = new System.Windows.Forms.Padding(8);
            this.cbDiscount.Name = "cbDiscount";
            this.cbDiscount.Size = new System.Drawing.Size(80, 39);
            this.cbDiscount.TabIndex = 177;
            this.cbDiscount.TextChanged += new System.EventHandler(this.cbDiscount_TextChanged);
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.ForeColor = System.Drawing.Color.Maroon;
            this.txtSubTotal.Location = new System.Drawing.Point(175, 58);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(233, 45);
            this.txtSubTotal.TabIndex = 176;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupPayment
            // 
            this.groupPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPayment.Controls.Add(this.btPayment);
            this.groupPayment.Controls.Add(this.txtChange);
            this.groupPayment.Controls.Add(this.txtPaid);
            this.groupPayment.Controls.Add(this.label10);
            this.groupPayment.Controls.Add(this.label11);
            this.groupPayment.Controls.Add(this.label12);
            this.groupPayment.Controls.Add(this.txtTotal);
            this.groupPayment.Controls.Add(this.label9);
            this.groupPayment.Controls.Add(this.lbDiscount);
            this.groupPayment.Controls.Add(this.pictureBox1);
            this.groupPayment.Controls.Add(this.txtOthers);
            this.groupPayment.Controls.Add(this.txtDiscount);
            this.groupPayment.Controls.Add(this.cbDiscount);
            this.groupPayment.Controls.Add(this.label6);
            this.groupPayment.Controls.Add(this.label5);
            this.groupPayment.Controls.Add(this.label4);
            this.groupPayment.Controls.Add(this.label1);
            this.groupPayment.Controls.Add(this.label2);
            this.groupPayment.Controls.Add(this.label3);
            this.groupPayment.Controls.Add(this.txtSubTotal);
            this.groupPayment.Controls.Add(this.label7);
            this.groupPayment.Font = new System.Drawing.Font("Sitka Display", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPayment.ForeColor = System.Drawing.Color.White;
            this.groupPayment.Location = new System.Drawing.Point(1012, 373);
            this.groupPayment.Name = "groupPayment";
            this.groupPayment.Size = new System.Drawing.Size(520, 611);
            this.groupPayment.TabIndex = 179;
            this.groupPayment.TabStop = false;
            this.groupPayment.Text = "Payment";
            // 
            // btPayment
            // 
            this.btPayment.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btPayment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btPayment.BackgroundImage")));
            this.btPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btPayment.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btPayment.FlatAppearance.BorderSize = 3;
            this.btPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPayment.Font = new System.Drawing.Font("Arrus-Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btPayment.Location = new System.Drawing.Point(26, 520);
            this.btPayment.Name = "btPayment";
            this.btPayment.Size = new System.Drawing.Size(468, 75);
            this.btPayment.TabIndex = 194;
            this.btPayment.Text = "  PAYMENT";
            this.btPayment.UseVisualStyleBackColor = false;
            this.btPayment.Click += new System.EventHandler(this.btPayment_Click);
            // 
            // txtChange
            // 
            this.txtChange.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtChange.Enabled = false;
            this.txtChange.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChange.ForeColor = System.Drawing.Color.Maroon;
            this.txtChange.Location = new System.Drawing.Point(175, 440);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(233, 45);
            this.txtChange.TabIndex = 193;
            this.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPaid
            // 
            this.txtPaid.BackColor = System.Drawing.Color.Thistle;
            this.txtPaid.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaid.ForeColor = System.Drawing.Color.Maroon;
            this.txtPaid.Location = new System.Drawing.Point(175, 377);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(233, 45);
            this.txtPaid.TabIndex = 192;
            this.txtPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPaid.TextChanged += new System.EventHandler(this.txtPaid_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(414, 447);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 37);
            this.label10.TabIndex = 191;
            this.label10.Text = "VND";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(414, 384);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 37);
            this.label11.TabIndex = 190;
            this.label11.Text = "VND";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(414, 322);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 37);
            this.label12.TabIndex = 189;
            this.label12.Text = "VND";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.MediumAquamarine;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Maroon;
            this.txtTotal.Location = new System.Drawing.Point(175, 315);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(233, 45);
            this.txtTotal.TabIndex = 188;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(414, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 37);
            this.label9.TabIndex = 187;
            this.label9.Text = "VND";
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiscount.ForeColor = System.Drawing.Color.White;
            this.lbDiscount.Location = new System.Drawing.Point(414, 127);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(80, 37);
            this.lbDiscount.TabIndex = 186;
            this.lbDiscount.Text = "VND";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 255);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(481, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 184;
            this.pictureBox1.TabStop = false;
            // 
            // txtOthers
            // 
            this.txtOthers.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtOthers.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOthers.ForeColor = System.Drawing.Color.Maroon;
            this.txtOthers.Location = new System.Drawing.Point(175, 183);
            this.txtOthers.Name = "txtOthers";
            this.txtOthers.Size = new System.Drawing.Size(233, 45);
            this.txtOthers.TabIndex = 183;
            this.txtOthers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDiscount
            // 
            this.txtDiscount.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtDiscount.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.ForeColor = System.Drawing.Color.Maroon;
            this.txtDiscount.Location = new System.Drawing.Point(257, 120);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(151, 45);
            this.txtDiscount.TabIndex = 182;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(32, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 37);
            this.label6.TabIndex = 181;
            this.label6.Text = "Paid";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(32, 447);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 37);
            this.label5.TabIndex = 180;
            this.label5.Text = "Change";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(32, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 37);
            this.label4.TabIndex = 179;
            this.label4.Text = "Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 37);
            this.label1.TabIndex = 175;
            this.label1.Text = "Discount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 37);
            this.label3.TabIndex = 89;
            this.label3.Text = "Subtotal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(414, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 37);
            this.label7.TabIndex = 185;
            this.label7.Text = "VND";
            // 
            // btPrintInvoice
            // 
            this.btPrintInvoice.BackColor = System.Drawing.Color.Crimson;
            this.btPrintInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btPrintInvoice.FlatAppearance.BorderColor = System.Drawing.Color.DarkMagenta;
            this.btPrintInvoice.FlatAppearance.BorderSize = 3;
            this.btPrintInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPrintInvoice.Font = new System.Drawing.Font("Arrus-Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrintInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btPrintInvoice.Location = new System.Drawing.Point(606, 931);
            this.btPrintInvoice.Name = "btPrintInvoice";
            this.btPrintInvoice.Size = new System.Drawing.Size(385, 53);
            this.btPrintInvoice.TabIndex = 195;
            this.btPrintInvoice.Text = "PRINT AN INVOICE";
            this.btPrintInvoice.UseVisualStyleBackColor = false;
            this.btPrintInvoice.Click += new System.EventHandler(this.btPrintInvoice_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(599, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 37);
            this.label8.TabIndex = 181;
            this.label8.Text = "Invoice No";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtInvoiceNo.Enabled = false;
            this.txtInvoiceNo.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceNo.ForeColor = System.Drawing.Color.Maroon;
            this.txtInvoiceNo.Location = new System.Drawing.Point(789, 148);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(177, 45);
            this.txtInvoiceNo.TabIndex = 182;
            this.txtInvoiceNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtComment
            // 
            this.txtComment.BackColor = System.Drawing.Color.LightYellow;
            this.txtComment.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComment.ForeColor = System.Drawing.Color.Maroon;
            this.txtComment.Location = new System.Drawing.Point(1032, 148);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(493, 201);
            this.txtComment.TabIndex = 183;
            this.txtComment.Text = "Total payment due in ... days ";
            this.txtComment.WordWrap = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(1026, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(461, 33);
            this.label14.TabIndex = 184;
            this.label14.Text = "Other comments or Specical intructions";
            // 
            // txtMemIDInvoide
            // 
            this.txtMemIDInvoide.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtMemIDInvoide.Enabled = false;
            this.txtMemIDInvoide.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemIDInvoide.ForeColor = System.Drawing.Color.Maroon;
            this.txtMemIDInvoide.Location = new System.Drawing.Point(789, 199);
            this.txtMemIDInvoide.Name = "txtMemIDInvoide";
            this.txtMemIDInvoide.Size = new System.Drawing.Size(177, 45);
            this.txtMemIDInvoide.TabIndex = 186;
            this.txtMemIDInvoide.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(599, 207);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(165, 37);
            this.label15.TabIndex = 185;
            this.label15.Text = "Member ID";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(599, 108);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 37);
            this.label16.TabIndex = 187;
            this.label16.Text = "Date";
            // 
            // lbDatePayment
            // 
            this.lbDatePayment.AutoSize = true;
            this.lbDatePayment.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatePayment.ForeColor = System.Drawing.Color.White;
            this.lbDatePayment.Location = new System.Drawing.Point(782, 108);
            this.lbDatePayment.Name = "lbDatePayment";
            this.lbDatePayment.Size = new System.Drawing.Size(195, 37);
            this.lbDatePayment.TabIndex = 188;
            this.lbDatePayment.Text = "Date payment";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(599, 258);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(185, 37);
            this.label17.TabIndex = 189;
            this.label17.Text = "Employee ID";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtEmployeeID.Enabled = false;
            this.txtEmployeeID.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeID.ForeColor = System.Drawing.Color.Maroon;
            this.txtEmployeeID.Location = new System.Drawing.Point(789, 250);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(177, 45);
            this.txtEmployeeID.TabIndex = 190;
            this.txtEmployeeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvCheckInvoice
            // 
            this.dgvCheckInvoice.AllowUserToAddRows = false;
            this.dgvCheckInvoice.AllowUserToDeleteRows = false;
            this.dgvCheckInvoice.AllowUserToResizeColumns = false;
            this.dgvCheckInvoice.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCheckInvoice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCheckInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCheckInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCheckInvoice.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCheckInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCheckInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckInvoice.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCheckInvoice.Location = new System.Drawing.Point(282, 352);
            this.dgvCheckInvoice.Name = "dgvCheckInvoice";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCheckInvoice.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCheckInvoice.RowHeadersVisible = false;
            this.dgvCheckInvoice.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCheckInvoice.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCheckInvoice.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCheckInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCheckInvoice.Size = new System.Drawing.Size(709, 573);
            this.dgvCheckInvoice.TabIndex = 191;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Maroon;
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(1555, 59);
            this.textBox2.TabIndex = 192;
            this.textBox2.Text = "Check of INVOICE";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label0.ForeColor = System.Drawing.Color.White;
            this.label0.Location = new System.Drawing.Point(282, 931);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(76, 27);
            this.label0.TabIndex = 193;
            this.label0.Text = "Status:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtNote);
            this.groupBox1.Controls.Add(this.txtGender);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtNameMember);
            this.groupBox1.Font = new System.Drawing.Font("Sitka Display", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(35, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 212);
            this.groupBox1.TabIndex = 194;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invoice to";
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.Color.LightYellow;
            this.txtNote.Enabled = false;
            this.txtNote.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.ForeColor = System.Drawing.Color.Maroon;
            this.txtNote.Location = new System.Drawing.Point(23, 148);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(480, 41);
            this.txtNote.TabIndex = 187;
            this.txtNote.Text = "Note";
            // 
            // txtGender
            // 
            this.txtGender.BackColor = System.Drawing.Color.LightYellow;
            this.txtGender.Enabled = false;
            this.txtGender.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.ForeColor = System.Drawing.Color.Maroon;
            this.txtGender.Location = new System.Drawing.Point(402, 101);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(101, 41);
            this.txtGender.TabIndex = 186;
            this.txtGender.Text = "Female";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.Color.LightYellow;
            this.txtPhoneNumber.Enabled = false;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.Maroon;
            this.txtPhoneNumber.Location = new System.Drawing.Point(309, 54);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(194, 41);
            this.txtPhoneNumber.TabIndex = 185;
            this.txtPhoneNumber.Text = "Phone number";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.LightYellow;
            this.txtAddress.Enabled = false;
            this.txtAddress.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.Maroon;
            this.txtAddress.Location = new System.Drawing.Point(23, 101);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(373, 41);
            this.txtAddress.TabIndex = 184;
            this.txtAddress.Text = "Address";
            // 
            // txtNameMember
            // 
            this.txtNameMember.BackColor = System.Drawing.Color.LightYellow;
            this.txtNameMember.Enabled = false;
            this.txtNameMember.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameMember.ForeColor = System.Drawing.Color.Maroon;
            this.txtNameMember.Location = new System.Drawing.Point(23, 54);
            this.txtNameMember.Name = "txtNameMember";
            this.txtNameMember.Size = new System.Drawing.Size(280, 41);
            this.txtNameMember.TabIndex = 183;
            this.txtNameMember.Text = "Fullname";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(276, 316);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(96, 33);
            this.label18.TabIndex = 195;
            this.label18.Text = "Details";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(17, 316);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(168, 33);
            this.label19.TabIndex = 196;
            this.label19.Text = "Add Products";
            // 
            // listViewProducts
            // 
            this.listViewProducts.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.listViewProducts.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewProducts.HideSelection = false;
            this.listViewProducts.Location = new System.Drawing.Point(23, 352);
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(253, 632);
            this.listViewProducts.TabIndex = 197;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(282, 958);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 27);
            this.label13.TabIndex = 198;
            this.label13.Text = "Time:";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.Color.White;
            this.lbStatus.Location = new System.Drawing.Point(355, 931);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(144, 27);
            this.lbStatus.TabIndex = 199;
            this.lbStatus.Text = "Non-payment";
            this.lbStatus.TextChanged += new System.EventHandler(this.lbStatus_TextChanged);
            // 
            // lbTimePayment
            // 
            this.lbTimePayment.AutoSize = true;
            this.lbTimePayment.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimePayment.ForeColor = System.Drawing.Color.White;
            this.lbTimePayment.Location = new System.Drawing.Point(355, 957);
            this.lbTimePayment.Name = "lbTimePayment";
            this.lbTimePayment.Size = new System.Drawing.Size(136, 27);
            this.lbTimePayment.TabIndex = 200;
            this.lbTimePayment.Text = "dd-mm-yyyy";
            // 
            // ReceiptUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.lbTimePayment);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btPrintInvoice);
            this.Controls.Add(this.listViewProducts);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dgvCheckInvoice);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lbDatePayment);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtMemIDInvoide);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtInvoiceNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupPayment);
            this.Name = "ReceiptUC";
            this.Size = new System.Drawing.Size(1555, 1011);
            this.Load += new System.EventHandler(this.ReceiptUC_Load);
            this.groupPayment.ResumeLayout(false);
            this.groupPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckInvoice)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDiscount;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.GroupBox groupPayment;
        private System.Windows.Forms.TextBox txtOthers;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btPayment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMemIDInvoide;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbDatePayment;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtEmployeeID;
        public System.Windows.Forms.DataGridView dgvCheckInvoice;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtNameMember;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.ListView listViewProducts;
        private System.Windows.Forms.Button btPrintInvoice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbTimePayment;
    }
}
