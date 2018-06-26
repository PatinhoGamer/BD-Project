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
        private Urgencias Purge;
        private Utente Putente;
        private Trabalhadores Ptrab;

        public FormPrincipal()
        {
            InitializeComponent();
            //groupBox2.Hide();
        }

        Login login = new Login("admin", "1234");

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
            new Utente(this).ShowDialog(this);
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Trabalhadores(this).ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Ptrab == null)
                Ptrab = new Trabalhadores(this);
            Ptrab.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Putente == null)
                Putente = new Utente(this);
            Putente.Show();
            Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //define local variables from the user inputs 
            string user = textBox1.Text;
            string pass = textBox2.Text;
            //check if eligible to be logged in 
            if (login.IsLoggedIn(user, pass))
            {
                MessageBox.Show("You are logged in successfully");
                groupBox1.Hide();
                groupBox2.Show();
            }
            else
            {
                //show default login error message 
                MessageBox.Show("Login Error!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Purge == null)
                Purge = new Urgencias(this);
            Purge.Show();
            //Hide();
        }


    }
}