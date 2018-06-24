namespace BD_Trab
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.principalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trabalhadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urgênciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carrinhasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalToolStripMenuItem,
            this.utentesToolStripMenuItem,
            this.trabalhadoresToolStripMenuItem,
            this.urgênciasToolStripMenuItem,
            this.carrinhasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(853, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // principalToolStripMenuItem
            // 
            this.principalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.principalToolStripMenuItem.Name = "principalToolStripMenuItem";
            this.principalToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.principalToolStripMenuItem.Text = "Principal";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // utentesToolStripMenuItem
            // 
            this.utentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pesquisarToolStripMenuItem});
            this.utentesToolStripMenuItem.Name = "utentesToolStripMenuItem";
            this.utentesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.utentesToolStripMenuItem.Text = "Utentes";
            this.utentesToolStripMenuItem.Click += new System.EventHandler(this.utentesToolStripMenuItem_Click);
            // 
            // pesquisarToolStripMenuItem
            // 
            this.pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            this.pesquisarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.pesquisarToolStripMenuItem.Text = "Consultar";
            this.pesquisarToolStripMenuItem.Click += new System.EventHandler(this.pesquisarToolStripMenuItem_Click);
            // 
            // trabalhadoresToolStripMenuItem
            // 
            this.trabalhadoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem});
            this.trabalhadoresToolStripMenuItem.Name = "trabalhadoresToolStripMenuItem";
            this.trabalhadoresToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.trabalhadoresToolStripMenuItem.Text = "Trabalhadores";
            this.trabalhadoresToolStripMenuItem.Click += new System.EventHandler(this.trabalhadoresToolStripMenuItem_Click);
            // 
            // urgênciasToolStripMenuItem
            // 
            this.urgênciasToolStripMenuItem.Name = "urgênciasToolStripMenuItem";
            this.urgênciasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.urgênciasToolStripMenuItem.Text = "Urgências";
            this.urgênciasToolStripMenuItem.Click += new System.EventHandler(this.urgênciasToolStripMenuItem_Click);
            // 
            // carrinhasToolStripMenuItem
            // 
            this.carrinhasToolStripMenuItem.Name = "carrinhasToolStripMenuItem";
            this.carrinhasToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.carrinhasToolStripMenuItem.Text = "Carrinhas";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(853, 426);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem principalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trabalhadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urgênciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carrinhasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
    }
}

