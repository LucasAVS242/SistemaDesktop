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

            FGTS.Location = new Point(284, 57);
            INSS.Location = new Point(284, 57);
        }
        private void Limpar()
        {

            txtFGTSmes.Clear();
            txtResult.Clear();
            txtFGTSsal.Clear();
            txt1faixa.Clear();
            txt2faixa.Clear();
            txt3faixa.Clear();
            txt4faixa.Clear();
            txtINSStotal.Clear();
            txtINSSsal.Clear();
           

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
           
            if (cbCalc.Text == "FGTS")
            {
                double fgtsSal, fgtsMes;

           

                fgtsSal = double.Parse(txtFGTSsal.Text);
                fgtsMes = double.Parse(txtFGTSmes.Text);

               
                R = (fgtsMes * fgtsSal) * 0.08;

                txtResult.Text = string.Format("{0:c}", R);
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

                    txtINSSsal.Text.Replace(",", ".");

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
                        txt2faixa.Text = R.ToString();

                        txtINSStotal.Text = string.Format("{0:c}", (R + 99));

                    }
                    if (inssSal >= 2571.30 && inssSal <= 3856.94)
                    {
                        R = (inssSal - 2571.29) * 0.12;
                        txt1faixa.Text = "$99,00";
                        txt2faixa.Text = "$112,62";
                        txt3faixa.Text = string.Format("{0:c}", R);

                        txtINSStotal.Text = string.Format("{0:c}", (R + 99 + 112.62));

                    }
                    if (inssSal >= 3856.95 && inssSal <= 7507.49)
                    {
                        R = (inssSal - 3856.94) * 0.14;
                        txt1faixa.Text = "$99,00";
                        txt2faixa.Text = "$112,62";
                        txt3faixa.Text = "$154,28";
                        txt4faixa.Text = string.Format("{0:c}", R);

                        txtINSStotal.Text = string.Format("{0:c}",(R + 99 + 112.62 + 154.28));
                    }
                    if (inssSal >= 7507.50)
                    {
                        txt1faixa.Text = "$99,00";
                        txt2faixa.Text = "$112,62";
                        txt3faixa.Text = "$154,28";
                        txt4faixa.Text = "$511,07";

                        txtINSStotal.Text = "$876,97";

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
    }
}
