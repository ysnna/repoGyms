using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
namespace slnGym.Class
{
    class EMPLOYEEs
    {
        MY_DB mydb = new MY_DB();
        //Them Khach Hang
        public bool insertEmployee(string ID, string group, MemoryStream ava, string fname, string lname, DateTime bdate, string address,
            int gender, string phone, int salary, int idcard)
        {
            SqlCommand cmd = new SqlCommand("insert into MEMBERS(employeeID,groupID,avatar,employeeFName,employeeBDate,employeeAddress,gender,phone,salary,employeeIDCard)" +
                "values (@id,@group,@ava,@lname,@fname,@bdate,@add,@gen,@phone,@sal,@idcard)", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = ID;
            cmd.Parameters.Add("@group", SqlDbType.VarChar).Value = group;
            cmd.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
            cmd.Parameters.Add("@ava", SqlDbType.Image).Value = ava.ToArray() ;

            cmd.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            cmd.Parameters.Add("@bdate", SqlDbType.DateTime).Value = bdate;
            cmd.Parameters.Add("@add", SqlDbType.NVarChar).Value = address;
            cmd.Parameters.Add("@gen", SqlDbType.Int).Value = gender;
            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@idcard", SqlDbType.Int).Value = idcard;
            cmd.Parameters.Add("@sal", SqlDbType.Int).Value = salary;


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

        //Xoa khach hang
        public bool deleteEmployee(string memID)
        {
            SqlCommand cmd = new SqlCommand("delete from EMPLOYEE where employeeID=@id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = memID;
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
        //Update khach hang
        public bool updateEmployee(string ID, string group, string lname, string fname, DateTime bdate, string address,
            int gender, string phone, int idcard, int salary)
        {
            SqlCommand cmd = new SqlCommand("update EMPLOYEE set employeeID=@id,groupID=@group,employeeLname=@lname,employeeFname=@fname,employeeBDate=@bdate,employeeAddress=@add," +
                "gender=@gen,phone=@phone,salary=@sal,employeeIDCard=@idcard", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = ID;
            cmd.Parameters.Add("@group", SqlDbType.VarChar).Value = group;
            cmd.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
            cmd.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            cmd.Parameters.Add("@bdate", SqlDbType.DateTime).Value = bdate;
            cmd.Parameters.Add("@add", SqlDbType.NVarChar).Value = address;
            cmd.Parameters.Add("@gen", SqlDbType.Int).Value = gender;
            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@idcard", SqlDbType.Int).Value = idcard;
            cmd.Parameters.Add("@sal", SqlDbType.Int).Value = salary;

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
        public DataTable getAllEMPLOYEE()
        {
            SqlCommand cmd = new SqlCommand("select *from EMPLOYEE", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable getEmployeebyID(string id)
        {
            SqlCommand cmd = new SqlCommand("select *from EMPLOYEE where employeeID=@ma", mydb.getConnection);
            cmd.Parameters.Add("@ma", SqlDbType.VarChar).Value = id;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getEmployeebyPhone(string id)
        {
            SqlCommand cmd = new SqlCommand("select *from EMPLOYEE where phone=@ma", mydb.getConnection);
            cmd.Parameters.Add("@ma", SqlDbType.VarChar).Value = id;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getEmployeebyGroupID(string group)
        {
            SqlCommand cmd = new SqlCommand("select *from EMPLOYEE where groupID=@ma", mydb.getConnection);
            cmd.Parameters.Add("@ma", SqlDbType.VarChar).Value = group;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}