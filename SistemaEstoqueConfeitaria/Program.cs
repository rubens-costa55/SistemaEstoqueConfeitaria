namespace SistemaEstoqueConfeitaria
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Cria a pasta, o banco e as tabelas automaticamente
            BancoDados.InicializarBanco();

            // Abre a tela de carregamento normalmente
            Application.Run(new frmCarregamento());
        }
    }
}