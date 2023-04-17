using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace Assignment7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double VAT = 0.21;
        private void btncalc_Click(object sender, EventArgs e)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            // get and convert start / end / km price
            double start = Double.Parse(txtstart.Text);
            double end = Double.Parse(txtend.Text);
            double price = Double.Parse(txtprice.Text);

            //calculate the driven km
            double drivenkm = end - start;

            //calculate price
            double priceexcl = drivenkm * price;
            double vatprice = priceexcl * VAT;
            double priceincl = priceexcl + vatprice;

            //convert those lovely doubles to strings
            string Spriceexcl = priceexcl.ToString("0.00");
            string Svatprice = vatprice.ToString("0.00");
            string Spriceincl = priceincl.ToString("0.00");

            // generate output
            txtpriceexcl.Text = Spriceexcl;
            txtvat.Text = Svatprice;
            txtpriceincl.Text = Spriceincl;

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtend.Text = string.Empty;
            txtprice.Text = string.Empty;
            txtpriceexcl.Text = string.Empty;
            txtpriceincl.Text = string.Empty;
            txtstart.Text = string.Empty;
            txtvat.Text = string.Empty;
        }
    }
}
