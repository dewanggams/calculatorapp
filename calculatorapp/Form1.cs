using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int pengurangan(int a, int b)
        {
            return a - b;
        }
        static int pembagian(int a, int b)
        {
            return a / b;
        }
        static int perkalian(int a, int b)
        {
            return a * b;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btnhitung_Click_1(object sender, EventArgs e)
        {
            int a = int.Parse(txtnilaia.Text);
            int b = int.Parse(txtnilaib.Text);
            double c;

            switch (box.SelectedIndex)
            {
                case 0:
                    c = a + b;
                    hasil.Text = Convert.ToString(c);
                    break;

                case 1:
                    c = a - b;
                    hasil.Text = Convert.ToString(c);
                    break;

                case 2:
                    c = a * b;
                    hasil.Text = Convert.ToString(c);
                    break;

                case 3:
                    c = a / b;
                    hasil.Text = Convert.ToString(c);
                    break;
            }

        }
    }
}
