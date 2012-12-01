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
    public partial class frmCadastro : Form
    {

        public frmCadastro()
        {
            InitializeComponent();

        }

        public void passaValoresParaCombobox()
        {
            //cboMidia.Items.Add("Selecione un item");

            conexaoBanco inter = new conexaoBanco();
            cboInterprete.DataSource = inter.prCombo_Interprete();
            cboInterprete.DisplayMember = "Nome_Interprete";

            conexaoBanco autor = new conexaoBanco();
            cboAutor.DataSource = autor.prCombo_Autor();
            cboAutor.DisplayMember = "Nome_Autor";

            conexaoBanco album = new conexaoBanco();
            cboAlbum.DataSource = album.prcombo_Album();
            cboAlbum.DisplayMember = "Nome_Album";

            conexaoBanco midia = new conexaoBanco();
            cboMidia.DataSource = midia.prCombo_Midia();
            cboMidia.DisplayMember = "Tipo_Midia";



            cboMidia.Text = "N/C";
        }

        public void passaArrayListParaPreencherBanco()
        {
            conexaoBanco passa = new conexaoBanco();
            

                if (tbcCadastro.TabPages[1].CanFocus)
                {

                    conexaoBanco fazz = new conexaoBanco();
                    ArrayList arramig = new ArrayList();

                    arramig.Add(cboNomeAmigo.Text);
                    arramig.Add(mtbTelefone.Text);
                    arramig.Add(cboEndereco.Text);

                    fazz.CadastrarAmigos(arramig);

                }
                if (tbcCadastro.TabPages[0].CanFocus)
                {

                    ArrayList autor = new ArrayList();
                    if (passa.PesqAutor(cboAutor.Text) <= 0 && cboAutor.Text != "")
                    {
                        autor.Add(cboAutor.Text);

                        passa.CadastrarAutor(autor);
                    }

                    //conexaoBanco passa = new conexaoBanco();
                    ArrayList album = new ArrayList();
                    if (passa.PesqAlbuns(cboAlbum.Text) <= 0 && cboAlbum.Text != "")
                    {
                        album.Add(cboAlbum.Text);

                        passa.CadastrarAlbum(album);
                    }

                    //conexaoBanco passa = new conexaoBanco();
                    ArrayList interr = new ArrayList();

                    if (passa.PesqInterprete(cboInterprete.Text) <= 0 && cboInterprete.Text != "")
                    {
                        interr.Add(cboInterprete.Text);

                        passa.CadastrarInterpretes(interr);
                    }
                    conexaoBanco disc = new conexaoBanco();
                    ArrayList arrdisc = new ArrayList();

                    conexaoBanco inter = new conexaoBanco();
                    conexaoBanco aut = new conexaoBanco();
                    conexaoBanco alb = new conexaoBanco();
                    conexaoBanco mid = new conexaoBanco();
                    //string arr = cboAutor.Text;
                    int codaut = 0;
                    int codinter = inter.PesqCodinter(cboInterprete.Text);
                    if (cboAutor.Text != "")
                    {
                        codaut = aut.PesqCodautor(cboAutor.Text);
                    }
                    else
                        codaut = Convert.ToInt32(cboAutor.Text = Enabled.ToString());
                
                    int codalb = alb.PesqCodalbum(cboAlbum.Text);
                    int codmid = mid.PesqCodmidia(cboMidia.Text);

                    arrdisc.Add(codmid);
                    arrdisc.Add(codaut);
                    arrdisc.Add(codinter);
                    arrdisc.Add(codalb);
                    arrdisc.Add(dtpDataAlbum.Value.ToShortDateString());
                    arrdisc.Add(dtpDataCompra.Value.ToShortDateString());
                    arrdisc.Add(txtOrigemCompra.Text);
                    arrdisc.Add(txtObservacoes.Text);
                    //arrdisc.Add(txtMusica.Text);
                    arrdisc.Add(txtNota.Text);

                    disc.CadastrarDiscos(arrdisc);
                }
                passaValoresParaCombobox();
                limpaCampos();
        }

        public int Nota(string notas)
        {
            int retur = 0;
            for (int i = 0; i <= 10; i++)
            {
                if (notas != i.ToString() && retur != 1 && notas != "")
                {
                    erpErro.SetError(txtNota, "Digite valores de 0 à 10");
                }
                else if(notas == i.ToString() || notas == "")
                {
                    erpErro.SetError(txtNota, "");
                    retur = 1;
                }
            }
            if (retur == 0)
                return retur;
            else
                return retur;
        }

        public void salvarDiscos()
        {
            if (tbcCadastro.TabPages[0].CanFocus)
            {
                foreach (Control tex in this.tbpDiscos.Controls)
                {
                    if (tex is ComboBox)
                    {
                        ComboBox t = (ComboBox)tex;
                        if (t.Text == "")
                        {
                            if (t.Name == cboAlbum.Name)
                                erpErro.SetError(t, "Digite o Campo Album");
                            if (t.Name == cboInterprete.Name)
                                erpErro.SetError(t, "Digite o Campo Interprete");
                        }
                        else if (t.Text == "N/C")
                            erpErro.SetError(t, "Escolha um Tipo de Midia");
                        else
                            erpErro.SetError(t, "");
                    }
                }

                if (cboAlbum.Text != "" && cboInterprete.Text != "" && cboMidia.Text != "N/C" && (Nota(txtNota.Text) == 1))
                    passaArrayListParaPreencherBanco();
            }
            else if (tbcCadastro.TabPages[1].CanFocus)
            {
                if (cboNomeAmigo.Text == "" && cboEndereco.Text == "")
                {
                    erpErro.SetError(cboNomeAmigo, "Digite o Nome");
                    erpErro.SetError(cboEndereco, "Digite o Endereço");
                }
                else if (cboNomeAmigo.Text == "")
                    erpErro.SetError(cboNomeAmigo, "Digite o Nome");
                else if (cboEndereco.Text == "")
                    erpErro.SetError(cboEndereco, "Digite o Endereço");
                else
                {
                    erpErro.SetError(cboNomeAmigo, "");
                    erpErro.SetError(cboEndereco, "");
                }
                if (cboNomeAmigo.Text != "" && cboEndereco.Text != "")
                    passaArrayListParaPreencherBanco();


            }
                
        }

        public void limpaCampos()
        {
            cboAlbum.Text = "";
            cboAutor.Text = "";
            cboInterprete.Text = "";
            //txtMusica.Clear();
            txtNota.Clear();
            txtObservacoes.Clear();
            txtOrigemCompra.Clear();
            cboNomeAmigo.Text = "";
            mtbTelefone.Clear();
            cboEndereco.Text = "";
            cboInterprete.Focus();
            cboNomeAmigo.Focus();
           
        }

        public void cancelar()
        {
            if (cboAlbum.Text == "" && cboAutor.Text == "" && cboInterprete.Text == "" && txtNota.Text == ""
                 && txtObservacoes.Text == "" && txtOrigemCompra.Text == "")
                this.Close();
            else if (MessageBox.Show("Campo preenchido", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                == DialogResult.Yes)
                this.Close();

        }


        private void frmCadastro_Load(object sender, EventArgs e)
        {
            passaValoresParaCombobox();
            limpaCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            salvarDiscos();
            //passaValoresParaCombobox();
        }

        private void btnCancelarAmigo_Click(object sender, EventArgs e)
        {
            cancelar();
        }

        private void btnLimparAmigo_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }
     
        private void txtNota_Leave(object sender, EventArgs e)
        {
            Nota(txtNota.Text);
        }

        private void btnSalvarAmigo_Click_1(object sender, EventArgs e)
        {
            salvarDiscos();
            //passaValoresParaCombobox();
        }

        private void cboNomeAmigo_MouseClick(object sender, MouseEventArgs e)
        {
            conexaoBanco pega = new conexaoBanco();
            cboNomeAmigo.DataSource = pega.prCombo_Amigos();
            cboNomeAmigo.DisplayMember = "Nome";
            cboNomeAmigo.Text = "";
            
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            conexaoBanco pegaEndereco = new conexaoBanco();
            cboEndereco.DataSource = pegaEndereco.prCombo_AmigosEndereco();
            cboEndereco.DisplayMember = "Endereco";
            cboEndereco.Text = "";
        }
    }
}

