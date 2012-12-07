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
    public partial class frmEditarDiscos : Form
    {
        public frmEditarDiscos()
        {
            InitializeComponent();
        }
        frmPrincipal frmprincipal;
        public frmEditarDiscos(frmPrincipal formPric)
        {
            InitializeComponent();
            frmprincipal = formPric;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmEditarDiscos_Load(object sender, EventArgs e)
        {
            conexaoBanco inter = new conexaoBanco();
            cboEditaInterprete .DataSource = inter.prCombo_Interprete();
            cboEditaInterprete .DisplayMember = "Nome_Interprete";

            conexaoBanco autor = new conexaoBanco();
            cboEditaAutor.DataSource = autor.prCombo_Autor();
            cboEditaAutor.DisplayMember = "Nome_Autor";

            conexaoBanco album = new conexaoBanco();
            cboEditaAlbumeAutor.DataSource = album.prcombo_Album();
            cboEditaAlbumeAutor.DisplayMember = "Nome_Album";

            conexaoBanco midia = new conexaoBanco();
            cboEditaTipoMidia.DataSource = midia.prCombo_Midia();
            cboEditaTipoMidia .DisplayMember = "Tipo_Midia";

        }
    }
}
