﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace slnGym.Layer
{
    class SERVICEPACKs
    {
        MY_DB mydb = new MY_DB();
        public bool insertSERVICE(int id, string name, decimal cost, string note)
        {
            SqlCommand cmd = new SqlCommand("insert into SERVICEPACK(serviceID,serviceNAME,cost,note)" +
                "values (@id,@name,@cost,@note)", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@cost", SqlDbType.Decimal).Value = cost;
            cmd.Parameters.Add("@note", SqlDbType.NVarChar).Value = note;

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
        public bool deleteSERVICE(int ID)
        {
            SqlCommand cmd = new SqlCommand("delete from SERVICEPACK where serviceID=@id", mydb.getConnection);
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
        public bool updateSERVICE(int id, string name, decimal cost, string note)
        {
            SqlCommand cmd = new SqlCommand("update SERVICEPACK set serviceName=@name,cost=@cost,note=@note where serviceID=@id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@cost", SqlDbType.Decimal).Value = cost;
            cmd.Parameters.Add("@note", SqlDbType.NVarChar).Value = note;

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
        public DataTable getSERVICE()
        {
            SqlCommand cmd = new SqlCommand("select * from SERVICEPACK order by serviceID DESC", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }
        public DataTable getSERVICEbyID(int id)
        {
            SqlCommand cmd = new SqlCommand("select *from SERVICEPACK where serviceID=@ID", mydb.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }
        public DataTable getSERVICEbyName(string name)
        {
            SqlCommand cmd = new SqlCommand("select *from SERVICEPACK where serviceName=@ID", mydb.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = name;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }
    }
}