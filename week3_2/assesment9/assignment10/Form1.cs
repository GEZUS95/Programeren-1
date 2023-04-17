using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const double PRICE = 12;
        private void btnprice_Click(object sender, EventArgs e)
        {
            int age = Int32.Parse(txtage.Text);
            double ticketprice = 0;
            if (age < 5)
            {
                ticketprice = 0;
            }
            else if (age < 13)
            {
                ticketprice = PRICE / 2;
            }
            else if (age < 55)
            {
                ticketprice = PRICE;
            }

            txtprice.Text = ticketprice.ToString("€ 0.00");

        }
    }
}
