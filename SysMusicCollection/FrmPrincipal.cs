﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        
            string codDicos;
            string autor;
            string inter;
            string nomeAlbum;
            string dataAlbum;
            string dataCompra;
            string origem;
            string obs;
            string nota;
            string midia;
            

        public int btnAbaSup = 0, btnAbaLat = 0;

        private void btnCadastro_Click(object sender, EventArgs e)
        {
             frmCadastro frmCadAmigo = new frmCadastro(this);
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
            if (btnAbaSup == 0)
            {
                spcHorizontal.SplitterDistance = 50;
                btnAbaSup = 1;
            }
            else
            {
                spcHorizontal.SplitterDistance = 0;
                btnAbaSup = 0;
            }

        }
        
        public void preenchelist()
        {
            SqlDataReader dr;
            conexaoBanco s = new conexaoBanco();
            bool espera = false;
            bool visibol = Visible = true;
            SqlCommand epa = s.lv(espera);

            dr = epa.ExecuteReader();

            lsvPrincipal.Clear();
            lsvPrincipal.View = View.Details;
            lsvPrincipal.FullRowSelect = true;
            lsvPrincipal.GridLines = true;
            //lsvPrincipal.Columns.Add(dr.GetName(0), 60, HorizontalAlignment.Left);
            lsvPrincipal.Columns.Add(dr.GetName(0), 0, HorizontalAlignment.Center);
            lsvPrincipal.Columns.Add(dr.GetName(2), 120, HorizontalAlignment.Center);
            lsvPrincipal.Columns.Add(dr.GetName(3), 120, HorizontalAlignment.Center);
            lsvPrincipal.Columns.Add(dr.GetName(4), 120, HorizontalAlignment.Center);
            lsvPrincipal.Columns.Add(dr.GetName(5), 120, HorizontalAlignment.Center);
            lsvPrincipal.Columns.Add(dr.GetName(6), 120, HorizontalAlignment.Center);
            lsvPrincipal.Columns.Add(dr.GetName(7), 120, HorizontalAlignment.Center);
            lsvPrincipal.Columns.Add(dr.GetName(8), 120, HorizontalAlignment.Center);
            lsvPrincipal.Columns.Add(dr.GetName(9), 120, HorizontalAlignment.Center);

            while (dr.Read())
            {
                string nome = dr[0].ToString();
                ListViewItem teste = new ListViewItem(nome, 0);
                teste.SubItems.Add(dr[2].ToString());
                teste.SubItems.Add(dr[3].ToString());
                teste.SubItems.Add(dr[4].ToString());
                teste.SubItems.Add(dr[5].ToString());
                teste.SubItems.Add(dr[6].ToString());
                teste.SubItems.Add(dr[7].ToString());
                teste.SubItems.Add(dr[8].ToString());
                teste.SubItems.Add(dr[9].ToString());
                teste.Group = lsvPrincipal.Groups[dr[1].ToString()];

                lsvPrincipal.Items.Add(teste);
            }


            espera = true;
            dr.Close();

            s.lv(espera);
        }
        
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            preenchelist();
           
            
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codDicos = lsvPrincipal.SelectedItems[0].Text;
            autor = lsvPrincipal.SelectedItems[0].SubItems[1].Text;
            inter = lsvPrincipal.SelectedItems[0].SubItems[2].Text;
            nomeAlbum = lsvPrincipal.SelectedItems[0].SubItems[3].Text;
            dataAlbum = lsvPrincipal.SelectedItems[0].SubItems[4].Text;
            dataCompra = lsvPrincipal.SelectedItems[0].SubItems[5].Text;
            origem = lsvPrincipal.SelectedItems[0].SubItems[6].Text;
            obs = lsvPrincipal.SelectedItems[0].SubItems[7].Text;
            nota = lsvPrincipal.SelectedItems[0].SubItems[8].Text;
            midia = lsvPrincipal.SelectedItems[0].Group.ToString();
            ArrayList passaVariaveis = new ArrayList();
            passaVariaveis.Add(codDicos);
            passaVariaveis.Add(autor);
            passaVariaveis.Add(inter);
            passaVariaveis.Add(nomeAlbum);
            passaVariaveis.Add(dataAlbum);
            passaVariaveis.Add(dataCompra);
            passaVariaveis.Add(origem);
            passaVariaveis.Add(obs);
            passaVariaveis.Add(nota);
            passaVariaveis.Add(midia);
            frmEditarDiscos frmEditar = new frmEditarDiscos(passaVariaveis);
            frmEditar.ShowDialog();
            List<string> passalist = new List<string>();
            for (int i =0; i<frmEditar.passaPrinc.Count; i++ )
            {
                passalist.Add(frmEditar.passaPrinc[i].ToString());
            }
            if (frmEditar.passaPrinc.Count != 0)
            {
                for (int i = lsvPrincipal.SelectedItems.Count - 1; i >= 0; i--)
                {
                    ListViewItem altera = lsvPrincipal.SelectedItems[i];
                    altera.Group = lsvPrincipal.Groups[passalist[5].ToString()];
                    altera.Text = passalist[0].ToString();
                    altera.SubItems[1].Text = passalist[2].ToString();
                    altera.SubItems[2].Text = passalist[1].ToString();
                    altera.SubItems[3].Text = passalist[3].ToString();
                    altera.SubItems[4].Text = passalist[8].ToString();
                    altera.SubItems[5].Text = passalist[9].ToString();
                    altera.SubItems[6].Text = passalist[4].ToString();
                    altera.SubItems[7].Text = passalist[7].ToString();
                    altera.SubItems[8].Text = passalist[6].ToString();
                }
            }
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> apagar = new List<string>();
            for (int i = lsvPrincipal.SelectedItems.Count - 1; i >= 0; i--)
            {
                ListViewItem remove = lsvPrincipal.SelectedItems[i];
                apagar.Add(remove.Text);
            }
            conexaoBanco apaga = new conexaoBanco();
            apaga.removeItemBanco(apagar);
            for (int i = lsvPrincipal.SelectedItems.Count - 1; i >= 0; i--)
            {
                ListViewItem remove = lsvPrincipal.SelectedItems[i];
                remove.Remove();
            }
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorios frm = new frmRelatorios();
            frm.ShowDialog();
        }


        private void btnAbaLateral_Click(object sender, EventArgs e)
        {
            if (btnAbaLat == 0)
            {
                spcPrincipal.SplitterDistance = 170;
                btnAbaLat = 1;
            }
            else
            {
                spcPrincipal.SplitterDistance = 0;
                btnAbaLat = 0;
            }
        }

        private void lsvPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                List<string> apagar = new List<string>();
                for (int i = lsvPrincipal.SelectedItems.Count - 1; i >= 0; i--)
                {
                    ListViewItem remove = lsvPrincipal.SelectedItems[i];
                    apagar.Add(remove.Text);
                }
                conexaoBanco apaga = new conexaoBanco();
                apaga.removeItemBanco(apagar);
                for (int i = lsvPrincipal.SelectedItems.Count - 1; i >= 0; i--)
                {
                    ListViewItem remove = lsvPrincipal.SelectedItems[i];
                    remove.Remove();
                }
            }
        }

        private void excluirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            List<string> apagar = new List<string>();
            for (int i = lsvPrincipal.SelectedItems.Count - 1; i >= 0; i--)
            {
                ListViewItem remove = lsvPrincipal.SelectedItems[i];
                apagar.Add(remove.Text);
            }
            conexaoBanco apaga = new conexaoBanco();
             List<string> armazena = apaga.AchaItemEmprestimo(apagar);
            int emprestado=0;
             if (armazena.Count != 0)
             {
                 apaga.removeItemBanco(armazena);
                 for (int i = lsvPrincipal.SelectedItems.Count - 1; i >= 0; i--)
                 {
                     for (int j = 0; j < armazena.Count; j++)
                     {

                         if (armazena[j].ToString() == lsvPrincipal.SelectedItems[i].Text)
                         {
                             ListViewItem remove = lsvPrincipal.SelectedItems[i];
                             remove.Remove();
                             break;
                         }
                         else
                             emprestado++;
                     }
                 }
                 if (emprestado >= 1)
                 {
                     MessageBox.Show(" Campo(s) nao podem ser excluidos pois estao emprestados", "Aviso");
                 }
             }
             else
             {
                 MessageBox.Show("Esta musica nao pode ser excluida", "aviso");
             }
        }

        private void ediarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codDicos = lsvPrincipal.SelectedItems[0].Text;
            autor = lsvPrincipal.SelectedItems[0].SubItems[1].Text;
            inter = lsvPrincipal.SelectedItems[0].SubItems[2].Text;
            nomeAlbum = lsvPrincipal.SelectedItems[0].SubItems[3].Text;
            dataAlbum = lsvPrincipal.SelectedItems[0].SubItems[4].Text;
            dataCompra = lsvPrincipal.SelectedItems[0].SubItems[5].Text;
            origem = lsvPrincipal.SelectedItems[0].SubItems[6].Text;
            obs = lsvPrincipal.SelectedItems[0].SubItems[7].Text;
            nota = lsvPrincipal.SelectedItems[0].SubItems[8].Text;
            midia = lsvPrincipal.SelectedItems[0].Group.ToString();
            ArrayList passaVariaveis = new ArrayList();
            passaVariaveis.Add(codDicos);
            passaVariaveis.Add(autor);
            passaVariaveis.Add(inter);
            passaVariaveis.Add(nomeAlbum);
            passaVariaveis.Add(dataAlbum);
            passaVariaveis.Add(dataCompra);
            passaVariaveis.Add(origem);
            passaVariaveis.Add(obs);
            passaVariaveis.Add(nota);
            passaVariaveis.Add(midia);
            frmEditarDiscos frmEditar = new frmEditarDiscos(passaVariaveis);
            frmEditar.ShowDialog();
            List<string> passalist = new List<string>();
            for (int i = 0; i < frmEditar.passaPrinc.Count; i++)
            {
                passalist.Add(frmEditar.passaPrinc[i].ToString());
            }
            if (frmEditar.passaPrinc.Count != 0)
            {
                for (int i = lsvPrincipal.SelectedItems.Count - 1; i >= 0; i--)
                {
                    ListViewItem altera = lsvPrincipal.SelectedItems[i];
                    altera.Group = lsvPrincipal.Groups[passalist[5].ToString()];
                    altera.Text = passalist[0].ToString();
                    altera.SubItems[1].Text = passalist[2].ToString();
                    altera.SubItems[2].Text = passalist[1].ToString();
                    altera.SubItems[3].Text = passalist[3].ToString();
                    altera.SubItems[4].Text = passalist[8].ToString();
                    altera.SubItems[5].Text = passalist[9].ToString();
                    altera.SubItems[6].Text = passalist[4].ToString();
                    altera.SubItems[7].Text = passalist[7].ToString();
                    altera.SubItems[8].Text = passalist[6].ToString();
                }
            }
        }

        private void lsvPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
