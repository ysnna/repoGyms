using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace slnGym.Layer
{
    public class AccountBL
    {
        EMPLOYEEs emp = new EMPLOYEEs();
        LOGIN lg = new LOGIN();
        User_Control.AccountEmployeeUC empUC = new User_Control.AccountEmployeeUC();
        MY_DB mydb = new MY_DB();
        //Hien thi thong tin cua nhan vien 
        public void DisplayEmp(string id)
        {
            //id = GLOBAL.username;
            DataTable empDT = new DataTable();
            empDT = emp.getEmployeebyID(id);
            if (empDT.Rows.Count > 0)
            {
                empUC.EmployeeID = empDT.Rows[0][0].ToString();
                empUC.Group = empDT.Rows[0][1].ToString();
                //empUC.Ava = empDT.Rows[0][2];
                empUC.FName = empDT.Rows[0][3].ToString();
                empUC.LName = empDT.Rows[0][4].ToString();
                empUC.BDate = empDT.Rows[0][5].ToString();
                empUC.Address = empDT.Rows[0][6].ToString();
                empUC.Gender = empDT.Rows[0][7].ToString();
                empUC.Phone = empDT.Rows[0][8].ToString();
                empUC.Salary = empDT.Rows[0][9].ToString();
                empUC.IDCard = empDT.Rows[0][10].ToString();
            }
            else MessageBox.Show("bug");
            //Show hinh anh len picture box
            //byte[] pic;
            //pic = (byte[])empDT.Rows[0]["avatar"]; //Chuyen ve dang Rawformat
            //MemoryStream picture = new MemoryStream(pic);
            //empUC.Ava = Image.FromStream(picture);
            mydb.closeConnection();
        }

        //Dang nhap = sdt
        public string checkPhone(string phone)
        {
            string empID = null;
            DataTable dt = new DataTable();
            dt = emp.getEmployeebyPhone(phone);
            if (dt.Rows.Count > 0)
            {
                empID = dt.Rows[0][0].ToString();
                return empID;
            }
            else return empID;
        }
    }
}