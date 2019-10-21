namespace slnGym.User_Control
{
    partial class ListMachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListMachine));
            this.picMachine = new System.Windows.Forms.PictureBox();
            this.lbAmount = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lbName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMachine)).BeginInit();
            this.flowLayoutPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picMachine
            // 
            this.picMachine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picMachine.BackgroundImage")));
            this.picMachine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picMachine.Location = new System.Drawing.Point(9, 9);
            this.picMachine.Name = "picMachine";
            this.picMachine.Size = new System.Drawing.Size(246, 211);
            this.picMachine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMachine.TabIndex = 26;
            this.picMachine.TabStop = false;
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmount.ForeColor = System.Drawing.Color.Maroon;
            this.lbAmount.Location = new System.Drawing.Point(706, 23);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(129, 36);
            this.lbAmount.TabIndex = 90;
            this.lbAmount.Text = "(amount)";
            this.lbAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.ForeColor = System.Drawing.Color.Maroon;
            this.lbDescription.Location = new System.Drawing.Point(3, 0);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(162, 36);
            this.lbDescription.TabIndex = 91;
            this.lbDescription.Text = "Description";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flowLayoutPanel.Controls.Add(this.lbDescription);
            this.flowLayoutPanel.Location = new System.Drawing.Point(295, 77);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(540, 167);
            this.flowLayoutPanel.TabIndex = 92;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.Maroon;
            this.lbName.Location = new System.Drawing.Point(298, 23);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(89, 36);
            this.lbName.TabIndex = 93;
            this.lbName.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.picMachine);
            this.groupBox1.Location = new System.Drawing.Point(15, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 229);
            this.groupBox1.TabIndex = 94;
            this.groupBox1.TabStop = false;
            // 
            // ListMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListMachine";
            this.Size = new System.Drawing.Size(850, 257);
            this.Load += new System.EventHandler(this.ListMachine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMachine)).EndInit();
            this.flowLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMachine;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
