using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliance_Rental_System
{
    internal interface IAuthentication
    {
        string Firstname { get => Firstname; set { Firstname = value; } }
        string Lastname { get => Lastname; set { Lastname = value; } }
        string Username { get => Username; set { Lastname = value; } }
        string Password { get => Password; set { Password = value; } }
    }
}
