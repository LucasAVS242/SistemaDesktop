
namespace SistemaDesktop
{
    partial class frmOP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOP));
            System.Windows.Forms.Label idOSLabel;
            System.Windows.Forms.Label idServicoLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cadastroUsuarioDataSet = new SistemaDesktop.CadastroUsuarioDataSet();
            this.tbOrdemProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbOrdemProdutoTableAdapter = new SistemaDesktop.CadastroUsuarioDataSetTableAdapters.tbOrdemProdutoTableAdapter();
            this.tableAdapterManager = new SistemaDesktop.CadastroUsuarioDataSetTableAdapters.TableAdapterManager();
            this.tbOrdemProdutoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tbOrdemProdutoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idOSTextBox = new System.Windows.Forms.TextBox();
            this.idServicoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbOrdemProdutoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idOSLabel = new System.Windows.Forms.Label();
            idServicoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroUsuarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOrdemProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOrdemProdutoBindingNavigator)).BeginInit();
            this.tbOrdemProdutoBindingNavigator.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbOrdemProdutoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(idOSLabel);
            this.groupBox1.Controls.Add(this.idOSTextBox);
            this.groupBox1.Controls.Add(idServicoLabel);
            this.groupBox1.Controls.Add(this.idServicoTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 280);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // cadastroUsuarioDataSet
            // 
            this.cadastroUsuarioDataSet.DataSetName = "CadastroUsuarioDataSet";
            this.cadastroUsuarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbOrdemProdutoBindingSource
            // 
            this.tbOrdemProdutoBindingSource.DataMember = "tbOrdemProduto";
            this.tbOrdemProdutoBindingSource.DataSource = this.cadastroUsuarioDataSet;
            // 
            // tbOrdemProdutoTableAdapter
            // 
            this.tbOrdemProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbClienteTableAdapter = null;
            this.tableAdapterManager.tbOrdemProdutoTableAdapter = this.tbOrdemProdutoTableAdapter;
            this.tableAdapterManager.tbOSTableAdapter = null;
            this.tableAdapterManager.tbServicoTableAdapter = null;
            this.tableAdapterManager.tbUsuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SistemaDesktop.CadastroUsuarioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbOrdemProdutoBindingNavigator
            // 
            this.tbOrdemProdutoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbOrdemProdutoBindingNavigator.BindingSource = this.tbOrdemProdutoBindingSource;
            this.tbOrdemProdutoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbOrdemProdutoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbOrdemProdutoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tbOrdemProdutoBindingNavigatorSaveItem});
            this.tbOrdemProdutoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbOrdemProdutoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbOrdemProdutoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbOrdemProdutoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbOrdemProdutoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbOrdemProdutoBindingNavigator.Name = "tbOrdemProdutoBindingNavigator";
            this.tbOrdemProdutoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbOrdemProdutoBindingNavigator.Size = new System.Drawing.Size(518, 25);
            this.tbOrdemProdutoBindingNavigator.TabIndex = 2;
            this.tbOrdemProdutoBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // tbOrdemProdutoBindingNavigatorSaveItem
            // 
            this.tbOrdemProdutoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbOrdemProdutoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbOrdemProdutoBindingNavigatorSaveItem.Image")));
            this.tbOrdemProdutoBindingNavigatorSaveItem.Name = "tbOrdemProdutoBindingNavigatorSaveItem";
            this.tbOrdemProdutoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tbOrdemProdutoBindingNavigatorSaveItem.Text = "Save Data";
            this.tbOrdemProdutoBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbOrdemProdutoBindingNavigatorSaveItem_Click);
            // 
            // idOSLabel
            // 
            idOSLabel.AutoSize = true;
            idOSLabel.Location = new System.Drawing.Point(20, 37);
            idOSLabel.Name = "idOSLabel";
            idOSLabel.Size = new System.Drawing.Size(47, 17);
            idOSLabel.TabIndex = 0;
            idOSLabel.Text = "ID OS:";
            // 
            // idOSTextBox
            // 
            this.idOSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbOrdemProdutoBindingSource, "idOS", true));
            this.idOSTextBox.Location = new System.Drawing.Point(98, 34);
            this.idOSTextBox.Name = "idOSTextBox";
            this.idOSTextBox.Size = new System.Drawing.Size(100, 25);
            this.idOSTextBox.TabIndex = 1;
            // 
            // idServicoLabel
            // 
            idServicoLabel.AutoSize = true;
            idServicoLabel.Location = new System.Drawing.Point(20, 87);
            idServicoLabel.Name = "idServicoLabel";
            idServicoLabel.Size = new System.Drawing.Size(74, 17);
            idServicoLabel.TabIndex = 2;
            idServicoLabel.Text = "ID Serviço:";
            // 
            // idServicoTextBox
            // 
            this.idServicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbOrdemProdutoBindingSource, "idServico", true));
            this.idServicoTextBox.Location = new System.Drawing.Point(98, 84);
            this.idServicoTextBox.Name = "idServicoTextBox";
            this.idServicoTextBox.Size = new System.Drawing.Size(100, 25);
            this.idServicoTextBox.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbOrdemProdutoDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(277, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 283);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OP";
            // 
            // tbOrdemProdutoDataGridView
            // 
            this.tbOrdemProdutoDataGridView.AllowUserToAddRows = false;
            this.tbOrdemProdutoDataGridView.AllowUserToDeleteRows = false;
            this.tbOrdemProdutoDataGridView.AutoGenerateColumns = false;
            this.tbOrdemProdutoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbOrdemProdutoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tbOrdemProdutoDataGridView.DataSource = this.tbOrdemProdutoBindingSource;
            this.tbOrdemProdutoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbOrdemProdutoDataGridView.Location = new System.Drawing.Point(3, 21);
            this.tbOrdemProdutoDataGridView.Name = "tbOrdemProdutoDataGridView";
            this.tbOrdemProdutoDataGridView.ReadOnly = true;
            this.tbOrdemProdutoDataGridView.Size = new System.Drawing.Size(218, 259);
            this.tbOrdemProdutoDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idOS";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID OS";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 75;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idServico";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID Serviço";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // frmOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbOrdemProdutoBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar OP";
            this.Load += new System.EventHandler(this.frmOP_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroUsuarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOrdemProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOrdemProdutoBindingNavigator)).EndInit();
            this.tbOrdemProdutoBindingNavigator.ResumeLayout(false);
            this.tbOrdemProdutoBindingNavigator.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbOrdemProdutoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private CadastroUsuarioDataSet cadastroUsuarioDataSet;
        private System.Windows.Forms.BindingSource tbOrdemProdutoBindingSource;
        private CadastroUsuarioDataSetTableAdapters.tbOrdemProdutoTableAdapter tbOrdemProdutoTableAdapter;
        private CadastroUsuarioDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbOrdemProdutoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tbOrdemProdutoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idOSTextBox;
        private System.Windows.Forms.TextBox idServicoTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView tbOrdemProdutoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}