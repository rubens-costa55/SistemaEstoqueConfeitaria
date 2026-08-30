using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace SistemaEstoqueConfeitaria
{
    public partial class RedefinirSenha : Form
    {
        // ============================================================
        // VARIÁVEIS
        // ============================================================

        private bool novaSenhaVisivel = false;
        private bool confirmarSenhaVisivel = false;

        private bool arrastando = false;

        private Point posicaoMouseInicial;
        private Point posicaoFormInicial;

        // ============================================================
        // CONSTRUTOR
        // ============================================================

        public RedefinirSenha()
        {
            InitializeComponent();

            ConfigurarEventos();

            AtualizarOlhos();
        }

        // ============================================================
        // CONFIGURAR EVENTOS
        // ============================================================

        private void ConfigurarEventos()
        {
            btnRedefinir.Click +=
                btnRedefinir_Click;

            btnVoltar.Click +=
                btnVoltar_Click;

            lblSair.Click +=
                lblSair_Click;

            pbolhoNovaSenha.Click +=
                pbolhoNovaSenha_Click;

            pbolhoConfirmarSenha.Click +=
                pbolhoConfirmarSenha_Click;

            txtCpf.KeyPress +=
                txtCpf_KeyPress;

            MouseDown +=
                Janela_MouseDown;

            MouseMove +=
                Janela_MouseMove;

            MouseUp +=
                Janela_MouseUp;

            lblTitulo.MouseDown +=
                Janela_MouseDown;

            lblTitulo.MouseMove +=
                Janela_MouseMove;

            lblTitulo.MouseUp +=
                Janela_MouseUp;
        }

        // ============================================================
        // REDEFINIR SENHA
        // ============================================================

        private void btnRedefinir_Click(
            object? sender,
            EventArgs e)
        {
            string cpf =
                LimparCpf(txtCpf.Text);

            string novaSenha =
                txtNovaSenha.Text;

            string confirmarSenha =
                txtConfirmarSenha.Text;

            // ========================================================
            // CPF
            // ========================================================

            if (string.IsNullOrWhiteSpace(cpf))
            {
                MessageBox.Show(
                    "Digite o CPF cadastrado.",
                    "Campo obrigatório",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtCpf.Focus();

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

                txtCpf.Focus();

                return;
            }

            // ========================================================
            // NOVA SENHA
            // ========================================================

            if (string.IsNullOrWhiteSpace(novaSenha))
            {
                MessageBox.Show(
                    "Digite a nova senha.",
                    "Campo obrigatório",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtNovaSenha.Focus();

                return;
            }

            if (novaSenha.Length < 4)
            {
                MessageBox.Show(
                    "A nova senha deve possuir pelo menos 4 caracteres.",
                    "Senha inválida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtNovaSenha.Focus();

                return;
            }

            // ========================================================
            // CONFIRMAR SENHA
            // ========================================================

            if (string.IsNullOrWhiteSpace(confirmarSenha))
            {
                MessageBox.Show(
                    "Confirme a nova senha.",
                    "Campo obrigatório",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtConfirmarSenha.Focus();

                return;
            }

            if (novaSenha != confirmarSenha)
            {
                MessageBox.Show(
                    "As senhas digitadas não são iguais.",
                    "Senhas diferentes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtConfirmarSenha.Clear();

                txtConfirmarSenha.Focus();

                return;
            }

            // ========================================================
            // BANCO SQLITE
            // ========================================================

            try
            {
                using SqliteConnection con =
                    BancoDados.Conectar();

                con.Open();

                // ====================================================
                // VERIFICAR SE O CPF EXISTE
                // ====================================================

                string sqlVerificar =
                    @"SELECT id
                      FROM login
                      WHERE cpf = @cpf
                      LIMIT 1;";

                using SqliteCommand cmdVerificar =
                    new SqliteCommand(
                        sqlVerificar,
                        con
                    );

                cmdVerificar.Parameters.AddWithValue(
                    "@cpf",
                    cpf
                );

                object? resultado =
                    cmdVerificar.ExecuteScalar();

                if (resultado == null)
                {
                    MessageBox.Show(
                        "CPF não encontrado no sistema.",
                        "Usuário não encontrado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    txtCpf.Focus();

                    return;
                }

                // ====================================================
                // ALTERAR SENHA
                // ====================================================

                string sqlAtualizar =
                    @"UPDATE login
                      SET senha = @senha
                      WHERE cpf = @cpf;";

                using SqliteCommand cmdAtualizar =
                    new SqliteCommand(
                        sqlAtualizar,
                        con
                    );

                cmdAtualizar.Parameters.AddWithValue(
                    "@senha",
                    novaSenha
                );

                cmdAtualizar.Parameters.AddWithValue(
                    "@cpf",
                    cpf
                );

                int linhasAfetadas =
                    cmdAtualizar.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show(
                        "Senha redefinida com sucesso!",
                        "Redefinir Senha",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    AbrirLogin();
                }
                else
                {
                    MessageBox.Show(
                        "Não foi possível alterar a senha.",
                        "Redefinir Senha",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
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
                    "Ocorreu um erro ao redefinir a senha.\n\n" +
                    ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
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
        // CPF
        // ============================================================

        private void txtCpf_KeyPress(
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
        // OLHO - NOVA SENHA
        // ============================================================

        private void pbolhoNovaSenha_Click(
            object? sender,
            EventArgs e)
        {
            novaSenhaVisivel =
                !novaSenhaVisivel;

            if (novaSenhaVisivel)
            {
                // MOSTRA A SENHA
                txtNovaSenha.PasswordChar =
                    '\0';

                pbolhoNovaSenha.Image =
                    Properties.Resources.ResourceManager
                    .GetObject("olho fechado") as Image;
            }
            else
            {
                // ESCONDE A SENHA
                txtNovaSenha.PasswordChar =
                    '●';

                pbolhoNovaSenha.Image =
                    Properties.Resources.ResourceManager
                    .GetObject("olho aberto") as Image;
            }
        }

        // ============================================================
        // OLHO - CONFIRMAR SENHA
        // ============================================================

        private void pbolhoConfirmarSenha_Click(
            object? sender,
            EventArgs e)
        {
            confirmarSenhaVisivel =
                !confirmarSenhaVisivel;

            if (confirmarSenhaVisivel)
            {
                // MOSTRA A SENHA
                txtConfirmarSenha.PasswordChar =
                    '\0';

                pbolhoConfirmarSenha.Image =
                    Properties.Resources.ResourceManager
                    .GetObject("olho fechado") as Image;
            }
            else
            {
                // ESCONDE A SENHA
                txtConfirmarSenha.PasswordChar =
                    '●';

                pbolhoConfirmarSenha.Image =
                    Properties.Resources.ResourceManager
                    .GetObject("olho aberto") as Image;
            }
        }

        // ============================================================
        // CONFIGURAR ÍCONES AO ABRIR
        // ============================================================

        private void AtualizarOlhos()
        {
            novaSenhaVisivel = false;
            confirmarSenhaVisivel = false;

            txtNovaSenha.PasswordChar =
                '●';

            txtConfirmarSenha.PasswordChar =
                '●';

            pbolhoNovaSenha.Image =
                Properties.Resources.ResourceManager
                .GetObject("olho aberto") as Image;

            pbolhoConfirmarSenha.Image =
                Properties.Resources.ResourceManager
                .GetObject("olho aberto") as Image;
        }

        // ============================================================
        // VOLTAR PARA LOGIN
        // ============================================================

        private void btnVoltar_Click(
            object? sender,
            EventArgs e)
        {
            AbrirLogin();
        }

        private void AbrirLogin()
        {
            TelaLogin login =
                new TelaLogin();

            login.Show();

            this.Hide();
        }

        // ============================================================
        // FECHAR SISTEMA
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

            arrastando =
                true;

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
            arrastando =
                false;
        }
    }
}