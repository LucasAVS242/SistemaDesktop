using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SistemaDesktop
{
    public partial class frmTelaPrincipal : Form
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void frmTelaPrincipal_Load(object sender, EventArgs e)
        {
            if (frmLogin.nivelAcesso == "Usuario")
            {
                usuárioToolStripMenuItem.Visible = false;

            }
            tsslUsuario.Text = "Usuario: " + frmLogin.usuarioConectado;

            string myHost = System.Net.Dns.GetHostName();
            tsslNomePC.Text = "Nome do PC: " + myHost;

            System.Net.IPHostEntry myIPs = System.Net.Dns.GetHostEntry(myHost);

            foreach (System.Net.IPAddress myIP in myIPs.AddressList)
            {
                tsslIP.Text = "IP" + myIp;
            }




        }

        private void toolStripStatusLabel5_Click(object sender, EventArgs e)
        {

        }

        private void tsslData_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsslData.Text = DateTime.Now.ToString("HH:mm")
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmUsuario  usuario = null

                    foreach (Form frm in this.MdiChildren)
                    {
                        if (frm is frmUsuario)
                        {
                        usuario = (frmUsuario)frm;
                        break;
                        
                        }   


                    }
                    if (usuario == null)
                    {
                        usuario = new frmUsuario();
                        usuario.MdiParent = this;
                        usuario.Show();
                    }
                usuario.Focus();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel se conectar ao formulário devido ao erro: " + ex.Message,
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
