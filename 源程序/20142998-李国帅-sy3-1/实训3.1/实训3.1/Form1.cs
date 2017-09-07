using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 实训3._1
{
    public partial class Form1 : Form
    {
        double a = 0;
        double b = 0;
        bool c = false;
        string d;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += "7";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += "1";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += "2";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += "5";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += "6";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += "9";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += "0";
            if (d == "/")
            {
                textBox1.Clear();
                MessageBox.Show("除数不能为零", "错误提示", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            c = true;
            b = double.Parse(textBox1.Text);
            d = "+";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            c = true;
            b = double.Parse(textBox1.Text);
            d = "/";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            c = true;
            b = double.Parse(textBox1.Text);
            d = "*";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            c = true;
            b = double.Parse(textBox1.Text);
            d = "-";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            switch (d)
            {

             case "+": a = b + double.Parse(textBox1.Text); break;
             case "-": a = b - double.Parse(textBox1.Text); break;
             case "*": a = b * double.Parse(textBox1.Text); break;
             case "/": a = b / double.Parse(textBox1.Text); break;
        }
          textBox1.Text = a + "";
          c = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            b = double.Parse(textBox1.Text);
            a = b * b;
            textBox1.Text = a + "";
            c = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (double.Parse(textBox1.Text) < 0)
            {
                MessageBox.Show("除数不能为0", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            b = double.Parse(textBox1.Text);
            a = Math.Sqrt(b);                              //Math.Sqrt（double a）函数用于求开方运算
            textBox1.Text = a + "";
            c = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (double.Parse(textBox1.Text) < 0)
            {
                MessageBox.Show("指数不能为0", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            b = double.Parse(textBox1.Text);
            a = Math.Log(b);                                //Math.Log(double b)函数用于求ln运算，以e为底
            textBox1.Text = a + "";
            c = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (double.Parse(textBox1.Text) < 0)
            {
                MessageBox.Show("指数不能为0", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            b = double.Parse(textBox1.Text);
            a = Math.Log10(b);                             //Math.Log10(double b)函数用于求log运算，以10为底
            textBox1.Text = a + "";
            c = true;
        }
    }
}
