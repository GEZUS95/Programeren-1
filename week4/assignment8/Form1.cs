using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncompare_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtnumber.Text);


            int sum = 1;
            int formulasum = n * (n + 1) / 2;

            while ((sum < n)||(sum<formulasum))
            {
                sum++;
            }


            txtformula.Text = formulasum.ToString();
            txtsum.Text = sum.ToString();

            if (sum == formulasum)
            {
                txtequal.Text = "The sum and formula are equal.";
            }
            else
            {
                txtequal.Text = "The sum and formula are not equal";
            }

        }
    }
}
