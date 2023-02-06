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
    public partial class Add_Appliances : Form
    {
        public Add_Appliances()
        {
            InitializeComponent();
        }

        private void cmdAddAppliance_Click(object sender, EventArgs e)
        {
            Appliance appliance = new()
            {
                Brand = TxtBrand.Text,
                Model = TxtModel.Text,
                ApplianceType = TxtApplianceType.Text,
                Color = TxtColor.Text,
                MonthlyFee = int.Parse(TxtMonthlyFee.Text),
                Dimensions = TxtDimensions.Text,
                EnergyConsumption = int.Parse(TxtEnergyConsumption.Text),

            };

            if (string.IsNullOrEmpty(appliance.Model))
            {
                MessageBox.Show("Please model field can't be empty");
            }
            else if (string.IsNullOrEmpty(appliance.Brand))
            {
                MessageBox.Show("Please brand field can't be empty");
            }
            else if (string.IsNullOrEmpty(appliance.ApplianceType))
            {
                MessageBox.Show("Please Appliance Type field can't be empty");
            }
            else if (string.IsNullOrEmpty(appliance.Dimensions))
            {
                MessageBox.Show("Please Dimensions field can't be empty");
            }
            else if (string.IsNullOrEmpty(appliance.Color))
            {
                MessageBox.Show("Please Color field can't be empty");
            }
            else if (string.IsNullOrEmpty(TxtMonthlyFee.Text))
            {
                MessageBox.Show("Please monthly fee field can't be empty");
            }
            else if (string.IsNullOrEmpty(TxtEnergyConsumption.Text))
            {
                MessageBox.Show("Please energy consumption field can't be empty");
            }
            else
            {
                Administrator admin = new();

                // pairing user form data to a managed dictionary
                var applianceData = new Dictionary<string, object>

                {
                     {"Model", appliance.Model},
                     {"Brand", appliance.Brand},
                     {"Type", appliance.ApplianceType},
                     {"Dimensions", appliance.Dimensions},
                     {"Color", appliance.Color},
                     {"Consumption", appliance.EnergyConsumption},
                     {"Monthly-Fee", appliance.MonthlyFee},
                };

                int result = admin.AddAppliance(applianceData);

                if (result == 0)
                {
                    MessageBox.Show("Failed to add appliances. Try again later");
                }
                else
                {
                    MessageBox.Show("Added Applianced successful");
                }
            }
        }
    }
}
