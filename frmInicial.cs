using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemploFrmWindows
{
    public partial class frmInicial : Form
    {
        public frmInicial()
        {
            InitializeComponent();
        }

        private void tpClientes_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tcClientes.Visible = false;
            painelCliente.Visible = true;
            painelCliente.BringToFront();
        }

        private void miClientes_Click(object sender, EventArgs e)
        {
            tcClientes.Visible = true;
        }
    }
}
