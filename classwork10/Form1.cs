using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classwork10
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
        }
        public string numberOne;
        public string operation;
        public void addNumber(string number)
        {
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = number;
            }
            else
            {
                richTextBox1.Text += number;
            }
        }
        private void buttonOne_Click(object sender, EventArgs e)
        {
            addNumber("1");
        }
        private void buttonTwo_Click(object sender, EventArgs e)
        {
            addNumber("2");
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "0")
            {
                richTextBox1.Text += "0";
            }
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            addNumber("3");
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            addNumber("4");
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            addNumber("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            addNumber("6");
        }

        private void buttonSevenn_Click(object sender, EventArgs e)
        {
            addNumber("7");
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            addNumber("8");
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            addNumber("9");
        }

        private void buttonErase_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            numberOne = "";
        }

        private void changeSignButton_Click(object sender, EventArgs e)
        {
            List<char> numbers = richTextBox1.Text.ToList();
            if (numbers[0] == '-')
            {
                numbers.RemoveAt(0);
            }
            else
            {
                numbers.Insert(0, '-');
            }
            numbers.ToArray();
            richTextBox1.Text = new string(numbers.ToArray());
        }

        private void buttonComma_Click(object sender, EventArgs e)
        {
            if (!richTextBox1.Text.Contains("."))
            {
                richTextBox1.Text += ".";
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(operation))
            {
                numberOne = richTextBox1.Text;
                richTextBox1.Text = "";
                operation = "+";
            }
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(operation))
            {
                string result = "";
                switch (operation)
                {
                    case "+":
                        result = (double.Parse(numberOne) + double.Parse(richTextBox1.Text)).ToString();
                        break;
                    case "-":
                        result = (double.Parse(numberOne) - double.Parse(richTextBox1.Text)).ToString();
                        break;
                    case "*":
                        result = (double.Parse(numberOne) * double.Parse(richTextBox1.Text)).ToString();
                        break;
                    case "/":
                        result = (double.Parse(numberOne) / double.Parse(richTextBox1.Text)).ToString();
                        break;
                    default:
                        break;
                }
                operation = "";
                numberOne = result;
                richTextBox1.Text = result;
            }
        }

        private void percentButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = (double.Parse(richTextBox1.Text) / 100).ToString();
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(operation))
            {
                numberOne = richTextBox1.Text;
                richTextBox1.Text = "";
                operation = "/";
            }
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(operation))
            {
                numberOne = richTextBox1.Text;
                richTextBox1.Text = "";
                operation = "*";
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(operation))
            {
                if (string.IsNullOrEmpty(numberOne))
                {
                    numberOne = richTextBox1.Text;
                }
                richTextBox1.Text = "";
                operation = "-";
            }
        }
    }
}
