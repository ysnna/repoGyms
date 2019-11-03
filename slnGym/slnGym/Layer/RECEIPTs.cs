using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace slnGym.Layer
{
    class RECEIPTs
    {
        MY_DB mydb = new MY_DB();
        public bool insertRECEIPT(string receipt, string memID, decimal total)
        {
            SqlCommand cmd = new SqlCommand("insert into RECEIPT(receiptID,memID,total)" +
                "values (@id,@mem,@total)", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = receipt;
            cmd.Parameters.Add("@mem", SqlDbType.VarChar).Value = memID;
            cmd.Parameters.Add("@total", SqlDbType.Decimal).Value = total;

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
        public bool updateRECEIPT(string receipt, string memID, decimal total)
        {
            SqlCommand cmd = new SqlCommand("update RECEIPT set memID=@mem, total=@total where receiptID=@id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = receipt;
            cmd.Parameters.Add("@mem", SqlDbType.VarChar).Value = memID;
            cmd.Parameters.Add("@total", SqlDbType.Decimal).Value = total;
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
        public DataTable getRECEIPTbyID(string receiptID)
        {
            SqlCommand cmd = new SqlCommand("select *from RECEIPT where memID = @id ", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = receiptID;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.openConnection();
            return dt;
        }
        public DataTable getRECEIPT()
        {
            SqlCommand cmd = new SqlCommand("select *from RECEIPT ", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }
    }
}