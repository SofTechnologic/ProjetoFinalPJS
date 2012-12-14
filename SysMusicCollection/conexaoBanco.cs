using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace SysMusicCollection
{
    public class conexaoBanco
    {



        private const string sqlConn = //@" Data Source=FELIPE-IBM;Initial Catalog=dbSysMusicColletion;Integrated Security=True";
///* Bruno*/ @"Data Source=NOTEBOOK;Initial Catalog=dbSysMusicColletion;Integrated Security=True";
//            ///*Felipe*/ @" Data Source=PC08LAB3\MSSQLSERVER2;Initial Catalog=dbSysMusicColletion;Integrated Security=True";
            /*Thiago*/ @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\dbSysMusicColletion.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";




        

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
                    cadastrardiscos = new SqlCommand("INSERT INTO Discos (Cod_Midia , ID_Autor , ID_Interprete , ID_Album , Data_Album , Data_Compra , Origem_Compra , Observ , Nota, Emprestado) VALUES (@Cod_Midia , @ID_Autor, @ID_Interprete , @ID_Album, @Data_Album, @Data_Compra, @Origem_Compra, @Observ, @Nota, 0 )", cnx);

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
                    if (Convert.ToInt16(p_codem[1]) > 0)
                    {
                        cadastraritens = new SqlCommand("Insert Into Emprestimos (Data_Emprestimo , Cod_Amigo) values (@dt,@CD)", cnx);
                        cadastraritens.Parameters.Add(new SqlParameter("@dt", p_codem[0]));
                        cadastraritens.Parameters.Add(new SqlParameter("@CD", p_codem[1]));
                        cadastraritens.ExecuteNonQuery();
                    }
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
                    cadastraritens = new SqlCommand("Insert Into Itens_Emprestimo (Cod_Disco,Num_Emprestimo) values (@Cd,@Ne) update Discos set Emprestado = 1 where Cod_Disco = @Cd ; ", cnx);
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

        public bool CadastrarDevolucao(string data, int codemp, int codamg, string dtemp, int coddisc)
        {
            SqlCommand cadastrardatadevolve = null;
            if (this.Abrirconexao())
            {
                try
                {
                    cadastrardatadevolve = new SqlCommand("Update Itens_Emprestimo SET Data_Devolucao = @DT from Itens_Emprestimo inner join Emprestimos on Itens_Emprestimo.Num_Emprestimo = Emprestimos.Num_Emprestimo where (Itens_Emprestimo.Num_Emprestimo = @Cod and Emprestimos.Cod_Amigo = @Am and Emprestimos.Data_Emprestimo = @Dtemp and Itens_Emprestimo.Cod_Disco = @Coddisc) update Discos SET Emprestado = 0 where Cod_Disco = @Coddisc ", cnx);

                    cadastrardatadevolve.Parameters.Add(new SqlParameter("@DT", data));
                    cadastrardatadevolve.Parameters.AddWithValue("@Cod", codemp);
                    cadastrardatadevolve.Parameters.AddWithValue("@Am", codamg);
                    cadastrardatadevolve.Parameters.AddWithValue("@Dtemp", dtemp);
                    cadastrardatadevolve.Parameters.AddWithValue("@Coddisc", coddisc);
                    cadastrardatadevolve.ExecuteNonQuery();

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

        public bool CadastrarMorto(string nome_am, string nome_disc, string data_em, string data_dev)
        {
            SqlCommand cadastraritens = null;
            if (this.Abrirconexao())
            {
                try
                {
                    cadastraritens = new SqlCommand("Insert Into Morto (Nome_Amigo, Nome_Disco, Data_Emprestimo, Data_Devolucao) values (@Am,@Disc,@Dt_em,@Dt_dv)", cnx);
                    cadastraritens.Parameters.Add(new SqlParameter("@Am", nome_am));
                    cadastraritens.Parameters.Add(new SqlParameter("@Disc", nome_disc));
                    cadastraritens.Parameters.Add(new SqlParameter("@Dt_em", data_em));
                    cadastraritens.Parameters.Add(new SqlParameter("@Dt_dv", data_dev));

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
                        if (dr["Nome_Autor"].ToString() != "Nada Consta")
                        {
                            comboAutor.Add(dr["Nome_Autor"].ToString());
                        }

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
                    listardiscos = new SqlCommand("Select Nome_Album, Cod_Disco  from Albuns, Discos where (Albuns.ID_Album = Discos.ID_Album  and Discos.Emprestado = 0 and Cod_Midia != 5) ", cnx);

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


        public List<string> prComboDevolve_Discos()
        {

            SqlCommand listardiscos = null;

            List<string> combomidias = new List<string>();
            //List<string> cods = new List<string>();

            if (this.Abrirconexao())
            {
                try
                {
                    listardiscos = new SqlCommand("Select Nome_Album, Cod_Disco  from Albuns, Discos where (Albuns.ID_Album = Discos.ID_Album and Discos.Cod_Midia != 5) ", cnx);

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

        #region Preenchimento dos grids e listview

        public DataTable GridEmp()
        {
            SqlCommand dgvEmp = null;

            if (this.Abrirconexao())
            {
                string sql = " select Nome_Album as [Album/Msica], Nome, Data_Emprestimo as [Data do Emprestimo], DATEDIFF(DAY, Convert(Date, data_emprestimo,103), GETDATE()) AS [Dias Emprestado] from Albuns" +
                             " inner join Discos on Albuns.ID_Album = Discos.ID_Album " +
                             " inner join Itens_Emprestimo on Discos.Cod_Disco = Itens_Emprestimo.Cod_Disco " +
                             " inner join Emprestimos on Itens_Emprestimo.Num_Emprestimo = Emprestimos.Num_Emprestimo " +
                             " inner join amigos on Emprestimos.Cod_Amigo = Amigos.Cod_Amigo" +
                             " where Itens_Emprestimo.Data_Devolucao IS NULL ";

                
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

        public DataTable GridDev()
        {
            SqlCommand dgvEmp = null;

            if (this.Abrirconexao())
            {
                string sql = " Select Nome_amigo as Amigo, Nome_disco as Disco, Data_Emprestimo as [Data do Emprestimo], Data_devolucao as [Data de Devolução] from Morto";

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

        public DataTable GridAmig()
        {
            SqlCommand dgvAmig = null;

            if (this.Abrirconexao())
            {
                string sql = " Select Nome as [Amigo], Telefone, Endereco from Amigos";

                try
                {
                    dgvAmig = new SqlCommand(sql, cnx);
                    SqlDataAdapter adp = new SqlDataAdapter(dgvAmig);
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


        public DataTable GridPesqAmig(string amg)
        {
            SqlCommand dgvAmig = null;

            if (this.Abrirconexao())
            {
                string sql = " Select Nome as [Amigo], Telefone, Endereco from Amigos where Nome like @amg";

                try
                {
                    dgvAmig = new SqlCommand(sql, cnx);
                    dgvAmig.Parameters.Add("@amg","%" + amg + "%");
                    SqlDataAdapter adp = new SqlDataAdapter(dgvAmig);
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

        
        public int pesqUltimoCod()
        {
            SqlCommand pesqCodDisco= null;

            if (this.Abrirconexao())
            {
                try
                {
                pesqCodDisco =  new SqlCommand(" Select Max(Cod_Disco) from Discos", cnx);
                int v = (int)pesqCodDisco.ExecuteScalar();
                return v;
                
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
                
        public SqlCommand lv(bool espera)
        {

            if (this.Abrirconexao())
            {
                string sql = " select Cod_Disco, Tipo_Midia, Nome_Autor as Autor, Nome_Interprete as Interprete , Nome_Album as [Album/Musica] , Convert(char(10),Data_Album,103)  as [Data do Album], Convert(char(10),Data_Compra,103) as [Data da Compra], Origem_Compra as [Origem da Compra], " + 
                    " Observ as Observação , Nota from Discos inner join Midias on Discos.Cod_Midia = Midias.Cod_Midia inner join " + " Autores on Autores.ID_Autor = Discos.ID_autor inner join Interpretes on Interpretes.ID_Interprete " +
                    " = Discos.Id_Interprete inner join Albuns on Albuns.ID_Album = Discos.ID_Album ";
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

        public SqlCommand filtro(bool espera, string nome,  string tipo, string interprete, string autor, string origem, DateTime datal1,DateTime datal2,DateTime dtcom1, DateTime dtcom2)
        {
            if (this.Abrirconexao())
            {
                string sql = "select Cod_Disco,Tipo_Midia, Nome_Autor as Autor, Nome_Interprete as Interprete, " +
                             " Nome_Album as [Album/Musica], Convert(char(10),Data_Album,103)  as [Data do Album], " +
                             " Convert(char(10),Data_Compra,103) as [Data da Compra], Origem_Compra as [Origem da Compra], Observ as Observação," +
                             " Nota from Discos inner join Midias on Discos.Cod_Midia = Midias.Cod_Midia " +
                             " inner join Autores on Autores.ID_Autor = Discos.ID_autor " +
                             " inner join Interpretes on Interpretes.ID_Interprete = Discos.Id_Interprete " +
                             " inner join Albuns on Albuns.ID_Album = Discos.ID_Album " +
                             " where (Albuns.Nome_Album like @nome or @nome = '') " +
                             " and (Midias.Tipo_Midia = @tipo or @tipo = '') and (Autores.Nome_Autor like @autor or @autor = '')" +
                             " and (Discos.Origem_Compra like @origem or @origem = '') " +
                             " and (Interpretes.Nome_Interprete like @interprete or @interprete = '')" +
                            " and (Discos.data_album >= Convert(date,@dtal1,103) and Discos.data_album <= Convert(date,@dtal2,103))" +
                            " and (Discos.data_compra >= Convert(date,@dtcom1,103) and Discos.data_compra <= Convert(date,@dtcom2,103))";
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, cnx);
                    cmd.Parameters.Add("@nome", "%" + nome + "%"); 
                    cmd.Parameters.Add("@tipo", tipo);
                    cmd.Parameters.Add("@autor", "%" + autor + "%");
                    cmd.Parameters.Add("@origem", "%" + origem + "%");
                    cmd.Parameters.Add("@interprete", "%" + interprete + "%");
                    cmd.Parameters.Add("@dtal1",datal1.ToShortDateString());
                    cmd.Parameters.Add("@dtal2",datal2.ToShortDateString());
                    cmd.Parameters.Add("@dtcom1", dtcom1.ToShortDateString());
                    cmd.Parameters.Add("@dtcom2", dtcom2.ToShortDateString());

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

        public DataTable PesqAmigosgrid(string passasql, string param)
        {
            SqlCommand pesqAmigosgrid = null;

            if (this.Abrirconexao())
            {
                string sql = passasql;
                try
                {
                    pesqAmigosgrid = new SqlCommand(sql, cnx);
                    pesqAmigosgrid.Parameters.Add(new SqlParameter("@Pega", param));
                    SqlDataAdapter adp = new SqlDataAdapter(pesqAmigosgrid);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    pesqAmigosgrid.ExecuteNonQuery();
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
                
                    try
                    {
                        if (Nome != "")
                        {
                            string sql = "select ID_Autor from Autores where Nome_Autor = @Pega";
                            pesqcod = new SqlCommand(sql, cnx);
                            pesqcod.Parameters.AddWithValue("@Pega", Nome);
                            //pesqInter.ExecuteNonQuery();
                            int cd = (int)pesqcod.ExecuteScalar();
                            return cd;
                        }
                        else
                        {
                            string Nomea = Nome;
                            Nomea = "Nada Consta";
                            string sql = "select ID_Autor from Autores where Nome_Autor = @Pega";
                            pesqcod = new SqlCommand(sql, cnx);
                            pesqcod.Parameters.AddWithValue("@Pega", Nomea);
                            //pesqInter.ExecuteNonQuery();
                            int cd = (int)pesqcod.ExecuteScalar();
                            return cd;
                        }
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
                    if (Cdam > 0)
                    {
                        pesqamigo = new SqlCommand(sql, cnx);
                        pesqamigo.Parameters.AddWithValue("@dt", data);
                        pesqamigo.Parameters.AddWithValue("@cdam", Cdam);
                        //pesqInter.ExecuteNonQuery();
                        int cd = (int)pesqamigo.ExecuteScalar();
                        return cd;
                    }
                    else
                    {
                        return 0;
                    }
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

        public int PesqCodItemEmp(string disco, int codam, string data)
        {
            SqlCommand PesqCodItemEmp = null;

            if (this.Abrirconexao())
            {
                string sql = "select Emprestimos.Num_Emprestimo from Itens_Emprestimo inner join emprestimos on Emprestimos.Num_Emprestimo = Itens_Emprestimo.Num_Emprestimo inner join  Discos on Itens_Emprestimo.Cod_Disco = Discos.Cod_Disco inner join Albuns on Discos.Id_Album = Albuns.ID_Album where (Albuns.Nome_Album = @Acha and Emprestimos.Cod_amigo = @cd and Emprestimos.Data_Emprestimo = @dt) ";
                try
                {
                    PesqCodItemEmp = new SqlCommand(sql, cnx);
                    PesqCodItemEmp.Parameters.AddWithValue("@acha", disco);
                    PesqCodItemEmp.Parameters.AddWithValue("@cd", codam);
                    PesqCodItemEmp.Parameters.AddWithValue("@dt", data);
                    //PesqCodItemEmp.Parameters.AddWithValue("@cdam", Cdam);
                    int cd = (int)PesqCodItemEmp.ExecuteScalar();
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

        public string PesqDataEmp(int codam)
        {
            SqlCommand pesqdt = null;

            if (this.Abrirconexao())
            {
                string sql = "select Data_Emprestimo from Emprestimos inner join Itens_Emprestimo on Emprestimos.Num_Emprestimo = Itens_Emprestimo.Num_Emprestimo where Emprestimos.Cod_Amigo = @cd and Itens_Emprestimo.Data_Devolucao is null";
                try
                {
                    pesqdt = new SqlCommand(sql, cnx);
                    pesqdt.Parameters.AddWithValue("@cd", codam);
                    //pesqdt.Parameters.AddWithValue("@cdam", Cdam);
                    //pesqInter.ExecuteNonQuery();
                    string dt = (string)pesqdt.ExecuteScalar();
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


        #endregion

        #region Remove e Edita

        public void excluiItensEmprestimo(List<string> chaves)
        {
            SqlCommand DeletaItensEmprestado = null;
            if (this.Abrirconexao())
            {
                try
                {
                    for (int i = 0; i < chaves.Count; i++)
                    {
                        DeletaItensEmprestado = new SqlCommand("Delete from Itens_Emprestimo where (Cod_Disco = @compara)  ", cnx);


                        DeletaItensEmprestado.Parameters.Add(new SqlParameter("@compara", chaves[i]));

                        DeletaItensEmprestado.ExecuteNonQuery();
                    }
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
            }
        }

        public List<string> pesqtemEmprestimo(List<string> itens)
        {
            SqlCommand pesqItensEmprestimo = null;
            if (this.Abrirconexao())
            {
                try
                {
                    List<string> passaEmprestimo = new List<string>();
                    SqlDataReader emprestado;
                    for (int i = 0; i < itens.Count; i++)
                    {
                        pesqItensEmprestimo = new SqlCommand("Select count(Cod_Disco) from Itens_Emprestimo where Cod_Disco =  @compara and Data_Devolucao is null", cnx);
                        pesqItensEmprestimo.Parameters.Add(new SqlParameter("@compara", itens[i].ToString()));
                        int j = (int)pesqItensEmprestimo.ExecuteScalar();
                        if (j != 0)
                        {
                            passaEmprestimo.Add(itens[i].ToString());
                        }
                    }

                    return passaEmprestimo;
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
                return null ;
            }
        }
        //public List<string> AchaItemEmprestimo1(List<string> chaves)
        //{
        //    SqlCommand DeletarItensEmprestimo = null;
        //    SqlCommand AchaDIscoItemEmpre = null;
        //    if (this.Abrirconexao())
        //    {
        //        try
        //        {
        //            List<string> armazena = new List<string>();
        //            for (int i = 0; i < chaves.Count; i++)
        //            {
        //                AchaDIscoItemEmpre = new SqlCommand("Select Count(*) from Itens_Emprestimo where (Cod_Disco = @compara and Data_Devolucao is null) ", cnx);


        //                AchaDIscoItemEmpre.Parameters.Add(new SqlParameter("@compara", chaves[i]));

        //                int dt = (int)AchaDIscoItemEmpre.ExecuteScalar();
        //                if (dt != 0)
        //                {
                           
        //                    armazena.Add(chaves[i].ToString());
        //                }
        //            }

        //            return armazena;
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
        //        return null;
        //    }
        //}

        public List<string> AchaItemEmprestimo(List<string> chaves)
        {
            SqlCommand DeletarItensEmprestimo = null;
            SqlCommand AchaDIscoItemEmpre = null;
            if (this.Abrirconexao())
            {
                try
                {
                    List<string> armazena = new List<string>();
                    for (int i = 0; i < chaves.Count; i++)
                    {
                        AchaDIscoItemEmpre = new SqlCommand("Select Count(*) from Itens_Emprestimo where (Cod_Disco = @compara and Data_Devolucao is null) ", cnx);


                        AchaDIscoItemEmpre.Parameters.Add(new SqlParameter("@compara", chaves[i]));

                        int dt = (int)AchaDIscoItemEmpre.ExecuteScalar();
                        if (dt != 0)
                        {
                        }
                        if (dt == 0)
                        {
                            DeletarItensEmprestimo = new SqlCommand("Delete from Itens_Emprestimo where Cod_Disco = @compara", cnx);
                            DeletarItensEmprestimo.Parameters.Add(new SqlParameter("@compara", chaves[i]));
                            DeletarItensEmprestimo.ExecuteNonQuery();
                            armazena.Add(chaves[i].ToString());
                        }
                    }
                    return armazena;
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

        public void removeItemBanco(List<string> chave)
        {
            SqlCommand DeletarDisco = null;
            if (this.Abrirconexao())
            {
                try
                {
                    //AchaItemEmprestimo(chave);
                    for(int i=0;i < chave.Count ; i++)
                    {
                        
                            DeletarDisco = new SqlCommand("Delete from Discos where Cod_Disco = @apagar", cnx);

                            DeletarDisco.Parameters.Add(new SqlParameter("@apagar", chave[i].ToString()));

                            DeletarDisco.ExecuteNonQuery();
                       
                    }
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    this.Fecharconexao();
                }
            }
            else
            {
                this.Fecharconexao();
            }
        }

        public void editaIntemBanco(ArrayList edita)
        {
            SqlCommand EditaDisco = null;
            if (this.Abrirconexao())
            {
                try
                {
                    

                        EditaDisco = new SqlCommand("Update Discos set "+
                            "Cod_Midia = @codMidia, ID_Autor = @idAutor, ID_Interprete = @idInterprete,"+
                            "ID_Album = @idAlbum, Data_Album = @dataAlbum ,Data_Compra = @dataCompra, "+
                    "Origem_Compra = @origem, Observ = @obs, Nota = @nota where Cod_Disco = @codDisco", cnx);

                        EditaDisco.Parameters.Add(new SqlParameter("@codMidia", edita[1].ToString()));
                        EditaDisco.Parameters.Add(new SqlParameter("@idAutor", edita[2].ToString()));
                        EditaDisco.Parameters.Add(new SqlParameter("@idInterprete", edita[3].ToString()));
                        EditaDisco.Parameters.Add(new SqlParameter("@idAlbum", edita[4].ToString()));
                        EditaDisco.Parameters.Add(new SqlParameter("@dataAlbum", Convert.ToDateTime(edita[5])));
                        EditaDisco.Parameters.Add(new SqlParameter("@dataCompra", Convert.ToDateTime(edita[6])));
                        EditaDisco.Parameters.Add(new SqlParameter("@dataAlbum", edita[5]));
                        EditaDisco.Parameters.Add(new SqlParameter("@dataCompra", edita[6]));
                        EditaDisco.Parameters.Add(new SqlParameter("@origem", edita[7].ToString()));
                        EditaDisco.Parameters.Add(new SqlParameter("@obs", edita[8].ToString()));
                        EditaDisco.Parameters.Add(new SqlParameter("@nota", edita[9].ToString()));
                        EditaDisco.Parameters.Add(new SqlParameter("@codDisco", edita[0].ToString()));

                        EditaDisco.ExecuteNonQuery();
                    
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
                this.Fecharconexao();
            }
        }
        #endregion
    }
}
