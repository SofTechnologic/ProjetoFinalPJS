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
        private string amgdevolve;
        conexaoBanco mds = new conexaoBanco();
        conexaoBanco pega = new conexaoBanco();

        public frmEmprestimo()
        {
            InitializeComponent();
        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {

        }

        private void cboNomeMidia_KeyPress(object sender, KeyPressEventArgs e)
        {
         

           
        
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
            for (i = dgvEmprestimo.Rows.Count - 1; i >= 0; )
            {
                coddisc = disc.PesqCoddiscos(dgvEmprestimo[0, i].Value.ToString());

                disc.CadastrarItensEmp(coddisc, codemp);

                dgvEmprestimo.Rows.RemoveAt(i);
                i--;
            }
            frmEmprestimo_Load(e, e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cboNomeAmigo_Leave(object sender, EventArgs e)
        {
            if (cboNomeAmigo.SelectedText != " ")
            {
                conexaoBanco amig = new conexaoBanco();
                codamigo = amig.PesqAmigos(cboNomeAmigo.Text);
            }
        }

        private void cboDevolver_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            conexaoBanco devolve = new conexaoBanco();
            int codemp;
            string data = dateTimePicker1.Value.ToShortDateString();
            string pegadt;
            int i;

            if (ckbAmigos.Checked)
            {

                for (i = dgvDevolucao.Rows.Count - 1; i >= 0; )
                {
                    if (bool.Parse(dgvDevolucao[0, i].EditedFormattedValue.ToString()))
                    {
                        codamigo = devolve.PesqAmigos(cboDevolver.Text);
                        pegadt = devolve.PesqDataEmp(codamigo);
                        codemp = devolve.PesqCodItemEmp(dgvDevolucao[1, i].Value.ToString(), codamigo, pegadt);
                        coddisc = devolve.PesqCoddiscos(dgvDevolucao[1, i].Value.ToString());

                        devolve.CadastrarDevolucao(data, codemp, codamigo, pegadt, coddisc);
                        devolve.CadastrarMorto(cboDevolver.Text, dgvDevolucao[1, i].Value.ToString(), pegadt, data);

                        dgvDevolucao.Rows.RemoveAt(i);
                        i--;
                    }
                    else
                    {
                        i--;
                    }
                }
                frmEmprestimo_Load(e, e);
            }

            if (ckbMidias.Checked)
            {

                for (i = dgvDevolucao.Rows.Count - 1; i >= 0; )
                {
                    if (bool.Parse(dgvDevolucao[0, i].Selected.ToString()))
                    {
                        codamigo = devolve.PesqAmigos(dgvDevolucao[2, i].Value.ToString());
                        pegadt = devolve.PesqDataEmp(codamigo);
                        codemp = devolve.PesqCodItemEmp(dgvDevolucao[1, i].Value.ToString(), codamigo, pegadt);
                        coddisc = devolve.PesqCoddiscos(dgvDevolucao[1, i].Value.ToString());

                        devolve.CadastrarDevolucao(data, codemp, codamigo, pegadt, coddisc);
                        devolve.CadastrarMorto(dgvDevolucao[2, i].Value.ToString(), dgvDevolucao[1, i].Value.ToString(),pegadt, data);


                        dgvDevolucao.Rows.RemoveAt(i);
                        i--;
                    }
                    else
                    {
                        i--;
                    }
                }
            }
        }

       
        private void frmEmprestimo_Load(object sender, EventArgs e)
        {
            cboNomeAmigo.DataSource = pega.prCombo_Amigos();

            cboNomeAmigo.DisplayMember = "Nome";


            cboNomeMidia.DataSource = mds.prCombo_Discos();
            cboNomeMidia.DisplayMember = "Nome_Album";


        }

        private void ckbMidias_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMidias.Checked)
            {
                ckbAmigos.Checked = false;
                cboDevolver.DataSource = mds.prComboDevolve_Discos();
                cboDevolver.DisplayMember = "Nome_Album";
                cboDevolver.Focus();
            }
         }

        private void ckbAmigos_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAmigos.Checked)
            {
                ckbMidias.Checked = false;
                cboDevolver.DataSource = pega.prCombo_Amigos();
                cboDevolver.Focus();
            }

        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnPesquisar;
        }

        private void cboDevolver_Leave(object sender, EventArgs e)
        {
            

            
        }

        private void cboNomeMidia_Leave(object sender, EventArgs e)
        {
                                     

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            conexaoBanco pesqdevolve = new conexaoBanco();
            string passasql;

            if (ckbAmigos.Checked)
            {

                passasql = " select Nome_Album AS Discos from Albuns inner join Discos on Albuns.ID_Album = Discos.ID_Album " +
                           " inner join Itens_Emprestimo ON Itens_Emprestimo.Cod_Disco = Discos.Cod_Disco " +
                           " inner Join Emprestimos ON Emprestimos.Num_Emprestimo = Itens_Emprestimo.Num_Emprestimo " +
                           " inner join Amigos ON Amigos.Cod_Amigo = Emprestimos.Cod_Amigo" +
                           " WHERE (Amigos.Nome = @Pega and Itens_Emprestimo.Data_Devolucao IS NULL ) ";

                dgvDevolucao.DataSource = pesqdevolve.PesqAmigosgrid(passasql, cboDevolver.Text);
                dgvDevolucao.Columns[1].ReadOnly = true;
                dgvDevolucao.Columns[1].Width = 318;

            }

            if (ckbMidias.Checked)
            {

                passasql = " select Nome_Album AS Discos, Nome AS Amigos from Albuns " +
                              " inner join Discos on Albuns.ID_Album = Discos.ID_Album " +
                              " inner join Itens_Emprestimo ON Itens_Emprestimo.Cod_Disco = Discos.Cod_Disco " +
                              " inner Join Emprestimos ON Emprestimos.Num_Emprestimo = Itens_Emprestimo.Num_Emprestimo " +
                              " inner join Amigos ON Amigos.Cod_Amigo = Emprestimos.Cod_Amigo " +
                              " WHERE (Albuns.Nome_Album = @Pega and Itens_Emprestimo.Data_devolucao IS NULL ) ";

                dgvDevolucao.DataSource = pesqdevolve.PesqAmigosgrid(passasql, cboDevolver.Text);
                dgvDevolucao.Columns[1].ReadOnly = true;
                dgvDevolucao.Columns[1].Width = 159;
                dgvDevolucao.Columns[2].ReadOnly = true;
                dgvDevolucao.Columns[2].Width = 159;
            }
        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            if (cboNomeMidia.SelectedText != "")
            {
                conexaoBanco disc = new conexaoBanco();
                ArrayList arr = new ArrayList();
                coddisc = disc.PesqCoddiscos(cboNomeMidia.Text);

                string sq = " select Nome_Album from Albuns inner join Discos on Albuns.ID_Album = Discos.ID_Album " +
                               " inner join Itens_Emprestimo on Discos.Cod_Disco = Itens_Emprestimo.Cod_Disco inner join on " +                             " where (Discos.Cod_Disco = @valor) ";

                dgvEmprestimo.Rows.Add(cboNomeMidia.Text);

            }
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btn_OK;
        }

        private void btnCancelar2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


    }
}
