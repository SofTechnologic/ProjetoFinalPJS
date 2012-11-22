using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SysMusicCollection
{
    public partial class frmEmprestimo : Form
    {
        public frmEmprestimo()
        {
            InitializeComponent();
        }

        private void frmEmprestimo_Load(object sender, EventArgs e)
        {
            conexaoBanco pega = new conexaoBanco();
            cboNomeAmigo.DataSource = pega.prCombo();
            cboNomeAmigo.DisplayMember = "Nome";

        }

        private void cboNomeMidia_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
 