using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opgave5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbltxtresterend.ResetText();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int dag = int.Parse(txtdag.Text);
            int maand = int.Parse(txtmaand.Text);
            int jaar = int.Parse(txtjaar.Text);
            int dagen = 0;

            switch (maand)
            {
                case 1:
                    dagen = 31;
                    break;
                case 2:
                    if (IsLeapYear(jaar) == true)
                    {
                        dagen = 29;
                    }
                    else { dagen = 28; }
                    break;
                case 3:
                    dagen = 31;
                    break;
                case 4:
                    dagen = 30;
                    break;
                case 5:
                    dagen = 31;
                    break;
                case 6:
                    dagen = 30;
                    break;
                case 7:
                    dagen = 31;
                    break;
                case 8:
                    dagen = 31;
                    break;
                case 9:
                    dagen = 30;
                    break;
                case 10:
                    dagen = 31;
                    break;
                case 11:
                    dagen = 30;
                    break;
                case 12:
                    dagen = 31;
                    break;
            }

            int resterend = dagen - dag + 1;
            lbltxtresterend.Text = resterend.ToString();
        }

        static bool IsLeapYear(int year)
        {

            bool deelDoor400 = ((year % 400) == 0);
            bool deelDoor100 = ((year % 100) == 0);
            bool deelDoor4 = ((year % 4) == 0);

            return (deelDoor400 || (deelDoor4 && !deelDoor100));

        }

    }
}
