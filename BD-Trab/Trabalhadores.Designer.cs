namespace BD_Trab
{
    partial class Trabalhadores
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
            System.Windows.Forms.Label iD_TRABALHADORLabel;
            System.Windows.Forms.Label nOMELabel;
            System.Windows.Forms.Label gENEROLabel;
            System.Windows.Forms.Label mORADALabel;
            System.Windows.Forms.Label eNCARGOLabel;
            System.Windows.Forms.Label tURNOLabel;
            this.iD_TRABALHADORTextBox = new System.Windows.Forms.TextBox();
            this.tRABALHADORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD = new BD_Trab.BD();
            this.nOMETextBox = new System.Windows.Forms.TextBox();
            this.gENEROTextBox = new System.Windows.Forms.TextBox();
            this.mORADATextBox = new System.Windows.Forms.TextBox();
            this.eNCARGOTextBox = new System.Windows.Forms.TextBox();
            this.tURNOTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tRABALHADORTableAdapter = new BD_Trab.BDTableAdapters.TRABALHADORTableAdapter();
            this.tableAdapterManager = new BD_Trab.BDTableAdapters.TableAdapterManager();
            this.nOMEListBox = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cONTACTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cONTACTOSTableAdapter = new BD_Trab.BDTableAdapters.CONTACTOSTableAdapter();
            iD_TRABALHADORLabel = new System.Windows.Forms.Label();
            nOMELabel = new System.Windows.Forms.Label();
            gENEROLabel = new System.Windows.Forms.Label();
            mORADALabel = new System.Windows.Forms.Label();
            eNCARGOLabel = new System.Windows.Forms.Label();
            tURNOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tRABALHADORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cONTACTOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_TRABALHADORLabel
            // 
            iD_TRABALHADORLabel.AutoSize = true;
            iD_TRABALHADORLabel.Location = new System.Drawing.Point(335, 186);
            iD_TRABALHADORLabel.Name = "iD_TRABALHADORLabel";
            iD_TRABALHADORLabel.Size = new System.Drawing.Size(105, 13);
            iD_TRABALHADORLabel.TabIndex = 0;
            iD_TRABALHADORLabel.Text = "ID TRABALHADOR:";
            // 
            // nOMELabel
            // 
            nOMELabel.AutoSize = true;
            nOMELabel.Location = new System.Drawing.Point(335, 212);
            nOMELabel.Name = "nOMELabel";
            nOMELabel.Size = new System.Drawing.Size(42, 13);
            nOMELabel.TabIndex = 2;
            nOMELabel.Text = "NOME:";
            // 
            // gENEROLabel
            // 
            gENEROLabel.AutoSize = true;
            gENEROLabel.Location = new System.Drawing.Point(335, 238);
            gENEROLabel.Name = "gENEROLabel";
            gENEROLabel.Size = new System.Drawing.Size(56, 13);
            gENEROLabel.TabIndex = 4;
            gENEROLabel.Text = "GENERO:";
            // 
            // mORADALabel
            // 
            mORADALabel.AutoSize = true;
            mORADALabel.Location = new System.Drawing.Point(335, 264);
            mORADALabel.Name = "mORADALabel";
            mORADALabel.Size = new System.Drawing.Size(57, 13);
            mORADALabel.TabIndex = 6;
            mORADALabel.Text = "MORADA:";
            // 
            // eNCARGOLabel
            // 
            eNCARGOLabel.AutoSize = true;
            eNCARGOLabel.Location = new System.Drawing.Point(335, 290);
            eNCARGOLabel.Name = "eNCARGOLabel";
            eNCARGOLabel.Size = new System.Drawing.Size(63, 13);
            eNCARGOLabel.TabIndex = 8;
            eNCARGOLabel.Text = "ENCARGO:";
            // 
            // tURNOLabel
            // 
            tURNOLabel.AutoSize = true;
            tURNOLabel.Location = new System.Drawing.Point(335, 316);
            tURNOLabel.Name = "tURNOLabel";
            tURNOLabel.Size = new System.Drawing.Size(49, 13);
            tURNOLabel.TabIndex = 10;
            tURNOLabel.Text = "TURNO:";
            // 
            // iD_TRABALHADORTextBox
            // 
            this.iD_TRABALHADORTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRABALHADORBindingSource, "ID_TRABALHADOR", true));
            this.iD_TRABALHADORTextBox.Location = new System.Drawing.Point(446, 183);
            this.iD_TRABALHADORTextBox.Name = "iD_TRABALHADORTextBox";
            this.iD_TRABALHADORTextBox.ReadOnly = true;
            this.iD_TRABALHADORTextBox.Size = new System.Drawing.Size(317, 20);
            this.iD_TRABALHADORTextBox.TabIndex = 1;
            // 
            // tRABALHADORBindingSource
            // 
            this.tRABALHADORBindingSource.DataMember = "TRABALHADOR";
            this.tRABALHADORBindingSource.DataSource = this.bD;
            // 
            // bD
            // 
            this.bD.DataSetName = "BD";
            this.bD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nOMETextBox
            // 
            this.nOMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRABALHADORBindingSource, "NOME", true));
            this.nOMETextBox.Location = new System.Drawing.Point(446, 209);
            this.nOMETextBox.Name = "nOMETextBox";
            this.nOMETextBox.Size = new System.Drawing.Size(317, 20);
            this.nOMETextBox.TabIndex = 3;
            // 
            // gENEROTextBox
            // 
            this.gENEROTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRABALHADORBindingSource, "GENERO", true));
            this.gENEROTextBox.Location = new System.Drawing.Point(6, 405);
            this.gENEROTextBox.Name = "gENEROTextBox";
            this.gENEROTextBox.Size = new System.Drawing.Size(75, 20);
            this.gENEROTextBox.TabIndex = 5;
            // 
            // mORADATextBox
            // 
            this.mORADATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRABALHADORBindingSource, "MORADA", true));
            this.mORADATextBox.Location = new System.Drawing.Point(446, 261);
            this.mORADATextBox.Name = "mORADATextBox";
            this.mORADATextBox.Size = new System.Drawing.Size(317, 20);
            this.mORADATextBox.TabIndex = 7;
            // 
            // eNCARGOTextBox
            // 
            this.eNCARGOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRABALHADORBindingSource, "ENCARGO", true));
            this.eNCARGOTextBox.Location = new System.Drawing.Point(218, 405);
            this.eNCARGOTextBox.Name = "eNCARGOTextBox";
            this.eNCARGOTextBox.Size = new System.Drawing.Size(74, 20);
            this.eNCARGOTextBox.TabIndex = 9;
            // 
            // tURNOTextBox
            // 
            this.tURNOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRABALHADORBindingSource, "TURNO", true));
            this.tURNOTextBox.Location = new System.Drawing.Point(116, 405);
            this.tURNOTextBox.Name = "tURNOTextBox";
            this.tURNOTextBox.Size = new System.Drawing.Size(86, 20);
            this.tURNOTextBox.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(640, 113);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 32);
            this.button3.TabIndex = 12;
            this.button3.Text = "Apagar Selecionado";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(338, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 32);
            this.button2.TabIndex = 13;
            this.button2.Text = "Adicionar Novo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(492, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 32);
            this.button1.TabIndex = 12;
            this.button1.Text = "Alterar/Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tRABALHADORTableAdapter
            // 
            this.tRABALHADORTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CONTACTOSTableAdapter = null;
            this.tableAdapterManager.TRABALHADORTableAdapter = this.tRABALHADORTableAdapter;
            this.tableAdapterManager.TRABURGTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BD_Trab.BDTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.URGENCIATableAdapter = null;
            this.tableAdapterManager.UTENTETableAdapter = null;
            // 
            // nOMEListBox
            // 
            this.nOMEListBox.CausesValidation = false;
            this.nOMEListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tRABALHADORBindingSource, "NOME", true));
            this.nOMEListBox.DataSource = this.tRABALHADORBindingSource;
            this.nOMEListBox.DisplayMember = "NOME";
            this.nOMEListBox.FormattingEnabled = true;
            this.nOMEListBox.Location = new System.Drawing.Point(9, 104);
            this.nOMEListBox.Name = "nOMEListBox";
            this.nOMEListBox.Size = new System.Drawing.Size(262, 290);
            this.nOMEListBox.TabIndex = 3;
            this.nOMEListBox.SelectedIndexChanged += new System.EventHandler(this.nOMEListBox_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(651, 402);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 37);
            this.button4.TabIndex = 4;
            this.button4.Text = "Voltar ao Menu Principal";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.CausesValidation = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nome",
            "ID_Trabalhador",
            "Genero",
            "Morada",
            "Encargo",
            "Turno"});
            this.comboBox1.Location = new System.Drawing.Point(85, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Procurar Por:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pesquisa:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox4);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(iD_TRABALHADORLabel);
            this.groupBox2.Controls.Add(this.iD_TRABALHADORTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(nOMELabel);
            this.groupBox2.Controls.Add(this.nOMEListBox);
            this.groupBox2.Controls.Add(this.nOMETextBox);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(gENEROLabel);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.gENEROTextBox);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(mORADALabel);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.mORADATextBox);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(eNCARGOLabel);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.eNCARGOTextBox);
            this.groupBox2.Controls.Add(this.tURNOTextBox);
            this.groupBox2.Controls.Add(tURNOLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(790, 445);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // cONTACTOSBindingSource
            // 
            this.cONTACTOSBindingSource.DataMember = "CONTACTOS";
            this.cONTACTOSBindingSource.DataSource = this.bD;
            // 
            // comboBox4
            // 
            this.comboBox4.CausesValidation = false;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Dia",
            "Tarde",
            "Noite"});
            this.comboBox4.Location = new System.Drawing.Point(446, 314);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(317, 21);
            this.comboBox4.TabIndex = 16;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.CausesValidation = false;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.comboBox3.Location = new System.Drawing.Point(446, 234);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(317, 21);
            this.comboBox3.TabIndex = 15;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.CausesValidation = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Enfermeiro",
            "Limpeza"});
            this.comboBox2.Location = new System.Drawing.Point(446, 287);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(317, 21);
            this.comboBox2.TabIndex = 14;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cONTACTOSTableAdapter
            // 
            this.cONTACTOSTableAdapter.ClearBeforeFill = true;
            // 
            // Trabalhadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 457);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Trabalhadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trabalhadores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Trabalhadores_FormClosing);
            this.Load += new System.EventHandler(this.Trabalhadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tRABALHADORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cONTACTOSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BD bD;
        private System.Windows.Forms.BindingSource tRABALHADORBindingSource;
        private BDTableAdapters.TRABALHADORTableAdapter tRABALHADORTableAdapter;
        private BDTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iD_TRABALHADORTextBox;
        private System.Windows.Forms.TextBox nOMETextBox;
        private System.Windows.Forms.TextBox gENEROTextBox;
        private System.Windows.Forms.TextBox mORADATextBox;
        private System.Windows.Forms.TextBox eNCARGOTextBox;
        private System.Windows.Forms.TextBox tURNOTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox nOMEListBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource cONTACTOSBindingSource;
        private BDTableAdapters.CONTACTOSTableAdapter cONTACTOSTableAdapter;
    }
}