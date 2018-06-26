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
        private string search;
        private string filter;

        public Urgencias(Form form)
        {
            InitializeComponent();
            principal = (FormPrincipal)form;
        }

        private void Urgencias_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD.UTENTE' table. You can move, or remove it, as needed.
            this.uTENTETableAdapter.Fill(this.bD.UTENTE);
            // TODO: This line of code loads data into the 'bD.URGENCIA' table. You can move, or remove it, as needed.
            this.uRGENCIATableAdapter.Fill(this.bD.URGENCIA);

        }

        private void Urgencias_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (checkClose)
                principal.Close();
        }

        private void uRGENCIABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uRGENCIABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD);

        }

        private void iD_URGENCIAListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iD_URGENCIATextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            search = this.textBox2.Text;
            if (filter[0] == 'I')
            {
                if (int.TryParse(search, out int id))
                    uRGENCIABindingSource.Filter = string.Format("{0} = {1}", filter, id);
            }
            else if(filter[0] == 'D')
            {
                uRGENCIABindingSource.Filter = string.Format("TO_CHAR(DATA_,'DD-MM-YYYY') like '%{0}%'",search);
            }
            else
                uRGENCIABindingSource.Filter = string.Format("{0} LIKE '%{1}%'", filter, search);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter = this.comboBox1.SelectedItem.ToString().ToUpper();
        }

        private void Urgencias_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (checkClose)
                principal.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkClose = false;
            principal.Show();
            Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
