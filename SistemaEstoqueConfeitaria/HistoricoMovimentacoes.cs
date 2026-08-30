using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SistemaEstoqueConfeitaria
{
    public partial class HistoricoMovimentacoes : Form
    {
        private bool arrastando = false;

        private Point posicaoMouseInicial;
        private Point posicaoFormInicial;

        private bool carregandoFiltros = false;

        public HistoricoMovimentacoes()
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
            Load +=
                HistoricoMovimentacoes_Load;

            txtPesquisar.TextChanged +=
                FiltrosAlterados;

            cmbInsumo.SelectedIndexChanged +=
                FiltrosAlterados;

            cmbTipo.SelectedIndexChanged +=
                FiltrosAlterados;

            cmbMotivo.SelectedIndexChanged +=
                FiltrosAlterados;

            dtpDataInicial.ValueChanged +=
                FiltrosAlterados;

            dtpDataFinal.ValueChanged +=
                FiltrosAlterados;

            btnAtualizar.Click +=
                btnAtualizar_Click;

            btnLimparFiltros.Click +=
                btnLimparFiltros_Click;

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
        // LOAD
        // ============================================================

        private void HistoricoMovimentacoes_Load(
            object? sender,
            EventArgs e)
        {
            carregandoFiltros =
                true;

            CarregarInsumos();

            cmbTipo.SelectedIndex =
                0;

            cmbMotivo.SelectedIndex =
                0;

            dtpDataInicial.Checked =
                false;

            dtpDataFinal.Checked =
                false;

            carregandoFiltros =
                false;

            CarregarHistorico();
        }

        // ============================================================
        // CONFIGURAR GRID
        // ============================================================

        private void ConfigurarDataGridView()
        {
            dgvHistorico.EnableHeadersVisualStyles =
                false;

            dgvHistorico.GridColor =
                Color.FromArgb(
                    228,
                    206,
                    199
                );

            dgvHistorico.ColumnHeadersHeight =
                38;

            dgvHistorico.RowTemplate.Height =
                35;

            // CABEÇALHO
            dgvHistorico
                .ColumnHeadersDefaultCellStyle
                .BackColor =
                Color.FromArgb(
                    239,
                    229,
                    226
                );

            dgvHistorico
                .ColumnHeadersDefaultCellStyle
                .ForeColor =
                Color.FromArgb(
                    94,
                    74,
                    68
                );

            dgvHistorico
                .ColumnHeadersDefaultCellStyle
                .Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold
                );

            // EVITA AZUL NO CABEÇALHO
            dgvHistorico
                .ColumnHeadersDefaultCellStyle
                .SelectionBackColor =
                Color.FromArgb(
                    239,
                    229,
                    226
                );

            dgvHistorico
                .ColumnHeadersDefaultCellStyle
                .SelectionForeColor =
                Color.FromArgb(
                    94,
                    74,
                    68
                );

            // LINHAS
            dgvHistorico
                .DefaultCellStyle
                .Font =
                new Font(
                    "Segoe UI",
                    9F
                );

            dgvHistorico
                .DefaultCellStyle
                .ForeColor =
                Color.FromArgb(
                    94,
                    74,
                    68
                );

            dgvHistorico
                .DefaultCellStyle
                .BackColor =
                Color.White;

            // SELEÇÃO ROSA
            dgvHistorico
                .DefaultCellStyle
                .SelectionBackColor =
                Color.FromArgb(
                    184,
                    112,
                    121
                );

            dgvHistorico
                .DefaultCellStyle
                .SelectionForeColor =
                Color.White;

            dgvHistorico
                .AlternatingRowsDefaultCellStyle
                .BackColor =
                Color.FromArgb(
                    252,
                    250,
                    249
                );
        }

        // ============================================================
        // CARREGAR INSUMOS NO FILTRO
        // ============================================================

        private void CarregarInsumos()
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
                        nome

                    FROM insumos

                    ORDER BY nome;";

                using MySqlDataAdapter adapter =
                    new MySqlDataAdapter(
                        sql,
                        con
                    );

                DataTable tabela =
                    new DataTable();

                adapter.Fill(tabela);

                // Adiciona "Todos" na primeira posição.
                DataRow linhaTodos =
                    tabela.NewRow();

                linhaTodos["id"] =
                    0;

                linhaTodos["nome"] =
                    "Todos";

                tabela.Rows.InsertAt(
                    linhaTodos,
                    0
                );

                cmbInsumo.DataSource =
                    tabela;

                cmbInsumo.DisplayMember =
                    "nome";

                cmbInsumo.ValueMember =
                    "id";

                cmbInsumo.SelectedIndex =
                    0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Não foi possível carregar os insumos.\n\n" +
                    ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ============================================================
        // CARREGAR HISTÓRICO
        // ============================================================

        private void CarregarHistorico()
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

                        m.id,

                        DATE_FORMAT(
                            m.data_movimentacao,
                            '%d/%m/%Y %H:%i'
                        ) AS 'Data',

                        i.nome AS 'Insumo',

                        m.tipo AS 'Tipo',

                        m.quantidade AS 'Quantidade',

                        i.unidade AS 'Un.',

                        m.estoque_anterior AS 'Antes',

                        m.estoque_novo AS 'Depois',

                        m.motivo AS 'Motivo',

                        COALESCE(
                            m.observacao,
                            ''
                        ) AS 'Observação'

                    FROM movimentacoes_estoque m

                    INNER JOIN insumos i
                        ON i.id = m.insumo_id

                    WHERE 1 = 1";

                // ====================================================
                // DATA INICIAL
                // ====================================================

                if (dtpDataInicial.Checked)
                {
                    sql +=
                        @" AND m.data_movimentacao >= @dataInicial";
                }

                // ====================================================
                // DATA FINAL
                // ====================================================

                if (dtpDataFinal.Checked)
                {
                    sql +=
                        @" AND m.data_movimentacao < @dataFinal";
                }

                // ====================================================
                // INSUMO
                // ====================================================

                int insumoSelecionado =
                    0;

                if (cmbInsumo.SelectedValue != null)
                {
                    int.TryParse(
                        cmbInsumo
                        .SelectedValue
                        .ToString(),

                        out insumoSelecionado
                    );
                }

                if (insumoSelecionado > 0)
                {
                    sql +=
                        @" AND m.insumo_id = @insumo";
                }

                // ====================================================
                // TIPO
                // ====================================================

                if (cmbTipo.Text == "Entrada" ||
                    cmbTipo.Text == "Saída")
                {
                    sql +=
                        @" AND m.tipo = @tipo";
                }

                // ====================================================
                // MOTIVO
                // ====================================================

                if (!string.IsNullOrWhiteSpace(
                    cmbMotivo.Text
                )
                &&
                cmbMotivo.Text != "Todos")
                {
                    sql +=
                        @" AND m.motivo = @motivo";
                }

                // ====================================================
                // PESQUISA
                // ====================================================

                if (!string.IsNullOrWhiteSpace(
                    txtPesquisar.Text
                ))
                {
                    sql +=
                        @" AND
                        (
                            i.nome LIKE @pesquisa

                            OR m.motivo LIKE @pesquisa

                            OR m.observacao LIKE @pesquisa
                        )";
                }

                sql +=
                    @" ORDER BY
                        m.data_movimentacao DESC,
                        m.id DESC;";

                using MySqlCommand cmd =
                    new MySqlCommand(
                        sql,
                        con
                    );

                // ====================================================
                // PARÂMETROS
                // ====================================================

                if (dtpDataInicial.Checked)
                {
                    cmd.Parameters.AddWithValue(
                        "@dataInicial",
                        dtpDataInicial.Value.Date
                    );
                }

                if (dtpDataFinal.Checked)
                {
                    // +1 dia para incluir o dia final inteiro.
                    cmd.Parameters.AddWithValue(
                        "@dataFinal",
                        dtpDataFinal
                        .Value
                        .Date
                        .AddDays(1)
                    );
                }

                if (insumoSelecionado > 0)
                {
                    cmd.Parameters.AddWithValue(
                        "@insumo",
                        insumoSelecionado
                    );
                }

                if (cmbTipo.Text == "Entrada" ||
                    cmbTipo.Text == "Saída")
                {
                    cmd.Parameters.AddWithValue(
                        "@tipo",
                        cmbTipo.Text
                    );
                }

                if (!string.IsNullOrWhiteSpace(
                    cmbMotivo.Text
                )
                &&
                cmbMotivo.Text != "Todos")
                {
                    cmd.Parameters.AddWithValue(
                        "@motivo",
                        cmbMotivo.Text
                    );
                }

                if (!string.IsNullOrWhiteSpace(
                    txtPesquisar.Text
                ))
                {
                    cmd.Parameters.AddWithValue(
                        "@pesquisa",
                        "%" +
                        txtPesquisar.Text.Trim() +
                        "%"
                    );
                }

                using MySqlDataAdapter adapter =
                    new MySqlDataAdapter(cmd);

                DataTable tabela =
                    new DataTable();

                adapter.Fill(tabela);

                dgvHistorico.DataSource =
                    tabela;

                // ====================================================
                // ESCONDER ID
                // ====================================================

                if (dgvHistorico.Columns["id"] != null)
                {
                    dgvHistorico.Columns["id"].Visible =
                        false;
                }

                // ====================================================
                // FORMATAR COLUNAS
                // ====================================================

                if (dgvHistorico.Columns["Data"] != null)
                {
                    dgvHistorico.Columns["Data"].FillWeight =
                        115;
                }

                if (dgvHistorico.Columns["Insumo"] != null)
                {
                    dgvHistorico.Columns["Insumo"].FillWeight =
                        160;
                }

                if (dgvHistorico.Columns["Tipo"] != null)
                {
                    dgvHistorico.Columns["Tipo"].FillWeight =
                        80;
                }

                if (dgvHistorico.Columns["Quantidade"] != null)
                {
                    dgvHistorico.Columns["Quantidade"].FillWeight =
                        85;

                    dgvHistorico.Columns["Quantidade"]
                        .DefaultCellStyle.Format =
                        "N2";
                }

                if (dgvHistorico.Columns["Un."] != null)
                {
                    dgvHistorico.Columns["Un."].FillWeight =
                        55;
                }

                if (dgvHistorico.Columns["Antes"] != null)
                {
                    dgvHistorico.Columns["Antes"].FillWeight =
                        75;

                    dgvHistorico.Columns["Antes"]
                        .DefaultCellStyle.Format =
                        "N2";
                }

                if (dgvHistorico.Columns["Depois"] != null)
                {
                    dgvHistorico.Columns["Depois"].FillWeight =
                        75;

                    dgvHistorico.Columns["Depois"]
                        .DefaultCellStyle.Format =
                        "N2";
                }

                if (dgvHistorico.Columns["Motivo"] != null)
                {
                    dgvHistorico.Columns["Motivo"].FillWeight =
                        100;
                }

                if (dgvHistorico.Columns["Observação"] != null)
                {
                    dgvHistorico.Columns["Observação"].FillWeight =
                        150;
                }

                AplicarCoresTipo();

                AtualizarResumo(
                    tabela
                );

                // NÃO SELECIONA A PRIMEIRA LINHA
                dgvHistorico.ClearSelection();

                dgvHistorico.CurrentCell =
                    null;

                if (tabela.Rows.Count == 0)
                {
                    lblListaDescricao.Text =
                        "Nenhuma movimentação encontrada com os filtros selecionados.";
                }
                else
                {
                    lblListaDescricao.Text =
                        "Histórico completo das alterações realizadas no estoque.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Não foi possível carregar o histórico.\n\n" +
                    ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ============================================================
        // CORES DE ENTRADA / SAÍDA
        // ============================================================

        private void AplicarCoresTipo()
        {
            if (dgvHistorico.Columns["Tipo"] == null)
            {
                return;
            }

            foreach (DataGridViewRow linha
                in dgvHistorico.Rows)
            {
                string tipo =
                    linha.Cells["Tipo"]
                    .Value?
                    .ToString()
                    ?? "";

                DataGridViewCell celula =
                    linha.Cells["Tipo"];

                celula.Style.Font =
                    new Font(
                        "Segoe UI",
                        9F,
                        FontStyle.Bold
                    );

                celula.Style.Alignment =
                    DataGridViewContentAlignment
                    .MiddleCenter;

                // ENTRADA
                if (tipo == "Entrada")
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

                // SAÍDA
                else if (tipo == "Saída")
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

        private void AtualizarResumo(
            DataTable tabela)
        {
            int total =
                tabela.Rows.Count;

            int entradas =
                0;

            int saidas =
                0;

            foreach (DataRow linha
                in tabela.Rows)
            {
                string tipo =
                    linha["Tipo"]?
                    .ToString()
                    ?? "";

                if (tipo == "Entrada")
                {
                    entradas++;
                }

                else if (tipo == "Saída")
                {
                    saidas++;
                }
            }

            lblTotal.Text =
                total.ToString();

            lblEntradas.Text =
                entradas.ToString();

            lblSaidas.Text =
                saidas.ToString();
        }

        // ============================================================
        // FILTROS ALTERADOS
        // ============================================================

        private void FiltrosAlterados(
            object? sender,
            EventArgs e)
        {
            if (carregandoFiltros)
            {
                return;
            }

            CarregarHistorico();
        }

        // ============================================================
        // ATUALIZAR
        // ============================================================

        private void btnAtualizar_Click(
            object? sender,
            EventArgs e)
        {
            CarregarHistorico();
        }

        // ============================================================
        // LIMPAR FILTROS
        // ============================================================

        private void btnLimparFiltros_Click(
            object? sender,
            EventArgs e)
        {
            carregandoFiltros =
                true;

            dtpDataInicial.Checked =
                false;

            dtpDataFinal.Checked =
                false;

            if (cmbInsumo.Items.Count > 0)
            {
                cmbInsumo.SelectedIndex =
                    0;
            }

            cmbTipo.SelectedIndex =
                0;

            cmbMotivo.SelectedIndex =
                0;

            txtPesquisar.Clear();

            carregandoFiltros =
                false;

            CarregarHistorico();
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
        // CADASTRO
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
        // MOVIMENTAR
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
            // Já estamos nesta tela.
        }

        // ============================================================
        // SAIR
        // ============================================================

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