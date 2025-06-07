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
    public partial class Form4 : Form
    {
        public static SqlConnection con = new SqlConnection("Data Source=DESKTOP-390P831;Initial Catalog=gestionOperation;Integrated Security=True;TrustServerCertificate=True");
        public static SqlCommand com = new SqlCommand(" ", con);

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            con.Open();
            com.CommandText = "select * from Client";
            SqlDataReader reader = com.ExecuteReader();
            if (!reader.HasRows)
            {
                con.Close();
                MessageBox.Show("No Client Available !");
            }
            else
            {
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader[0].ToString());
                }
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                com.CommandText = "insert into Operation values(" + int.Parse(textBox1.Text) + ",'" + textBox3.Text + "','" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "','" + textBox4.Text + "'," + int.Parse(comboBox1.SelectedItem.ToString()) + ");";
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Succes !");
                textBox1.Clear(); textBox3.Clear(); dateTimePicker1.Value = DateTime.Now; textBox4.Clear(); comboBox1.SelectedIndex = -1;
                textBox1.Focus();
            }
            catch (Exception Error)
            {
                con.Close();
                MessageBox.Show("Error : " + Error.Message);
            }
        }
    }
}
