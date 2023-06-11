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
        }
        private void Limpar()
        {

            txtFGTSmes.Clear();
            txtResult.Clear();
            txtFGTSsal.Clear();
        }

        private void frmCalc_Load(object sender, EventArgs e)
        {
            Vis();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vis();
            if (cbCalc.Text == "FGTS")
            {
                FGTS.Visible = true;
            }
            if (cbCalc.Text == "INSS")
            {
                FGTS.Visible = true;
            }
        }

        private void btFGTScalc_Click(object sender, EventArgs e)
        {
            if (cbCalc.Text == "FGTS")
            {
                double fgtsSal, fgtsMes;


                fgtsSal = double.Parse(txtFGTSsal.Text);
                fgtsMes = int.Parse(txtFGTSmes.Text);
                R = (fgtsMes * fgtsSal) * 0.08;

                txtResult.Text = R.ToString("R$ ");
            }

            if (cbCalc.Text == "INSS")
            {
                if (cbINSStab.Text == "05/2023")
                {
                    double inssSal;

                    inssSal = double.Parse(txtINSSsal.Text);

                    if (inssSal <= 1320)
                    {
                        R = inssSal * 0.075;
                    }
                    if (inssSal >1320 && inssSal < 2571.30)
                    {
                        R = (inssSal - 1320) * 0.09;

                    }



                }
            }



        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
