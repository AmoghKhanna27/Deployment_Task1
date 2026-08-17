using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PricingLogic;
using PriceFormatter;

namespace PriceChecker_Credit_Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttn_categorize_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtPrice.Text, out decimal price))
            {
                PricingClassifier classifier = new PricingClassifier();
                CurrencyFormatter formatter = new CurrencyFormatter();

                string category = classifier.Categorize(price);
                string formattedPrice = formatter.FormatPrice(price);

                lblResult.Text = "Result: " + formattedPrice + " is " + category;
            }
            else
            {
                lblResult.Text = "Result: Please enter a valid number.";
            }
        }
    }
}
