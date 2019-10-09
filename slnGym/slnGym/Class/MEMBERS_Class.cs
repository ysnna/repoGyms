using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace slnGym.Class
{
    class MEMBERS_Class
    {
        MY_DBClass mydb = new MY_DBClass();
        //Them Khach Hang
        public bool insertMembers(string ID, string lname, string fname, DateTime bdate,string address,
            int gender,string phone, int idcard,string note)
        {
            SqlCommand cmd = new SqlCommand("insert into MEMBERS(memID,memLname,memFname,memBDate,memAddress,memGender,memPhone,cardID,note)" +
                "values (@id,@lname,@fname,@bdate,@add,@gen,@phone,@idcard,@note)", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = ID;
            cmd.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
            cmd.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
            cmd.Parameters.Add("@bdate", SqlDbType.DateTime).Value = bdate;
            cmd.Parameters.Add("@add", SqlDbType.VarChar).Value = address;
            cmd.Parameters.Add("@gen", SqlDbType.Int).Value = gender;
            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@idcard", SqlDbType.Int).Value = idcard;
            cmd.Parameters.Add("@note", SqlDbType.VarChar).Value = note;

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

        //Xoa khach hang
        public bool deleteMembers(string memID)
        {
            SqlCommand cmd = new SqlCommand("delete from MEMBERS where memID=@id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = memID;
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
        //Update khach hang
        public bool updateMembers(string ID, string lname, string fname, DateTime bdate, string address,
            int gender, string phone, int idcard, string note)
        {
            SqlCommand cmd = new SqlCommand("update MEMBERS set memID=@id,memLname=@lname,memFname=@fname,memBDate=@bdate,memAddress=@add," +
                "memGender=@gen,memPhone=@phone,cardID=@idcard,note=@note", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = ID;
            cmd.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
            cmd.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
            cmd.Parameters.Add("@bdate", SqlDbType.DateTime).Value = bdate;
            cmd.Parameters.Add("@add", SqlDbType.VarChar).Value = address;
            cmd.Parameters.Add("@gen", SqlDbType.Int).Value = gender;
            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@idcard", SqlDbType.Int).Value = idcard;
            cmd.Parameters.Add("@note", SqlDbType.VarChar).Value = note;

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
        //Lay thong tin 
        public DataTable getAllMEMBERS()
        {
            SqlCommand cmd = new SqlCommand("select *from MEMBERS", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable getMemberbyID(string id)
        {
            SqlCommand cmd = new SqlCommand("select *from MEMBERS where memID=@ma", mydb.getConnection);
            cmd.Parameters.Add("@ma", SqlDbType.VarChar).Value = id;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable getMemberbyPhone(int phone)
        {
            SqlCommand cmd = new SqlCommand("select *from MEMBERS where memPhone=@ma", mydb.getConnection);
            cmd.Parameters.Add("@ma", SqlDbType.Int).Value = phone;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
