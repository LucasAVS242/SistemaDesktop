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
                            dataCadastroTextBox.Text = DateTime.Now.ToString();

                        }

                        if (cadastradoPorTextBox.Text == "")
                        {
                            cadastradoPorTextBox.Text = frmLogin.usuarioConectado;


                        }
                        this.Validate();
                        this.tbUsuarioBindingSource.EndEdit();
                        this.tableAdapterManager.UpdateAll(this.cadastroUsuarioDataSet);

                    }
                    else
                    {
                        MessageBox.Show("As senhas precisam ser iguais");
                    }

                }
                else
                {
                    MessageBox.Show("Todos os campos não podem ficar " + "vazio");

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
            thois.suarioTableAdapter.Fill(this.cadastroUsuarioDataSet.tbUsuario);

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
    }
}
