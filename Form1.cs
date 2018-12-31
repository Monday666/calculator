using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 计算器
{
    public partial class Form1 : Form
    {
        double num1=0;
        double num2=0;
        bool disp = false;
        string sym="0";
        bool equ = false;
        bool sc = false;
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_n1_Click(object sender, EventArgs e)
        {
            if (disp == true)
            {
                textBox1.Text="0";
                disp = false;
            }
            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += "1";

            if (sc == true)
            {
                if (textBox2.Text == "0")
                    textBox2.Text = "";
                textBox2.Text += "1";

            }

        }

        private void button_n2_Click(object sender, EventArgs e)
        {
            if (disp == true)
            {
                textBox1.Text = "0";
                disp = false;
            }
            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += "2";

            if (sc == true)
            {
                if (textBox2.Text == "0")
                    textBox2.Text = "";
                textBox2.Text += "2";

            }
        }


        private void button_n3_Click(object sender, EventArgs e)
        {
            if (disp == true)
            {
                textBox1.Text = "0";
                disp = false;
            }
            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += "3";

            if (sc == true)
            {
                if (textBox2.Text == "0")
                    textBox2.Text = "";
                textBox2.Text += "3";

            }
        }

        private void button_n4_Click(object sender, EventArgs e)
        {
            if (disp == true)
            {
                textBox1.Text = "0";
                disp = false;
            }
            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += "4";

            if (sc == true)
            {
                if (textBox2.Text == "0")
                    textBox2.Text = "";
                textBox2.Text += "4";

            }
        }

        private void button_n5_Click(object sender, EventArgs e)
        {
            if (disp == true)
            {
                textBox1.Text = "0";
                disp = false;
            }
            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += "5";

            if (sc == true)
            {
                if (textBox2.Text == "0")
                    textBox2.Text = "";
                textBox2.Text += "5";

            }
        }

        private void button_n6_Click(object sender, EventArgs e)
        {
            if (disp == true)
            {
                textBox1.Text = "0";
                disp = false;
            }
            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += "6";

            if (sc == true)
            {
                if (textBox2.Text == "0")
                    textBox2.Text = "";
                textBox2.Text += "6";

            }
        }

        private void button_n7_Click(object sender, EventArgs e)
        {
            if (disp == true)
            {
                textBox1.Text = "0";
                disp = false;
            }
            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += "7";

            if (sc == true)
            {
                if (textBox2.Text == "0")
                    textBox2.Text = "";
                textBox2.Text += "7";

            }
        }

        private void button_n8_Click(object sender, EventArgs e)
        {
            if (disp == true)
            {
                textBox1.Text = "0";
                disp = false;
            }
            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += "8";

            if (sc == true)
            {
                if (textBox2.Text == "0")
                    textBox2.Text = "";
                textBox2.Text += "8";

            }
        }

        private void button_n9_Click(object sender, EventArgs e)
        {
            if (disp == true)
            {
                textBox1.Text = "0";
                disp = false;
            }
            if (textBox1.Text == "0")
                textBox1.Text = "";
            textBox1.Text += "9";

            if (sc == true)
            {
                if (textBox2.Text == "0")
                    textBox2.Text = "";
                textBox2.Text += "9";

            }
        }

        private void button_n0_Click(object sender, EventArgs e)
        {
            if (disp == true)
            {
                textBox1.Text = "0";
                disp = false;
            }
            if (textBox1.Text == "0")
                textBox1.Text = "0";
            else
                textBox1.Text += "0";

            if (sc == true)
            {
                if (textBox2.Text == "0")
                    textBox2.Text = "";
                textBox2.Text += "0";

            }
        }

        private void button_point_Click(object sender, EventArgs e)
        {
            if (disp == true)
            {
                textBox1.Text = "";
                disp = false;
            }
            if (textBox1.Text == "")
                textBox1.Text = "0.";
            else if (textBox1.Text.Contains("."))
                MessageBox.Show("不能输入两个点!!","错误！");
            else 
                textBox1.Text += ".";

            if (sc == true)
            {
                textBox2.Text += ".";

            }
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            num1 = 0;
            num2 = 0;
            disp = false;
            sym = "0";
            equ = false;

            if (sc == true)
            {

                textBox2.Text = "0";

            }
        }

        private void button_CE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            disp = false;

            if (sc == true)
            {

                textBox2.Text = "0";

            }
        }

        private void button_BkSps_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1)
                textBox1.Text = "0";
            else
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);

            if (sc == true)
            {
                if (textBox2.Text.Length == 1)
                    textBox2.Text = "0";
                else
                    textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);

            }
        }

        private void button_percent_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Double.Parse(textBox1.Text) * 0.01).ToString();
            disp = true;
        }

        private void button_sqrt_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Sqrt(Double.Parse(textBox1.Text)).ToString();
            disp = true;
        }

        private void button_square_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Pow(Double.Parse(textBox1.Text), 2).ToString();
            disp = true;
        }

        private void button_pm_Click(object sender, EventArgs e)
        {
            textBox1.Text = (-1 * Double.Parse(textBox1.Text)).ToString();
            
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            if (equ == true && sc == false)
                button_equal.PerformClick();
            disp = true;
            num1 = Double.Parse(textBox1.Text);
            sym = "+";
            equ = true;

            if (sc == true)
            {

                textBox2.Text += "+";

            }
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            if (equ == true && sc == false)
                button_equal.PerformClick();
            disp = true;
            num1 = Double.Parse(textBox1.Text);
            sym = "-";
            equ = true;

            if (sc == true)
            {

                textBox2.Text += "-";

            }
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            if (equ == true && sc == false)
                button_equal.PerformClick();
            disp = true;
            num1 = Double.Parse(textBox1.Text);
            sym = "*";
            equ = true;

            if (sc == true)
            {

                textBox2.Text += "*";

            }
        }

        private void button_division_Click(object sender, EventArgs e)
        {
            if (equ == true && sc == false)
                button_equal.PerformClick();
            disp = true;
            num1 = Double.Parse(textBox1.Text);
            sym = "/";
            equ = true;

            if (sc == true)
            {

                textBox2.Text += "/";

            }
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            if (disp == false)
                num2 = Double.Parse(textBox1.Text);
            switch (sym)
            {
                case "+":
                    textBox1.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    textBox1.Text = (num1 - num2).ToString();
                    break;
                case "*":
                    textBox1.Text = (num1 * num2).ToString();
                    break;
                case "/":
                    if (textBox1.Text == "0")
                        MessageBox.Show("除数不能为0","错误！");
                    else
                        textBox1.Text = (num1 / num2).ToString();
                    break;
            }
            num1 = Double.Parse(textBox1.Text);
            disp = true;
            equ = false;

            if (sc == true)
            {

                try
                {
                    MSScriptControl.ScriptControlClass aa = new MSScriptControl.ScriptControlClass();
                    aa.Language = "javascript";
                    object obj = aa.Eval(textBox2.Text);
                    textBox2.Text = obj.ToString();
                }
                catch
                {
                    MessageBox.Show("请输入正确的表达式！");
                }

            }

        }

        private void button_sin_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Sin(Double.Parse(textBox1.Text)).ToString();
            disp = true;
        }

        private void button_cos_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Cos(Double.Parse(textBox1.Text)).ToString();
            disp = true;
        }

        private void button_tan_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Tan(Double.Parse(textBox1.Text)).ToString();
            disp = true;
        }

        private void button_cot_Click(object sender, EventArgs e)
        {
            textBox1.Text = (1 / Math.Tan(Double.Parse(textBox1.Text))).ToString();
            disp = true;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '9':
                    button_n9.PerformClick();
                    e.Handled = true;
                    break;
                case '8':
                    button_n8.PerformClick();
                    e.Handled = true;
                    break;
                case '7':
                    button_n7.PerformClick();
                    e.Handled = true;
                    break;
                case '6':
                    button_n6.PerformClick();
                    e.Handled = true;
                    break;
                case '5':
                    button_n5.PerformClick();
                    e.Handled = true;
                    break;
                case '4':
                    button_n4.PerformClick();
                    e.Handled = true;
                    break;
                case '3':
                    button_n3.PerformClick();
                    e.Handled = true;
                    break;
                case '2':
                    button_n2.PerformClick();
                    e.Handled = true;
                    break;
                case '1':
                    button_n1.PerformClick();
                    e.Handled = true;
                    break;
                case '0':
                    button_n0.PerformClick();
                    e.Handled = true;
                    break;
                case '+':
                    button_plus.PerformClick();
                    e.Handled = true;
                    break;
                case '-':
                    button_minus.PerformClick();
                    e.Handled = true;
                    break;
                case '*':
                    button_multiply.PerformClick();
                    e.Handled = true;
                    break;
                case '/':
                    button_division.PerformClick();
                    e.Handled = true;
                    break;
                case '.':
                    button_point.PerformClick();
                    e.Handled = true;
                    break;
            }
            if (e.KeyChar == 13)
            {
                button_plus.PerformClick();
                e.Handled = true;

            }
            if (e.KeyChar == 8)
            {
                button_BkSps.PerformClick();
                e.Handled = true;
            }

        }

        private void button_onoff_Click(object sender, EventArgs e)
        {
            if (sc == false)
            {
                sc = true;
                textBox2.Text = "0";
            }
            else
            {
                textBox2.Text = "";
                sc = false;
            } 
        }

        private void button_leftpar_Click(object sender, EventArgs e)
        {
            if (sc == true)
            {
                if (textBox2.Text == "0")
                    textBox2.Text = "";
                textBox2.Text += "(";

            }
        }

        private void button_ritpar_Click(object sender, EventArgs e)
        {
            if (sc == true)
            {
                if (textBox2.Text == "0")
                    textBox2.Text = "";
                  textBox2.Text += ")";

            }
        }

    }
}
