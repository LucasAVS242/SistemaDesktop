
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtFGTSmes = new System.Windows.Forms.TextBox();
            this.FGTS = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCalc = new System.Windows.Forms.ComboBox();
            this.INSS = new System.Windows.Forms.GroupBox();
            this.txt4faixa = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtINSStotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt3faixa = new System.Windows.Forms.TextBox();
            this.txt2faixa = new System.Windows.Forms.TextBox();
            this.txt1faixa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbINSStab = new System.Windows.Forms.ComboBox();
            this.txtINSSsal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btCalc = new System.Windows.Forms.Button();
            this.FGTS.SuspendLayout();
            this.INSS.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salário Bruto:";
            // 
            // txtFGTSsal
            // 
            this.txtFGTSsal.Location = new System.Drawing.Point(146, 35);
            this.txtFGTSsal.Name = "txtFGTSsal";
            this.txtFGTSsal.Size = new System.Drawing.Size(75, 25);
            this.txtFGTSsal.TabIndex = 1;
            this.txtFGTSsal.Text = "0,00";
            this.txtFGTSsal.TextChanged += new System.EventHandler(this.txtFGTSsal_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Meses Trabalhados:";
            // 
            // txtFGTSmes
            // 
            this.txtFGTSmes.Location = new System.Drawing.Point(146, 70);
            this.txtFGTSmes.Name = "txtFGTSmes";
            this.txtFGTSmes.Size = new System.Drawing.Size(75, 25);
            this.txtFGTSmes.TabIndex = 4;
            // 
            // FGTS
            // 
            this.FGTS.Controls.Add(this.label3);
            this.FGTS.Controls.Add(this.txtFGTSsal);
            this.FGTS.Controls.Add(this.label2);
            this.FGTS.Controls.Add(this.txtFGTSmes);
            this.FGTS.Controls.Add(this.txtResult);
            this.FGTS.Controls.Add(this.label1);
            this.FGTS.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.FGTS.Location = new System.Drawing.Point(15, 57);
            this.FGTS.Name = "FGTS";
            this.FGTS.Size = new System.Drawing.Size(227, 244);
            this.FGTS.TabIndex = 5;
            this.FGTS.TabStop = false;
            this.FGTS.Text = "FGTS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Resultado:";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(146, 180);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(75, 25);
            this.txtResult.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Selecione o calculo:";
            // 
            // cbCalc
            // 
            this.cbCalc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCalc.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbCalc.FormattingEnabled = true;
            this.cbCalc.Items.AddRange(new object[] {
            "",
            "FGTS",
            "INSS"});
            this.cbCalc.Location = new System.Drawing.Point(143, 18);
            this.cbCalc.Name = "cbCalc";
            this.cbCalc.Size = new System.Drawing.Size(121, 25);
            this.cbCalc.TabIndex = 8;
            this.cbCalc.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // INSS
            // 
            this.INSS.Controls.Add(this.txt4faixa);
            this.INSS.Controls.Add(this.label11);
            this.INSS.Controls.Add(this.txtINSStotal);
            this.INSS.Controls.Add(this.label10);
            this.INSS.Controls.Add(this.txt3faixa);
            this.INSS.Controls.Add(this.txt2faixa);
            this.INSS.Controls.Add(this.txt1faixa);
            this.INSS.Controls.Add(this.label9);
            this.INSS.Controls.Add(this.label8);
            this.INSS.Controls.Add(this.label5);
            this.INSS.Controls.Add(this.cbINSStab);
            this.INSS.Controls.Add(this.txtINSSsal);
            this.INSS.Controls.Add(this.label6);
            this.INSS.Controls.Add(this.label7);
            this.INSS.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.INSS.Location = new System.Drawing.Point(284, 57);
            this.INSS.Name = "INSS";
            this.INSS.Size = new System.Drawing.Size(240, 312);
            this.INSS.TabIndex = 9;
            this.INSS.TabStop = false;
            this.INSS.Text = "INSS";
            // 
            // txt4faixa
            // 
            this.txt4faixa.Enabled = false;
            this.txt4faixa.Location = new System.Drawing.Point(137, 223);
            this.txt4faixa.Name = "txt4faixa";
            this.txt4faixa.Size = new System.Drawing.Size(83, 25);
            this.txt4faixa.TabIndex = 14;
            this.txt4faixa.Text = "0,00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(75, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "4ª Faixa:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtINSStotal
            // 
            this.txtINSStotal.Enabled = false;
            this.txtINSStotal.Location = new System.Drawing.Point(137, 281);
            this.txtINSStotal.Name = "txtINSStotal";
            this.txtINSStotal.Size = new System.Drawing.Size(83, 25);
            this.txtINSStotal.TabIndex = 12;
            this.txtINSStotal.Text = "0,00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(88, 284);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Total:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txt3faixa
            // 
            this.txt3faixa.Enabled = false;
            this.txt3faixa.Location = new System.Drawing.Point(137, 192);
            this.txt3faixa.Name = "txt3faixa";
            this.txt3faixa.Size = new System.Drawing.Size(83, 25);
            this.txt3faixa.TabIndex = 10;
            this.txt3faixa.Text = "0,00";
            // 
            // txt2faixa
            // 
            this.txt2faixa.Enabled = false;
            this.txt2faixa.Location = new System.Drawing.Point(137, 161);
            this.txt2faixa.Name = "txt2faixa";
            this.txt2faixa.Size = new System.Drawing.Size(83, 25);
            this.txt2faixa.TabIndex = 9;
            this.txt2faixa.Text = "0,00";
            // 
            // txt1faixa
            // 
            this.txt1faixa.Enabled = false;
            this.txt1faixa.Location = new System.Drawing.Point(137, 130);
            this.txt1faixa.Name = "txt1faixa";
            this.txt1faixa.Size = new System.Drawing.Size(83, 25);
            this.txt1faixa.TabIndex = 8;
            this.txt1faixa.Text = "0,00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(70, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "3ª Faixa:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "2ª Faixa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "1ª Faixa:";
            // 
            // cbINSStab
            // 
            this.cbINSStab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbINSStab.FormattingEnabled = true;
            this.cbINSStab.Items.AddRange(new object[] {
            "",
            "05/2023"});
            this.cbINSStab.Location = new System.Drawing.Point(137, 73);
            this.cbINSStab.Name = "cbINSStab";
            this.cbINSStab.Size = new System.Drawing.Size(83, 25);
            this.cbINSStab.TabIndex = 4;
            // 
            // txtINSSsal
            // 
            this.txtINSSsal.Location = new System.Drawing.Point(137, 35);
            this.txtINSSsal.Name = "txtINSSsal";
            this.txtINSSsal.Size = new System.Drawing.Size(83, 25);
            this.txtINSSsal.TabIndex = 1;
            this.txtINSSsal.Text = "0,00";
            this.txtINSSsal.TextChanged += new System.EventHandler(this.txtINSSsal_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tabela:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Salário Bruto:";
            // 
            // btLimpar
            // 
            this.btLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btLimpar.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btLimpar.Location = new System.Drawing.Point(366, 16);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(89, 35);
            this.btLimpar.TabIndex = 10;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btCalc
            // 
            this.btCalc.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btCalc.Location = new System.Drawing.Point(270, 16);
            this.btCalc.Name = "btCalc";
            this.btCalc.Size = new System.Drawing.Size(90, 35);
            this.btCalc.TabIndex = 11;
            this.btCalc.Text = "Calcular";
            this.btCalc.UseVisualStyleBackColor = true;
            this.btCalc.Click += new System.EventHandler(this.btCalc_Click);
            // 
            // frmCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(536, 393);
            this.Controls.Add(this.btCalc);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.INSS);
            this.Controls.Add(this.cbCalc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FGTS);
            this.Name = "frmCalc";
            this.Text = "Calculos";
            this.Load += new System.EventHandler(this.frmCalc_Load);
            this.FGTS.ResumeLayout(false);
            this.FGTS.PerformLayout();
            this.INSS.ResumeLayout(false);
            this.INSS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFGTSsal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFGTSmes;
        private System.Windows.Forms.GroupBox FGTS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCalc;
        private System.Windows.Forms.GroupBox INSS;
        private System.Windows.Forms.TextBox txtINSSsal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbINSStab;
        private System.Windows.Forms.TextBox txtINSStotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt3faixa;
        private System.Windows.Forms.TextBox txt2faixa;
        private System.Windows.Forms.TextBox txt1faixa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt4faixa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btCalc;
    }
}