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
    public partial class frmLogin : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.CadastroUsuarioConnectionString);
        public static string NivelAcesso;
        public static 
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtUsuario.Text != "") && (cbmNivelAcesso.Text != "") && (txtSenha.Text != ""))
                {
                    SqlCommand comm = new SqlCommand("Select * From tbUsuario Where nomeUsuario = @usuario and " + "senha = @senha and nivelAcesso=@nivel", conn);
                    comm.Parameters.Add("@usuario", SqlDbType.VarChar).Value = txtUsuario.Text;
                    comm.Parameters.Add("@senha", SqlDbType.VarChar).Value = txtSenha.Text;
                    comm.Parameters.Add("@nivel", SqlDbType.VarChar).Value = cbmNivelAcesso.Text;
                    conn.Open();
                    SqlDataReader reader = null;
                    reader = comm.ExecuteReader();
                    if (reader.Read())
                    {
                        //Será implementado mais adiante
                    }
                    else
                    {
                        MessageBox.Show(
                            "Usuário ou senha incorretos",
                            "Atenção!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Todos os Campos são obrigatórios",
                        "Atenção!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
