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

        public void detectaErro()
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
            cboMidia.SelectedIndex = 0;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            detectaErro();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarAmigo_Click(object sender, EventArgs e)
        {
            detectaErro();
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
    }
}

