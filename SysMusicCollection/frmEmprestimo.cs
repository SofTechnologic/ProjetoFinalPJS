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
            cboNomeAmigo.DataSource = pega.prCombo_Amigos();

            cboNomeAmigo.DisplayMember = "Nome";

            conexaoBanco mds = new conexaoBanco();
            cboNomeMidia.DataSource = mds.prCombo_Midia();
            cboNomeMidia.DisplayMember = "Nome_Album";
            
            conexaoBanco grd = new conexaoBanco();
            dgvEmprestimo.DataSource = grd.GridEmp();

        }

        private void cboNomeMidia_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void cboNomeMidia_KeyPress(object sender, KeyPressEventArgs e)
        {
            string sql;
            if (e.KeyChar == 13)
            {
                if (cboNomeMidia.SelectedText != "")
                {
                    sql = " select Nome_Album from Albuns inner join Discos on Albuns.ID_Album = Discos.ID_Album " +
                                   " inner join Itens_Emprestimo on Discos.Cod_Disco = Itens_Emprestimo.Cod_Disco " +
                                   " where Discos.Cod_Disco = @valor ";

                    conexaoBanco grd = new conexaoBanco();
                    dgvEmprestimo.DataSource = grd.GridEmpPesq(sql, cboNomeAmigo.SelectedIndex);
                }
             }

        }
    }
}
 