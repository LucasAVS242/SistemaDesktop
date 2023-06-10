
namespace SistemaDesktop
{
    partial class frmrelatServico
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tbServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CadastroUsuarioDataSet = new SistemaDesktop.CadastroUsuarioDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbServicoTableAdapter = new SistemaDesktop.CadastroUsuarioDataSetTableAdapters.tbServicoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbServicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CadastroUsuarioDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tbServicoBindingSource
            // 
            this.tbServicoBindingSource.DataMember = "tbServico";
            this.tbServicoBindingSource.DataSource = this.CadastroUsuarioDataSet;
            // 
            // CadastroUsuarioDataSet
            // 
            this.CadastroUsuarioDataSet.DataSetName = "CadastroUsuarioDataSet";
            this.CadastroUsuarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetServico";
            reportDataSource1.Value = this.tbServicoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaDesktop.rltServico.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(599, 368);
            this.reportViewer1.TabIndex = 0;
            // 
            // tbServicoTableAdapter
            // 
            this.tbServicoTableAdapter.ClearBeforeFill = true;
            // 
            // frmrelatServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(599, 368);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmrelatServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Serviço";
            this.Load += new System.EventHandler(this.frmrelatServico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbServicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CadastroUsuarioDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbServicoBindingSource;
        private CadastroUsuarioDataSet CadastroUsuarioDataSet;
        private CadastroUsuarioDataSetTableAdapters.tbServicoTableAdapter tbServicoTableAdapter;
    }
}