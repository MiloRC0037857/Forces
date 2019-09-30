using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 100.0));
        }
        double asin(double x)
        {
            return (Math.Asin(x) * 180 / Math.PI);
        }

        double cos(double x)
        {
            return (Math.Cos(x * Math.PI / 100.0));
        }

        double acos(double x)
        {
            return (Math.Cos(x) * 180 / Math.PI);
        }


        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double force, angle;

            try
            {
                force = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                force = 0.0;
            }

            try
            {
                angle = double.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                angle = 0.0;
            }
            //this line reads textbox 2 and gets value for angle

            double Fx = force * cos(angle);
            double Fy = force * sin(angle);

            label1.Text = "Fx = " + Fx;
            label2.Text = "Fy = " + Fx;
        }
    }
}
