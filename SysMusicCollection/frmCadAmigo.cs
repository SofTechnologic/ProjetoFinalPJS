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

        public void salvar()
        {
            
            
                foreach (Control tex in this.tbpDiscos.Controls)
                {
                    if (tex is ComboBox)
                    {
                        ComboBox t = (ComboBox)tex;
                        if (t.Text == "" || t.Text == "Selecione um Tipo...")
                        {
                            if (t.Name == cboAlbum.Name)
                                errorProvider1.SetError(t, "Digite o Campo Album");
                            if (t.Name == cboAutor.Name)
                                errorProvider1.SetError(t, "Digite o Campo Autor");
                            if (t.Name == cboInterprete.Name )
                                errorProvider1.SetError(t, "Digite o Campo Imterprete");
                            if (t.Name == cboMidia.Name )
                                errorProvider1.SetError(t, "Digite o Campo Nome");     
                        }
                        else
                            errorProvider1.SetError(t, "");
                    }
                }

        }

        public void limpaCampos()
        {
            cboAlbum.Text = "";
            cboAutor.Text = "";
            cboInterprete.Text = "";
            txtMusica.Clear();
            txtNota.Clear();
            txtObservacoes.Clear();
            txtOrigemCompra.Clear();
            txtNomeAmigo.Clear();
            mtbTelefone.Clear();
            txtEndereco.Clear();
            cboMidia.SelectedIndex = 0;
            cboInterprete.Focus();
            txtNomeAmigo.Focus();
        }

        public void cancelar()
        {
            if (cboAlbum.Text == "" && cboAutor.Text == "" && cboInterprete.Text == "" && txtNota.Text == ""
                 && txtObservacoes.Text == "" && txtOrigemCompra.Text == "" && txtMusica.Text == "")
                this.Close();
            else if (MessageBox.Show("Campo preenchido", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                == DialogResult.Yes)
                this.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmCadastro_Load(object sender, EventArgs e)
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

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            salvar();
            if (tbcCadastro.TabPages[1].CanFocus)
            {
                conexaoBanco fazz = new conexaoBanco();
                ArrayList arramig = new ArrayList();

                arramig.Add(txtNomeAmigo.Text);
                arramig.Add(mtbTelefone.Text);
                arramig.Add(txtEndereco.Text);

                fazz.CadastrarAmigos(arramig);
            }
            if (tbcCadastro.TabPages[0].CanFocus)
            {
                conexaoBanco disc = new conexaoBanco();
                ArrayList arrdisc = new ArrayList();

                conexaoBanco inter = new conexaoBanco();
                conexaoBanco aut = new conexaoBanco();
                conexaoBanco alb = new conexaoBanco();
                conexaoBanco mid = new conexaoBanco();
                //string arr = cboAutor.Text;

                int codinter = inter.PesqCodinter(cboInterprete.Text);
                int codaut = aut.PesqCodautor(cboAutor.Text);
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
                arrdisc.Add(txtMusica.Text);
                arrdisc.Add(txtNota.Text);

                disc.CadastrarDiscos(arrdisc);
                //lblInterprete.Text = teste.ToString();
                //lblAutor.Text = testes.ToString();
                //lblAlbum.Text = test.ToString();

                frmCadastro_Load(e, e);
            }


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

        private void txtInterprete_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAutor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMusica_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAlbum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOrigemCompra_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboMidia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvarAmigo_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(conexaoBanco.sqlconn);//@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\dbSysMusicColletion.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            conexaoBanco faz = new conexaoBanco();
            ArrayList arr = new ArrayList();

            arr.Add(txtNomeAmigo.Text);
            arr.Add(mtbTelefone.Text);
            arr.Add(txtEndereco.Text);

            faz.CadastrarAmigos(arr);

        }

        private void tbpDiscos_Click(object sender, EventArgs e)
        {

        }

        private void cboInterprete_Leave(object sender, EventArgs e)
        {
            conexaoBanco passa = new conexaoBanco();
            ArrayList inter = new ArrayList();


            if (passa.PesqInterprete(cboInterprete.Text) <= 0 && cboInterprete.Text != "")
            {
                inter.Add(cboInterprete.Text);

                passa.CadastrarInterpretes(inter);
            }
        }

        private void cboAutor_Leave(object sender, EventArgs e)
        {
            conexaoBanco passa = new conexaoBanco();
            ArrayList autor = new ArrayList();


            if (passa.PesqAutor(cboAutor.Text) <= 0 && cboAutor.Text != "")
            {
                autor.Add(cboAutor.Text);

                passa.CadastrarAutor(autor);
            }
        }

        private void cboAlbum_Leave(object sender, EventArgs e)
        {
            conexaoBanco passa = new conexaoBanco();
            ArrayList album = new ArrayList();


            if (passa.PesqAlbuns(cboAlbum.Text) <= 0 && cboAlbum.Text != "")
            {
                album.Add(cboAlbum.Text);

                passa.CadastrarAlbum(album);
            }
        }      
    }
}

