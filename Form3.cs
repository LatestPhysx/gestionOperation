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

namespace gestionOperation
{
    public partial class Form3 : Form
    {
        public static SqlConnection con = new SqlConnection("Data Source=DESKTOP-390P831;Initial Catalog=gestionOperation;Integrated Security=True;TrustServerCertificate=True");
        public static SqlCommand com = new SqlCommand(" ", con);

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                com.CommandText = "insert into Client Values(" + int.Parse(textBox1.Text) + ",'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "');";
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Succes");
                textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear();
                textBox1.Focus();
            }
            catch (Exception error)
            {
                con.Close();
                MessageBox.Show("Error : " + error.Message);
                textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear();
                textBox1.Focus();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
