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
            else if (filter.Substring(0,2) == "Da")
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            uRGENCIABindingSource.AddNew();
            //iD_URGENCIATextBox.Text = uRGENCIATableAdapter.GetNextID_Urgencia().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uRGENCIABindingSource.EndEdit();
            uRGENCIABindingSource.AddNew();
            uRGENCIABindingSource.RemoveCurrent();
            tableAdapterManager.UpdateAll(bD);
        }

        private void iD_URGENCIAListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*string connstr = @"Server=.\SQLEXPRESS ;Initial Catalog=RPSJDB;Integrated Security=True;";
             string query = "Select ID_Trabalhador" +
                            " From TrabUrg" +
                            " Where ID_Urgencia = " + id_urgencia;
             SqlDataAdapter adapter = new SqlDataAdapter(query, connstr);
             DataTable table = new DataTable();
             adapter.Fill(table);
             BindingSource bindingSource1 = new BindingSource();
             BindingSource bindingSource1.DataSource = table;*/
            id_urgencia = int.Parse(iD_URGENCIATextBox.Text);

            tRABURGBindingSource.Filter = string.Format("ID_Urgencia = {0}",id_urgencia);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tRABURGBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tRABURGBindingSource.RemoveCurrent();
        }

    }
}
