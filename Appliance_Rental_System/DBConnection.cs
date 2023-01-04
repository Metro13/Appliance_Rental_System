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

        public string loadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public int QueryExecuter(string query, Dictionary<string, object> args)
        {

            // database connection using Connection string from AppConfig
            using (var connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand(query, connection))
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
}
