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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ActiveControl = mailBox;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = passwordBox.Text;
            string mail = mailBox.Text;

            if (Helper.IsPasswordOkay(password) && Helper.IsMailOkay(mail) && Helper.IsCorrect(mail, password))
            {
                this.Hide();
                Form2 form2 = new Form2(this);
                form2.Show();
            }
            else
                MessageBox.Show("Wrong mail/password combination.");
        }
    }
}
