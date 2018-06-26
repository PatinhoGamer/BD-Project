namespace BD_Trab
{
    partial class Utente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nOMELabel;
            System.Windows.Forms.Label iD_UTENTELabel;
            System.Windows.Forms.Label nOMELabel1;
            System.Windows.Forms.Label gENEROLabel;
            System.Windows.Forms.Label mORADALabel;
            System.Windows.Forms.Label label1;
            this.bd1 = new BD_Trab.BD();
            this.uTENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uTENTETableAdapter = new BD_Trab.BDTableAdapters.UTENTETableAdapter();
            this.tableAdapterManager = new BD_Trab.BDTableAdapters.TableAdapterManager();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.iD_UTENTETextBox = new System.Windows.Forms.TextBox();
            this.gENEROTextBox = new System.Windows.Forms.TextBox();
            this.mORADATextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.nOMEListBox = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            nOMELabel = new System.Windows.Forms.Label();
            iD_UTENTELabel = new System.Windows.Forms.Label();
            nOMELabel1 = new System.Windows.Forms.Label();
            gENEROLabel = new System.Windows.Forms.Label();
            mORADALabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bd1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uTENTEBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nOMELabel
            // 
            nOMELabel.AutoSize = true;
            nOMELabel.Location = new System.Drawing.Point(4, 16);
            nOMELabel.Name = "nOMELabel";
            nOMELabel.Size = new System.Drawing.Size(69, 13);
            nOMELabel.TabIndex = 3;
            nOMELabel.Text = "Procurar Por:";
            // 
            // iD_UTENTELabel
            // 
            iD_UTENTELabel.AutoSize = true;
            iD_UTENTELabel.Location = new System.Drawing.Point(295, 215);
            iD_UTENTELabel.Name = "iD_UTENTELabel";
            iD_UTENTELabel.Size = new System.Drawing.Size(68, 13);
            iD_UTENTELabel.TabIndex = 10;
            iD_UTENTELabel.Text = "ID UTENTE:";
            // 
            // nOMELabel1
            // 
            nOMELabel1.AutoSize = true;
            nOMELabel1.Location = new System.Drawing.Point(295, 238);
            nOMELabel1.Name = "nOMELabel1";
            nOMELabel1.Size = new System.Drawing.Size(42, 13);
            nOMELabel1.TabIndex = 12;
            nOMELabel1.Text = "NOME:";
            // 
            // gENEROLabel
            // 
            gENEROLabel.AutoSize = true;
            gENEROLabel.Location = new System.Drawing.Point(293, 267);
            gENEROLabel.Name = "gENEROLabel";
            gENEROLabel.Size = new System.Drawing.Size(56, 13);
            gENEROLabel.TabIndex = 14;
            gENEROLabel.Text = "GENERO:";
            // 
            // mORADALabel
            // 
            mORADALabel.AutoSize = true;
            mORADALabel.Location = new System.Drawing.Point(293, 293);
            mORADALabel.Name = "mORADALabel";
            mORADALabel.Size = new System.Drawing.Size(57, 13);
            mORADALabel.TabIndex = 16;
            mORADALabel.Text = "MORADA:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(4, 57);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(53, 13);
            label1.TabIndex = 8;
            label1.Text = "Pesquisa:";
            // 
            // bd1
            // 
            this.bd1.DataSetName = "BD";
            this.bd1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uTENTEBindingSource
            // 
            this.uTENTEBindingSource.DataMember = "UTENTE";
            this.uTENTEBindingSource.DataSource = this.bd1;
            // 
            // uTENTETableAdapter
            // 
            this.uTENTETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CONTACTOSTableAdapter = null;
            this.tableAdapterManager.TRABALHADORTableAdapter = null;
            this.tableAdapterManager.TRABURGTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BD_Trab.BDTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.URGENCIATableAdapter = null;
            this.tableAdapterManager.UTENTETableAdapter = this.uTENTETableAdapter;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uTENTEBindingSource, "NOME", true));
            this.textBox1.Location = new System.Drawing.Point(400, 238);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 20);
            this.textBox1.TabIndex = 18;
            // 
            // iD_UTENTETextBox
            // 
            this.iD_UTENTETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uTENTEBindingSource, "ID_UTENTE", true));
            this.iD_UTENTETextBox.Location = new System.Drawing.Point(400, 212);
            this.iD_UTENTETextBox.Name = "iD_UTENTETextBox";
            this.iD_UTENTETextBox.ReadOnly = true;
            this.iD_UTENTETextBox.Size = new System.Drawing.Size(316, 20);
            this.iD_UTENTETextBox.TabIndex = 11;
            // 
            // gENEROTextBox
            // 
            this.gENEROTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uTENTEBindingSource, "GENERO", true));
            this.gENEROTextBox.Location = new System.Drawing.Point(400, 264);
            this.gENEROTextBox.Name = "gENEROTextBox";
            this.gENEROTextBox.Size = new System.Drawing.Size(316, 20);
            this.gENEROTextBox.TabIndex = 15;
            // 
            // mORADATextBox
            // 
            this.mORADATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uTENTEBindingSource, "MORADA", true));
            this.mORADATextBox.Location = new System.Drawing.Point(400, 290);
            this.mORADATextBox.Name = "mORADATextBox";
            this.mORADATextBox.Size = new System.Drawing.Size(316, 20);
            this.mORADATextBox.TabIndex = 17;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(640, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 29);
            this.button3.TabIndex = 10;
            this.button3.Text = "Apagar Selecionado";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(464, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 34);
            this.button2.TabIndex = 9;
            this.button2.Text = "Alterar/Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Adicionar Novo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nOMEListBox
            // 
            this.nOMEListBox.CausesValidation = false;
            this.nOMEListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.uTENTEBindingSource, "NOME", true));
            this.nOMEListBox.DataSource = this.uTENTEBindingSource;
            this.nOMEListBox.DisplayMember = "NOME";
            this.nOMEListBox.FormattingEnabled = true;
            this.nOMEListBox.Location = new System.Drawing.Point(7, 107);
            this.nOMEListBox.Name = "nOMEListBox";
            this.nOMEListBox.Size = new System.Drawing.Size(262, 303);
            this.nOMEListBox.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(618, 359);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 47);
            this.button4.TabIndex = 5;
            this.button4.Text = "Voltar ao Menu Principal";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(label1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(iD_UTENTELabel);
            this.groupBox2.Controls.Add(this.iD_UTENTETextBox);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(nOMELabel1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(gENEROLabel);
            this.groupBox2.Controls.Add(this.nOMEListBox);
            this.groupBox2.Controls.Add(this.gENEROTextBox);
            this.groupBox2.Controls.Add(nOMELabel);
            this.groupBox2.Controls.Add(mORADALabel);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.mORADATextBox);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 426);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(89, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nome",
            "ID_Utente",
            "Genero",
            "Morada"});
            this.comboBox1.Location = new System.Drawing.Point(89, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Utente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Utente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Utente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Utente_FormClosing);
            this.Load += new System.EventHandler(this.Utente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uTENTEBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BD bd1;
        private System.Windows.Forms.BindingSource uTENTEBindingSource;
        private BDTableAdapters.UTENTETableAdapter uTENTETableAdapter;
        private BDTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox iD_UTENTETextBox;
        private System.Windows.Forms.TextBox gENEROTextBox;
        private System.Windows.Forms.TextBox mORADATextBox;
        private System.Windows.Forms.ListBox nOMEListBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}