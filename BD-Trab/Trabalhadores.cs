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
    public partial class Trabalhadores : Form
    {
        private FormPrincipal principal;
        private string search;
        private string filter;
        private bool checkClose = true;
        char[] arrayEncargo = { 'E', 'L' };
        char[] arrayGenero = { 'M', 'F' };
        char[] arrayTurno = { 'D', 'T', 'N' };

        public Trabalhadores(Form form)
        {
            principal = (FormPrincipal)form;
            InitializeComponent();
        }


        private void Trabalhadores_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bD.TRABALHADOR'. Você pode movê-la ou removê-la conforme necessário.
            this.tRABALHADORTableAdapter.Fill(this.bD.TRABALHADOR);

            this.comboBox1.SelectedIndex = 0;
            try
            {
                for (int i = 0; i < arrayEncargo.Length; i++)
                {
                    if (eNCARGOTextBox.Text[0] == arrayEncargo[i])
                        comboBox2.SelectedIndex = i;
                }

                for (int i = 0; i < arrayGenero.Length; i++)
                {
                    if (gENEROTextBox.Text[0] == arrayGenero[i])
                        comboBox3.SelectedIndex = i;
                }
                for (int i = 0; i < arrayTurno.Length; i++)
                {
                    if (tURNOTextBox.Text[0] == arrayTurno[i])
                        comboBox4.SelectedIndex = i;
                }
            }
            catch { }
             eNCARGOTextBox.Hide();
             gENEROTextBox.Hide();
             tURNOTextBox.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tRABALHADORBindingSource.AddNew();
            gENEROTextBox.Text = comboBox3.Text.Substring(0, 1);
            eNCARGOTextBox.Text = comboBox2.Text;
            tURNOTextBox.Text = comboBox4.Text.Substring(0, 1);

            this.iD_TRABALHADORTextBox.Text = this.tRABALHADORTableAdapter.GetNextID_Trabalhador().ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            string id = iD_TRABALHADORTextBox.Text;
            string nome = nOMETextBox.Text;
            string genero = gENEROTextBox.Text;
            string morada = mORADATextBox.Text;
            string encargo = eNCARGOTextBox.Text;
            string turno = tURNOTextBox.Text;

            //tRABALHADORBindingSource.RemoveCurrent();
            //tRABALHADORBindingSource.AddNew();

            iD_TRABALHADORTextBox.Text = id;
            nOMETextBox.Text = nome;
            gENEROTextBox.Text = genero;
            mORADATextBox.Text = morada;
            eNCARGOTextBox.Text = encargo;
            tURNOTextBox.Text = turno;
            */

            Validate();
            tRABALHADORBindingSource.EndEdit();            
            tRABALHADORBindingSource.AddNew();
            tRABALHADORBindingSource.RemoveCurrent();
            try
            {
                tableAdapterManager.UpdateAll(bD);
            }
            catch   
            {
                MessageBox.Show("Existe Algum Valor Inválido");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.tRABALHADORBindingSource.RemoveCurrent();
            }
            catch { };
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Validate();
            this.tRABALHADORBindingSource.EndEdit();
            this.tRABALHADORBindingSource.AddNew();
            this.tRABALHADORBindingSource.RemoveCurrent();
            this.tableAdapterManager.UpdateAll(this.bD);
            
            checkClose = false;
            principal.Show();
            Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter = this.comboBox1.SelectedItem.ToString().ToUpper();
        }

        private void Trabalhadores_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (checkClose)
                principal.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            search = this.textBox1.Text;
            if (filter[0] == 'I')
            {
                if (int.TryParse(search, out int id))
                    tRABALHADORBindingSource.Filter = string.Format("{0} = {1}", filter, id);
            }
            else
                tRABALHADORBindingSource.Filter = string.Format("{0} LIKE '%{1}%'", filter, search);
        }

        public void SetCheckClose(bool x)
        {
            checkClose = x;
        }

        private void nOMEListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < arrayEncargo.Length; i++)
                {
                    if (eNCARGOTextBox.Text[0] == arrayEncargo[i])
                        comboBox2.SelectedIndex = i;
                }
                for (int i = 0; i < arrayGenero.Length; i++)
                {
                    if (gENEROTextBox.Text[0] == arrayGenero[i])
                        comboBox3.SelectedIndex = i;
                }
                for (int i = 0; i < arrayTurno.Length; i++)
                {
                    if (tURNOTextBox.Text[0] == arrayTurno[i])
                        comboBox4.SelectedIndex = i;
                }
            }
            catch { }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox me = sender as ComboBox;
            eNCARGOTextBox.Text = me.Text;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox me = sender as ComboBox;
            tURNOTextBox.Text = me.Text.Substring(0, 1);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox me = sender as ComboBox;
            gENEROTextBox.Text = me.Text.Substring(0, 1);
        }
    }
}
