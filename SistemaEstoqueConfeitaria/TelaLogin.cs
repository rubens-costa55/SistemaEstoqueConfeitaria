using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace SistemaEstoqueConfeitaria
{
    public partial class TelaLogin : Form
    {
        // ============================================================
        // VARIÁVEIS
        // ============================================================

        private bool senhaVisivel = false;

        private bool arrastando = false;
        private Point posicaoMouseInicial;
        private Point posicaoFormInicial;

        // ============================================================
        // CONSTRUTOR
        // ============================================================

        public TelaLogin()
        {
            InitializeComponent();

            ConfigurarEventos();

            ConfigurarSenhaInicial();
        }

        // ============================================================
        // CONFIGURAR EVENTOS
        // ============================================================

        private void ConfigurarEventos()
        {
            // BOTÃO ACESSAR
            btnAcessar.Click -= btnAcessar_Click;
            btnAcessar.Click += btnAcessar_Click;

            // ESQUECI MINHA SENHA
            btnEsqueciSenha.Click -= btnEsqueciSenha_Click;
            btnEsqueciSenha.Click += btnEsqueciSenha_Click;

            // OLHO DA SENHA
            pbolhosenha.Click -= pbolhosenha_Click;
            pbolhosenha.Click += pbolhosenha_Click;

            // SAIR
            lblSair.Click -= lblSair_Click;
            lblSair.Click += lblSair_Click;

            // CPF
            txtcpf.KeyPress -= txtcpf_KeyPress;
            txtcpf.KeyPress += txtcpf_KeyPress;

            // ENTER PARA FAZER LOGIN
            txtSenha.KeyDown -= txtSenha_KeyDown;
            txtSenha.KeyDown += txtSenha_KeyDown;

            // EFEITO BOTÃO ACESSAR
            btnAcessar.MouseEnter -= btnAcessar_MouseEnter;
            btnAcessar.MouseEnter += btnAcessar_MouseEnter;

            btnAcessar.MouseLeave -= btnAcessar_MouseLeave;
            btnAcessar.MouseLeave += btnAcessar_MouseLeave;

            // EFEITO ESQUECI SENHA
            btnEsqueciSenha.MouseEnter -= btnEsqueciSenha_MouseEnter;
            btnEsqueciSenha.MouseEnter += btnEsqueciSenha_MouseEnter;

            btnEsqueciSenha.MouseLeave -= btnEsqueciSenha_MouseLeave;
            btnEsqueciSenha.MouseLeave += btnEsqueciSenha_MouseLeave;

            // ========================================================
            // MOVER JANELA
            // ========================================================

            MouseDown -= Janela_MouseDown;
            MouseDown += Janela_MouseDown;

            MouseMove -= Janela_MouseMove;
            MouseMove += Janela_MouseMove;

            MouseUp -= Janela_MouseUp;
            MouseUp += Janela_MouseUp;

            panel1.MouseDown -= Janela_MouseDown;
            panel1.MouseDown += Janela_MouseDown;

            panel1.MouseMove -= Janela_MouseMove;
            panel1.MouseMove += Janela_MouseMove;

            panel1.MouseUp -= Janela_MouseUp;
            panel1.MouseUp += Janela_MouseUp;

            lblLogin.MouseDown -= Janela_MouseDown;
            lblLogin.MouseDown += Janela_MouseDown;

            lblLogin.MouseMove -= Janela_MouseMove;
            lblLogin.MouseMove += Janela_MouseMove;

            lblLogin.MouseUp -= Janela_MouseUp;
            lblLogin.MouseUp += Janela_MouseUp;
        }

        // ============================================================
        // CONFIGURAR SENHA AO ABRIR
        // ============================================================

        private void ConfigurarSenhaInicial()
        {
            senhaVisivel = false;

            txtSenha.PasswordChar = '\0';

            txtSenha.UseSystemPasswordChar = true;

            pbolhosenha.SizeMode =
                PictureBoxSizeMode.Zoom;

            pbolhosenha.Cursor =
                Cursors.Hand;

            AtualizarImagemOlho();
        }

        // ============================================================
        // MOSTRAR / ESCONDER SENHA
        // ============================================================

        private void pbolhosenha_Click(
            object? sender,
            EventArgs e)
        {
            senhaVisivel = !senhaVisivel;

            if (senhaVisivel)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
            }

            AtualizarImagemOlho();

            txtSenha.Focus();

            txtSenha.SelectionStart =
                txtSenha.Text.Length;
        }

        // ============================================================
        // ATUALIZAR IMAGEM DO OLHO
        // ============================================================

        private void AtualizarImagemOlho()
        {
            try
            {
                if (senhaVisivel)
                {
                    pbolhosenha.Image =
                        Properties.Resources.ResourceManager
                        .GetObject("olho fechado") as Image;
                }
                else
                {
                    pbolhosenha.Image =
                        Properties.Resources.ResourceManager
                        .GetObject("olho aberto") as Image;
                }
            }
            catch
            {
                // O mostrar/esconder continua funcionando
                // mesmo se houver problema com a imagem.
            }
        }

        // ============================================================
        // BOTÃO ACESSAR
        // ============================================================

        private void btnAcessar_Click(
            object? sender,
            EventArgs e)
        {
            string cpf =
                LimparCpf(txtcpf.Text);

            string senha =
                txtSenha.Text;

            // ========================================================
            // VALIDAR CPF
            // ========================================================

            if (string.IsNullOrWhiteSpace(cpf))
            {
                MessageBox.Show(
                    "Digite o CPF.",
                    "Campo obrigatório",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtcpf.Focus();

                return;
            }

            if (cpf.Length != 11)
            {
                MessageBox.Show(
                    "Digite um CPF com 11 números.",
                    "CPF inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtcpf.Focus();

                return;
            }

            // ========================================================
            // VALIDAR SENHA
            // ========================================================

            if (string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show(
                    "Digite a senha.",
                    "Campo obrigatório",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtSenha.Focus();

                return;
            }

            // ========================================================
            // CONSULTAR BANCO SQLITE
            // ========================================================

            try
            {
                using SqliteConnection con =
                    BancoDados.Conectar();

                con.Open();

                string sql =
                    @"SELECT id
                      FROM login
                      WHERE cpf = @cpf
                      AND senha = @senha
                      LIMIT 1;";

                using SqliteCommand cmd =
                    new SqliteCommand(
                        sql,
                        con
                    );

                cmd.Parameters.AddWithValue(
                    "@cpf",
                    cpf
                );

                cmd.Parameters.AddWithValue(
                    "@senha",
                    senha
                );

                object? resultado =
                    cmd.ExecuteScalar();

                // ====================================================
                // LOGIN CORRETO
                // ====================================================

                if (resultado != null)
                {
                    MenuPrincipal menu =
                        new MenuPrincipal();

                    menu.Show();

                    this.Hide();
                }

                // ====================================================
                // LOGIN INCORRETO
                // ====================================================

                else
                {
                    MessageBox.Show(
                        "CPF ou senha incorretos.",
                        "Acesso não autorizado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    txtSenha.Clear();

                    senhaVisivel = false;

                    txtSenha.UseSystemPasswordChar =
                        true;

                    AtualizarImagemOlho();

                    txtSenha.Focus();
                }
            }

            catch (SqliteException ex)
            {
                MessageBox.Show(
                    "Não foi possível acessar o banco de dados.\n\n" +
                    ex.Message,
                    "Erro no banco de dados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocorreu um erro ao realizar o login.\n\n" +
                    ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ============================================================
        // ESQUECI MINHA SENHA
        // ============================================================

        private void btnEsqueciSenha_Click(
            object? sender,
            EventArgs e)
        {
            RedefinirSenha tela =
                new RedefinirSenha();

            tela.Show();

            this.Hide();
        }

        // ============================================================
        // ENTER PARA ENTRAR
        // ============================================================

        private void txtSenha_KeyDown(
            object? sender,
            KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAcessar.PerformClick();

                e.SuppressKeyPress = true;
            }
        }

        // ============================================================
        // LIMPAR CPF
        // ============================================================

        private string LimparCpf(
            string cpf)
        {
            return cpf
                .Replace(".", "")
                .Replace("-", "")
                .Replace(" ", "")
                .Trim();
        }

        // ============================================================
        // CPF - ACEITAR SOMENTE NÚMEROS, PONTO E TRAÇO
        // ============================================================

        private void txtcpf_KeyPress(
            object? sender,
            KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.' &&
                e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        // ============================================================
        // EFEITOS DOS BOTÕES
        // ============================================================

        private void btnAcessar_MouseEnter(
            object? sender,
            EventArgs e)
        {
            btnAcessar.BackColor =
                Color.FromArgb(
                    184,
                    112,
                    121
                );
        }

        private void btnAcessar_MouseLeave(
            object? sender,
            EventArgs e)
        {
            btnAcessar.BackColor =
                Color.FromArgb(
                    201,
                    142,
                    124
                );
        }

        private void btnEsqueciSenha_MouseEnter(
            object? sender,
            EventArgs e)
        {
            btnEsqueciSenha.BackColor =
                Color.FromArgb(
                    184,
                    112,
                    121
                );
        }

        private void btnEsqueciSenha_MouseLeave(
            object? sender,
            EventArgs e)
        {
            btnEsqueciSenha.BackColor =
                Color.FromArgb(
                    201,
                    142,
                    124
                );
        }

        // ============================================================
        // SAIR
        // ============================================================

        private void lblSair_Click(
            object? sender,
            EventArgs e)
        {
            DialogResult resposta =
                MessageBox.Show(
                    "Deseja fechar o sistema?",
                    "Sair",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (resposta ==
                DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // ============================================================
        // MOVER JANELA
        // ============================================================

        private void Janela_MouseDown(
            object? sender,
            MouseEventArgs e)
        {
            if (e.Button !=
                MouseButtons.Left)
            {
                return;
            }

            arrastando = true;

            posicaoMouseInicial =
                Cursor.Position;

            posicaoFormInicial =
                Location;
        }

        private void Janela_MouseMove(
            object? sender,
            MouseEventArgs e)
        {
            if (!arrastando)
            {
                return;
            }

            int diferencaX =
                Cursor.Position.X -
                posicaoMouseInicial.X;

            int diferencaY =
                Cursor.Position.Y -
                posicaoMouseInicial.Y;

            Location =
                new Point(
                    posicaoFormInicial.X +
                    diferencaX,

                    posicaoFormInicial.Y +
                    diferencaY
                );
        }

        private void Janela_MouseUp(
            object? sender,
            MouseEventArgs e)
        {
            arrastando = false;
        }
    }
}