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
        public bool insertLogin(string user, string pass, string type)
        {
            SqlCommand cmd = new SqlCommand("insert into ACCOUNT(username,passw,userID)" +
                "values (@user,@pass,@type)", mydb.getConnection);
            cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = user;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;
            cmd.Parameters.Add("@type", SqlDbType.Int).Value = type;
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
            SqlCommand cmd = new SqlCommand("update ACCOUNT set passw=@pass where username=@user", mydb.getConnection);
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
        public bool usernameExist(string user)
        {
            SqlCommand cmd = new SqlCommand("select * from LOGIN where username =@user", mydb.getConnection);

            cmd.Parameters.Add("@user", SqlDbType.NChar).Value = user;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public bool deleteAccount(string ID)
        {
            SqlCommand cmd = new SqlCommand("delete from ACCOUNT where username=@id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = ID;
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

        public DataTable getAccUserID(string user)
        {
            SqlCommand cmd = new SqlCommand("select * from ACCOUNT where userID=@user", mydb.getConnection);
            cmd.Parameters.Add("@user", SqlDbType.NChar).Value = user;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getUserID(string user)
        {
            SqlCommand cmd = new SqlCommand("select userID from ACCOUNT where username=@user", mydb.getConnection);
            cmd.Parameters.Add("@user", SqlDbType.NChar).Value = user;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getAccount(string user, string pass)
        {
            SqlCommand cmd = new SqlCommand("select *from ACCOUNT where username=@user and passw=@pass", mydb.getConnection);
            cmd.Parameters.Add("@user", SqlDbType.NChar).Value = user;
            cmd.Parameters.Add("@pass", SqlDbType.NChar).Value = pass;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getAccountbyUser(string user)
        {
            SqlCommand cmd = new SqlCommand("select *from ACCOUNT where username=@user", mydb.getConnection);
            cmd.Parameters.Add("@user", SqlDbType.NChar).Value = user;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}