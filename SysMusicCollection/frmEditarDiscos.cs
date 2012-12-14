using System;
using System.Collections.Generic;
using System.Collections;
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
        string codDisco;
        public ArrayList passaPrinc = new ArrayList();
        public frmEditarDiscos(ArrayList passar)
        {
            InitializeComponent();
            conexaoBanco inter = new conexaoBanco();
            cboEditaInterprete.DataSource = inter.prCombo_Interprete();
            cboEditaInterprete.DisplayMember = "Nome_Interprete";

            conexaoBanco autor = new conexaoBanco();
            cboEditaAutor.DataSource = autor.prCombo_Autor();
            cboEditaAutor.DisplayMember = "Nome_Autor";

            conexaoBanco album = new conexaoBanco();
            cboEditaAlbumeAutor.DataSource = album.prcombo_Album();
            cboEditaAlbumeAutor.DisplayMember = "Nome_Album";

            conexaoBanco midia = new conexaoBanco();
            cboEditaTipoMidia.DataSource = midia.prCombo_Midia();
            cboEditaTipoMidia.DisplayMember = "Tipo_Midia";

            cboEditaInterprete.Text = passar[2].ToString();
            cboEditaAutor.Text = passar[1].ToString();
            cboEditaAlbumeAutor.Text = passar[3].ToString();
            cboEditaOrigemCompra.Text = passar[6].ToString();
            cboEditaTipoMidia.Text = passar[9].ToString();
            txtEditaNota.Text = passar[8].ToString();
            txtEditaObservacoes.Text = passar[7].ToString();
            dtpEditaDataAlbum.Value = Convert.ToDateTime(passar[4]);
            dtpEditaDataCompra.Value = Convert.ToDateTime(passar[5]);
            codDisco = passar[0].ToString();
        }
        frmEditarDiscos frmedita;

        public frmEditarDiscos(frmEditarDiscos formPric)
        {
            InitializeComponent();
            frmedita = formPric;
        }

        public void VerificaItemsnoBanco()
        {
            conexaoBanco passa = new conexaoBanco();
            ArrayList autor = new ArrayList();
                    if (passa.PesqAutor(cboEditaAutor.Text) <=0 && (cboEditaAutor.Text != "" || cboEditaAutor.Text == ""))
                    {
                        if (cboEditaAutor.Text != "")
                        {
                            autor.Add(cboEditaAutor.Text);

                            passa.CadastrarAutor(autor);
                        }
                        else
                        {
                            autor.Add(cboEditaAutor.Text = "Nada Consta");

                            passa.CadastrarAutor(autor);
                            cboEditaAutor.Text = "";
                        }
                    }

                    //conexaoBanco passa = new conexaoBanco();
                    ArrayList album = new ArrayList();
                    if (passa.PesqAlbuns(cboEditaAlbumeAutor.Text) <= 0 && cboEditaAlbumeAutor.Text != "")
                    {
                        album.Add(cboEditaAlbumeAutor.Text);

                        passa.CadastrarAlbum(album);
                    }

                    //conexaoBanco passa = new conexaoBanco();
                    ArrayList interr = new ArrayList();

                    if (passa.PesqInterprete(cboEditaInterprete.Text) <= 0 && cboEditaInterprete.Text != "")
                    {
                        interr.Add(cboEditaInterprete.Text);

                        passa.CadastrarInterpretes(interr);
                    }

                    conexaoBanco disc = new conexaoBanco();
                    ArrayList arrdisc = new ArrayList();

                    conexaoBanco inter = new conexaoBanco();
                    conexaoBanco aut = new conexaoBanco();
                    conexaoBanco alb = new conexaoBanco();
                    conexaoBanco mid = new conexaoBanco();
                    //string arr = cboAutor.Text;
                    int codinter = inter.PesqCodinter(cboEditaInterprete.Text);
                    int codaut = aut.PesqCodautor(cboEditaAutor.Text);
                    int codalb = alb.PesqCodalbum(cboEditaAlbumeAutor.Text);
                    int codmid = mid.PesqCodmidia(cboEditaTipoMidia.Text);
                    
                    arrdisc.Add(codDisco);
                    arrdisc.Add(codmid);
                    arrdisc.Add(codaut);
                    arrdisc.Add(codinter);
                    arrdisc.Add(codalb);
                    arrdisc.Add(dtpEditaDataAlbum.Value);
                    arrdisc.Add(dtpEditaDataCompra.Value);
                    arrdisc.Add(cboEditaOrigemCompra.Text);
                    arrdisc.Add(txtEditaObservacoes.Text);
                    //arrdisc.Add(txtMusica.Text);
                    arrdisc.Add(txtEditaNota.Text);
                    disc.editaIntemBanco(arrdisc);
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmEditarDiscos_Load(object sender, EventArgs e)
        {
           
        }
        public int erroProvaider(string notas)
        {
            int retur = 0;
            for (int i = 0; i <= 10; i++)
            {
                if (notas != i.ToString() && retur != 1 && notas != "")
                {
                    erpErroEdita.SetError(txtEditaNota, "Digite valores de 0 à 10");
                }
                else if (notas == i.ToString() || notas == "")
                {
                    erpErroEdita.SetError(txtEditaNota, "");
                    retur = 1;
                }
            }
            if (retur == 0)
                return retur;
            else
                return retur;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            foreach (Control tex in this.Controls )
            {
                if (tex is ComboBox)
                {
                    ComboBox t = (ComboBox)tex;
                    if (t.Text == "")
                    {
                        if (t.Name == cboEditaAlbumeAutor.Name)
                        {
                            erpErroEdita.SetError(t, "Digite Album");
                        }
                        if (t.Name == cboEditaInterprete.Name)
                            erpErroEdita.SetError(t, "Digite o Interprete");
                    }
                    else if ((t.Name == cboEditaTipoMidia.Name) && (cboEditaTipoMidia.Text != "K7" &&
                        cboEditaTipoMidia.Text != "CD" && cboEditaTipoMidia.Text != "DVD" && cboEditaTipoMidia.Text != "Digital"))
                        erpErroEdita.SetError(t, "Escolha um Tipo de Midia");
                    else
                        erpErroEdita.SetError(t, "");
                }
            }
            frmCadastro frmcadastro = new frmCadastro();
            if (cboEditaAlbumeAutor.Text != "" && cboEditaInterprete.Text != "" && (cboEditaTipoMidia.Text == "Vinil" || cboEditaTipoMidia.Text == "K7" ||
                cboEditaTipoMidia.Text == "CD" || cboEditaTipoMidia.Text == "DVD" || cboEditaTipoMidia.Text == "Digital") && (erroProvaider(txtEditaNota.Text) == 1))
            {

                VerificaItemsnoBanco();

                passaPrinc = new ArrayList();
                passaPrinc.Add(codDisco);
                passaPrinc.Add(cboEditaInterprete.Text);
                passaPrinc.Add(cboEditaAutor.Text);
                passaPrinc.Add(cboEditaAlbumeAutor.Text);
                passaPrinc.Add(cboEditaOrigemCompra.Text);
                passaPrinc.Add(cboEditaTipoMidia.Text);
                passaPrinc.Add(txtEditaNota.Text);
                passaPrinc.Add(txtEditaObservacoes.Text);
                passaPrinc.Add(dtpEditaDataAlbum.Value);
                passaPrinc.Add(dtpEditaDataCompra.Value);
                this.Close();
            }
    
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtEditaNota_Leave(object sender, EventArgs e)
        {
            erroProvaider(txtEditaNota.Text);
        }



    }
}
