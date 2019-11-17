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
    class EMPLOYEEs
    {
        public static string EmployeeID { get; set; }
        MY_DB mydb = new MY_DB();
        //Them Khach Hang
        public bool insertEmployee(string ID, string group, MemoryStream ava, string fname, string lname, DateTime bdate, string address,
            int gender, string phone, int salary, int idcard)
        {
            SqlCommand cmd = new SqlCommand("insert into EMPLOYEE(employeeID,groupID,avatar,employeeFName,employeeLName,employeeBDate,employeeAddress,gender,phone,salary,employeeIDCard)" +
                "values (@id,@group,@ava,@fname,@lname,@bdate,@add,@gen,@phone,@sal,@idcard)", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = ID;
            cmd.Parameters.Add("@group", SqlDbType.VarChar).Value = group;
            cmd.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
            cmd.Parameters.Add("@ava", SqlDbType.Image).Value = ava.ToArray();
            cmd.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            cmd.Parameters.Add("@bdate", SqlDbType.DateTime).Value = bdate;
            cmd.Parameters.Add("@add", SqlDbType.NVarChar).Value = address;
            cmd.Parameters.Add("@gen", SqlDbType.Bit).Value = gender;
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
        public bool updateEmployee(string id, MemoryStream ava, DateTime bdate, string address, int gender, string phone)
        {//groupID=@gr,avatar=@ava,employeeFName=@fn,employeeLName=@ln,employeeBDate=@bd,employeeAddress=@add,gender=@gd,phone=@phone,salary=@sala,employeeIDCard=@idcard where employeeID=@id
            SqlCommand cmd = new SqlCommand("update EMPLOYEE set avatar=@ava,employeeBDate=@bd,employeeAddress=@add,gender=@gd,phone=@phone where employeeID=@id", mydb.getConnection);
            cmd.Parameters.Add("@bd", SqlDbType.DateTime).Value = bdate;
            cmd.Parameters.Add("@add", SqlDbType.NVarChar).Value = address;
            cmd.Parameters.Add("@gd", SqlDbType.Int).Value = gender;
            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@ava", SqlDbType.Image).Value = ava.ToArray();
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id;

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
        public bool updateEmployeeAD(string idEmployee, string grID, MemoryStream ava, string fname, string lname, DateTime bdate, string address, int gender, string phone, int salary, string idCard)
        {
            SqlCommand cmd = new SqlCommand("update EMPLOYEE set groupID=@gid,avatar=@ava,employeeFName=@fname,employeeLName=@lname,employeeBDate=@bdate," +
                "employeeAddress=@add,gender=@gender,phone=@phone,salary=@salary,employeeIDCard=@idcard where employeeID=@id", mydb.getConnection);
            cmd.Parameters.Add("@gid", SqlDbType.VarChar).Value = grID;
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = idEmployee;
            cmd.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            cmd.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
            cmd.Parameters.Add("@salary", SqlDbType.Int).Value = salary;
            cmd.Parameters.Add("@bdate", SqlDbType.DateTime).Value = bdate;
            cmd.Parameters.Add("@add", SqlDbType.NVarChar).Value = address;
            cmd.Parameters.Add("@gender", SqlDbType.Int).Value = gender;
            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@ava", SqlDbType.Image).Value = ava.ToArray();
            cmd.Parameters.Add("@idcard", SqlDbType.VarChar).Value = idCard;

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
            SqlCommand cmd = new SqlCommand("select employeeID as 'ID', groupID as 'Group', avatar as 'Avatar',employeeFname as 'FName', employeeLname as 'LName'," +
                " employeeBdate as 'Birthday', employeeAddress as 'Address', gender as 'Female', phone as 'Phone', salary as 'Salary', employeeIDCard as 'ID Card' from EMPLOYEE", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }

        public DataTable getEmployeebyID(string id)
        {
            SqlCommand cmd = new SqlCommand("select *from EMPLOYEE where employeeID=@ma", mydb.getConnection);
            cmd.Parameters.Add("@ma", SqlDbType.VarChar).Value = id;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }
        public DataTable getEmployeebyPhone(string id)
        {
            SqlCommand cmd = new SqlCommand("select *from EMPLOYEE where phone=@ma", mydb.getConnection);
            cmd.Parameters.Add("@ma", SqlDbType.VarChar).Value = id;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }
        public DataTable getEmployeebyGroupID(string group)
        {
            SqlCommand cmd = new SqlCommand("select employeeID as 'ID', groupID as 'Group', avatar as 'Avatar',employeeFname as 'FName', employeeLname as 'LName',employeeBdate as 'Birthday'," +
                "employeeAddress as 'Address', gender as 'Female', phone as 'Phone', salary as 'Salary', employeeIDCard as 'ID Card' from EMPLOYEE where groupID=@ma", mydb.getConnection);
            cmd.Parameters.Add("@ma", SqlDbType.VarChar).Value = group;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }
        public DataTable searchEmployee(string search)
        {
            SqlCommand cmd = new SqlCommand("select employeeID as 'ID', groupID as 'Group', avatar as 'Avatar',employeeFname as 'FName', employeeLname as 'LName',employeeBdate as 'Birthday', " +
                "employeeAddress as 'Address', gender as 'Female', phone as 'Phone', salary as 'Salary', employeeIDCard as 'ID Card' from EMPLOYEE where Concat(employeeID, employeeFname, " +
                "employeeLname, phone) like N'%" + search + "%' ", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }
        public DataTable getPTbyMemID(string memID)
        {
            SqlCommand cmd = new SqlCommand("select distinct employeeID as 'ID', EMPLOYEE.employeeFName +' '+EMPLOYEE.employeeLName as 'Name' from EMPLOYEE," +
                " (select ptID from MEMBERS, CONTRACTS " +
                " where cusID = @ma) as A" +
                " where ptID = employeeID", mydb.getConnection);
            cmd.Parameters.Add("@ma", SqlDbType.VarChar).Value = memID;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }
        //Kiểm tra ID động
        public DataTable getexistID(string id)
        {
            SqlCommand cmd = new SqlCommand("select *from EMPLOYEE where groupID=@ma", mydb.getConnection);
            cmd.Parameters.Add("@ma", SqlDbType.VarChar).Value = id;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }
    }
}