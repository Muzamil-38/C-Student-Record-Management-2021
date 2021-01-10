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
    public partial class Accountant : Form
    {
        DataTable dt;
        public Accountant()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5QMQKBD\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update Students set fees=@fees,roll=@roll", con);
            cmd.Parameters.AddWithValue("@fees", comboBox4.Text);
            cmd.Parameters.AddWithValue("@roll", textBox4.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Update Successfully");
        }

        private void Accountant_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5QMQKBD\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Students ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form1 obf1 = new Form1();
            this.Hide();
            obf1.Show();
        }
    }
}
