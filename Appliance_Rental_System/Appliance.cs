using System;
using System.Collections.Generic;
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
    }
}
