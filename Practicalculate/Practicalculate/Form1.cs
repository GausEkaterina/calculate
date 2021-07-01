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
        private void button4_Click(object sender, EventArgs e) //кнопка умножения
        {
            if (textBox1.Text != "")
            {
                digit = double.Parse(textBox1.Text);
                textBox1.Clear();
                count = 4;
                label1.Text = digit.ToString() + "*";
                sign = true;
            }
            dot = false;
        }

        private void button8_Click(object sender, EventArgs e)//2
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button10_Click(object sender, EventArgs e)//4
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button7_Click(object sender, EventArgs e)//1
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button9_Click(object sender, EventArgs e)//3
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button11_Click(object sender, EventArgs e)//5
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button12_Click(object sender, EventArgs e)//6
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button13_Click(object sender, EventArgs e)//7
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button14_Click(object sender, EventArgs e)//8
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button15_Click(object sender, EventArgs e)//9
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button17_Click(object sender, EventArgs e)//0
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button16_Click(object sender, EventArgs e) //,
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button5_Click(object sender, EventArgs e) //кнопка сложения
        {
            if (textBox1.Text != "")
            {
                digit = double.Parse(textBox1.Text);
                textBox1.Clear();
                count = 1;
                label1.Text = digit.ToString() + "+";
                sign = true;
            }
            dot = false;
        }

        private void button19_Click(object sender, EventArgs e) //кнопка вычитания
        {
            if (textBox1.Text != "")
            {
                digit = double.Parse(textBox1.Text);
                textBox1.Clear();
                count = 2;
                label1.Text = digit.ToString() + "-";
                sign = true;
            }
            dot = false;
        }

        private void button3_Click(object sender, EventArgs e) //кнопка деления
        {
            if (textBox1.Text != "")
            {
                digit = double.Parse(textBox1.Text);
                textBox1.Clear();
                count = 3;
                label1.Text = digit.ToString() + "/";
                sign = true;
            }
            dot = false;
        }

        private void button6_Click(object sender, EventArgs e)//равно
        {
            if (textBox1.Text != "")
            {
                digit2 = double.Parse(textBox1.Text);
                calculator2 calculator = Class1.cal2(count);
                result = calculator.Calculate(digit, digit2);
            }
            textBox1.Text = result.ToString();
            dot = false;
            label1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)//удалить один элемент
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            if (text[lenght] == ',') sign = false;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
            label1.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)//знак +/-
        {
            if (sign == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                sign = false;
            }
            else if (sign == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                sign = true;
            }
            dot = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)//защита от ввода текста
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61)
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//удалить всё
        {
            textBox1.Text = "";
            label1.Text = "";
        }
    }
}
