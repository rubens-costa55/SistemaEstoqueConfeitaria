using System.Drawing;
using System.Windows.Forms;

namespace SistemaEstoqueConfeitaria
{
    partial class EstoqueAtual
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
            lblPesquisar = new Label();
            txtPesquisar = new TextBox();
            lblFiltroStatus = new Label();
            cmbStatus = new ComboBox();
            btnAtualizar = new Button();
            panelTotal = new Panel();
            lblTextoTotal = new Label();
            lblTotal = new Label();
            panelOk = new Panel();
            lblTextoOk = new Label();
            lblOk = new Label();
            panelBaixo = new Panel();
            lblTextoBaixo = new Label();
            lblBaixo = new Label();
            panelCritico = new Panel();
            lblTextoCritico = new Label();
            lblCritico = new Label();
            panelLista = new Panel();
            lblLista = new Label();
            lblListaDescricao = new Label();
            dgvEstoque = new DataGridView();
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
            panelOk.SuspendLayout();
            panelBaixo.SuspendLayout();
            panelCritico.SuspendLayout();
            panelLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).BeginInit();
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
            lblTitulo.Size = new Size(600, 55);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "ESTOQUE ATUAL";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Font = new Font("Segoe UI", 11F);
            lblSubtitulo.ForeColor = Color.FromArgb(142, 111, 101);
            lblSubtitulo.Location = new Point(340, 145);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(700, 35);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Acompanhe as quantidades disponíveis dos insumos.";
            // 
            // panelFiltros
            // 
            panelFiltros.BackColor = Color.FromArgb(252, 250, 249);
            panelFiltros.BorderStyle = BorderStyle.FixedSingle;
            panelFiltros.Controls.Add(lblPesquisar);
            panelFiltros.Controls.Add(txtPesquisar);
            panelFiltros.Controls.Add(lblFiltroStatus);
            panelFiltros.Controls.Add(cmbStatus);
            panelFiltros.Controls.Add(btnAtualizar);
            panelFiltros.Location = new Point(335, 205);
            panelFiltros.Name = "panelFiltros";
            panelFiltros.Size = new Size(1150, 100);
            panelFiltros.TabIndex = 3;
            // 
            // lblPesquisar
            // 
            lblPesquisar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPesquisar.ForeColor = Color.FromArgb(123, 97, 88);
            lblPesquisar.Location = new Point(25, 15);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(200, 22);
            lblPesquisar.TabIndex = 0;
            lblPesquisar.Text = "Pesquisar insumo";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Font = new Font("Segoe UI", 11F);
            txtPesquisar.Location = new Point(25, 42);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PlaceholderText = "Digite o nome do insumo...";
            txtPesquisar.Size = new Size(500, 27);
            txtPesquisar.TabIndex = 1;
            // 
            // lblFiltroStatus
            // 
            lblFiltroStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFiltroStatus.ForeColor = Color.FromArgb(123, 97, 88);
            lblFiltroStatus.Location = new Point(555, 15);
            lblFiltroStatus.Name = "lblFiltroStatus";
            lblFiltroStatus.Size = new Size(180, 22);
            lblFiltroStatus.TabIndex = 2;
            lblFiltroStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 11F);
            cmbStatus.Items.AddRange(new object[] { "Todos", "OK", "Baixo", "Crítico" });
            cmbStatus.Location = new Point(555, 42);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(300, 28);
            cmbStatus.TabIndex = 3;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.FromArgb(201, 142, 124);
            btnAtualizar.Cursor = Cursors.Hand;
            btnAtualizar.FlatAppearance.BorderSize = 0;
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnAtualizar.ForeColor = Color.White;
            btnAtualizar.Location = new Point(885, 40);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(235, 35);
            btnAtualizar.TabIndex = 4;
            btnAtualizar.Text = "Atualizar Estoque";
            btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // panelTotal
            // 
            panelTotal.BackColor = Color.FromArgb(252, 250, 249);
            panelTotal.BorderStyle = BorderStyle.FixedSingle;
            panelTotal.Controls.Add(lblTextoTotal);
            panelTotal.Controls.Add(lblTotal);
            panelTotal.Location = new Point(335, 330);
            panelTotal.Name = "panelTotal";
            panelTotal.Size = new Size(260, 100);
            panelTotal.TabIndex = 4;
            // 
            // lblTextoTotal
            // 
            lblTextoTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTextoTotal.ForeColor = Color.FromArgb(142, 111, 101);
            lblTextoTotal.Location = new Point(20, 15);
            lblTextoTotal.Name = "lblTextoTotal";
            lblTextoTotal.Size = new Size(200, 25);
            lblTextoTotal.TabIndex = 0;
            lblTextoTotal.Text = "Total de insumos";
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(94, 74, 68);
            lblTotal.Location = new Point(20, 42);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(210, 45);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "0";
            // 
            // panelOk
            // 
            panelOk.BackColor = Color.FromArgb(235, 244, 236);
            panelOk.BorderStyle = BorderStyle.FixedSingle;
            panelOk.Controls.Add(lblTextoOk);
            panelOk.Controls.Add(lblOk);
            panelOk.Location = new Point(630, 330);
            panelOk.Name = "panelOk";
            panelOk.Size = new Size(260, 100);
            panelOk.TabIndex = 5;
            // 
            // lblTextoOk
            // 
            lblTextoOk.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTextoOk.ForeColor = Color.FromArgb(83, 117, 88);
            lblTextoOk.Location = new Point(20, 15);
            lblTextoOk.Name = "lblTextoOk";
            lblTextoOk.Size = new Size(200, 25);
            lblTextoOk.TabIndex = 0;
            lblTextoOk.Text = "Estoque OK";
            // 
            // lblOk
            // 
            lblOk.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblOk.ForeColor = Color.FromArgb(67, 107, 75);
            lblOk.Location = new Point(20, 42);
            lblOk.Name = "lblOk";
            lblOk.Size = new Size(210, 45);
            lblOk.TabIndex = 1;
            lblOk.Text = "0";
            // 
            // panelBaixo
            // 
            panelBaixo.BackColor = Color.FromArgb(250, 241, 219);
            panelBaixo.BorderStyle = BorderStyle.FixedSingle;
            panelBaixo.Controls.Add(lblTextoBaixo);
            panelBaixo.Controls.Add(lblBaixo);
            panelBaixo.Location = new Point(925, 330);
            panelBaixo.Name = "panelBaixo";
            panelBaixo.Size = new Size(260, 100);
            panelBaixo.TabIndex = 6;
            // 
            // lblTextoBaixo
            // 
            lblTextoBaixo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTextoBaixo.ForeColor = Color.FromArgb(145, 111, 46);
            lblTextoBaixo.Location = new Point(20, 15);
            lblTextoBaixo.Name = "lblTextoBaixo";
            lblTextoBaixo.Size = new Size(200, 25);
            lblTextoBaixo.TabIndex = 0;
            lblTextoBaixo.Text = "Estoque baixo";
            // 
            // lblBaixo
            // 
            lblBaixo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblBaixo.ForeColor = Color.FromArgb(154, 112, 37);
            lblBaixo.Location = new Point(20, 42);
            lblBaixo.Name = "lblBaixo";
            lblBaixo.Size = new Size(210, 45);
            lblBaixo.TabIndex = 1;
            lblBaixo.Text = "0";
            // 
            // panelCritico
            // 
            panelCritico.BackColor = Color.FromArgb(249, 229, 229);
            panelCritico.BorderStyle = BorderStyle.FixedSingle;
            panelCritico.Controls.Add(lblTextoCritico);
            panelCritico.Controls.Add(lblCritico);
            panelCritico.Location = new Point(1220, 330);
            panelCritico.Name = "panelCritico";
            panelCritico.Size = new Size(265, 100);
            panelCritico.TabIndex = 7;
            // 
            // lblTextoCritico
            // 
            lblTextoCritico.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTextoCritico.ForeColor = Color.FromArgb(151, 78, 78);
            lblTextoCritico.Location = new Point(20, 15);
            lblTextoCritico.Name = "lblTextoCritico";
            lblTextoCritico.Size = new Size(200, 25);
            lblTextoCritico.TabIndex = 0;
            lblTextoCritico.Text = "Estoque crítico";
            // 
            // lblCritico
            // 
            lblCritico.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblCritico.ForeColor = Color.FromArgb(146, 65, 65);
            lblCritico.Location = new Point(20, 42);
            lblCritico.Name = "lblCritico";
            lblCritico.Size = new Size(210, 45);
            lblCritico.TabIndex = 1;
            lblCritico.Text = "0";
            // 
            // panelLista
            // 
            panelLista.BackColor = Color.FromArgb(252, 250, 249);
            panelLista.BorderStyle = BorderStyle.FixedSingle;
            panelLista.Controls.Add(lblLista);
            panelLista.Controls.Add(lblListaDescricao);
            panelLista.Controls.Add(dgvEstoque);
            panelLista.Location = new Point(335, 455);
            panelLista.Name = "panelLista";
            panelLista.Size = new Size(1150, 345);
            panelLista.TabIndex = 8;
            // 
            // lblLista
            // 
            lblLista.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblLista.ForeColor = Color.FromArgb(111, 84, 75);
            lblLista.Location = new Point(25, 18);
            lblLista.Name = "lblLista";
            lblLista.Size = new Size(350, 32);
            lblLista.TabIndex = 0;
            lblLista.Text = "Situação dos insumos";
            // 
            // lblListaDescricao
            // 
            lblListaDescricao.Font = new Font("Segoe UI", 10F);
            lblListaDescricao.ForeColor = Color.FromArgb(142, 111, 101);
            lblListaDescricao.Location = new Point(25, 50);
            lblListaDescricao.Name = "lblListaDescricao";
            lblListaDescricao.Size = new Size(650, 25);
            lblListaDescricao.TabIndex = 1;
            lblListaDescricao.Text = "Consulte a quantidade atual e o nível mínimo de cada insumo.";
            // 
            // dgvEstoque
            // 
            dgvEstoque.AllowUserToAddRows = false;
            dgvEstoque.AllowUserToDeleteRows = false;
            dgvEstoque.AllowUserToResizeRows = false;
            dgvEstoque.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEstoque.BackgroundColor = Color.White;
            dgvEstoque.Location = new Point(25, 90);
            dgvEstoque.MultiSelect = false;
            dgvEstoque.Name = "dgvEstoque";
            dgvEstoque.ReadOnly = true;
            dgvEstoque.RowHeadersVisible = false;
            dgvEstoque.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEstoque.Size = new Size(1100, 225);
            dgvEstoque.TabIndex = 2;
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
            panelMenu.TabIndex = 9;
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
            btnEstoqueAtual.BackColor = Color.FromArgb(184, 112, 121);
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
            // EstoqueAtual
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
            Controls.Add(panelOk);
            Controls.Add(panelBaixo);
            Controls.Add(panelCritico);
            Controls.Add(panelLista);
            FormBorderStyle = FormBorderStyle.None;
            MinimizeBox = false;
            Name = "EstoqueAtual";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estoque Atual";
            panelFiltros.ResumeLayout(false);
            panelFiltros.PerformLayout();
            panelTotal.ResumeLayout(false);
            panelOk.ResumeLayout(false);
            panelBaixo.ResumeLayout(false);
            panelCritico.ResumeLayout(false);
            panelLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).EndInit();
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pblogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Label lblSubtitulo;

        private Panel panelFiltros;
        private Label lblPesquisar;
        private TextBox txtPesquisar;
        private Label lblFiltroStatus;
        private ComboBox cmbStatus;
        private Button btnAtualizar;

        private Panel panelTotal;
        private Label lblTextoTotal;
        private Label lblTotal;

        private Panel panelOk;
        private Label lblTextoOk;
        private Label lblOk;

        private Panel panelBaixo;
        private Label lblTextoBaixo;
        private Label lblBaixo;

        private Panel panelCritico;
        private Label lblTextoCritico;
        private Label lblCritico;

        private Panel panelLista;
        private Label lblLista;
        private Label lblListaDescricao;

        private DataGridView dgvEstoque;
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