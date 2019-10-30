﻿namespace slnGym.User_Control
{
    partial class ManageAccountUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageAccountUC));
            this.listPackage = new System.Windows.Forms.ListView();
            this.colUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label49 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.colPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLoginDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLogoutDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGroup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btSearch = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDSeller = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // listPackage
            // 
            this.listPackage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listPackage.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listPackage.BackgroundImageTiled = true;
            this.listPackage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colUsername,
            this.colPassword,
            this.colLoginDate,
            this.colLogoutDate,
            this.colGroup});
            this.listPackage.Font = new System.Drawing.Font("UTM Aptima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPackage.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listPackage.FullRowSelect = true;
            this.listPackage.GridLines = true;
            this.listPackage.HideSelection = false;
            this.listPackage.Location = new System.Drawing.Point(6, 74);
            this.listPackage.Name = "listPackage";
            this.listPackage.Size = new System.Drawing.Size(1332, 701);
            this.listPackage.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listPackage.TabIndex = 3;
            this.listPackage.UseCompatibleStateImageBehavior = false;
            this.listPackage.View = System.Windows.Forms.View.Details;
            // 
            // colUsername
            // 
            this.colUsername.Text = "Username";
            this.colUsername.Width = 220;
            // 
            // groupBox9
            // 
            this.groupBox9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox9.Controls.Add(this.textBox1);
            this.groupBox9.Controls.Add(this.label2);
            this.groupBox9.Controls.Add(this.txtIDSeller);
            this.groupBox9.Controls.Add(this.label1);
            this.groupBox9.Controls.Add(this.button1);
            this.groupBox9.Controls.Add(this.btSearch);
            this.groupBox9.Controls.Add(this.txtSearch);
            this.groupBox9.Controls.Add(this.btDelete);
            this.groupBox9.Controls.Add(this.btEdit);
            this.groupBox9.Controls.Add(this.label49);
            this.groupBox9.Controls.Add(this.listPackage);
            this.groupBox9.Controls.Add(this.label54);
            this.groupBox9.Controls.Add(this.label55);
            this.groupBox9.Font = new System.Drawing.Font("Sitka Display", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.ForeColor = System.Drawing.Color.DarkGreen;
            this.groupBox9.Location = new System.Drawing.Point(37, 3);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(1344, 782);
            this.groupBox9.TabIndex = 205;
            this.groupBox9.TabStop = false;
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
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Transparent;
            this.btDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btDelete.BackgroundImage")));
            this.btDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelete.Font = new System.Drawing.Font("Sitka Subheading", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.ForeColor = System.Drawing.Color.White;
            this.btDelete.Location = new System.Drawing.Point(463, 25);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(51, 45);
            this.btDelete.TabIndex = 189;
            this.btDelete.UseVisualStyleBackColor = false;
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.Color.Transparent;
            this.btEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btEdit.BackgroundImage")));
            this.btEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEdit.Font = new System.Drawing.Font("Sitka Subheading", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.ForeColor = System.Drawing.Color.White;
            this.btEdit.Location = new System.Drawing.Point(403, 25);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(54, 45);
            this.btEdit.TabIndex = 188;
            this.btEdit.UseVisualStyleBackColor = false;
            // 
            // colPassword
            // 
            this.colPassword.Text = "Password";
            this.colPassword.Width = 230;
            // 
            // colLoginDate
            // 
            this.colLoginDate.Text = "Login date";
            this.colLoginDate.Width = 316;
            // 
            // colLogoutDate
            // 
            this.colLogoutDate.Text = "Logout date";
            this.colLogoutDate.Width = 305;
            // 
            // colGroup
            // 
            this.colGroup.Text = "Group";
            this.colGroup.Width = 253;
            // 
            // btSearch
            // 
            this.btSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSearch.BackColor = System.Drawing.Color.MintCream;
            this.btSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSearch.BackgroundImage")));
            this.btSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSearch.Location = new System.Drawing.Point(297, 27);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(40, 40);
            this.btSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btSearch.TabIndex = 193;
            this.btSearch.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.MintCream;
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtSearch.Location = new System.Drawing.Point(6, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '*';
            this.txtSearch.Size = new System.Drawing.Size(334, 44);
            this.txtSearch.TabIndex = 194;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Sitka Subheading", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(343, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 45);
            this.button1.TabIndex = 195;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(652, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 31);
            this.label1.TabIndex = 196;
            this.label1.Text = "Number of logins";
            // 
            // txtIDSeller
            // 
            this.txtIDSeller.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtIDSeller.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDSeller.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtIDSeller.Location = new System.Drawing.Point(858, 28);
            this.txtIDSeller.Name = "txtIDSeller";
            this.txtIDSeller.ReadOnly = true;
            this.txtIDSeller.Size = new System.Drawing.Size(84, 39);
            this.txtIDSeller.TabIndex = 197;
            this.txtIDSeller.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(994, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 31);
            this.label2.TabIndex = 198;
            this.label2.Text = "User";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.ForestGreen;
            this.textBox1.Location = new System.Drawing.Point(1064, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(274, 39);
            this.textBox1.TabIndex = 199;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ManageAccountUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.groupBox9);
            this.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "ManageAccountUC";
            this.Size = new System.Drawing.Size(1414, 798);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView listPackage;
        private System.Windows.Forms.ColumnHeader colUsername;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.ColumnHeader colPassword;
        private System.Windows.Forms.ColumnHeader colLoginDate;
        private System.Windows.Forms.ColumnHeader colLogoutDate;
        private System.Windows.Forms.ColumnHeader colGroup;
        private System.Windows.Forms.PictureBox btSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDSeller;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}