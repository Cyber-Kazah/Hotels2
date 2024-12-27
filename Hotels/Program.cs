using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotels
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Sql_class.conn = new MySqlConnection(Sql_class.CONNECTION_STRING);
            Sql_class.conn.Open();

            Application.Run(new Form1());

            Sql_class.conn.Close();
        }
    }
}
