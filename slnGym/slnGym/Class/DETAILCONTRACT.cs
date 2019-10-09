using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace slnGym.Class
{
    class DETAILCONTRACT
    {
        MY_DBClass mydb = new MY_DBClass();
        public bool insertDETAILCON(string conID, string empID, string workID, int val)
        {
            SqlCommand cmd = new SqlCommand("insert into DETAILSCONTRACT(contractID,employeeID,workID,value)" +
                "values (@con,@emp,@work,@value)", mydb.getConnection);
            cmd.Parameters.Add("@con", SqlDbType.VarChar).Value = conID;
            cmd.Parameters.Add("@emp", SqlDbType.VarChar).Value = empID;
            cmd.Parameters.Add("@work", SqlDbType.VarChar).Value = workID;
            cmd.Parameters.Add("@value", SqlDbType.Int).Value = val;

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

        public bool updateDETAILCON(string conID, string empID, string workID, int val)
        {
            SqlCommand cmd = new SqlCommand("update DETAILSCONTRACT set contractID=@con,employeeID=@emp,workID=@work,value=@value", mydb.getConnection);
            cmd.Parameters.Add("@con", SqlDbType.VarChar).Value = conID;
            cmd.Parameters.Add("@emp", SqlDbType.VarChar).Value = empID;
            cmd.Parameters.Add("@work", SqlDbType.VarChar).Value = workID;
            cmd.Parameters.Add("@value", SqlDbType.Int).Value = val;

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
        public DataTable getDetailByConID(string conID)
        {
            SqlCommand cmd = new SqlCommand("select *from DETAILSCONTRACT where contractID=@con ", mydb.getConnection);
            cmd.Parameters.Add("@con", SqlDbType.VarChar).Value = conID;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getDetailByEmpID(string emp)
        {
            SqlCommand cmd = new SqlCommand("select *from DETAILSCONTRACT where employeeID=@emp ", mydb.getConnection);
            cmd.Parameters.Add("@emp", SqlDbType.VarChar).Value = emp;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getDetailByWorkID(string work)
        {
            SqlCommand cmd = new SqlCommand("select *from DETAILSCONTRACT where workID=@con", mydb.getConnection);
            cmd.Parameters.Add("@con", SqlDbType.VarChar).Value = work;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
