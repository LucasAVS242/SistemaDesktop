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
    public partial class frmrelatServico : Form
    {
        public frmrelatServico()
        {
            InitializeComponent();
        }

        private void frmrelatServico_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'CadastroUsuarioDataSet.tbServico' table. You can move, or remove it, as needed.
            this.tbServicoTableAdapter.Fill(this.CadastroUsuarioDataSet.tbServico);

            this.reportViewer1.RefreshReport();
        }
    }
}
