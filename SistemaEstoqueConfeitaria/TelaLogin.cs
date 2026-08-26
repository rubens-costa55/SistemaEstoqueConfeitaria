using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaEstoqueConfeitaria
{
    public partial class TelaLogin : Form
    {
        private bool senhaVisivel = false;

        // Variáveis para mover a janela sem borda
        private bool arrastando = false;
        private Point posicaoMouseInicial;
        private Point posicaoFormInicial;

        public TelaLogin()
        {
            InitializeComponent();

            // Eventos da tela
            Load += TelaLogin_Load;

            // Botões
            lblSair.Click += lblSair_Click;
            pbolhosenha.Click += pbolhosenha_Click;
            btnAcessar.Click += btnAcessar_Click;
            btnEsqueciSenha.Click += btnEsqueciSenha_Click;

            // Efeito do botão Acessar
            btnAcessar.MouseEnter += btnAcessar_MouseEnter;
            btnAcessar.MouseLeave += btnAcessar_MouseLeave;
            btnAcessar.MouseDown += btnAcessar_MouseDown;
            btnAcessar.MouseUp += btnAcessar_MouseUp;

            // Permite mover a janela pelo mouse
            MouseDown += Janela_MouseDown;
            MouseMove += Janela_MouseMove;
            MouseUp += Janela_MouseUp;

            panel1.MouseDown += Janela_MouseDown;
            panel1.MouseMove += Janela_MouseMove;
            panel1.MouseUp += Janela_MouseUp;

            lblLogin.MouseDown += Janela_MouseDown;
            lblLogin.MouseMove += Janela_MouseMove;
            lblLogin.MouseUp += Janela_MouseUp;

            // Enter aciona o botão Acessar
            AcceptButton = btnAcessar;
        }

        // ============================================================
        // CARREGAMENTO DA TELA
        // ============================================================

        private void TelaLogin_Load(object? sender, EventArgs e)
        {
            senhaVisivel = false;

            txtSenha.UseSystemPasswordChar = true;

            txtcpf.Focus();

            AtualizarIconeOlho();
        }

        // ============================================================
        // BOTÃO X
        // ============================================================

        private void lblSair_Click(object? sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "Deseja realmente sair do sistema?",
                "Sair",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // ============================================================
        // MOSTRAR / ESCONDER SENHA
        // ============================================================

        private void pbolhosenha_Click(object? sender, EventArgs e)
        {
            senhaVisivel = !senhaVisivel;

            txtSenha.UseSystemPasswordChar = !senhaVisivel;

            AtualizarIconeOlho();

            txtSenha.Focus();

            txtSenha.SelectionStart = txtSenha.Text.Length;
        }

        private void AtualizarIconeOlho()
        {
            try
            {
                if (senhaVisivel)
                {
                    Image? imagemAberta =
                        Properties.Resources.ResourceManager.GetObject(
                            "olho aberto") as Image;

                    if (imagemAberta != null)
                    {
                        pbolhosenha.Image = imagemAberta;
                    }
                }
                else
                {
                    Image? imagemFechada =
                        Properties.Resources.ResourceManager.GetObject(
                            "olho fechado") as Image;

                    if (imagemFechada != null)
                    {
                        pbolhosenha.Image = imagemFechada;
                    }
                }
            }
            catch
            {
                // Se os ícones ainda não estiverem nos Resources,
                // o sistema continua funcionando normalmente.
            }
        }

        // ============================================================
        // BOTÃO ACESSAR
        // ============================================================

        private void btnAcessar_Click(object? sender, EventArgs e)
        {
            string cpf = txtcpf.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (string.IsNullOrWhiteSpace(cpf))
            {
                MessageBox.Show(
                    "Digite o CPF para continuar.",
                    "Campo obrigatório",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtcpf.Focus();

                return;
            }

            if (string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show(
                    "Digite a senha para continuar.",
                    "Campo obrigatório",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtSenha.Focus();

                return;
            }

            // --------------------------------------------------------
            // TEMPORÁRIO
            // --------------------------------------------------------
            // O banco MySQL ainda será criado.
            // Depois vamos substituir esta mensagem pelo login real.
            // --------------------------------------------------------

            MessageBox.Show(
                "Login preenchido corretamente!\n\n" +
                "Na próxima etapa vamos conectar esta tela ao banco de dados.",
                "Sistema de Estoque",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // ============================================================
        // ESQUECI MINHA SENHA
        // ============================================================

        private void btnEsqueciSenha_Click(object? sender, EventArgs e)
        {
            MessageBox.Show(
                "A tela de redefinição de senha será criada em seguida.",
                "Redefinir senha",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // ============================================================
        // EFEITOS DO BOTÃO ACESSAR
        // ============================================================

        private void btnAcessar_MouseEnter(object? sender, EventArgs e)
        {
            btnAcessar.BackColor =
                Color.FromArgb(190, 125, 108);
        }

        private void btnAcessar_MouseLeave(object? sender, EventArgs e)
        {
            btnAcessar.BackColor =
                Color.FromArgb(201, 142, 124);
        }

        private void btnAcessar_MouseDown(object? sender, MouseEventArgs e)
        {
            btnAcessar.BackColor =
                Color.FromArgb(170, 105, 90);
        }

        private void btnAcessar_MouseUp(object? sender, MouseEventArgs e)
        {
            btnAcessar.BackColor =
                Color.FromArgb(190, 125, 108);
        }

        // ============================================================
        // MOVER A JANELA
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

            Point diferenca = new Point(
                Cursor.Position.X - posicaoMouseInicial.X,
                Cursor.Position.Y - posicaoMouseInicial.Y
            );

            Location = new Point(
                posicaoFormInicial.X + diferenca.X,
                posicaoFormInicial.Y + diferenca.Y
            );
        }

        private void Janela_MouseUp(object? sender, MouseEventArgs e)
        {
            arrastando = false;
        }
    }
}