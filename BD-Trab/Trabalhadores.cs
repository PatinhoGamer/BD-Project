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

        }
    }
}
