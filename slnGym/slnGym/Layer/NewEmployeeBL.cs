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
        public int randomNext(int a, int b)
        {
            Random random = new Random();
            return random.Next(a, b);
        }
    }
}