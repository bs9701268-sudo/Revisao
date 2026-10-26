
using Microsoft.Data.Sqlite;
using Nomes;
using System.Text.Json;
namespace Revisao.Infraestrutura
{
    public class BeatrizRepository
    {
        private const string MeuBanco = "Data Source=Beatriz.db";

        public static void Inicializar()
        {
            using var conexao = new SqliteConnection(MeuBanco);
            conexao.Open();

            using var comando = conexao.CreateCommand();

            comando.CommandText = @"
                CREATE TABLE IF NOT EXISTS Beatriz (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nome TEXT NOT NULL,
                    Apelido TEXT NOT NULL,
                    Idade INTEGER NOT NULL,
                    Sexo TEXT NOT NULL,
                    Habilidades TEXT NOT NULL
                );
            ";

            comando.ExecuteNonQuery();
        }

        public static void Adicionar(Beatriz pessoa)
        {
            using var conexao = new SqliteConnection(MeuBanco);
            conexao.Open();

            using var comando = conexao.CreateCommand();

            comando.CommandText = @"
                INSERT INTO Beatriz
                (Nome, Apelido, Idade, Sexo, Habilidades)
                VALUES
                ($nome, $apelido, $idade, $sexo, $habilidades);
            ";

            comando.Parameters.AddWithValue("$nome", pessoa.Nome);
            comando.Parameters.AddWithValue("$apelido", pessoa.Apelido);
            comando.Parameters.AddWithValue("$idade", pessoa.Idade);
            comando.Parameters.AddWithValue("$sexo", pessoa.Sexo);
            comando.Parameters.AddWithValue(
                "$habilidades",
                JsonSerializer.Serialize(pessoa.Habilidades)
            );

            comando.ExecuteNonQuery();
        }

        public static List<Beatriz> Listar()
        {
            using var conexao = new SqliteConnection(MeuBanco);
            conexao.Open();

            using var comando = conexao.CreateCommand();

            comando.CommandText = @"
                SELECT Id, Nome, Apelido, Idade, Sexo, Habilidades
                FROM Beatriz
                ORDER BY Id;
            ";

            using var leitor = comando.ExecuteReader();

            List<Beatriz> pessoas = new List<Beatriz>();

            while (leitor.Read())
            {
                Beatriz pessoa = new Beatriz();

                pessoa.Id = leitor.GetInt32(0);
                pessoa.Nome = leitor.GetString(1);
                pessoa.Apelido = leitor.GetString(2);
                pessoa.Idade = leitor.GetInt32(3);
                pessoa.Sexo = leitor.GetString(4);

                pessoa.Habilidades =
                    JsonSerializer.Deserialize<List<string>>(
                        leitor.GetString(5)
                    ) ?? new List<string>();

                pessoas.Add(pessoa);
            }

            return pessoas;
        }
    }
}
