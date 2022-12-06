using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clientчето_там
{
    public static class sql
    {
        public const string connection_string = "SslMode=none;Server=localhost;Database=schedule;Uid=root;";
        public static MySqlConnection CONN;

        public static void Update(string cmdText)
        {
            MySqlCommand cmd = new MySqlCommand(cmdText, CONN);
            DbDataReader reader = cmd.ExecuteReader();
            reader.Close();
        }
        public static List<string> Select(string cmdtext)
        {
            List<string> list = new List<string>();

            MySqlCommand cmd = new MySqlCommand(cmdtext, CONN);
            DbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    list.Add(reader.GetValue(i).ToString());
                }

            }
            reader.Close();

            return list;
        }
    }
}
