
namespace SistemaDesktop
{
    partial class frmOS
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
            System.Windows.Forms.Label idOSLabel;
            System.Windows.Forms.Label idClienteLabel;
            System.Windows.Forms.Label dataCadastroLabel;
            System.Windows.Forms.Label cadastradoPorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOS));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idOSTextBox = new System.Windows.Forms.TextBox();
            this.tbOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroUsuarioDataSet = new SistemaDesktop.CadastroUsuarioDataSet();
            this.idClienteTextBox = new System.Windows.Forms.TextBox();
            this.dataCadastroTextBox = new System.Windows.Forms.TextBox();
            this.cadastradoPorTextBox = new System.Windows.Forms.TextBox();
            this.tbOSTableAdapter = new SistemaDesktop.CadastroUsuarioDataSetTableAdapters.tbOSTableAdapter();
            this.tableAdapterManager = new SistemaDesktop.CadastroUsuarioDataSetTableAdapters.TableAdapterManager();
            this.tbOSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tbOSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbOSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idOSLabel = new System.Windows.Forms.Label();
            idClienteLabel = new System.Windows.Forms.Label();
            dataCadastroLabel = new System.Windows.Forms.Label();
            cadastradoPorLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroUsuarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOSBindingNavigator)).BeginInit();
            this.tbOSBindingNavigator.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbOSDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idOSLabel
            // 
            idOSLabel.AutoSize = true;
            idOSLabel.Location = new System.Drawing.Point(6, 38);
            idOSLabel.Name = "idOSLabel";
            idOSLabel.Size = new System.Drawing.Size(47, 17);
            idOSLabel.TabIndex = 0;
            idOSLabel.Text = "ID OS:";
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Location = new System.Drawing.Point(6, 89);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(73, 17);
            idClienteLabel.TabIndex = 2;
            idClienteLabel.Text = "ID Cliente:";
            // 
            // dataCadastroLabel
            // 
            dataCadastroLabel.AutoSize = true;
            dataCadastroLabel.Location = new System.Drawing.Point(241, 38);
            dataCadastroLabel.Name = "dataCadastroLabel";
            dataCadastroLabel.Size = new System.Drawing.Size(119, 17);
            dataCadastroLabel.TabIndex = 4;
            dataCadastroLabel.Text = "Data de Cadastro:";
            // 
            // cadastradoPorLabel
            // 
            cadastradoPorLabel.AutoSize = true;
            cadastradoPorLabel.Location = new System.Drawing.Point(241, 89);
            cadastradoPorLabel.Name = "cadastradoPorLabel";
            cadastradoPorLabel.Size = new System.Drawing.Size(106, 17);
            cadastradoPorLabel.TabIndex = 6;
            cadastradoPorLabel.Text = "Cadastrado Por:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(idOSLabel);
            this.groupBox1.Controls.Add(this.idOSTextBox);
            this.groupBox1.Controls.Add(idClienteLabel);
            this.groupBox1.Controls.Add(this.idClienteTextBox);
            this.groupBox1.Controls.Add(dataCadastroLabel);
            this.groupBox1.Controls.Add(this.dataCadastroTextBox);
            this.groupBox1.Controls.Add(cadastradoPorLabel);
            this.groupBox1.Controls.Add(this.cadastradoPorTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // idOSTextBox
            // 
            this.idOSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbOSBindingSource, "idOS", true));
            this.idOSTextBox.Enabled = false;
            this.idOSTextBox.Location = new System.Drawing.Point(85, 35);
            this.idOSTextBox.Name = "idOSTextBox";
            this.idOSTextBox.Size = new System.Drawing.Size(100, 25);
            this.idOSTextBox.TabIndex = 1;
            // 
            // tbOSBindingSource
            // 
            this.tbOSBindingSource.DataMember = "tbOS";
            this.tbOSBindingSource.DataSource = this.cadastroUsuarioDataSet;
            // 
            // cadastroUsuarioDataSet
            // 
            this.cadastroUsuarioDataSet.DataSetName = "CadastroUsuarioDataSet";
            this.cadastroUsuarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idClienteTextBox
            // 
            this.idClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbOSBindingSource, "idCliente", true));
            this.idClienteTextBox.Location = new System.Drawing.Point(85, 86);
            this.idClienteTextBox.Name = "idClienteTextBox";
            this.idClienteTextBox.Size = new System.Drawing.Size(100, 25);
            this.idClienteTextBox.TabIndex = 3;
            // 
            // dataCadastroTextBox
            // 
            this.dataCadastroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbOSBindingSource, "dataCadastro", true));
            this.dataCadastroTextBox.Enabled = false;
            this.dataCadastroTextBox.Location = new System.Drawing.Point(366, 35);
            this.dataCadastroTextBox.Name = "dataCadastroTextBox";
            this.dataCadastroTextBox.Size = new System.Drawing.Size(100, 25);
            this.dataCadastroTextBox.TabIndex = 5;
            // 
            // cadastradoPorTextBox
            // 
            this.cadastradoPorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbOSBindingSource, "cadastradoPor", true));
            this.cadastradoPorTextBox.Enabled = false;
            this.cadastradoPorTextBox.Location = new System.Drawing.Point(366, 86);
            this.cadastradoPorTextBox.Name = "cadastradoPorTextBox";
            this.cadastradoPorTextBox.Size = new System.Drawing.Size(100, 25);
            this.cadastradoPorTextBox.TabIndex = 7;
            // 
            // tbOSTableAdapter
            // 
            this.tbOSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbClienteTableAdapter = null;
            this.tableAdapterManager.tbOrdemProdutoTableAdapter = null;
            this.tableAdapterManager.tbOSTableAdapter = this.tbOSTableAdapter;
            this.tableAdapterManager.tbServicoTableAdapter = null;
            this.tableAdapterManager.tbUsuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SistemaDesktop.CadastroUsuarioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbOSBindingNavigator
            // 
            this.tbOSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbOSBindingNavigator.BindingSource = this.tbOSBindingSource;
            this.tbOSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbOSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbOSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tbOSBindingNavigatorSaveItem});
            this.tbOSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbOSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbOSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbOSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbOSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbOSBindingNavigator.Name = "tbOSBindingNavigator";
            this.tbOSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbOSBindingNavigator.Size = new System.Drawing.Size(552, 25);
            this.tbOSBindingNavigator.TabIndex = 1;
            this.tbOSBindingNavigator.Text = "bindingNavigator1";
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
            // tbOSBindingNavigatorSaveItem
            // 
            this.tbOSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbOSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbOSBindingNavigatorSaveItem.Image")));
            this.tbOSBindingNavigatorSaveItem.Name = "tbOSBindingNavigatorSaveItem";
            this.tbOSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tbOSBindingNavigatorSaveItem.Text = "Save Data";
            this.tbOSBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbOSBindingNavigatorSaveItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbOSDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(12, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(523, 281);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OS";
            // 
            // tbOSDataGridView
            // 
            this.tbOSDataGridView.AllowUserToAddRows = false;
            this.tbOSDataGridView.AllowUserToDeleteRows = false;
            this.tbOSDataGridView.AutoGenerateColumns = false;
            this.tbOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbOSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tbOSDataGridView.DataSource = this.tbOSBindingSource;
            this.tbOSDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbOSDataGridView.Location = new System.Drawing.Point(3, 21);
            this.tbOSDataGridView.Name = "tbOSDataGridView";
            this.tbOSDataGridView.ReadOnly = true;
            this.tbOSDataGridView.Size = new System.Drawing.Size(517, 257);
            this.tbOSDataGridView.TabIndex = 0;
            this.tbOSDataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbOSDataGridView_MouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idOS";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID OS";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idCliente";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID Cliente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dataCadastro";
            this.dataGridViewTextBoxColumn3.HeaderText = "Data de Cadastro";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cadastradoPor";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cadastrado Por";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // frmOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(552, 498);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbOSBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar OS";
            this.Load += new System.EventHandler(this.frmOS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroUsuarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOSBindingNavigator)).EndInit();
            this.tbOSBindingNavigator.ResumeLayout(false);
            this.tbOSBindingNavigator.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbOSDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private CadastroUsuarioDataSet cadastroUsuarioDataSet;
        private System.Windows.Forms.BindingSource tbOSBindingSource;
        private CadastroUsuarioDataSetTableAdapters.tbOSTableAdapter tbOSTableAdapter;
        private CadastroUsuarioDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbOSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tbOSBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idOSTextBox;
        private System.Windows.Forms.TextBox idClienteTextBox;
        private System.Windows.Forms.TextBox dataCadastroTextBox;
        private System.Windows.Forms.TextBox cadastradoPorTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView tbOSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}