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
            this.loginUC = new slnGym.LoginUC();
            this.btSignIn = new System.Windows.Forms.Button();
            this.btSignUp = new System.Windows.Forms.Button();
            this.displayAdminUC = new slnGym.User_Control.DisplayAdminUC();
            this.SuspendLayout();
            // 
            // loginUC
            // 
            this.loginUC.BackColor = System.Drawing.Color.CornflowerBlue;
<<<<<<< HEAD
            this.loginUC.Location = new System.Drawing.Point(409, 0);
            this.loginUC.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.loginUC.Name = "loginUC";
            this.loginUC.Size = new System.Drawing.Size(1457, 1003);
=======
            this.loginUC.Location = new System.Drawing.Point(2, 3);
            this.loginUC.Margin = new System.Windows.Forms.Padding(4);
            this.loginUC.Name = "loginUC";
            this.loginUC.Size = new System.Drawing.Size(1920, 1017);
>>>>>>> 7250eb92071bf6bb02f102b682cb2ca3717cf541
            this.loginUC.TabIndex = 1;
            // 
            // btSignIn
            // 
            this.btSignIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSignIn.BackgroundImage")));
            this.btSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSignIn.Font = new System.Drawing.Font("Sitka Subheading", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSignIn.ForeColor = System.Drawing.Color.White;
<<<<<<< HEAD
            this.btSignIn.Location = new System.Drawing.Point(1720, 314);
            this.btSignIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
=======
            this.btSignIn.Location = new System.Drawing.Point(944, 265);
>>>>>>> 7250eb92071bf6bb02f102b682cb2ca3717cf541
            this.btSignIn.Name = "btSignIn";
            this.btSignIn.Size = new System.Drawing.Size(332, 119);
            this.btSignIn.TabIndex = 11;
            this.btSignIn.Text = "Sign in";
            this.btSignIn.UseVisualStyleBackColor = true;
            this.btSignIn.Click += new System.EventHandler(this.btSignIn_Click);
            // 
            // btSignUp
            // 
            this.btSignUp.BackColor = System.Drawing.Color.Transparent;
            this.btSignUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSignUp.BackgroundImage")));
            this.btSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSignUp.Font = new System.Drawing.Font("Sitka Subheading", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSignUp.ForeColor = System.Drawing.Color.White;
<<<<<<< HEAD
            this.btSignUp.Location = new System.Drawing.Point(1720, 481);
            this.btSignUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
=======
            this.btSignUp.Location = new System.Drawing.Point(944, 401);
>>>>>>> 7250eb92071bf6bb02f102b682cb2ca3717cf541
            this.btSignUp.Name = "btSignUp";
            this.btSignUp.Size = new System.Drawing.Size(332, 119);
            this.btSignUp.TabIndex = 12;
            this.btSignUp.Text = "Sign up";
            this.btSignUp.UseVisualStyleBackColor = false;
<<<<<<< HEAD
            this.btSignUp.Click += new System.EventHandler(this.BtSignUp_Click);
=======
            this.btSignUp.Click += new System.EventHandler(this.btSignUp_Click);
>>>>>>> 7250eb92071bf6bb02f102b682cb2ca3717cf541
            // 
            // displayAdminUC
            // 
<<<<<<< HEAD
            this.panelView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelView.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelView.Controls.Add(this.btLogin);
            this.panelView.Controls.Add(this.panelClick);
            this.panelView.Controls.Add(this.btHome);
            this.panelView.Location = new System.Drawing.Point(0, 0);
            this.panelView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(400, 1108);
            this.panelView.TabIndex = 13;
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLogin.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.ForeColor = System.Drawing.Color.Transparent;
            this.btLogin.Location = new System.Drawing.Point(4, 134);
            this.btLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(467, 123);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // panelClick
            // 
            this.panelClick.BackColor = System.Drawing.Color.AliceBlue;
            this.panelClick.Location = new System.Drawing.Point(4, 4);
            this.panelClick.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelClick.Name = "panelClick";
            this.panelClick.Size = new System.Drawing.Size(31, 123);
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
            this.btHome.Location = new System.Drawing.Point(4, 4);
            this.btHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(467, 123);
            this.btHome.TabIndex = 0;
            this.btHome.Text = "Home";
            this.btHome.UseVisualStyleBackColor = true;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // homeUC
            // 
            this.homeUC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homeUC.BackColor = System.Drawing.Color.LightCoral;
            this.homeUC.Location = new System.Drawing.Point(408, 0);
            this.homeUC.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.homeUC.Name = "homeUC";
            this.homeUC.Size = new System.Drawing.Size(2024, 1002);
            this.homeUC.TabIndex = 14;
=======
            this.displayAdminUC.BackColor = System.Drawing.Color.DarkGray;
            this.displayAdminUC.Location = new System.Drawing.Point(2, 3);
            this.displayAdminUC.Name = "displayAdminUC";
            this.displayAdminUC.Size = new System.Drawing.Size(1920, 1017);
            this.displayAdminUC.TabIndex = 13;
>>>>>>> 7250eb92071bf6bb02f102b682cb2ca3717cf541
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1924, 1004);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.btSignIn);
            this.Controls.Add(this.btSignUp);
            this.Controls.Add(this.loginUC);
            this.Controls.Add(this.homeUC);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
=======
            this.ClientSize = new System.Drawing.Size(1443, 816);
            this.Controls.Add(this.btSignIn);
            this.Controls.Add(this.btSignUp);
            this.Controls.Add(this.loginUC);
            this.Controls.Add(this.displayAdminUC);
>>>>>>> 7250eb92071bf6bb02f102b682cb2ca3717cf541
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private LoginUC loginUC;
        private System.Windows.Forms.Button btSignIn;
        private System.Windows.Forms.Button btSignUp;
        private User_Control.DisplayAdminUC displayAdminUC;
    }
}

