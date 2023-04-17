using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblOutput.ResetText();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            double input = double.Parse(TxtInput.Text);
            double convertedDegrees = 0;
            if (RbtnCtF.Checked)
            {
                C2F(input, out double convertedDegrees);
            }
            else if (RbtnCtK.Checked)
            {
                C2K(input, out double convertedDegrees);
            }
            else if (RbtnFtC.Checked)
            {
                F2C(input, out double convertedDegrees);
            }

            LblOutput.Text = convertedDegrees.ToString("0.00");
        }

        static void C2F(double celsius, out double farenheit)
        {
            farenheit = celsius * 9 / 5 + 32;
        }

        static void C2K(double celsius, out double kelvin)
        {
            kelvin = celsius + 273;
        }
        static void F2C(double fahrenheit, out double celsius)
        {
            celsius = (fahrenheit - 32) * 5 / 9;
        }

    }
}
