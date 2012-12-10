using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SysMusicCollection
{
    public partial class frmRelatorios : Form
    {
        public frmRelatorios()
        {
            InitializeComponent();
        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {

        }

        private void tbcDevolucao_Enter(object sender, EventArgs e)
        {
            conexaoBanco rel = new conexaoBanco();

            dgvDevolucao.DataSource = rel.GridEmp();
            dgvDevolucao.Columns[1].Width = 300;
           
        }

        private void frmRelatorios_Load(object sender, EventArgs e)
        {
            tbcDevolucao_Enter(e, e);
            tbcEmprestados_Enter(e, e);
        }

        private void tbcEmprestados_Enter(object sender, EventArgs e)
        {
            conexaoBanco rel = new conexaoBanco();

            dgvEmprestados.DataSource = rel.GridDev();
            dgvEmprestados.Columns[1].Width = 300;
        }
    }
}
