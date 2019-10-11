using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using slnGym.Class;

namespace slnGym
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        LOGIN login = new LOGIN();
        LoginUC lg = new LoginUC();
        private void Form1_Load(object sender, EventArgs e)
        {
            displayAdminUC.Location = new Point(0, 0);
            displayEmployeesUC.Location = new Point(0, 0);
            displayMembersUC.Location = new Point(0, 0);
            displayPTsUC.Location = new Point(0, 0);
            loginUC.Location = new Point(0, 0);
            loginUC.BringToFront();
            btSignIn.BringToFront();
            btSignUp.BringToFront();
        }
       
        
        private void btSignIn_Click(object sender, EventArgs e)
        {
          
            GLOBAL.GetUsername(loginUC.txtUsername.Text);

            if(LoginCheck()==true)
                switch (DefineAccount()) {
                    case 0:
                        displayAdminUC.BringToFront();
                        break;
                    case 1:
                        displayEmployeesUC.BringToFront();
                        break;
                    case 2:
                        displayMembersUC.BringToFront();
                        break;
                }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);        
}
        
        }

        private void btSignUp_Click(object sender, EventArgs e)
        {
            
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
            dt = login.getAccount(GLOBAL.username, loginUC.txtPassword.Text);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        private void LoginUC_Load(object sender, EventArgs e)
        {

        }
    }
}