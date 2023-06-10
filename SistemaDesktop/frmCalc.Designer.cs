
namespace SistemaDesktop
{
    partial class frmCalc
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFGTSsal = new System.Windows.Forms.TextBox();
            this.btFGTScalc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFGTSmes = new System.Windows.Forms.TextBox();
            this.FGTS = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFGTSresult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCalc = new System.Windows.Forms.ComboBox();
            this.FGTS.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salário Bruto:";
            // 
            // txtFGTSsal
            // 
            this.txtFGTSsal.Location = new System.Drawing.Point(112, 35);
            this.txtFGTSsal.Name = "txtFGTSsal";
            this.txtFGTSsal.Size = new System.Drawing.Size(75, 20);
            this.txtFGTSsal.TabIndex = 1;
            // 
            // btFGTScalc
            // 
            this.btFGTScalc.Location = new System.Drawing.Point(112, 113);
            this.btFGTScalc.Name = "btFGTScalc";
            this.btFGTScalc.Size = new System.Drawing.Size(75, 23);
            this.btFGTScalc.TabIndex = 2;
            this.btFGTScalc.Text = "button1";
            this.btFGTScalc.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Meses Trabalhados:";
            // 
            // txtFGTSmes
            // 
            this.txtFGTSmes.Location = new System.Drawing.Point(112, 73);
            this.txtFGTSmes.Name = "txtFGTSmes";
            this.txtFGTSmes.Size = new System.Drawing.Size(75, 20);
            this.txtFGTSmes.TabIndex = 4;
            // 
            // FGTS
            // 
            this.FGTS.Controls.Add(this.label3);
            this.FGTS.Controls.Add(this.txtFGTSresult);
            this.FGTS.Controls.Add(this.txtFGTSsal);
            this.FGTS.Controls.Add(this.btFGTScalc);
            this.FGTS.Controls.Add(this.label2);
            this.FGTS.Controls.Add(this.txtFGTSmes);
            this.FGTS.Controls.Add(this.label1);
            this.FGTS.Location = new System.Drawing.Point(15, 57);
            this.FGTS.Name = "FGTS";
            this.FGTS.Size = new System.Drawing.Size(201, 219);
            this.FGTS.TabIndex = 5;
            this.FGTS.TabStop = false;
            this.FGTS.Text = "FGTS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Salário Bruto:";
            // 
            // txtFGTSresult
            // 
            this.txtFGTSresult.Location = new System.Drawing.Point(112, 168);
            this.txtFGTSresult.Name = "txtFGTSresult";
            this.txtFGTSresult.Size = new System.Drawing.Size(75, 20);
            this.txtFGTSresult.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Selecione o calculo:";
            // 
            // cbCalc
            // 
            this.cbCalc.FormattingEnabled = true;
            this.cbCalc.Items.AddRange(new object[] {
            "",
            "FGTS"});
            this.cbCalc.Location = new System.Drawing.Point(121, 18);
            this.cbCalc.Name = "cbCalc";
            this.cbCalc.Size = new System.Drawing.Size(121, 21);
            this.cbCalc.TabIndex = 8;
            this.cbCalc.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // frmCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 364);
            this.Controls.Add(this.cbCalc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FGTS);
            this.Name = "frmCalc";
            this.Text = "frmCalcFGTS";
            this.Load += new System.EventHandler(this.frmCalc_Load);
            this.FGTS.ResumeLayout(false);
            this.FGTS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFGTSsal;
        private System.Windows.Forms.Button btFGTScalc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFGTSmes;
        private System.Windows.Forms.GroupBox FGTS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFGTSresult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCalc;
    }
}