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
            System.Windows.Forms.Label nOMELabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trabalhadores));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.iD_TRABALHADORTextBox = new System.Windows.Forms.TextBox();
            this.tRABALHADORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD = new BD_Trab.BD();
            this.nOMETextBox = new System.Windows.Forms.TextBox();
            this.gENEROTextBox = new System.Windows.Forms.TextBox();
            this.mORADATextBox = new System.Windows.Forms.TextBox();
            this.eNCARGOTextBox = new System.Windows.Forms.TextBox();
            this.tURNOTextBox = new System.Windows.Forms.TextBox();
            this.tRABALHADORTableAdapter = new BD_Trab.BDTableAdapters.TRABALHADORTableAdapter();
            this.tableAdapterManager = new BD_Trab.BDTableAdapters.TableAdapterManager();
            this.tRABALHADORBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tRABALHADORBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nOMEListBox = new System.Windows.Forms.ListBox();
            iD_TRABALHADORLabel = new System.Windows.Forms.Label();
            nOMELabel = new System.Windows.Forms.Label();
            gENEROLabel = new System.Windows.Forms.Label();
            mORADALabel = new System.Windows.Forms.Label();
            eNCARGOLabel = new System.Windows.Forms.Label();
            tURNOLabel = new System.Windows.Forms.Label();
            nOMELabel1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRABALHADORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRABALHADORBindingNavigator)).BeginInit();
            this.tRABALHADORBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_TRABALHADORLabel
            // 
            iD_TRABALHADORLabel.AutoSize = true;
            iD_TRABALHADORLabel.Location = new System.Drawing.Point(40, 50);
            iD_TRABALHADORLabel.Name = "iD_TRABALHADORLabel";
            iD_TRABALHADORLabel.Size = new System.Drawing.Size(105, 13);
            iD_TRABALHADORLabel.TabIndex = 0;
            iD_TRABALHADORLabel.Text = "ID TRABALHADOR:";
            // 
            // nOMELabel
            // 
            nOMELabel.AutoSize = true;
            nOMELabel.Location = new System.Drawing.Point(40, 76);
            nOMELabel.Name = "nOMELabel";
            nOMELabel.Size = new System.Drawing.Size(42, 13);
            nOMELabel.TabIndex = 2;
            nOMELabel.Text = "NOME:";
            // 
            // gENEROLabel
            // 
            gENEROLabel.AutoSize = true;
            gENEROLabel.Location = new System.Drawing.Point(40, 102);
            gENEROLabel.Name = "gENEROLabel";
            gENEROLabel.Size = new System.Drawing.Size(56, 13);
            gENEROLabel.TabIndex = 4;
            gENEROLabel.Text = "GENERO:";
            // 
            // mORADALabel
            // 
            mORADALabel.AutoSize = true;
            mORADALabel.Location = new System.Drawing.Point(40, 128);
            mORADALabel.Name = "mORADALabel";
            mORADALabel.Size = new System.Drawing.Size(57, 13);
            mORADALabel.TabIndex = 6;
            mORADALabel.Text = "MORADA:";
            // 
            // eNCARGOLabel
            // 
            eNCARGOLabel.AutoSize = true;
            eNCARGOLabel.Location = new System.Drawing.Point(40, 154);
            eNCARGOLabel.Name = "eNCARGOLabel";
            eNCARGOLabel.Size = new System.Drawing.Size(63, 13);
            eNCARGOLabel.TabIndex = 8;
            eNCARGOLabel.Text = "ENCARGO:";
            // 
            // tURNOLabel
            // 
            tURNOLabel.AutoSize = true;
            tURNOLabel.Location = new System.Drawing.Point(40, 180);
            tURNOLabel.Name = "tURNOLabel";
            tURNOLabel.Size = new System.Drawing.Size(49, 13);
            tURNOLabel.TabIndex = 10;
            tURNOLabel.Text = "TURNO:";
            // 
            // nOMELabel1
            // 
            nOMELabel1.AutoSize = true;
            nOMELabel1.Location = new System.Drawing.Point(33, 59);
            nOMELabel1.Name = "nOMELabel1";
            nOMELabel1.Size = new System.Drawing.Size(42, 13);
            nOMELabel1.TabIndex = 2;
            nOMELabel1.Text = "NOME:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(iD_TRABALHADORLabel);
            this.groupBox1.Controls.Add(this.iD_TRABALHADORTextBox);
            this.groupBox1.Controls.Add(nOMELabel);
            this.groupBox1.Controls.Add(this.nOMETextBox);
            this.groupBox1.Controls.Add(gENEROLabel);
            this.groupBox1.Controls.Add(this.gENEROTextBox);
            this.groupBox1.Controls.Add(mORADALabel);
            this.groupBox1.Controls.Add(this.mORADATextBox);
            this.groupBox1.Controls.Add(eNCARGOLabel);
            this.groupBox1.Controls.Add(this.eNCARGOTextBox);
            this.groupBox1.Controls.Add(tURNOLabel);
            this.groupBox1.Controls.Add(this.tURNOTextBox);
            this.groupBox1.Location = new System.Drawing.Point(217, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 368);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(379, 280);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Apagar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(27, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Adicionar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Alterar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // iD_TRABALHADORTextBox
            // 
            this.iD_TRABALHADORTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRABALHADORBindingSource, "ID_TRABALHADOR", true));
            this.iD_TRABALHADORTextBox.Location = new System.Drawing.Point(151, 47);
            this.iD_TRABALHADORTextBox.Name = "iD_TRABALHADORTextBox";
            this.iD_TRABALHADORTextBox.Size = new System.Drawing.Size(100, 20);
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
            this.nOMETextBox.Location = new System.Drawing.Point(151, 73);
            this.nOMETextBox.Name = "nOMETextBox";
            this.nOMETextBox.Size = new System.Drawing.Size(100, 20);
            this.nOMETextBox.TabIndex = 3;
            // 
            // gENEROTextBox
            // 
            this.gENEROTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRABALHADORBindingSource, "GENERO", true));
            this.gENEROTextBox.Location = new System.Drawing.Point(151, 99);
            this.gENEROTextBox.Name = "gENEROTextBox";
            this.gENEROTextBox.Size = new System.Drawing.Size(100, 20);
            this.gENEROTextBox.TabIndex = 5;
            // 
            // mORADATextBox
            // 
            this.mORADATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRABALHADORBindingSource, "MORADA", true));
            this.mORADATextBox.Location = new System.Drawing.Point(151, 125);
            this.mORADATextBox.Name = "mORADATextBox";
            this.mORADATextBox.Size = new System.Drawing.Size(100, 20);
            this.mORADATextBox.TabIndex = 7;
            // 
            // eNCARGOTextBox
            // 
            this.eNCARGOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRABALHADORBindingSource, "ENCARGO", true));
            this.eNCARGOTextBox.Location = new System.Drawing.Point(151, 151);
            this.eNCARGOTextBox.Name = "eNCARGOTextBox";
            this.eNCARGOTextBox.Size = new System.Drawing.Size(100, 20);
            this.eNCARGOTextBox.TabIndex = 9;
            // 
            // tURNOTextBox
            // 
            this.tURNOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRABALHADORBindingSource, "TURNO", true));
            this.tURNOTextBox.Location = new System.Drawing.Point(151, 177);
            this.tURNOTextBox.Name = "tURNOTextBox";
            this.tURNOTextBox.Size = new System.Drawing.Size(100, 20);
            this.tURNOTextBox.TabIndex = 11;
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
            // tRABALHADORBindingNavigator
            // 
            this.tRABALHADORBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tRABALHADORBindingNavigator.BindingSource = this.tRABALHADORBindingSource;
            this.tRABALHADORBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tRABALHADORBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tRABALHADORBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tRABALHADORBindingNavigatorSaveItem});
            this.tRABALHADORBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tRABALHADORBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tRABALHADORBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tRABALHADORBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tRABALHADORBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tRABALHADORBindingNavigator.Name = "tRABALHADORBindingNavigator";
            this.tRABALHADORBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tRABALHADORBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.tRABALHADORBindingNavigator.TabIndex = 1;
            this.tRABALHADORBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
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
            // tRABALHADORBindingNavigatorSaveItem
            // 
            this.tRABALHADORBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tRABALHADORBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tRABALHADORBindingNavigatorSaveItem.Image")));
            this.tRABALHADORBindingNavigatorSaveItem.Name = "tRABALHADORBindingNavigatorSaveItem";
            this.tRABALHADORBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tRABALHADORBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tRABALHADORBindingNavigatorSaveItem.Click += new System.EventHandler(this.tRABALHADORBindingNavigatorSaveItem_Click);
            // 
            // nOMEListBox
            // 
            this.nOMEListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tRABALHADORBindingSource, "NOME", true));
            this.nOMEListBox.DataSource = this.tRABALHADORBindingSource;
            this.nOMEListBox.DisplayMember = "NOME";
            this.nOMEListBox.FormattingEnabled = true;
            this.nOMEListBox.Location = new System.Drawing.Point(26, 83);
            this.nOMEListBox.Name = "nOMEListBox";
            this.nOMEListBox.Size = new System.Drawing.Size(155, 303);
            this.nOMEListBox.TabIndex = 3;
            // 
            // Trabalhadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(nOMELabel1);
            this.Controls.Add(this.nOMEListBox);
            this.Controls.Add(this.tRABALHADORBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Name = "Trabalhadores";
            this.Text = "Trabalhadores";
            this.Load += new System.EventHandler(this.Trabalhadores_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRABALHADORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRABALHADORBindingNavigator)).EndInit();
            this.tRABALHADORBindingNavigator.ResumeLayout(false);
            this.tRABALHADORBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private BD bD;
        private System.Windows.Forms.BindingSource tRABALHADORBindingSource;
        private BDTableAdapters.TRABALHADORTableAdapter tRABALHADORTableAdapter;
        private BDTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tRABALHADORBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tRABALHADORBindingNavigatorSaveItem;
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
    }
}