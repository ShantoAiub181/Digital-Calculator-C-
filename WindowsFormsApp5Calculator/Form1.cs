using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5Calculator
{
    public partial class Form1 : Form
    {
        Double value = 0;
        string operation = "";
        bool operation_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0")||(operation_pressed))
                result.Clear();
            operation_pressed = false;
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(result.Text);
            operation_pressed = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    result.Text =( value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;

            }//end switch
            operation_pressed = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            result.Clear();
            value = 0;
        }
    }
}
