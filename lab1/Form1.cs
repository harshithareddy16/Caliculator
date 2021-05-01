using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        Double fnumber = 0;
        Double snumber = 0;
        int op;
        Boolean selectop = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
                textBox1.Text += "1";
            else
                textBox1.Text = "1";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
                textBox1.Text += "2";
            else
                textBox1.Text = "2";



        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "0")
                textBox1.Text += "3";
            else
                textBox1.Text = "3";


        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "0")
                textBox1.Text += "4";
            else
                textBox1.Text = "4";


        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "0")
                textBox1.Text += "5";
            else
                textBox1.Text = "5";


        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "0")
                textBox1.Text += "6";
            else
                textBox1.Text = "6";


        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "0")
                textBox1.Text += "7";
            else
                textBox1.Text = "7";


        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "0")
                textBox1.Text += "8";
            else
                textBox1.Text = "8";


        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "0")
                textBox1.Text += "9";
            else
                textBox1.Text = "9";


        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
                textBox1.Text += "0";
            else
                textBox1.Text = "0";


        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (selectop == true)
            {
                snumber = Convert.ToDouble(textBox1.Text);
                if (op == 1)
                {
                    textBox1.Text = Convert.ToString(fnumber + snumber);
                }
            }
            if (op == 2)
            {
                textBox1.Text = Convert.ToString(fnumber - snumber);
            }
            if (op == 3)
            {
                textBox1.Text = Convert.ToString(fnumber * snumber);
            }
            if (op == 4)
            {
                textBox1.Text = Convert.ToString(fnumber / snumber);
            }
            if (op == 5)
            {
                textBox1.Text = Convert.ToString(fnumber % snumber);
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            fnumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            op = 1;
            selectop = true;

        }

        private void button14_Click(object sender, EventArgs e)
        {

            fnumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            op = 2;
            selectop = true;


        }

        private void button15_Click(object sender, EventArgs e)
        {

            fnumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            op = 3;
            selectop = true;


        }

        private void button18_Click(object sender, EventArgs e)
        {
            fnumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            op = 4;
            selectop = true;


        }

        private void button17_Click(object sender, EventArgs e)
        {
            fnumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            op = 5;
            selectop = true;


        }
    }
}
