using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
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
            conexaoBanco amg = new conexaoBanco();
            cboNomeAmigo.DataSource = amg.prCombo_Amigos();
            cboNomeAmigo.DisplayMember = "Nome";

            conexaoBanco mds = new conexaoBanco();
            cboNomeMidia.DataSource = mds.prCombo_Midias();
            cboNomeMidia.DisplayMember = "Nome_Album";

        }

        private void cboNomeMidia_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
 