using System.Drawing;
using System.Windows.Forms;

namespace SistemaEstoqueConfeitaria
{
    partial class RedefinirSenha
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
            panelPrincipal = new Panel();
            pblogo = new PictureBox();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblCpf = new Label();
            txtCpf = new TextBox();
            lblNovaSenha = new Label();
            txtNovaSenha = new TextBox();
            pbolhoNovaSenha = new PictureBox();
            lblConfirmarSenha = new Label();
            txtConfirmarSenha = new TextBox();
            pbolhoConfirmarSenha = new PictureBox();
            btnRedefinir = new Button();
            btnVoltar = new Button();
            lblSair = new Label();
            panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pblogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbolhoNovaSenha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbolhoConfirmarSenha).BeginInit();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(249, 245, 243);
            panelPrincipal.BorderStyle = BorderStyle.FixedSingle;
            panelPrincipal.Controls.Add(pblogo);
            panelPrincipal.Controls.Add(lblTitulo);
            panelPrincipal.Controls.Add(lblSubtitulo);
            panelPrincipal.Controls.Add(lblCpf);
            panelPrincipal.Controls.Add(txtCpf);
            panelPrincipal.Controls.Add(lblNovaSenha);
            panelPrincipal.Controls.Add(txtNovaSenha);
            panelPrincipal.Controls.Add(pbolhoNovaSenha);
            panelPrincipal.Controls.Add(lblConfirmarSenha);
            panelPrincipal.Controls.Add(txtConfirmarSenha);
            panelPrincipal.Controls.Add(pbolhoConfirmarSenha);
            panelPrincipal.Controls.Add(btnRedefinir);
            panelPrincipal.Controls.Add(btnVoltar);
            panelPrincipal.Location = new Point(475, 90);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(650, 720);
            panelPrincipal.TabIndex = 0;
            // 
            // pblogo
            // 
            pblogo.BackColor = Color.Transparent;
            pblogo.Image = Properties.Resources.Logo__2_;
            pblogo.Location = new Point(225, 30);
            pblogo.Name = "pblogo";
            pblogo.Size = new Size(200, 140);
            pblogo.SizeMode = PictureBoxSizeMode.Zoom;
            pblogo.TabIndex = 0;
            pblogo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(94, 74, 68);
            lblTitulo.Location = new Point(70, 185);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(510, 50);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "REDEFINIR SENHA";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Font = new Font("Segoe UI", 10.5F);
            lblSubtitulo.ForeColor = Color.FromArgb(142, 111, 101);
            lblSubtitulo.Location = new Point(65, 235);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(520, 45);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Informe seu CPF cadastrado e escolha uma nova senha.";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCpf
            // 
            lblCpf.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblCpf.ForeColor = Color.FromArgb(123, 97, 88);
            lblCpf.Location = new Point(80, 310);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(150, 25);
            lblCpf.TabIndex = 3;
            lblCpf.Text = "CPF";
            // 
            // txtCpf
            // 
            txtCpf.Font = new Font("Segoe UI", 11F);
            txtCpf.Location = new Point(80, 340);
            txtCpf.MaxLength = 14;
            txtCpf.Name = "txtCpf";
            txtCpf.PlaceholderText = "Digite seu CPF";
            txtCpf.Size = new Size(490, 27);
            txtCpf.TabIndex = 4;
            // 
            // lblNovaSenha
            // 
            lblNovaSenha.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblNovaSenha.ForeColor = Color.FromArgb(123, 97, 88);
            lblNovaSenha.Location = new Point(80, 395);
            lblNovaSenha.Name = "lblNovaSenha";
            lblNovaSenha.Size = new Size(180, 25);
            lblNovaSenha.TabIndex = 5;
            lblNovaSenha.Text = "Nova senha";
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Font = new Font("Segoe UI", 11F);
            txtNovaSenha.Location = new Point(80, 425);
            txtNovaSenha.MaxLength = 100;
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.PasswordChar = '●';
            txtNovaSenha.PlaceholderText = "Digite a nova senha";
            txtNovaSenha.Size = new Size(445, 27);
            txtNovaSenha.TabIndex = 6;
            // 
            // pbolhoNovaSenha
            // 
            pbolhoNovaSenha.BackColor = Color.Transparent;
            pbolhoNovaSenha.Cursor = Cursors.Hand;
            pbolhoNovaSenha.Image = Properties.Resources.olho_aberto;
            pbolhoNovaSenha.Location = new Point(535, 425);
            pbolhoNovaSenha.Name = "pbolhoNovaSenha";
            pbolhoNovaSenha.Size = new Size(35, 30);
            pbolhoNovaSenha.SizeMode = PictureBoxSizeMode.Zoom;
            pbolhoNovaSenha.TabIndex = 7;
            pbolhoNovaSenha.TabStop = false;
            // 
            // lblConfirmarSenha
            // 
            lblConfirmarSenha.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblConfirmarSenha.ForeColor = Color.FromArgb(123, 97, 88);
            lblConfirmarSenha.Location = new Point(80, 480);
            lblConfirmarSenha.Name = "lblConfirmarSenha";
            lblConfirmarSenha.Size = new Size(200, 25);
            lblConfirmarSenha.TabIndex = 8;
            lblConfirmarSenha.Text = "Confirmar nova senha";
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Font = new Font("Segoe UI", 11F);
            txtConfirmarSenha.Location = new Point(80, 510);
            txtConfirmarSenha.MaxLength = 100;
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.PasswordChar = '●';
            txtConfirmarSenha.PlaceholderText = "Digite novamente a senha";
            txtConfirmarSenha.Size = new Size(445, 27);
            txtConfirmarSenha.TabIndex = 9;
            // 
            // pbolhoConfirmarSenha
            // 
            pbolhoConfirmarSenha.BackColor = Color.Transparent;
            pbolhoConfirmarSenha.Cursor = Cursors.Hand;
            pbolhoConfirmarSenha.Image = Properties.Resources.olho_aberto;
            pbolhoConfirmarSenha.Location = new Point(535, 510);
            pbolhoConfirmarSenha.Name = "pbolhoConfirmarSenha";
            pbolhoConfirmarSenha.Size = new Size(35, 30);
            pbolhoConfirmarSenha.SizeMode = PictureBoxSizeMode.Zoom;
            pbolhoConfirmarSenha.TabIndex = 10;
            pbolhoConfirmarSenha.TabStop = false;
            // 
            // btnRedefinir
            // 
            btnRedefinir.BackColor = Color.FromArgb(201, 142, 124);
            btnRedefinir.Cursor = Cursors.Hand;
            btnRedefinir.FlatAppearance.BorderSize = 0;
            btnRedefinir.FlatStyle = FlatStyle.Flat;
            btnRedefinir.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRedefinir.ForeColor = Color.White;
            btnRedefinir.Location = new Point(80, 575);
            btnRedefinir.Name = "btnRedefinir";
            btnRedefinir.Size = new Size(490, 48);
            btnRedefinir.TabIndex = 11;
            btnRedefinir.Text = "Redefinir Senha";
            btnRedefinir.UseVisualStyleBackColor = false;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(247, 242, 241);
            btnVoltar.Cursor = Cursors.Hand;
            btnVoltar.FlatAppearance.BorderColor = Color.FromArgb(228, 206, 199);
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnVoltar.ForeColor = Color.FromArgb(123, 97, 88);
            btnVoltar.Location = new Point(80, 640);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(490, 42);
            btnVoltar.TabIndex = 12;
            btnVoltar.Text = "Voltar para o Login";
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // lblSair
            // 
            lblSair.Cursor = Cursors.Hand;
            lblSair.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblSair.ForeColor = Color.FromArgb(123, 97, 88);
            lblSair.Location = new Point(1540, 20);
            lblSair.Name = "lblSair";
            lblSair.Size = new Size(40, 40);
            lblSair.TabIndex = 1;
            lblSair.Text = "X";
            lblSair.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RedefinirSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 239, 237);
            ClientSize = new Size(1600, 900);
            Controls.Add(panelPrincipal);
            Controls.Add(lblSair);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RedefinirSenha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Redefinir Senha";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pblogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbolhoNovaSenha).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbolhoConfirmarSenha).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;

        private PictureBox pblogo;

        private Label lblTitulo;
        private Label lblSubtitulo;

        private Label lblCpf;
        private TextBox txtCpf;

        private Label lblNovaSenha;
        private TextBox txtNovaSenha;
        private PictureBox pbolhoNovaSenha;

        private Label lblConfirmarSenha;
        private TextBox txtConfirmarSenha;
        private PictureBox pbolhoConfirmarSenha;

        private Button btnRedefinir;
        private Button btnVoltar;

        private Label lblSair;
    }
}