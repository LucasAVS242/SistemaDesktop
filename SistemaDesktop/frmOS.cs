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
    public partial class frmOS : Form
    {
        SqlConnection cn = new SqlConnection(Properties.Settings.Default.CadastroUsuarioConnectionString);
        SqlCommand cmd = null;

        public frmOS()
        {
            InitializeComponent();
        }

        private void frmOS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cadastroUsuarioDataSet.tbOS' table. You can move, or remove it, as needed.
            this.tbOSTableAdapter.Fill(this.cadastroUsuarioDataSet.tbOS);

            if (frmLogin.nivelAcesso == "Usuario")
            {
                bindingNavigatorDeleteItem.Enabled = false;
            }
        }

        private void tbOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (frmLogin.nivelAcesso == "Usuario")
                {
                    bindingNavigatorDeleteItem.Enabled = false;
                }
                if ((idClienteTextBox.Text != "") && (idOSTextBox.Text != ""))
                {
                    SqlCommand comm = new SqlCommand("Select idCliente From tbCliente Where idCliente = @idCliente", cn);
                    comm.Parameters.Add("@idCliente", SqlDbType.Int).Value = idClienteTextBox.Text;
                    cn.Open();
                    SqlDataReader reader = null;
                    reader = comm.ExecuteReader();
                    if (reader.Read())
                    {
                        if (dataCadastroTextBox.Text == "")
                        {
                            dataCadastroTextBox.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

                        }

                        if (cadastradoPorTextBox.Text == "")
                        {
                            cadastradoPorTextBox.Text =
                           frmLogin.usuarioConectado;
                        }
                        this.Validate();
                        this.tbOSBindingSource.EndEdit();
                        this.tbOSTableAdapter.Update(this.cadastroUsuarioDataSet.tbOS);
                        MessageBox.Show("Cadastro realizado com sucesso");
                    }
                    else
                    {
                        MessageBox.Show(
                        "ID Cliente informado não existe nos registros",
                        "Atenção!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Todos os campos são obrigatórios",
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
                cn.Close();
            }

            //this.Validate();
            //this.tbOSBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.cadastroUsuarioDataSet);

        }

        private void LimparCampo()
        {
            idOSTextBox.Clear();
            idClienteTextBox.Clear();
            dataCadastroTextBox.Clear();
            cadastradoPorTextBox.Clear();
        }

        private void tbOSDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LimparCampo();
            idOSTextBox.Text = tbOSDataGridView.CurrentRow.Cells[0].Value.ToString();
            idClienteTextBox.Text = tbOSDataGridView.CurrentRow.Cells[1].Value.ToString();
            dataCadastroTextBox.Text = tbOSDataGridView.CurrentRow.Cells[2].Value.ToString();
            cadastradoPorTextBox.Text = tbOSDataGridView.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
