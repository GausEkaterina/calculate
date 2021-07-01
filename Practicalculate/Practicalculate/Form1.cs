using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicalculate
{
    public partial class Form1 : Form
    {

        double digit, digit2, result;
        int count;
        bool sign = true;
        private bool dot;
        public Form1()
        {
            InitializeComponent();
        }
        static class Class1
        {
            public static calculator2 cal2(int count)
            {
                switch (count)
                {
                    case 1:
                        return new PLUS();
                    case 2:
                        return new MINUS();
                    case 3:
                        return new DIVITION();
                    case 4:
                        return new MULTIPLY();
                    default:
                        return new PLUS();

                }

            }
        }
        interface calculator2
        {
            double Calculate(double firstValue, double secondValue);
        }
        public class PLUS : calculator2
        {
            public double Calculate(double firstValue, double secondValue)
            {
                return (firstValue + secondValue);
            }
        }
        public class MINUS : calculator2
        {
            public double Calculate(double firstValue, double secondValue)
            {
                return (firstValue - secondValue);
            }
        }
        public class DIVITION : calculator2
        {
            public double Calculate(double firstValue, double secondValue)
            {
                return (firstValue / secondValue);
            }
        }
        public class MULTIPLY : calculator2
        {
            public double Calculate(double firstValue, double secondValue)
            {
                return (firstValue * secondValue);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
