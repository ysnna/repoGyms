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
    
        //Update khach hang
       
       
        //Lay thong tin 
     

        public DataTable getEmployeebyID(string id)
        {
            SqlCommand cmd = new SqlCommand("select *from tblEMPLOYEE where empID=@ma", mydb.getConnection);
            cmd.Parameters.Add("@ma", SqlDbType.VarChar).Value = id;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }
        public DataTable getEmployeebyPhone(string id)
        {
            SqlCommand cmd = new SqlCommand("select *from tblEMPLOYEE where phone=@ma", mydb.getConnection);
            cmd.Parameters.Add("@ma", SqlDbType.VarChar).Value = id;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }
        public DataTable getEmployeebyGroupID(string group)
        {
            SqlCommand cmd = new SqlCommand("select empID as 'ID', grID as 'Group', avatar as 'Avatar',empFname as 'FName', empLname as 'LName',empBdate as 'Birthday'," +
                "empAddress as 'Address', gender as 'Female', phone as 'Phone', salary as 'Salary', empIDCard as 'ID Card' from tblEMPLOYEE where grID=@ma", mydb.getConnection);
            cmd.Parameters.Add("@ma", SqlDbType.VarChar).Value = group;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }
        public DataTable searchEmployee(string search)
        {
            SqlCommand cmd = new SqlCommand("select tblemployeeID as 'ID', groupID as 'Group', avatar as 'Avatar',employeeFname as 'FName', employeeLname as 'LName',employeeBdate as 'Birthday', " +
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
            SqlCommand cmd = new SqlCommand("select distinct tblemployeeID as 'ID', EMPLOYEE.employeeFName +' '+EMPLOYEE.employeeLName as 'Name' from EMPLOYEE," +
                " (select ptID from CONTRACTS, DETAILSCONTRACT" +
                " where cusID = @ma and contractID = contID) as A" +
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
            SqlCommand cmd = new SqlCommand("select *from tblEMPLOYEE where grID=@ma", mydb.getConnection);
            cmd.Parameters.Add("@ma", SqlDbType.VarChar).Value = id;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }
    }
}