using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace slnGym.Class
{
    class RECEIPTs
    {
        MY_DB mydb = new MY_DB();
        public bool insertRECEIPT(string receipt, string memID, DateTime date, DateTime time, string emp, int value)
        {
            SqlCommand cmd = new SqlCommand("insert into RECEIPT(receiptID,memID,receiptDate,receiptTime,employeeID,value)" +
                "values (@id,@mem,@date,@time,@empID,@val)", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = receipt;
            cmd.Parameters.Add("@mem", SqlDbType.VarChar).Value = memID;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
            cmd.Parameters.Add("@time", SqlDbType.DateTime).Value = time;
            cmd.Parameters.Add("@empID", SqlDbType.VarChar).Value = emp;
            cmd.Parameters.Add("@val", SqlDbType.Int).Value = value;

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
        public bool updateRECEIPT(string receipt, string memID, DateTime date, DateTime time, string emp, int value)
        {
            SqlCommand cmd = new SqlCommand("update REPCEIPT set receiptID=@id,memID=@num,receiptDate=@date,receiptTime=@time,employeeID=@emp,value=@val", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = receipt;
            cmd.Parameters.Add("@mem", SqlDbType.VarChar).Value = memID;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
            cmd.Parameters.Add("@time", SqlDbType.DateTime).Value = time;
            cmd.Parameters.Add("@empID", SqlDbType.VarChar).Value = emp;
            cmd.Parameters.Add("@val", SqlDbType.Int).Value = value;
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
            SqlCommand cmd = new SqlCommand("select *from REPCEPIT where memID = @id ", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = receiptID;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}