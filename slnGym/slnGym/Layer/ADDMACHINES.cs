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
    class ADDMACHINES
    {
        MY_DB mydb = new MY_DB();
        public bool insertMACHINE(string name, MemoryStream pic, string info, int amount)
        {
            SqlCommand cmd = new SqlCommand("insert into MACHINES(nameMachine,picture,infor,amount)" + "values(@name,@pic,@info,@amt)", mydb.getConnection);
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@pic", SqlDbType.Image).Value = pic.ToArray();
            cmd.Parameters.Add("@info", SqlDbType.NVarChar).Value = info;
            cmd.Parameters.Add("@amt", SqlDbType.Int).Value = amount;

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
        public bool updateMACHINE(string name, MemoryStream pic, string info, int amount)
        {
            SqlCommand cmd = new SqlCommand("update MACHINES set picture=@pic, infor=@info, amount=@amt where nameMachine=@name", mydb.getConnection);
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@pic", SqlDbType.Image).Value = pic.ToArray();
            cmd.Parameters.Add("@info", SqlDbType.NVarChar).Value = info;
            cmd.Parameters.Add("@amt", SqlDbType.Int).Value = amount;

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
        public bool deleteMACHINE(string name)
        {
            SqlCommand cmd = new SqlCommand("delete from MACHINES where nameMachine=@name", mydb.getConnection);
            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
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