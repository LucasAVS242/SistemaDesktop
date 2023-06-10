
namespace SistemaDesktop
{
    partial class frmServico
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
            System.Windows.Forms.Label idServicoLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label observacaoLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label dataCadastroLabel;
            System.Windows.Forms.Label cadastradoPorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServico));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idServicoTextBox = new System.Windows.Forms.TextBox();
            this.tbServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroUsuarioDataSet = new SistemaDesktop.CadastroUsuarioDataSet();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.observacaoTextBox = new System.Windows.Forms.TextBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.dataCadastroTextBox = new System.Windows.Forms.TextBox();
            this.cadastradoPorTextBox = new System.Windows.Forms.TextBox();
            this.tbServicoTableAdapter = new SistemaDesktop.CadastroUsuarioDataSetTableAdapters.tbServicoTableAdapter();
            this.tableAdapterManager = new SistemaDesktop.CadastroUsuarioDataSetTableAdapters.TableAdapterManager();
            this.tbServicoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tbServicoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbServicoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idServicoLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            observacaoLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            dataCadastroLabel = new System.Windows.Forms.Label();
            cadastradoPorLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbServicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroUsuarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbServicoBindingNavigator)).BeginInit();
            this.tbServicoBindingNavigator.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbServicoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idServicoLabel
            // 
            idServicoLabel.AutoSize = true;
            idServicoLabel.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            idServicoLabel.Location = new System.Drawing.Point(18, 23);
            idServicoLabel.Name = "idServicoLabel";
            idServicoLabel.Size = new System.Drawing.Size(25, 17);
            idServicoLabel.TabIndex = 0;
            idServicoLabel.Text = "ID:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            nomeLabel.Location = new System.Drawing.Point(166, 23);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(48, 17);
            nomeLabel.TabIndex = 2;
            nomeLabel.Text = "Nome:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            descricaoLabel.Location = new System.Drawing.Point(22, 57);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(70, 17);
            descricaoLabel.TabIndex = 4;
            descricaoLabel.Text = "Descrição:";
            // 
            // observacaoLabel
            // 
            observacaoLabel.AutoSize = true;
            observacaoLabel.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            observacaoLabel.Location = new System.Drawing.Point(22, 152);
            observacaoLabel.Name = "observacaoLabel";
            observacaoLabel.Size = new System.Drawing.Size(82, 17);
            observacaoLabel.TabIndex = 6;
            observacaoLabel.Text = "Observação:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            valorLabel.Location = new System.Drawing.Point(11, 270);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(44, 17);
            valorLabel.TabIndex = 8;
            valorLabel.Text = "Valor:";
            // 
            // dataCadastroLabel
            // 
            dataCadastroLabel.AutoSize = true;
            dataCadastroLabel.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            dataCadastroLabel.Location = new System.Drawing.Point(237, 320);
            dataCadastroLabel.Name = "dataCadastroLabel";
            dataCadastroLabel.Size = new System.Drawing.Size(119, 17);
            dataCadastroLabel.TabIndex = 10;
            dataCadastroLabel.Text = "Data de Cadastro:";
            // 
            // cadastradoPorLabel
            // 
            cadastradoPorLabel.AutoSize = true;
            cadastradoPorLabel.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            cadastradoPorLabel.Location = new System.Drawing.Point(237, 270);
            cadastradoPorLabel.Name = "cadastradoPorLabel";
            cadastradoPorLabel.Size = new System.Drawing.Size(106, 17);
            cadastradoPorLabel.TabIndex = 12;
            cadastradoPorLabel.Text = "Cadastrado Por:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(idServicoLabel);
            this.groupBox1.Controls.Add(this.idServicoTextBox);
            this.groupBox1.Controls.Add(nomeLabel);
            this.groupBox1.Controls.Add(this.nomeTextBox);
            this.groupBox1.Controls.Add(descricaoLabel);
            this.groupBox1.Controls.Add(this.descricaoTextBox);
            this.groupBox1.Controls.Add(observacaoLabel);
            this.groupBox1.Controls.Add(this.observacaoTextBox);
            this.groupBox1.Controls.Add(valorLabel);
            this.groupBox1.Controls.Add(this.valorTextBox);
            this.groupBox1.Controls.Add(dataCadastroLabel);
            this.groupBox1.Controls.Add(this.dataCadastroTextBox);
            this.groupBox1.Controls.Add(cadastradoPorLabel);
            this.groupBox1.Controls.Add(this.cadastradoPorTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(25, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 410);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // idServicoTextBox
            // 
            this.idServicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbServicoBindingSource, "idServico", true));
            this.idServicoTextBox.Enabled = false;
            this.idServicoTextBox.Location = new System.Drawing.Point(49, 20);
            this.idServicoTextBox.Name = "idServicoTextBox";
            this.idServicoTextBox.Size = new System.Drawing.Size(100, 25);
            this.idServicoTextBox.TabIndex = 1;
            // 
            // tbServicoBindingSource
            // 
            this.tbServicoBindingSource.DataMember = "tbServico";
            this.tbServicoBindingSource.DataSource = this.cadastroUsuarioDataSet;
            // 
            // cadastroUsuarioDataSet
            // 
            this.cadastroUsuarioDataSet.DataSetName = "CadastroUsuarioDataSet";
            this.cadastroUsuarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbServicoBindingSource, "nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(220, 20);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(100, 25);
            this.nomeTextBox.TabIndex = 3;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbServicoBindingSource, "descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(25, 77);
            this.descricaoTextBox.Multiline = true;
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descricaoTextBox.Size = new System.Drawing.Size(523, 65);
            this.descricaoTextBox.TabIndex = 5;
            // 
            // observacaoTextBox
            // 
            this.observacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbServicoBindingSource, "observacao", true));
            this.observacaoTextBox.Location = new System.Drawing.Point(25, 172);
            this.observacaoTextBox.Multiline = true;
            this.observacaoTextBox.Name = "observacaoTextBox";
            this.observacaoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.observacaoTextBox.Size = new System.Drawing.Size(523, 65);
            this.observacaoTextBox.TabIndex = 7;
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbServicoBindingSource, "valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(61, 267);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(100, 25);
            this.valorTextBox.TabIndex = 9;
            // 
            // dataCadastroTextBox
            // 
            this.dataCadastroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbServicoBindingSource, "dataCadastro", true));
            this.dataCadastroTextBox.Enabled = false;
            this.dataCadastroTextBox.Location = new System.Drawing.Point(362, 317);
            this.dataCadastroTextBox.Name = "dataCadastroTextBox";
            this.dataCadastroTextBox.Size = new System.Drawing.Size(100, 25);
            this.dataCadastroTextBox.TabIndex = 11;
            // 
            // cadastradoPorTextBox
            // 
            this.cadastradoPorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbServicoBindingSource, "cadastradoPor", true));
            this.cadastradoPorTextBox.Enabled = false;
            this.cadastradoPorTextBox.Location = new System.Drawing.Point(362, 267);
            this.cadastradoPorTextBox.Name = "cadastradoPorTextBox";
            this.cadastradoPorTextBox.Size = new System.Drawing.Size(100, 25);
            this.cadastradoPorTextBox.TabIndex = 13;
            // 
            // tbServicoTableAdapter
            // 
            this.tbServicoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbClienteTableAdapter = null;
            this.tableAdapterManager.tbOrdemProdutoTableAdapter = null;
            this.tableAdapterManager.tbOSTableAdapter = null;
            this.tableAdapterManager.tbServicoTableAdapter = this.tbServicoTableAdapter;
            this.tableAdapterManager.tbUsuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SistemaDesktop.CadastroUsuarioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbServicoBindingNavigator
            // 
            this.tbServicoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbServicoBindingNavigator.BindingSource = this.tbServicoBindingSource;
            this.tbServicoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbServicoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbServicoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tbServicoBindingNavigatorSaveItem});
            this.tbServicoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbServicoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbServicoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbServicoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbServicoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbServicoBindingNavigator.Name = "tbServicoBindingNavigator";
            this.tbServicoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbServicoBindingNavigator.Size = new System.Drawing.Size(1240, 25);
            this.tbServicoBindingNavigator.TabIndex = 1;
            this.tbServicoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
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
            // tbServicoBindingNavigatorSaveItem
            // 
            this.tbServicoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbServicoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbServicoBindingNavigatorSaveItem.Image")));
            this.tbServicoBindingNavigatorSaveItem.Name = "tbServicoBindingNavigatorSaveItem";
            this.tbServicoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tbServicoBindingNavigatorSaveItem.Text = "Save Data";
            this.tbServicoBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbServicoBindingNavigatorSaveItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbServicoDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(625, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(603, 410);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serviço";
            // 
            // tbServicoDataGridView
            // 
            this.tbServicoDataGridView.AllowUserToAddRows = false;
            this.tbServicoDataGridView.AllowUserToDeleteRows = false;
            this.tbServicoDataGridView.AutoGenerateColumns = false;
            this.tbServicoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbServicoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.tbServicoDataGridView.DataSource = this.tbServicoBindingSource;
            this.tbServicoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbServicoDataGridView.Location = new System.Drawing.Point(3, 21);
            this.tbServicoDataGridView.Name = "tbServicoDataGridView";
            this.tbServicoDataGridView.ReadOnly = true;
            this.tbServicoDataGridView.Size = new System.Drawing.Size(597, 386);
            this.tbServicoDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idServico";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 45;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "descricao";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "observacao";
            this.dataGridViewTextBoxColumn4.HeaderText = "Observação";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "valor";
            this.dataGridViewTextBoxColumn5.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 75;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "dataCadastro";
            this.dataGridViewTextBoxColumn6.HeaderText = "Data de Cadastro";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "cadastradoPor";
            this.dataGridViewTextBoxColumn7.HeaderText = "Cadastrado Por";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // frmServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbServicoBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmServico";
            this.Text = "Cadastro de Serviço";
            this.Load += new System.EventHandler(this.frmServico_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbServicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroUsuarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbServicoBindingNavigator)).EndInit();
            this.tbServicoBindingNavigator.ResumeLayout(false);
            this.tbServicoBindingNavigator.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbServicoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private CadastroUsuarioDataSet cadastroUsuarioDataSet;
        private System.Windows.Forms.BindingSource tbServicoBindingSource;
        private CadastroUsuarioDataSetTableAdapters.tbServicoTableAdapter tbServicoTableAdapter;
        private CadastroUsuarioDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbServicoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tbServicoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idServicoTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox observacaoTextBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.TextBox dataCadastroTextBox;
        private System.Windows.Forms.TextBox cadastradoPorTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView tbServicoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}