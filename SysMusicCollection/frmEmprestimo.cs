using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace SysMusicCollection
{
    public partial class frmEmprestimo : Form
    {
        public frmEmprestimo()
        {
            InitializeComponent();
        }

        private void frmEmprestimo_Load(object sender, EventArgs e)
        {
            SqlConnection sqlconn = conexaoBanco.Abrirconexao();

            cboNomeAmigo.Items.Clear();

            SqlCommand listaramigos = new SqlCommand("Select" + "Cod_Amigo" + "Nome" + "from" + "Amigos", sqlconn);

            SqlDataReader dataReader = listaramigos.ExecuteReader();

            while (dataReader.Read())
            {
                cboNomeAmigo.Items.Add(dataReader["Nome"]);
                cboNomeAmigo.SelectedValue = dataReader["Cod_Amigo"];
            }
            conexaoBanco.Fecharconexao();
            
        }
    }
}
 