using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            string num1 = txtnum1.Text;
            string num2 = txtnum2.Text;
            string num3 = txtnum3.Text;

            double num1D = double.Parse(num1);
            double num2D = double.Parse(num2);
            double num3D = double.Parse(num3);

            double result = (num1D + num2D + num3D) / 3;

            string resultS = result.ToString("0.000");

            txtaverage.Text = resultS;
        }
    }
}
