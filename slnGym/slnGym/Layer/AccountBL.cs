using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using slnGym.Class;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace slnGym.Layer
{
    class AccountBL
    {
        EMPLOYEEs emp = new EMPLOYEEs();
        LOGIN lg = new LOGIN();
        User_Control.AccountEmployeeUC empUC = new User_Control.AccountEmployeeUC();

        //Hien thi thong tin cua nhan vien 
        public void DisplayEmp(string id)
        {
                DataTable empDT = new DataTable();           
                empDT = emp.getEmployeebyID(id);
            //empUC.FName = empDT.Rows[0][3].ToString();
            empUC.FName = "lolololololo";
            empUC.LName = empDT.Rows[0][4].ToString();
                empUC.BDate = empDT.Rows[0][5].ToString();
                empUC.Address = empDT.Rows[0][6].ToString();
                empUC.Gender = empDT.Rows[0][7].ToString();
                empUC.Phone = empDT.Rows[0][8].ToString();
                empUC.Salary = empDT.Rows[0][9].ToString();
                empUC.IDCard = empDT.Rows[0][10].ToString();
                
                //Show hinh anh len picture box
                //byte[] pic;
                //pic = (byte[])empDT.Rows[0]["avatar"]; //Chuyen ve dang Rawformat
                //MemoryStream picture = new MemoryStream(pic);
                //empUC.Ava = Image.FromStream(picture);

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
