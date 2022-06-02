using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukuv0602
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Top = label1.Top - 10;
            label1.Text = "(^ω^)";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Left = label1.Left - 10;
            label1.Text = "(・ω・#)";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Left = label1.Left + 10;
            label1.Text = "(#・ω・)";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Top = label1.Top + 10;
            label1.Text = "(_ω_)";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("田中雄");
            label1.Visible = false;
        }
    }
}
