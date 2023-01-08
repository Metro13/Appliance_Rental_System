using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliance_Rental_System
{
    internal class Administrator:User
    {
        public int AddAppliance(Dictionary<string, object> appliance)
        {
            DBConnection conn = new();

            string query = "INSERT INTO Appliance(model, brand, type, dimensions, color, energy-consumption, monthly-fee) VALUES (@model, @brand, @type, @dimensions, @color, @energyConsumption, @monthly-fee)";

            var args = new Dictionary<string, object>
            {
                {"@model", appliance["Model"]},
                {"@brand",  appliance["Brand"]},
                {"@type",  appliance["Type"]},
                {"@dimensions",  appliance["Dimensions"]},
                {"@color",  appliance["Color"]},
                {"@energyConsumption",  appliance["Consumption"]},
                {"@monthly-fee",  appliance["Monthly-Fee"]},
            };

            return conn.QueryExecuter(query, args); 

        }
    }
}
