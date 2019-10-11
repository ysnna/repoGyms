using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace slnGym.Class
{
    class MY_DB
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-KU7N2N8\SQLEXPRESS;Initial Catalog=GYMManager;Integrated Security=True");
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-KU7N2N8\SQLEXPRESS;Initial Catalog=GYMManager;Integrated Security=True");
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
            }
        }
    }
}