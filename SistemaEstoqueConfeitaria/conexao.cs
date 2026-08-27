using MySql.Data.MySqlClient;

namespace SistemaEstoqueConfeitaria
{
    public class conexao
    {
        private readonly string stringConexao =
            "server=localhost;" +
            "port=3306;" +
            "user=root;" +
            "password=;" +
            "database=sistemaestoqueconfeitaria;";

        public MySqlConnection Conectar()
        {
            return new MySqlConnection(stringConexao);
        }
    }
}