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
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }

        private void registration_Load(object sender, EventArgs e)
        {

        }

        private void CmdSignUp_Click(object sender, EventArgs e)
        {
            //initializing the user details to work with the Interface constructor

            IUser auth = new User
            {
                Firstname = TxtFirstname.Text,
                Lastname = TxtLastname.Text,
                Username = TxtUsername.Text,
                Password = TxtPassword.Text,
                Contact = TxtContactNumber.Text,
            };

            //validating empty fields before submission

            if (string.IsNullOrEmpty(auth.Firstname))
            {
                MessageBox.Show("Please firstname field can't be empty");
            }
            else if (string.IsNullOrEmpty(auth.Lastname))
            {
                MessageBox.Show("Please lastname field can't be empty");
            }
            else if (string.IsNullOrEmpty(auth.Username))
            {
                MessageBox.Show("Please username field can't be empty");
            }
            else if (string.IsNullOrEmpty(auth.Contact))
            {
                MessageBox.Show("Please contact field can't be empty");
            }
            else if (string.IsNullOrEmpty(auth.Password))
            {
                MessageBox.Show("Please lastname field can't be empty");
            }
            else
            {
                //validating password case requirements
                if (auth.PasswordCaseValidator(auth.Password))
                {
                    //validating password lenth
                    if(auth.PasswordLengthValidator(auth.Password))
                    {
                        // pairing user form data to a managed dictionary
                        var userData = new Dictionary<string, object>
                        {
                            {"Firstname", auth.Firstname},
                            {"Lastname", auth.Lastname},
                            {"Username", auth.Username},
                            {"Contact", auth.Contact},
                            {"Password", auth.Password},
                        };

                        int queryResult = auth.SignUpUser(userData);

                        if (queryResult == 0)
                        {
                            MessageBox.Show("Ooops! Failed to create user check details or try again late");
                        }
                        else
                        {
                            MessageBox.Show("User account created successfull");
                            login login = new();
                            login.Show();
                            Hide();
                        }

                    }
                    else
                    {
                        MessageBox.Show("cannot proceed passwords should not be less than 8 and not more that 16 characters");
                    }
                }
                else
                {
                    MessageBox.Show("Please include atlease one uppercase, lowercase and number in your password");
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
         
           login login = new();
           login.Show();
           Hide();
        }
    }
}
