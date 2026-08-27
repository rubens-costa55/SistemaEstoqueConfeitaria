using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SistemaEstoqueConfeitaria
{
    public partial class TelaLogin : Form
    {
        // Controla se a senha está aparecendo
        private bool senhaVisivel = false;

        // Variáveis para mover a janela
        private bool arrastando = false;
        private Point posicaoMouseInicial;
        private Point posicaoFormInicial;

        public TelaLogin()
        {
            InitializeComponent();

            // ========================================================
            // EVENTOS
            // ========================================================

            Load += TelaLogin_Load;

            lblSair.Click += lblSair_Click;

            pbolhosenha.Click += pbolhosenha_Click;

            btnAcessar.Click += btnAcessar_Click;

            btnEsqueciSenha.Click += btnEsqueciSenha_Click;

            // Efeitos do botão
            btnAcessar.MouseEnter += btnAcessar_MouseEnter;
            btnAcessar.MouseLeave += btnAcessar_MouseLeave;
            btnAcessar.MouseDown += btnAcessar_MouseDown;
            btnAcessar.MouseUp += btnAcessar_MouseUp;

            // Mover janela pelo mouse
            MouseDown += Janela_MouseDown;
            MouseMove += Janela_MouseMove;
            MouseUp += Janela_MouseUp;

            panel1.MouseDown += Janela_MouseDown;
            panel1.MouseMove += Janela_MouseMove;
            panel1.MouseUp += Janela_MouseUp;

            lblLogin.MouseDown += Janela_MouseDown;
            lblLogin.MouseMove += Janela_MouseMove;
            lblLogin.MouseUp += Janela_MouseUp;

            // Enter funciona como botão Acessar
            AcceptButton = btnAcessar;
        }

        // ============================================================
        // CARREGAMENTO DA TELA
        // ============================================================

        private void TelaLogin_Load(object? sender, EventArgs e)
        {
            senhaVisivel = false;

            txtSenha.UseSystemPasswordChar = true;

            AtualizarIconeOlho();

            txtcpf.Focus();
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
                    // Senha aparecendo = olho fechado
                    pbolhosenha.Image =
                        Properties.Resources.ResourceManager.GetObject(
                            "olho_fechado"
                        ) as System.Drawing.Image;
                }
                else
                {
                    // Senha escondida = olho aberto
                    pbolhosenha.Image =
                        Properties.Resources.ResourceManager.GetObject(
                            "olho_aberto"
                        ) as System.Drawing.Image;
                }
            }
            catch
            {
                // Caso a imagem não seja encontrada,
                // o restante do sistema continua funcionando.
            }
        }

        // ============================================================
        // BOTÃO ACESSAR
        // ============================================================

        private void btnAcessar_Click(object? sender, EventArgs e)
        {
            // Remove pontuação do CPF
            string cpf = txtcpf.Text.Trim()
                .Replace(".", "")
                .Replace("-", "")
                .Replace(" ", "");

            string senha = txtSenha.Text.Trim();

            // ========================================================
            // VALIDAR CPF
            // ========================================================

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

            // ========================================================
            // VALIDAR SENHA
            // ========================================================

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

            // ========================================================
            // CONECTAR AO MYSQL
            // ========================================================

            try
            {
                conexao banco = new conexao();

                using MySqlConnection con = banco.Conectar();

                con.Open();

                // ====================================================
                // CONSULTAR USUÁRIO
                // ====================================================

                string sql =
                    "SELECT id, nome " +
                    "FROM login " +
                    "WHERE cpf = @cpf AND senha = @senha " +
                    "LIMIT 1;";

                using MySqlCommand cmd =
                    new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@senha", senha);

                using MySqlDataReader leitor =
                    cmd.ExecuteReader();

                // ====================================================
                // LOGIN CORRETO
                // ====================================================

                if (leitor.Read())
                {
                    string nome =
                        leitor["nome"]?.ToString() ?? "Usuário";

                    MessageBox.Show(
                        "Bem-vindo(a), " + nome + "!",
                        "Login realizado com sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    // =================================================
                    // QUANDO CRIARMOS O MENU PRINCIPAL,
                    // VAMOS COLOCAR AQUI:
                    //
                    // MenuPrincipal menu = new MenuPrincipal();
                    // menu.Show();
                    // this.Hide();
                    // =================================================
                }

                // ====================================================
                // LOGIN INCORRETO
                // ====================================================

                else
                {
                    MessageBox.Show(
                        "CPF ou senha inválidos.",
                        "Login não realizado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    txtSenha.Clear();

                    txtSenha.Focus();
                }
            }

            // ========================================================
            // ERRO DE BANCO
            // ========================================================

            catch (MySqlException ex)
            {
                MessageBox.Show(
                    "Não foi possível conectar ao banco de dados.\n\n" +
                    "Verifique se o MySQL está iniciado no XAMPP.\n\n" +
                    "Detalhes: " + ex.Message,
                    "Erro no banco de dados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            // ========================================================
            // OUTROS ERROS
            // ========================================================

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

        private void btnEsqueciSenha_Click(object? sender, EventArgs e)
        {
            
        }

        // ============================================================
        // EFEITOS DO BOTÃO ACESSAR
        // ============================================================

        private void btnAcessar_MouseEnter(
            object? sender,
            EventArgs e)
        {
            btnAcessar.BackColor =
                Color.FromArgb(190, 125, 108);
        }

        private void btnAcessar_MouseLeave(
            object? sender,
            EventArgs e)
        {
            btnAcessar.BackColor =
                Color.FromArgb(201, 142, 124);
        }

        private void btnAcessar_MouseDown(
            object? sender,
            MouseEventArgs e)
        {
            btnAcessar.BackColor =
                Color.FromArgb(170, 105, 90);
        }

        private void btnAcessar_MouseUp(
            object? sender,
            MouseEventArgs e)
        {
            btnAcessar.BackColor =
                Color.FromArgb(190, 125, 108);
        }

        // ============================================================
        // MOVER JANELA
        // ============================================================

        private void Janela_MouseDown(
            object? sender,
            MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
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

            Location = new Point(
                posicaoFormInicial.X + diferencaX,
                posicaoFormInicial.Y + diferencaY
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