using System;
using System.Windows.Forms;

namespace PizzaBillingApp
{
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your payment has been processed", "ASHTONS PERFECTED PIZZA");
            Application.Exit();
        }
    }
}