using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaEstoqueConfeitaria
{
    public partial class MenuPrincipal : Form
    {
        private bool arrastando = false;
        private Point posicaoMouseInicial;
        private Point posicaoFormInicial;

        public MenuPrincipal()
        {
            InitializeComponent();

            ConfigurarEventos();
        }

        private void ConfigurarEventos()
        {
            // ========================================================
            // MENU LATERAL
            // ========================================================

            btnMenuPrincipal.Click += btnMenuPrincipal_Click;
            btnCadastroInsumos.Click += btnCadastroInsumos_Click;
            btnMovimentarEstoque.Click += btnMovimentarEstoque_Click;
            btnEstoqueAtual.Click += btnEstoqueAtual_Click;
            btnListaCompras.Click += btnListaCompras_Click;
            btnHistorico.Click += btnHistorico_Click;
            btnSair.Click += btnSair_Click;

            // ========================================================
            // CARDS
            // ========================================================

            btnAbrirEstoque.Click += btnAbrirEstoque_Click;
            btnAbrirMovimentacao.Click += btnAbrirMovimentacao_Click;
            btnAbrirListaCompras.Click += btnAbrirListaCompras_Click;

            // ========================================================
            // MOVER JANELA
            // ========================================================

            MouseDown += Janela_MouseDown;
            MouseMove += Janela_MouseMove;
            MouseUp += Janela_MouseUp;

            lblTitulo.MouseDown += Janela_MouseDown;
            lblTitulo.MouseMove += Janela_MouseMove;
            lblTitulo.MouseUp += Janela_MouseUp;
        }

        // ============================================================
        // MENU PRINCIPAL
        // ============================================================

        private void btnMenuPrincipal_Click(object? sender, EventArgs e)
        {
            // Já estamos no Menu Principal.
        }

        // ============================================================
        // CADASTRO DE INSUMOS
        // ============================================================

        private void btnCadastroInsumos_Click(object? sender, EventArgs e)
        {
            CadastroInsumos tela = new CadastroInsumos();

            tela.Show();

            this.Close();

            // A tela Cadastro de Insumos será criada na próxima etapa.
        }

        // ============================================================
        // MOVIMENTAR ESTOQUE
        // ============================================================

        private void btnMovimentarEstoque_Click(object? sender, EventArgs e)
        {
            // A tela Movimentar Estoque será criada depois.
        }

        // ============================================================
        // ESTOQUE ATUAL
        // ============================================================

        private void btnEstoqueAtual_Click(object? sender, EventArgs e)
        {
            // A tela Estoque Atual será criada depois.
        }

        // ============================================================
        // LISTA DE COMPRAS
        // ============================================================

        private void btnListaCompras_Click(object? sender, EventArgs e)
        {
            // A tela Lista de Compras será criada depois.
        }

        // ============================================================
        // HISTÓRICO
        // ============================================================

        private void btnHistorico_Click(object? sender, EventArgs e)
        {
            // A tela Histórico será criada depois.
        }

        // ============================================================
        // CARD - ESTOQUE ATUAL
        // ============================================================

        private void btnAbrirEstoque_Click(object? sender, EventArgs e)
        {
            // Será conectado à tela Estoque Atual.
        }

        // ============================================================
        // CARD - MOVIMENTAÇÃO
        // ============================================================

        private void btnAbrirMovimentacao_Click(object? sender, EventArgs e)
        {
            // Será conectado à tela Movimentar Estoque.
        }

        // ============================================================
        // CARD - LISTA DE COMPRAS
        // ============================================================

        private void btnAbrirListaCompras_Click(object? sender, EventArgs e)
        {
            // Será conectado à tela Lista de Compras.
        }

        // ============================================================
        // SAIR / VOLTAR AO LOGIN
        // ============================================================

        private void btnSair_Click(object? sender, EventArgs e)
        {
            TelaLogin login = new TelaLogin();

            login.Show();

            this.Close();
        }

        // ============================================================
        // MOVER JANELA
        // ============================================================

        private void Janela_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            arrastando = true;

            posicaoMouseInicial = Cursor.Position;

            posicaoFormInicial = Location;
        }

        private void Janela_MouseMove(object? sender, MouseEventArgs e)
        {
            if (!arrastando)
            {
                return;
            }

            int diferencaX =
                Cursor.Position.X - posicaoMouseInicial.X;

            int diferencaY =
                Cursor.Position.Y - posicaoMouseInicial.Y;

            Location = new Point(
                posicaoFormInicial.X + diferencaX,
                posicaoFormInicial.Y + diferencaY
            );
        }

        private void Janela_MouseUp(object? sender, MouseEventArgs e)
        {
            arrastando = false;
        }
    }
}