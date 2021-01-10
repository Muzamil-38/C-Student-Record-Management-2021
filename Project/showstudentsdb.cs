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
    public partial class showstudentsdb : Form
    {
        public showstudentsdb()
        {
            InitializeComponent();
        }
        DataTable dt;

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("name LIKE '%{0}%'", textBox1.Text);
            dataGridView1.DataSource = dv;

        }

        private void Showstudentsdb_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5QMQKBD\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Students ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("program LIKE '%{0}%'", textBox2.Text);
            dataGridView1.DataSource = dv;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Advisor obad = new Advisor();
            this.Hide();
            obad.Show();
        }
    }
}
