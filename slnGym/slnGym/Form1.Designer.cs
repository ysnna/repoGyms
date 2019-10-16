namespace slnGym
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btSignIn = new System.Windows.Forms.Button();
            this.loginUC = new slnGym.LoginUC();
            this.displayAdminUC = new slnGym.User_Control.DisplayAdminUC();
            this.displayMembersUC = new slnGym.User_Control.DisplayMembersUC();
            this.displayPTsUC = new slnGym.User_Control.DisplayPTsUC();
            this.displayEmployeesUC = new slnGym.User_Control.DisplayEmployeesUC();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.usernameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripKH = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.KHtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.menuStripKH.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSignIn
            // 
            this.btSignIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSignIn.BackgroundImage")));
            this.btSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSignIn.Font = new System.Drawing.Font("Sitka Subheading", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSignIn.ForeColor = System.Drawing.Color.White;
            this.btSignIn.Location = new System.Drawing.Point(944, 265);
            this.btSignIn.Name = "btSignIn";
            this.btSignIn.Size = new System.Drawing.Size(249, 97);
            this.btSignIn.TabIndex = 11;
            this.btSignIn.Text = "Sign in";
            this.btSignIn.UseVisualStyleBackColor = true;
            this.btSignIn.Click += new System.EventHandler(this.btSignIn_Click);
            // 
            // loginUC
            // 
            this.loginUC.BackColor = System.Drawing.Color.CornflowerBlue;
            this.loginUC.Location = new System.Drawing.Point(2, 3);
            this.loginUC.Margin = new System.Windows.Forms.Padding(4);
            this.loginUC.Name = "loginUC";
            this.loginUC.Size = new System.Drawing.Size(1920, 1017);
            this.loginUC.TabIndex = 1;
            this.loginUC.Load += new System.EventHandler(this.loginUC_Load);
            // 
            // displayAdminUC
            // 
            this.displayAdminUC.BackColor = System.Drawing.Color.DarkGray;
            this.displayAdminUC.Location = new System.Drawing.Point(2, 3);
            this.displayAdminUC.Margin = new System.Windows.Forms.Padding(4);
            this.displayAdminUC.Name = "displayAdminUC";
            this.displayAdminUC.Size = new System.Drawing.Size(1920, 1017);
            this.displayAdminUC.TabIndex = 13;
            // 
            // displayMembersUC
            // 
            this.displayMembersUC.BackColor = System.Drawing.Color.White;
            this.displayMembersUC.Location = new System.Drawing.Point(2, 3);
            this.displayMembersUC.Margin = new System.Windows.Forms.Padding(4);
            this.displayMembersUC.Name = "displayMembersUC";
            this.displayMembersUC.Size = new System.Drawing.Size(1920, 1017);
            this.displayMembersUC.TabIndex = 15;
            // 
            // displayPTsUC
            // 
            this.displayPTsUC.BackColor = System.Drawing.Color.CornflowerBlue;
            this.displayPTsUC.Location = new System.Drawing.Point(2, 3);
            this.displayPTsUC.Margin = new System.Windows.Forms.Padding(4);
            this.displayPTsUC.Name = "displayPTsUC";
            this.displayPTsUC.Size = new System.Drawing.Size(1920, 1017);
            this.displayPTsUC.TabIndex = 16;
            // 
            // displayEmployeesUC
            // 
            this.displayEmployeesUC.BackColor = System.Drawing.Color.Silver;
            this.displayEmployeesUC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("displayEmployeesUC.BackgroundImage")));
            this.displayEmployeesUC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.displayEmployeesUC.Location = new System.Drawing.Point(2, 3);
            this.displayEmployeesUC.Margin = new System.Windows.Forms.Padding(4);
            this.displayEmployeesUC.Name = "displayEmployeesUC";
            this.displayEmployeesUC.Size = new System.Drawing.Size(1920, 1017);
            this.displayEmployeesUC.TabIndex = 14;
            this.displayEmployeesUC.Load += new System.EventHandler(this.displayEmployeesUC_Load);
            // 
            // menuStrip
            // 
            this.menuStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.menuStrip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.menuStrip.BackColor = System.Drawing.Color.LemonChiffon;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usernameToolStripMenuItem});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStrip.Location = new System.Drawing.Point(-2, 792);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(34, 24);
            this.menuStrip.TabIndex = 17;
            this.menuStrip.Text = "menuStrip1";
            // 
            // usernameToolStripMenuItem
            // 
            this.usernameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.usernameToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.usernameToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usernameToolStripMenuItem.Image")));
            this.usernameToolStripMenuItem.Name = "usernameToolStripMenuItem";
            this.usernameToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            this.usernameToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.logOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logOutToolStripMenuItem.Image")));
            this.logOutToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Tab)));
            this.logOutToolStripMenuItem.ShowShortcutKeys = false;
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(180, 32);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // menuStripKH
            // 
            this.menuStripKH.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.menuStripKH.BackColor = System.Drawing.Color.LemonChiffon;
            this.menuStripKH.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripKH.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripKH.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStripKH.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStripKH.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStripKH.Location = new System.Drawing.Point(121, 752);
            this.menuStripKH.Name = "menuStripKH";
            this.menuStripKH.Size = new System.Drawing.Size(126, 43);
            this.menuStripKH.TabIndex = 18;
            this.menuStripKH.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KHtoolStripMenuItem});
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(28, 20);
            this.toolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // KHtoolStripMenuItem
            // 
            this.KHtoolStripMenuItem.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.KHtoolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("KHtoolStripMenuItem.Image")));
            this.KHtoolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.KHtoolStripMenuItem.Name = "KHtoolStripMenuItem";
            this.KHtoolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Tab)));
            this.KHtoolStripMenuItem.ShowShortcutKeys = false;
            this.KHtoolStripMenuItem.Size = new System.Drawing.Size(180, 32);
            this.KHtoolStripMenuItem.Text = "Log out";
            this.KHtoolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KHtoolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.KHtoolStripMenuItem.Click += new System.EventHandler(this.KHtoolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btSignIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1443, 816);
            this.Controls.Add(this.menuStripKH);
            this.Controls.Add(this.btSignIn);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.loginUC);
            this.Controls.Add(this.displayAdminUC);
            this.Controls.Add(this.displayMembersUC);
            this.Controls.Add(this.displayPTsUC);
            this.Controls.Add(this.displayEmployeesUC);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.menuStripKH.ResumeLayout(false);
            this.menuStripKH.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LoginUC loginUC;
        private System.Windows.Forms.Button btSignIn;
        private User_Control.DisplayAdminUC displayAdminUC;
        private User_Control.DisplayEmployeesUC displayEmployeesUC;
        private User_Control.DisplayMembersUC displayMembersUC;
        private User_Control.DisplayPTsUC displayPTsUC;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem usernameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripKH;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem KHtoolStripMenuItem;
    }
}

