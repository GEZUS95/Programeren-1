using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assesment9
{
    public partial class Form1 : Form
    {
        const double FEEFOOTBALL = 175;
        const double FEEHANDBALL = 225;
        const double AGEDISC = 25;
        const double MEMDISC = 20;
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            double fee = 0;
            if (rbfootball.Checked == true)
            {
                fee = FEEFOOTBALL;
            }
            
            if (rbhandbal.Checked == true)
            {
                fee = FEEHANDBALL;
            }

            // collect age and membership duration
            int age = Int32.Parse(txtage.Text);
            int memduration = Int32.Parse(txtmembership.Text);

            if (age > 40)
            {
                fee = fee - AGEDISC;
            }
            if (memduration > 10)
            {
                fee = fee - MEMDISC;
            }

            txtfee.Text = fee.ToString("€ 0.00");
        }
    }
}
