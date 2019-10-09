using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace slnGym.Class
{
    class DETAILREPCEIPT
    {
        MY_DBClass mydb = new MY_DBClass();
        public bool insertDETAILRECEIPT(string receipt, string product)
        {
            SqlCommand cmd = new SqlCommand("insert into DETAILSREPCEPIT(receiptID,productID)" +
                "values (@id,@num)", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = receipt;
            cmd.Parameters.Add("@num", SqlDbType.VarChar).Value = product;
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
        public bool updateDETAILRECEIPT(string id, string product)
        {
            SqlCommand cmd = new SqlCommand("update DETAILSREPCEPIT set receiptID=@id,productID=@num", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@num", SqlDbType.VarChar).Value = product;
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
        public DataTable getDETAILRECEIPTbyReceiptID(string receiptID)
        {
            SqlCommand cmd = new SqlCommand("select *from DETAILSREPCEPIT where receiptID = @id ", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = receiptID;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
