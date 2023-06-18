using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDesktop
{
    public partial class frmCalc : Form
    {


        public frmCalc()
        {
            InitializeComponent();
        }
        public double R;

        private void Vis()
        {
            FGTS.Visible = false;
            INSS.Visible = false;
            IRRF.Visible = false;

            FGTS.Location = new Point(284, 57);
            INSS.Location = new Point(284, 57);
            IRRF.Location = new Point(284, 57);
        }
        private void Limpar()
        {

            txtFGTSmes.Text = "0";
            txtResult.Text = "0,00";
            txtFGTSsal.Text = "0,00";
            txt1faixa.Text = "0,00";
            txt2faixa.Text = "0,00";
            txt3faixa.Text = "0,00";
            txt4faixa.Text = "0,00";
            txtINSStotal.Text = "0,00";
            txtINSSsal.Text = "0,00";
            txtIRRFdev.Text = "0,00";
            txtIRRFod.Text = "0,00";
            txtIRRFpa.Text = "0,00";
            txtIRRFres.Text = "0,00";
            txtIRRFsal.Text = "0,00";
            


        }

        private void frmCalc_Load(object sender, EventArgs e)
        {
            Vis();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Limpar();
            Vis();

            if (cbCalc.Text == "FGTS")
            {
                FGTS.Visible = true;
                FGTS.Location = new Point(15, 57);
            }
            if (cbCalc.Text == "INSS")
            {
                INSS.Visible = true;
                INSS.Location = new Point(15, 57);
            }
            if (cbCalc.Text == "IRRF")
            {
                IRRF.Visible = true;
                IRRF.Location = new Point(15, 57);
            }

        }

            private void label10_Click(object sender, EventArgs e)
            {

            }

            private void btLimpar_Click(object sender, EventArgs e)
            {
                Limpar();

            }

            private void btCalc_Click(object sender, EventArgs e)
            {
                if (cbCalc.Text == "IRRF")
                { 
                /*Tabela IRRF a partir do mês 05/2023
                Base de Cálculo          (R$	Alíquota (%)	Parcela a Deduzir do IR (R$)
                Até 2.112,00	                          0	         0
                De 2.112,01 até 2.826,65	              7,5        158,40
                De 2.826,66 até 3.751,05	              15	     370,40
                De 3.751,06 até 4.664,68	              22,50	     651,73
                Acima de 4.664,68	                      27,50   	 884,96
                * */
            {
                    double irrfSal, irrfPA = 0, irrfOD = 0,irrfDev;
                    int irrfDep = 0;
                    
                    if (cbIRRFdep.Text != "")
                    irrfDep = int.Parse(cbIRRFdep.Text);
                    if (txtIRRFod.Text != "")
                    irrfOD = double.Parse(txtIRRFod.Text);
                    if (txtIRRFod.Text != "") 
                    irrfPA = double.Parse(txtIRRFpa.Text);




                if (txtIRRFsal.Text != "")
                {
                    irrfSal = double.Parse(txtIRRFsal.Text);

                    if (cbIRFFtab.Text == "05/2023")
                    {
                        if (irrfSal <= 1320)
                        {
                            R = irrfSal * 0.075;

                        }
                        if (irrfSal >= 1321 && irrfSal <= 2571.29)
                        {
                            R = (irrfSal - 1320) * 0.09 + 99;

                        }
                        if (irrfSal >= 2571.30 && irrfSal <= 3856.94)
                        {
                            R = (irrfSal - 2571.29) * 0.12 + 99 + 112.62;


                        }
                        if (irrfSal >= 3856.95 && irrfSal <= 7507.49)
                        {
                            R = (irrfSal - 3856.94) * 0.14 + 99 + 112.62 + 154.28;

                        }
                        if (irrfSal >= 7507.50)
                        {
                            R = 876.97;

                        }
                    }
                    if (cbIRRFtab2.Text == "05/2023")
                    {
                        irrfSal += -(R + (irrfDep * 189.59) + irrfPA + irrfOD);

                        if (irrfSal <= 2.112) {

                            txtIRRFdev.Text = string.Format("{0:c}", 0)
                            txtIRRFres.Text = string.Format("{0:c}", irrfSal);
                        }

                        if (irrfSal >= 2112.01 && irrfSal <= 2826.65)
                        {
                            irrfDev = (irrfSal * 0.075) - 158.40;
                            irrfSal += -irrfDev;
                            txtIRRFdev.Text = string.Format("{0:c}", irrfDev);
                            txtIRRFres.Text = string.Format("{0:c}", irrfSal);



                        }
                            if (irrfSal >= 2826.66 && irrfSal <= 3751.05)
                            {
                                irrfDev = (irrfSal * 0.15) - 370.40;
                                irrfSal += -irrfDev;
                                txtIRRFdev.Text = string.Format("{0:c}", irrfDev);
                                txtIRRFres.Text = string.Format("{0:c}", irrfSal);
                            }
                            if (irrfSal >= 3751.06 && irrfSal <= 4664.68)
                            {
                                irrfDev = (irrfSal * 0.225) - 651.73;
                                irrfSal += -irrfDev;
                                txtIRRFdev.Text = string.Format("{0:c}", irrfDev);
                                txtIRRFres.Text = string.Format("{0:c}", irrfSal);
                            }
                            if (irrfSal > 4664.68)
                            {
                                irrfDev = (irrfSal * 0.275) - 651.73;
                                irrfSal += -irrfDev;
                                txtIRRFdev.Text = string.Format("{0:c}", irrfDev);
                                txtIRRFres.Text = string.Format("{0:c}", irrfSal);
                            }

                    }


                }
                if (cbCalc.Text == "FGTS")
                {

                    double fgtsSal, fgtsMes;

                    if (txtFGTSsal.Text != "" && txtFGTSmes.Text != "")
                    {

                        fgtsSal = double.Parse(txtFGTSsal.Text);
                        fgtsMes = double.Parse(txtFGTSmes.Text);


                        R = (fgtsMes * fgtsSal) * 0.08;

                        txtResult.Text = string.Format("{0:c}", R);
                    }
                }

                if (cbCalc.Text == "INSS")
                {
                    /*
                     * Salário de até R$ 1.320,00 |7,5%
                       De R$ 1.320,01 até R$ 2.571,29 |9%
                       De R$ 2.571,30 até R$ 3.856,94 |12%
                       De R$ 3.856,95 até R$ 7.507,49 |14%
                     * */
                    if (cbINSStab.Text == "05/2023")
                    {
                        double inssSal;


                        if (txtINSSsal.Text != "")
                        {
                            inssSal = double.Parse(txtINSSsal.Text);


                            if (inssSal <= 1320)
                            {
                                R = inssSal * 0.075;
                                txt1faixa.Text = string.Format("{0:c}", R);

                                txtINSStotal.Text = string.Format("{0:c}", R);
                            }
                            if (inssSal >= 1321 && inssSal <= 2571.29)
                            {
                                R = (inssSal - 1320) * 0.09;
                                txt1faixa.Text = "$99,00";
                                txt2faixa.Text = string.Format("{0:c}", R);

                                txtINSStotal.Text = string.Format("{0:c}", (R + 99));

                            }
                            if (inssSal >= 2571.30 && inssSal <= 3856.94)
                            {
                                R = (inssSal - 2571.29) * 0.12;
                                txt1faixa.Text = string.Format("{0:c}", 99);
                                txt2faixa.Text = string.Format("{0:c}", 112.62);
                                txt3faixa.Text = string.Format("{0:c}", R);

                                txtINSStotal.Text = string.Format("{0:c}", (R + 99 + 112.62));

                            }
                            if (inssSal >= 3856.95 && inssSal <= 7507.49)
                            {
                                R = (inssSal - 3856.94) * 0.14;
                                txt1faixa.Text = string.Format("{0:c}", 99);
                                txt2faixa.Text = string.Format("{0:c}", 112.62);
                                txt3faixa.Text = string.Format("{0:c}", 154.28);
                                txt4faixa.Text = string.Format("{0:c}", R);

                                txtINSStotal.Text = string.Format("{0:c}", (R + 99 + 112.62 + 154.28));
                            }
                            if (inssSal >= 7507.50)
                            {
                                txt1faixa.Text = string.Format("{0:c}", 99);
                                txt2faixa.Text = string.Format("{0:c}", 112.62);
                                txt3faixa.Text = string.Format("{0:c}", 154.28);
                                txt4faixa.Text = string.Format("{0:c}", 511.07);

                                txtINSStotal.Text = string.Format("{0:c}", 876.97);

                            }


                        }
                    }
                }


            }
        
        private void txtFGTSsal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtINSSsal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtFGTSmes_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

