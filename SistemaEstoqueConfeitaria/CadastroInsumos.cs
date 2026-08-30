using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace SistemaEstoqueConfeitaria
{
    public partial class CadastroInsumos : Form
    {
        private int idSelecionado = 0;

        private bool arrastando = false;
        private Point posicaoMouseInicial;
        private Point posicaoFormInicial;

        public CadastroInsumos()
        {
            InitializeComponent();
            ConfigurarEventos();
        }

        // ============================================================
        // EVENTOS
        // ============================================================

        private void ConfigurarEventos()
        {
            Load -= CadastroInsumos_Load;
            Load += CadastroInsumos_Load;

            btnSalvar.Click -= btnSalvar_Click;
            btnSalvar.Click += btnSalvar_Click;

            btnLimpar.Click -= btnLimpar_Click;
            btnLimpar.Click += btnLimpar_Click;

            dgvInsumos.CellClick -= dgvInsumos_CellClick;
            dgvInsumos.CellClick += dgvInsumos_CellClick;

            txtPesquisar.TextChanged -= txtPesquisar_TextChanged;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;

            btnEditar.Click -= btnEditar_Click;
            btnEditar.Click += btnEditar_Click;

            btnExcluir.Click -= btnExcluir_Click;
            btnExcluir.Click += btnExcluir_Click;

            btnMenuPrincipal.Click -= btnMenuPrincipal_Click;
            btnMenuPrincipal.Click += btnMenuPrincipal_Click;

            btnCadastroInsumos.Click -= btnCadastroInsumos_Click;
            btnCadastroInsumos.Click += btnCadastroInsumos_Click;

            btnMovimentarEstoque.Click -= btnMovimentarEstoque_Click;
            btnMovimentarEstoque.Click += btnMovimentarEstoque_Click;

            btnEstoqueAtual.Click -= btnEstoqueAtual_Click;
            btnEstoqueAtual.Click += btnEstoqueAtual_Click;

            btnListaCompras.Click -= btnListaCompras_Click;
            btnListaCompras.Click += btnListaCompras_Click;

            btnHistorico.Click -= btnHistorico_Click;
            btnHistorico.Click += btnHistorico_Click;

            btnSair.Click -= btnSair_Click;
            btnSair.Click += btnSair_Click;

            MouseDown -= Janela_MouseDown;
            MouseDown += Janela_MouseDown;

            MouseMove -= Janela_MouseMove;
            MouseMove += Janela_MouseMove;

            MouseUp -= Janela_MouseUp;
            MouseUp += Janela_MouseUp;

            lblTitulo.MouseDown -= Janela_MouseDown;
            lblTitulo.MouseDown += Janela_MouseDown;

            lblTitulo.MouseMove -= Janela_MouseMove;
            lblTitulo.MouseMove += Janela_MouseMove;

            lblTitulo.MouseUp -= Janela_MouseUp;
            lblTitulo.MouseUp += Janela_MouseUp;
        }

        // ============================================================
        // LOAD
        // ============================================================

        private void CadastroInsumos_Load(
            object? sender,
            EventArgs e)
        {
            PrepararComboBoxes();
            ConfigurarDataGridView();
            CarregarInsumos();
            LimparCampos();
        }

        // ============================================================
        // COMBOBOX
        // ============================================================

        private void PrepararComboBoxes()
        {
            if (cmbCategoria.Items.Count == 0)
            {
                cmbCategoria.Items.AddRange(
                    new object[]
                    {
                        "Farinhas",
                        "Açúcares",
                        "Laticínios",
                        "Chocolates",
                        "Frutas",
                        "Confeitos",
                        "Embalagens",
                        "Outros"
                    }
                );
            }

            if (cmbUnidade.Items.Count == 0)
            {
                cmbUnidade.Items.AddRange(
                    new object[]
                    {
                        "kg",
                        "g",
                        "L",
                        "ml",
                        "un",
                        "pacote",
                        "caixa"
                    }
                );
            }
        }

        // ============================================================
        // DATAGRID
        // ============================================================

        private void ConfigurarDataGridView()
        {
            dgvInsumos.ReadOnly = true;

            dgvInsumos.AllowUserToAddRows = false;
            dgvInsumos.AllowUserToDeleteRows = false;
            dgvInsumos.AllowUserToResizeRows = false;

            dgvInsumos.MultiSelect = false;

            dgvInsumos.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvInsumos.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvInsumos.RowHeadersVisible = false;

            dgvInsumos.BackgroundColor =
                Color.White;

            dgvInsumos.BorderStyle =
                BorderStyle.FixedSingle;

            dgvInsumos.GridColor =
                Color.FromArgb(228, 206, 199);

            // Cabeçalho
            dgvInsumos.EnableHeadersVisualStyles =
                false;

            dgvInsumos
                .ColumnHeadersDefaultCellStyle
                .BackColor =
                Color.FromArgb(239, 229, 226);

            dgvInsumos
                .ColumnHeadersDefaultCellStyle
                .ForeColor =
                Color.FromArgb(94, 74, 68);

            dgvInsumos
                .ColumnHeadersDefaultCellStyle
                .Font =
                new Font(
                    "Segoe UI",
                    9.5F,
                    FontStyle.Bold
                );

            dgvInsumos
                .ColumnHeadersDefaultCellStyle
                .SelectionBackColor =
                Color.FromArgb(239, 229, 226);

            dgvInsumos
                .ColumnHeadersDefaultCellStyle
                .SelectionForeColor =
                Color.FromArgb(94, 74, 68);

            // Linhas
            dgvInsumos.DefaultCellStyle.BackColor =
                Color.White;

            dgvInsumos.DefaultCellStyle.ForeColor =
                Color.FromArgb(94, 74, 68);

            dgvInsumos.DefaultCellStyle.Font =
                new Font(
                    "Segoe UI",
                    9.5F,
                    FontStyle.Regular
                );

            // Seleção
            dgvInsumos
                .DefaultCellStyle
                .SelectionBackColor =
                Color.FromArgb(184, 112, 121);

            dgvInsumos
                .DefaultCellStyle
                .SelectionForeColor =
                Color.White;

            dgvInsumos
                .AlternatingRowsDefaultCellStyle
                .BackColor =
                Color.FromArgb(252, 250, 249);
        }

        // ============================================================
        // SALVAR NOVO INSUMO
        // ============================================================

        private void btnSalvar_Click(
            object? sender,
            EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            try
            {
                using SqliteConnection con =
                    BancoDados.Conectar();

                con.Open();

                string sql = @"
                    INSERT INTO insumos
                    (
                        nome,
                        categoria,
                        unidade,
                        quantidade_atual,
                        estoque_minimo,
                        valor_unitario,
                        fornecedor,
                        observacao
                    )
                    VALUES
                    (
                        @nome,
                        @categoria,
                        @unidade,
                        @quantidade,
                        @minimo,
                        @valor,
                        @fornecedor,
                        @observacao
                    );
                ";

                using SqliteCommand cmd =
                    new SqliteCommand(sql, con);

                cmd.Parameters.AddWithValue(
                    "@nome",
                    txtNome.Text.Trim()
                );

                cmd.Parameters.AddWithValue(
                    "@categoria",
                    cmbCategoria.Text
                );

                cmd.Parameters.AddWithValue(
                    "@unidade",
                    cmbUnidade.Text
                );

                cmd.Parameters.AddWithValue(
                    "@quantidade",
                    Convert.ToDouble(
                        nudQuantidade.Value
                    )
                );

                cmd.Parameters.AddWithValue(
                    "@minimo",
                    Convert.ToDouble(
                        nudEstoqueMinimo.Value
                    )
                );

                cmd.Parameters.AddWithValue(
                    "@valor",
                    Convert.ToDouble(
                        nudValorUnitario.Value
                    )
                );

                cmd.Parameters.AddWithValue(
                    "@fornecedor",
                    txtFornecedor.Text.Trim()
                );

                cmd.Parameters.AddWithValue(
                    "@observacao",
                    txtObservacao.Text.Trim()
                );

                cmd.ExecuteNonQuery();

                MessageBox.Show(
                    "Insumo cadastrado com sucesso!",
                    "Cadastro de Insumos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LimparCampos();
                CarregarInsumos();
            }
            catch (SqliteException ex)
            {
                MessageBox.Show(
                    "Não foi possível salvar o insumo.\n\n" +
                    ex.Message,
                    "Erro no banco de dados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocorreu um erro ao salvar o insumo.\n\n" +
                    ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ============================================================
        // VALIDAR CAMPOS
        // ============================================================

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(
                txtNome.Text))
            {
                MessageBox.Show(
                    "Digite o nome do insumo.",
                    "Campo obrigatório",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtNome.Focus();

                return false;
            }

            if (cmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Selecione uma categoria.",
                    "Campo obrigatório",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbCategoria.Focus();

                return false;
            }

            if (cmbUnidade.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Selecione a unidade.",
                    "Campo obrigatório",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbUnidade.Focus();

                return false;
            }

            return true;
        }

        // ============================================================
        // CARREGAR INSUMOS
        // ============================================================

        private void CarregarInsumos(
            string pesquisa = "")
        {
            try
            {
                using SqliteConnection con =
                    BancoDados.Conectar();

                con.Open();

                string sql = @"
                    SELECT
                        id,
                        nome AS 'Insumo',
                        categoria AS 'Categoria',
                        unidade AS 'Un.',
                        quantidade_atual AS 'Quantidade',
                        estoque_minimo AS 'Mínimo',
                        valor_unitario AS 'Valor'
                    FROM insumos
                    WHERE ativo = 1
                    AND nome LIKE @pesquisa
                    ORDER BY nome;
                ";

                using SqliteCommand cmd =
                    new SqliteCommand(sql, con);

                cmd.Parameters.AddWithValue(
                    "@pesquisa",
                    "%" + pesquisa + "%"
                );

                using SqliteDataReader leitor =
                    cmd.ExecuteReader();

                DataTable tabela =
                    new DataTable();

                tabela.Load(leitor);

                dgvInsumos.DataSource =
                    tabela;

                if (dgvInsumos.Columns["id"] != null)
                {
                    dgvInsumos
                        .Columns["id"]
                        .Visible = false;
                }

                dgvInsumos.ClearSelection();
                dgvInsumos.CurrentCell = null;

                idSelecionado = 0;
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
        // PESQUISA
        // ============================================================

        private void txtPesquisar_TextChanged(
            object? sender,
            EventArgs e)
        {
            CarregarInsumos(
                txtPesquisar.Text.Trim()
            );
        }

        // ============================================================
        // SELEÇÃO DA LINHA
        // ============================================================

        private void dgvInsumos_CellClick(
            object? sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow linha =
                dgvInsumos.Rows[e.RowIndex];

            if (linha.Cells["id"].Value == null)
            {
                return;
            }

            idSelecionado =
                Convert.ToInt32(
                    linha.Cells["id"].Value
                );
        }

        // ============================================================
        // EDITAR
        // ============================================================

        private void btnEditar_Click(
            object? sender,
            EventArgs e)
        {
            if (idSelecionado == 0)
            {
                MessageBox.Show(
                    "Selecione um insumo na lista.",
                    "Editar Insumo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            CarregarInsumoSelecionado();
        }

        private void CarregarInsumoSelecionado()
        {
            try
            {
                using SqliteConnection con =
                    BancoDados.Conectar();

                con.Open();

                string sql = @"
                    SELECT *
                    FROM insumos
                    WHERE id = @id
                    AND ativo = 1
                    LIMIT 1;
                ";

                using SqliteCommand cmd =
                    new SqliteCommand(sql, con);

                cmd.Parameters.AddWithValue(
                    "@id",
                    idSelecionado
                );

                using SqliteDataReader leitor =
                    cmd.ExecuteReader();

                if (leitor.Read())
                {
                    txtNome.Text =
                        leitor["nome"]?.ToString()
                        ?? "";

                    cmbCategoria.Text =
                        leitor["categoria"]?.ToString()
                        ?? "";

                    cmbUnidade.Text =
                        leitor["unidade"]?.ToString()
                        ?? "";

                    nudQuantidade.Value =
                        Convert.ToDecimal(
                            leitor["quantidade_atual"]
                        );

                    nudEstoqueMinimo.Value =
                        Convert.ToDecimal(
                            leitor["estoque_minimo"]
                        );

                    nudValorUnitario.Value =
                        Convert.ToDecimal(
                            leitor["valor_unitario"]
                        );

                    txtFornecedor.Text =
                        leitor["fornecedor"]?.ToString()
                        ?? "";

                    txtObservacao.Text =
                        leitor["observacao"]?.ToString()
                        ?? "";

                    btnSalvar.Text =
                        "Salvar Alterações";

                    btnSalvar.Click -=
                        btnSalvar_Click;

                    btnSalvar.Click -=
                        btnSalvarAlteracoes_Click;

                    btnSalvar.Click +=
                        btnSalvarAlteracoes_Click;

                    txtNome.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Não foi possível carregar o insumo.\n\n" +
                    ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ============================================================
        // SALVAR ALTERAÇÕES
        // ============================================================

        private void btnSalvarAlteracoes_Click(
            object? sender,
            EventArgs e)
        {
            if (idSelecionado == 0)
            {
                return;
            }

            if (!ValidarCampos())
            {
                return;
            }

            try
            {
                using SqliteConnection con =
                    BancoDados.Conectar();

                con.Open();

                string sql = @"
                    UPDATE insumos
                    SET
                        nome = @nome,
                        categoria = @categoria,
                        unidade = @unidade,
                        quantidade_atual = @quantidade,
                        estoque_minimo = @minimo,
                        valor_unitario = @valor,
                        fornecedor = @fornecedor,
                        observacao = @observacao,
                        data_atualizacao = CURRENT_TIMESTAMP
                    WHERE id = @id;
                ";

                using SqliteCommand cmd =
                    new SqliteCommand(sql, con);

                cmd.Parameters.AddWithValue(
                    "@nome",
                    txtNome.Text.Trim()
                );

                cmd.Parameters.AddWithValue(
                    "@categoria",
                    cmbCategoria.Text
                );

                cmd.Parameters.AddWithValue(
                    "@unidade",
                    cmbUnidade.Text
                );

                cmd.Parameters.AddWithValue(
                    "@quantidade",
                    Convert.ToDouble(
                        nudQuantidade.Value
                    )
                );

                cmd.Parameters.AddWithValue(
                    "@minimo",
                    Convert.ToDouble(
                        nudEstoqueMinimo.Value
                    )
                );

                cmd.Parameters.AddWithValue(
                    "@valor",
                    Convert.ToDouble(
                        nudValorUnitario.Value
                    )
                );

                cmd.Parameters.AddWithValue(
                    "@fornecedor",
                    txtFornecedor.Text.Trim()
                );

                cmd.Parameters.AddWithValue(
                    "@observacao",
                    txtObservacao.Text.Trim()
                );

                cmd.Parameters.AddWithValue(
                    "@id",
                    idSelecionado
                );

                cmd.ExecuteNonQuery();

                MessageBox.Show(
                    "Insumo atualizado com sucesso!",
                    "Cadastro de Insumos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                VoltarModoCadastro();
                LimparCampos();
                CarregarInsumos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Não foi possível atualizar o insumo.\n\n" +
                    ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ============================================================
        // EXCLUIR / DESATIVAR
        // ============================================================

        private void btnExcluir_Click(
            object? sender,
            EventArgs e)
        {
            if (idSelecionado == 0)
            {
                MessageBox.Show(
                    "Selecione um insumo na lista.",
                    "Excluir Insumo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DialogResult resposta =
                MessageBox.Show(
                    "Deseja realmente excluir este insumo?",
                    "Excluir Insumo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (resposta !=
                DialogResult.Yes)
            {
                return;
            }

            try
            {
                using SqliteConnection con =
                    BancoDados.Conectar();

                con.Open();

                string sql = @"
                    UPDATE insumos
                    SET
                        ativo = 0,
                        data_atualizacao = CURRENT_TIMESTAMP
                    WHERE id = @id;
                ";

                using SqliteCommand cmd =
                    new SqliteCommand(sql, con);

                cmd.Parameters.AddWithValue(
                    "@id",
                    idSelecionado
                );

                cmd.ExecuteNonQuery();

                MessageBox.Show(
                    "Insumo excluído com sucesso.",
                    "Cadastro de Insumos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LimparCampos();
                CarregarInsumos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Não foi possível excluir o insumo.\n\n" +
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
            VoltarModoCadastro();
        }

        private void LimparCampos()
        {
            idSelecionado = 0;

            txtNome.Clear();

            cmbCategoria.SelectedIndex = -1;
            cmbUnidade.SelectedIndex = -1;

            nudQuantidade.Value = 0;
            nudEstoqueMinimo.Value = 0;
            nudValorUnitario.Value = 0;

            txtFornecedor.Clear();
            txtObservacao.Clear();

            dgvInsumos.ClearSelection();
            dgvInsumos.CurrentCell = null;

            txtNome.Focus();
        }

        private void VoltarModoCadastro()
        {
            btnSalvar.Text =
                "Salvar Insumo";

            btnSalvar.Click -=
                btnSalvarAlteracoes_Click;

            btnSalvar.Click -=
                btnSalvar_Click;

            btnSalvar.Click +=
                btnSalvar_Click;
        }

        // ============================================================
        // MENU
        // ============================================================

        private void btnMenuPrincipal_Click(
            object? sender,
            EventArgs e)
        {
            MenuPrincipal menu =
                new MenuPrincipal();

            menu.Show();

            Hide();
        }

        private void btnCadastroInsumos_Click(
            object? sender,
            EventArgs e)
        {
            // Já está nesta tela.
        }

        private void btnMovimentarEstoque_Click(
            object? sender,
            EventArgs e)
        {
            MovimentarEstoque tela =
                new MovimentarEstoque();

            tela.Show();

            Hide();
        }

        private void btnEstoqueAtual_Click(
            object? sender,
            EventArgs e)
        {
            EstoqueAtual tela =
                new EstoqueAtual();

            tela.Show();

            Hide();
        }

        private void btnListaCompras_Click(
            object? sender,
            EventArgs e)
        {
            ListaCompras tela =
                new ListaCompras();

            tela.Show();

            Hide();
        }

        private void btnHistorico_Click(
            object? sender,
            EventArgs e)
        {
            HistoricoMovimentacoes tela =
                new HistoricoMovimentacoes();

            tela.Show();

            Hide();
        }

        private void btnSair_Click(
            object? sender,
            EventArgs e)
        {
            TelaLogin login =
                new TelaLogin();

            login.Show();

            Hide();
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