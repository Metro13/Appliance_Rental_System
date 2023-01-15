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
    public partial class Manage_Appliances : Form
    {
        List<Dictionary<string, object>> myAppliances = new();
        Appliance appliance = new();
        Administrator admin = new();
    
        public Manage_Appliances()
        {
            InitializeComponent();
        }

        private void Manage_Appliances_Load(object sender, EventArgs e)
        {
            manageAppliancePanel.Visible = false;
            UpdateDataTable();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            manageAppliancePanel.Visible = true;
            int RowIndex = e.RowIndex;
            

            DataGridViewRow row = dataGridView1.Rows[RowIndex];

            TxtModel.Text = row.Cells[0].Value.ToString();
            TxtBrand.Text = row.Cells[1].Value.ToString();
            TxtApplianceType.Text = row.Cells[2].Value.ToString();
            TxtDimensions.Text = row.Cells[3].Value.ToString();
            TxtColor.Text = row.Cells[4].Value.ToString();
            TxtEnergyConsumption.Text = row.Cells[5].Value.ToString();  
            TxtMonthlyFee.Text = row.Cells[6].Value.ToString();
        }

        private void UpdateDataTable()
        {
            myAppliances = appliance.GetAppliances();
            dataGridView1.DataSource = appliance.ParseDictionaryToDataTable(myAppliances);
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            int energyconsumption = 0;
            int monthlyfee = 0;

            if (string.IsNullOrEmpty(TxtModel.Text))
            {
                MessageBox.Show("Please model field can't be empty");
            }
            else if (string.IsNullOrEmpty(TxtBrand.Text))
            {
                MessageBox.Show("Please model field can't be empty");
            }
            else if (string.IsNullOrEmpty(TxtApplianceType.Text))
            {
                MessageBox.Show("Please Appliance Type field can't be empty");
            }
            else if (string.IsNullOrEmpty(TxtDimensions.Text))
            {
                MessageBox.Show("Please Dimensions field can't be empty");
            }
            else if (string.IsNullOrEmpty(TxtColor.Text))
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
                energyconsumption = int.Parse(TxtEnergyConsumption.Text);
                monthlyfee = int.Parse(TxtMonthlyFee.Text);

                var applianceData = new Dictionary<string, object>

                {
                     {"Model", TxtModel.Text},
                     {"Brand", TxtBrand.Text},
                     {"Type", TxtApplianceType.Text},
                     {"Dimensions", TxtDimensions.Text},
                     {"Color", TxtColor.Text},
                     {"consumption", energyconsumption},
                     {"MonthlyFee", monthlyfee},
                };

                int result = admin.UpdateAppliance(applianceData);

                if(result >= 1)
                {
                    MessageBox.Show("Item has been updated");
                    UpdateDataTable();
                    manageAppliancePanel.Visible = false;
                }
                else
                {
                    MessageBox.Show("Couldn't update item, check your details");
                }
            }
        }
        private void CmdDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete?","Message", MessageBoxButtons.YesNo ) ==  DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(TxtModel.Text))
                {
                    MessageBox.Show("Cannot delete item because the model is empty");
                }
                else
                {
                    int result = admin.DeleteAppliance(TxtModel.Text);

                    if(result >= 1)
                    {
                        MessageBox.Show("Item Deleted");
                        UpdateDataTable();
                        manageAppliancePanel.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the item");
                    }       
                }
            }
            else
            {
                return;
            }
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            manageAppliancePanel.Visible = false;
        }

        private void cmdGetBack_Click(object sender, EventArgs e)
        {
            Admin_Dashboard _Dashboard = new();
            _Dashboard.Show();
            Hide();
        }
    }
}
