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
        int[] ELEMENTS = new int[20];
        private void Form1_Load(object sender, EventArgs e)
        {
            //int[] elements = new int[20];
            Random rand = new Random();
            lbltxtbefore.Text = "";
            lbltxtafter.Text = "";
            for (int i = 0; i < ELEMENTS.Length; i++)
            {
                int randNum = rand.Next(0, 500);
                ELEMENTS[i] = randNum;
                lbltxtbefore.Text += String.Format("Element {0:00} = {1} \n", i, ELEMENTS[i]);
            }
        }

        private void btncompair_Click(object sender, EventArgs e)
        {
            btncompair.Enabled = false;
            int compnum = int.Parse(txtcompairnum.Text);

            for (int j = 0; j < ELEMENTS.Length; j++)
            {
                if (ELEMENTS[j] >= compnum)
                {
                    ELEMENTS[j] = ELEMENTS[j] + 10;
                }
                else if (ELEMENTS[j] < compnum)
                {
                    ELEMENTS[j] = ELEMENTS[j] - 5;
                }

                lbltxtafter.Text += String.Format("Element {0:00} = {1} \n", j, ELEMENTS[j]);
            }

        }
    }
}
