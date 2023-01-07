namespace Appliance_Rental_System
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }
        private void CmdProceed_Click(object sender, EventArgs e)
        {
            registration registration = new();
            registration.Show();
            Hide(); 
        }
    }
}