using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace SysMusicCollection
{
    public class conexaoBanco
    {
        private const string sqlConn = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\dbSysMusicColletion.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        private string pegasql = "";
        SqlConnection cnx = null;

        private bool Abrirconexao()
        {
            cnx = new SqlConnection(sqlConn);
            try
            {
                cnx.Open();
                return true;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                return false;
            }

        }

        private bool Fecharconexao()
        {
            if (cnx.State != ConnectionState.Closed)
            {
                cnx.Close();
                cnx.Dispose();
                return true;
            }
            else
            {
                cnx.Dispose();
                return false;
            }
        }

        public bool CadastrarAmigos(ArrayList p_Cadamigo)
        {
            SqlCommand cadastraramigos = null;
            if (this.Abrirconexao())
            {
                try
                {
                    cadastraramigos = new SqlCommand("Insert Into Amigos (Nome,Telefone,Endereco) values (@N,@T,@E)", cnx);
                    cadastraramigos.Parameters.Add(new SqlParameter("@N", p_Cadamigo[0]));
                    cadastraramigos.Parameters.Add(new SqlParameter("@T", p_Cadamigo[1]));
                    cadastraramigos.Parameters.Add(new SqlParameter("@E", p_Cadamigo[2]));

                    cadastraramigos.ExecuteNonQuery();

                    return true;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    this.Fecharconexao();
                }
            }
            else
            {
                return false;
            }
        }

        public List<string> prCombo()
        {

            SqlCommand listaramigos = null;

            List<string> comboamigos = new List<string>();
            //List<string> cods = new List<string>();

            if (this.Abrirconexao())
            {
                try
                {
                    listaramigos = new SqlCommand("Select Cod_Amigo, Nome from Amigos", cnx);

                    SqlDataReader dr = listaramigos.ExecuteReader();

                    while (dr.Read())
                    {
                        comboamigos.Add(dr["Nome"].ToString());

                    }

                    return comboamigos;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    this.Fecharconexao();
                }
            }
            else
            {
                return null;
            }

        }

        //public static int Quantidade()
        //{
        //    Abrirconexao();
        //    SqlCommand qtd = new SqlCommand();
        //    qtd.Connection = Abrirconexao();
        //    qtd.CommandText = "Select Count(*) from Amigos";

        //    int total = (int)qtd.ExecuteScalar();

        //    Fecharconexao();
        //    return total;
        //}

        //public void inserirDiscos()
        //{
        //    Abrirconexao();
        //    SqlCommand comandoInsert = new SqlCommand("Insert into Discos (Cod_Midia, ID_Autor, ID_interprete, ID_album, Data_album, Data_compra, Origem_Compra, Observ, Nome_Musica, Nota)");

        //}
    }
}


