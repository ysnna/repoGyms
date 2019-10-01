namespace slnGym
{
    partial class LoginUC
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
            this.radioAdmin = new System.Windows.Forms.RadioButton();
            this.radioMember = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radioNhanVien = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.groupBoxThongtin = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioNVGiamSat = new System.Windows.Forms.RadioButton();
            this.groupBoxThongtin.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioAdmin
            // 
            this.radioAdmin.AutoSize = true;
            this.radioAdmin.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAdmin.Location = new System.Drawing.Point(582, 427);
            this.radioAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.radioAdmin.Name = "radioAdmin";
            this.radioAdmin.Size = new System.Drawing.Size(141, 48);
            this.radioAdmin.TabIndex = 46;
            this.radioAdmin.TabStop = true;
            this.radioAdmin.Text = "Admin";
            this.radioAdmin.UseVisualStyleBackColor = true;
            // 
            // radioMember
            // 
            this.radioMember.AutoSize = true;
            this.radioMember.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMember.Location = new System.Drawing.Point(368, 493);
            this.radioMember.Margin = new System.Windows.Forms.Padding(2);
            this.radioMember.Name = "radioMember";
            this.radioMember.Size = new System.Drawing.Size(162, 48);
            this.radioMember.TabIndex = 47;
            this.radioMember.TabStop = true;
            this.radioMember.Text = "Member";
            this.radioMember.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM Aptima", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(283, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 48);
            this.label2.TabIndex = 37;
            this.label2.Text = "Username";
            // 
            // radioNhanVien
            // 
            this.radioNhanVien.AutoSize = true;
            this.radioNhanVien.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNhanVien.Location = new System.Drawing.Point(368, 427);
            this.radioNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.radioNhanVien.Name = "radioNhanVien";
            this.radioNhanVien.Size = new System.Drawing.Size(182, 48);
            this.radioNhanVien.TabIndex = 45;
            this.radioNhanVien.TabStop = true;
            this.radioNhanVien.Text = "Employee";
            this.radioNhanVien.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UTM Aptima", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(283, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 48);
            this.label3.TabIndex = 38;
            this.label3.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtUsername.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Navy;
            this.txtUsername.Location = new System.Drawing.Point(368, 221);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(325, 54);
            this.txtUsername.TabIndex = 39;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Navy;
            this.txtPassword.Location = new System.Drawing.Point(368, 355);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(325, 54);
            this.txtPassword.TabIndex = 40;
            // 
            // groupBoxThongtin
            // 
            this.groupBoxThongtin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxThongtin.Controls.Add(this.label4);
            this.groupBoxThongtin.Controls.Add(this.label1);
            this.groupBoxThongtin.Controls.Add(this.radioNVGiamSat);
            this.groupBoxThongtin.Controls.Add(this.radioAdmin);
            this.groupBoxThongtin.Controls.Add(this.radioMember);
            this.groupBoxThongtin.Controls.Add(this.label2);
            this.groupBoxThongtin.Controls.Add(this.radioNhanVien);
            this.groupBoxThongtin.Controls.Add(this.label3);
            this.groupBoxThongtin.Controls.Add(this.txtUsername);
            this.groupBoxThongtin.Controls.Add(this.txtPassword);
            this.groupBoxThongtin.Font = new System.Drawing.Font("UTM Aquarelle", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxThongtin.ForeColor = System.Drawing.Color.White;
            this.groupBoxThongtin.Location = new System.Drawing.Point(84, 48);
            this.groupBoxThongtin.Name = "groupBoxThongtin";
            this.groupBoxThongtin.Size = new System.Drawing.Size(874, 692);
            this.groupBoxThongtin.TabIndex = 49;
            this.groupBoxThongtin.TabStop = false;
            this.groupBoxThongtin.Text = "Welcome";
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("UTM Aquarelle", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(710, 611);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 34);
            this.label4.TabIndex = 50;
            this.label4.Text = "Lê Hồng Danh";
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Aquarelle", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(646, 645);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 34);
            this.label1.TabIndex = 49;
            this.label1.Text = "Nguyễn Lê Nguyên Anh";
            // 
            // radioNVGiamSat
            // 
            this.radioNVGiamSat.AutoSize = true;
            this.radioNVGiamSat.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNVGiamSat.Location = new System.Drawing.Point(582, 493);
            this.radioNVGiamSat.Margin = new System.Windows.Forms.Padding(2);
            this.radioNVGiamSat.Name = "radioNVGiamSat";
            this.radioNVGiamSat.Size = new System.Drawing.Size(79, 48);
            this.radioNVGiamSat.TabIndex = 48;
            this.radioNVGiamSat.TabStop = true;
            this.radioNVGiamSat.Text = "PT";
            this.radioNVGiamSat.UseVisualStyleBackColor = true;
            // 
            // LoginUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.groupBoxThongtin);
            this.Name = "LoginUC";
            this.Size = new System.Drawing.Size(1080, 800);
            this.groupBoxThongtin.ResumeLayout(false);
            this.groupBoxThongtin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RadioButton radioAdmin;
        public System.Windows.Forms.RadioButton radioMember;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.RadioButton radioNhanVien;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtUsername;
        public System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.GroupBox groupBoxThongtin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.RadioButton radioNVGiamSat;
    }
}
