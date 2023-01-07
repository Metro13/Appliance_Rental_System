using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SQLite;

namespace Appliance_Rental_System
{
    internal class DBConnection
    {
        private int numrows;

        //setting up a portable mysqlite connection string
        public static string ConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        //setting up a portable query executor
        public int QueryExecuter(string query, Dictionary<string, object> args)
        {
            // database connection using Connection string from AppConfig
            using var connection = new SQLiteConnection(ConnectionString());
            connection.Open();
            using (SQLiteCommand command = new(query, connection))
            {
                foreach (var pair in args)
                {
                    command.Parameters.AddWithValue(pair.Key, pair.Value);
                }
                // execute the Query & Returning Number of Rows
                numrows = command.ExecuteNonQuery();
            }
            return numrows;
        }
    }
}
