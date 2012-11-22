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
        private const string sqlConn =  @"Data Source=PC08LAB3\MSSQLSERVER1;Initial Catalog=dbSysMusicColletion;Integrated Security=True";
//@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\dbSysMusicColletion.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
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
           //return cnx;
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

        //public List<string> PrCombo(string nome, string cod, string nomealb, string coddisco)
        //{
        //    SqlCommand listaramigos = null;

        //    //List<string> nomes = new List<string>();
        //    //List<string> cods = new List<string>();

        //    if (this.Abrirconexao())
        //    {
        //        try
        //        {
        //            new SqlCommand("Select Cod_Amigo, Nome from Amigos", cnx);

        //            SqlDataReader conta = listaramigos.ExecuteReader();

        //            while (conta.Read())
        //            {
        //                nome.add(conta["Nome"].ToString());
        //                cod.Add(conta["Cod_Amigo"].ToString());
        //                //cboNomeAmigo.Items.Add(conta["Nome"]);
        //                //cboNomeAmigo.SelectedValue = conta["Cod_Amigo"];

        //            }

        //            //List<string> nomealbs = new List<string>();
        //            //List<string> coddiscos = new List<string>();

        //            SqlCommand listarmidias = new SqlCommand("Select Nome_Album, Cod_Disco  from Albuns, Discos where Albuns.ID_Album = Discos.ID_Album ", cnx);

        //            SqlDataReader pega = listarmidias.ExecuteReader();

        //            while (pega.Read())
        //            {
        //                nomealbs.Add(pega["Nome_Album"].ToString());
        //                coddiscos.Add(pega["Cod_Discos"].ToString());
        //                //cboNomeMidia.Items.Add(pega["Nome_Album"]);
        //                //cboNomeMidia.SelectedValue = pega["Cod_Disco"];
        //            }
                 
                    
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception(ex.Message);
        //        }
        //        finally
        //        {
        //            this.Fecharconexao();
        //        }
        //    }
        //    else
        //    {
        //        return false;
        //    }

        //}

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

