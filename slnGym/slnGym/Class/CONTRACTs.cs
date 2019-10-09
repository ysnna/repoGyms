using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace slnGym.Class
{
    class CONTRACTs
    {
        MY_DB mydb = new MY_DB();
        public bool insertCONTRACTS(string conID, string cusID, string packID, DateTime datesign, DateTime dateliquid, string status)
        {
            SqlCommand cmd = new SqlCommand("insert into CONTRACTS(contractID,cusID,servicePACK,dateSigned,dateLiquidation,conStatus)" +
                "values (@conID,@cusID,@pack,@datesign,@dateliquid,@sta)", mydb.getConnection);
            cmd.Parameters.Add("@conID", SqlDbType.VarChar).Value = conID;
            cmd.Parameters.Add("@cusID", SqlDbType.VarChar).Value = cusID;
            cmd.Parameters.Add("@pack", SqlDbType.VarChar).Value = packID;
            cmd.Parameters.Add("@datesign", SqlDbType.DateTime).Value = datesign;
            cmd.Parameters.Add("@dateliquid", SqlDbType.DateTime).Value = dateliquid;
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
            SqlCommand cmd = new SqlCommand("delete from CONTRACT where contractID=@id", mydb.getConnection);
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

        public bool updateCONTRACTS(string conID, string cusID, string packID, DateTime datesign, DateTime dateliquid, string status)
        {
            SqlCommand cmd = new SqlCommand("update CONTRACTS set contractID=@conID,cusID=@cusID," +
                "servicePACK=@pack,dateSigned=@datesign,dateLiquidation=@dateliquid,conStatus=@sta", mydb.getConnection);
            cmd.Parameters.Add("@conID", SqlDbType.VarChar).Value = conID;
            cmd.Parameters.Add("@cusID", SqlDbType.VarChar).Value = cusID;
            cmd.Parameters.Add("@pack", SqlDbType.VarChar).Value = packID;
            cmd.Parameters.Add("@datesign", SqlDbType.DateTime).Value = datesign;
            cmd.Parameters.Add("@dateliquid", SqlDbType.DateTime).Value = dateliquid;
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
            return dt;
        }
        public DataTable getContractByCUSID(string id)
        {
            SqlCommand cmd = new SqlCommand("select *from CONTRACTS where cusID=@id ", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable getContractByPack(string id)
        {
            SqlCommand cmd = new SqlCommand("select *from CONTRACTS where servicePACK=@id ", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}