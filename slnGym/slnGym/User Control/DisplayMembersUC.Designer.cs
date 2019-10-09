namespace slnGym.User_Control
{
    partial class DisplayMembersUC
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
            this.panelMembers = new System.Windows.Forms.Panel();
            this.btReceipt = new System.Windows.Forms.Button();
            this.btContract = new System.Windows.Forms.Button();
            this.btAccount = new System.Windows.Forms.Button();
            this.panelClick = new System.Windows.Forms.Panel();
            this.btHome = new System.Windows.Forms.Button();
            this.homeUCMember = new slnGym.HomeUC();
            this.btNew = new System.Windows.Forms.Button();
            this.accountMemberUC = new slnGym.User_Control.AccountMemberUC();
            this.panelMembers.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMembers
            // 
            this.panelMembers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMembers.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelMembers.Controls.Add(this.btReceipt);
            this.panelMembers.Controls.Add(this.btContract);
            this.panelMembers.Controls.Add(this.btNew);
            this.panelMembers.Controls.Add(this.btAccount);
            this.panelMembers.Controls.Add(this.panelClick);
            this.panelMembers.Controls.Add(this.btHome);
            this.panelMembers.Location = new System.Drawing.Point(1560, 3);
            this.panelMembers.Name = "panelMembers";
            this.panelMembers.Size = new System.Drawing.Size(357, 1011);
            this.panelMembers.TabIndex = 15;
            // 
            // btReceipt
            // 
            this.btReceipt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btReceipt.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReceipt.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReceipt.ForeColor = System.Drawing.Color.Transparent;
            this.btReceipt.Location = new System.Drawing.Point(4, 428);
            this.btReceipt.Name = "btReceipt";
            this.btReceipt.Size = new System.Drawing.Size(350, 100);
            this.btReceipt.TabIndex = 8;
            this.btReceipt.Text = "Receipts";
            this.btReceipt.UseVisualStyleBackColor = true;
            // 
            // btContract
            // 
            this.btContract.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btContract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btContract.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btContract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btContract.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btContract.ForeColor = System.Drawing.Color.Transparent;
            this.btContract.Location = new System.Drawing.Point(4, 322);
            this.btContract.Name = "btContract";
            this.btContract.Size = new System.Drawing.Size(350, 100);
            this.btContract.TabIndex = 7;
            this.btContract.Text = "Contracts";
            this.btContract.UseVisualStyleBackColor = true;
            // 
            // btAccount
            // 
            this.btAccount.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAccount.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAccount.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAccount.ForeColor = System.Drawing.Color.Transparent;
            this.btAccount.Location = new System.Drawing.Point(3, 109);
            this.btAccount.Name = "btAccount";
            this.btAccount.Size = new System.Drawing.Size(350, 100);
            this.btAccount.TabIndex = 4;
            this.btAccount.Text = "Account";
            this.btAccount.UseVisualStyleBackColor = true;
            this.btAccount.Click += new System.EventHandler(this.btAccount_Click);
            // 
            // panelClick
            // 
            this.panelClick.BackColor = System.Drawing.Color.AliceBlue;
            this.panelClick.Location = new System.Drawing.Point(3, 3);
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
            this.btHome.Location = new System.Drawing.Point(3, 3);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(350, 100);
            this.btHome.TabIndex = 0;
            this.btHome.Text = "Home";
            this.btHome.UseVisualStyleBackColor = true;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // homeUCMember
            // 
            this.homeUCMember.AutoScroll = true;
            this.homeUCMember.BackColor = System.Drawing.Color.LightCoral;
            this.homeUCMember.Location = new System.Drawing.Point(2, 2);
            this.homeUCMember.Name = "homeUCMember";
            this.homeUCMember.Size = new System.Drawing.Size(1555, 1011);
            this.homeUCMember.TabIndex = 16;
            // 
            // btNew
            // 
            this.btNew.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNew.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNew.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNew.ForeColor = System.Drawing.Color.Transparent;
            this.btNew.Location = new System.Drawing.Point(4, 216);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(350, 100);
            this.btNew.TabIndex = 6;
            this.btNew.Text = "News";
            this.btNew.UseVisualStyleBackColor = true;
            // 
            // accountMemberUC
            // 
            this.accountMemberUC.BackColor = System.Drawing.Color.CornflowerBlue;
            this.accountMemberUC.Location = new System.Drawing.Point(2, 2);
            this.accountMemberUC.Name = "accountMemberUC";
            this.accountMemberUC.Size = new System.Drawing.Size(1555, 1011);
            this.accountMemberUC.TabIndex = 17;
            // 
            // DisplayMembersUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.accountMemberUC);
            this.Controls.Add(this.homeUCMember);
            this.Controls.Add(this.panelMembers);
            this.Name = "DisplayMembersUC";
            this.Size = new System.Drawing.Size(1920, 1017);
            this.Load += new System.EventHandler(this.DisplayMembersUC_Load);
            this.panelMembers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelMembers;
        private System.Windows.Forms.Button btReceipt;
        private System.Windows.Forms.Button btContract;
        private System.Windows.Forms.Button btAccount;
        private System.Windows.Forms.Panel panelClick;
        private System.Windows.Forms.Button btHome;
        private HomeUC homeUCMember;
        private System.Windows.Forms.Button btNew;
        private AccountMemberUC accountMemberUC;
    }
}
