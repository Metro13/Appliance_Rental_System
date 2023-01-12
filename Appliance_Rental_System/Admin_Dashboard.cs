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
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void cmdAddAppliance_Click(object sender, EventArgs e)
        {
            Add_Appliances _Appliances = new();
            _Appliances.Show();
            Hide();
        }

        private void CmdManageAppliances_Click(object sender, EventArgs e)
        {
            Manage_Appliances manage_ = new();
            manage_.Show();
            Hide();
        }
    }
}
