using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace slnGym.Layer
{
    public class LOGIN
    {
        MY_DB mydb = new MY_DB();
        //Dang ky tai khoan
        public bool insertLogin(string user, string pass, string type, string state)
        {
            SqlCommand cmd = new SqlCommand("insert into tblACCOUNT(username,passw,userID,state)" +
                "values (@user,@pass,@type,@state)", mydb.getConnection);
            cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = user;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;
            cmd.Parameters.Add("@type", SqlDbType.Int).Value = type;
            cmd.Parameters.Add("@state", SqlDbType.VarChar).Value = state;
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
        public bool updatePass(string user, string passw)
        {
            SqlCommand cmd = new SqlCommand("update tblACCOUNT set passw=@pass where username=@user", mydb.getConnection);
            cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = user;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = passw;


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
        public bool updateAccount(string user, int userid, string state)
        {
            SqlCommand cmd = new SqlCommand("update tblACCOUNT set userID=@uID, state=@state where username=@user", mydb.getConnection);
            cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = user;
            cmd.Parameters.Add("@uID", SqlDbType.Int).Value = userid;
            cmd.Parameters.Add("@state", SqlDbType.VarChar).Value = state;

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
     
    
        public DataTable getListAccount()
        {
            SqlCommand cmd = new SqlCommand("select username as 'Username', passw as 'Password', state as 'State' from tblACCOUNT", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }

        public DataTable getUserID(string user)
        {
            SqlCommand cmd = new SqlCommand("select userID from tblACCOUNT where username=@user", mydb.getConnection);
            cmd.Parameters.Add("@user", SqlDbType.NVarChar).Value = user;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }
        public DataTable getAccount(string user, string pass)
        {
            SqlCommand cmd = new SqlCommand("select *from tblACCOUNT where username=@user and passw=@pass", mydb.getConnection);
            cmd.Parameters.Add("@user", SqlDbType.NChar).Value = user;
            cmd.Parameters.Add("@pass", SqlDbType.NChar).Value = pass;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }
        public DataTable getAccountbyUser(string user)
        {
            SqlCommand cmd = new SqlCommand("select *from tblACCOUNT where username=@user", mydb.getConnection);
            cmd.Parameters.Add("@user", SqlDbType.NVarChar).Value = user;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }
    }
}