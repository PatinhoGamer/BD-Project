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
        public Trabalhadores()
        {
            InitializeComponent();
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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tRABALHADORBindingSource.AddNew();
            this.iD_TRABALHADORTextBox.Text = this.tRABALHADORTableAdapter.GetNextID_Trabalhador().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tRABALHADORBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.tRABALHADORBindingSource.RemoveCurrent();
            this.tableAdapterManager.UpdateAll(this.bD);
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
