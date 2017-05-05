using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form2 : Form
    {
        private Form1 superForm;

        public Form2(Form1 form)
        {
            superForm = form;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = Helper.CalculateBamFromEur(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = Helper.CalculatePDV(textBox4.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox5.Text = Helper.CalculateRate(textBox6.Text, textBox7.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox8.Text = Helper.CalculateAverage(textBox9.Text);
        }

        private void closer(object sender, FormClosingEventArgs e)
        {
            superForm.Close();
        }
        
    }
}
