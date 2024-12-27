using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hotels
{
    public static class Sql_class
    {
        public const string CONNECTION_STRING =
            "SslMode=none; Server=localhost; Database=work; port=3306; uid=root; ";
        public static MySqlConnection conn;


        /// <summary>
        /// Функция селект запроса
        /// </summary>
        /// 
        public static List<string> MySelect(string cmdText)
        {
            List<string> List = new List<string>();

            MySqlCommand cmd = new MySqlCommand(cmdText, conn);
            DbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    List.Add(reader.GetString(i));
                }
            }
            reader.Close();

            return List;
        }

        /// <summary>
        /// Функция селект запроса
        /// </summary>
        /// 
        public static void MyUpDate(string cmdText)
        {
            MySqlCommand cmd = new MySqlCommand(cmdText, conn);
            DbDataReader reader = cmd.ExecuteReader();
            reader.Close();
        }


    }
}
