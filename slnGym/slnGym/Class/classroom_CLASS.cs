using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace slnGym.Class
{
    class classroom_CLASS
    {
        MY_DBClass mydb = new MY_DBClass();
        public bool insertCLASSROOM(string id, string roomnum, string teacher)
        {
            SqlCommand cmd = new SqlCommand("insert into CLASSROOM(classID,roomNum,teacher)" +
                "values (@id,@num,@teacher)", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@num", SqlDbType.VarChar).Value = roomnum;
            cmd.Parameters.Add("@teacher", SqlDbType.Int).Value = teacher;
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

        public bool deleteCLASSROOM(string ID)
        {
            SqlCommand cmd = new SqlCommand("delete from CLASSROOM where classID=@id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = ID;
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
        
        public bool updateCLASSROOM(string id, string roomnum, string teacher)
        {
            SqlCommand cmd = new SqlCommand("update CLASSROOM set classID=@id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@num", SqlDbType.VarChar).Value = roomnum;
            cmd.Parameters.Add("@teacher", SqlDbType.Int).Value = teacher;


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
        public DataTable getClassroom()
        {
            SqlCommand cmd = new SqlCommand("select *from CLASSROOM ", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable getClassroombyTeacher(string teacher)
        {
            SqlCommand cmd = new SqlCommand("select *from CLASSROOM where teacher=@teacher", mydb.getConnection);
            cmd.Parameters.Add("@teacher", SqlDbType.Int).Value = teacher;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getClassroombyRoomNum(string teacher)
        {
            SqlCommand cmd = new SqlCommand("select *from CLASSROOM where roomNum=@teacher", mydb.getConnection);
            cmd.Parameters.Add("@teacher", SqlDbType.Int).Value = teacher;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
