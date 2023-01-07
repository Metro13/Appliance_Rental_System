using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliance_Rental_System
{
    // a authentication interface to abstract the user methods implementation
    public interface IAuthentication
    {
        string Firstname { get; set; }
        string Lastname { get; set ;  }
        string Username { get; set ; }
        string Password { get; set; }
        string Contact { get; set; }

        int SignInUser(Dictionary<string, object> authdata);
        bool PasswordCaseValidator(string password);
        bool PasswordLengthValidator(string password);
        int SignUpUser(Dictionary<string, object> userdata);
    }
}
