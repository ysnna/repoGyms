using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnGym.Layer
{
    public class STATISTICS
    {
        MY_DB mydb = new MY_DB();
        public bool insertSTATISTIC(DateTime day, string group, int amount, decimal total, string status)
        {
            SqlCommand cmd = new SqlCommand("insert into DAYSTATISTIC(dayST,groupST,amount,total,statusST)" + "values(@day,@gr,@amount,@total,@status)", mydb.getConnection);
            cmd.Parameters.Add("@day", SqlDbType.DateTime).Value = day;
            cmd.Parameters.Add("@gr", SqlDbType.NVarChar).Value = group;
            cmd.Parameters.Add("@amount", SqlDbType.Int).Value = amount;
            cmd.Parameters.Add("@total", SqlDbType.Decimal).Value = total;
            cmd.Parameters.Add("@status", SqlDbType.NVarChar).Value = status;
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
        public bool updateSTATISTIC(DateTime day, string group, int amount, decimal total, string status)
        {
            SqlCommand cmd = new SqlCommand("update DAYSTATISTIC set groupST=@gr,amount=@amount,total=@total,statusST=@status where dayST=@day", mydb.getConnection);
            cmd.Parameters.Add("@gr", SqlDbType.NVarChar).Value = group;
            cmd.Parameters.Add("@amount", SqlDbType.Int).Value = amount;
            cmd.Parameters.Add("@total", SqlDbType.Decimal).Value = total;
            cmd.Parameters.Add("@status", SqlDbType.NVarChar).Value = status;
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
        public DataTable getSTATISTIC(int id)
        {
            SqlCommand cmd = new SqlCommand("select repceiptDate as 'Date', idBrand as 'ID', count (total) as 'Amount', SUM(total) as 'Total' from DETAILSREPCEIPT " +
                "where idBrand =@id group by idBrand, repceiptDate", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }
        public DataTable getDaySTATISTIC(DateTime day, string group)
        {
            SqlCommand cmd = new SqlCommand("select *from DAYSTATISTIC where dayST=@day and groupST=@gr", mydb.getConnection);
            cmd.Parameters.Add("@day", SqlDbType.DateTime).Value = day;
            cmd.Parameters.Add("@gr", SqlDbType.NVarChar).Value = group;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }
    }
}