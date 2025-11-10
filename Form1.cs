using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string expression = textBox1.Text;
            List<int> operands = new List<int>();
            List<char> operators = new List<char>();

            // 用來暫存連續的數字字元 (Gemini 教的)
            StringBuilder tempOperand = new StringBuilder();
            char[] knownOperators = { '+', '-', '*', '/' };


            if (!string.IsNullOrEmpty(expression))
            {
                // 把input的數值分成operands, operators
                foreach (char x in expression)
                {
                    if (char.IsDigit(x))
                    {
                        tempOperand.Append(x);
                    }
                    else if (knownOperators.Contains(x))
                    {
                        operators.Add(x);
                        operands.Add(int.Parse(tempOperand.ToString()));
                        tempOperand.Clear();
                    }
                }

                if (tempOperand.Length > 0) 
                {
                    operands.Add(int.Parse(tempOperand.ToString()));
                }

                // 計算
                int result = operands[0];
                operands.RemoveAt(0);
                for (int i = 0; i < operands.Count; i++) 
                {
                    if (operators[i] == '+')
                    {
                        result += operands[i];
                    }
                    else if (operators[i] == '-')
                    {
                        result -= operands[i];
                    }
                    else if (operators[i] == '*')
                    {
                        result *= operands[i];
                    }
                    else if (operators[i] == '/')
                    {
                        result /= operands[i];
                    }
                }

                textBox1.Text = result.ToString();
            }
            
        }

        // Operator Inputs
        private void canOperator(char inputOperator)
        {
            char lastChar = textBox1.Text.Last();
            char[] operators = { '+', '-', '*', '/' };
            if (!operators.Contains(lastChar))
            {
                textBox1.Text = textBox1.Text + inputOperator;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            canOperator('+');
        }
        private void button12_Click(object sender, EventArgs e)
        {
            canOperator('-');
        }

        private void button13_Click(object sender, EventArgs e)
        {
            canOperator('*');
        }

        private void button14_Click(object sender, EventArgs e)
        {
            canOperator('/');
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        // Value Input
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
