﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace slnGym.Layer
{
    class DETAILCONTRACT
    {
        MY_DB mydb = new MY_DB();
        public bool insertDETAILCON(string conID, string receiptID, string ptID, int idPackage, DateTime start, DateTime end, string status)
        {
            SqlCommand cmd = new SqlCommand("insert into DETAILSCONTRACT(contID,receiptID,ptID,servicePACK,dateStart,dateDischarge,status)" +
                "values (@con,@rep,@pt,@pack,@start,@end,@status)", mydb.getConnection);
            cmd.Parameters.Add("@con", SqlDbType.VarChar).Value = conID;
            cmd.Parameters.Add("@rep", SqlDbType.VarChar).Value = receiptID;
            cmd.Parameters.Add("@pt", SqlDbType.VarChar).Value = ptID;
            cmd.Parameters.Add("@pack", SqlDbType.Int).Value = idPackage;
            cmd.Parameters.Add("@start", SqlDbType.DateTime).Value = start;
            cmd.Parameters.Add("@end", SqlDbType.DateTime).Value = end;
            cmd.Parameters.Add("@status", SqlDbType.NVarChar).Value = status;

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
            SqlCommand cmd = new SqlCommand("select *from DETAILSCONTRACT where contID=@con ", mydb.getConnection);
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

        public DataTable getDetailConTractDGV()
        {
            SqlCommand cmd = new SqlCommand("select contID,cusID,serviceName, employeeID, dateStart,dateDischarge, B.receiptID, total, ptID from RECEIPT," +
                " (select contID, serviceName, employeeID, cusID, dateStart, dateDischarge, receiptID, ptID from DETAILSCONTRACT," +
                " (select * from SERVICEPACK, CONTRACTS" +
                " where CONTRACTS.servicePACK = SERVICEPACK.serviceID) as A" +
                " where DETAILSCONTRACT.contID = A.contractID) as B" +
                " where B.receiptID = RECEIPT.receiptID", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }
    }
}