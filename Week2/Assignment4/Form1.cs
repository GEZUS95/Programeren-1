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

namespace Assignment4
{
    public partial class Form1 : Form
    {
        const double VAT = 0.21;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDetermine_Click(object sender, EventArgs e)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            // obtain input
            string invoer = txtInput.Text;
            
            //convert input to double
            double invoerD = double.Parse(invoer);
            
            //calculate double VAT
            double VATprice = invoerD * VAT;
            
            //calulate double Total
            double total = invoerD + VATprice;

            //convert to strings and put them in their boxes
            txtPrice.Text = invoerD.ToString("0.00");
            txtVAT.Text = VATprice.ToString("0.00");
            txtTotal.Text = total.ToString("0.00");


        }
    }
}
