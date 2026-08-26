using System;
using System.Windows.Forms;

namespace SistemaEstoqueConfeitaria
{
    public partial class frmCarregamento : Form
    {
        private int progresso = 0;
        private int pontos = 0;

        public frmCarregamento()
        {
            InitializeComponent();

            this.Load += frmCarregamento_Load;
            tCarregar.Tick += tCarregar_Tick;
            tPontos.Tick += tPontos_Tick;
        }

        private void frmCarregamento_Load(object? sender, EventArgs e)
        {
            progresso = 0;
            pontos = 0;

            panel2.Left = 0;
            panel2.Top = 0;
            panel2.Width = 0;
            panel2.Height = panelbarrafundo.ClientSize.Height;

            panel2.BringToFront();

            lbcarregando.Text = "Carregando sistema";
            lblrodape.Text = "Preparando seu ambiente...";

            tCarregar.Start();
            tPontos.Start();
        }

        private void tCarregar_Tick(object? sender, EventArgs e)
        {
            progresso += 2;

            if (progresso > 100)
                progresso = 100;

            int larguraMaxima = panelbarrafundo.ClientSize.Width;

            panel2.Width = larguraMaxima * progresso / 100;

            if (progresso >= 100)
            {
                tCarregar.Stop();
                tPontos.Stop();

                AbrirLogin();
            }
        }

        private void tPontos_Tick(object? sender, EventArgs e)
        {
            pontos++;

            if (pontos > 3)
                pontos = 0;

            lbcarregando.Text =
                "Carregando sistema" +
                new string('.', pontos);
        }

        private void AbrirLogin()
        {
            TelaLogin login = new TelaLogin();
            login.Show();

            this.Hide();
        }
    }
}