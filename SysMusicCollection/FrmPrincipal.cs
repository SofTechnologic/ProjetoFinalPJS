﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data;
using System.Data.SqlClient;
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
                splitContainer1.SplitterDistance = 10;
                btn = 0;
            }

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            SqlDataReader dr;
            conexaoBanco s = new conexaoBanco();
            bool espera = false;

            SqlCommand epa = s.lv(espera);

            dr = epa.ExecuteReader();

            lsvPrincipal.Columns.Add(dr.GetName(0), 60, HorizontalAlignment.Left);
            lsvPrincipal.Columns.Add(dr.GetName(1), 60, HorizontalAlignment.Left);
            lsvPrincipal.Columns.Add(dr.GetName(2), 60, HorizontalAlignment.Left);
            lsvPrincipal.Columns.Add(dr.GetName(3), 60, HorizontalAlignment.Left);
            lsvPrincipal.Columns.Add(dr.GetName(4), 60, HorizontalAlignment.Left);
            lsvPrincipal.Columns.Add(dr.GetName(5), 60, HorizontalAlignment.Left);
            lsvPrincipal.Columns.Add(dr.GetName(6), 60, HorizontalAlignment.Left);
            lsvPrincipal.Columns.Add(dr.GetName(7), 60, HorizontalAlignment.Left);
            lsvPrincipal.Columns.Add(dr.GetName(8), 60, HorizontalAlignment.Left);


            while (dr.Read())
            {
                string midia = dr[0].ToString();
                ListViewItem teste = new ListViewItem(midia, 0);
                teste.SubItems.Add(dr[1].ToString());
                teste.SubItems.Add(dr[2].ToString());
                teste.SubItems.Add(dr[3].ToString());
                teste.SubItems.Add(dr[4].ToString());
                teste.SubItems.Add(dr[5].ToString());
                teste.SubItems.Add(dr[6].ToString());
                teste.SubItems.Add(dr[7].ToString());
                teste.SubItems.Add(dr[8].ToString());
                teste.Group = lsvPrincipal.Groups[dr[0].ToString()];

                lsvPrincipal.Items.Add(teste);
            }
            espera = true;
            dr.Close();

            s.lv(espera);
            
        }

        private void devolverToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
        }
        
    }
}
