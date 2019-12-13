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
    class MEMBERs
    {
        MY_DB mydb = new MY_DB();
        //Them Khach Hang
        public bool insertMembers(string ID, string lname, string fname, MemoryStream pic, DateTime bdate, string address,
            string gender, string phone, int idcard, string note)
        {
            SqlCommand cmd = new SqlCommand("insert into tblMEMBERS(memID,memLname,memFname,avatar,memBDate,memAddress,memGender,memPhone,cardID,note)" +
                "values (@id,@lname,@fname,@ava,@bdate,@add,@gen,@phone,@idcard,@note)", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = ID;
            cmd.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
            cmd.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            cmd.Parameters.Add("@ava", SqlDbType.Image).Value = pic.ToArray();
            cmd.Parameters.Add("@bdate", SqlDbType.DateTime).Value = bdate;
            cmd.Parameters.Add("@add", SqlDbType.NVarChar).Value = address;
            cmd.Parameters.Add("@gen", SqlDbType.VarChar).Value = gender;
            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@idcard", SqlDbType.Int).Value = idcard;
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

        //Xoa khach hang
        public bool deleteMembers(string memID)
        {
            SqlCommand cmd = new SqlCommand("delete from MEMBERS where memID=@id", mydb.getConnection);
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
        public bool updateMembers(string ID, string lname, string fname, MemoryStream pic, DateTime bdate, string address,
            string gender, string phone, int idcard, string note)
        {//(memID,memLname,memFname,avatar,memBDate,memAddress,memGender,memPhone,cardID,note
            SqlCommand cmd = new SqlCommand("update tblMEMBERS set memFName=@fname,memLname=@lname," +
                "avatar=@ava,memBDate=@bdate,memAddress=@add,memGender=@gen,memPhone=@phone,cardID=@idcard,note=@note where memID=@id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = ID;
            cmd.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
            cmd.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            cmd.Parameters.Add("@ava", SqlDbType.Image).Value = pic.ToArray();
            cmd.Parameters.Add("@bdate", SqlDbType.DateTime).Value = bdate;
            cmd.Parameters.Add("@add", SqlDbType.NVarChar).Value = address;
            cmd.Parameters.Add("@gen", SqlDbType.VarChar).Value = gender;
            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@idcard", SqlDbType.Int).Value = idcard;
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
            public bool updateAccpuntMember(string ID, string note)
        {
            SqlCommand cmd = new SqlCommand("update tblMEMBERS set note=@note where memID=@id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = ID;
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
        public DataTable getAllMEMBERS()
        {
            SqlCommand cmd = new SqlCommand("select memID as 'ID',memFname as 'FName',memLname as 'LName', avatar as 'Avatar', memBDate as 'Birthday'," +
                "memAddress as 'Address',memGender as 'Female',memPhone as 'Phone',cardID as 'ID card',note as 'Status' from tblMEMBERS", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }

        public DataTable getMemberbyID(string id)
        {
            SqlCommand cmd = new SqlCommand("select *from tblMEMBERS where memID=@ma", mydb.getConnection);
            cmd.Parameters.Add("@ma", SqlDbType.VarChar).Value = id;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }

        public DataTable getMemberbyPackage(string IDMember)
        {
            SqlCommand cmd = new SqlCommand("select idBrand as 'Group',idService as 'Package', nameServices as 'Name', period as 'Period', tblDETAILSRECEIPT.total from tblRECEIPT, tblDETAILSRECEIPT " +
                "where tblRECEIPT.receipt_ID= tblDETAILSRECEIPT.receiptID and mem_ID = @mem", mydb.getConnection);
            cmd.Parameters.Add("@mem", SqlDbType.VarChar).Value = IDMember;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }
        //Sua doi thong tin cua khach hang duoc admin duyet m   
        public bool insertTemporary(string ID, string lname, string fname,MemoryStream ava, DateTime bdate, string address,
            string gender, string phone, int idcard, string note)
        {
            SqlCommand cmd = new SqlCommand("insert into tblTEMP(ID,FName,LName,avatar,BDate,Address,Gender,Phone,cardID,note)" +
                "values (@id,@fname,@lname,@ava,@bdate,@add,@gen,@phone,@idcard,@note)", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = ID;
            cmd.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
            cmd.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            cmd.Parameters.Add("@bdate", SqlDbType.DateTime).Value = bdate;
            cmd.Parameters.Add("@add", SqlDbType.NVarChar).Value = address;
            cmd.Parameters.Add("@ava", SqlDbType.Image).Value = ava.ToArray();
            cmd.Parameters.Add("@gen", SqlDbType.VarChar).Value = gender;
            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@idcard", SqlDbType.Int).Value = idcard;
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

        public bool deleteTEMP(string ID)
        {
            SqlCommand cmd = new SqlCommand("DELETE from tblTEMP where ID=@ID",mydb.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = ID;
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

        public DataTable getTEMP()
        {
            SqlCommand cmd = new SqlCommand("select *from tblTEMP", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }

        public DataTable searchEmployee(string search)
        {
            SqlCommand cmd = new SqlCommand("select memID as 'ID',memFname as 'FName',memLname as 'LName', avatar as 'Avatar', memBDate as 'Birthday'," +
                "memAddress as 'Address',memGender as 'Female',memPhone as 'Phone',cardID as 'ID card',note as 'Status' from tblMEMBERS where Concat(memID, memFname, " +
                "memlname, memaddress) like N'%" + search + "%' ", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }

        public DataTable getRenewMember()
        {
            SqlCommand cmd = new SqlCommand("select memID as 'ID',memFname as 'FName',memLname as 'LName' from tblMEMBERS", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }

        public DataTable searchRenewMember(string search)
        {
            SqlCommand cmd = new SqlCommand("select memID as 'ID',memFname as 'FName',memLname as 'LName' from tblMEMBERS where Concat(memID, memFname, " +
                "memlname) like N'%" + search + "%' ", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }
        public DataTable searchMember(string search)
        {
            SqlCommand cmd = new SqlCommand("select memID as 'ID',memFname as 'FName',memLname as 'LName', avatar as 'Avatar', memBDate as 'Birthday'," +
                "memAddress as 'Address',memGender as 'Female',memPhone as 'Phone',cardID as 'ID card',note as 'Status' from tblMEMBERS where Concat(memID, memFname, " +
                "memlname) like N'%" + search + "%' ", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }
        public DataTable getRenewMemberByID(string search)
        {
            SqlCommand cmd = new SqlCommand("select contID as 'ID', ptID as 'PT', servicePACK as 'Package', serNAME as 'Name', dateStart as 'Date start', dateDischarge as 'Date Expiration', cost as 'Price', status as 'Status' from tblCONTRACTS, tblDETAILSCONTRACT, tblSERVICEPACK where serID=servicePACK and contID=cont_ID and cusID=@cusID", mydb.getConnection);
            cmd.Parameters.Add("@cusID", SqlDbType.VarChar).Value = search;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }
        public DataTable getMemberF1()
        {
            SqlCommand cmd = new SqlCommand("select memID as 'ID',memFname as 'FName',memLname as 'LName' from tblMEMBERS ", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }
    }
}