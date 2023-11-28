using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace 678
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 5;
            label4.Text = "sin" + a.ToString();
            znak = true;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        double a, b;
        int count;
        bool znak = true;
        private void button14_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            label4.Text = a.ToString() + "+";
            znak = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            calculate();
            label4.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            label4.Text = a.ToString() + "-";
            znak = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            label4.Text = a.ToString() + "*";
            znak = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label4.Text = a.ToString() + "/";
            znak = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 6;
            label4.Text = "cos" + a.ToString();
            znak = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 7;
            label4.Text = "tg" + a.ToString();
            znak = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 8;
            label4.Text = "log" + a.ToString();
            znak = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 9;
            label4.Text = "ln" + a.ToString();
            znak = true;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 10;
            label4.Text = "exp" + a.ToString();
            znak = true;
        }

        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + double.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - double.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * double.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / double.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 5:
                    a = Math.Sin(a);
                    textBox1.Text = a.ToString();
                    break;
                case 6:
                    a = Math.Cos(a);
                    textBox1.Text = a.ToString();
                    break;
                case 7:
                    a = Math.Sin(a) / Math.Cos(a);
                    textBox1.Text = a.ToString();
                    break;
                case 8:
                    a = Math.Log(a);
                    textBox1.Text = a.ToString();
                    break;
                case 9:
                    a = Math.Log10(a);
                    textBox1.Text = a.ToString();
                    break;
                case 10:
                    a = Math.Exp(a);
                    textBox1.Text = a.ToString();
                    break;

                default:
                    break;
            }

        }
    }
}
