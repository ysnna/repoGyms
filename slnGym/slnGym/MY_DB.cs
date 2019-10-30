using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace slnGym
{
    class MY_DB
    {
        //SqlConnection conn = new SqlConnection(@"Data Source=ADMIN\DANH;Initial Catalog=GYMManager;Integrated Security=True");
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-RRRHOP4\RRRHOP4;Initial Catalog=GYMManager;Integrated Security=True");
        
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
    }
}