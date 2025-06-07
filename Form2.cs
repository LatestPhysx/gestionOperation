using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionOperation
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void operationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void clientToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void afficherClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void ajouterClientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void ajouterOperationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form4().Show();
        }

        private void afficherOperationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form5().Show();
        }
    }
}
