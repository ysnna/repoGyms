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
        public bool insertDETAILRECEIPT(string receipt, DateTime date, int idBrand, int idService, string nameService, int period, decimal total, string remain)
        {
            SqlCommand cmd = new SqlCommand("insert into tblDETAILSRECEIPT(receiptID,receiptDate,idBrand,idService,nameServices,period,total,remain)" +
                "values (@id,@date,@idBrand,@idSer,@name,@dis,@total,@remain)", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = receipt;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
            cmd.Parameters.Add("@idBrand", SqlDbType.Int).Value = idBrand;
            cmd.Parameters.Add("@idSer", SqlDbType.Int).Value = idService;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = nameService;
            cmd.Parameters.Add("@dis", SqlDbType.Int).Value = period;
            cmd.Parameters.Add("@total", SqlDbType.Decimal).Value = total;
            cmd.Parameters.Add("@remain", SqlDbType.NVarChar).Value = remain;
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
        
    }
}