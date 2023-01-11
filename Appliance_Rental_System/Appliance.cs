using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliance_Rental_System
{
    internal class Appliance
    {
        private string? model;
        private string? brand;
        private string? applianceType;
        private string? dimensions;
        private string? color;
        private int energyConsumption;
        private int monthlyFee;


        public Appliance(string model, string brand, string applianceType, string dimensions, string color, int energyConsumption, int monthlyFee)
        {
            Model = model;
            Brand = brand;
            ApplianceType = applianceType;
            Dimensions = dimensions;
            Color = color;
            EnergyConsumption = energyConsumption;
            MonthlyFee = monthlyFee;
           
        }

        public Appliance()
        {

        }

        public string Model
        {
            get { return model!; }
            set { model = value; }
        }
        public string Brand
        {
            get { return brand!; }
            set { brand = value; }
        }
        public string ApplianceType
        {
            get { return applianceType!; }
            set { applianceType = value; }
        }
        public string Dimensions
        {
            get { return dimensions!; } 
            set { dimensions = value; }
        }

        public string Color
        {
            get { return color!; }
            set
            {
                color = value;
            }   
        }
        public int EnergyConsumption
        {
            get { return energyConsumption; }
            set { energyConsumption = value; }  
        }   

        public int MonthlyFee
        {
            get { return monthlyFee; }
            set { monthlyFee = value; }
        }


       public List<Dictionary<string, dynamic>> GetAppliances()
       {
            DBConnection connection = new();
            string conString = connection.ConnectionString();
            using var conn = new SQLiteConnection(conString);
            conn.Open();
            using var command = new SQLiteCommand("SELECT * FROM Appliance", conn);

            
            List<Dictionary<string, dynamic>> appliances = new();

            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

                Dictionary<string, dynamic> appliance = new();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    appliance.Add(reader.GetName(i), reader[i]);
                }

                appliances.Add(appliance);  

            }

            return appliances;
        }
    }
    
}
