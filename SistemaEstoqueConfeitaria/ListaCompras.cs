using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace SistemaEstoqueConfeitaria
{
    public partial class ListaCompras : Form
    {
        private bool arrastando = false;

        private Point posicaoMouseInicial;
        private Point posicaoFormInicial;

        public ListaCompras()
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
            Load += ListaCompras_Load;

            txtPesquisar.TextChanged +=
                txtPesquisar_TextChanged;

            cmbStatus.SelectedIndexChanged +=
                cmbStatus_SelectedIndexChanged;

            btnAtualizar.Click +=
                btnAtualizar_Click;

            btnMovimentar.Click +=
                btnMovimentar_Click;

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

            MouseDown += Janela_MouseDown;
            MouseMove += Janela_MouseMove;
            MouseUp += Janela_MouseUp;

            lblTitulo.MouseDown +=
                Janela_MouseDown;

            lblTitulo.MouseMove +=
                Janela_MouseMove;

            lblTitulo.MouseUp +=
                Janela_MouseUp;
        }

        // ============================================================
        // LOAD
        // ============================================================

        private void ListaCompras_Load(
            object? sender,
            EventArgs e)
        {
            cmbStatus.SelectedIndex = 0;

            CarregarResumo();

            CarregarLista();
        }

        // ============================================================
        // DATAGRIDVIEW
        // ============================================================

        private void ConfigurarDataGridView()
        {
            dgvCompras.EnableHeadersVisualStyles =
                false;

            dgvCompras.GridColor =
                Color.FromArgb(228, 206, 199);

            dgvCompras.ColumnHeadersHeight =
                38;

            dgvCompras.RowTemplate.Height =
                35;

            dgvCompras
                .ColumnHeadersDefaultCellStyle
                .BackColor =
                Color.FromArgb(239, 229, 226);

            dgvCompras
                .ColumnHeadersDefaultCellStyle
                .ForeColor =
                Color.FromArgb(94, 74, 68);

            dgvCompras
                .ColumnHeadersDefaultCellStyle
                .Font =
                new Font(
                    "Segoe UI",
                    9.5F,
                    FontStyle.Bold
                );

            dgvCompras
                .ColumnHeadersDefaultCellStyle
                .SelectionBackColor =
                Color.FromArgb(239, 229, 226);

            dgvCompras
                .ColumnHeadersDefaultCellStyle
                .SelectionForeColor =
                Color.FromArgb(94, 74, 68);

            dgvCompras
                .DefaultCellStyle
                .Font =
                new Font(
                    "Segoe UI",
                    9.5F
                );

            dgvCompras
                .DefaultCellStyle
                .ForeColor =
                Color.FromArgb(94, 74, 68);

            dgvCompras
                .DefaultCellStyle
                .SelectionBackColor =
                Color.FromArgb(184, 112, 121);

            dgvCompras
                .DefaultCellStyle
                .SelectionForeColor =
                Color.White;

            dgvCompras
                .AlternatingRowsDefaultCellStyle
                .BackColor =
                Color.FromArgb(252, 250, 249);
        }

        // ============================================================
        // CARREGAR LISTA - SQLITE
        // ============================================================

        private void CarregarLista()
        {
            try
            {
                using SqliteConnection con =
                    BancoDados.Conectar();

                con.Open();

                string sql =
                    @"SELECT
                        id,
                        nome,
                        categoria,
                        unidade,
                        quantidade_atual,
                        estoque_minimo,
                        COALESCE(
                            NULLIF(fornecedor, ''),
                            'Não informado'
                        ) AS fornecedor_exibicao,
                        CASE
                            WHEN quantidade_atual <= 0
                                THEN 'CRÍTICO'
                            ELSE 'BAIXO'
                        END AS status
                    FROM insumos
                    WHERE ativo = 1
                    AND quantidade_atual <= estoque_minimo
                    AND nome LIKE @pesquisa";

                // ================================================
                // FILTRO
                // ================================================

                if (cmbStatus.Text == "Baixo")
                {
                    sql +=
                        @" AND quantidade_atual > 0";
                }
                else if (cmbStatus.Text == "Crítico")
                {
                    sql +=
                        @" AND quantidade_atual <= 0";
                }

                sql +=
                    @" ORDER BY
                        CASE
                            WHEN quantidade_atual <= 0
                                THEN 1
                            ELSE 2
                        END,
                        nome;";

                using SqliteCommand cmd =
                    new SqliteCommand(
                        sql,
                        con
                    );

                cmd.Parameters.AddWithValue(
                    "@pesquisa",
                    "%" +
                    txtPesquisar.Text.Trim() +
                    "%"
                );

                using SqliteDataReader leitor =
                    cmd.ExecuteReader();

                // Define os tipos manualmente para o DataGridView
                // não interpretar nenhuma coluna como imagem.
                DataTable tabela =
                    new DataTable();

                tabela.Columns.Add(
                    "id",
                    typeof(long)
                );

                tabela.Columns.Add(
                    "Insumo",
                    typeof(string)
                );

                tabela.Columns.Add(
                    "Categoria",
                    typeof(string)
                );

                tabela.Columns.Add(
                    "Unidade",
                    typeof(string)
                );

                tabela.Columns.Add(
                    "Atual",
                    typeof(double)
                );

                tabela.Columns.Add(
                    "Mínimo",
                    typeof(double)
                );

                tabela.Columns.Add(
                    "Fornecedor",
                    typeof(string)
                );

                tabela.Columns.Add(
                    "Status",
                    typeof(string)
                );

                while (leitor.Read())
                {
                    DataRow linha =
                        tabela.NewRow();

                    linha["id"] =
                        Convert.ToInt64(
                            leitor["id"]
                        );

                    linha["Insumo"] =
                        leitor["nome"]?.ToString()
                        ?? "";

                    linha["Categoria"] =
                        leitor["categoria"]?.ToString()
                        ?? "";

                    linha["Unidade"] =
                        leitor["unidade"]?.ToString()
                        ?? "";

                    linha["Atual"] =
                        Convert.ToDouble(
                            leitor["quantidade_atual"]
                        );

                    linha["Mínimo"] =
                        Convert.ToDouble(
                            leitor["estoque_minimo"]
                        );

                    linha["Fornecedor"] =
                        leitor["fornecedor_exibicao"]?
                        .ToString()
                        ?? "Não informado";

                    linha["Status"] =
                        leitor["status"]?.ToString()
                        ?? "";

                    tabela.Rows.Add(linha);
                }

                dgvCompras.DataSource =
                    tabela;

                if (dgvCompras.Columns["id"] != null)
                {
                    dgvCompras.Columns["id"].Visible =
                        false;
                }

                // FORMATAÇÃO

                if (dgvCompras.Columns["Insumo"] != null)
                {
                    dgvCompras.Columns["Insumo"].FillWeight =
                        160;
                }

                if (dgvCompras.Columns["Categoria"] != null)
                {
                    dgvCompras.Columns["Categoria"].FillWeight =
                        110;
                }

                if (dgvCompras.Columns["Unidade"] != null)
                {
                    dgvCompras.Columns["Unidade"].FillWeight =
                        65;
                }

                if (dgvCompras.Columns["Atual"] != null)
                {
                    dgvCompras.Columns["Atual"].FillWeight =
                        80;

                    dgvCompras.Columns["Atual"]
                        .DefaultCellStyle.Format =
                        "N2";
                }

                if (dgvCompras.Columns["Mínimo"] != null)
                {
                    dgvCompras.Columns["Mínimo"].FillWeight =
                        80;

                    dgvCompras.Columns["Mínimo"]
                        .DefaultCellStyle.Format =
                        "N2";
                }

                if (dgvCompras.Columns["Fornecedor"] != null)
                {
                    dgvCompras.Columns["Fornecedor"].FillWeight =
                        150;
                }

                if (dgvCompras.Columns["Status"] != null)
                {
                    dgvCompras.Columns["Status"].FillWeight =
                        90;
                }

                AplicarCoresStatus();

                dgvCompras.ClearSelection();

                dgvCompras.CurrentCell =
                    null;

                if (tabela.Rows.Count == 0)
                {
                    lblListaDescricao.Text =
                        "Nenhum insumo precisa de reposição neste momento.";
                }
                else
                {
                    lblListaDescricao.Text =
                        "A lista é gerada automaticamente a partir do estoque atual.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Não foi possível carregar a lista de compras.\n\n" +
                    ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ============================================================
        // COR STATUS
        // ============================================================

        private void AplicarCoresStatus()
        {
            if (dgvCompras.Columns["Status"] == null)
            {
                return;
            }

            foreach (DataGridViewRow linha
                in dgvCompras.Rows)
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

                if (status == "BAIXO")
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
        // RESUMO - SQLITE
        // ============================================================

        private void CarregarResumo()
        {
            try
            {
                using SqliteConnection con =
                    BancoDados.Conectar();

                con.Open();

                string sql =
                    @"SELECT

                        COALESCE(
                            SUM(
                                CASE
                                    WHEN quantidade_atual <= estoque_minimo
                                    THEN 1
                                    ELSE 0
                                END
                            ),
                            0
                        ) AS total,

                        COALESCE(
                            SUM(
                                CASE
                                    WHEN quantidade_atual > 0
                                    AND quantidade_atual <= estoque_minimo
                                    THEN 1
                                    ELSE 0
                                END
                            ),
                            0
                        ) AS baixo,

                        COALESCE(
                            SUM(
                                CASE
                                    WHEN quantidade_atual <= 0
                                    THEN 1
                                    ELSE 0
                                END
                            ),
                            0
                        ) AS critico

                    FROM insumos

                    WHERE ativo = 1;";

                using SqliteCommand cmd =
                    new SqliteCommand(
                        sql,
                        con
                    );

                using SqliteDataReader leitor =
                    cmd.ExecuteReader();

                if (leitor.Read())
                {
                    lblTotal.Text =
                        ConverterNumero(
                            leitor["total"]
                        );

                    lblBaixo.Text =
                        ConverterNumero(
                            leitor["baixo"]
                        );

                    lblCritico.Text =
                        ConverterNumero(
                            leitor["critico"]
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Não foi possível carregar o resumo.\n\n" +
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
            if (valor == DBNull.Value ||
                valor == null)
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
            CarregarLista();
        }

        // ============================================================
        // STATUS
        // ============================================================

        private void cmbStatus_SelectedIndexChanged(
            object? sender,
            EventArgs e)
        {
            CarregarLista();
        }

        // ============================================================
        // ATUALIZAR
        // ============================================================

        private void btnAtualizar_Click(
            object? sender,
            EventArgs e)
        {
            CarregarResumo();

            CarregarLista();
        }

        // ============================================================
        // REGISTRAR ENTRADA
        // ============================================================

        private void btnMovimentar_Click(
            object? sender,
            EventArgs e)
        {
            MovimentarEstoque tela =
                new MovimentarEstoque();

            tela.Show();

            this.Hide();
        }

        // ============================================================
        // NAVEGAÇÃO
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

        private void btnCadastroInsumos_Click(
            object? sender,
            EventArgs e)
        {
            CadastroInsumos tela =
                new CadastroInsumos();

            tela.Show();

            this.Hide();
        }

        private void btnMovimentarEstoque_Click(
            object? sender,
            EventArgs e)
        {
            MovimentarEstoque tela =
                new MovimentarEstoque();

            tela.Show();

            this.Hide();
        }

        private void btnEstoqueAtual_Click(
            object? sender,
            EventArgs e)
        {
            EstoqueAtual tela =
                new EstoqueAtual();

            tela.Show();

            this.Hide();
        }

        private void btnListaCompras_Click(
            object? sender,
            EventArgs e)
        {
            // Já estamos nesta tela.
        }

        private void btnHistorico_Click(
            object? sender,
            EventArgs e)
        {
            HistoricoMovimentacoes tela =
                new HistoricoMovimentacoes();

            tela.Show();

            this.Hide();
        }

        private void btnSair_Click(
            object? sender,
            EventArgs e)
        {
            TelaLogin tela =
                new TelaLogin();

            tela.Show();

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
