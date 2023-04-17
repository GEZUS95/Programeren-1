using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            //read seconds
            string input = txtseconds.Text;
            
            //string to double
            double secondsD = double.Parse(input);
            
            // tijd van string naar Timespan
            TimeSpan time = TimeSpan.FromSeconds(secondsD);

            // Timespan naar leesbare tekst
            string tijd = time.ToString(@"hh\:mm\:ss");

            //output the time
            txttime.Text = tijd;
        }
    }
}
