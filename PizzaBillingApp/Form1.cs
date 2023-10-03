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
        public static double TotalCost;
        Bill billForm = new Bill();
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String selectedSize = comboBox1.SelectedItem.ToString();
            String selectedTopping = comboBox2.SelectedItem.ToString();
            String selectedCrust = comboBox3.SelectedItem.ToString();
            switch (selectedSize)
            {
                case "9\u0022":
                    TotalCost += 2.0;
                    break;
                case "11\u0022":
                    TotalCost += 3.5;
                    break;
                case "14\u0022":
                    TotalCost += 5;
                    break;
            }
            switch (selectedTopping)
            {
                case "Cheese":
                    TotalCost += 1.3;
                    break;
                case "Pepperoni":
                    TotalCost += 2;
                    break;
                case "Meat feast":
                    TotalCost += 3.5;
                    break;
                case "Ham & pineapple":
                    TotalCost += 2.5;
                    break;
            }
            switch (selectedCrust){
                case "Normal":
                    TotalCost += 0.5;
                    break;
                case "Stuffed":
                    TotalCost += 1;
                    break;
                case "Thin":
                    TotalCost += 1;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String km = String.Format("{0:.00}", TotalCost);
            ((Label)billForm.Controls["label1"]).Text = ("Your total cost is £" + km);
            billForm.Show();
            this.Hide();
        }
    }
}
