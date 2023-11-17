using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    internal class Connection : IDisposable
    {
        // Declaração de uma variável para a conexão com o banco de dados. Nome do banco de dados a ser utilizado.
        // Variável de controle para rastrear se o objeto já foi liberado.

        private SqlConnection con; 
        private readonly string DataBase = "MyDatabase"; 
        private bool disposed = false; 

        public Connection()
        {
            // Inicializa a conexão utilizando a string de conexão criada no método BuildConnectionString.
            con = new SqlConnection(BuildConnectionString()); 
        }

        private string BuildConnectionString()
        {
            // Método para construir e retornar a string de conexão com o banco de dados.
            return $@"Data Source={Environment.MachineName}\SQLEXPRESS;Initial Catalog={DataBase};Integrated Security=true";
        }

        public SqlConnection OpenConnection()
        {
            if (con.State != System.Data.ConnectionState.Open)
            {
                // Abre a conexão com o banco de dados se ela não estiver aberta.
                con.Open(); 
            }

            // Retorna a conexão (aberta ou já existente).
            return con; 
        }

        public void CloseConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                // Fecha a conexão com o banco de dados se estiver aberta.
                con.Close(); 
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    if (con != null)
                    {
                        // Libera os recursos da conexão com o banco de dados.
                        con.Dispose();

                        // Define a conexão como nula para evitar uso posterior.
                        con = null; 
                    }
                }

                // Marca o objeto como liberado.
                disposed = true; 
            }
        }

        internal SqlConnection ReturnConnection()
        {
            // Cria e retorna uma nova instância de SqlConnection com a string de conexão.
            return new SqlConnection(BuildConnectionString()); 
        }
    }
}

