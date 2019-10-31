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
        public bool insertMACHINE(int id, string name, MemoryStream pic, string info, int amount)
        {
            SqlCommand cmd = new SqlCommand("insert into MACHINES(idMachine,nameMachine,picture,infor,amount)" + "values(@id,@name,@pic,@info,@amt)", mydb.getConnection);
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@pic", SqlDbType.Image).Value = pic.ToArray();
            cmd.Parameters.Add("@info", SqlDbType.NVarChar).Value = info;
            cmd.Parameters.Add("@amt", SqlDbType.Int).Value = amount;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
        public bool updateMACHINE(int id, string name, MemoryStream pic, string info, int amount)
        {
            SqlCommand cmd = new SqlCommand("update MACHINES set nameMachine=@name, picture=@pic, infor=@info, amount=@amt where idMachine=@id", mydb.getConnection);
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@pic", SqlDbType.Image).Value = pic.ToArray();
            cmd.Parameters.Add("@info", SqlDbType.NVarChar).Value = info;
            cmd.Parameters.Add("@amt", SqlDbType.Int).Value = amount;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
        public bool deleteMACHINE(int id)
        {
            SqlCommand cmd = new SqlCommand("delete from MACHINES where idMachine=@id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
        public DataTable getMACHINE()
        {
            SqlCommand cmd = new SqlCommand("select *from MACHINES", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }
        public DataTable getMACHINESbyID(int id)
        {
            SqlCommand cmd = new SqlCommand("select *from MACHINES where idMachine=@id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }
    }
}