using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_Trab
{
    public partial class Urgencias : Form
    {
        private FormPrincipal principal;
        private bool checkClose = true;

        public Urgencias(Form form)
        {
            InitializeComponent();
            principal = (FormPrincipal)form;
        }

        private void Urgencias_Load(object sender, EventArgs e)
        {

        }

        private void Urgencias_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (checkClose)
                principal.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkClose = false;
            principal.Show();
            Hide();
        }
    }
}
