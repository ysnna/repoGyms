using System;
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
        public bool insertSERVICE(int id, string name, decimal cost, string note, string tag)
        {
            SqlCommand cmd = new SqlCommand("insert into tblSERVICEPACK(serID,serNAME,cost,note, tagPT)" +
                "values (@id,@name,@cost,@note,@tag)", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@cost", SqlDbType.Decimal).Value = cost;
            cmd.Parameters.Add("@note", SqlDbType.NVarChar).Value = note;
            cmd.Parameters.Add("@tag", SqlDbType.VarChar).Value = tag;
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
            SqlCommand cmd = new SqlCommand("delete from tblSERVICEPACK where serID=@id", mydb.getConnection);
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
        public bool updateSERVICE(int id, string name, decimal cost, string note, string tag)
        {
            SqlCommand cmd = new SqlCommand("update tblSERVICEPACK set serName=@name,cost=@cost,note=@note,tagPT=@tag where serID=@id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@cost", SqlDbType.Decimal).Value = cost;
            cmd.Parameters.Add("@note", SqlDbType.NVarChar).Value = note;
            cmd.Parameters.Add("@tag", SqlDbType.VarChar).Value = tag;
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
            SqlCommand cmd = new SqlCommand("select serID as 'ID',serNAME as 'Name',cost as 'Price',note as 'Description', tagPT as 'Tag' from tblSERVICEPACK order by serID", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }

        public DataTable getNamePTbyPackage(string tagPT) //--tagPT = @tagPT roi add cmd.Add.Parameter vo
        {
            SqlCommand cmd = new SqlCommand("select Distinct tblEMPLOYEE.empID as 'ID  ',tblEMPLOYEE.empFName as 'First name', tblEMPLOYEE.empLName as 'Last name' from tblEMPLOYEE," +
                "(select idPT from tblWork,(select *from tblSERVICEPACK, tblGROUPWORK where tblSERVICEPACK.tagPT = tblGROUPWORK.grWorkID) as A " +
                "where tblWORK.groupWorkID = A.tagPT and tagPT =@tagpt) as B  where tblEMPLOYEE.empID = B.idPT", mydb.getConnection);
            cmd.Parameters.Add("@tagpt", SqlDbType.VarChar).Value = tagPT;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }
        public DataTable getSERVICEbyID(int id)
        {
            SqlCommand cmd = new SqlCommand("select *from tblSERVICEPACK where serID=@ID", mydb.getConnection);
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }
        
        public DataTable getPackageDGV(string idKH)
        {
            SqlCommand cmd = new SqlCommand("select A.contID as 'ID', serNAME as 'Name', A.dateStart as 'Date Start',A.dateDischarge as 'Date Discharge' from tblSERVICEPACK, " +
                " (select contID, tblDETAILSCONTRACT.servicePACK, dateStart, dateDischarge from tblCONTRACTS, tblDETAILSCONTRACT" +
                " where cusID = @id AND contID = cont_ID) as A" +
                " where serID = A.servicePACK", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = idKH;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mydb.closeConnection();
            return dt;
        }
    }
}