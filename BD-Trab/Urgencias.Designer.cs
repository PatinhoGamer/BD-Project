namespace BD_Trab
{
    partial class Urgencias
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label nOMELabel;
            System.Windows.Forms.Label iD_URGENCIALabel;
            System.Windows.Forms.Label iD_UTENTELabel;
            System.Windows.Forms.Label iD_TRABALHADORLabel;
            System.Windows.Forms.Label dATA_Label;
            System.Windows.Forms.Label dESCRICAOLabel;
            System.Windows.Forms.Label label3;
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.iD_URGENCIATextBox1 = new System.Windows.Forms.TextBox();
            this.tRABURGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD = new BD_Trab.BD();
            this.iD_TRABALHADORTextBox1 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.iD_TRABALHADORListBox = new System.Windows.Forms.ListBox();
            this.tRABALHADORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iD_URGENCIAListBox = new System.Windows.Forms.ListBox();
            this.uRGENCIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iD_URGENCIATextBox = new System.Windows.Forms.TextBox();
            this.iD_UTENTETextBox = new System.Windows.Forms.TextBox();
            this.iD_TRABALHADORTextBox = new System.Windows.Forms.TextBox();
            this.dATA_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dESCRICAOTextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.uTENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uRGENCIATableAdapter = new BD_Trab.BDTableAdapters.URGENCIATableAdapter();
            this.tableAdapterManager = new BD_Trab.BDTableAdapters.TableAdapterManager();
            this.bDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uTENTETableAdapter = new BD_Trab.BDTableAdapters.UTENTETableAdapter();
            this.tRABALHADORTableAdapter = new BD_Trab.BDTableAdapters.TRABALHADORTableAdapter();
            this.tRABURGTableAdapter = new BD_Trab.BDTableAdapters.TRABURGTableAdapter();
            label1 = new System.Windows.Forms.Label();
            nOMELabel = new System.Windows.Forms.Label();
            iD_URGENCIALabel = new System.Windows.Forms.Label();
            iD_UTENTELabel = new System.Windows.Forms.Label();
            iD_TRABALHADORLabel = new System.Windows.Forms.Label();
            dATA_Label = new System.Windows.Forms.Label();
            dESCRICAOLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRABURGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRABALHADORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uRGENCIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uTENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // nOMELabel
            // 
            nOMELabel.AutoSize = true;
            nOMELabel.Location = new System.Drawing.Point(4, 16);
            nOMELabel.Name = "nOMELabel";
            nOMELabel.Size = new System.Drawing.Size(69, 13);
            nOMELabel.TabIndex = 3;
            nOMELabel.Text = "Procurar Por:";
            // 
            // iD_URGENCIALabel
            // 
            iD_URGENCIALabel.AutoSize = true;
            iD_URGENCIALabel.Location = new System.Drawing.Point(347, 116);
            iD_URGENCIALabel.Name = "iD_URGENCIALabel";
            iD_URGENCIALabel.Size = new System.Drawing.Size(80, 13);
            iD_URGENCIALabel.TabIndex = 10;
            iD_URGENCIALabel.Text = "ID URGENCIA:";
            // 
            // iD_UTENTELabel
            // 
            iD_UTENTELabel.AutoSize = true;
            iD_UTENTELabel.Location = new System.Drawing.Point(347, 142);
            iD_UTENTELabel.Name = "iD_UTENTELabel";
            iD_UTENTELabel.Size = new System.Drawing.Size(68, 13);
            iD_UTENTELabel.TabIndex = 12;
            iD_UTENTELabel.Text = "ID UTENTE:";
            // 
            // iD_TRABALHADORLabel
            // 
            iD_TRABALHADORLabel.AutoSize = true;
            iD_TRABALHADORLabel.Location = new System.Drawing.Point(347, 168);
            iD_TRABALHADORLabel.Name = "iD_TRABALHADORLabel";
            iD_TRABALHADORLabel.Size = new System.Drawing.Size(105, 13);
            iD_TRABALHADORLabel.TabIndex = 14;
            iD_TRABALHADORLabel.Text = "ID TRABALHADOR:";
            // 
            // dATA_Label
            // 
            dATA_Label.AutoSize = true;
            dATA_Label.Location = new System.Drawing.Point(347, 195);
            dATA_Label.Name = "dATA_Label";
            dATA_Label.Size = new System.Drawing.Size(42, 13);
            dATA_Label.TabIndex = 16;
            dATA_Label.Text = "DATA :";
            // 
            // dESCRICAOLabel
            // 
            dESCRICAOLabel.AutoSize = true;
            dESCRICAOLabel.Location = new System.Drawing.Point(347, 220);
            dESCRICAOLabel.Name = "dESCRICAOLabel";
            dESCRICAOLabel.Size = new System.Drawing.Size(72, 13);
            dESCRICAOLabel.TabIndex = 18;
            dESCRICAOLabel.Text = "DESCRICAO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(347, 256);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(105, 13);
            label3.TabIndex = 23;
            label3.Text = "ID Outros Ajudantes:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.iD_URGENCIATextBox1);
            this.groupBox2.Controls.Add(this.iD_TRABALHADORTextBox1);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.iD_TRABALHADORListBox);
            this.groupBox2.Controls.Add(label3);
            this.groupBox2.Controls.Add(this.iD_URGENCIAListBox);
            this.groupBox2.Controls.Add(iD_URGENCIALabel);
            this.groupBox2.Controls.Add(this.iD_URGENCIATextBox);
            this.groupBox2.Controls.Add(iD_UTENTELabel);
            this.groupBox2.Controls.Add(this.iD_UTENTETextBox);
            this.groupBox2.Controls.Add(iD_TRABALHADORLabel);
            this.groupBox2.Controls.Add(this.iD_TRABALHADORTextBox);
            this.groupBox2.Controls.Add(dATA_Label);
            this.groupBox2.Controls.Add(this.dATA_DateTimePicker);
            this.groupBox2.Controls.Add(dESCRICAOLabel);
            this.groupBox2.Controls.Add(this.dESCRICAOTextBox);
            this.groupBox2.Controls.Add(label1);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(nOMELabel);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(778, 426);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(552, 256);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 20);
            this.textBox1.TabIndex = 32;
            // 
            // iD_URGENCIATextBox1
            // 
            this.iD_URGENCIATextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRABURGBindingSource, "ID_URGENCIA", true));
            this.iD_URGENCIATextBox1.Location = new System.Drawing.Point(294, 311);
            this.iD_URGENCIATextBox1.Name = "iD_URGENCIATextBox1";
            this.iD_URGENCIATextBox1.Size = new System.Drawing.Size(100, 20);
            this.iD_URGENCIATextBox1.TabIndex = 29;
            // 
            // tRABURGBindingSource
            // 
            this.tRABURGBindingSource.DataMember = "TRABURG";
            this.tRABURGBindingSource.DataSource = this.bD;
            // 
            // bD
            // 
            this.bD.DataSetName = "BD";
            this.bD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iD_TRABALHADORTextBox1
            // 
            this.iD_TRABALHADORTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRABURGBindingSource, "ID_TRABALHADOR", true));
            this.iD_TRABALHADORTextBox1.Location = new System.Drawing.Point(294, 337);
            this.iD_TRABALHADORTextBox1.Name = "iD_TRABALHADORTextBox1";
            this.iD_TRABALHADORTextBox1.Size = new System.Drawing.Size(100, 20);
            this.iD_TRABALHADORTextBox1.TabIndex = 31;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(552, 311);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(106, 23);
            this.button6.TabIndex = 26;
            this.button6.Text = "Remover Ajudante";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(552, 282);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 23);
            this.button5.TabIndex = 25;
            this.button5.Text = "Adicionar Ajudante";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // iD_TRABALHADORListBox
            // 
            this.iD_TRABALHADORListBox.CausesValidation = false;
            this.iD_TRABALHADORListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tRABALHADORBindingSource, "ID_TRABALHADOR", true));
            this.iD_TRABALHADORListBox.DataSource = this.tRABURGBindingSource;
            this.iD_TRABALHADORListBox.DisplayMember = "ID_TRABALHADOR";
            this.iD_TRABALHADORListBox.FormattingEnabled = true;
            this.iD_TRABALHADORListBox.Location = new System.Drawing.Point(460, 256);
            this.iD_TRABALHADORListBox.Name = "iD_TRABALHADORListBox";
            this.iD_TRABALHADORListBox.Size = new System.Drawing.Size(76, 147);
            this.iD_TRABALHADORListBox.TabIndex = 24;
            // 
            // tRABALHADORBindingSource
            // 
            this.tRABALHADORBindingSource.DataMember = "TRABALHADOR";
            this.tRABALHADORBindingSource.DataSource = this.bD;
            // 
            // iD_URGENCIAListBox
            // 
            this.iD_URGENCIAListBox.CausesValidation = false;
            this.iD_URGENCIAListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.uRGENCIABindingSource, "ID_URGENCIA", true));
            this.iD_URGENCIAListBox.DataSource = this.uRGENCIABindingSource;
            this.iD_URGENCIAListBox.DisplayMember = "ID_URGENCIA";
            this.iD_URGENCIAListBox.FormattingEnabled = true;
            this.iD_URGENCIAListBox.Location = new System.Drawing.Point(7, 103);
            this.iD_URGENCIAListBox.Name = "iD_URGENCIAListBox";
            this.iD_URGENCIAListBox.Size = new System.Drawing.Size(262, 303);
            this.iD_URGENCIAListBox.TabIndex = 20;
            this.iD_URGENCIAListBox.SelectedIndexChanged += new System.EventHandler(this.iD_URGENCIAListBox_SelectedIndexChanged);
            // 
            // uRGENCIABindingSource
            // 
            this.uRGENCIABindingSource.DataMember = "URGENCIA";
            this.uRGENCIABindingSource.DataSource = this.bD;
            // 
            // iD_URGENCIATextBox
            // 
            this.iD_URGENCIATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uRGENCIABindingSource, "ID_URGENCIA", true));
            this.iD_URGENCIATextBox.Location = new System.Drawing.Point(458, 113);
            this.iD_URGENCIATextBox.Name = "iD_URGENCIATextBox";
            this.iD_URGENCIATextBox.ReadOnly = true;
            this.iD_URGENCIATextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_URGENCIATextBox.TabIndex = 11;
            // 
            // iD_UTENTETextBox
            // 
            this.iD_UTENTETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uRGENCIABindingSource, "ID_UTENTE", true));
            this.iD_UTENTETextBox.Location = new System.Drawing.Point(458, 139);
            this.iD_UTENTETextBox.Name = "iD_UTENTETextBox";
            this.iD_UTENTETextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_UTENTETextBox.TabIndex = 13;
            // 
            // iD_TRABALHADORTextBox
            // 
            this.iD_TRABALHADORTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uRGENCIABindingSource, "ID_TRABALHADOR", true));
            this.iD_TRABALHADORTextBox.Location = new System.Drawing.Point(458, 165);
            this.iD_TRABALHADORTextBox.Name = "iD_TRABALHADORTextBox";
            this.iD_TRABALHADORTextBox.Size = new System.Drawing.Size(200, 20);
            this.iD_TRABALHADORTextBox.TabIndex = 15;
            // 
            // dATA_DateTimePicker
            // 
            this.dATA_DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.uRGENCIABindingSource, "DATA_", true));
            this.dATA_DateTimePicker.Location = new System.Drawing.Point(458, 191);
            this.dATA_DateTimePicker.Name = "dATA_DateTimePicker";
            this.dATA_DateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dATA_DateTimePicker.TabIndex = 17;
            // 
            // dESCRICAOTextBox
            // 
            this.dESCRICAOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uRGENCIABindingSource, "DESCRICAO", true));
            this.dESCRICAOTextBox.Location = new System.Drawing.Point(458, 217);
            this.dESCRICAOTextBox.Name = "dESCRICAOTextBox";
            this.dESCRICAOTextBox.Size = new System.Drawing.Size(200, 20);
            this.dESCRICAOTextBox.TabIndex = 19;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(637, 373);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 47);
            this.button4.TabIndex = 5;
            this.button4.Text = "Voltar ao Menu Principal";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            "ID_Urgencia",
            "ID_Utente",
            "ID_Trabalhador",
            "Descricao"});
            this.comboBox1.Location = new System.Drawing.Point(89, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Adicionar Novo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(460, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 34);
            this.button2.TabIndex = 9;
            this.button2.Text = "Alterar/Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(636, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 34);
            this.button3.TabIndex = 10;
            this.button3.Text = "Apagar Selecionado";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // uTENTEBindingSource
            // 
            this.uTENTEBindingSource.DataMember = "UTENTE";
            this.uTENTEBindingSource.DataSource = this.bD;
            // 
            // uRGENCIATableAdapter
            // 
            this.uRGENCIATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CONTACTOSTableAdapter = null;
            this.tableAdapterManager.TRABALHADORTableAdapter = null;
            this.tableAdapterManager.TRABURGTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BD_Trab.BDTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.URGENCIATableAdapter = this.uRGENCIATableAdapter;
            this.tableAdapterManager.UTENTETableAdapter = null;
            // 
            // bDBindingSource
            // 
            this.bDBindingSource.DataSource = this.bD;
            this.bDBindingSource.Position = 0;
            // 
            // uTENTETableAdapter
            // 
            this.uTENTETableAdapter.ClearBeforeFill = true;
            // 
            // tRABALHADORTableAdapter
            // 
            this.tRABALHADORTableAdapter.ClearBeforeFill = true;
            // 
            // tRABURGTableAdapter
            // 
            this.tRABURGTableAdapter.ClearBeforeFill = true;
            // 
            // Urgencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Urgencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urgencias";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Urgencias_FormClosing_1);
            this.Load += new System.EventHandler(this.Urgencias_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRABURGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRABALHADORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uRGENCIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uTENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private BD bD;
        private System.Windows.Forms.BindingSource uRGENCIABindingSource;
        private BDTableAdapters.URGENCIATableAdapter uRGENCIATableAdapter;
        private BDTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ListBox iD_URGENCIAListBox;
        private System.Windows.Forms.TextBox iD_URGENCIATextBox;
        private System.Windows.Forms.TextBox iD_UTENTETextBox;
        private System.Windows.Forms.TextBox iD_TRABALHADORTextBox;
        private System.Windows.Forms.DateTimePicker dATA_DateTimePicker;
        private System.Windows.Forms.TextBox dESCRICAOTextBox;
        private System.Windows.Forms.BindingSource bDBindingSource;
        private System.Windows.Forms.BindingSource uTENTEBindingSource;
        private BDTableAdapters.UTENTETableAdapter uTENTETableAdapter;
        private System.Windows.Forms.BindingSource tRABALHADORBindingSource;
        private BDTableAdapters.TRABALHADORTableAdapter tRABALHADORTableAdapter;
        private System.Windows.Forms.ListBox iD_TRABALHADORListBox;
        private System.Windows.Forms.BindingSource tRABURGBindingSource;
        private BDTableAdapters.TRABURGTableAdapter tRABURGTableAdapter;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox iD_URGENCIATextBox1;
        private System.Windows.Forms.TextBox iD_TRABALHADORTextBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}