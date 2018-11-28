
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TempConvertTemplate
{
    public partial class Form1 : Form
    {
        double length;
        double answer;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            length = Convert.ToDouble(textBox2.Text);
            if (textBox1.Text == "1")
            {
                answer = ItoC(length);
                label1.Text = length + " inches = " + answer + " centimeters";
            }
            else if (textBox1.Text == "2")
            {
                answer = FtoC(length);
                label1.Text = length + " feet = " + answer + " centimeters";
            }
            else if (textBox1.Text == "3")
            {
                answer = YtoM(length);
                label1.Text = length + " yards = " + answer + " meters";
            }
            else if (textBox1.Text == "4")
            {
                answer = MToK(length);
                label1.Text = length + " miles = " + answer + " kilometers";
            }

        }
        public double ItoC(double inches)
        {
            double centimeters;
            centimeters = (2.54 * inches);
            return centimeters;
        }

        public double FtoC(double feet)
        {
            double centimeters;
            centimeters = (30.48 * feet);
            return centimeters;
        }
        public double YtoM(double yards)
        {
            double meters;
            meters = (0.9144 * yards);
            return meters;
        }
        public double MToK(double miles)
        {
            double kilometers;
            kilometers = (0.9144 * miles);
            return kilometers;
        }
    }
}
