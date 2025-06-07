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
    public partial class Form5 : Form
    {
        public static SqlConnection con = new SqlConnection("Data Source=DESKTOP-390P831;Initial Catalog=gestionOperation;Integrated Security=True;TrustServerCertificate=True");
        public static SqlCommand com = new SqlCommand(" ", con);

        public Form5()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                com.CommandText = "select * from Operation";
                SqlDataReader reader = com.ExecuteReader();
                if (!reader.HasRows)
                {
                    con.Close();
                    MessageBox.Show("No Data !");
                }
                else
                {
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString());
                    }
                    con.Close();
                }
            }
            catch (Exception Error)
            {
                con.Close();
                MessageBox.Show("Error : " + Error.Message);
            }
        }
    }
}