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

        private void Form1_Load(object sender, EventArgs e)
        {
            lbloutput.ResetText(); // just for design purposes the label is filled so i need to empty it to look nice again.
        }

        private void btnSqrRef_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtinput.Text);
            SquareByReference(ref number);
            lbloutput.Text = number.ToString();
        }

        private void btnSqrRefOut_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtinput.Text);
            SquareByReferenceOut(number, out int square);
            lbloutput.Text = square.ToString();
        }

        private void btnSqrVal_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtinput.Text);
            int Square = SquareByValue(number);
            lbloutput.Text = Square.ToString();
        }

        static void SquareByReference(ref int number)
        {
            number = number * number;
        }

        static void SquareByReferenceOut(int number, out int square)
        {
            square = number * number;
        }

        static int SquareByValue(int number)
        {
            int square = number * number;
            return square;
        }
    }
}
