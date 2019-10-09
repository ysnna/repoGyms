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
            this.btSignUp = new System.Windows.Forms.Button();
            this.displayPTsUC = new slnGym.User_Control.DisplayPTsUC();
            this.displayEmployeesUC = new slnGym.User_Control.DisplayEmployeesUC();
            this.loginUC = new slnGym.LoginUC();
            this.displayAdminUC = new slnGym.User_Control.DisplayAdminUC();
            this.displayMembersUC = new slnGym.User_Control.DisplayMembersUC();
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
            // btSignUp
            // 
            this.btSignUp.BackColor = System.Drawing.Color.Transparent;
            this.btSignUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSignUp.BackgroundImage")));
            this.btSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSignUp.Font = new System.Drawing.Font("Sitka Subheading", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSignUp.ForeColor = System.Drawing.Color.White;
            this.btSignUp.Location = new System.Drawing.Point(944, 401);
            this.btSignUp.Name = "btSignUp";
            this.btSignUp.Size = new System.Drawing.Size(249, 97);
            this.btSignUp.TabIndex = 12;
            this.btSignUp.Text = "Sign up";
            this.btSignUp.UseVisualStyleBackColor = false;
            this.btSignUp.Click += new System.EventHandler(this.btSignUp_Click);
            // 
            // displayPTsUC
            // 
            this.displayPTsUC.Location = new System.Drawing.Point(2, 3);
            this.displayPTsUC.Name = "displayPTsUC";
            this.displayPTsUC.Size = new System.Drawing.Size(1920, 1017);
            this.displayPTsUC.TabIndex = 16;
            // 
            // displayEmployeesUC
            // 
            this.displayEmployeesUC.Location = new System.Drawing.Point(2, 3);
            this.displayEmployeesUC.Name = "displayEmployeesUC";
            this.displayEmployeesUC.Size = new System.Drawing.Size(1920, 1017);
            this.displayEmployeesUC.TabIndex = 14;
            // 
            // loginUC
            // 
            this.loginUC.BackColor = System.Drawing.Color.CornflowerBlue;
            this.loginUC.Location = new System.Drawing.Point(2, 3);
            this.loginUC.Margin = new System.Windows.Forms.Padding(4);
            this.loginUC.Name = "loginUC";
            this.loginUC.Size = new System.Drawing.Size(1920, 1017);
            this.loginUC.TabIndex = 1;
            // 
            // displayAdminUC
            // 
            this.displayAdminUC.BackColor = System.Drawing.Color.DarkGray;
            this.displayAdminUC.Location = new System.Drawing.Point(2, 3);
            this.displayAdminUC.Name = "displayAdminUC";
            this.displayAdminUC.Size = new System.Drawing.Size(1920, 1017);
            this.displayAdminUC.TabIndex = 13;
            // 
            // displayMembersUC
            // 
            this.displayMembersUC.Location = new System.Drawing.Point(2, 3);
            this.displayMembersUC.Name = "displayMembersUC";
            this.displayMembersUC.Size = new System.Drawing.Size(1920, 1017);
            this.displayMembersUC.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1443, 816);
            this.Controls.Add(this.btSignIn);
            this.Controls.Add(this.btSignUp);
            this.Controls.Add(this.displayEmployeesUC);
            this.Controls.Add(this.loginUC);
            this.Controls.Add(this.displayAdminUC);
            this.Controls.Add(this.displayMembersUC);
            this.Controls.Add(this.displayPTsUC);
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
        private User_Control.DisplayEmployeesUC displayEmployeesUC;
        private User_Control.DisplayMembersUC displayMembersUC;
        private User_Control.DisplayPTsUC displayPTsUC;
    }
}

