using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliance_Rental_System
{
    internal class User:IAuthentication
    {
        public string Firstname { get => Firstname; set { Firstname = value; } }
        public string Lastname { get => Lastname;  set { Lastname = value; } }
        public string Username { get => Username; set { Lastname = value; } }
        public string Password { get => Password; set { Password = value; } }

        DBConnection conn = new DBConnection();
        public int SignInUser(Dictionary<string, object> authdata)
        {
            using var conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString);
            conn.Open();
            using var command = new SQLiteCommand("SELECT username, password FROM Users WHERE username=@username AND password=@password", conn);
            if (authdata != null)
            {
                command.Parameters.Add(new SQLiteParameter("@username", authdata["Username"]));
                command.Parameters.Add(new SQLiteParameter("@password", authdata["Password"]));
            }
            else
            {
                //if 2 is returned it means the auth data is null
                return 2;
            }

            using var reader = command.ExecuteReader();
            var count = 0;
            while (reader.Read())
            {
                count++;
            }
            return count;

        }

    }
}
