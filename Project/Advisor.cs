using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project
{
    public partial class Advisor : Form
    {
        public Advisor()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form1 obf1 = new Form1();
            this.Hide();
            obf1.Show();
        }

        private void Advisor_Load(object sender, EventArgs e)
        {
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Flutter")
            {
                comboBox3.Text= "Sir Irfan";
            }
            else if (comboBox2.Text == "Website Development")
            {
                comboBox3.Text = "Sir Imran";
            }
            else if (comboBox2.Text == "Artificial Intelligence")
            {
                comboBox3.Text = "Sir Tariq";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5QMQKBD\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Students values(@name,@gender,@program,@age,@mobile,@teacher,@fees,@roll)", con);
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@gender", comboBox1.Text);
            cmd.Parameters.AddWithValue("@program", comboBox2.Text);
            cmd.Parameters.AddWithValue("@age", int.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("@mobile", int.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@teacher", comboBox3.Text);
            cmd.Parameters.AddWithValue("@fees", comboBox4.Text);
            cmd.Parameters.AddWithValue("@roll", textBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Add Successfully");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox4.Text = "";

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            showstudentsdb obssd = new showstudentsdb();
            this.Hide();
            obssd.Show();
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5QMQKBD\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Students where roll=@roll", con);
            cmd.Parameters.AddWithValue("@roll", textBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Delete Successfully");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5QMQKBD\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update Students set name=@name,gender=@gender,program=@program,age=@age,mobile=@mobile,teacher=@teacher,roll=@roll", con);
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@gender", comboBox1.Text);
            cmd.Parameters.AddWithValue("@program", comboBox2.Text);
            cmd.Parameters.AddWithValue("@age", int.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("@mobile", int.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@teacher", comboBox3.Text);
            cmd.Parameters.AddWithValue("@roll", textBox4.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Update Successfully");
        }
    }
}
