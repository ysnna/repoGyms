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
        //}

         // Kiểm tra ID tự động xem có trùng nhau không
        public string existsPTID(string grID)
        {
            string Texti = null;
            DataTable dtcontract = new DataTable();
           
            dtcontract = emp.getexistID(grID);
            int countRowContract = dtcontract.Rows.Count;
            int i = 1;
            int j = 0;
            if (countRowContract < 10)
            {
                while (i <= countRowContract && j < countRowContract)
                {
                    Texti = "HLV0";
                    Texti += i;
                    if (Texti == dtcontract.Rows[j][0].ToString())
                    {
                        j++;
                        i++;
                    }
                    else return Texti;
                }
                if (i > countRowContract)
                {
                    Texti = "HLV0";
                    Texti += i;
                }
                return Texti;
            }
            else
            {
                i = 10;
                j = 9;
                while (i <= dtcontract.Rows.Count && j < dtcontract.Rows.Count)
                {
                    Texti = "HLV";
                    Texti += i;
                    if (Texti == dtcontract.Rows[j][0].ToString())
                    {
                        j++;
                        i++;
                    }
                    else return Texti;
                }
                if (i > countRowContract)
                {
                    Texti = "HLV";
                    Texti += i;
                }
                return Texti;
            }
        }
        public string existsEmpID(string grID)
        {
            DataTable dtcontract = new DataTable();
            dtcontract = emp.getexistID(grID);
            int countRowContract = dtcontract.Rows.Count;
            string Texti = null;
            int i = 1;
            int j = 0;
            if (countRowContract < 10)
            {
                while (i <= countRowContract && j < countRowContract)
                {
                    Texti = "NV0";
                    Texti += i;
                    if (Texti == dtcontract.Rows[j][0].ToString())
                    {
                        j++;
                        i++;
                    }
                    else return Texti;
                }
                if (i > countRowContract)
                {
                    Texti = "NV0";
                    Texti += i;
                }
                return Texti;
            }
            else
            {
                i = 10;
                j = 9;
                while (i <= dtcontract.Rows.Count && j < dtcontract.Rows.Count)
                {
                    Texti = "NV";
                    Texti += i;
                    if (Texti == dtcontract.Rows[j][0].ToString())
                    {
                        j++;
                        i++;
                    }
                    else return Texti;
                }
                if (i > countRowContract)
                {
                    Texti = "NV";
                    Texti += i;
                }
                return Texti;
            }
        }
    }
}