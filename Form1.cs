using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = string.Format("Координаты: {0},{1}", e.X, e.Y);
            double x1, y, e7, z, a, Z, x, s_9;
            textBox8.Text = e.X.ToString();
            textBox3.Text = e.Y.ToString();
            x1 = Convert.ToDouble(textBox4.Text);
            a = Convert.ToDouble(textBox1.Text);
            e7 = Convert.ToDouble(textBox5.Text);          
            z = Convert.ToDouble(textBox2.Text);
            s_9 = Convert.ToDouble(textBox6.Text);
            Z = z * a * x1 + Math.Sqrt(Math.Abs(e7 + x1 / e.Y)) - Math.Abs(e.X + Math.Cos(a * s_9 + e.Y));
            textBox7.Text = Z.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
