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

        public Trabalhadores(Form form)
        {
            principal = (FormPrincipal)form;
            InitializeComponent();
            groupBox1.Hide();
        }

        private void tRABALHADORBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tRABALHADORBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD);

        }

        private void Trabalhadores_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bD.TRABALHADOR'. Você pode movê-la ou removê-la conforme necessário.
            this.tRABALHADORTableAdapter.Fill(this.bD.TRABALHADOR);
            this.comboBox1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            groupBox2.Hide();
            groupBox1.Show();

            this.tRABALHADORBindingSource.AddNew();

            this.iD_TRABALHADORTextBox.Text = this.tRABALHADORTableAdapter.GetNextID_Trabalhador().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2.Hide();
            groupBox1.Show();

            if (!this.Validate())
                MessageBox.Show("Not Valid!");
            this.tRABALHADORBindingSource.EndEdit();
            this.tRABALHADORBindingSource.AddNew();
            this.tRABALHADORBindingSource.RemoveCurrent();
            this.tableAdapterManager.UpdateAll(this.bD);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.tRABALHADORBindingSource.RemoveCurrent();
            this.tableAdapterManager.UpdateAll(this.bD);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkClose = false;
            principal.Show();
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter = this.comboBox1.SelectedItem.ToString().ToUpper();
            //this.nOMEListBox.DisplayMember = filter;
        }

        private void Trabalhadores_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(checkClose)
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

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }



        /*
       private void button1_Click(object sender, EventArgs e)
       {
           this.uTENTEBindingSource.AddNew();
           this.iD_UTENTETextBox.Text = this.uTENTETableAdapter.GetNextID_Utente().ToString();
       }

       private void button2_Click(object sender, EventArgs e)
       {
           this.Validate();
           this.uTENTEBindingSource.EndEdit();
           this.tableAdapterManager.UpdateAll(this.bd1);
       }

       private void button3_Click(object sender, EventArgs e)
       {
           this.uTENTEBindingSource.RemoveCurrent();
           this.tableAdapterManager.UpdateAll(this.bd1);
       }*/
    }
}
