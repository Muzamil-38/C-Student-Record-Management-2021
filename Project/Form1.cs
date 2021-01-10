using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
           if (textBox1.Text == "Acc1" && textBox2.Text == "acc1")
            {
                Accountant obac = new Accountant();
                this.Hide();
                obac.Show();
            }
            else if (textBox1.Text == "Ad1" && textBox2.Text == "ad1")
            {
                Advisor obad = new Advisor();
                this.Hide();
                obad.Show();
            }
            else
            {
                MessageBox.Show("Plz Enter Correct Username and Password !");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
