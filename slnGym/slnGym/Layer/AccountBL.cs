using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace slnGym.Layer
{
    public class AccountBL
    {
        EMPLOYEEs emp = new EMPLOYEEs();
        LOGIN lg = new LOGIN();
        User_Control.AccountEmployeeUC empUC = new User_Control.AccountEmployeeUC();
        MY_DB mydb = new MY_DB();
        public bool insertAccount(string username, string login, string logout, string status)
        {
            SqlCommand cmd = new SqlCommand("insert into ACCOUNTLOGIN(username,loginDate,logoutDate,status)" + "values(@user,@login,@logout,@status)", mydb.getConnection);
            cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
            cmd.Parameters.Add("@logout", SqlDbType.VarChar).Value = logout;
            cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = status;
            mydb.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }//update CLASSROOM set classID=@id
        public bool updateAccount(string username, string login, string logout, string status)
        {
            SqlCommand cmd = new SqlCommand("update ACCOUNTLOGIN set logoutDate=@logout,status=@status where username=@user and loginDate=@login", mydb.getConnection);
            cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
            cmd.Parameters.Add("@logout", SqlDbType.VarChar).Value = logout;
            cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = status;
            mydb.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        //Dang nhap = sdt
        public string checkPhone(string phone)
        {
            string empID = null;
            DataTable dt = new DataTable();
            dt = emp.getEmployeebyPhone(phone);
            if (dt.Rows.Count > 0)
            {
                empID = dt.Rows[0][0].ToString();
                return empID;
            }
            else return empID;
        }
        public DataTable getACCOUNTLog()
        {
            SqlCommand cmd = new SqlCommand("select ACCOUNTLOGIN.username as 'Username', ACCOUNT.passw as 'Password', " +
                "loginDate as 'Date Login', logoutDate as 'Date Logout', status as 'Status'" +
                "from ACCOUNT, ACCOUNTLOGIN where ACCOUNT.username = ACCOUNTLOGIN.username order by loginDate desc", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }
    }
}