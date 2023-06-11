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
    public partial class frmUsuario : Form
    {
        SqlConnection cn = new SqlConnection(Properties.Settings.Default.CadastroUsuarioConnectionString);
        
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void tbUsuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if ((idUsuarioTextBox.Text != "") && (nivelAcessoComboBox.Text != "") && (senhaTextBox.Text != ""))
                {
                    if (senhaTextBox.Text == repitasenhaTextBox.Text)
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
                        this.tbUsuarioBindingSource.EndEdit();
                        MessageBox.Show("Cadastro realizado com sucesso");
                        this.tbUsuarioTableAdapter.Update(this.cadastroUsuarioDataSet.tbUsuario);

                    }
                    else
                    {
                        MessageBox.Show(
                            "As senhas precisam ser iguais",
                            "Atenção!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }

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
            //this.tbUsuarioBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.cadastroUsuarioDataSet);

        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cadastroUsuarioDataSet.tbUsuario' table. You can move, or remove it, as needed.
            this.tbUsuarioTableAdapter.Fill(this.cadastroUsuarioDataSet.tbUsuario);

            if (frmLogin.nivelAcesso == "Usuario")
            {
                bindingNavigatorDeleteItem.Enabled = false;
            }
        }

        private void LimparCampo()
        {
            idUsuarioTextBox.Clear();
            nomeUsuarioTextBox.Clear();
            senhaTextBox.Clear();
            repitasenhaTextBox.Clear();
            nivelAcessoComboBox.SelectedIndex = -1;
            dataCadastroTextBox.Clear();
            cadastradoPorTextBox.Clear();
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void nomeUsuarioLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tbUsuarioDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbUsuarioDataGridView_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void tbUsuarioDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LimparCampo();
            idUsuarioTextBox.Text = tbUsuarioDataGridView.CurrentRow.Cells[0].Value.ToString();
            nomeUsuarioTextBox.Text = tbUsuarioDataGridView.CurrentRow.Cells[1].Value.ToString();
            senhaTextBox.Text = tbUsuarioDataGridView.CurrentRow.Cells[2].Value.ToString();
            nivelAcessoComboBox.Text = tbUsuarioDataGridView.CurrentRow.Cells[3].Value.ToString();
            dataCadastroTextBox.Text = tbUsuarioDataGridView.CurrentRow.Cells[4].Value.ToString();
            cadastradoPorTextBox.Text = tbUsuarioDataGridView.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
