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
    public partial class frmrelatCliente : Form
    {
        public frmrelatCliente()
        {
            InitializeComponent();
        }

        private void frmrelatCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'CadastroUsuarioDataSet.tbCliente' table. You can move, or remove it, as needed.
            this.tbClienteTableAdapter.Fill(this.CadastroUsuarioDataSet.tbCliente);

            this.reportViewer1.RefreshReport();
        }
    }
}
