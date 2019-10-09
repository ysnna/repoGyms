using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace slnGym.Class
{
    class PRODUCTs
    {
        MY_DB mydb = new MY_DB();
        public bool insertPRODUCTS(string id, string name, int cost)
        {
            SqlCommand cmd = new SqlCommand("insert into PRODUCTS(productID,productName,productCost)" +
                "values (@id,@name,@cost)", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@cost", SqlDbType.Int).Value = cost;

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
        public bool deletePRODUCTS(string ID)
        {
            SqlCommand cmd = new SqlCommand("delete from PRODUCTS where productID=@id", mydb.getConnection);
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
        public bool updatePRODUCTS(string id, string name, int cost)
        {
            SqlCommand cmd = new SqlCommand("update PRODUCTS set productID=@id,productName=@name,productCost=@cost", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@cost", SqlDbType.Int).Value = cost;

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
            SqlCommand cmd = new SqlCommand("select *from PRODUCTS", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getPRODUCTSbyID(string id)
        {
            SqlCommand cmd = new SqlCommand("select *from PRODUCTS where productID=@ID", mydb.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getPRODUCTbyName(string name)
        {
            SqlCommand cmd = new SqlCommand("select *from PRODUCTS where productName=@ID", mydb.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = name;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}