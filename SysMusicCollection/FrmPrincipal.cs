using System;
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
            List<string> listaEmprestados = new List<string>();
            conexaoBanco apaga = new conexaoBanco();
        public int btnAbaSup = 0, btnAbaLat = 0;
        public void passalistview(List<string> valores)
        {
            ListViewItem item = new ListViewItem();
            item.Text = valores[0].ToString();
            item.SubItems.Add(valores[2].ToString());
            item.SubItems.Add(valores[3].ToString());
            item.SubItems.Add(valores[4].ToString());
            item.SubItems.Add(valores[5].ToString());
            item.SubItems.Add(valores[6].ToString());
            item.SubItems.Add(valores[7].ToString());
            item.SubItems.Add(valores[8].ToString());
            item.SubItems.Add(valores[9].ToString());
            item.Group = lsvPrincipal.Groups[valores[1].ToString()];
            lsvPrincipal.Items.Add(item);
        }

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
                spcHorizontal.SplitterDistance = 160;
                habilitaComponentesFiltro();
                btnAbaSup = 1;
            }
            else
            {
                spcHorizontal.SplitterDistance = 0;
                btnAbaSup = 0;
                desabilitaComponentesFiltro();
            }

        }

        public void habilitaComponentesFiltro()
        {
            ckbInterprete.Visible = true;
            ckbAutor.Visible = true;
            ckbDataAlbMus.Visible = true;
            ckbDataCompra.Visible = true;
            ckbOrigemCompra.Visible = true;
            ckbTipoMidia.Visible = true;
            cbxTipoMidia1.Visible = true;
            txbAutor1.Visible = true;
            txbIterprete1.Visible = true;
            txbOrigem1.Visible = true;
            txbPesquisa.Visible = true;
            dtpDataAlbum1.Visible = true;
            dtpDataAlbum2.Visible = true;
            dtpDataCompra1.Visible = true;
            dtpDataCompra2.Visible = true;
            btnFiltrar.Visible = true;
        }

        public void desabilitaComponentesFiltro()
        {
            ckbInterprete.Visible = false;
            ckbAutor.Visible = false;
            ckbDataAlbMus.Visible = false;
            ckbDataCompra.Visible = false;
            ckbOrigemCompra.Visible = false;
            ckbTipoMidia.Visible = false;
            cbxTipoMidia1.Visible = false;
            txbAutor1.Visible = false;
            txbIterprete1.Visible = false;
            txbOrigem1.Visible = false;
            txbPesquisa.Visible = false;
            dtpDataAlbum1.Visible = false;
            dtpDataAlbum2.Visible = false;
            dtpDataCompra1.Visible = false;
            dtpDataCompra2.Visible = false;
            btnFiltrar.Visible = false;
        }

        public void habilitaComponentesFunc()
        {
            btnCadastro.Visible = true;
            btnEmprDev.Visible = true;
        }

        public void desabilitaComponentesFunc()
        {
            btnCadastro.Visible = false;
            btnEmprDev.Visible = false;
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
            //lsvPrincipal.Columns.Add(dr.GetName(10), 0, HorizontalAlignment.Center);

            while (dr.Read())
            {
                string nome = dr[0].ToString();
                ListViewItem teste = new ListViewItem(nome, 0);
                if (dr[2].ToString() != "Nada Consta")
                    teste.SubItems.Add(dr[2].ToString());
                else
                    teste.SubItems.Add("");

                teste.SubItems.Add(dr[3].ToString());
                teste.SubItems.Add(dr[4].ToString());
                teste.SubItems.Add(dr[5].ToString());
                teste.SubItems.Add(dr[6].ToString());
                teste.SubItems.Add(dr[7].ToString());
                teste.SubItems.Add(dr[8].ToString());
                teste.SubItems.Add(dr[9].ToString());
                //teste.SubItems.Add(dr[10].ToString());
                teste.Group = lsvPrincipal.Groups[dr[1].ToString()];

                //if (lsvPrincipal.Columns[10].ToString() == Convert.ToString(1))
                //{
                //    lsvPrincipal.Items[0].ForeColor = Color.Red;
                //}

                lsvPrincipal.Items.Add(teste);
                
            }


            espera = true;
            dr.Close();

            s.lv(espera);
            
        }
        
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            conexaoBanco pega = new conexaoBanco();
            preenchelist();
            List<string> armazenaEmprestado = new List<string>();
            foreach (ListViewItem itens in lsvPrincipal.Items)
            {
                armazenaEmprestado.Add(itens.Text);
                
            }
            if (armazenaEmprestado.ToString() != null)
            {
                List<string> pegaEmprestado = pega.pesqtemEmprestimo(armazenaEmprestado);
                foreach (ListViewItem itens in lsvPrincipal.Items)
                {
                    for (int j = 0; j < pegaEmprestado.Count; j++)
                    {
                        if (pegaEmprestado.ToString() == itens.Text)
                        {
                            itens.BackColor = Color.Red;
                            break;
                        }
                    }

                }
            }


            cbxTipoMidia1.DataSource = pega.prCombo_Midia();
            cbxTipoMidia1.Enabled = false;
            txbAutor1.Enabled = false;
            txbIterprete1.Enabled = false;
            txbOrigem1.Enabled = false;
            dtpDataAlbum1.Enabled = false;
            dtpDataAlbum2.Enabled = false;
            dtpDataCompra1.Enabled = false;
            dtpDataCompra2.Enabled = false;

            
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
            //conexaoBanco apaga = new conexaoBanco();
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
                habilitaComponentesFunc();
                btnAbaLat = 1;
            }
            else
            {
                spcPrincipal.SplitterDistance = 0;
                desabilitaComponentesFunc();
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
                List<string> armazena = apaga.AchaItemEmprestimo(apagar);
                List<string> armazenaEmprestado = apaga.AchaItemEmprestimo1(apagar);
                bool avisa = false;
                string nome = null;
                List<string> pegaNome = new List<string>();
                if (armazenaEmprestado.Count != 0)
                {
                    for (int j = 0; j < armazenaEmprestado.Count; j++)
                    {
                        for (int i = lsvPrincipal.SelectedItems.Count - 1; i >= 0; i--)
                        {

                            if (armazenaEmprestado[j].ToString() == lsvPrincipal.SelectedItems[i].Text)
                            {
                                avisa = true;
                                pegaNome.Add(lsvPrincipal.SelectedItems[i].SubItems[3].Text);
                            }
                        }
                    }
                    if (avisa == true)
                    {
                        //nome = pegaNome.ToString();
                        if (MessageBox.Show(pegaNome.ToString() + " Iten(s) Emprestados, Deseja Excluir", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                   == DialogResult.Yes)
                        {
                            for (int j = 0; j < armazenaEmprestado.Count; j++)
                            {
                                for (int i = lsvPrincipal.SelectedItems.Count - 1; i >= 0; i--)
                                {

                                    if (armazenaEmprestado[j].ToString() == lsvPrincipal.SelectedItems[i].Text)
                                    {
                                        apaga.excluiItensEmprestimo(armazenaEmprestado);
                                        apaga.removeItemBanco(armazenaEmprestado);
                                        ListViewItem remove = lsvPrincipal.SelectedItems[i];
                                        remove.Remove();
                                    }
                                }
                            }
                        }
                    }
                }
                if (armazena.Count != 0)
                {
                    apaga.removeItemBanco(armazena);
                    for (int j = 0; j < armazena.Count; j++)
                    {
                        for (int i = lsvPrincipal.SelectedItems.Count - 1; i >= 0; i--)
                        {

                            if (armazena[j].ToString() == lsvPrincipal.SelectedItems[i].Text)
                            {
                                ListViewItem remove = lsvPrincipal.SelectedItems[i];
                                remove.Remove();
                            }
                        }
                    }
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
             List<string> armazenaEmprestado = apaga.AchaItemEmprestimo1(apagar);
             bool avisa = false;
             string nome = null;
             List<string> pegaNome = new List<string>(); 
            if (armazenaEmprestado.Count != 0)
            {
                for (int j = 0; j < armazenaEmprestado.Count; j++)
                {
                    for (int i = lsvPrincipal.SelectedItems.Count - 1; i >= 0; i--)
                    {

                        if (armazenaEmprestado[j].ToString() == lsvPrincipal.SelectedItems[i].Text)
                        {
                                avisa = true;
                                pegaNome.Add( lsvPrincipal.SelectedItems[i].SubItems[3].Text);
                        }
                    }
                }
                if (avisa == true)
                {
                    //nome = pegaNome.ToString();
                    if (MessageBox.Show( pegaNome.ToString()+" Iten(s) Emprestados, Deseja Excluir", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
               == DialogResult.Yes)
                    {
                        for (int j = 0; j < armazenaEmprestado.Count; j++)
                        {
                            for (int i = lsvPrincipal.SelectedItems.Count - 1; i >= 0; i--)
                            {

                                if (armazenaEmprestado[j].ToString() == lsvPrincipal.SelectedItems[i].Text)
                                {
                                        apaga.excluiItensEmprestimo(armazenaEmprestado);
                                        apaga.removeItemBanco(armazenaEmprestado);
                                        ListViewItem remove = lsvPrincipal.SelectedItems[i];
                                        remove.Remove();                                  
                                }
                            }
                        }
                    }
                }
            }
             if (armazena.Count != 0)
             {
                 apaga.removeItemBanco(armazena);
                     for (int j = 0; j < armazena.Count; j++)
                     {
                          for (int i = lsvPrincipal.SelectedItems.Count - 1; i >= 0; i--)
                        {

                            if (armazena[j].ToString() == lsvPrincipal.SelectedItems[i].Text)
                            {
                                ListViewItem remove = lsvPrincipal.SelectedItems[i];
                                remove.Remove();
                            }
                        }
                     }
             }
        }

        private void ediarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int itens=0;
            List<string> apagar = new List<string>();
            for (int i = lsvPrincipal.SelectedItems.Count - 1; i >= 0; i--)
            {
                ListViewItem adiciona = lsvPrincipal.SelectedItems[i];
                apagar.Add(adiciona.Text);
                itens++;
            }
            if (itens == 1)
            {
                listaEmprestados = apaga.AchaItemEmprestimo(apagar);
                if (listaEmprestados.Count != 0)
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
                else
                    MessageBox.Show("Este item esta emprestado", "Aviso");
                
            }
        }

        private void lsvPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            int inter=0;
            for (int i = lsvPrincipal.SelectedItems.Count - 1; i >= 0; i--)
            {
                inter++;
            }
            if (inter >= 2)
            {
               cmiEditar.Enabled = false;
            }
            else
                cmiEditar.Enabled = true;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            SqlDataReader drf;
            conexaoBanco f = new conexaoBanco();
            bool espera = false;

            SqlCommand fi = f.filtro(espera, cbxTipoMidia1.Text, txbIterprete1.Text, txbAutor1.Text, txbOrigem1.Text, dtpDataAlbum1.Value.ToShortDateString(), dtpDataCompra1.Value.ToShortDateString());

            //fi.ExecuteNonQuery();

            drf = fi.ExecuteReader();


            //List<string> pesq = new List<string>();

            lsvPrincipal.Clear();
            lsvPrincipal.View = View.Details;
            lsvPrincipal.FullRowSelect = true;
            lsvPrincipal.GridLines = true;
            lsvPrincipal.Columns.Add(drf.GetName(0), 0, HorizontalAlignment.Left);
            lsvPrincipal.Columns.Add(drf.GetName(0), 0, HorizontalAlignment.Center);
            lsvPrincipal.Columns.Add(drf.GetName(2), 120, HorizontalAlignment.Center);
            lsvPrincipal.Columns.Add(drf.GetName(3), 120, HorizontalAlignment.Center);
            lsvPrincipal.Columns.Add(drf.GetName(4), 120, HorizontalAlignment.Center);
            lsvPrincipal.Columns.Add(drf.GetName(5), 120, HorizontalAlignment.Center);
            lsvPrincipal.Columns.Add(drf.GetName(6), 120, HorizontalAlignment.Center);
            lsvPrincipal.Columns.Add(drf.GetName(7), 120, HorizontalAlignment.Center);
            lsvPrincipal.Columns.Add(drf.GetName(8), 120, HorizontalAlignment.Center);
            lsvPrincipal.Columns.Add(drf.GetName(9), 120, HorizontalAlignment.Center);
            //lsvPrincipal.Columns.Add(dr.GetName(10), 0, HorizontalAlignment.Center);

            while (drf.Read())
            {

                ListViewItem teste = new ListViewItem();
                teste.SubItems.Add(drf[0].ToString());
                if (drf[2].ToString() != "Nada Consta")
                {
                    teste.SubItems.Add(drf[2].ToString());
                }
                else
                {
                    teste.SubItems.Add("");

                }

                teste.SubItems.Add(drf[3].ToString());
                teste.SubItems.Add(drf[4].ToString());
                teste.SubItems.Add(drf[5].ToString());
                teste.SubItems.Add(drf[6].ToString());
                teste.SubItems.Add(drf[7].ToString());
                teste.SubItems.Add(drf[8].ToString());
                teste.SubItems.Add(drf[9].ToString());
                teste.Group = lsvPrincipal.Groups[drf[1].ToString()];

                //if (lsvPrincipal.Columns[10].ToString() == Convert.ToString(1))
                //{
                //    lsvPrincipal.Items[0].ForeColor = Color.Red;
                //}

                lsvPrincipal.Items.Add(teste);

                //teste.SubItems.Add(drf[2].ToString());
            }


            espera = true;
            drf.Close();

            f.filtro(espera, null, null, null, null, null, null);
            
        }

        private void frmPrincipal_Resize(object sender, EventArgs e)
        {
            if (btnAbaLat == 1)
                spcPrincipal.SplitterDistance = 160;
            else
                spcPrincipal.SplitterDistance = 0;

            if (btnAbaSup == 1)
                spcHorizontal.SplitterDistance = 160;
            else
                spcHorizontal.SplitterDistance = 0;
        }

        private void ckbTipoMidia_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbTipoMidia.Checked)
            {
                cbxTipoMidia1.Enabled = true;

            }

            else
            {
                cbxTipoMidia1.Enabled = false;
                cbxTipoMidia1.Text = "";
            }
        }

        private void ckbAutor_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAutor.Checked)
            {
                txbAutor1.Enabled = true;

            }

            else
            {
                txbAutor1.Enabled = false;
                txbAutor1.Text = "";
            }
        }

        private void ckbOrigemCompra_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbOrigemCompra.Checked)
            {
                txbOrigem1.Enabled = true;

            }

            else
            {
                txbOrigem1.Enabled = false;
                txbOrigem1.Text = "";
            }

        }

        private void ckbDataAlbMus_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbDataAlbMus.Checked)
            {
                dtpDataAlbum1.Enabled = true;
                dtpDataAlbum1.Text = "";
                dtpDataAlbum2.Enabled = true;
                dtpDataAlbum2.Text = "";

            }

            else
            {
                dtpDataAlbum1.Enabled = false;
                dtpDataAlbum2.Enabled = false;

            }
        }

        private void ckbDataCompra_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbDataCompra.Checked)
            {
                dtpDataCompra1.Enabled = true;
                dtpDataCompra2.Enabled = true;

            }

            else
            {
                dtpDataCompra1.Enabled = false;
                dtpDataCompra2.Enabled = false;

            }

        }

        private void ckbInterprete_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbInterprete.Checked)
            {
                txbIterprete1.Enabled = true;

            }

            else
            {
                txbIterprete1.Enabled = false;
                txbIterprete1.Text = "";
            }

        }

        
    }
}
