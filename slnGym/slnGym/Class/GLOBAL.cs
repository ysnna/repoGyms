﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnGym
{
        static class GLOBAL
        {
            //Lấy ID khách hàng
            public static string IDKH = "";
            public static string getID(string id)
            {
                IDKH = id;
                return IDKH;
            }
            //Lấy username
            public static string username = "";
            public static string GetUsername(string user)
            {
                username = user;
                return username;
            }

        }
    }