using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_Trab
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void utentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void trabalhadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void urgênciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            string Command = string.Format("select * from {0}",this.Text);

            SqlCommand myCommand = new SqlCommand(Command);
            */
            new Utente().ShowDialog(this);
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Trabalhadores().ShowDialog(this);
        }
    }
}
