using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string Operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if(calcDisplay.Text == Operation && calcDisplay.Text != null)
            {
                calcDisplay.Text = "0";
            }
            else
            {
                calcDisplay.Text = calcDisplay.Text + "0";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (calcDisplay.Text == Operation && calcDisplay.Text != null)
            {
                calcDisplay.Text = "1";
            }
            else
            {
                calcDisplay.Text = calcDisplay.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (calcDisplay.Text == Operation && calcDisplay.Text != null)
            {
                calcDisplay.Text = "2";
            }
            else
            {
                calcDisplay.Text = calcDisplay.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (calcDisplay.Text == Operation && calcDisplay.Text != null)
            {
                calcDisplay.Text = "3";
            }
            else
            {
                calcDisplay.Text = calcDisplay.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (calcDisplay.Text == Operation && calcDisplay.Text != null)
            {
                calcDisplay.Text = "4";
            }
            else
            {
                calcDisplay.Text = calcDisplay.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (calcDisplay.Text == Operation && calcDisplay.Text != null)
            {
                calcDisplay.Text = "5";
            }
            else
            {
                calcDisplay.Text = calcDisplay.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (calcDisplay.Text == Operation && calcDisplay.Text != null)
            {
                calcDisplay.Text = "6";
            }
            else
            {
                calcDisplay.Text = calcDisplay.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (calcDisplay.Text == Operation && calcDisplay.Text != null)
            {
                calcDisplay.Text = "7";
            }
            else
            {
                calcDisplay.Text = calcDisplay.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (calcDisplay.Text == Operation && calcDisplay.Text != null)
            {
                calcDisplay.Text = "8";
            }
            else
            {
                calcDisplay.Text = calcDisplay.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (calcDisplay.Text == Operation && calcDisplay.Text != null)
            {
                calcDisplay.Text = "9";
            }
            else
            {
                calcDisplay.Text = calcDisplay.Text + "9";
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            calcDisplay.Text = calcDisplay.Text + ",";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(calcDisplay.Text);
            calcDisplay.Text = "/";
            Operation = "/";
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(calcDisplay.Text);
            calcDisplay.Text = "*";
            Operation = "*";
        }

        private void btnDiff_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(calcDisplay.Text);
            calcDisplay.Text = "-";
            Operation = "-";
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(calcDisplay.Text);
            calcDisplay.Text = "+";
            Operation = "+";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(calcDisplay.Text);

            if(Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                calcDisplay.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }

            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                calcDisplay.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }

            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                calcDisplay.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }

            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    calcDisplay.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    calcDisplay.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            calcDisplay.Clear();
            Operation = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if(calcDisplay.Text.Length > 0)
            {
                calcDisplay.Text = calcDisplay.Text.Remove(calcDisplay.Text.Length - 1, 1);
            }
        }

        private void calcDisplay_ClientSizeChanged(object sender, EventArgs e)
        {
            //calcDisplay.Font.Size = 24;
        }
    }
}
