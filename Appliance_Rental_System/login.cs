using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appliance_Rental_System
{
    public partial class login : Form
    {
        int MaxloginAttempts = 3;

        public login()
        {
            InitializeComponent();
        }


        //User authentication
        private void CmdSignin_Click(object sender, EventArgs e)
        {
            //setting up User class and interface attributes to the actual data input fiedls

            IAuthentication authentication = new User
            {
                Username = TxtUsername.Text,
                Password = TxtPassword.Text,
            };

            //validating empty fields to avoid null types
            if (string.IsNullOrEmpty(authentication.Username))
            {
                MessageBox.Show("Please username field can't be empty");
            }
            else if (string.IsNullOrEmpty(authentication.Password))
            {
                MessageBox.Show("Please password field can't be empty");
            }
            else
            {
                //pairing the attributes to a portable dictionary for easy management 

                var authData = new Dictionary<string, object>
                   {
                        {"Username", authentication.Username},
                        {"Password", authentication.Password},
                   };

                int NumberOfRows = authentication.SignInUser(authData);

                //checking the number of rows affected when the query runs and also checking login attempts

                if (NumberOfRows == 0 && MaxloginAttempts != 0)
                {
                    MessageBox.Show("Username & Password Incorrect");
                    MaxloginAttempts--;

                    if (MaxloginAttempts == 0)
                    {
                        MessageBox.Show("Maximum password attempts reached. Try loggin in later");
                        MaxloginAttempts = 0;
                    }
                }
                else if (NumberOfRows == 1 && MaxloginAttempts != 0)
                {
                    MessageBox.Show("Authentication Successfull!");
                    Dashboard dashboard = new();
                    dashboard.Show();
                    Hide();

                }
            }
        }
    }
}
