using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Appliance_Rental_System
{
    public class User : IAuthentication
    {
        private string firstname;
        private string lastname;
        private string password;
        private string username;

        public string Firstname 
        {
            set{ firstname = value;}
            get{ return firstname;}
        }
        public string Lastname 
        { 
            set { lastname = value; }
            get { return lastname; }
        }
        public string Username
        { set { username = value; } 
            get{ return username; }
        }
        public string Password 
        { 
            set { password = value; }
            get
            {
                return password;
            }   
        }

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

            using var reader = command.ExecuteReader();
            var count = 0;
            while (reader.Read())
            {
                count++;
            }
            return count;

        }

        public bool PasswordCaseValidator(string password)
        {
            if(Regex.IsMatch(password, "^(?=.*[a-z])(?=.*[A-Z]).+$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool PasswordLengthValidator(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
