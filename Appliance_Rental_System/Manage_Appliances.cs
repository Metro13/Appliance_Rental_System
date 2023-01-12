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
        public Manage_Appliances()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

            
        }

        private void Manage_Appliances_Load(object sender, EventArgs e)
        {
            List<Dictionary<string, object>> myAppliances = new();
            Appliance appliance = new();
            myAppliances = appliance.GetAppliances();

            dataGridView1.DataSource = appliance.ParseDictionaryToDataTable(myAppliances);
        }
    }
}
