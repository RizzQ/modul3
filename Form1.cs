using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace modul3
{
    public partial class Form1 : Form
    {
        int hasilOutput = 0;
        public Form1()
        {
            
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "3";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "4";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "5";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "6";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "7";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "8";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "9";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "0";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            hasilOutput += int.Parse(lblOutput.Text);
            lblOutput.Text = "";

        }

        private void button10_Click(object sender, EventArgs e)
        {

            hasilOutput += int.Parse(lblOutput.Text);

            lblOutput.Text = hasilOutput.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
