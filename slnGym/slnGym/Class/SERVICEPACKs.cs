using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace slnGym.Class
{
    class SERVICEPACKs
    {
        MY_DB mydb = new MY_DB();
        public bool insertSERVICE(string id, string name, int cost, string note)
        {
            SqlCommand cmd = new SqlCommand("insert into SERVICEPACK(serviceID,serviceNAME,cost,note)" +
                "values (@id,@name,@cost,@note)", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@cost", SqlDbType.Int).Value = cost;
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
        public bool deleteSERVICE(string ID)
        {
            SqlCommand cmd = new SqlCommand("delete from SERVICEPACK where serviceID=@id", mydb.getConnection);
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
        public bool updateSERVICE(string id, string name, int cost, string note)
        {
            SqlCommand cmd = new SqlCommand("update SERVICEPACK set serviceID=@id,serviceName=@name,cost=@cost,note=@note", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@cost", SqlDbType.Int).Value = cost;
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
        public DataTable getSERVICE()
        {
            SqlCommand cmd = new SqlCommand("select *from SERVICEPACK", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getSERVICEbyID(string id)
        {
            SqlCommand cmd = new SqlCommand("select *from SERVICEPACK where serviceID=@ID", mydb.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getSERVICEbyName(string name)
        {
            SqlCommand cmd = new SqlCommand("select *from SERVICEPACK where serviceName=@ID", mydb.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = name;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}