using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadoradogiovanni
{
    public partial class textBoxDisplay : Form
    {
        public textBoxDisplay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxDisplayy.Text = textBoxDisplayy.Text + this.Text;
        }

        private void textBoxDisplay_Load(object sender, EventArgs e)
        {

        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSubtração_Click(object sender, EventArgs e)
        {
            textBoxDisplayy.Text = textBoxDisplayy.Text + "-";
        }

        private void buttonSoma_Click(object sender, EventArgs e)
        {
            textBoxDisplayy.Text = textBoxDisplayy.Text + "+";
        }

        private void buttonDivisão_Click(object sender, EventArgs e)
        {
            textBoxDisplayy.Text = textBoxDisplayy.Text + "/";
        }

        private void buttonMultiplica_Click(object sender, EventArgs e)
        {
            textBoxDisplayy.Text = textBoxDisplayy.Text + "*";
        }

        private void buttonVirgula_Click(object sender, EventArgs e)
        {
            textBoxDisplayy.Text = textBoxDisplayy.Text + ",";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBoxDisplayy.Text = textBoxDisplayy.Text + this.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBoxDisplayy.Text = textBoxDisplayy.Text + this.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxDisplayy.Text = textBoxDisplayy.Text + this.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxDisplayy.Text = textBoxDisplayy.Text + this.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxDisplayy.Text = textBoxDisplayy.Text + this.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxDisplayy.Text = textBoxDisplayy.Text + this.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxDisplayy.Text = textBoxDisplayy.Text + this.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxDisplayy.Text = textBoxDisplayy.Text + this.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxDisplayy.Text = textBoxDisplayy.Text + this.Text;
        }
    }
}
