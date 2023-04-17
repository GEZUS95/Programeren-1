using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbloutput.ResetText();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtnum1.Text);
            int num2 = int.Parse(txtnum2.Text);

            add(num1, num2, out int result);

            lbloutput.Text= result.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtnum1.Text);
            int num2 = int.Parse(txtnum2.Text);

            sub(num1, num2, out int result);

            lbloutput.Text= result.ToString();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtnum1.Text);
            int num2 = int.Parse(txtnum2.Text);

            mult(num1, num2, out int result);

            lbloutput.Text= result.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtnum1.Text);
            double num2 = double.Parse(txtnum2.Text);

            div(num1, num2, out double result);

            lbloutput.Text = result.ToString("0.000");
        }



        static void add(int num1, int num2, out int result)
        {
            result = num1 + num2;
        }

        static void sub(int num1, int num2, out int result)
        {
            result = num1 - num2;
        }

        static void mult(int num1, int num2, out int result)
        {
            result = num1 * num2;
        }

        static void div(double num1, double num2, out double result)
        {
            result = num1 / num2;
        }




    }
}
