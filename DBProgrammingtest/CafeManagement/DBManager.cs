﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CafeManagement
{
    class DBManager
    {
        private static DBManager instace = new DBManager();
        string strConn = "Server=49.50.174.201;Database=s5414043;Uid=s5414043;Pwd=rlatjdgns12;Charset=utf8";

        public static DBManager GetInstace() { return instace; }
        private DBManager()
        {

        }

        public void Insert(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }

        }
        public string Select(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    query = string.Format("{0} : {1}", rdr["staff_id"], rdr["staff_pw"]);
                }
                rdr.Close();
                return query;

            }

        }
    }
}
