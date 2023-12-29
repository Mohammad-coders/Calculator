using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private string operators;
        private double value1;
        private double value2;
        private double result=0;
        public Form1()
        {
            InitializeComponent();
            txtDisplayResult.Text = "0";
        }

        private void lblApplicationExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if(txtDisplayResult.Text== "0" && txtDisplayResult != null)
            {
                txtDisplayResult.Text = "7";
            }
            else
            {
                txtDisplayResult.Text = "7";
            }
            
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtDisplayResult.Text == "0" && txtDisplayResult != null)
            {
                txtDisplayResult.Text = "8";
            }
            else
            {
                txtDisplayResult.Text = "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtDisplayResult.Text == "0" && txtDisplayResult != null)
            {
                txtDisplayResult.Text = "9";
            }
            else
            {
                txtDisplayResult.Text = "9";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtDisplayResult.Text == "0" && txtDisplayResult != null)
            {
                txtDisplayResult.Text = "4";
            }
            else
            {
                txtDisplayResult.Text = "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtDisplayResult.Text == "0" && txtDisplayResult != null)
            {
                txtDisplayResult.Text = "5";
            }
            else
            {
                txtDisplayResult.Text = "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtDisplayResult.Text == "0" && txtDisplayResult != null)
            {
                txtDisplayResult.Text = "6";
            }
            else
            {
                txtDisplayResult.Text = "6";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtDisplayResult.Text == "0" && txtDisplayResult != null)
            {
                txtDisplayResult.Text = "1";
            }
            else
            {
                txtDisplayResult.Text = "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtDisplayResult.Text == "0" && txtDisplayResult != null)
            {
                txtDisplayResult.Text = "2";
            }
            else
            {
                txtDisplayResult.Text = "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtDisplayResult.Text == "0" && txtDisplayResult != null)
            {
                txtDisplayResult.Text = "3";
            }
            else
            {
                txtDisplayResult.Text = "3";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplayResult.Text = "0";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (txtDisplayResult.Text == "0" && txtDisplayResult != null)
            {
                txtDisplayResult.Text = ".";
            }
            else
            {
                txtDisplayResult.Text = ".";
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            operators = "+";
            value1 = double.Parse(txtDisplayResult.Text);
            txtDisplayResult.Clear();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            operators = "-";
            value1 = double.Parse(txtDisplayResult.Text);
            txtDisplayResult.Clear();
        }

        private void btnModulous_Click(object sender, EventArgs e)
        {
            operators = "%";
            value1 = double.Parse(txtDisplayResult.Text);
            txtDisplayResult.Clear();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operators = "/";
            value1 = double.Parse(txtDisplayResult.Text);
            txtDisplayResult.Clear();
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            operators = "*";
            value1 = double.Parse(txtDisplayResult.Text);
            txtDisplayResult.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            value2 = double.Parse(txtDisplayResult.Text);
            if (operators.Equals("+"))
            {
                result = value1 + value2;
                value1 = result;
            }
            if (operators.Equals("-"))
            {
                result = value1 - value2;
                value1 = result;
            }
            if (operators.Equals("*"))
            {
                result = value1 * value2;
                value1 = result;
            }
            if (operators.Equals("/"))
            {
                result = value1 / value2;
                value1 = result;
            }
            if (operators.Equals("%"))
            {
                result = value1 % value2;
                value1 = result;
            }
            txtDisplayResult.Text = result + " ";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplayResult.Text = "0";
        }
    }
}
