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


     private const string sqlConn = @" Data Source=PC08LAB3\MSSQLSERVER2;Initial Catalog=dbSysMusicColletion;Integrated Security=True";
/* Bruno*/ //@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\dbSysMusicColletion.mdf;Integrated Security=True;Connect Timeout=2;User Instance=True";
/*Felipe*/ //@" Data Source=PC08LAB3\MSSQLSERVER2;Initial Catalog=dbSysMusicColletion;Integrated Security=True";
///*Thiago*/ @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\dbSysMusicColletion.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";

        private string pegasql = "";
        SqlConnection cnx = null;

        #region Métodos de conexão

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

        #endregion

        #region Cadastros nas tabelas Discos, Amigos

        public bool CadastrarDiscos(ArrayList p_cadDiscos)
        {
            SqlCommand cadastrardiscos = null;
            if (this.Abrirconexao())
            {
                try
                {
                    cadastrardiscos = new SqlCommand("INSERT INTO Discos (Cod_Midia , ID_Autor , ID_Interprete , ID_Album , Data_Album , Data_Compra , Origem_Compra , Observ , Nota) VALUES (@Cod_Midia , @ID_Autor, @ID_Interprete , @ID_Album, @Data_Album, @Data_Compra, @Origem_Compra, @Observ, @Nota )" , cnx);

                        //p_cadDiscos[1] = null;
                    cadastrardiscos.Parameters.Add(new SqlParameter("@Cod_Midia", p_cadDiscos[0]));
                    cadastrardiscos.Parameters.Add(new SqlParameter("@ID_Autor", p_cadDiscos[1]));
                    cadastrardiscos.Parameters.Add(new SqlParameter("@ID_Interprete", p_cadDiscos[2]));
                    cadastrardiscos.Parameters.Add(new SqlParameter("@ID_Album", p_cadDiscos[3]));
                    cadastrardiscos.Parameters.Add(new SqlParameter("@Data_Album", p_cadDiscos[4]));
                    cadastrardiscos.Parameters.Add(new SqlParameter("@Data_Compra", p_cadDiscos[5]));
                    cadastrardiscos.Parameters.Add(new SqlParameter("@Origem_Compra", p_cadDiscos[6]));
                    cadastrardiscos.Parameters.Add(new SqlParameter("@Observ", p_cadDiscos[7]));
                    //cadastrardiscos.Parameters.Add(new SqlParameter("@Nome_Musica", p_cadDiscos[8]));
                    cadastrardiscos.Parameters.Add(new SqlParameter("@Nota", p_cadDiscos[8]));

                    cadastrardiscos.ExecuteNonQuery();
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

        public bool CadastrarEmp(ArrayList p_codem)
        {
            SqlCommand cadastraritens = null;
            if (this.Abrirconexao())
            {
                try
                {
                    cadastraritens = new SqlCommand("Insert Into Emprestimos (Data_Emprestimo,Cod_Amigo) values (@dt,@CD)", cnx);
                    cadastraritens.Parameters.Add(new SqlParameter("@dt", p_codem[0]));
                    cadastraritens.Parameters.Add(new SqlParameter("@CD", p_codem[1]));
                    cadastraritens.ExecuteNonQuery();

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
        public bool CadastrarItensEmp(int coddisc, int codemp)
        {
            SqlCommand cadastraritens = null;
            if (this.Abrirconexao())
            {
                try
                {
                    cadastraritens = new SqlCommand("Insert Into Itens_Emprestimo (Cod_Disco,Num_Emprestimo) values (@Cd,@Ne)", cnx);
                    cadastraritens.Parameters.Add(new SqlParameter("@Cd", coddisc));
                    cadastraritens.Parameters.Add(new SqlParameter("@Ne", codemp));

                    cadastraritens.ExecuteNonQuery();

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

        #endregion

        #region Preenchimento dos comboboxs

        public List<string> prcombo_Album()
        {
            SqlCommand listarAlbum = null;

            List<string> comboAlbum = new List<string>();
            if (this.Abrirconexao())
            {
                try
                {
                    listarAlbum = new SqlCommand("Select Nome_Album from Albuns", cnx);
                    SqlDataReader dr = listarAlbum.ExecuteReader();

                    while (dr.Read())
                    {
                        comboAlbum.Add(dr["Nome_Album"].ToString());
                    }
                    return comboAlbum;

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

        public List<string> prCombo_Interprete()
        {
            SqlCommand listarInterprete = null;

            List<string> comboInterprete = new List<string>();
            if (this.Abrirconexao())
            {
                try
                {
                    listarInterprete = new SqlCommand("Select Nome_Interprete from Interpretes", cnx);
                    SqlDataReader dr = listarInterprete.ExecuteReader();

                    while (dr.Read())
                    {
                        comboInterprete.Add(dr["Nome_Interprete"].ToString());
                    }
                    return comboInterprete;

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

        public List<string> prCombo_Autor()
        {
            SqlCommand listarAutor = null;

            List<string> comboAutor = new List<string>();
            //List<string> cods = new List<string>();

            if (this.Abrirconexao())
            {
                try
                {
                    listarAutor = new SqlCommand("Select Nome_Autor from Autores", cnx);

                    SqlDataReader dr = listarAutor.ExecuteReader();

                    while (dr.Read())
                    {
                        comboAutor.Add(dr["Nome_Autor"].ToString());

                    }

                    return comboAutor;
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

        public List<string> prCombo_Midia()
        {
            SqlCommand listarMidia = null;

            List<string> comboMidia = new List<string>();
            //List<string> cods = new List<string>();

            if (this.Abrirconexao())
            {
                try
                {
                    listarMidia = new SqlCommand("Select Tipo_Midia from Midias", cnx);

                    SqlDataReader dr = listarMidia.ExecuteReader();

                    while (dr.Read())
                    {
                        comboMidia.Add(dr["Tipo_Midia"].ToString());

                    }

                    return comboMidia;
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

        public List<string> prCombo_Amigos()
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

        public List<string> prCombo_AmigosEndereco()
        {

            SqlCommand listaramigosEndereco = null;

            List<string> comboamigosEnderecos = new List<string>();
            //List<string> comboamigo = new List<string>();
            //List<string> cods = new List<string>();

            if (this.Abrirconexao())
            {
                try
                {
                    listaramigosEndereco = new SqlCommand("Select Endereco from Amigos", cnx);

                    SqlDataReader dr = listaramigosEndereco.ExecuteReader();

                    while (dr.Read())
                    {
                        comboamigosEnderecos.Add(dr["Endereco"].ToString());

                    }

                    return comboamigosEnderecos;
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


        public List<string> prCombo_Discos()
        {

            SqlCommand listardiscos = null;

            List<string> combomidias = new List<string>();
            //List<string> cods = new List<string>();

            if (this.Abrirconexao())
            {
                try
                {
                    listardiscos = new SqlCommand("Select Nome_Album, Cod_Disco  from Albuns, Discos where Albuns.ID_Album = Discos.ID_Album ", cnx);

                    SqlDataReader dr = listardiscos.ExecuteReader();

                    while (dr.Read())
                    {
                        combomidias.Add(dr["Nome_Album"].ToString());

                    }

                    return combomidias;
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

        #endregion

        #region Preenchimento dos grids

        public DataTable GridEmp()
        {
            SqlCommand dgvEmp = null;

            if (this.Abrirconexao())
            {
                string sql = " select Nome_Album from Albuns inner join Discos on Albuns.ID_Album = Discos.ID_Album " +
                              " inner join Itens_Emprestimo on Discos.Cod_Disco = Itens_Emprestimo.Cod_Disco where Discos.Cod_Disco = null";
                try
                {
                    dgvEmp = new SqlCommand(sql, cnx);
                    SqlDataAdapter adp = new SqlDataAdapter(dgvEmp);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    //dgvEmp.ExecuteNonQuery();
                    return dt;
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

        public DataTable GridEmpPesq(string pesq, int pega)
        {
            string sql = pesq;
            SqlCommand dgvEmp = null;

            if (this.Abrirconexao())
            {

                try
                {
                    dgvEmp = new SqlCommand(sql, cnx);
                    dgvEmp.Parameters.Add(new SqlParameter("@valor", pega));
                    SqlDataAdapter adp = new SqlDataAdapter(dgvEmp);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    //dgvEmp.ExecuteNonQuery();

                    return dt;
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

        public SqlCommand lv(bool espera)
        {

            if (this.Abrirconexao())
            {
                string sql = " select Tipo_Midia, Nome_Autor, Nome_Interprete, Nome_Album ,Data_Album, Data_Compra, Origem_Compra, " + " Observ, Nota from Discos inner join Midias on Discos.Cod_Midia = Midias.Cod_Midia inner join " + " Autores on Autores.ID_Autor = Discos.ID_autor inner join Interpretes on Interpretes.ID_Interprete " + " = Discos.Id_Interprete inner join Albuns on Albuns.ID_Album = Discos.ID_Album ";
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, cnx);
                    return cmd;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    if (espera)
                        this.Fecharconexao();
                }
            }
            else
            {
                return null;
            }
        }

        #endregion

        #region Pesquisa e Cadastro Discos

        public int PesqInterprete(string Nome)
        {
            SqlCommand pesqInter = null;

            if (this.Abrirconexao())
            {
                string sql = " select Count(*) from Interpretes where Nome_Interprete = @Pega";
                try
                {
                    pesqInter = new SqlCommand(sql, cnx);
                    pesqInter.Parameters.AddWithValue("@Pega", Nome);
                    //pesqInter.ExecuteNonQuery();
                    int total = (int)pesqInter.ExecuteScalar();
                    return total;
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
                return 0;
            }
        }

        public bool CadastrarInterpretes(ArrayList p_Cadinterprete)
        {
            SqlCommand cadastrarinterprete = null;
            if (this.Abrirconexao())
            {
                try
                {
                    cadastrarinterprete = new SqlCommand("Insert Into Interpretes (Nome_interprete) values (@N)", cnx);
                    cadastrarinterprete.Parameters.Add(new SqlParameter("@N", p_Cadinterprete[0]));

                    cadastrarinterprete.ExecuteNonQuery();

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

        public int PesqAutor(string Nome)
        {
            SqlCommand pesqAutor = null;
            int total =0;
            if (this.Abrirconexao())
            {
                try
                {
                    if (Nome != "")
                    {
                        string sql = " select Count(*) from Autores where Nome_Autor = @Pega";


                        pesqAutor = new SqlCommand(sql, cnx);
                        pesqAutor.Parameters.AddWithValue("@Pega", Nome);

                        total = (int)pesqAutor.ExecuteScalar();

                        return total;
                    }

                    else if (Nome == "")
                    {
                        string sql = " select Count(*) from Autores where Nome_Autor = 'Nada Consta'";


                        pesqAutor = new SqlCommand(sql, cnx);
                        //pesqAutor.Parameters.AddWithValue("@Pega", Nome);

                        total = (int)pesqAutor.ExecuteScalar();
                        return total;
                    }
                    return total;
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
                return 0;
            }
        }

        public bool CadastrarAutor(ArrayList p_Cadautor)
        {
            SqlCommand cadastrarautor = null;
            if (this.Abrirconexao())
            {
                try
                {
                    
                        cadastrarautor = new SqlCommand("Insert Into Autores (Nome_Autor) values (@N)", cnx);
                        cadastrarautor.Parameters.Add(new SqlParameter("@N", p_Cadautor[0]));

                        cadastrarautor.ExecuteNonQuery();
                    
                    
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


        public int PesqAlbuns(string Nome)
        {
            SqlCommand pesqAlbuns = null;

            if (this.Abrirconexao())
            {
                string sql = " select Count(*) from Albuns where Nome_Album = @Pega";
                try
                {
                    pesqAlbuns = new SqlCommand(sql, cnx);
                    pesqAlbuns.Parameters.AddWithValue("@Pega", Nome);

                    int total = (int)pesqAlbuns.ExecuteScalar();

                    return total;
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
                return 0;
            }
        }

        public bool CadastrarAlbum(ArrayList p_Cadalbum)
        {
            SqlCommand cadastraralbum = null;
            if (this.Abrirconexao())
            {
                try
                {
                    cadastraralbum = new SqlCommand("Insert Into Albuns (Nome_Album) values (@N)", cnx);
                    cadastraralbum.Parameters.Add(new SqlParameter("@N", p_Cadalbum[0]));

                    cadastraralbum.ExecuteNonQuery();

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


        #endregion

        #region pesquisa para cadastro do código

        public int PesqCodinter(string Nome)
        {
            SqlCommand pesqcod = null;

            if (this.Abrirconexao())
            {
                string sql = "select ID_Interprete from Interpretes where Nome_Interprete = @Pega";
                try
                {
                    pesqcod = new SqlCommand(sql, cnx);
                    pesqcod.Parameters.AddWithValue("@Pega", Nome);
                    //pesqInter.ExecuteNonQuery();
                    int cd = (int)pesqcod.ExecuteScalar();
                    return cd;
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
                return 0;
            }
        }

        public int PesqCodautor(string Nome)
        {
            SqlCommand pesqcod = null;

            if (this.Abrirconexao())
            {
                if (Nome != "")
                {
                    string sql = "select ID_Autor from Autores where Nome_Autor = @Pega";
                    try
                    {
                        pesqcod = new SqlCommand(sql, cnx);
                        pesqcod.Parameters.AddWithValue("@Pega", Nome);
                        //pesqInter.ExecuteNonQuery();
                        int cd = (int)pesqcod.ExecuteScalar();
                        return cd;
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
                return 0;
            }
            else
            {
                return 0;
            }
        }

        public int PesqCodalbum(string Nome)
        {
            SqlCommand pesqcod = null;

            if (this.Abrirconexao())
            {

                
                    string sql = "select ID_Album from Albuns where Nome_Album = @Pega";
                    try
                    {
                        pesqcod = new SqlCommand(sql, cnx);
                        pesqcod.Parameters.AddWithValue("@Pega", Nome);
                        //pesqInter.ExecuteNonQuery();
                        int cd = (int)pesqcod.ExecuteScalar();
                        return cd;
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
                return 0;
            }
        }

        public int PesqAmigos(string Nome)
        {
            SqlCommand pesqamigo = null;

            if (this.Abrirconexao())
            {
                string sql = "select Cod_Amigo from Amigos where Nome = @Pega";
                try
                {
                    pesqamigo = new SqlCommand(sql, cnx);
                    pesqamigo.Parameters.AddWithValue("@Pega", Nome);
                    //pesqInter.ExecuteNonQuery();
                    int cd = (int)pesqamigo.ExecuteScalar();
                    return cd;
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
                return 0;
            }
        }

        public int PesqCodmidia(string Nome)
        {
            SqlCommand pesqcod = null;

            if (this.Abrirconexao())
            {
                string sql = "select Cod_Midia from Midias where Tipo_Midia = @Pega";
                try
                {
                    pesqcod = new SqlCommand(sql, cnx);
                    pesqcod.Parameters.AddWithValue("@Pega", Nome);
                    //pesqInter.ExecuteNonQuery();
                    int cd = (int)pesqcod.ExecuteScalar();
                    return cd;
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
                return 0;
            }
        }

        public int PesqCoddiscos(string Nome)
        {
            SqlCommand pesqcod = null;

            if (this.Abrirconexao())
            {
                string sql = "select Cod_Disco from Discos inner join Albuns on Discos.ID_Album = Albuns.ID_Album where Albuns.Nome_Album = @Pega";
                try
                {
                    pesqcod = new SqlCommand(sql, cnx);
                    pesqcod.Parameters.AddWithValue("@Pega", Nome);
                    //pesqInter.ExecuteNonQuery();
                    int cd = (int)pesqcod.ExecuteScalar();
                    return cd;
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
                return 0;
            }
        }

        public int PesqCodEmp(int Cdam, string data)
        {
            SqlCommand pesqamigo = null;

            if (this.Abrirconexao())
            {
                string sql = "select Num_Emprestimo from Emprestimos where Data_Emprestimo = @dt and Cod_Amigo = @cdam";
                try
                {
                    pesqamigo = new SqlCommand(sql, cnx);
                    pesqamigo.Parameters.AddWithValue("@dt", data);
                    pesqamigo.Parameters.AddWithValue("@cdam", Cdam);
                    //pesqInter.ExecuteNonQuery();
                    int cd = (int)pesqamigo.ExecuteScalar();
                    return cd;
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
                return 0;
            }
        }


        #endregion


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
