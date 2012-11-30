using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SysMusicCollection
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        public int btn = 0;

        private void btnCadastro_Click(object sender, EventArgs e)
        {
             frmCadastro frmCadAmigo = new frmCadastro();
             frmCadAmigo.Show();
        }

        private void btnEmprDev_Click(object sender, EventArgs e)
        {
            frmEmprestimo frmEmprestimo = new frmEmprestimo();
            frmEmprestimo.Show();
        }

        private void txbPesquisa_MouseClick(object sender, MouseEventArgs e)
        {
            txbPesquisa.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btn == 0)
            {
                splitContainer1.SplitterDistance = 50;
                btn = 1;
            }
            else
            {
                splitContainer1.SplitterDistance = 25;
                btn = 0;
            }

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
        }
    }
}
