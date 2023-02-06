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
    public class User : IUser
    {
        private string? firstname;
        private string? lastname;
        private string? password;
        private string? username;
        private string? contact;

        public string Firstname 
        {
            set{ firstname = value;}
            get{ return firstname!;}
        }
        public string Lastname 
        { 
            set { lastname = value; }
            get { return lastname!; }
        }
        public string Username
        { set { username = value; } 
            get{ return username!; }
        }
        public string Password 
        { 
            set { password = value; }
            get
            {
                return password!;
            }   
        }

        public string Contact
        {
            set { contact = value; }
            get { return contact!; }
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
                using var reader = command.ExecuteReader();
                var count = 0;
                while (reader.Read())
                {
                    count++;
                }
                return count;
            }
            else
            {
                return 0;
            }
        }
        public int SignUpUser(Dictionary<string, object> userdata)
        {
            //setting up database connection

            DBConnection connection = new();

            const string query = "INSERT INTO Users(username, firstname,  lastname, contact, password) VALUES (@username, @firstname, @lastname, @contact, @password)";

            var args = new Dictionary<string, object>
            {
                {"@firstname", userdata["Firstname"]},
                {"@lastname", userdata["Lastname"]},
                {"@username", userdata["Username"]},
                {"@password", userdata["Password"]},
                {"@contact", userdata["Contact"]},
            };

            //running a query executor helper function 

            return connection.QueryExecuter(query, args);
        }

        //checks the input password and check if it contains atleast number, uppercase and lowercase values
        public bool PasswordCaseValidator(string password)
        {
            //regex expression

            if(Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //checks the input password and checks if its 8 digits long
        public bool PasswordLengthValidator(string password)
        {
            if (password.Length < 8 || password.Length >= 16)
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
