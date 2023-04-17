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

        const string STER = "X";
        const string SPATIE = " ";
        const string NIEUWE_REGEL = "\n";

        private void btncreate_Click(object sender, EventArgs e)
        {
            int zijde = int.Parse(txtnum.Text);
            string uitvoer = "";
            for (int rij = 1; rij <= zijde; rij++)
            {
                for (int kolom = 1; kolom <= zijde; kolom++)
                {
                    if ((rij == 1) || (rij == zijde) || (kolom == 1) || (kolom == zijde))
                    {
                        uitvoer = uitvoer + STER;
                    }
                    else 
                    {
                        uitvoer = uitvoer + SPATIE;
                    }
                }

                uitvoer = uitvoer + NIEUWE_REGEL;
            }

            lbloutput.Text = uitvoer;

        }
    }
}
