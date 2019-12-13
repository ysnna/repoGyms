using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace slnGym.Layer
{
    class PRODUCTs
    {
        MY_DB mydb = new MY_DB();
        public bool insertPRODUCTS(int id, string name, decimal cost, MemoryStream pic)
        {
            SqlCommand cmd = new SqlCommand("insert into tblPRODUCTS(proID,picture,proName,proCost)" +
                "values (@id,@pic,@name,@cost)", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@pic", SqlDbType.Image).Value = pic.ToArray();
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@cost", SqlDbType.Decimal).Value = cost;

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
        public bool deletePRODUCTS(int ID)
        {
            SqlCommand cmd = new SqlCommand("delete from tblPRODUCTS where proID=@id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = ID;
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
        public bool updatePRODUCTS(int id, MemoryStream pic, string name, decimal cost)
        {
            SqlCommand cmd = new SqlCommand("update tblPRODUCTS set picture=@pic,proName=@name,proCost=@cost where proID=@id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@cost", SqlDbType.Decimal).Value = cost;
            cmd.Parameters.Add("@pic", SqlDbType.Image).Value = pic.ToArray();
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
        public DataTable getPRODUCTS()
        {
            SqlCommand cmd = new SqlCommand("select *from tblPRODUCTS", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }
        public DataTable getPRODUCTSbyIDNAMECost()
        {
            SqlCommand cmd = new SqlCommand("select proID as 'ID', proName as 'Name', proCost as 'Price' from tblPRODUCTS", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }
        public DataTable getPRODUCTSbyID(int id)
        {
            SqlCommand cmd = new SqlCommand("select *from tblPRODUCTS where proID=@ID", mydb.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }
        public DataTable getPRODUCTbyName(string name)
        {
            SqlCommand cmd = new SqlCommand("select *from tblPRODUCTS where prodName=@ID", mydb.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = name;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }
        public DataTable getPRODUCTDGV(string name)
        {
            SqlCommand cmd = new SqlCommand("select A.receipt_ID as 'ID', nameServices as 'Name', period as 'Quantity',total as 'Total', receiptDate as 'Date payment' from tblDETAILSRECEIPT," +
                " (select cont_ID, receipt_ID  from tblCONTRACTS, tblDETAILSCONTRACT " +
                " where contID = cont_ID AND tblCONTRACTS.cusID = @ID) as A" +
                " where A.receipt_ID = tblDETAILSRECEIPT.receiptID AND  idBrand = '2'", mydb.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = name;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }
    }
}