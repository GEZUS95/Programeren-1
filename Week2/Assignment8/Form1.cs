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

namespace Assignment8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const double VAT = 0.21;
        const double PRICEPERSHIRT = 30.00;
        const double PRICEPERJEAN = 100.00;

        private void btncalculate_Click(object sender, EventArgs e)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            //get the amount of shirts and jeans
            int numshirt = Convert.ToInt32(txtnumshirt.Text);
            int numjean = Convert.ToInt32(txtnumjean.Text);

            //get the date
            DateTime localdate = DateTime.Now;

            //calculate prices
            double priceshirts = numshirt * PRICEPERSHIRT;
            double pricejeans = numjean * PRICEPERJEAN;
            double subtotal = priceshirts + pricejeans;
            double priceVAT = subtotal * VAT;
            double total = subtotal + priceVAT;

            //convert to strings
            string date = localdate.ToString(@"hh\:mm\:ss dd/mm/yyyy");
            string subtotalS = subtotal.ToString("€ 0.00");
            string priceVATS = priceVAT.ToString("€ 0.00");
            string totalS = total.ToString("€ 0.00");

            //output the prices
            txtdate.Text = date;
            txtpriceexcl.Text = subtotalS;
            txtvat.Text = priceVATS;
            txttotal.Text = totalS;
            
        }
    }
}
