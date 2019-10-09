using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace slnGym.Class
{
    class abilities_CLASS
    {
        MY_DBClass mydb = new MY_DBClass();
        //Dang ky tai khoan
        public bool insertAILITIES(string emID,string workID)
        {
            SqlCommand cmd = new SqlCommand("insert into ABILITIES(employeeID,workID)" +
                "values (@empID,@workID))", mydb.getConnection);
            cmd.Parameters.Add("@empID", SqlDbType.VarChar).Value = emID;
            cmd.Parameters.Add("@workID", SqlDbType.VarChar).Value = workID;
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


    }
}
