﻿using slnGym.Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnGym.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.txtUsername.Text.ToString());
        }
        private void LoginUC_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
        LOGIN login = new LOGIN();

        private void btSignIn_Click(object sender, EventArgs e)
        {
            string uname = null;
            AccountBL act = new AccountBL();
            if (act.checkPhone(txtUsername.Text) != null)
            {
                uname = act.checkPhone(txtUsername.Text).ToString();
                GLOBAL.GetUsername(uname);
            }
            else
            {
                GLOBAL.GetUsername(txtUsername.Text);
            }
            if (LoginCheck() == true)
                switch (DefineAccount())
                {
                    case 0:
                        reLoadUserPassword();
                        this.Close();
                        break;
                    case 1:
                        reLoadUserPassword();
                        this.Close();
                        break;
                    case 2:
                        reLoadUserPassword();
                        this.Close();
                        break;
                    case 3:
                        reLoadUserPassword();
                        this.Close();
                        break;
                }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Nhan dien nguoi dang nhap la Nhan Vien hay Member
        int DefineAccount()
        {
            DataTable dt = new DataTable();
            dt = login.getUserID(GLOBAL.username);
            int id = Convert.ToInt32(dt.Rows[0][0].ToString());
            return id;
        }

        //Xac nhan Account
        bool LoginCheck()
        {
            DataTable dt = new DataTable();
            dt = login.getAccount(GLOBAL.username, txtPassword.Text);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        void reLoadUserPassword()
        {
            txtPassword.Text = "";
            txtUsername.Text = "";
        }
    }
}