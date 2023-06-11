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
    public partial class frmOP : Form
    {
        SqlConnection cn = new SqlConnection(Properties.Settings.Default.CadastroUsuarioConnectionString);
        SqlCommand cmd = null;

        public frmOP()
        {
            InitializeComponent();
        }

        private void tbOrdemProdutoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (frmLogin.nivelAcesso == "Usuario")
                {
                    bindingNavigatorDeleteItem.Enabled = false;
                }
                if ((idOSTextBox.Text != "") && (idServicoTextBox.Text != ""))
                {
                        this.Validate();
                        this.tbOrdemProdutoBindingSource.EndEdit();
                        this.tbOrdemProdutoTableAdapter.Update(this.cadastroUsuarioDataSet.tbOrdemProduto);
                        MessageBox.Show("Cadastro realizado com sucesso");
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
            //this.tbOrdemProdutoBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.cadastroUsuarioDataSet);

        }

        private void frmOP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cadastroUsuarioDataSet.tbOrdemProduto' table. You can move, or remove it, as needed.
            this.tbOrdemProdutoTableAdapter.Fill(this.cadastroUsuarioDataSet.tbOrdemProduto);

        }
    }
}
