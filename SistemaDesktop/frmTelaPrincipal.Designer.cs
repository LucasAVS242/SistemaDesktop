﻿
namespace SistemaDesktop
{
    partial class frmTelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordemDeServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ordemDeServiçoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbCliente = new System.Windows.Forms.ToolStripButton();
            this.tsbServico = new System.Windows.Forms.ToolStripButton();
            this.tsbOS = new System.Windows.Forms.ToolStripButton();
            this.tsbCalc = new System.Windows.Forms.ToolStripButton();
            this.tsbLogoff = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslNivelAcesso = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslIP = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslNomePC = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslData = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ordemDeProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbOP = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1028, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuárioToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.serviçoToolStripMenuItem,
            this.ordemDeServiçoToolStripMenuItem,
            this.ordemDeProdutoToolStripMenuItem});
            this.cadastroToolStripMenuItem.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(74, 21);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            this.usuárioToolStripMenuItem.Click += new System.EventHandler(this.usuárioToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // serviçoToolStripMenuItem
            // 
            this.serviçoToolStripMenuItem.Name = "serviçoToolStripMenuItem";
            this.serviçoToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.serviçoToolStripMenuItem.Text = "Serviço";
            this.serviçoToolStripMenuItem.Click += new System.EventHandler(this.serviçoToolStripMenuItem_Click);
            // 
            // ordemDeServiçoToolStripMenuItem
            // 
            this.ordemDeServiçoToolStripMenuItem.Name = "ordemDeServiçoToolStripMenuItem";
            this.ordemDeServiçoToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.ordemDeServiçoToolStripMenuItem.Text = "Ordem de serviço";
            this.ordemDeServiçoToolStripMenuItem.Click += new System.EventHandler(this.ordemDeServiçoToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem1,
            this.serviçoToolStripMenuItem1,
            this.ordemDeServiçoToolStripMenuItem1});
            this.relatóriosToolStripMenuItem.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(82, 21);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            this.clienteToolStripMenuItem1.Click += new System.EventHandler(this.clienteToolStripMenuItem1_Click);
            // 
            // serviçoToolStripMenuItem1
            // 
            this.serviçoToolStripMenuItem1.Name = "serviçoToolStripMenuItem1";
            this.serviçoToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.serviçoToolStripMenuItem1.Text = "Serviço";
            this.serviçoToolStripMenuItem1.Click += new System.EventHandler(this.serviçoToolStripMenuItem1_Click);
            // 
            // ordemDeServiçoToolStripMenuItem1
            // 
            this.ordemDeServiçoToolStripMenuItem1.Name = "ordemDeServiçoToolStripMenuItem1";
            this.ordemDeServiçoToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.ordemDeServiçoToolStripMenuItem1.Text = "Ordem de serviço";
            this.ordemDeServiçoToolStripMenuItem1.Click += new System.EventHandler(this.ordemDeServiçoToolStripMenuItem1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCliente,
            this.tsbServico,
            this.tsbOS,
            this.tsbOP,
            this.tsbCalc,
            this.tsbLogoff});
            this.toolStrip1.Location = new System.Drawing.Point(0, 27);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1028, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbCliente
            // 
            this.tsbCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCliente.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.tsbCliente.Image = ((System.Drawing.Image)(resources.GetObject("tsbCliente.Image")));
            this.tsbCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCliente.Name = "tsbCliente";
            this.tsbCliente.Size = new System.Drawing.Size(23, 22);
            this.tsbCliente.Text = "Cliente";
            this.tsbCliente.ToolTipText = "Cliente";
            this.tsbCliente.Click += new System.EventHandler(this.tsbCliente_Click);
            // 
            // tsbServico
            // 
            this.tsbServico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbServico.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.tsbServico.Image = ((System.Drawing.Image)(resources.GetObject("tsbServico.Image")));
            this.tsbServico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbServico.Name = "tsbServico";
            this.tsbServico.Size = new System.Drawing.Size(23, 22);
            this.tsbServico.Text = "Serviço";
            this.tsbServico.Click += new System.EventHandler(this.tsbServico_Click);
            // 
            // tsbOS
            // 
            this.tsbOS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOS.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.tsbOS.Image = ((System.Drawing.Image)(resources.GetObject("tsbOS.Image")));
            this.tsbOS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOS.Name = "tsbOS";
            this.tsbOS.Size = new System.Drawing.Size(23, 22);
            this.tsbOS.Text = "OS";
            this.tsbOS.Click += new System.EventHandler(this.tsbOS_Click);
            // 
            // tsbCalc
            // 
            this.tsbCalc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCalc.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.tsbCalc.Image = ((System.Drawing.Image)(resources.GetObject("tsbCalc.Image")));
            this.tsbCalc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCalc.Name = "tsbCalc";
            this.tsbCalc.Size = new System.Drawing.Size(23, 22);
            this.tsbCalc.Text = "Calculadora";
            this.tsbCalc.Click += new System.EventHandler(this.tsbCalc_Click);
            // 
            // tsbLogoff
            // 
            this.tsbLogoff.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLogoff.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.tsbLogoff.Image = ((System.Drawing.Image)(resources.GetObject("tsbLogoff.Image")));
            this.tsbLogoff.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLogoff.Name = "tsbLogoff";
            this.tsbLogoff.Size = new System.Drawing.Size(23, 22);
            this.tsbLogoff.Text = "Logoff";
            this.tsbLogoff.Click += new System.EventHandler(this.tsbLogoff_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslUsuario,
            this.tsslNivelAcesso,
            this.tsslIP,
            this.tsslNomePC,
            this.tsslData,
            this.tsslHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 727);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1028, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslUsuario
            // 
            this.tsslUsuario.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslUsuario.Name = "tsslUsuario";
            this.tsslUsuario.Size = new System.Drawing.Size(4, 17);
            // 
            // tsslNivelAcesso
            // 
            this.tsslNivelAcesso.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslNivelAcesso.Name = "tsslNivelAcesso";
            this.tsslNivelAcesso.Size = new System.Drawing.Size(4, 17);
            // 
            // tsslIP
            // 
            this.tsslIP.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslIP.Name = "tsslIP";
            this.tsslIP.Size = new System.Drawing.Size(4, 17);
            // 
            // tsslNomePC
            // 
            this.tsslNomePC.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslNomePC.Name = "tsslNomePC";
            this.tsslNomePC.Size = new System.Drawing.Size(4, 17);
            this.tsslNomePC.Click += new System.EventHandler(this.tsslData_Click);
            // 
            // tsslData
            // 
            this.tsslData.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslData.Name = "tsslData";
            this.tsslData.Size = new System.Drawing.Size(4, 17);
            this.tsslData.Click += new System.EventHandler(this.toolStripStatusLabel5_Click);
            // 
            // tsslHora
            // 
            this.tsslHora.Name = "tsslHora";
            this.tsslHora.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ordemDeProdutoToolStripMenuItem
            // 
            this.ordemDeProdutoToolStripMenuItem.Name = "ordemDeProdutoToolStripMenuItem";
            this.ordemDeProdutoToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.ordemDeProdutoToolStripMenuItem.Text = "Ordem de produto";
            this.ordemDeProdutoToolStripMenuItem.Click += new System.EventHandler(this.ordemDeProdutoToolStripMenuItem_Click);
            // 
            // tsbOP
            // 
            this.tsbOP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOP.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.tsbOP.Image = ((System.Drawing.Image)(resources.GetObject("tsbOP.Image")));
            this.tsbOP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOP.Name = "tsbOP";
            this.tsbOP.Size = new System.Drawing.Size(23, 22);
            this.tsbOP.Text = "OP";
            this.tsbOP.Click += new System.EventHandler(this.tsbOP_Click);
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 749);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTelaPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmTelaPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordemDeServiçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem serviçoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ordemDeServiçoToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbCliente;
        private System.Windows.Forms.ToolStripButton tsbServico;
        private System.Windows.Forms.ToolStripButton tsbOS;
        private System.Windows.Forms.ToolStripButton tsbLogoff;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslUsuario;
        private System.Windows.Forms.ToolStripStatusLabel tsslNivelAcesso;
        private System.Windows.Forms.ToolStripStatusLabel tsslIP;
        private System.Windows.Forms.ToolStripStatusLabel tsslNomePC;
        private System.Windows.Forms.ToolStripStatusLabel tsslData;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripButton tsbCalc;
        private System.Windows.Forms.ToolStripStatusLabel tsslHora;
        private System.Windows.Forms.ToolStripMenuItem ordemDeProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbOP;
    }
}