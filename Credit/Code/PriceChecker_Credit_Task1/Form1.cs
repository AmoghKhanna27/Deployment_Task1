using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                if (price < 0)
                {
                    lblResult.Text = "Result: Please enter a valid price.";
                }
                else if (price <= 50)
                {
                    lblResult.Text = "Result: Cheap";
                }
                else if (price == 100000)
                {
                    lblResult.Text = "Result: Cheap innit";
                }
                else
                {
                    lblResult.Text = "Result: Expensive";
                }
            }
            else
            {
                lblResult.Text = "Result: Please enter a valid number.";
            }
        }
    }
}
