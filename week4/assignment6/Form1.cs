using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double RATE = 0.05;

        private void btncalc_Click(object sender, EventArgs e)
        {
            double invoer = double.Parse(txtstart.Text);
            double money = invoer;
            double interest = 0;
            for (int i = 0; i < 5; i++)
            {
                interest = money * RATE;
                money += interest; 
            }
            string uitvoer = money.ToString("€0.00");
            txtfinal.Text = uitvoer;
        }
    }
}
