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
            tsslUsuario.Text = "Usuário: " + frmLogin.usuarioConectado;

            string myHost = System.Net.Dns.GetHostName();
            tsslNomePC.Text = "Nome do PC: " + myHost;

            System.Net.IPHostEntry myIPs = System.Net.Dns.GetHostEntry(myHost);

            foreach (System.Net.IPAddress myIP in myIPs.AddressList)
            {
                tsslIP.Text = "IP: " + myIP;
            }

            tsslNivelAcesso.Text = "Nivel de Acesso: " + frmLogin.nivelAcesso;


        }

        private void toolStripStatusLabel5_Click(object sender, EventArgs e)
        {

        }

        private void tsslData_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsslData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            tsslHora.Text = DateTime.Now.ToString("HH:mm");
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmUsuario usuario = null;

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

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmCliente cliente = null;

                    foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmCliente)
                    {
                        cliente = (frmCliente)frm;
                        break;

                    }


                }
                if (cliente == null)
                {
                    cliente = new frmCliente();
                    cliente.MdiParent = this;
                    cliente.Show();
                }
                cliente.Focus();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel se conectar ao formulário devido ao erro: " + ex.Message,
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void serviçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmServico servico = null;

                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmServico)
                    {
                        servico = (frmServico)frm;
                        break;

                    }


                }
                if (servico == null)
                {
                    servico = new frmServico();
                    servico.MdiParent = this;
                    servico.Show();
                }
                servico.Focus();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel se conectar ao formulário devido ao erro: " + ex.Message,
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ordemDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmOS os = null;

                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmOS)
                    {
                        os = (frmOS)frm;
                        break;

                    }


                }
                if (os == null)
                {
                    os = new frmOS();
                    os.MdiParent = this;
                    os.Show();
                }
                os.Focus();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel se conectar ao formulário devido ao erro: " + ex.Message,
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmrelatCliente relatcliente = null;

                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmrelatCliente)
                    {
                        relatcliente = (frmrelatCliente)frm;
                        break;

                    }


                }
                if (relatcliente == null)
                {
                    relatcliente = new frmrelatCliente();
                    relatcliente.MdiParent = this;
                    relatcliente.Show();
                }
                relatcliente.Focus();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel se conectar ao formulário devido ao erro: " + ex.Message,
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void serviçoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmrelatServico relatservico = null;

                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmrelatServico)
                    {
                        relatservico = (frmrelatServico)frm;
                        break;

                    }


                }
                if (relatservico == null)
                {
                    relatservico = new frmrelatServico();
                    relatservico.MdiParent = this;
                    relatservico.Show();
                }
                relatservico.Focus();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel se conectar ao formulário devido ao erro: " + ex.Message,
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ordemDeServiçoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmrelatOS relatos = null;

                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmrelatOS)
                    {
                        relatos = (frmrelatOS)frm;
                        break;

                    }


                }
                if (relatos == null)
                {
                    relatos = new frmrelatOS();
                    relatos.MdiParent = this;
                    relatos.Show();
                }
                relatos.Focus();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel se conectar ao formulário devido ao erro: " + ex.Message,
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsbCliente_Click(object sender, EventArgs e)
        {
            try
            {
                frmCliente cliente = null;

                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmCliente)
                    {
                        cliente = (frmCliente)frm;
                        break;

                    }


                }
                if (cliente == null)
                {
                    cliente = new frmCliente();
                    cliente.MdiParent = this;
                    cliente.Show();
                }
                cliente.Focus();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel se conectar ao formulário devido ao erro: " + ex.Message,
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsbServico_Click(object sender, EventArgs e)
        {
            try
            {
                frmServico servico = null;

                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmServico)
                    {
                        servico = (frmServico)frm;
                        break;

                    }


                }
                if (servico == null)
                {
                    servico = new frmServico();
                    servico.MdiParent = this;
                    servico.Show();
                }
                servico.Focus();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel se conectar ao formulário devido ao erro: " + ex.Message,
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsbOS_Click(object sender, EventArgs e)
        {
            try
            {
                frmOS os = null;

                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmOS)
                    {
                        os = (frmOS)frm;
                        break;

                    }


                }
                if (os == null)
                {
                    os = new frmOS();
                    os.MdiParent = this;
                    os.Show();
                }
                os.Focus();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel se conectar ao formulário devido ao erro: " + ex.Message,
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsbLogoff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmTelaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tsbCalc_Click(object sender, EventArgs e)
        {
            try
            {
                frmCalc cal = null;

                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmCalc)
                    {
                        cal = (frmCalc)frm;
                        break;

                    }


                }
                if (cal == null)
                {
                    cal = new frmCalc();
                    cal.MdiParent = this;
                    cal.Show();
                }
                cal.Focus();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel se conectar ao formulário devido ao erro: " + ex.Message,
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void tsbCalcular_Click(object sender, EventArgs e)
        {
            

        }
    }
}

