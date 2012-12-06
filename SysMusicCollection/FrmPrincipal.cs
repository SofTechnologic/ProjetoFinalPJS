using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        public void preenchelist()
        {
            SqlDataReader dr;
            conexaoBanco s = new conexaoBanco();
            bool espera = false;

            SqlCommand epa = s.lv(espera);

            dr = epa.ExecuteReader();

            lsvPrincipal.Clear();
            lsvPrincipal.View = View.Details;
            lsvPrincipal.FullRowSelect = true;
            lsvPrincipal.GridLines = true;
            //lsvPrincipal.Columns.Add(dr.GetName(0), 60, HorizontalAlignment.Left);
            lsvPrincipal.Columns.Add(dr.GetName(0), 120, HorizontalAlignment.Center);
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

    }
}
