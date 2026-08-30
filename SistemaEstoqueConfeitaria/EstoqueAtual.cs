using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SistemaEstoqueConfeitaria
{
    public partial class EstoqueAtual : Form
    {
        private bool arrastando = false;

        private Point posicaoMouseInicial;
        private Point posicaoFormInicial;

        public EstoqueAtual()
        {
            InitializeComponent();

            ConfigurarEventos();

            ConfigurarDataGridView();
        }

        // ============================================================
        // EVENTOS
        // ============================================================

        private void ConfigurarEventos()
        {
            Load += EstoqueAtual_Load;

            txtPesquisar.TextChanged +=
                txtPesquisar_TextChanged;

            cmbStatus.SelectedIndexChanged +=
                cmbStatus_SelectedIndexChanged;

            btnAtualizar.Click +=
                btnAtualizar_Click;

            btnMenuPrincipal.Click +=
                btnMenuPrincipal_Click;

            btnCadastroInsumos.Click +=
                btnCadastroInsumos_Click;

            btnMovimentarEstoque.Click +=
                btnMovimentarEstoque_Click;

            btnEstoqueAtual.Click +=
                btnEstoqueAtual_Click;

            btnListaCompras.Click +=
                btnListaCompras_Click;

            btnHistorico.Click +=
                btnHistorico_Click;

            btnSair.Click +=
                btnSair_Click;

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
        // CARREGAMENTO
        // ============================================================

        private void EstoqueAtual_Load(
            object? sender,
            EventArgs e)
        {
            cmbStatus.SelectedIndex =
                0;

            CarregarResumo();

            CarregarEstoque();
        }

        // ============================================================
        // CONFIGURAÇÃO DO DATAGRIDVIEW
        // ============================================================

        private void ConfigurarDataGridView()
        {
            dgvEstoque.EnableHeadersVisualStyles =
                false;

            dgvEstoque.GridColor =
                Color.FromArgb(228, 206, 199);

            dgvEstoque.ColumnHeadersHeight =
                38;

            dgvEstoque.RowTemplate.Height =
                35;

            // CABEÇALHO
            dgvEstoque
                .ColumnHeadersDefaultCellStyle
                .BackColor =
                Color.FromArgb(239, 229, 226);

            dgvEstoque
                .ColumnHeadersDefaultCellStyle
                .ForeColor =
                Color.FromArgb(94, 74, 68);

            dgvEstoque
                .ColumnHeadersDefaultCellStyle
                .Font =
                new Font(
                    "Segoe UI",
                    9.5F,
                    FontStyle.Bold
                );

            // Impede cabeçalho azul
            dgvEstoque
                .ColumnHeadersDefaultCellStyle
                .SelectionBackColor =
                Color.FromArgb(239, 229, 226);

            dgvEstoque
                .ColumnHeadersDefaultCellStyle
                .SelectionForeColor =
                Color.FromArgb(94, 74, 68);

            // LINHAS
            dgvEstoque
                .DefaultCellStyle
                .Font =
                new Font(
                    "Segoe UI",
                    9.5F,
                    FontStyle.Regular
                );

            dgvEstoque
                .DefaultCellStyle
                .ForeColor =
                Color.FromArgb(94, 74, 68);

            dgvEstoque
                .DefaultCellStyle
                .BackColor =
                Color.White;

            // SELEÇÃO
            dgvEstoque
                .DefaultCellStyle
                .SelectionBackColor =
                Color.FromArgb(184, 112, 121);

            dgvEstoque
                .DefaultCellStyle
                .SelectionForeColor =
                Color.White;

            dgvEstoque
                .AlternatingRowsDefaultCellStyle
                .BackColor =
                Color.FromArgb(252, 250, 249);
        }

        // ============================================================
        // CARREGAR ESTOQUE
        // ============================================================

        private void CarregarEstoque()
        {
            try
            {
                conexao banco =
                    new conexao();

                using MySqlConnection con =
                    banco.Conectar();

                con.Open();

                string sql =
                    @"SELECT
                        id,

                        nome AS 'Insumo',

                        categoria AS 'Categoria',

                        unidade AS 'Unidade',

                        quantidade_atual AS 'Estoque',

                        estoque_minimo AS 'Mínimo',

                        CASE
                            WHEN quantidade_atual <= 0
                                THEN 'CRÍTICO'

                            WHEN quantidade_atual <= estoque_minimo
                                THEN 'BAIXO'

                            ELSE 'OK'
                        END AS 'Status'

                    FROM insumos

                    WHERE ativo = 1

                    AND nome LIKE @pesquisa";

                // ================================================
                // FILTRO POR STATUS
                // ================================================

                if (cmbStatus.Text == "OK")
                {
                    sql +=
                        @" AND quantidade_atual > estoque_minimo";
                }

                else if (cmbStatus.Text == "Baixo")
                {
                    sql +=
                        @" AND quantidade_atual > 0
                           AND quantidade_atual <= estoque_minimo";
                }

                else if (cmbStatus.Text == "Crítico")
                {
                    sql +=
                        @" AND quantidade_atual <= 0";
                }

                sql +=
                    @" ORDER BY nome;";

                using MySqlCommand cmd =
                    new MySqlCommand(
                        sql,
                        con
                    );

                cmd.Parameters.AddWithValue(
                    "@pesquisa",
                    "%" +
                    txtPesquisar.Text.Trim() +
                    "%"
                );

                using MySqlDataAdapter adapter =
                    new MySqlDataAdapter(cmd);

                DataTable tabela =
                    new DataTable();

                adapter.Fill(tabela);

                dgvEstoque.DataSource =
                    tabela;

                // ================================================
                // ESCONDER ID
                // ================================================

                if (dgvEstoque.Columns["id"] != null)
                {
                    dgvEstoque.Columns["id"].Visible =
                        false;
                }

                // ================================================
                // TAMANHO DAS COLUNAS
                // ================================================

                if (dgvEstoque.Columns["Insumo"] != null)
                {
                    dgvEstoque.Columns["Insumo"].FillWeight =
                        180;
                }

                if (dgvEstoque.Columns["Categoria"] != null)
                {
                    dgvEstoque.Columns["Categoria"].FillWeight =
                        120;
                }

                if (dgvEstoque.Columns["Unidade"] != null)
                {
                    dgvEstoque.Columns["Unidade"].FillWeight =
                        70;
                }

                if (dgvEstoque.Columns["Estoque"] != null)
                {
                    dgvEstoque.Columns["Estoque"].FillWeight =
                        90;

                    dgvEstoque.Columns["Estoque"]
                        .DefaultCellStyle.Format =
                        "N2";
                }

                if (dgvEstoque.Columns["Mínimo"] != null)
                {
                    dgvEstoque.Columns["Mínimo"].FillWeight =
                        90;

                    dgvEstoque.Columns["Mínimo"]
                        .DefaultCellStyle.Format =
                        "N2";
                }

                if (dgvEstoque.Columns["Status"] != null)
                {
                    dgvEstoque.Columns["Status"].FillWeight =
                        90;
                }

                // ================================================
                // CORES DOS STATUS
                // ================================================

                AplicarCoresStatus();

                // ================================================
                // NÃO SELECIONAR PRIMEIRA LINHA
                // ================================================

                dgvEstoque.ClearSelection();

                dgvEstoque.CurrentCell =
                    null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Não foi possível carregar o estoque.\n\n" +
                    ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ============================================================
        // CORES DOS STATUS
        // ============================================================

        private void AplicarCoresStatus()
        {
            if (dgvEstoque.Columns["Status"] == null)
            {
                return;
            }

            foreach (DataGridViewRow linha
                in dgvEstoque.Rows)
            {
                string status =
                    linha.Cells["Status"]
                    .Value?
                    .ToString()
                    ?? "";

                DataGridViewCell celula =
                    linha.Cells["Status"];

                celula.Style.Font =
                    new Font(
                        "Segoe UI",
                        9F,
                        FontStyle.Bold
                    );

                celula.Style.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;

                if (status == "OK")
                {
                    celula.Style.BackColor =
                        Color.FromArgb(
                            235,
                            244,
                            236
                        );

                    celula.Style.ForeColor =
                        Color.FromArgb(
                            67,
                            107,
                            75
                        );
                }

                else if (status == "BAIXO")
                {
                    celula.Style.BackColor =
                        Color.FromArgb(
                            250,
                            241,
                            219
                        );

                    celula.Style.ForeColor =
                        Color.FromArgb(
                            154,
                            112,
                            37
                        );
                }

                else if (status == "CRÍTICO")
                {
                    celula.Style.BackColor =
                        Color.FromArgb(
                            249,
                            229,
                            229
                        );

                    celula.Style.ForeColor =
                        Color.FromArgb(
                            146,
                            65,
                            65
                        );
                }
            }
        }

        // ============================================================
        // RESUMO
        // ============================================================

        private void CarregarResumo()
        {
            try
            {
                conexao banco =
                    new conexao();

                using MySqlConnection con =
                    banco.Conectar();

                con.Open();

                string sql =
                    @"SELECT

                        COUNT(*) AS total,

                        SUM(
                            CASE
                                WHEN quantidade_atual > estoque_minimo
                                THEN 1
                                ELSE 0
                            END
                        ) AS total_ok,

                        SUM(
                            CASE
                                WHEN quantidade_atual > 0
                                AND quantidade_atual <= estoque_minimo
                                THEN 1
                                ELSE 0
                            END
                        ) AS total_baixo,

                        SUM(
                            CASE
                                WHEN quantidade_atual <= 0
                                THEN 1
                                ELSE 0
                            END
                        ) AS total_critico

                    FROM insumos

                    WHERE ativo = 1;";

                using MySqlCommand cmd =
                    new MySqlCommand(
                        sql,
                        con
                    );

                using MySqlDataReader leitor =
                    cmd.ExecuteReader();

                if (leitor.Read())
                {
                    lblTotal.Text =
                        ConverterNumero(
                            leitor["total"]
                        );

                    lblOk.Text =
                        ConverterNumero(
                            leitor["total_ok"]
                        );

                    lblBaixo.Text =
                        ConverterNumero(
                            leitor["total_baixo"]
                        );

                    lblCritico.Text =
                        ConverterNumero(
                            leitor["total_critico"]
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Não foi possível carregar o resumo do estoque.\n\n" +
                    ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private string ConverterNumero(
            object valor)
        {
            if (valor == DBNull.Value)
            {
                return "0";
            }

            return Convert
                .ToInt32(valor)
                .ToString();
        }

        // ============================================================
        // PESQUISA
        // ============================================================

        private void txtPesquisar_TextChanged(
            object? sender,
            EventArgs e)
        {
            CarregarEstoque();
        }

        // ============================================================
        // FILTRO STATUS
        // ============================================================

        private void cmbStatus_SelectedIndexChanged(
            object? sender,
            EventArgs e)
        {
            CarregarEstoque();
        }

        // ============================================================
        // ATUALIZAR
        // ============================================================

        private void btnAtualizar_Click(
            object? sender,
            EventArgs e)
        {
            CarregarResumo();

            CarregarEstoque();
        }

        // ============================================================
        // MENU PRINCIPAL
        // ============================================================

        private void btnMenuPrincipal_Click(
            object? sender,
            EventArgs e)
        {
            MenuPrincipal tela =
                new MenuPrincipal();

            tela.Show();

            this.Hide();
        }

        // ============================================================
        // CADASTRO DE INSUMOS
        // ============================================================

        private void btnCadastroInsumos_Click(
            object? sender,
            EventArgs e)
        {
            CadastroInsumos tela =
                new CadastroInsumos();

            tela.Show();

            this.Hide();
        }

        // ============================================================
        // MOVIMENTAR ESTOQUE
        // ============================================================

        private void btnMovimentarEstoque_Click(
            object? sender,
            EventArgs e)
        {
            MovimentarEstoque tela =
                new MovimentarEstoque();

            tela.Show();

            this.Hide();
        }

        // ============================================================
        // ESTOQUE ATUAL
        // ============================================================

        private void btnEstoqueAtual_Click(
            object? sender,
            EventArgs e)
        {
            EstoqueAtual tela =
        new EstoqueAtual();

            tela.Show();

            this.Hide();
        }

        // ============================================================
        // LISTA DE COMPRAS
        // ============================================================

        private void btnListaCompras_Click(
            object? sender,
            EventArgs e)
        {
            ListaCompras tela =
       new ListaCompras();

            tela.Show();

            this.Hide();
        }

        // ============================================================
        // HISTÓRICO
        // ============================================================

        private void btnHistorico_Click(
            object? sender,
            EventArgs e)
        {
            HistoricoMovimentacoes tela =
        new HistoricoMovimentacoes();

            tela.Show();

            this.Hide();
        }

        // ============================================================
        // SAIR
        // ============================================================

        private void btnSair_Click(
            object? sender,
            EventArgs e)
        {
            TelaLogin login =
                new TelaLogin();

            login.Show();

            this.Hide();
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