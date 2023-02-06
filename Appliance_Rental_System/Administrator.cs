using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliance_Rental_System
{
    internal class Administrator:User
    {
        DBConnection conn = new();
        public int AddAppliance(Dictionary<string, object> appliance)
        {
            string query = "INSERT INTO Appliance (model, brand, type, dimensions, color, energyConsumption, monthlyFee) VALUES (@model, @brand, @type, @dimensions, @color, @energyConsumption, @monthlyfee)";

            var QueryArgs = new Dictionary<string, object>
            {
                {"@model", appliance["Model"]},
                {"@brand",  appliance["Brand"]},
                {"@type",  appliance["Type"]},
                {"@dimensions",  appliance["Dimensions"]},
                {"@color",  appliance["Color"]},
                {"@energyConsumption",  appliance["Consumption"]},
                {"@monthlyfee",  appliance["Monthly-Fee"]},
            };

            return conn.QueryExecuter(query, QueryArgs); 
        }

        public int DeleteAppliance(string applianceModel)
        {
            string query = "DELETE FROM Appliance WHERE model=@mode";
            var QueryArgs = new Dictionary<string, object>
            {
                {"@mode",  applianceModel },
            };
            return conn.QueryExecuter(query, QueryArgs);    
        }

        public int UpdateAppliance(Dictionary<string, object> updatedApplianceData)
        {
            string query = "UPDATE Appliance SET model=@model, brand=@brand, type=@type, dimensions=@dimensions, color=@color, energyConsumption=@consumption, monthlyFee=@monthlyfee WHERE model=@model";

            var QueryArgs = new Dictionary<string, object>
            {
                {"@model", updatedApplianceData["Model"]  },
                {"@brand", updatedApplianceData["Brand"]  },
                {"@type", updatedApplianceData["Type"]  },
                {"@dimensions", updatedApplianceData["Dimensions"]  },
                {"@color", updatedApplianceData["Color"]  },
                {"@consumption", updatedApplianceData["consumption"] },
                {"@monthlyfee", updatedApplianceData["MonthlyFee"]  },
            };
            return conn.QueryExecuter(query, QueryArgs);
           
        }
    }
}
