using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace BD_Trab
{
    public partial class Utente : Form
    {
        private FormPrincipal principal;
        private string search;
        private string filter;
        private bool checkClose = true;
        char[] arrayGenero = { 'M', 'F' };

        public Utente(Form form)
        {
            principal = (FormPrincipal)form;
            InitializeComponent();
        }

        private void Utente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bd1.UTENTE'. Você pode movê-la ou removê-la conforme necessário.
            this.uTENTETableAdapter.Fill(this.bd1.UTENTE);
            this.comboBox1.SelectedIndex = 0;
            try
            {
                for (int i = 0; i < arrayGenero.Length; i++)
                {
                    if (gENEROTextBox.Text[0] == arrayGenero[i])
                        comboBox2.SelectedIndex = i;
                }
            }
            catch { }
            gENEROTextBox.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.uTENTEBindingSource.AddNew();
            gENEROTextBox.Text = comboBox2.Text.Substring(0,1);
            this.iD_UTENTETextBox.Text = this.uTENTETableAdapter.GetNextID_Utente().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = iD_UTENTETextBox.Text;
            string nome = textBox1.Text;
            string genero = gENEROTextBox.Text;
            string morada = mORADATextBox.Text;


            OracleCommand comm = new OracleCommand(string.Format("update utente" +
                " set nome='{0}',genero='{1}',morada='{2}'" +
                " where id_utente={3}"
                , nome, genero, morada, id),
                principal.GetOracleConnection());
            try
            {
                comm.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Informação Inválida");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.uTENTEBindingSource.RemoveCurrent();
        }

        public void SetCheckClose(bool x)
        {
            checkClose = x;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.uTENTEBindingSource.EndEdit();
            this.uTENTEBindingSource.AddNew();
            this.uTENTEBindingSource.RemoveCurrent();
            this.tableAdapterManager.UpdateAll(this.bd1);
            checkClose = false;
            principal.Show();
            Hide();
        }

        private void Utente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (checkClose)
                principal.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter = this.comboBox1.SelectedItem.ToString().ToUpper();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            search = this.textBox2.Text;
            if (filter[0] == 'I')
            {
                if (int.TryParse(search, out int id))
                    uTENTEBindingSource.Filter = string.Format("{0} = {1}", filter, id);
            }
            else
                uTENTEBindingSource.Filter = string.Format("{0} LIKE '%{1}%'", filter, search);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox me = sender as ComboBox;
            gENEROTextBox.Text = me.Text.Substring(0, 1);
        }

        private void nOMEListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < arrayGenero.Length; i++)
                {
                    if (gENEROTextBox.Text[0] == arrayGenero[i])
                        comboBox2.SelectedIndex = i;
                }
            }
            catch { }
        }
    }
}
