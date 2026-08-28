namespace SistemaEstoqueConfeitaria
{
    partial class CadastroInsumos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            btnSair = new Button();
            btnHistorico = new Button();
            btnListaCompras = new Button();
            btnEstoqueAtual = new Button();
            btnMovimentarEstoque = new Button();
            btnCadastroInsumos = new Button();
            btnMenuPrincipal = new Button();
            panelLinha = new Panel();
            pblogo = new PictureBox();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            panelCadastro = new Panel();
            btnSalvar = new Button();
            btnLimpar = new Button();
            txtObservacao = new TextBox();
            lblObservacao = new Label();
            txtFornecedor = new TextBox();
            lblFornecedor = new Label();
            nudValorUnitario = new NumericUpDown();
            lblValorUnitario = new Label();
            nudEstoqueMinimo = new NumericUpDown();
            lblEstoqueMinimo = new Label();
            nudQuantidade = new NumericUpDown();
            lblQuantidade = new Label();
            cmbUnidade = new ComboBox();
            lblUnidade = new Label();
            cmbCategoria = new ComboBox();
            lblCategoria = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            lblDadosInsumo = new Label();
            panelLista = new Panel();
            btnExcluir = new Button();
            btnEditar = new Button();
            dgvInsumos = new DataGridView();
            txtPesquisar = new TextBox();
            lblPesquisar = new Label();
            lblListaDescricao = new Label();
            lblLista = new Label();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pblogo).BeginInit();
            panelCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudValorUnitario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudEstoqueMinimo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).BeginInit();
            panelLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInsumos).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(239, 229, 226);
            panelMenu.BorderStyle = BorderStyle.FixedSingle;
            panelMenu.Controls.Add(btnSair);
            panelMenu.Controls.Add(btnHistorico);
            panelMenu.Controls.Add(btnListaCompras);
            panelMenu.Controls.Add(btnEstoqueAtual);
            panelMenu.Controls.Add(btnMovimentarEstoque);
            panelMenu.Controls.Add(btnCadastroInsumos);
            panelMenu.Controls.Add(btnMenuPrincipal);
            panelMenu.Controls.Add(panelLinha);
            panelMenu.Controls.Add(pblogo);
            panelMenu.Location = new Point(30, 90);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(260, 740);
            panelMenu.TabIndex = 1;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(201, 142, 124);
            btnSair.Cursor = Cursors.Hand;
            btnSair.FlatAppearance.BorderColor = Color.FromArgb(228, 206, 199);
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(20, 650);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(220, 60);
            btnSair.TabIndex = 9;
            btnSair.Text = "Sair\r\n";
            btnSair.UseVisualStyleBackColor = false;
            // 
            // btnHistorico
            // 
            btnHistorico.BackColor = Color.FromArgb(201, 142, 124);
            btnHistorico.Cursor = Cursors.Hand;
            btnHistorico.FlatAppearance.BorderColor = Color.FromArgb(228, 206, 199);
            btnHistorico.FlatStyle = FlatStyle.Flat;
            btnHistorico.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHistorico.ForeColor = Color.White;
            btnHistorico.Location = new Point(20, 535);
            btnHistorico.Name = "btnHistorico";
            btnHistorico.Size = new Size(220, 60);
            btnHistorico.TabIndex = 8;
            btnHistorico.Text = "Histórico de Movimentações\r\n";
            btnHistorico.UseVisualStyleBackColor = false;
            // 
            // btnListaCompras
            // 
            btnListaCompras.BackColor = Color.FromArgb(201, 142, 124);
            btnListaCompras.Cursor = Cursors.Hand;
            btnListaCompras.FlatAppearance.BorderColor = Color.FromArgb(228, 206, 199);
            btnListaCompras.FlatStyle = FlatStyle.Flat;
            btnListaCompras.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnListaCompras.ForeColor = Color.White;
            btnListaCompras.Location = new Point(20, 460);
            btnListaCompras.Name = "btnListaCompras";
            btnListaCompras.Size = new Size(220, 60);
            btnListaCompras.TabIndex = 7;
            btnListaCompras.Text = "Lista de Compras";
            btnListaCompras.UseVisualStyleBackColor = false;
            // 
            // btnEstoqueAtual
            // 
            btnEstoqueAtual.BackColor = Color.FromArgb(201, 142, 124);
            btnEstoqueAtual.Cursor = Cursors.Hand;
            btnEstoqueAtual.FlatAppearance.BorderColor = Color.FromArgb(228, 206, 199);
            btnEstoqueAtual.FlatStyle = FlatStyle.Flat;
            btnEstoqueAtual.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEstoqueAtual.ForeColor = Color.White;
            btnEstoqueAtual.Location = new Point(20, 385);
            btnEstoqueAtual.Name = "btnEstoqueAtual";
            btnEstoqueAtual.Size = new Size(220, 60);
            btnEstoqueAtual.TabIndex = 6;
            btnEstoqueAtual.Text = "Estoque Atual";
            btnEstoqueAtual.UseVisualStyleBackColor = false;
            // 
            // btnMovimentarEstoque
            // 
            btnMovimentarEstoque.BackColor = Color.FromArgb(201, 142, 124);
            btnMovimentarEstoque.Cursor = Cursors.Hand;
            btnMovimentarEstoque.FlatAppearance.BorderColor = Color.FromArgb(228, 206, 199);
            btnMovimentarEstoque.FlatStyle = FlatStyle.Flat;
            btnMovimentarEstoque.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMovimentarEstoque.ForeColor = Color.White;
            btnMovimentarEstoque.Location = new Point(20, 310);
            btnMovimentarEstoque.Name = "btnMovimentarEstoque";
            btnMovimentarEstoque.Size = new Size(220, 60);
            btnMovimentarEstoque.TabIndex = 5;
            btnMovimentarEstoque.Text = "Movimentar Estoque";
            btnMovimentarEstoque.UseVisualStyleBackColor = false;
            // 
            // btnCadastroInsumos
            // 
            btnCadastroInsumos.BackColor = Color.FromArgb(184, 112, 121);
            btnCadastroInsumos.Cursor = Cursors.Hand;
            btnCadastroInsumos.FlatAppearance.BorderColor = Color.FromArgb(228, 206, 199);
            btnCadastroInsumos.FlatStyle = FlatStyle.Flat;
            btnCadastroInsumos.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastroInsumos.ForeColor = Color.White;
            btnCadastroInsumos.Location = new Point(20, 235);
            btnCadastroInsumos.Name = "btnCadastroInsumos";
            btnCadastroInsumos.Size = new Size(220, 60);
            btnCadastroInsumos.TabIndex = 4;
            btnCadastroInsumos.Text = "Cadastro Insumos";
            btnCadastroInsumos.UseVisualStyleBackColor = false;
            // 
            // btnMenuPrincipal
            // 
            btnMenuPrincipal.BackColor = Color.FromArgb(201, 142, 124);
            btnMenuPrincipal.Cursor = Cursors.Hand;
            btnMenuPrincipal.FlatAppearance.BorderColor = Color.FromArgb(228, 206, 199);
            btnMenuPrincipal.FlatStyle = FlatStyle.Flat;
            btnMenuPrincipal.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenuPrincipal.ForeColor = Color.White;
            btnMenuPrincipal.Location = new Point(20, 160);
            btnMenuPrincipal.Name = "btnMenuPrincipal";
            btnMenuPrincipal.Size = new Size(220, 60);
            btnMenuPrincipal.TabIndex = 3;
            btnMenuPrincipal.Text = "Menu Principal";
            btnMenuPrincipal.UseVisualStyleBackColor = false;
            // 
            // panelLinha
            // 
            panelLinha.BackColor = Color.FromArgb(216, 194, 187);
            panelLinha.Location = new Point(20, 138);
            panelLinha.Name = "panelLinha";
            panelLinha.Size = new Size(220, 2);
            panelLinha.TabIndex = 2;
            // 
            // pblogo
            // 
            pblogo.BackColor = Color.Transparent;
            pblogo.Image = Properties.Resources.Logo__2_;
            pblogo.Location = new Point(52, 10);
            pblogo.Name = "pblogo";
            pblogo.Size = new Size(150, 110);
            pblogo.SizeMode = PictureBoxSizeMode.Zoom;
            pblogo.TabIndex = 1;
            pblogo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(94, 74, 68);
            lblTitulo.ImageAlign = ContentAlignment.MiddleLeft;
            lblTitulo.Location = new Point(335, 90);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(600, 55);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "CADASTRO DE INSUMOS";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.BackColor = Color.Transparent;
            lblSubtitulo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.FromArgb(142, 111, 101);
            lblSubtitulo.ImageAlign = ContentAlignment.MiddleLeft;
            lblSubtitulo.Location = new Point(340, 145);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(500, 35);
            lblSubtitulo.TabIndex = 3;
            lblSubtitulo.Text = "Cadastre e organize os materiais utilizados na produção.\r\n\r\n";
            // 
            // panelCadastro
            // 
            panelCadastro.BackColor = Color.FromArgb(252, 250, 249);
            panelCadastro.BorderStyle = BorderStyle.FixedSingle;
            panelCadastro.Controls.Add(btnSalvar);
            panelCadastro.Controls.Add(btnLimpar);
            panelCadastro.Controls.Add(txtObservacao);
            panelCadastro.Controls.Add(lblObservacao);
            panelCadastro.Controls.Add(txtFornecedor);
            panelCadastro.Controls.Add(lblFornecedor);
            panelCadastro.Controls.Add(nudValorUnitario);
            panelCadastro.Controls.Add(lblValorUnitario);
            panelCadastro.Controls.Add(nudEstoqueMinimo);
            panelCadastro.Controls.Add(lblEstoqueMinimo);
            panelCadastro.Controls.Add(nudQuantidade);
            panelCadastro.Controls.Add(lblQuantidade);
            panelCadastro.Controls.Add(cmbUnidade);
            panelCadastro.Controls.Add(lblUnidade);
            panelCadastro.Controls.Add(cmbCategoria);
            panelCadastro.Controls.Add(lblCategoria);
            panelCadastro.Controls.Add(txtNome);
            panelCadastro.Controls.Add(lblNome);
            panelCadastro.Controls.Add(lblDadosInsumo);
            panelCadastro.Location = new Point(335, 215);
            panelCadastro.Name = "panelCadastro";
            panelCadastro.Size = new Size(620, 585);
            panelCadastro.TabIndex = 4;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(201, 142, 124);
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(30, 525);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(355, 42);
            btnSalvar.TabIndex = 22;
            btnSalvar.Text = "Salvar Insumo";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(247, 242, 241);
            btnLimpar.Cursor = Cursors.Hand;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.ForeColor = Color.FromArgb(123, 97, 88);
            btnLimpar.Location = new Point(429, 525);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(180, 42);
            btnLimpar.TabIndex = 21;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            // 
            // txtObservacao
            // 
            txtObservacao.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtObservacao.Location = new Point(30, 455);
            txtObservacao.Multiline = true;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.ScrollBars = ScrollBars.Vertical;
            txtObservacao.Size = new Size(569, 55);
            txtObservacao.TabIndex = 20;
            // 
            // lblObservacao
            // 
            lblObservacao.BackColor = Color.Transparent;
            lblObservacao.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblObservacao.ForeColor = Color.FromArgb(123, 97, 88);
            lblObservacao.ImageAlign = ContentAlignment.MiddleLeft;
            lblObservacao.Location = new Point(30, 425);
            lblObservacao.Name = "lblObservacao";
            lblObservacao.Size = new Size(150, 25);
            lblObservacao.TabIndex = 19;
            lblObservacao.Text = "Observação";
            // 
            // txtFornecedor
            // 
            txtFornecedor.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFornecedor.Location = new Point(320, 370);
            txtFornecedor.Name = "txtFornecedor";
            txtFornecedor.PlaceholderText = "Ex.: Atacadista";
            txtFornecedor.Size = new Size(279, 27);
            txtFornecedor.TabIndex = 18;
            // 
            // lblFornecedor
            // 
            lblFornecedor.BackColor = Color.Transparent;
            lblFornecedor.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFornecedor.ForeColor = Color.FromArgb(123, 97, 88);
            lblFornecedor.ImageAlign = ContentAlignment.MiddleLeft;
            lblFornecedor.Location = new Point(320, 340);
            lblFornecedor.Name = "lblFornecedor";
            lblFornecedor.Size = new Size(150, 25);
            lblFornecedor.TabIndex = 17;
            lblFornecedor.Text = "Fornecedor\r\n";
            // 
            // nudValorUnitario
            // 
            nudValorUnitario.DecimalPlaces = 2;
            nudValorUnitario.Location = new Point(30, 370);
            nudValorUnitario.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudValorUnitario.Name = "nudValorUnitario";
            nudValorUnitario.Size = new Size(260, 23);
            nudValorUnitario.TabIndex = 16;
            nudValorUnitario.ThousandsSeparator = true;
            // 
            // lblValorUnitario
            // 
            lblValorUnitario.BackColor = Color.Transparent;
            lblValorUnitario.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValorUnitario.ForeColor = Color.FromArgb(123, 97, 88);
            lblValorUnitario.ImageAlign = ContentAlignment.MiddleLeft;
            lblValorUnitario.Location = new Point(30, 340);
            lblValorUnitario.Name = "lblValorUnitario";
            lblValorUnitario.Size = new Size(150, 25);
            lblValorUnitario.TabIndex = 15;
            lblValorUnitario.Text = "Valor unitário";
            // 
            // nudEstoqueMinimo
            // 
            nudEstoqueMinimo.DecimalPlaces = 2;
            nudEstoqueMinimo.Location = new Point(320, 285);
            nudEstoqueMinimo.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudEstoqueMinimo.Name = "nudEstoqueMinimo";
            nudEstoqueMinimo.Size = new Size(279, 23);
            nudEstoqueMinimo.TabIndex = 14;
            // 
            // lblEstoqueMinimo
            // 
            lblEstoqueMinimo.BackColor = Color.Transparent;
            lblEstoqueMinimo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstoqueMinimo.ForeColor = Color.FromArgb(123, 97, 88);
            lblEstoqueMinimo.ImageAlign = ContentAlignment.MiddleLeft;
            lblEstoqueMinimo.Location = new Point(320, 255);
            lblEstoqueMinimo.Name = "lblEstoqueMinimo";
            lblEstoqueMinimo.Size = new Size(150, 25);
            lblEstoqueMinimo.TabIndex = 13;
            lblEstoqueMinimo.Text = "Estoque mínimo";
            // 
            // nudQuantidade
            // 
            nudQuantidade.Location = new Point(30, 285);
            nudQuantidade.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudQuantidade.Name = "nudQuantidade";
            nudQuantidade.Size = new Size(260, 23);
            nudQuantidade.TabIndex = 12;
            // 
            // lblQuantidade
            // 
            lblQuantidade.BackColor = Color.Transparent;
            lblQuantidade.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantidade.ForeColor = Color.FromArgb(123, 97, 88);
            lblQuantidade.ImageAlign = ContentAlignment.MiddleLeft;
            lblQuantidade.Location = new Point(30, 255);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(150, 25);
            lblQuantidade.TabIndex = 11;
            lblQuantidade.Text = "Quantidade atual";
            // 
            // cmbUnidade
            // 
            cmbUnidade.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUnidade.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbUnidade.FormattingEnabled = true;
            cmbUnidade.Items.AddRange(new object[] { "kg", "", "g", "", "L", "", "ml", "", "un", "", "pacote", "", "caixa" });
            cmbUnidade.Location = new Point(320, 200);
            cmbUnidade.Name = "cmbUnidade";
            cmbUnidade.Size = new Size(160, 28);
            cmbUnidade.TabIndex = 10;
            // 
            // lblUnidade
            // 
            lblUnidade.BackColor = Color.Transparent;
            lblUnidade.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUnidade.ForeColor = Color.FromArgb(123, 97, 88);
            lblUnidade.ImageAlign = ContentAlignment.MiddleLeft;
            lblUnidade.Location = new Point(320, 170);
            lblUnidade.Name = "lblUnidade";
            lblUnidade.Size = new Size(150, 25);
            lblUnidade.TabIndex = 9;
            lblUnidade.Text = "Unidade";
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "Farinhas", "", "Açúcares", "", "Laticínios", "", "Chocolates", "", "Frutas", "", "Confeitos", "", "Embalagens", "", "Outros" });
            cmbCategoria.Location = new Point(30, 200);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(260, 28);
            cmbCategoria.TabIndex = 8;
            // 
            // lblCategoria
            // 
            lblCategoria.BackColor = Color.Transparent;
            lblCategoria.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoria.ForeColor = Color.FromArgb(123, 97, 88);
            lblCategoria.ImageAlign = ContentAlignment.MiddleLeft;
            lblCategoria.Location = new Point(30, 170);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(200, 25);
            lblCategoria.TabIndex = 7;
            lblCategoria.Text = "Categoria\r\n\r\n";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(30, 120);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Ex.: Farinha de trigo";
            txtNome.Size = new Size(569, 27);
            txtNome.TabIndex = 6;
            // 
            // lblNome
            // 
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.ForeColor = Color.FromArgb(123, 97, 88);
            lblNome.ImageAlign = ContentAlignment.MiddleLeft;
            lblNome.Location = new Point(30, 92);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(200, 25);
            lblNome.TabIndex = 5;
            lblNome.Text = "Nome do insumo\r\n";
            // 
            // lblDadosInsumo
            // 
            lblDadosInsumo.BackColor = Color.Transparent;
            lblDadosInsumo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDadosInsumo.ForeColor = Color.FromArgb(111, 84, 75);
            lblDadosInsumo.ImageAlign = ContentAlignment.MiddleLeft;
            lblDadosInsumo.Location = new Point(30, 25);
            lblDadosInsumo.Name = "lblDadosInsumo";
            lblDadosInsumo.Size = new Size(300, 40);
            lblDadosInsumo.TabIndex = 4;
            lblDadosInsumo.Text = "Dados do insumo\r\n";
            // 
            // panelLista
            // 
            panelLista.BorderStyle = BorderStyle.FixedSingle;
            panelLista.Controls.Add(btnExcluir);
            panelLista.Controls.Add(btnEditar);
            panelLista.Controls.Add(dgvInsumos);
            panelLista.Controls.Add(txtPesquisar);
            panelLista.Controls.Add(lblPesquisar);
            panelLista.Controls.Add(lblListaDescricao);
            panelLista.Controls.Add(lblLista);
            panelLista.Location = new Point(985, 215);
            panelLista.Name = "panelLista";
            panelLista.Size = new Size(500, 585);
            panelLista.TabIndex = 5;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.FromArgb(247, 242, 241);
            btnExcluir.Cursor = Cursors.Hand;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = Color.FromArgb(184, 112, 121);
            btnExcluir.Location = new Point(260, 540);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(215, 35);
            btnExcluir.TabIndex = 24;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(243, 232, 228);
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.FromArgb(201, 142, 124);
            btnEditar.Location = new Point(25, 540);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(215, 35);
            btnEditar.TabIndex = 23;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // dgvInsumos
            // 
            dgvInsumos.AllowUserToAddRows = false;
            dgvInsumos.AllowUserToDeleteRows = false;
            dgvInsumos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInsumos.BackgroundColor = Color.White;
            dgvInsumos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInsumos.Location = new Point(25, 195);
            dgvInsumos.Name = "dgvInsumos";
            dgvInsumos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInsumos.Size = new Size(450, 335);
            dgvInsumos.TabIndex = 10;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPesquisar.Location = new Point(25, 145);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PlaceholderText = "Digite o nome do insumo...";
            txtPesquisar.Size = new Size(450, 27);
            txtPesquisar.TabIndex = 9;
            // 
            // lblPesquisar
            // 
            lblPesquisar.BackColor = Color.Transparent;
            lblPesquisar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPesquisar.ForeColor = Color.FromArgb(123, 97, 88);
            lblPesquisar.ImageAlign = ContentAlignment.MiddleLeft;
            lblPesquisar.Location = new Point(25, 115);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(200, 25);
            lblPesquisar.TabIndex = 8;
            lblPesquisar.Text = "Pesquisar\r\n";
            // 
            // lblListaDescricao
            // 
            lblListaDescricao.BackColor = Color.Transparent;
            lblListaDescricao.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblListaDescricao.ForeColor = Color.FromArgb(142, 111, 101);
            lblListaDescricao.ImageAlign = ContentAlignment.MiddleLeft;
            lblListaDescricao.Location = new Point(25, 65);
            lblListaDescricao.Name = "lblListaDescricao";
            lblListaDescricao.Size = new Size(400, 30);
            lblListaDescricao.TabIndex = 6;
            lblListaDescricao.Text = "Consulte rapidamente os itens já cadastrados.\r\n\r\n\r\n";
            // 
            // lblLista
            // 
            lblLista.BackColor = Color.Transparent;
            lblLista.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLista.ForeColor = Color.FromArgb(111, 84, 75);
            lblLista.ImageAlign = ContentAlignment.MiddleLeft;
            lblLista.Location = new Point(25, 25);
            lblLista.Name = "lblLista";
            lblLista.Size = new Size(300, 40);
            lblLista.TabIndex = 5;
            lblLista.Text = "Insumos cadastrados\r\n\r\n";
            // 
            // CadastroInsumos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 242, 241);
            ClientSize = new Size(1584, 861);
            Controls.Add(panelLista);
            Controls.Add(panelCadastro);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            MinimizeBox = false;
            Name = "CadastroInsumos";
            Text = "Cadastro de Insumos";
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pblogo).EndInit();
            panelCadastro.ResumeLayout(false);
            panelCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudValorUnitario).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudEstoqueMinimo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).EndInit();
            panelLista.ResumeLayout(false);
            panelLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInsumos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnSair;
        private Button btnHistorico;
        private Button btnListaCompras;
        private Button btnEstoqueAtual;
        private Button btnMovimentarEstoque;
        private Button btnCadastroInsumos;
        private Button btnMenuPrincipal;
        private Panel panelLinha;
        private PictureBox pblogo;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Panel panelCadastro;
        private Label lblNome;
        private Label lblDadosInsumo;
        private ComboBox cmbCategoria;
        private Label lblCategoria;
        private TextBox txtNome;
        private Label lblQuantidade;
        private ComboBox cmbUnidade;
        private Label lblUnidade;
        private Label lblValorUnitario;
        private NumericUpDown nudEstoqueMinimo;
        private Label lblEstoqueMinimo;
        private NumericUpDown nudQuantidade;
        private TextBox txtObservacao;
        private Label lblObservacao;
        private TextBox txtFornecedor;
        private Label lblFornecedor;
        private NumericUpDown nudValorUnitario;
        private Button btnSalvar;
        private Button btnLimpar;
        private Panel panelLista;
        private TextBox txtPesquisar;
        private Label lblPesquisar;
        private Label lblListaDescricao;
        private Label lblLista;
        private Button btnEditar;
        private DataGridView dgvInsumos;
        private Button btnExcluir;
    }
}