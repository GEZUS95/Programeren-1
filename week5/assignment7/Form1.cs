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

        private void btnthrow_Click(object sender, EventArgs e)
        {
            int[] dice = new int[6] { 0, 0, 0, 0, 0, 0 };
            Random rand = new Random();
            

                for (int i = 0; i < 6000; i++)
                {
                    int x = (rand.Next(1, 7) - 1);
                    dice[x]++;
                }
            for (int j = 0; j < dice.Length; j++)
            {
                int y = j + 1;
                lbldice.Text += String.Format("Number of throws of value {0} = {1} \n", y, dice[j]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbldice.Text = "";
        }
    }
}
