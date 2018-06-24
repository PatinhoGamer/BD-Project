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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Utente));
            this.bd1 = new BD_Trab.BD();
            this.uTENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uTENTETableAdapter = new BD_Trab.BDTableAdapters.UTENTETableAdapter();
            this.tableAdapterManager = new BD_Trab.BDTableAdapters.TableAdapterManager();
            this.uTENTEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.uTENTEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.iD_UTENTETextBox = new System.Windows.Forms.TextBox();
            this.gENEROTextBox = new System.Windows.Forms.TextBox();
            this.mORADATextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.nOMEListBox = new System.Windows.Forms.ListBox();
            nOMELabel = new System.Windows.Forms.Label();
            iD_UTENTELabel = new System.Windows.Forms.Label();
            nOMELabel1 = new System.Windows.Forms.Label();
            gENEROLabel = new System.Windows.Forms.Label();
            mORADALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bd1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uTENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uTENTEBindingNavigator)).BeginInit();
            this.uTENTEBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nOMELabel
            // 
            nOMELabel.AutoSize = true;
            nOMELabel.Location = new System.Drawing.Point(29, 121);
            nOMELabel.Name = "nOMELabel";
            nOMELabel.Size = new System.Drawing.Size(42, 13);
            nOMELabel.TabIndex = 3;
            nOMELabel.Text = "NOME:";
            // 
            // iD_UTENTELabel
            // 
            iD_UTENTELabel.AutoSize = true;
            iD_UTENTELabel.Location = new System.Drawing.Point(51, 53);
            iD_UTENTELabel.Name = "iD_UTENTELabel";
            iD_UTENTELabel.Size = new System.Drawing.Size(68, 13);
            iD_UTENTELabel.TabIndex = 10;
            iD_UTENTELabel.Text = "ID UTENTE:";
            // 
            // nOMELabel1
            // 
            nOMELabel1.AutoSize = true;
            nOMELabel1.Location = new System.Drawing.Point(51, 76);
            nOMELabel1.Name = "nOMELabel1";
            nOMELabel1.Size = new System.Drawing.Size(42, 13);
            nOMELabel1.TabIndex = 12;
            nOMELabel1.Text = "NOME:";
            // 
            // gENEROLabel
            // 
            gENEROLabel.AutoSize = true;
            gENEROLabel.Location = new System.Drawing.Point(49, 105);
            gENEROLabel.Name = "gENEROLabel";
            gENEROLabel.Size = new System.Drawing.Size(56, 13);
            gENEROLabel.TabIndex = 14;
            gENEROLabel.Text = "GENERO:";
            // 
            // mORADALabel
            // 
            mORADALabel.AutoSize = true;
            mORADALabel.Location = new System.Drawing.Point(49, 131);
            mORADALabel.Name = "mORADALabel";
            mORADALabel.Size = new System.Drawing.Size(57, 13);
            mORADALabel.TabIndex = 16;
            mORADALabel.Text = "MORADA:";
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
            // uTENTEBindingNavigator
            // 
            this.uTENTEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.uTENTEBindingNavigator.BindingSource = this.uTENTEBindingSource;
            this.uTENTEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.uTENTEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.uTENTEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.uTENTEBindingNavigatorSaveItem});
            this.uTENTEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.uTENTEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.uTENTEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.uTENTEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.uTENTEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.uTENTEBindingNavigator.Name = "uTENTEBindingNavigator";
            this.uTENTEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.uTENTEBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.uTENTEBindingNavigator.TabIndex = 0;
            this.uTENTEBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover seguinte";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // uTENTEBindingNavigatorSaveItem
            // 
            this.uTENTEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uTENTEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("uTENTEBindingNavigatorSaveItem.Image")));
            this.uTENTEBindingNavigatorSaveItem.Name = "uTENTEBindingNavigatorSaveItem";
            this.uTENTEBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.uTENTEBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.uTENTEBindingNavigatorSaveItem.Click += new System.EventHandler(this.uTENTEBindingNavigatorSaveItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(iD_UTENTELabel);
            this.groupBox1.Controls.Add(this.iD_UTENTETextBox);
            this.groupBox1.Controls.Add(nOMELabel1);
            this.groupBox1.Controls.Add(gENEROLabel);
            this.groupBox1.Controls.Add(this.gENEROTextBox);
            this.groupBox1.Controls.Add(mORADALabel);
            this.groupBox1.Controls.Add(this.mORADATextBox);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(274, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 336);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uTENTEBindingSource, "NOME", true));
            this.textBox1.Location = new System.Drawing.Point(156, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 18;
            // 
            // iD_UTENTETextBox
            // 
            this.iD_UTENTETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uTENTEBindingSource, "ID_UTENTE", true));
            this.iD_UTENTETextBox.Location = new System.Drawing.Point(156, 50);
            this.iD_UTENTETextBox.Name = "iD_UTENTETextBox";
            this.iD_UTENTETextBox.ReadOnly = true;
            this.iD_UTENTETextBox.Size = new System.Drawing.Size(176, 20);
            this.iD_UTENTETextBox.TabIndex = 11;
            // 
            // gENEROTextBox
            // 
            this.gENEROTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uTENTEBindingSource, "GENERO", true));
            this.gENEROTextBox.Location = new System.Drawing.Point(156, 102);
            this.gENEROTextBox.Name = "gENEROTextBox";
            this.gENEROTextBox.Size = new System.Drawing.Size(176, 20);
            this.gENEROTextBox.TabIndex = 15;
            // 
            // mORADATextBox
            // 
            this.mORADATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uTENTEBindingSource, "MORADA", true));
            this.mORADATextBox.Location = new System.Drawing.Point(156, 128);
            this.mORADATextBox.Name = "mORADATextBox";
            this.mORADATextBox.Size = new System.Drawing.Size(176, 20);
            this.mORADATextBox.TabIndex = 17;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(302, 244);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Apagar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Alterar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nOMEListBox
            // 
            this.nOMEListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.uTENTEBindingSource, "NOME", true));
            this.nOMEListBox.DataSource = this.uTENTEBindingSource;
            this.nOMEListBox.DisplayMember = "NOME";
            this.nOMEListBox.FormattingEnabled = true;
            this.nOMEListBox.Location = new System.Drawing.Point(32, 165);
            this.nOMEListBox.Name = "nOMEListBox";
            this.nOMEListBox.Size = new System.Drawing.Size(158, 251);
            this.nOMEListBox.TabIndex = 4;
            // 
            // Utente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(nOMELabel);
            this.Controls.Add(this.nOMEListBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.uTENTEBindingNavigator);
            this.Name = "Utente";
            this.Text = "Utente";
            this.Load += new System.EventHandler(this.Utente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uTENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uTENTEBindingNavigator)).EndInit();
            this.uTENTEBindingNavigator.ResumeLayout(false);
            this.uTENTEBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD bd1;
        private System.Windows.Forms.BindingSource uTENTEBindingSource;
        private BDTableAdapters.UTENTETableAdapter uTENTETableAdapter;
        private BDTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator uTENTEBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton uTENTEBindingNavigatorSaveItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox iD_UTENTETextBox;
        private System.Windows.Forms.TextBox gENEROTextBox;
        private System.Windows.Forms.TextBox mORADATextBox;
        private System.Windows.Forms.ListBox nOMEListBox;
    }
}