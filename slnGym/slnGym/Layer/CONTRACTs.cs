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
        public bool insertCONTRACTS(string conID, string cusID, string idPT, int packID, DateTime dateS, DateTime dateE, string status)
        {
            SqlCommand cmd = new SqlCommand("insert into CONTRACTS(contractID,cusID,ptID,servicePACK,dateStart,dateDischarge,conStatus)" +
                "values (@conID,@cusID,@ptID,@pack,@dateS,@dateE,@sta)", mydb.getConnection);
            cmd.Parameters.Add("@conID", SqlDbType.VarChar).Value = conID;
            cmd.Parameters.Add("@cusID", SqlDbType.VarChar).Value = cusID;
            cmd.Parameters.Add("@ptID", SqlDbType.VarChar).Value = idPT;
            cmd.Parameters.Add("@pack", SqlDbType.Int).Value = packID;
            cmd.Parameters.Add("@dateS", SqlDbType.DateTime).Value = dateS;
            cmd.Parameters.Add("@dateE", SqlDbType.DateTime).Value = dateE;
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

        public bool updateCONTRACTS(string conID, string cusID, string idPT, int packID, DateTime dateS, DateTime dateE, string status)
        {
            SqlCommand cmd = new SqlCommand("update CONTRACTS set cusID=@cusID,ptID=@ptID" +
                "servicePACK=@pack,dateStart=@dateS,dateDischarge=@dateE,conStatus=@sta where contractID=@conID", mydb.getConnection);
            cmd.Parameters.Add("@cusID", SqlDbType.VarChar).Value = cusID;
            cmd.Parameters.Add("@ptID", SqlDbType.VarChar).Value = idPT;
            cmd.Parameters.Add("@pack", SqlDbType.Int).Value = packID;
            cmd.Parameters.Add("@dateS", SqlDbType.DateTime).Value = dateS;
            cmd.Parameters.Add("@dateE", SqlDbType.DateTime).Value = dateE;
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

        public DataTable getContractByPack(string id)
        {
            SqlCommand cmd = new SqlCommand("select *from CONTRACTS where servicePACK=@id ", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }
    }
}