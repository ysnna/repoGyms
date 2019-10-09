using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace slnGym.Class
{
    class WORKs
    {
        MY_DB mydb = new MY_DB();
        public bool insertWORK(string id, string name, int group, string groupid)
        {
            SqlCommand cmd = new SqlCommand("insert into WORK(workID,workName,workGroup,groupWorkID)" +
                "values (@id,@name,@work,@workgroup)", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@work", SqlDbType.NVarChar).Value = group;
            cmd.Parameters.Add("@workgroup", SqlDbType.NVarChar).Value = groupid;

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
        public bool updateWORK(string id, string name, int group, string groupid)
        {
            SqlCommand cmd = new SqlCommand("update WORK set workID=@id,workName=@name,workGroup=@cost,groupWorkID=@note", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@work", SqlDbType.NVarChar).Value = group;
            cmd.Parameters.Add("@workgroup", SqlDbType.NVarChar).Value = groupid;

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
        public DataTable getWORK()
        {
            SqlCommand cmd = new SqlCommand("select *from WORK", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getWORKbyID(string id)
        {
            SqlCommand cmd = new SqlCommand("select *from WORK where workID=@ID", mydb.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getWORKbyName(string name)
        {
            SqlCommand cmd = new SqlCommand("select *from WORK where workName=@ID", mydb.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = name;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}