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
    public partial class Urgencias : Form
    {
        private FormPrincipal principal;
        private bool checkClose = true;
        private string search;
        private string filter;
        private int id_urgencia;

        public Urgencias(Form form)
        {
            InitializeComponent();
            principal = (FormPrincipal)form;
        }

        private void Urgencias_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD.TRABURG' table. You can move, or remove it, as needed.
            this.tRABURGTableAdapter.Fill(this.bD.TRABURG);
            // TODO: This line of code loads data into the 'bD.TRABALHADOR' table. You can move, or remove it, as needed.
            this.tRABALHADORTableAdapter.Fill(this.bD.TRABALHADOR);
            // TODO: This line of code loads data into the 'bD.UTENTE' table. You can move, or remove it, as needed.
            this.uTENTETableAdapter.Fill(this.bD.UTENTE);
            // TODO: This line of code loads data into the 'bD.URGENCIA' table. You can move, or remove it, as needed.
            this.uRGENCIATableAdapter.Fill(this.bD.URGENCIA);

            this.comboBox1.SelectedIndex = 0;
            id_urgencia = int.Parse(iD_URGENCIATextBox.Text);
            tRABURGBindingSource.Filter = string.Format("ID_Urgencia = {0}", id_urgencia);

            iD_TRABALHADORTextBox1.Hide();
            iD_URGENCIATextBox1.Hide();
        }

        private void Urgencias_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (checkClose)
                principal.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            search = this.textBox2.Text;
            if (filter[0] == 'I')
            {
                if (int.TryParse(search, out int id))
                    uRGENCIABindingSource.Filter = string.Format("{0} = {1}", filter, id);
                else
                    uRGENCIABindingSource.Filter = "";
            }
            else if (filter.Substring(0, 2) == "DA")
            {
                try
                {
                    String[] array = search.Split('/');

                    DateTime date = new DateTime(int.Parse(array[0]), int.Parse(array[1]), int.Parse(array[1]));

                    uRGENCIABindingSource.Filter = String.Format("DATA_ = '{0:YYYY-MM-DD}'", search);
                }
                catch { }

                //uRGENCIABindingSource.Filter = "TO_CHAR(DATA_,'YYYY-MM-DD') like '%" + search + "%'";
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
            tableAdapterManager.UpdateAll(bD);
            checkClose = false;
            principal.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uRGENCIABindingSource.AddNew();
            iD_URGENCIATextBox.Text = uRGENCIATableAdapter.GetNextID_Urgencia().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uRGENCIABindingSource.EndEdit();
            uRGENCIABindingSource.AddNew();
            uRGENCIABindingSource.RemoveCurrent();
            tRABURGBindingSource.EndEdit();
            tRABURGBindingSource.AddNew();
            tRABURGBindingSource.RemoveCurrent();
            try
            {
                tableAdapterManager.UpdateAll(bD);
            }
            catch
            {
                MessageBox.Show("Informação Inválida");
            }
        }

        private void iD_URGENCIAListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                tRABURGBindingSource.Filter = string.Format("ID_Urgencia = {0}", iD_URGENCIATextBox.Text);
            }
            catch { }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                tRABURGBindingSource.RemoveCurrent();
                Validate();
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                uRGENCIABindingSource.RemoveCurrent();
            }
            catch { }
        }
        public void SetCheckClose(bool x)
        {
            checkClose = x;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tRABURGBindingSource.AddNew();
            iD_TRABALHADORTextBox1.Text = textBox1.Text;
            iD_URGENCIATextBox1.Text = iD_URGENCIATextBox.Text;
            Validate();
            tRABURGBindingSource.EndEdit();
            tRABURGBindingSource.AddNew();
            tRABURGBindingSource.RemoveCurrent();
            tRABURGTableAdapter.Update(bD.TRABURG);
        }
    }
}
