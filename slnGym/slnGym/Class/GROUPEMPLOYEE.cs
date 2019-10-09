using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace slnGym.Class
{
    class GROUPEMPLOYEE
    {
        MY_DBClass mydb = new MY_DBClass();
        public bool insertGROUPEMP(string id,string name,string lname, string fname)
        {
            SqlCommand cmd = new SqlCommand("insert into GROUPEMPLOYEE(groupID,groupName,leaderFName,leaderLName)" +
                "values (@id,@name,@fname,@lname)", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            cmd.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
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

        public bool deleteGROUPEMP(string ID)
        {
            SqlCommand cmd = new SqlCommand("delete from GROUPEMPLOYEE where groupID=@id", mydb.getConnection);
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

        public bool updateGROUPEMP(string id, string name, string lname, string fname)
        {
            SqlCommand cmd = new SqlCommand("update GROUPEMPLOYEE set groupID=@id,groupName=@name,leaderFName = @fname,leaderLName=@lname", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            cmd.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;

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
        public DataTable getGROUPEMP()
        {
            SqlCommand cmd = new SqlCommand("select *from GROUPEMPLOYEE ", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable getGroupEmpbyID(string id)
        {
            SqlCommand cmd = new SqlCommand("select *from GROUPEMPLOYEE where groupID=@ID", mydb.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getGroupEmpbyName(string name)
        {
            SqlCommand cmd = new SqlCommand("select *from GROUPEMPLOYEE where groupName=@ID", mydb.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = name;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
