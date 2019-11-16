using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace slnGym.Layer
{
    class DETAILRECEIPT
    {
        MY_DB mydb = new MY_DB();
        public bool insertDETAILRECEIPT(string receipt, DateTime date, int idBrand, int idService, string nameService, int period, decimal total)
        {
            SqlCommand cmd = new SqlCommand("insert into DETAILSREPCEIPT(receiptID,repceiptDate,idBrand,idService,nameServices,period,total)" +
                "values (@id,@date,@idBrand,@idSer,@name,@dis,@total)", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = receipt;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
            cmd.Parameters.Add("@idBrand", SqlDbType.Int).Value = idBrand;
            cmd.Parameters.Add("@idSer", SqlDbType.Int).Value = idService;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = nameService;
            cmd.Parameters.Add("@dis", SqlDbType.Int).Value = period;
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