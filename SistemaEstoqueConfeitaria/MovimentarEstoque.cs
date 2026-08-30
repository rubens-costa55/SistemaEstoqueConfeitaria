using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SistemaEstoqueConfeitaria
{
    public partial class MovimentarEstoque : Form
    {
        private decimal estoqueAtual = 0;
        private string unidadeAtual = "";

        private bool arrastando = false;
        private Point posicaoMouseInicial;
        private Point posicaoFormInicial;

        public MovimentarEstoque()
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
            Load += MovimentarEstoque_Load;

            cmbInsumo.SelectedIndexChanged +=
                cmbInsumo_SelectedIndexChanged;

            cmbTipo.SelectedIndexChanged +=
                AtualizarPrevia_Evento;

            nudQuantidade.ValueChanged +=
                AtualizarPrevia_Evento;

            btnRegistrar.Click +=
                btnRegistrar_Click;

            btnLimpar.Click +=
                btnLimpar_Click;

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

            lblTitulo.MouseDown += Janela_MouseDown;
            lblTitulo.MouseMove += Janela_MouseMove;
            lblTitulo.MouseUp += Janela_MouseUp;
        }

        // ============================================================
        // LOAD
        // ============================================================

        private void MovimentarEstoque_Load(
            object? sender,
            EventArgs e)
        {
            CarregarInsumos();

            CarregarMovimentacoes();

            LimparCampos();
        }

        // ============================================================
        // DATAGRID
        // ============================================================

        private void ConfigurarDataGridView()
        {
            dgvMovimentacoes.EnableHeadersVisualStyles =
                false;

            dgvMovimentacoes.GridColor =
                Color.FromArgb(228, 206, 199);

            dgvMovimentacoes
                .ColumnHeadersDefaultCellStyle
                .BackColor =
                Color.FromArgb(239, 229, 226);

            dgvMovimentacoes
                .ColumnHeadersDefaultCellStyle
                .ForeColor =
                Color.FromArgb(94, 74, 68);

            dgvMovimentacoes
                .ColumnHeadersDefaultCellStyle
                .SelectionBackColor =
                Color.FromArgb(239, 229, 226);

            dgvMovimentacoes
                .ColumnHeadersDefaultCellStyle
                .SelectionForeColor =
                Color.FromArgb(94, 74, 68);

            dgvMovimentacoes
                .DefaultCellStyle
                .SelectionBackColor =
                Color.FromArgb(184, 112, 121);

            dgvMovimentacoes
                .DefaultCellStyle
                .SelectionForeColor =
                Color.White;

            dgvMovimentacoes
                .DefaultCellStyle
                .ForeColor =
                Color.FromArgb(94, 74, 68);

            dgvMovimentacoes
                .AlternatingRowsDefaultCellStyle
                .BackColor =
                Color.FromArgb(252, 250, 249);
        }

        // ============================================================
        // CARREGAR INSUMOS
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
                        nome,
                        quantidade_atual,
                        unidade
                    FROM insumos
                    WHERE ativo = 1
                    ORDER BY nome;";

                using MySqlDataAdapter adapter =
                    new MySqlDataAdapter(sql, con);

                DataTable tabela =
                    new DataTable();

                adapter.Fill(tabela);

                cmbInsumo.DataSource =
                    tabela;

                cmbInsumo.DisplayMember =
                    "nome";

                cmbInsumo.ValueMember =
                    "id";

                cmbInsumo.SelectedIndex =
                    -1;
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
        // SELECIONAR INSUMO
        // ============================================================

        private void cmbInsumo_SelectedIndexChanged(
            object? sender,
            EventArgs e)
        {
            if (cmbInsumo.SelectedItem
                is not DataRowView linha)
            {
                estoqueAtual = 0;
                unidadeAtual = "";

                AtualizarPrevia();

                return;
            }

            estoqueAtual =
                Convert.ToDecimal(
                    linha["quantidade_atual"]
                );

            unidadeAtual =
                linha["unidade"]?.ToString()
                ?? "";

            AtualizarPrevia();
        }

        // ============================================================
        // PRÉVIA
        // ============================================================

        private void AtualizarPrevia_Evento(
            object? sender,
            EventArgs e)
        {
            AtualizarPrevia();
        }

        private void AtualizarPrevia()
        {
            decimal quantidade =
                nudQuantidade.Value;

            decimal novoEstoque =
                estoqueAtual;

            if (cmbTipo.Text == "Entrada")
            {
                novoEstoque =
                    estoqueAtual + quantidade;
            }

            if (cmbTipo.Text == "Saída")
            {
                novoEstoque =
                    estoqueAtual - quantidade;
            }

            lblEstoqueAtualValor.Text =
                estoqueAtual.ToString("N2") +
                " " +
                unidadeAtual;

            lblNovoEstoqueValor.Text =
                novoEstoque.ToString("N2") +
                " " +
                unidadeAtual;

            if (novoEstoque < 0)
            {
                lblNovoEstoqueValor.ForeColor =
                    Color.Firebrick;
            }
            else
            {
                lblNovoEstoqueValor.ForeColor =
                    Color.FromArgb(184, 112, 121);
            }
        }

        // ============================================================
        // REGISTRAR
        // ============================================================

        private void btnRegistrar_Click(
            object? sender,
            EventArgs e)
        {
            if (cmbTipo.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Selecione o tipo da movimentação.",
                    "Campo obrigatório",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbTipo.Focus();

                return;
            }

            if (cmbInsumo.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Selecione um insumo.",
                    "Campo obrigatório",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbInsumo.Focus();

                return;
            }

            if (nudQuantidade.Value <= 0)
            {
                MessageBox.Show(
                    "Informe uma quantidade maior que zero.",
                    "Quantidade inválida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                nudQuantidade.Focus();

                return;
            }

            if (cmbMotivo.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Selecione o motivo da movimentação.",
                    "Campo obrigatório",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbMotivo.Focus();

                return;
            }

            int insumoId =
                Convert.ToInt32(
                    cmbInsumo.SelectedValue
                );

            decimal quantidade =
                nudQuantidade.Value;

            try
            {
                conexao banco =
                    new conexao();

                using MySqlConnection con =
                    banco.Conectar();

                con.Open();

                using MySqlTransaction transacao =
                    con.BeginTransaction();

                string sqlEstoque =
                    @"SELECT quantidade_atual
                      FROM insumos
                      WHERE id = @id
                      FOR UPDATE;";

                using MySqlCommand cmdEstoque =
                    new MySqlCommand(
                        sqlEstoque,
                        con,
                        transacao
                    );

                cmdEstoque.Parameters.AddWithValue(
                    "@id",
                    insumoId
                );

                decimal estoqueAnterior =
                    Convert.ToDecimal(
                        cmdEstoque.ExecuteScalar()
                    );

                decimal estoqueNovo;

                if (cmbTipo.Text == "Entrada")
                {
                    estoqueNovo =
                        estoqueAnterior +
                        quantidade;
                }
                else
                {
                    if (quantidade >
                        estoqueAnterior)
                    {
                        transacao.Rollback();

                        MessageBox.Show(
                            "A quantidade de saída é maior que o estoque disponível.",
                            "Estoque insuficiente",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );

                        return;
                    }

                    estoqueNovo =
                        estoqueAnterior -
                        quantidade;
                }

                string sqlAtualizar =
                    @"UPDATE insumos
                      SET
                        quantidade_atual = @novo,
                        data_atualizacao = NOW()
                      WHERE id = @id;";

                using MySqlCommand cmdAtualizar =
                    new MySqlCommand(
                        sqlAtualizar,
                        con,
                        transacao
                    );

                cmdAtualizar.Parameters.AddWithValue(
                    "@novo",
                    estoqueNovo
                );

                cmdAtualizar.Parameters.AddWithValue(
                    "@id",
                    insumoId
                );

                cmdAtualizar.ExecuteNonQuery();

                string sqlHistorico =
                    @"INSERT INTO movimentacoes_estoque
                    (
                        insumo_id,
                        tipo,
                        quantidade,
                        estoque_anterior,
                        estoque_novo,
                        motivo,
                        observacao
                    )
                    VALUES
                    (
                        @insumo,
                        @tipo,
                        @quantidade,
                        @anterior,
                        @novo,
                        @motivo,
                        @observacao
                    );";

                using MySqlCommand cmdHistorico =
                    new MySqlCommand(
                        sqlHistorico,
                        con,
                        transacao
                    );

                cmdHistorico.Parameters.AddWithValue(
                    "@insumo",
                    insumoId
                );

                cmdHistorico.Parameters.AddWithValue(
                    "@tipo",
                    cmbTipo.Text
                );

                cmdHistorico.Parameters.AddWithValue(
                    "@quantidade",
                    quantidade
                );

                cmdHistorico.Parameters.AddWithValue(
                    "@anterior",
                    estoqueAnterior
                );

                cmdHistorico.Parameters.AddWithValue(
                    "@novo",
                    estoqueNovo
                );

                cmdHistorico.Parameters.AddWithValue(
                    "@motivo",
                    cmbMotivo.Text
                );

                cmdHistorico.Parameters.AddWithValue(
                    "@observacao",
                    txtObservacao.Text.Trim()
                );

                cmdHistorico.ExecuteNonQuery();

                transacao.Commit();

                MessageBox.Show(
                    "Movimentação registrada com sucesso!",
                    "Estoque",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                CarregarInsumos();

                CarregarMovimentacoes();

                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Não foi possível registrar a movimentação.\n\n" +
                    ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ============================================================
        // CARREGAR HISTÓRICO RECENTE
        // ============================================================

        private void CarregarMovimentacoes()
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
                        DATE_FORMAT(
                            m.data_movimentacao,
                            '%d/%m %H:%i'
                        ) AS 'Data',

                        i.nome AS 'Insumo',

                        m.tipo AS 'Tipo',

                        m.quantidade AS 'Qtd.',

                        m.estoque_novo AS 'Estoque'

                    FROM movimentacoes_estoque m

                    INNER JOIN insumos i
                        ON i.id = m.insumo_id

                    ORDER BY
                        m.data_movimentacao DESC

                    LIMIT 20;";

                using MySqlDataAdapter adapter =
                    new MySqlDataAdapter(
                        sql,
                        con
                    );

                DataTable tabela =
                    new DataTable();

                adapter.Fill(tabela);

                dgvMovimentacoes.DataSource =
                    tabela;

                dgvMovimentacoes.ClearSelection();

                dgvMovimentacoes.CurrentCell =
                    null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Não foi possível carregar as movimentações.\n\n" +
                    ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ============================================================
        // LIMPAR
        // ============================================================

        private void btnLimpar_Click(
            object? sender,
            EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            cmbTipo.SelectedIndex =
                -1;

            cmbInsumo.SelectedIndex =
                -1;

            cmbMotivo.SelectedIndex =
                -1;

            nudQuantidade.Value =
                0;

            txtObservacao.Clear();

            estoqueAtual = 0;

            unidadeAtual = "";

            lblEstoqueAtualValor.Text =
                "0,00";

            lblNovoEstoqueValor.Text =
                "0,00";

            lblNovoEstoqueValor.ForeColor =
                Color.FromArgb(184, 112, 121);

            dgvMovimentacoes.ClearSelection();

            dgvMovimentacoes.CurrentCell =
                null;
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
            // Já estamos nesta tela.
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
            ListaCompras tela =
       new ListaCompras();

            tela.Show();

            this.Hide();
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