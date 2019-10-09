using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace slnGym.Class
{
    class GROUPWORK
    {
        MY_DBClass mydb = new MY_DBClass();
        public bool insertGROUPWORK(string id, string name)
        {
            SqlCommand cmd = new SqlCommand("insert into GROUPWORK(groupWorkID,groupWorkName)" +
                "values (@id,@name)", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
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

        public bool deleteGROUPWORK(string ID)
        {
            SqlCommand cmd = new SqlCommand("delete from GROUPEMPWORK where groupWorkID=@id", mydb.getConnection);
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

        public bool updateGROUPEMP(string id, string name)
        {
            SqlCommand cmd = new SqlCommand("update GROUPEMPWORK set groupWorkID=@id,groupWorkName=@name", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            
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
        public DataTable getGROUPWork()
        {
            SqlCommand cmd = new SqlCommand("select *from GROUPWORK ", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable getGroupWorkbyID(string id)
        {
            SqlCommand cmd = new SqlCommand("select *from GROUPWORK where groupID=@ID", mydb.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getGroupWorkbyName(string name)
        {
            SqlCommand cmd = new SqlCommand("select *from GROUPWORK where groupWorkName=@ID", mydb.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = name;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
