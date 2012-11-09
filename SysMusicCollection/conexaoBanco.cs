using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SysMusicCollection
{
    public class conexaoBanco
    {
        SqlConnection cnx = new SqlConnection();

        //static void Main(string[] args)
        //{
            
            
        //}
            public void abrir()
            {
                cnx.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\sysMusicColletion\BD\dbSysMusicColletion.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
                try
                {
                    cnx.Open();

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            public void fechar()

            {
                if (cnx != null)
                    cnx.Close();
            }
        }
    }

