using System.Data;
using System;
using MySql.Data.MySqlClient;

namespace CamadaDeDados
{
    class Conexao
    {
        string string_conexao = "Persist Security Info = false; server = localhost; database = communicalt; user = root; pwd=;"; //altere o nome do banco de dados

        MySqlConnection conexao;

        public void Conectar()
        {
            try
            {
                conexao = new MySqlConnection(string_conexao);
                conexao.Open();
            }

            catch(MySqlException ex)
            {
                throw new Exception("A Conexão com o banco de dados falhou");
            }
        }

        public void ExecutarComando(string sql)
        {
            try
            {
                Conectar();
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.ExecuteNonQuery();
                conexao.Close();
            }

            catch (MySqlException ex)
            {
                throw new Exception("Não foi possível executar o comando solicitado.");

            }

            finally
            {
                conexao.Close();
            }
        }

        
    }
}
