using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace slnGym.Layer
{
    public class NewEmployeeBL
    {
        LOGIN lg = new LOGIN();
        EMPLOYEEs emp = new EMPLOYEEs();
        User_Control.NewEmployeeUC empUC = new User_Control.NewEmployeeUC();
        //Hàm xử lý tạo mật khẩu tự động cho nhân viên
        public string SetPass()
        {
            string pass;
            pass = "nv" + randomNext(100, 999).ToString();
            return pass;
        }
        public string SetPassPT()
        {
            string pass;
            pass = "hlv" + randomNext(100, 999).ToString();
            return pass;
        }
        public int randomNext(int a, int b)
        {
            Random random = new Random();
            return random.Next(a, b);
        }
        //public string UserName()
        //{
        //    int count = 1;
        //    string username;
        //    DataTable dt = new DataTable();
        //    dt = emp.getAllEMPLOYEE();
        //    count += dt.Rows.Count;
        //    username = "nv" + count;
        //    return username;
        //} XÓA
        public string existsEmpID(string grID)
        {
            DataTable dt = new DataTable();
            dt = emp.getexistID(grID);
            string check= null;
            int i = 1;
            int j = 0;
            while (i<=dt.Rows.Count && j < dt.Rows.Count)
            {
                    check = "nv";
                    check += i;
                    if (check == dt.Rows[j][0].ToString())
                    {
                        j++;
                        i++;
                    }
                    else 
                    return check;
            }
            if (i > dt.Rows.Count)
            {
                check = "nv";
                check += i;
            }
            return check;
        }

        public string existsPTID(string grID)
        {
            DataTable dt = new DataTable();
            dt = emp.getexistID(grID);
            string check = null;
            int i = 1;
            int j = 0;
            while (i <= dt.Rows.Count  && j < dt.Rows.Count)
            {
                check = "hlv";
                check += i;
                if (check == dt.Rows[j][0].ToString())
                {
                    j++;
                    i++;
                }
                else return check;
            }
            if (i > dt.Rows.Count)
            {
                check = "hlv";
                check += i;
            }
            return check;
           
        }

    }
}