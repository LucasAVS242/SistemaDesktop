
namespace SistemaDesktop
{
    partial class frmUsuario
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
            System.Windows.Forms.Label idUsuarioLabel1;
            System.Windows.Forms.Label nomeUsuarioLabel;
            System.Windows.Forms.Label senhaLabel1;
            System.Windows.Forms.Label nivelAcessoLabel1;
            System.Windows.Forms.Label dataCadastroLabel1;
            System.Windows.Forms.Label cadastradoPorLabel1;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.repitasenhaTextBox = new System.Windows.Forms.TextBox();
            this.tbUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroUsuarioDataSet = new SistemaDesktop.CadastroUsuarioDataSet();
            this.idUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.nomeUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.nivelAcessoComboBox = new System.Windows.Forms.ComboBox();
            this.dataCadastroTextBox = new System.Windows.Forms.TextBox();
            this.cadastradoPorTextBox = new System.Windows.Forms.TextBox();
            this.tbUsuarioBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tbUsuarioBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tbUsuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivelAcessoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadastradoPorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbUsuarioTableAdapter = new SistemaDesktop.CadastroUsuarioDataSetTableAdapters.tbUsuarioTableAdapter();
            this.tableAdapterManager = new SistemaDesktop.CadastroUsuarioDataSetTableAdapters.TableAdapterManager();
            idUsuarioLabel1 = new System.Windows.Forms.Label();
            nomeUsuarioLabel = new System.Windows.Forms.Label();
            senhaLabel1 = new System.Windows.Forms.Label();
            nivelAcessoLabel1 = new System.Windows.Forms.Label();
            dataCadastroLabel1 = new System.Windows.Forms.Label();
            cadastradoPorLabel1 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroUsuarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingNavigator)).BeginInit();
            this.tbUsuarioBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // idUsuarioLabel1
            // 
            idUsuarioLabel1.AutoSize = true;
            idUsuarioLabel1.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            idUsuarioLabel1.Location = new System.Drawing.Point(87, 49);
            idUsuarioLabel1.Name = "idUsuarioLabel1";
            idUsuarioLabel1.Size = new System.Drawing.Size(25, 17);
            idUsuarioLabel1.TabIndex = 12;
            idUsuarioLabel1.Text = "ID:";
            // 
            // nomeUsuarioLabel
            // 
            nomeUsuarioLabel.AutoSize = true;
            nomeUsuarioLabel.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            nomeUsuarioLabel.Location = new System.Drawing.Point(64, 80);
            nomeUsuarioLabel.Name = "nomeUsuarioLabel";
            nomeUsuarioLabel.Size = new System.Drawing.Size(48, 17);
            nomeUsuarioLabel.TabIndex = 14;
            nomeUsuarioLabel.Text = "Nome:";
            nomeUsuarioLabel.Click += new System.EventHandler(this.nomeUsuarioLabel1_Click);
            // 
            // senhaLabel1
            // 
            senhaLabel1.AutoSize = true;
            senhaLabel1.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            senhaLabel1.Location = new System.Drawing.Point(62, 111);
            senhaLabel1.Name = "senhaLabel1";
            senhaLabel1.Size = new System.Drawing.Size(48, 17);
            senhaLabel1.TabIndex = 16;
            senhaLabel1.Text = "Senha:";
            // 
            // nivelAcessoLabel1
            // 
            nivelAcessoLabel1.AutoSize = true;
            nivelAcessoLabel1.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            nivelAcessoLabel1.Location = new System.Drawing.Point(22, 173);
            nivelAcessoLabel1.Name = "nivelAcessoLabel1";
            nivelAcessoLabel1.Size = new System.Drawing.Size(90, 17);
            nivelAcessoLabel1.TabIndex = 18;
            nivelAcessoLabel1.Text = "Nivel Acesso:";
            // 
            // dataCadastroLabel1
            // 
            dataCadastroLabel1.AutoSize = true;
            dataCadastroLabel1.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            dataCadastroLabel1.Location = new System.Drawing.Point(13, 204);
            dataCadastroLabel1.Name = "dataCadastroLabel1";
            dataCadastroLabel1.Size = new System.Drawing.Size(99, 17);
            dataCadastroLabel1.TabIndex = 20;
            dataCadastroLabel1.Text = "Data Cadastro:";
            // 
            // cadastradoPorLabel1
            // 
            cadastradoPorLabel1.AutoSize = true;
            cadastradoPorLabel1.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            cadastradoPorLabel1.Location = new System.Drawing.Point(6, 240);
            cadastradoPorLabel1.Name = "cadastradoPorLabel1";
            cadastradoPorLabel1.Size = new System.Drawing.Size(106, 17);
            cadastradoPorLabel1.TabIndex = 22;
            cadastradoPorLabel1.Text = "Cadastrado Por:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(9, 142);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(103, 17);
            label1.TabIndex = 25;
            label1.Text = "Repita a senha:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.repitasenhaTextBox);
            this.groupBox1.Controls.Add(idUsuarioLabel1);
            this.groupBox1.Controls.Add(this.idUsuarioTextBox);
            this.groupBox1.Controls.Add(nomeUsuarioLabel);
            this.groupBox1.Controls.Add(this.nomeUsuarioTextBox);
            this.groupBox1.Controls.Add(senhaLabel1);
            this.groupBox1.Controls.Add(this.senhaTextBox);
            this.groupBox1.Controls.Add(nivelAcessoLabel1);
            this.groupBox1.Controls.Add(this.nivelAcessoComboBox);
            this.groupBox1.Controls.Add(dataCadastroLabel1);
            this.groupBox1.Controls.Add(this.dataCadastroTextBox);
            this.groupBox1.Controls.Add(cadastradoPorLabel1);
            this.groupBox1.Controls.Add(this.cadastradoPorTextBox);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 332);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // repitasenhaTextBox
            // 
            this.repitasenhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "senha", true));
            this.repitasenhaTextBox.Location = new System.Drawing.Point(116, 139);
            this.repitasenhaTextBox.Name = "repitasenhaTextBox";
            this.repitasenhaTextBox.PasswordChar = '*';
            this.repitasenhaTextBox.Size = new System.Drawing.Size(121, 25);
            this.repitasenhaTextBox.TabIndex = 4;
            // 
            // tbUsuarioBindingSource
            // 
            this.tbUsuarioBindingSource.DataMember = "tbUsuario";
            this.tbUsuarioBindingSource.DataSource = this.cadastroUsuarioDataSet;
            // 
            // cadastroUsuarioDataSet
            // 
            this.cadastroUsuarioDataSet.DataSetName = "CadastroUsuarioDataSet";
            this.cadastroUsuarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idUsuarioTextBox
            // 
            this.idUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "idUsuario", true));
            this.idUsuarioTextBox.Enabled = false;
            this.idUsuarioTextBox.Location = new System.Drawing.Point(116, 46);
            this.idUsuarioTextBox.Name = "idUsuarioTextBox";
            this.idUsuarioTextBox.ReadOnly = true;
            this.idUsuarioTextBox.Size = new System.Drawing.Size(121, 25);
            this.idUsuarioTextBox.TabIndex = 1;
            // 
            // nomeUsuarioTextBox
            // 
            this.nomeUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "nomeUsuario", true));
            this.nomeUsuarioTextBox.Location = new System.Drawing.Point(116, 77);
            this.nomeUsuarioTextBox.Name = "nomeUsuarioTextBox";
            this.nomeUsuarioTextBox.Size = new System.Drawing.Size(121, 25);
            this.nomeUsuarioTextBox.TabIndex = 2;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "senha", true));
            this.senhaTextBox.Location = new System.Drawing.Point(116, 108);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.PasswordChar = '*';
            this.senhaTextBox.Size = new System.Drawing.Size(121, 25);
            this.senhaTextBox.TabIndex = 3;
            // 
            // nivelAcessoComboBox
            // 
            this.nivelAcessoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "nivelAcesso", true));
            this.nivelAcessoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nivelAcessoComboBox.FormattingEnabled = true;
            this.nivelAcessoComboBox.Items.AddRange(new object[] {
            "",
            "Administrador",
            "Usuario"});
            this.nivelAcessoComboBox.Location = new System.Drawing.Point(116, 170);
            this.nivelAcessoComboBox.Name = "nivelAcessoComboBox";
            this.nivelAcessoComboBox.Size = new System.Drawing.Size(121, 25);
            this.nivelAcessoComboBox.TabIndex = 5;
            // 
            // dataCadastroTextBox
            // 
            this.dataCadastroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "dataCadastro", true));
            this.dataCadastroTextBox.Enabled = false;
            this.dataCadastroTextBox.Location = new System.Drawing.Point(116, 201);
            this.dataCadastroTextBox.Name = "dataCadastroTextBox";
            this.dataCadastroTextBox.Size = new System.Drawing.Size(121, 25);
            this.dataCadastroTextBox.TabIndex = 6;
            // 
            // cadastradoPorTextBox
            // 
            this.cadastradoPorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "cadastradoPor", true));
            this.cadastradoPorTextBox.Enabled = false;
            this.cadastradoPorTextBox.Location = new System.Drawing.Point(116, 237);
            this.cadastradoPorTextBox.Name = "cadastradoPorTextBox";
            this.cadastradoPorTextBox.Size = new System.Drawing.Size(121, 25);
            this.cadastradoPorTextBox.TabIndex = 7;
            // 
            // tbUsuarioBindingNavigator
            // 
            this.tbUsuarioBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbUsuarioBindingNavigator.BindingSource = this.tbUsuarioBindingSource;
            this.tbUsuarioBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbUsuarioBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbUsuarioBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tbUsuarioBindingNavigatorSaveItem});
            this.tbUsuarioBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbUsuarioBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbUsuarioBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbUsuarioBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbUsuarioBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbUsuarioBindingNavigator.Name = "tbUsuarioBindingNavigator";
            this.tbUsuarioBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbUsuarioBindingNavigator.Size = new System.Drawing.Size(801, 25);
            this.tbUsuarioBindingNavigator.TabIndex = 1;
            this.tbUsuarioBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
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
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbUsuarioBindingNavigatorSaveItem
            // 
            this.tbUsuarioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbUsuarioBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbUsuarioBindingNavigatorSaveItem.Image")));
            this.tbUsuarioBindingNavigatorSaveItem.Name = "tbUsuarioBindingNavigatorSaveItem";
            this.tbUsuarioBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tbUsuarioBindingNavigatorSaveItem.Text = "Save Data";
            this.tbUsuarioBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbUsuarioBindingNavigatorSaveItem_Click);
            // 
            // tbUsuarioDataGridView
            // 
            this.tbUsuarioDataGridView.AllowUserToAddRows = false;
            this.tbUsuarioDataGridView.AllowUserToDeleteRows = false;
            this.tbUsuarioDataGridView.AutoGenerateColumns = false;
            this.tbUsuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbUsuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuarioDataGridViewTextBoxColumn,
            this.nomeUsuarioDataGridViewTextBoxColumn,
            this.senhaDataGridViewTextBoxColumn,
            this.nivelAcessoDataGridViewTextBoxColumn,
            this.dataCadastroDataGridViewTextBoxColumn,
            this.cadastradoPorDataGridViewTextBoxColumn});
            this.tbUsuarioDataGridView.DataSource = this.tbUsuarioBindingSource;
            this.tbUsuarioDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUsuarioDataGridView.Location = new System.Drawing.Point(3, 21);
            this.tbUsuarioDataGridView.Name = "tbUsuarioDataGridView";
            this.tbUsuarioDataGridView.ReadOnly = true;
            this.tbUsuarioDataGridView.Size = new System.Drawing.Size(462, 238);
            this.tbUsuarioDataGridView.TabIndex = 0;
            this.tbUsuarioDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbUsuarioDataGridView_CellContentClick);
            this.tbUsuarioDataGridView.DoubleClick += new System.EventHandler(this.tbUsuarioDataGridView_DoubleClick);
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "idUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            this.idUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idUsuarioDataGridViewTextBoxColumn.Width = 45;
            // 
            // nomeUsuarioDataGridViewTextBoxColumn
            // 
            this.nomeUsuarioDataGridViewTextBoxColumn.DataPropertyName = "nomeUsuario";
            this.nomeUsuarioDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeUsuarioDataGridViewTextBoxColumn.Name = "nomeUsuarioDataGridViewTextBoxColumn";
            this.nomeUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // senhaDataGridViewTextBoxColumn
            // 
            this.senhaDataGridViewTextBoxColumn.DataPropertyName = "senha";
            this.senhaDataGridViewTextBoxColumn.HeaderText = "Senha";
            this.senhaDataGridViewTextBoxColumn.Name = "senhaDataGridViewTextBoxColumn";
            this.senhaDataGridViewTextBoxColumn.ReadOnly = true;
            this.senhaDataGridViewTextBoxColumn.Visible = false;
            // 
            // nivelAcessoDataGridViewTextBoxColumn
            // 
            this.nivelAcessoDataGridViewTextBoxColumn.DataPropertyName = "nivelAcesso";
            this.nivelAcessoDataGridViewTextBoxColumn.HeaderText = "Nivel Acesso";
            this.nivelAcessoDataGridViewTextBoxColumn.Name = "nivelAcessoDataGridViewTextBoxColumn";
            this.nivelAcessoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nivelAcessoDataGridViewTextBoxColumn.Width = 75;
            // 
            // dataCadastroDataGridViewTextBoxColumn
            // 
            this.dataCadastroDataGridViewTextBoxColumn.DataPropertyName = "dataCadastro";
            this.dataCadastroDataGridViewTextBoxColumn.HeaderText = "Data Cadastro";
            this.dataCadastroDataGridViewTextBoxColumn.Name = "dataCadastroDataGridViewTextBoxColumn";
            this.dataCadastroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cadastradoPorDataGridViewTextBoxColumn
            // 
            this.cadastradoPorDataGridViewTextBoxColumn.DataPropertyName = "cadastradoPor";
            this.cadastradoPorDataGridViewTextBoxColumn.HeaderText = "Cadastrado Por";
            this.cadastradoPorDataGridViewTextBoxColumn.Name = "cadastradoPorDataGridViewTextBoxColumn";
            this.cadastradoPorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.tbUsuarioDataGridView);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(273, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 262);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usuário";
            // 
            // tbUsuarioTableAdapter
            // 
            this.tbUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbClienteTableAdapter = null;
            this.tableAdapterManager.tbOrdemProdutoTableAdapter = null;
            this.tableAdapterManager.tbOSTableAdapter = null;
            this.tableAdapterManager.tbServicoTableAdapter = null;
            this.tableAdapterManager.tbUsuarioTableAdapter = this.tbUsuarioTableAdapter;
            this.tableAdapterManager.UpdateOrder = SistemaDesktop.CadastroUsuarioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbUsuarioBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUsuario";
            this.Text = "Cadastro de Usuário";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroUsuarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingNavigator)).EndInit();
            this.tbUsuarioBindingNavigator.ResumeLayout(false);
            this.tbUsuarioBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private CadastroUsuarioDataSet cadastroUsuarioDataSet;
        private System.Windows.Forms.BindingSource tbUsuarioBindingSource;
        private CadastroUsuarioDataSetTableAdapters.tbUsuarioTableAdapter tbUsuarioTableAdapter;
        private CadastroUsuarioDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbUsuarioBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tbUsuarioBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idUsuarioTextBox;
        private System.Windows.Forms.TextBox nomeUsuarioTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.ComboBox nivelAcessoComboBox;
        private System.Windows.Forms.TextBox dataCadastroTextBox;
        private System.Windows.Forms.TextBox cadastradoPorTextBox;
        private System.Windows.Forms.DataGridView tbUsuarioDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivelAcessoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadastradoPorDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox repitasenhaTextBox;
    }
}