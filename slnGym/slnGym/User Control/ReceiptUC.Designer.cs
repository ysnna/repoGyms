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
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 189);
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
            this.cbDiscount.Location = new System.Drawing.Point(188, 122);
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
            this.txtSubTotal.Location = new System.Drawing.Point(188, 57);
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
            this.groupPayment.Location = new System.Drawing.Point(995, 399);
            this.groupPayment.Name = "groupPayment";
            this.groupPayment.Size = new System.Drawing.Size(536, 590);
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
            this.btPayment.Location = new System.Drawing.Point(28, 495);
            this.btPayment.Name = "btPayment";
            this.btPayment.Size = new System.Drawing.Size(480, 69);
            this.btPayment.TabIndex = 194;
            this.btPayment.Text = "  PAYMENT";
            this.btPayment.UseVisualStyleBackColor = false;
            // 
            // txtChange
            // 
            this.txtChange.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtChange.Enabled = false;
            this.txtChange.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChange.ForeColor = System.Drawing.Color.Maroon;
            this.txtChange.Location = new System.Drawing.Point(188, 431);
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
            this.txtPaid.Location = new System.Drawing.Point(188, 368);
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
            this.label10.Location = new System.Drawing.Point(427, 438);
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
            this.label11.Location = new System.Drawing.Point(427, 375);
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
            this.label12.Location = new System.Drawing.Point(427, 313);
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
            this.txtTotal.Location = new System.Drawing.Point(188, 306);
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
            this.label9.Location = new System.Drawing.Point(427, 189);
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
            this.lbDiscount.Location = new System.Drawing.Point(427, 126);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(80, 37);
            this.lbDiscount.TabIndex = 186;
            this.lbDiscount.Text = "VND";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 246);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(482, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 184;
            this.pictureBox1.TabStop = false;
            // 
            // txtOthers
            // 
            this.txtOthers.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtOthers.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOthers.ForeColor = System.Drawing.Color.Maroon;
            this.txtOthers.Location = new System.Drawing.Point(188, 182);
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
            this.txtDiscount.Location = new System.Drawing.Point(270, 119);
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
            this.label6.Location = new System.Drawing.Point(32, 375);
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
            this.label5.Location = new System.Drawing.Point(32, 438);
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
            this.label4.Location = new System.Drawing.Point(32, 313);
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
            this.label1.Location = new System.Drawing.Point(32, 126);
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
            this.label3.Location = new System.Drawing.Point(32, 64);
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
            this.label7.Location = new System.Drawing.Point(427, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 37);
            this.label7.TabIndex = 185;
            this.label7.Text = "VND";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(79, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(229, 37);
            this.label13.TabIndex = 180;
            this.label13.Text = "Check of invoice";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(79, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 37);
            this.label8.TabIndex = 181;
            this.label8.Text = "Invoice No";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Maroon;
            this.textBox1.Location = new System.Drawing.Point(241, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 45);
            this.textBox1.TabIndex = 182;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ReceiptUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupPayment);
            this.Name = "ReceiptUC";
            this.Size = new System.Drawing.Size(1555, 1011);
            this.Load += new System.EventHandler(this.ReceiptUC_Load);
            this.groupPayment.ResumeLayout(false);
            this.groupPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
    }
}
