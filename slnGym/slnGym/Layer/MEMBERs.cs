using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
namespace slnGym.Layer
{
    class MEMBERs
    {
        MY_DB mydb = new MY_DB();
        //Them Khach Hang
        public bool insertMembers(string ID, string lname, string fname, DateTime bdate, string address,
            int gender, string phone, int idcard, string note)
        {
            SqlCommand cmd = new SqlCommand("insert into MEMBERS(memID,memLname,memFname,memBDate,memAddress,memGender,memPhone,cardID,note)" +
                "values (@id,@lname,@fname,@bdate,@add,@gen,@phone,@idcard,@note)", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = ID;
            cmd.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
            cmd.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            cmd.Parameters.Add("@bdate", SqlDbType.DateTime).Value = bdate;
            cmd.Parameters.Add("@add", SqlDbType.NVarChar).Value = address;
            cmd.Parameters.Add("@gen", SqlDbType.Int).Value = gender;
            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@idcard", SqlDbType.Int).Value = idcard;
            cmd.Parameters.Add("@note", SqlDbType.NVarChar).Value = note;

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
            cmd.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
            cmd.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            cmd.Parameters.Add("@bdate", SqlDbType.DateTime).Value = bdate;
            cmd.Parameters.Add("@add", SqlDbType.NVarChar).Value = address;
            cmd.Parameters.Add("@gen", SqlDbType.Int).Value = gender;
            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@idcard", SqlDbType.Int).Value = idcard;
            cmd.Parameters.Add("@note", SqlDbType.NVarChar).Value = note;

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
        public bool updateAccpuntMember(string ID, string note)
        {
            SqlCommand cmd = new SqlCommand("update MEMBERS set note=@note where memID=@id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = ID;
            cmd.Parameters.Add("@note", SqlDbType.NVarChar).Value = note;

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
            SqlCommand cmd = new SqlCommand("select memID as 'ID',memLname as 'FName',memFname as 'LName',memBDate as 'Birthday'," +
                "memAddress as 'Address',memGender as 'Female',memPhone as 'Phone',cardID as 'ID card',note as 'Status' from MEMBERS", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }

        public DataTable getMemberbyID(string id)
        {
            SqlCommand cmd = new SqlCommand("select *from MEMBERS where memID=@ma", mydb.getConnection);
            cmd.Parameters.Add("@ma", SqlDbType.VarChar).Value = id;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }

        public DataTable getMemberbyPhone(int phone)
        {
            SqlCommand cmd = new SqlCommand("select *from MEMBERS where memPhone=@ma", mydb.getConnection);
            cmd.Parameters.Add("@ma", SqlDbType.Int).Value = phone;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }
        //Sua doi thong tin cua khach hang duoc admin duyet m   
        public bool insertTemporary(string ID, string lname, string fname,MemoryStream ava, DateTime bdate, string address,
            int gender, string phone, int idcard, string note)
        {
            SqlCommand cmd = new SqlCommand("insert into TEMP(ID,FName,LName,avatar,BDate,Address,Gender,Phone,cardID,note)" +
                "values (@id,@fname,@lname,@ava,@bdate,@add,@gen,@phone,@idcard,@note)", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = ID;
            cmd.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
            cmd.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            cmd.Parameters.Add("@bdate", SqlDbType.DateTime).Value = bdate;
            cmd.Parameters.Add("@add", SqlDbType.NVarChar).Value = address;
            cmd.Parameters.Add("@ava", SqlDbType.Image).Value = ava.ToArray();
            cmd.Parameters.Add("@gen", SqlDbType.Int).Value = gender;
            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@idcard", SqlDbType.Int).Value = idcard;
            cmd.Parameters.Add("@note", SqlDbType.NVarChar).Value = note;

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

        public DataTable getTEMP()
        {
            SqlCommand cmd = new SqlCommand("select *from TEMP", mydb.getConnection);
     
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }
    }
}