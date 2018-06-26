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
    public partial class Utente : Form
    {
        private FormPrincipal principal;
        private string search;
        private string filter;
        private bool checkClose = true;

        public Utente(Form form)
        {
            principal = (FormPrincipal)form;
            InitializeComponent();
        }

        private void uTENTEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uTENTEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd1);

        }

        private void Utente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bd1.UTENTE'. Você pode movê-la ou removê-la conforme necessário.
            this.uTENTETableAdapter.Fill(this.bd1.UTENTE);
            this.comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.uTENTEBindingSource.AddNew();
            this.iD_UTENTETextBox.Text = this.uTENTETableAdapter.GetNextID_Utente().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!this.Validate())
                MessageBox.Show("Informação Inválida!");
            this.uTENTEBindingSource.EndEdit();
            this.uTENTEBindingSource.AddNew();
            this.uTENTEBindingSource.RemoveCurrent();
            this.uTENTETableAdapter.Update(this.bd1.UTENTE);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.uTENTEBindingSource.RemoveCurrent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.uTENTEBindingSource.AddNew();
            this.uTENTEBindingSource.RemoveCurrent();
            this.tableAdapterManager.UpdateAll(this.bd1);
            checkClose = false;
            principal.Show();
            Hide();
        }

        private void Utente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(checkClose)
                principal.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter = this.comboBox1.SelectedItem.ToString().ToUpper();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            search = this.textBox1.Text;
            if (filter[0] == 'I')
            {
                if (int.TryParse(search, out int id))
                    uTENTEBindingSource.Filter = string.Format("{0} = {1}", filter, id);
            }
            else
                uTENTEBindingSource.Filter = string.Format("{0} LIKE '%{1}%'", filter, search);
        }

        private void nOMEListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
