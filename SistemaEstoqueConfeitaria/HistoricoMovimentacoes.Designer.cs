using System.Drawing;
using System.Windows.Forms;

namespace SistemaEstoqueConfeitaria
{
    partial class HistoricoMovimentacoes
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
            panelFiltros = new Panel();
            lblDataInicial = new Label();
            dtpDataInicial = new DateTimePicker();
            lblDataFinal = new Label();
            dtpDataFinal = new DateTimePicker();
            lblInsumo = new Label();
            cmbInsumo = new ComboBox();
            lblTipo = new Label();
            cmbTipo = new ComboBox();
            lblMotivo = new Label();
            cmbMotivo = new ComboBox();
            lblPesquisar = new Label();
            txtPesquisar = new TextBox();
            btnAtualizar = new Button();
            btnLimparFiltros = new Button();
            panelTotal = new Panel();
            lblTextoTotal = new Label();
            lblTotal = new Label();
            panelEntradas = new Panel();
            lblTextoEntradas = new Label();
            lblEntradas = new Label();
            panelSaidas = new Panel();
            lblTextoSaidas = new Label();
            lblSaidas = new Label();
            panelLista = new Panel();
            lblLista = new Label();
            lblListaDescricao = new Label();
            dgvHistorico = new DataGridView();
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
            panelFiltros.SuspendLayout();
            panelTotal.SuspendLayout();
            panelEntradas.SuspendLayout();
            panelSaidas.SuspendLayout();
            panelLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).BeginInit();
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
            lblTitulo.Size = new Size(800, 55);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "HISTÓRICO DE MOVIMENTAÇÕES";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Font = new Font("Segoe UI", 11F);
            lblSubtitulo.ForeColor = Color.FromArgb(142, 111, 101);
            lblSubtitulo.Location = new Point(340, 145);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(800, 35);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Consulte todas as entradas e saídas registradas no estoque.";
            // 
            // panelFiltros
            // 
            panelFiltros.BackColor = Color.FromArgb(252, 250, 249);
            panelFiltros.BorderStyle = BorderStyle.FixedSingle;
            panelFiltros.Controls.Add(lblDataInicial);
            panelFiltros.Controls.Add(dtpDataInicial);
            panelFiltros.Controls.Add(lblDataFinal);
            panelFiltros.Controls.Add(dtpDataFinal);
            panelFiltros.Controls.Add(lblInsumo);
            panelFiltros.Controls.Add(cmbInsumo);
            panelFiltros.Controls.Add(lblTipo);
            panelFiltros.Controls.Add(cmbTipo);
            panelFiltros.Controls.Add(lblMotivo);
            panelFiltros.Controls.Add(cmbMotivo);
            panelFiltros.Controls.Add(lblPesquisar);
            panelFiltros.Controls.Add(txtPesquisar);
            panelFiltros.Controls.Add(btnAtualizar);
            panelFiltros.Controls.Add(btnLimparFiltros);
            panelFiltros.Location = new Point(335, 205);
            panelFiltros.Name = "panelFiltros";
            panelFiltros.Size = new Size(1150, 150);
            panelFiltros.TabIndex = 3;
            // 
            // lblDataInicial
            // 
            lblDataInicial.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblDataInicial.ForeColor = Color.FromArgb(123, 97, 88);
            lblDataInicial.Location = new Point(25, 15);
            lblDataInicial.Name = "lblDataInicial";
            lblDataInicial.Size = new Size(170, 22);
            lblDataInicial.TabIndex = 0;
            lblDataInicial.Text = "Data inicial";
            // 
            // dtpDataInicial
            // 
            dtpDataInicial.Checked = false;
            dtpDataInicial.CustomFormat = "dd/MM/yyyy";
            dtpDataInicial.Font = new Font("Segoe UI", 10F);
            dtpDataInicial.Format = DateTimePickerFormat.Custom;
            dtpDataInicial.Location = new Point(25, 40);
            dtpDataInicial.Name = "dtpDataInicial";
            dtpDataInicial.ShowCheckBox = true;
            dtpDataInicial.Size = new Size(180, 25);
            dtpDataInicial.TabIndex = 1;
            // 
            // lblDataFinal
            // 
            lblDataFinal.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblDataFinal.ForeColor = Color.FromArgb(123, 97, 88);
            lblDataFinal.Location = new Point(225, 15);
            lblDataFinal.Name = "lblDataFinal";
            lblDataFinal.Size = new Size(170, 22);
            lblDataFinal.TabIndex = 2;
            lblDataFinal.Text = "Data final";
            // 
            // dtpDataFinal
            // 
            dtpDataFinal.Checked = false;
            dtpDataFinal.CustomFormat = "dd/MM/yyyy";
            dtpDataFinal.Font = new Font("Segoe UI", 10F);
            dtpDataFinal.Format = DateTimePickerFormat.Custom;
            dtpDataFinal.Location = new Point(225, 40);
            dtpDataFinal.Name = "dtpDataFinal";
            dtpDataFinal.ShowCheckBox = true;
            dtpDataFinal.Size = new Size(180, 25);
            dtpDataFinal.TabIndex = 3;
            // 
            // lblInsumo
            // 
            lblInsumo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblInsumo.ForeColor = Color.FromArgb(123, 97, 88);
            lblInsumo.Location = new Point(425, 15);
            lblInsumo.Name = "lblInsumo";
            lblInsumo.Size = new Size(200, 22);
            lblInsumo.TabIndex = 4;
            lblInsumo.Text = "Insumo";
            // 
            // cmbInsumo
            // 
            cmbInsumo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbInsumo.Font = new Font("Segoe UI", 10F);
            cmbInsumo.Location = new Point(425, 40);
            cmbInsumo.Name = "cmbInsumo";
            cmbInsumo.Size = new Size(260, 25);
            cmbInsumo.TabIndex = 5;
            // 
            // lblTipo
            // 
            lblTipo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTipo.ForeColor = Color.FromArgb(123, 97, 88);
            lblTipo.Location = new Point(705, 15);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(170, 22);
            lblTipo.TabIndex = 6;
            lblTipo.Text = "Tipo";
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.Font = new Font("Segoe UI", 10F);
            cmbTipo.Items.AddRange(new object[] { "Todos", "Entrada", "Saída" });
            cmbTipo.Location = new Point(705, 40);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(180, 25);
            cmbTipo.TabIndex = 7;
            // 
            // lblMotivo
            // 
            lblMotivo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblMotivo.ForeColor = Color.FromArgb(123, 97, 88);
            lblMotivo.Location = new Point(905, 15);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(200, 22);
            lblMotivo.TabIndex = 8;
            lblMotivo.Text = "Motivo";
            // 
            // cmbMotivo
            // 
            cmbMotivo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMotivo.Font = new Font("Segoe UI", 10F);
            cmbMotivo.Items.AddRange(new object[] { "Todos", "Compra", "Produção", "Ajuste de estoque", "Perda", "Vencimento", "Devolução", "Outro" });
            cmbMotivo.Location = new Point(905, 40);
            cmbMotivo.Name = "cmbMotivo";
            cmbMotivo.Size = new Size(220, 25);
            cmbMotivo.TabIndex = 9;
            // 
            // lblPesquisar
            // 
            lblPesquisar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPesquisar.ForeColor = Color.FromArgb(123, 97, 88);
            lblPesquisar.Location = new Point(25, 82);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(250, 22);
            lblPesquisar.TabIndex = 10;
            lblPesquisar.Text = "Pesquisar";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Font = new Font("Segoe UI", 10F);
            txtPesquisar.Location = new Point(25, 107);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PlaceholderText = "Digite o nome do insumo, motivo ou observação...";
            txtPesquisar.Size = new Size(600, 25);
            txtPesquisar.TabIndex = 11;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.FromArgb(201, 142, 124);
            btnAtualizar.Cursor = Cursors.Hand;
            btnAtualizar.FlatAppearance.BorderSize = 0;
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAtualizar.ForeColor = Color.White;
            btnAtualizar.Location = new Point(650, 104);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(220, 35);
            btnAtualizar.TabIndex = 12;
            btnAtualizar.Text = "Atualizar Histórico";
            btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // btnLimparFiltros
            // 
            btnLimparFiltros.BackColor = Color.FromArgb(247, 242, 241);
            btnLimparFiltros.Cursor = Cursors.Hand;
            btnLimparFiltros.FlatAppearance.BorderColor = Color.FromArgb(228, 206, 199);
            btnLimparFiltros.FlatStyle = FlatStyle.Flat;
            btnLimparFiltros.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLimparFiltros.ForeColor = Color.FromArgb(123, 97, 88);
            btnLimparFiltros.Location = new Point(895, 104);
            btnLimparFiltros.Name = "btnLimparFiltros";
            btnLimparFiltros.Size = new Size(230, 35);
            btnLimparFiltros.TabIndex = 13;
            btnLimparFiltros.Text = "Limpar Filtros";
            btnLimparFiltros.UseVisualStyleBackColor = false;
            // 
            // panelTotal
            // 
            panelTotal.BackColor = Color.FromArgb(252, 250, 249);
            panelTotal.BorderStyle = BorderStyle.FixedSingle;
            panelTotal.Controls.Add(lblTextoTotal);
            panelTotal.Controls.Add(lblTotal);
            panelTotal.Location = new Point(335, 380);
            panelTotal.Name = "panelTotal";
            panelTotal.Size = new Size(350, 100);
            panelTotal.TabIndex = 4;
            // 
            // lblTextoTotal
            // 
            lblTextoTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTextoTotal.ForeColor = Color.FromArgb(142, 111, 101);
            lblTextoTotal.Location = new Point(20, 15);
            lblTextoTotal.Name = "lblTextoTotal";
            lblTextoTotal.Size = new Size(250, 25);
            lblTextoTotal.TabIndex = 0;
            lblTextoTotal.Text = "Movimentações exibidas";
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(94, 74, 68);
            lblTotal.Location = new Point(20, 42);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(250, 45);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "0";
            // 
            // panelEntradas
            // 
            panelEntradas.BackColor = Color.FromArgb(235, 244, 236);
            panelEntradas.BorderStyle = BorderStyle.FixedSingle;
            panelEntradas.Controls.Add(lblTextoEntradas);
            panelEntradas.Controls.Add(lblEntradas);
            panelEntradas.Location = new Point(735, 380);
            panelEntradas.Name = "panelEntradas";
            panelEntradas.Size = new Size(350, 100);
            panelEntradas.TabIndex = 5;
            // 
            // lblTextoEntradas
            // 
            lblTextoEntradas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTextoEntradas.ForeColor = Color.FromArgb(83, 117, 88);
            lblTextoEntradas.Location = new Point(20, 15);
            lblTextoEntradas.Name = "lblTextoEntradas";
            lblTextoEntradas.Size = new Size(250, 25);
            lblTextoEntradas.TabIndex = 0;
            lblTextoEntradas.Text = "Entradas";
            // 
            // lblEntradas
            // 
            lblEntradas.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblEntradas.ForeColor = Color.FromArgb(67, 107, 75);
            lblEntradas.Location = new Point(20, 42);
            lblEntradas.Name = "lblEntradas";
            lblEntradas.Size = new Size(250, 45);
            lblEntradas.TabIndex = 1;
            lblEntradas.Text = "0";
            // 
            // panelSaidas
            // 
            panelSaidas.BackColor = Color.FromArgb(249, 229, 229);
            panelSaidas.BorderStyle = BorderStyle.FixedSingle;
            panelSaidas.Controls.Add(lblTextoSaidas);
            panelSaidas.Controls.Add(lblSaidas);
            panelSaidas.Location = new Point(1135, 380);
            panelSaidas.Name = "panelSaidas";
            panelSaidas.Size = new Size(350, 100);
            panelSaidas.TabIndex = 6;
            // 
            // lblTextoSaidas
            // 
            lblTextoSaidas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTextoSaidas.ForeColor = Color.FromArgb(151, 78, 78);
            lblTextoSaidas.Location = new Point(20, 15);
            lblTextoSaidas.Name = "lblTextoSaidas";
            lblTextoSaidas.Size = new Size(250, 25);
            lblTextoSaidas.TabIndex = 0;
            lblTextoSaidas.Text = "Saídas";
            // 
            // lblSaidas
            // 
            lblSaidas.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblSaidas.ForeColor = Color.FromArgb(146, 65, 65);
            lblSaidas.Location = new Point(20, 42);
            lblSaidas.Name = "lblSaidas";
            lblSaidas.Size = new Size(250, 45);
            lblSaidas.TabIndex = 1;
            lblSaidas.Text = "0";
            // 
            // panelLista
            // 
            panelLista.BackColor = Color.FromArgb(252, 250, 249);
            panelLista.BorderStyle = BorderStyle.FixedSingle;
            panelLista.Controls.Add(lblLista);
            panelLista.Controls.Add(lblListaDescricao);
            panelLista.Controls.Add(dgvHistorico);
            panelLista.Location = new Point(335, 505);
            panelLista.Name = "panelLista";
            panelLista.Size = new Size(1150, 295);
            panelLista.TabIndex = 7;
            // 
            // lblLista
            // 
            lblLista.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblLista.ForeColor = Color.FromArgb(111, 84, 75);
            lblLista.Location = new Point(25, 15);
            lblLista.Name = "lblLista";
            lblLista.Size = new Size(450, 32);
            lblLista.TabIndex = 0;
            lblLista.Text = "Movimentações registradas";
            // 
            // lblListaDescricao
            // 
            lblListaDescricao.Font = new Font("Segoe UI", 10F);
            lblListaDescricao.ForeColor = Color.FromArgb(142, 111, 101);
            lblListaDescricao.Location = new Point(25, 47);
            lblListaDescricao.Name = "lblListaDescricao";
            lblListaDescricao.Size = new Size(700, 25);
            lblListaDescricao.TabIndex = 1;
            lblListaDescricao.Text = "Histórico completo das alterações realizadas no estoque.";
            // 
            // dgvHistorico
            // 
            dgvHistorico.AllowUserToAddRows = false;
            dgvHistorico.AllowUserToDeleteRows = false;
            dgvHistorico.AllowUserToResizeRows = false;
            dgvHistorico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorico.BackgroundColor = Color.White;
            dgvHistorico.Location = new Point(25, 80);
            dgvHistorico.MultiSelect = false;
            dgvHistorico.Name = "dgvHistorico";
            dgvHistorico.ReadOnly = true;
            dgvHistorico.RowHeadersVisible = false;
            dgvHistorico.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorico.Size = new Size(1100, 190);
            dgvHistorico.TabIndex = 2;
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
            panelMenu.TabIndex = 8;
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
            btnHistorico.BackColor = Color.FromArgb(184, 112, 121);
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
            // HistoricoMovimentacoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 242, 241);
            ClientSize = new Size(1600, 900);
            Controls.Add(panelMenu);
            Controls.Add(lblTitulo);
            Controls.Add(lblSubtitulo);
            Controls.Add(panelFiltros);
            Controls.Add(panelTotal);
            Controls.Add(panelEntradas);
            Controls.Add(panelSaidas);
            Controls.Add(panelLista);
            FormBorderStyle = FormBorderStyle.None;
            MinimizeBox = false;
            Name = "HistoricoMovimentacoes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Histórico de Movimentações";
            panelFiltros.ResumeLayout(false);
            panelFiltros.PerformLayout();
            panelTotal.ResumeLayout(false);
            panelEntradas.ResumeLayout(false);
            panelSaidas.ResumeLayout(false);
            panelLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).EndInit();
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pblogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Label lblSubtitulo;

        private Panel panelFiltros;

        private Label lblDataInicial;
        private DateTimePicker dtpDataInicial;

        private Label lblDataFinal;
        private DateTimePicker dtpDataFinal;

        private Label lblInsumo;
        private ComboBox cmbInsumo;

        private Label lblTipo;
        private ComboBox cmbTipo;

        private Label lblMotivo;
        private ComboBox cmbMotivo;

        private Label lblPesquisar;
        private TextBox txtPesquisar;

        private Button btnAtualizar;
        private Button btnLimparFiltros;

        private Panel panelTotal;
        private Label lblTextoTotal;
        private Label lblTotal;

        private Panel panelEntradas;
        private Label lblTextoEntradas;
        private Label lblEntradas;

        private Panel panelSaidas;
        private Label lblTextoSaidas;
        private Label lblSaidas;

        private Panel panelLista;
        private Label lblLista;
        private Label lblListaDescricao;

        private DataGridView dgvHistorico;
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