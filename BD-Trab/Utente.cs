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

        }

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
        }

        private void button4_Click(object sender, EventArgs e)
        {
            principal.Show();
            Hide();
        }
    }
}
