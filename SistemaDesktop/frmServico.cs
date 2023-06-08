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
    public partial class frmServico : Form
    {
        SqlConnection cn = new SqlConnection(Properties.Settings.Default.CadastroUsuarioConnectionString);
        SqlCommand cmd = null;

        public frmServico()
        {
            InitializeComponent();
        }

        private void frmServico_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cadastroUsuarioDataSet.tbServico' table. You can move, or remove it, as needed.
            this.tbServicoTableAdapter.Fill(this.cadastroUsuarioDataSet.tbServico);
            // TODO: This line of code loads data into the 'cadastroUsuarioDataSet.tbServico' table. You can move, or remove it, as needed.
            this.tbServicoTableAdapter.Fill(this.cadastroUsuarioDataSet.tbServico);

        }

        private void tbServicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (frmLogin.nivelAcesso == "")
                {
                    bindingNavigatorDeleteItem.Enabled = false;
                }
                if (nomeTextBox.Text != "")
                {

                    if (dataCadastroTextBox.Text == "")
                    {
                        dataCadastroTextBox.Text =
                       DateTime.Now.ToString();
                    }
                    if (cadastradoPorTextBox.Text == "")
                    {
                        cadastradoPorTextBox.Text =
                       frmLogin.usuarioConectado;
                    }
                    this.Validate();
                    this.tbServicoBindingSource.EndEdit();
                    this.tbServicoTableAdapter.Update(this.cadastroUsuarioDataSet.tbServico);
                    MessageBox.Show("Cadastro realizado com sucesso");
                }

                else
                {
                    MessageBox.Show("O Campo nome não pode ficar vazio");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível salvar pelo seguinte motivo: " + ex.Message);
            }

            //this.Validate();
            //this.tbServicoBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.cadastroUsuarioDataSet);

        }

        private void tbServicoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tbServicoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastroUsuarioDataSet);

        }

        private void LimparCampo()
        {
            idServicoTextBox.Clear();
            nomeTextBox.Clear();
            descricaoTextBox.Clear();
            valorTextBox.Clear();
            dataCadastroTextBox.Clear();
            cadastradoPorTextBox.Clear();
        }

        private void tbServicoDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LimparCampo();
            idServicoTextBox.Text = tbServicoDataGridView.CurrentRow.Cells[0].Value.ToString();
            nomeTextBox.Text = tbServicoDataGridView.CurrentRow.Cells[1].Value.ToString();
            descricaoTextBox.Text = tbServicoDataGridView.CurrentRow.Cells[2].Value.ToString();
            observacaoTextBox.Text = tbServicoDataGridView.CurrentRow.Cells[3].Value.ToString();
            valorTextBox.Text = tbServicoDataGridView.CurrentRow.Cells[4].Value.ToString();
            dataCadastroTextBox.Text = tbServicoDataGridView.CurrentRow.Cells[5].Value.ToString();
            cadastradoPorTextBox.Text = tbServicoDataGridView.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
