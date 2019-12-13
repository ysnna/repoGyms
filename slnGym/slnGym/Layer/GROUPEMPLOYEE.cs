using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace slnGym.Layer
{
    class GROUPEMPLOYEE
    {
        MY_DB mydb = new MY_DB();
        //Lay thong tin 
        public DataTable getGROUPEMP()
        {
            SqlCommand cmd = new SqlCommand("select *from tblGROUPEMPLOYEE ", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }
    }
}