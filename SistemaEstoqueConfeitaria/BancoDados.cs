using Microsoft.Data.Sqlite;
using System;
using System.IO;

namespace SistemaEstoqueConfeitaria
{
    public static class BancoDados
    {
        private static readonly string pastaDados =
            Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.LocalApplicationData
                ),
                "ThayaraPolizelEstoque"
            );

        private static readonly string caminhoBanco =
            Path.Combine(pastaDados, "estoque.db");

        private static readonly string stringConexao =
            $"Data Source={caminhoBanco}";

        public static SqliteConnection Conectar()
        {
            if (!Directory.Exists(pastaDados))
            {
                Directory.CreateDirectory(pastaDados);
            }

            return new SqliteConnection(stringConexao);
        }

        public static void InicializarBanco()
        {
            if (!Directory.Exists(pastaDados))
            {
                Directory.CreateDirectory(pastaDados);
            }

            using SqliteConnection conexao = Conectar();

            conexao.Open();

            string sql = @"
                CREATE TABLE IF NOT EXISTS login
                (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    nome TEXT NOT NULL,
                    cpf TEXT NOT NULL UNIQUE,
                    senha TEXT NOT NULL,
                    data_cadastro TEXT DEFAULT CURRENT_TIMESTAMP
                );

                CREATE TABLE IF NOT EXISTS insumos
                (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    nome TEXT NOT NULL,
                    categoria TEXT NOT NULL,
                    unidade TEXT NOT NULL,
                    quantidade_atual REAL NOT NULL DEFAULT 0,
                    estoque_minimo REAL NOT NULL DEFAULT 0,
                    valor_unitario REAL NOT NULL DEFAULT 0,
                    fornecedor TEXT,
                    observacao TEXT,
                    ativo INTEGER NOT NULL DEFAULT 1,
                    data_cadastro TEXT NOT NULL DEFAULT CURRENT_TIMESTAMP,
                    data_atualizacao TEXT
                );

                CREATE TABLE IF NOT EXISTS movimentacoes_estoque
                (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    insumo_id INTEGER NOT NULL,
                    tipo TEXT NOT NULL,
                    quantidade REAL NOT NULL,
                    estoque_anterior REAL NOT NULL,
                    estoque_novo REAL NOT NULL,
                    motivo TEXT NOT NULL,
                    observacao TEXT,
                    data_movimentacao TEXT NOT NULL DEFAULT CURRENT_TIMESTAMP,

                    FOREIGN KEY (insumo_id)
                        REFERENCES insumos(id)
                );
            ";

            using SqliteCommand comando =
                new SqliteCommand(sql, conexao);

            comando.ExecuteNonQuery();

            CriarUsuarioInicial(conexao);
        }

        private static void CriarUsuarioInicial(
            SqliteConnection conexao)
        {
            string verificar = @"
                SELECT COUNT(*)
                FROM login;
            ";

            using SqliteCommand cmdVerificar =
                new SqliteCommand(verificar, conexao);

            long quantidade =
                (long)cmdVerificar.ExecuteScalar()!;

            if (quantidade == 0)
            {
                string inserir = @"
                    INSERT INTO login
                    (
                        nome,
                        cpf,
                        senha
                    )
                    VALUES
                    (
                        @nome,
                        @cpf,
                        @senha
                    );
                ";

                using SqliteCommand cmdInserir =
                    new SqliteCommand(inserir, conexao);

                cmdInserir.Parameters.AddWithValue(
                    "@nome",
                    "Administrador"
                );

                cmdInserir.Parameters.AddWithValue(
                    "@cpf",
                    "12345678900"
                );

                cmdInserir.Parameters.AddWithValue(
                    "@senha",
                    "1234"
                );

                cmdInserir.ExecuteNonQuery();
            }
        }

        public static string ObterCaminhoBanco()
        {
            return caminhoBanco;
        }
    }
}