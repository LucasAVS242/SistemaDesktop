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
    public partial class frmCliente : Form
    {
        SqlConnection cn = new SqlConnection(Properties.Settings.Default.CadastroUsuarioConnectionString);

        public frmCliente()
        {
            InitializeComponent();
        }

        private void tbClienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if ((idClienteTextBox.Text != "") && (cnpjTextBox.Text != "") && (emailTextBox.Text != "") && (telefoneTextBox.Text != "") && (logradouroTextBox.Text != "") && (numeroTextBox.Text != "") && (bairroTextBox.Text != "") && (cidadeTextBox.Text != "") && (cepTextBox.Text != "") && (estadoTextBox.Text != ""))
                {
                        if (dataCadastroTextBox.Text == "")
                        {
                            dataCadastroTextBox.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

                        }

                        if (cadastradoPorTextBox.Text == "")
                        {
                            cadastradoPorTextBox.Text = frmLogin.usuarioConectado;


                        }
                        this.Validate();
                        this.tbClienteBindingSource.EndEdit();
                        MessageBox.Show("Cadastro realizado com sucesso");
                        this.tbClienteTableAdapter.Update(this.cadastroUsuarioDataSet.tbCliente);
                }
                else
                {
                    MessageBox.Show(
                        "Nenhum campo pode ficar vazio",
                        "Atenção!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel salvar pelo seguinte motivo: " + ex.Message);
            }

            //this.Validate();
            //this.tbClienteBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.cadastroUsuarioDataSet);

        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cadastroUsuarioDataSet.tbCliente' table. You can move, or remove it, as needed.
            this.tbClienteTableAdapter.Fill(this.cadastroUsuarioDataSet.tbCliente);

            if (frmLogin.nivelAcesso == "Usuario")
            {
                bindingNavigatorDeleteItem.Enabled = false;
            }
        }

        private void LimparCampo()
        {
            idClienteTextBox.Clear();
            nomeTextBox.Clear();
            cnpjTextBox.Clear();
            emailTextBox.Clear();
            telefoneTextBox.Clear();
            logradouroTextBox.Clear();
            numeroTextBox.Clear();
            bairroTextBox.Clear();
            cidadeTextBox.Clear();
            cepTextBox.Clear();
            estadoTextBox.Clear();
            dataCadastroTextBox.Clear();
            cadastradoPorTextBox.Clear();
        }

        private void tbClienteDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LimparCampo();
            idClienteTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[0].Value.ToString();
            nomeTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[1].Value.ToString();
            cnpjTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[2].Value.ToString();
            emailTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[3].Value.ToString();
            telefoneTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[4].Value.ToString();
            logradouroTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[5].Value.ToString();
            numeroTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[6].Value.ToString();
            bairroTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[7].Value.ToString();
            cidadeTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[8].Value.ToString();
            cepTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[9].Value.ToString();
            estadoTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[10].Value.ToString();
            dataCadastroTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[11].Value.ToString();
            cadastradoPorTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[12].Value.ToString();
        }
    }
}
