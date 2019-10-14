namespace slnGym.User_Control
{
    partial class DisplayAdminUC
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
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btStatistic = new System.Windows.Forms.Button();
            this.btReceipt = new System.Windows.Forms.Button();
            this.btContract = new System.Windows.Forms.Button();
            this.btMember = new System.Windows.Forms.Button();
            this.btEmployee = new System.Windows.Forms.Button();
            this.btNewMember = new System.Windows.Forms.Button();
            this.panelClick = new System.Windows.Forms.Panel();
            this.btHome = new System.Windows.Forms.Button();
            this.homeUCAdmin = new slnGym.HomeUC();
            this.panelAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAdmin
            // 
            this.panelAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelAdmin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelAdmin.Controls.Add(this.label1);
            this.panelAdmin.Controls.Add(this.btStatistic);
            this.panelAdmin.Controls.Add(this.btReceipt);
            this.panelAdmin.Controls.Add(this.btContract);
            this.panelAdmin.Controls.Add(this.btMember);
            this.panelAdmin.Controls.Add(this.btEmployee);
            this.panelAdmin.Controls.Add(this.btNewMember);
            this.panelAdmin.Controls.Add(this.panelClick);
            this.panelAdmin.Controls.Add(this.btHome);
            this.panelAdmin.Location = new System.Drawing.Point(3, 3);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(357, 1011);
            this.panelAdmin.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(114, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Using as Administrator";
            // 
            // btStatistic
            // 
            this.btStatistic.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btStatistic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btStatistic.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStatistic.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStatistic.ForeColor = System.Drawing.Color.Transparent;
            this.btStatistic.Location = new System.Drawing.Point(3, 743);
            this.btStatistic.Name = "btStatistic";
            this.btStatistic.Size = new System.Drawing.Size(350, 100);
            this.btStatistic.TabIndex = 9;
            this.btStatistic.Text = "          Statistics";
            this.btStatistic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btStatistic.UseVisualStyleBackColor = true;
            this.btStatistic.Click += new System.EventHandler(this.btStatistic_Click);
            // 
            // btReceipt
            // 
            this.btReceipt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btReceipt.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReceipt.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReceipt.ForeColor = System.Drawing.Color.Transparent;
            this.btReceipt.Location = new System.Drawing.Point(3, 637);
            this.btReceipt.Name = "btReceipt";
            this.btReceipt.Size = new System.Drawing.Size(350, 100);
            this.btReceipt.TabIndex = 8;
            this.btReceipt.Text = "          Receipts";
            this.btReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btReceipt.UseVisualStyleBackColor = true;
            this.btReceipt.Click += new System.EventHandler(this.btReceipt_Click);
            // 
            // btContract
            // 
            this.btContract.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btContract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btContract.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btContract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btContract.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btContract.ForeColor = System.Drawing.Color.Transparent;
            this.btContract.Location = new System.Drawing.Point(3, 531);
            this.btContract.Name = "btContract";
            this.btContract.Size = new System.Drawing.Size(350, 100);
            this.btContract.TabIndex = 7;
            this.btContract.Text = "          Contracts";
            this.btContract.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btContract.UseVisualStyleBackColor = true;
            this.btContract.Click += new System.EventHandler(this.btContract_Click);
            // 
            // btMember
            // 
            this.btMember.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMember.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMember.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMember.ForeColor = System.Drawing.Color.Transparent;
            this.btMember.Location = new System.Drawing.Point(3, 425);
            this.btMember.Name = "btMember";
            this.btMember.Size = new System.Drawing.Size(350, 100);
            this.btMember.TabIndex = 6;
            this.btMember.Text = "          Members";
            this.btMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMember.UseVisualStyleBackColor = true;
            this.btMember.Click += new System.EventHandler(this.btMember_Click);
            // 
            // btEmployee
            // 
            this.btEmployee.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEmployee.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEmployee.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmployee.ForeColor = System.Drawing.Color.Transparent;
            this.btEmployee.Location = new System.Drawing.Point(3, 319);
            this.btEmployee.Name = "btEmployee";
            this.btEmployee.Size = new System.Drawing.Size(350, 100);
            this.btEmployee.TabIndex = 5;
            this.btEmployee.Text = "          Employees";
            this.btEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEmployee.UseVisualStyleBackColor = true;
            this.btEmployee.Click += new System.EventHandler(this.btEmployee_Click);
            // 
            // btNewMember
            // 
            this.btNewMember.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btNewMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNewMember.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btNewMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNewMember.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNewMember.ForeColor = System.Drawing.Color.Transparent;
            this.btNewMember.Location = new System.Drawing.Point(3, 213);
            this.btNewMember.Name = "btNewMember";
            this.btNewMember.Size = new System.Drawing.Size(350, 100);
            this.btNewMember.TabIndex = 4;
            this.btNewMember.Text = "          New Member";
            this.btNewMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNewMember.UseVisualStyleBackColor = true;
            this.btNewMember.Click += new System.EventHandler(this.btNewMember_Click);
            // 
            // panelClick
            // 
            this.panelClick.BackColor = System.Drawing.Color.AliceBlue;
            this.panelClick.Location = new System.Drawing.Point(3, 107);
            this.panelClick.Name = "panelClick";
            this.panelClick.Size = new System.Drawing.Size(23, 100);
            this.panelClick.TabIndex = 1;
            // 
            // btHome
            // 
            this.btHome.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHome.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHome.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHome.ForeColor = System.Drawing.Color.Transparent;
            this.btHome.Location = new System.Drawing.Point(3, 107);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(350, 100);
            this.btHome.TabIndex = 0;
            this.btHome.Text = "          Home";
            this.btHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHome.UseVisualStyleBackColor = true;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // homeUCAdmin
            // 
            this.homeUCAdmin.AutoScroll = true;
            this.homeUCAdmin.BackColor = System.Drawing.Color.LightCoral;
            this.homeUCAdmin.Location = new System.Drawing.Point(365, 3);
            this.homeUCAdmin.Name = "homeUCAdmin";
            this.homeUCAdmin.Size = new System.Drawing.Size(1555, 1011);
            this.homeUCAdmin.TabIndex = 15;
            // 
            // DisplayAdminUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.homeUCAdmin);
            this.Controls.Add(this.panelAdmin);
            this.Name = "DisplayAdminUC";
            this.Size = new System.Drawing.Size(1920, 1017);
            this.Load += new System.EventHandler(this.DisplayAdminUC_Load);
            this.panelAdmin.ResumeLayout(false);
            this.panelAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Button btStatistic;
        private System.Windows.Forms.Button btReceipt;
        private System.Windows.Forms.Button btContract;
        private System.Windows.Forms.Button btMember;
        private System.Windows.Forms.Button btEmployee;
        private System.Windows.Forms.Button btNewMember;
        private System.Windows.Forms.Panel panelClick;
        private System.Windows.Forms.Button btHome;
        private HomeUC homeUCAdmin;
        private System.Windows.Forms.Label label1;
    }
}
