namespace SistemaEstoqueConfeitaria
{
    partial class MovimentarEstoque
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            panelMovimentacao = new Panel();
            lblNovaMovimentacao = new Label();
            lblTipo = new Label();
            cmbTipo = new ComboBox();
            lblInsumo = new Label();
            cmbInsumo = new ComboBox();
            panelEstoqueAtual = new Panel();
            lblTextoEstoqueAtual = new Label();
            lblEstoqueAtualValor = new Label();
            panelNovoEstoque = new Panel();
            lblTextoNovoEstoque = new Label();
            lblNovoEstoqueValor = new Label();
            lblQuantidade = new Label();
            nudQuantidade = new NumericUpDown();
            lblMotivo = new Label();
            cmbMotivo = new ComboBox();
            lblObservacao = new Label();
            txtObservacao = new TextBox();
            btnLimpar = new Button();
            btnRegistrar = new Button();
            panelRecentes = new Panel();
            lblRecentes = new Label();
            lblRecentesDescricao = new Label();
            dgvMovimentacoes = new DataGridView();
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
            panelMovimentacao.SuspendLayout();
            panelEstoqueAtual.SuspendLayout();
            panelNovoEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).BeginInit();
            panelRecentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovimentacoes).BeginInit();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pblogo).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(94, 74, 68);
            lblTitulo.Location = new Point(335, 90);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(650, 55);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "MOVIMENTAR ESTOQUE";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Font = new Font("Segoe UI", 11F);
            lblSubtitulo.ForeColor = Color.FromArgb(142, 111, 101);
            lblSubtitulo.Location = new Point(340, 145);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(700, 35);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Registre entradas e saídas dos insumos da confeitaria.";
            // 
            // panelMovimentacao
            // 
            panelMovimentacao.BackColor = Color.FromArgb(252, 250, 249);
            panelMovimentacao.BorderStyle = BorderStyle.FixedSingle;
            panelMovimentacao.Controls.Add(lblNovaMovimentacao);
            panelMovimentacao.Controls.Add(lblTipo);
            panelMovimentacao.Controls.Add(cmbTipo);
            panelMovimentacao.Controls.Add(lblInsumo);
            panelMovimentacao.Controls.Add(cmbInsumo);
            panelMovimentacao.Controls.Add(panelEstoqueAtual);
            panelMovimentacao.Controls.Add(panelNovoEstoque);
            panelMovimentacao.Controls.Add(lblQuantidade);
            panelMovimentacao.Controls.Add(nudQuantidade);
            panelMovimentacao.Controls.Add(lblMotivo);
            panelMovimentacao.Controls.Add(cmbMotivo);
            panelMovimentacao.Controls.Add(lblObservacao);
            panelMovimentacao.Controls.Add(txtObservacao);
            panelMovimentacao.Controls.Add(btnLimpar);
            panelMovimentacao.Controls.Add(btnRegistrar);
            panelMovimentacao.Location = new Point(335, 215);
            panelMovimentacao.Name = "panelMovimentacao";
            panelMovimentacao.Size = new Size(650, 585);
            panelMovimentacao.TabIndex = 3;
            // 
            // lblNovaMovimentacao
            // 
            lblNovaMovimentacao.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblNovaMovimentacao.ForeColor = Color.FromArgb(111, 84, 75);
            lblNovaMovimentacao.Location = new Point(30, 25);
            lblNovaMovimentacao.Name = "lblNovaMovimentacao";
            lblNovaMovimentacao.Size = new Size(350, 40);
            lblNovaMovimentacao.TabIndex = 0;
            lblNovaMovimentacao.Text = "Nova movimentação";
            // 
            // lblTipo
            // 
            lblTipo.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblTipo.ForeColor = Color.FromArgb(123, 97, 88);
            lblTipo.Location = new Point(30, 90);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(250, 25);
            lblTipo.TabIndex = 1;
            lblTipo.Text = "Tipo de movimentação";
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.Font = new Font("Segoe UI", 11F);
            cmbTipo.Items.AddRange(new object[] { "Entrada", "Saída" });
            cmbTipo.Location = new Point(30, 120);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(590, 28);
            cmbTipo.TabIndex = 2;
            // 
            // lblInsumo
            // 
            lblInsumo.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblInsumo.ForeColor = Color.FromArgb(123, 97, 88);
            lblInsumo.Location = new Point(30, 170);
            lblInsumo.Name = "lblInsumo";
            lblInsumo.Size = new Size(150, 25);
            lblInsumo.TabIndex = 3;
            lblInsumo.Text = "Insumo";
            // 
            // cmbInsumo
            // 
            cmbInsumo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbInsumo.Font = new Font("Segoe UI", 11F);
            cmbInsumo.Location = new Point(30, 200);
            cmbInsumo.Name = "cmbInsumo";
            cmbInsumo.Size = new Size(590, 28);
            cmbInsumo.TabIndex = 4;
            // 
            // panelEstoqueAtual
            // 
            panelEstoqueAtual.BackColor = Color.FromArgb(243, 232, 228);
            panelEstoqueAtual.BorderStyle = BorderStyle.FixedSingle;
            panelEstoqueAtual.Controls.Add(lblTextoEstoqueAtual);
            panelEstoqueAtual.Controls.Add(lblEstoqueAtualValor);
            panelEstoqueAtual.Location = new Point(30, 255);
            panelEstoqueAtual.Name = "panelEstoqueAtual";
            panelEstoqueAtual.Size = new Size(280, 75);
            panelEstoqueAtual.TabIndex = 5;
            // 
            // lblTextoEstoqueAtual
            // 
            lblTextoEstoqueAtual.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTextoEstoqueAtual.ForeColor = Color.FromArgb(142, 111, 101);
            lblTextoEstoqueAtual.Location = new Point(15, 10);
            lblTextoEstoqueAtual.Name = "lblTextoEstoqueAtual";
            lblTextoEstoqueAtual.Size = new Size(150, 22);
            lblTextoEstoqueAtual.TabIndex = 0;
            lblTextoEstoqueAtual.Text = "Estoque atual";
            // 
            // lblEstoqueAtualValor
            // 
            lblEstoqueAtualValor.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblEstoqueAtualValor.ForeColor = Color.FromArgb(94, 74, 68);
            lblEstoqueAtualValor.Location = new Point(15, 34);
            lblEstoqueAtualValor.Name = "lblEstoqueAtualValor";
            lblEstoqueAtualValor.Size = new Size(245, 30);
            lblEstoqueAtualValor.TabIndex = 1;
            lblEstoqueAtualValor.Text = "0,00";
            // 
            // panelNovoEstoque
            // 
            panelNovoEstoque.BackColor = Color.FromArgb(239, 229, 226);
            panelNovoEstoque.BorderStyle = BorderStyle.FixedSingle;
            panelNovoEstoque.Controls.Add(lblTextoNovoEstoque);
            panelNovoEstoque.Controls.Add(lblNovoEstoqueValor);
            panelNovoEstoque.Location = new Point(340, 255);
            panelNovoEstoque.Name = "panelNovoEstoque";
            panelNovoEstoque.Size = new Size(280, 75);
            panelNovoEstoque.TabIndex = 6;
            // 
            // lblTextoNovoEstoque
            // 
            lblTextoNovoEstoque.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTextoNovoEstoque.ForeColor = Color.FromArgb(142, 111, 101);
            lblTextoNovoEstoque.Location = new Point(15, 10);
            lblTextoNovoEstoque.Name = "lblTextoNovoEstoque";
            lblTextoNovoEstoque.Size = new Size(150, 22);
            lblTextoNovoEstoque.TabIndex = 0;
            lblTextoNovoEstoque.Text = "Novo estoque";
            // 
            // lblNovoEstoqueValor
            // 
            lblNovoEstoqueValor.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblNovoEstoqueValor.ForeColor = Color.FromArgb(184, 112, 121);
            lblNovoEstoqueValor.Location = new Point(15, 34);
            lblNovoEstoqueValor.Name = "lblNovoEstoqueValor";
            lblNovoEstoqueValor.Size = new Size(245, 30);
            lblNovoEstoqueValor.TabIndex = 1;
            lblNovoEstoqueValor.Text = "0,00";
            // 
            // lblQuantidade
            // 
            lblQuantidade.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblQuantidade.ForeColor = Color.FromArgb(123, 97, 88);
            lblQuantidade.Location = new Point(30, 355);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(180, 25);
            lblQuantidade.TabIndex = 7;
            lblQuantidade.Text = "Quantidade";
            // 
            // nudQuantidade
            // 
            nudQuantidade.DecimalPlaces = 2;
            nudQuantidade.Font = new Font("Segoe UI", 11F);
            nudQuantidade.Location = new Point(30, 385);
            nudQuantidade.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            nudQuantidade.Name = "nudQuantidade";
            nudQuantidade.Size = new Size(280, 27);
            nudQuantidade.TabIndex = 8;
            // 
            // lblMotivo
            // 
            lblMotivo.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblMotivo.ForeColor = Color.FromArgb(123, 97, 88);
            lblMotivo.Location = new Point(340, 355);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(180, 25);
            lblMotivo.TabIndex = 9;
            lblMotivo.Text = "Motivo";
            // 
            // cmbMotivo
            // 
            cmbMotivo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMotivo.Font = new Font("Segoe UI", 11F);
            cmbMotivo.Items.AddRange(new object[] { "Compra", "Produção", "Ajuste de estoque", "Perda", "Vencimento", "Devolução", "Outro" });
            cmbMotivo.Location = new Point(340, 385);
            cmbMotivo.Name = "cmbMotivo";
            cmbMotivo.Size = new Size(280, 28);
            cmbMotivo.TabIndex = 10;
            // 
            // lblObservacao
            // 
            lblObservacao.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblObservacao.ForeColor = Color.FromArgb(123, 97, 88);
            lblObservacao.Location = new Point(30, 440);
            lblObservacao.Name = "lblObservacao";
            lblObservacao.Size = new Size(180, 25);
            lblObservacao.TabIndex = 11;
            lblObservacao.Text = "Observação";
            // 
            // txtObservacao
            // 
            txtObservacao.Font = new Font("Segoe UI", 10.5F);
            txtObservacao.Location = new Point(30, 470);
            txtObservacao.Multiline = true;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.ScrollBars = ScrollBars.Vertical;
            txtObservacao.Size = new Size(590, 55);
            txtObservacao.TabIndex = 12;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(247, 242, 241);
            btnLimpar.Cursor = Cursors.Hand;
            btnLimpar.FlatAppearance.BorderColor = Color.FromArgb(228, 206, 199);
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLimpar.ForeColor = Color.FromArgb(123, 97, 88);
            btnLimpar.Location = new Point(30, 535);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(180, 42);
            btnLimpar.TabIndex = 13;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(201, 142, 124);
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(225, 535);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(395, 42);
            btnRegistrar.TabIndex = 14;
            btnRegistrar.Text = "Registrar Movimentação";
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // panelRecentes
            // 
            panelRecentes.BackColor = Color.FromArgb(252, 250, 249);
            panelRecentes.BorderStyle = BorderStyle.FixedSingle;
            panelRecentes.Controls.Add(lblRecentes);
            panelRecentes.Controls.Add(lblRecentesDescricao);
            panelRecentes.Controls.Add(dgvMovimentacoes);
            panelRecentes.Location = new Point(1015, 215);
            panelRecentes.Name = "panelRecentes";
            panelRecentes.Size = new Size(470, 585);
            panelRecentes.TabIndex = 4;
            // 
            // lblRecentes
            // 
            lblRecentes.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblRecentes.ForeColor = Color.FromArgb(111, 84, 75);
            lblRecentes.Location = new Point(25, 25);
            lblRecentes.Name = "lblRecentes";
            lblRecentes.Size = new Size(390, 40);
            lblRecentes.TabIndex = 0;
            lblRecentes.Text = "Movimentações recentes";
            // 
            // lblRecentesDescricao
            // 
            lblRecentesDescricao.Font = new Font("Segoe UI", 10.5F);
            lblRecentesDescricao.ForeColor = Color.FromArgb(142, 111, 101);
            lblRecentesDescricao.Location = new Point(25, 65);
            lblRecentesDescricao.Name = "lblRecentesDescricao";
            lblRecentesDescricao.Size = new Size(410, 35);
            lblRecentesDescricao.TabIndex = 1;
            lblRecentesDescricao.Text = "Últimas entradas e saídas registradas no estoque.";
            // 
            // dgvMovimentacoes
            // 
            dgvMovimentacoes.AllowUserToAddRows = false;
            dgvMovimentacoes.AllowUserToDeleteRows = false;
            dgvMovimentacoes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMovimentacoes.BackgroundColor = Color.White;
            dgvMovimentacoes.Location = new Point(25, 120);
            dgvMovimentacoes.MultiSelect = false;
            dgvMovimentacoes.Name = "dgvMovimentacoes";
            dgvMovimentacoes.ReadOnly = true;
            dgvMovimentacoes.RowHeadersVisible = false;
            dgvMovimentacoes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMovimentacoes.Size = new Size(420, 425);
            dgvMovimentacoes.TabIndex = 2;
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
            panelMenu.TabIndex = 5;
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
            btnMovimentarEstoque.BackColor = Color.FromArgb(184, 112, 121);
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
            btnCadastroInsumos.BackColor = Color.FromArgb(201, 142, 124);
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
            // MovimentarEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 242, 241);
            ClientSize = new Size(1600, 900);
            Controls.Add(panelMenu);
            Controls.Add(lblTitulo);
            Controls.Add(lblSubtitulo);
            Controls.Add(panelMovimentacao);
            Controls.Add(panelRecentes);
            FormBorderStyle = FormBorderStyle.None;
            MinimizeBox = false;
            Name = "MovimentarEstoque";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Movimentar Estoque";
            panelMovimentacao.ResumeLayout(false);
            panelMovimentacao.PerformLayout();
            panelEstoqueAtual.ResumeLayout(false);
            panelNovoEstoque.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).EndInit();
            panelRecentes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMovimentacoes).EndInit();
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pblogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Label lblSubtitulo;

        private Panel panelMovimentacao;
        private Label lblNovaMovimentacao;

        private Label lblTipo;
        private ComboBox cmbTipo;

        private Label lblInsumo;
        private ComboBox cmbInsumo;

        private Panel panelEstoqueAtual;
        private Label lblTextoEstoqueAtual;
        private Label lblEstoqueAtualValor;

        private Panel panelNovoEstoque;
        private Label lblTextoNovoEstoque;
        private Label lblNovoEstoqueValor;

        private Label lblQuantidade;
        private NumericUpDown nudQuantidade;

        private Label lblMotivo;
        private ComboBox cmbMotivo;

        private Label lblObservacao;
        private TextBox txtObservacao;

        private Button btnLimpar;
        private Button btnRegistrar;

        private Panel panelRecentes;
        private Label lblRecentes;
        private Label lblRecentesDescricao;

        private DataGridView dgvMovimentacoes;
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
    }
}