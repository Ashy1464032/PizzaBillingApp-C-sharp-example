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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bill billForm = new Bill();
            double totalCost = 0.0;
            String selectedSize = comboBox1.SelectedItem.ToString();
            String selectedTopping = comboBox2.SelectedItem.ToString();
            String selectedCrust = comboBox3.SelectedItem.ToString();
            switch (selectedSize)
            {
                case "9\u0022":
                    totalCost += 2.0;
                    break;
                case "11\u0022":
                    totalCost += 3.5;
                    break;
                case "14\u0022":
                    totalCost += 5;
                    break;
            }
            switch (selectedTopping)
            {
                case "Cheese":
                    totalCost += 1.3;
                    break;
                case "Pepperoni":
                    totalCost += 2;
                    break;
                case "Meat feast":
                    totalCost += 3.5;
                    break;
                case "Ham & pineapple":
                    totalCost += 2.5;
                    break;
            }
            switch (selectedCrust){
                case "Normal":
                    totalCost += 0.5;
                    break;
                case "Stuffed":
                    totalCost += 1;
                    break;
                case "Thin":
                    totalCost += 1;
                    break;
            }

            String total = String.Format("{0:.00}", totalCost);
            ((Label)billForm.Controls["label1"]).Text = ("Your total cost is £" + total);
            billForm.Show();
            this.Hide();
        }
    }
}
