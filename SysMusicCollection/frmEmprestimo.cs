using System;
using System.Collections.Generic;
using System.Collections;
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
        private int codamigo;
        private int coddisc;
        private int codemp;
        
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
            cboNomeMidia.DataSource = mds.prCombo_Discos();
            cboNomeMidia.DisplayMember = "Nome_Album";
            
            //conexaoBanco grd = new conexaoBanco();
            //dgvEmprestimo.DataSource = grd.GridEmp();

        }

        private void cboNomeMidia_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        
        private void cboNomeMidia_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == 13)
            {
                if (cboNomeMidia.SelectedText != "")
                {
                    conexaoBanco disc = new conexaoBanco();
                    ArrayList arr = new ArrayList();
                    coddisc = disc.PesqCoddiscos(cboNomeMidia.Text);

                    string sq = " select Nome_Album from Albuns inner join Discos on Albuns.ID_Album = Discos.ID_Album " +
                                   " inner join Itens_Emprestimo on Discos.Cod_Disco = Itens_Emprestimo.Cod_Disco " +
                               " where Discos.Cod_Disco = @valor ";
                    
                    //lblNome.Text = coddisc.ToString();                    
                    
                    //conexaoBanco grd = new conexaoBanco();
                    //dgvEmprestimo.DataSource = grd.GridEmpPesq(sq, coddisc);

                    dgvEmprestimo.Rows.Add(cboNomeMidia.Text);
                                                        
                }
             }

        }


        private void btnEmprestar_Click(object sender, EventArgs e)
        {
            conexaoBanco disc = new conexaoBanco();
            ArrayList arremp = new ArrayList();
            arremp.Add(dtpDataEmprestimo.Value.ToShortDateString());
            arremp.Add(codamigo);
            disc.CadastrarEmp(arremp);

            codemp = disc.PesqCodEmp(codamigo, dtpDataEmprestimo.Value.ToShortDateString());
            
            int i;
            for (i = dgvEmprestimo.Rows.Count - 1; i >= 0;)
            {
                coddisc = disc.PesqCoddiscos(dgvEmprestimo[0, i].Value.ToString());

                disc.CadastrarItensEmp(coddisc, codemp);
                
                dgvEmprestimo.Rows.RemoveAt(i);
                i--;
            }
            
          }
        
        private void cboNomeMidia_Enter(object sender, EventArgs e)
        {
            
        }

        private void cboNomeAmigo_Leave(object sender, EventArgs e)
        {
            conexaoBanco amig = new conexaoBanco();
            codamigo = amig.PesqAmigos(cboNomeAmigo.Text);
        }
       
       private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesqMidias frmPesqMidias = new frmPesqMidias();
            frmPesqMidias.Show();
        }
    }
}
 