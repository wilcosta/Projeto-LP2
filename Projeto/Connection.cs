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
        private SqlConnection con; // Declaração de uma variável para a conexão com o banco de dados.
        private readonly string DataBase = "MyDatabase"; // Nome do banco de dados a ser utilizado.
        private bool disposed = false; // Variável de controle para rastrear se o objeto já foi liberado.

        public Connection()
        {
            con = new SqlConnection(BuildConnectionString()); // Inicializa a conexão utilizando a string de conexão criada no método BuildConnectionString.
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
                con.Open(); // Abre a conexão com o banco de dados se ela não estiver aberta.
            }
            return con; // Retorna a conexão (aberta ou já existente).
        }

        public void CloseConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close(); // Fecha a conexão com o banco de dados se estiver aberta.
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
                        con.Dispose(); // Libera os recursos da conexão com o banco de dados.
                        con = null; // Define a conexão como nula para evitar uso posterior.
                    }
                }
                disposed = true; // Marca o objeto como liberado.
            }
        }

        internal SqlConnection ReturnConnection()
        {
            return new SqlConnection(BuildConnectionString()); // Cria e retorna uma nova instância de SqlConnection com a string de conexão.
        }
    }
}

