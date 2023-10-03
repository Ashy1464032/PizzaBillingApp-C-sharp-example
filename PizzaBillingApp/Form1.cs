using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaBillingApp
{
    public static class Billing
    {
        public static double totalCost = 0.00;

    }
    public partial class Form1 : Form
    {
        Bill billForm = new Bill();
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String selectedSize = comboBox1.SelectedItem.ToString();
            String selectedTopping = comboBox2.SelectedItem.ToString();
            String selectedCrust = comboBox3.SelectedItem.ToString();
            switch (selectedSize)
            {
                case "9\u0022":
                    Billing.totalCost += 2.0;
                    break;
                case "11\u0022":
                    Billing.totalCost += 3.5;
                    break;
                case "14\u0022":
                    Billing.totalCost += 5;
                    break;
            }
            switch (selectedTopping)
            {
                case "Cheese":
                    Billing.totalCost += 1.3;
                    break;
                case "Pepperoni":
                    Billing.totalCost += 2;
                    break;
                case "Meat feast":
                    Billing.totalCost += 3.5;
                    break;
                case "Ham & pineapple":
                    Billing.totalCost += 2.5;
                    break;
            }
            switch (selectedCrust){
                case "Normal":
                    Billing.totalCost += 0.5;
                    break;
                case "Stuffed":
                    Billing.totalCost += 1;
                    break;
                case "Thin":
                    Billing.totalCost += 1;
                    break;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            billForm.Show();
            this.Hide();
        }
    }
}
