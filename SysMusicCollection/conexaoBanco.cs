using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

   
    public class conexaoBanco
    {
        private static string consql = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\sysMusicColletion\BD\dbSysMusicColletion.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";

        private static SqlConnection cnx = null;

        public static SqlConnection Abrirconexao()
        {
            cnx = new SqlConnection(consql);
            try
            {
               cnx.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return cnx;
        }

        public static void Fecharconexao()
        {
            if (cnx != null)
                cnx.Close();
            
        }

        public static int Quantidade()
        {
            Abrirconexao();
            SqlCommand qtd = new SqlCommand();
            qtd.Connection = Abrirconexao();
            qtd.CommandText = "Select Count(*) from Amigos";

            int total = (int)qtd.ExecuteScalar();

            Fecharconexao();
            return total;
        }
    }
