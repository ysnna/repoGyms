using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace slnGym
{
    class MY_DB
    {
        //SqlConnection conn = new SqlConnection(@"Data Source=192.168.43.252,1433;Initial Catalog=GYMManager;Persist Security Info=True;User ID=ysnna;Password=123456");
       SqlConnection conn = new SqlConnection(@"Data Source=ADMIN\DANH;Initial Catalog=DBMS;Integrated Security=True");

        public SqlConnection getConnection
        {
            get { return conn; }
        }
        public void openConnection()
        {
            if ((conn.State == ConnectionState.Closed))
            {
                conn.Open();
            }
        }
        public void closeConnection()
        {
            if ((conn.State == ConnectionState.Open))
            {
                conn.Close();
                //conn.Dispose();
            }
        }
        public DataTable createTable(String sql)
        {
            openConnection();
            SqlDataAdapter da = new SqlDataAdapter(sql, getConnection);
            DataSet dt = new DataSet();
            da.Fill(dt);
            closeConnection();
            return dt.Tables[0];
        }
        public void executeQuery(String sql)
        {
            SqlCommand cmd = new SqlCommand();
            openConnection();
            try
            {
                cmd.Connection = getConnection;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                closeConnection();
                MessageBox.Show("Success");
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}