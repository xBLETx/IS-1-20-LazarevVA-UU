﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConnectDB
{
    public class Class1
    {
        public class Con
        {
           
            static public MySqlConnection Conn1()
            {

                //string connStr = "server=10.90.12.110;port=33333;user=st_1_20_18;database=is_1_20_st18_KURS;password=54276237;";
                string connStr = "server=chuc.caseum.ru;port=33333;user=st_1_20_18;database=is_1_20_st18_KURS;password=54276237;";

                MySqlConnection connDB;

                connDB = new MySqlConnection(connStr);

                return connDB;
            }
            
        }
    }
}
