using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clientчето_там
{
    
    internal static class Program
    {
        public const string connection_string = "SslMode=none;Server=localhost;Database=schedule;Uid=root;";
        public static MySqlConnection CONN;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CONN = new MySqlConnection(connection_string);
            CONN.Open();

            Application.Run(new main());

            CONN.Close();
        }
    }
}
