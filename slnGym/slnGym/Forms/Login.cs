using slnGym.Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using slnGym.DataObject;

namespace slnGym.Forms
{
    public partial class Login : Form
    {
        Form1 f1 = new Form1();
        MY_DB mydb = new MY_DB();
        public Login(Form1 login)
        {
            InitializeComponent();
            f1 = login;
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

        private void btSignIn_Click(object sender, EventArgs e)
        {
            GLOBAL.username = txtUsername.Text;
            
            Log_in();
            f1.loginToolStripMenuItem.Visible = false;
            f1.logoutToolStripMenuItem.Visible = true;
        }
        public void Log_in()
        {
            if (LoginCheck() == true)
            {
                SysLOG.DateLogin = DateTime.Now.ToString();
                SysLOG.UserName = GLOBAL.username;
                SysLOG.Online = true;
                switch (DefineAccount())
                {
                    case 0:
                        reLoadUserPassword();
                        f1.managerToolStripMenuItem.Enabled = true;
                        this.Close();
                        break;
                    case 1:
                        
                        reLoadUserPassword();
                        f1.managerToolStripMenuItem.Enabled = false;
                        this.Close();
                        break;
                    case 2:
                        reLoadUserPassword();
                        f1.managerToolStripMenuItem.Enabled = false;
                        this.Close();
                        break;
                    case 3:
                        reLoadUserPassword();
                        f1.managerToolStripMenuItem.Enabled = false;
                        this.Close();
                        break;
                    case 5:
                        MessageBox.Show("Not approve");
                        return;
                }
                ///
                ///insert account
                ///
                f1.AccessSuccess();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Nhan dien nguoi dang nhap la Nhan Vien hay Member
        int DefineAccount()
        {
            string sql = @"select * from functGetAccountID('"+GLOBAL.username+"')";
            DataTable dt = new DataTable();
            dt = mydb.createTable(sql);
            int id = Convert.ToInt32(dt.Rows[0][0].ToString());
            return id;
        }

        //Xac nhan Account
        bool LoginCheck()
        {
            string sql = @"EXEC sp_proLOADAccount";
            DataTable dt = mydb.createTable(sql);            
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