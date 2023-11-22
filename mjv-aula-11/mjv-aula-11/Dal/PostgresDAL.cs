using System;
using System.Collections.Generic;
using Npgsql;

namespace mjv_aula_11.Dal
{
    public class PostgresDAL
    {
        private string strConnection = "Host=127.0.0.1;Port=5432;Username=postgres;Password=1234";
        private string dbName = "mjv";

        public PostgresDAL()
        {
            
            VerificarECriarBancoDeDados();
         
            strConnection += $";Database={dbName}";
        }

        private void VerificarECriarBancoDeDados()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection($"Host=127.0.0.1;Port=5432;Username=postgres;Password=1234"))
            {
                try
                {
                    conn.Open();
                    Console.WriteLine("Conexao aberta para verificar o banco de dados");

                    NpgsqlCommand sqlCommand = new NpgsqlCommand();
                    sqlCommand.CommandText = $"SELECT 1 FROM pg_database WHERE datname = '{dbName}'";
                    sqlCommand.CommandType = System.Data.CommandType.Text;
                    sqlCommand.Connection = conn;

                    object result = sqlCommand.ExecuteScalar();

                    if (result == null)
                    {
                        Console.WriteLine($"Banco de dados '{dbName}' não encontrado. Criando o banco de dados...");

                        sqlCommand.CommandText = $"CREATE DATABASE {dbName}";
                        sqlCommand.ExecuteNonQuery();
                        Console.WriteLine($"Banco de dados '{dbName}' criado com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine($"Banco de dados '{dbName}' encontrado.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                finally
                {
                    conn.Close();
                    Console.WriteLine("Connection closed");
                }
            }
        }

        public List<Models.Alunos> ListarAlunos()
        {
            List<Models.Alunos> listaAlunos = new List<Models.Alunos>();

            using (NpgsqlConnection conn = new NpgsqlConnection(strConnection))
            {
                conn.Open();
                Console.WriteLine("Conexao aberta");

                NpgsqlCommand sqlCommand = new NpgsqlCommand();
                sqlCommand.CommandText = "select * from Aulas.Alunos";
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.Connection = conn;

                NpgsqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Models.Alunos aluno = new Models.Alunos();
                    if (!reader.IsDBNull(1))
                        aluno.Nome = reader.GetString(1);

                    Console.Write(reader.GetString(1));
                    Console.Write(" " + reader.GetString(2));
                    Console.WriteLine("");
                }
            }

            return listaAlunos;
        }

        public bool InserirAluno(string nome, string sobrenome)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(strConnection))
            {
                try
                {
                    conn.Open();
                    Console.WriteLine("Conexao aberta");

                    NpgsqlCommand sqlCommand = new NpgsqlCommand();
                    sqlCommand.CommandText = "INSERT INTO Aulas.Alunos (nome, sobrenome) VALUES (@nome, @sobrenome)";
                    sqlCommand.CommandType = System.Data.CommandType.Text;
                    sqlCommand.Connection = conn;

                    sqlCommand.Parameters.AddWithValue("@nome", nome);
                    sqlCommand.Parameters.AddWithValue("@sobrenome", sobrenome);

                    int linhasAfetadas = sqlCommand.ExecuteNonQuery();
                    return linhasAfetadas > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    return false;
                }
                finally
                {
                    conn.Close();
                    Console.WriteLine("Connection closed");
                }
            }
        }
    }
}
