using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace slnGym.Layer
{
    class CONTRACTs
    {
        MY_DB mydb = new MY_DB();
        public bool insertCONTRACTS(string conID, string cusID, string emloyeeID, string status)
        {
            SqlCommand cmd = new SqlCommand("insert into CONTRACTS(contractID,cusID,employeeID,conStatus)" +
                "values (@conID,@cusID,@emID,@sta)", mydb.getConnection);
            cmd.Parameters.Add("@conID", SqlDbType.VarChar).Value = conID;
            cmd.Parameters.Add("@cusID", SqlDbType.VarChar).Value = cusID;
            cmd.Parameters.Add("@emID", SqlDbType.VarChar).Value = emloyeeID;
            cmd.Parameters.Add("@sta", SqlDbType.NVarChar).Value = status;

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

        public bool deleteCONTRACTS(string ID)
        {
            SqlCommand cmd = new SqlCommand("delete from CONTRACTS where contractID=@id", mydb.getConnection);
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
        //Lay thong tin 
        public DataTable getCONTRACTS()
        {
            SqlCommand cmd = new SqlCommand("select *from CONTRACTS ", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }

        public DataTable getContractByCUSID(string id)
        {
            SqlCommand cmd = new SqlCommand("select *from CONTRACTS where cusID=@id ", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }
    }
}