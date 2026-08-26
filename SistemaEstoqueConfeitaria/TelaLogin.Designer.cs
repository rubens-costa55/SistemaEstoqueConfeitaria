namespace SistemaEstoqueConfeitaria
{
    partial class TelaLogin
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
            panel1 = new Panel();
            panel4 = new Panel();
            lblDescricaoSistema = new Label();
            lblSistema = new Label();
            pblogo = new PictureBox();
            picOlhoSenha = new Panel();
            pbolhosenha = new PictureBox();
            btnEsqueciSenha = new Button();
            btnAcessar = new Button();
            txtSenha = new TextBox();
            lblSenha = new Label();
            txtcpf = new TextBox();
            lblCPF = new Label();
            lblDescricao = new Label();
            lblTitulo = new Label();
            lblSair = new Label();
            lblLogin = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pblogo).BeginInit();
            picOlhoSenha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbolhosenha).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(249, 245, 243);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(picOlhoSenha);
            panel1.Controls.Add(lblSair);
            panel1.Controls.Add(lblLogin);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1541, 803);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblDescricaoSistema);
            panel4.Controls.Add(lblSistema);
            panel4.Controls.Add(pblogo);
            panel4.Location = new Point(785, 90);
            panel4.Name = "panel4";
            panel4.Size = new Size(676, 690);
            panel4.TabIndex = 3;
            // 
            // lblDescricaoSistema
            // 
            lblDescricaoSistema.BackColor = Color.Transparent;
            lblDescricaoSistema.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescricaoSistema.ForeColor = Color.FromArgb(201, 137, 120);
            lblDescricaoSistema.Location = new Point(90, 490);
            lblDescricaoSistema.Name = "lblDescricaoSistema";
            lblDescricaoSistema.Size = new Size(496, 60);
            lblDescricaoSistema.TabIndex = 4;
            lblDescricaoSistema.Text = "Controle simples e organizado dos insumos da confeitaria.";
            lblDescricaoSistema.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSistema
            // 
            lblSistema.BackColor = Color.Transparent;
            lblSistema.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSistema.ForeColor = Color.FromArgb(201, 137, 120);
            lblSistema.Location = new Point(80, 435);
            lblSistema.Name = "lblSistema";
            lblSistema.Size = new Size(516, 40);
            lblSistema.TabIndex = 3;
            lblSistema.Text = "Sistema de Estoque\n";
            lblSistema.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pblogo
            // 
            pblogo.BackColor = Color.Transparent;
            pblogo.Image = Properties.Resources.Logo__2_;
            pblogo.Location = new Point(138, 105);
            pblogo.Name = "pblogo";
            pblogo.Size = new Size(400, 300);
            pblogo.SizeMode = PictureBoxSizeMode.Zoom;
            pblogo.TabIndex = 0;
            pblogo.TabStop = false;
            // 
            // picOlhoSenha
            // 
            picOlhoSenha.BackColor = Color.FromArgb(235, 221, 218);
            picOlhoSenha.Controls.Add(pbolhosenha);
            picOlhoSenha.Controls.Add(btnEsqueciSenha);
            picOlhoSenha.Controls.Add(btnAcessar);
            picOlhoSenha.Controls.Add(txtSenha);
            picOlhoSenha.Controls.Add(lblSenha);
            picOlhoSenha.Controls.Add(txtcpf);
            picOlhoSenha.Controls.Add(lblCPF);
            picOlhoSenha.Controls.Add(lblDescricao);
            picOlhoSenha.Controls.Add(lblTitulo);
            picOlhoSenha.Location = new Point(55, 90);
            picOlhoSenha.Name = "picOlhoSenha";
            picOlhoSenha.Size = new Size(700, 690);
            picOlhoSenha.TabIndex = 2;
            // 
            // pbolhosenha
            // 
            pbolhosenha.BackColor = Color.White;
            pbolhosenha.Cursor = Cursors.Hand;
            pbolhosenha.Image = Properties.Resources.olho_aberto;
            pbolhosenha.Location = new Point(569, 362);
            pbolhosenha.Name = "pbolhosenha";
            pbolhosenha.Size = new Size(25, 25);
            pbolhosenha.SizeMode = PictureBoxSizeMode.Zoom;
            pbolhosenha.TabIndex = 10;
            pbolhosenha.TabStop = false;
            // 
            // btnEsqueciSenha
            // 
            btnEsqueciSenha.BackColor = Color.FromArgb(201, 142, 124);
            btnEsqueciSenha.Cursor = Cursors.Hand;
            btnEsqueciSenha.FlatAppearance.BorderColor = Color.FromArgb(221, 201, 194);
            btnEsqueciSenha.FlatAppearance.BorderSize = 0;
            btnEsqueciSenha.FlatStyle = FlatStyle.Flat;
            btnEsqueciSenha.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEsqueciSenha.ForeColor = Color.White;
            btnEsqueciSenha.Location = new Point(55, 585);
            btnEsqueciSenha.Name = "btnEsqueciSenha";
            btnEsqueciSenha.Size = new Size(543, 46);
            btnEsqueciSenha.TabIndex = 9;
            btnEsqueciSenha.Text = "Esqueci minha senha";
            btnEsqueciSenha.UseVisualStyleBackColor = false;
            // 
            // btnAcessar
            // 
            btnAcessar.BackColor = Color.FromArgb(201, 142, 124);
            btnAcessar.Cursor = Cursors.Hand;
            btnAcessar.FlatAppearance.BorderSize = 0;
            btnAcessar.FlatStyle = FlatStyle.Flat;
            btnAcessar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAcessar.ForeColor = Color.White;
            btnAcessar.Location = new Point(55, 500);
            btnAcessar.Name = "btnAcessar";
            btnAcessar.Size = new Size(543, 52);
            btnAcessar.TabIndex = 8;
            btnAcessar.Text = "Acessar";
            btnAcessar.UseVisualStyleBackColor = false;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.White;
            txtSenha.BorderStyle = BorderStyle.FixedSingle;
            txtSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.ForeColor = Color.FromArgb(126, 99, 92);
            txtSenha.Location = new Point(55, 360);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Digite sua senha";
            txtSenha.Size = new Size(543, 29);
            txtSenha.TabIndex = 6;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // lblSenha
            // 
            lblSenha.BackColor = Color.Transparent;
            lblSenha.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.ForeColor = Color.FromArgb(185, 120, 103);
            lblSenha.Location = new Point(55, 329);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(100, 28);
            lblSenha.TabIndex = 5;
            lblSenha.Text = "Senha:";
            // 
            // txtcpf
            // 
            txtcpf.BackColor = Color.White;
            txtcpf.BorderStyle = BorderStyle.FixedSingle;
            txtcpf.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcpf.ForeColor = Color.FromArgb(126, 99, 92);
            txtcpf.Location = new Point(55, 253);
            txtcpf.Name = "txtcpf";
            txtcpf.PlaceholderText = "000.000.000-00";
            txtcpf.Size = new Size(543, 29);
            txtcpf.TabIndex = 4;
            // 
            // lblCPF
            // 
            lblCPF.BackColor = Color.Transparent;
            lblCPF.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCPF.ForeColor = Color.FromArgb(185, 120, 103);
            lblCPF.Location = new Point(55, 222);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(100, 28);
            lblCPF.TabIndex = 3;
            lblCPF.Text = "CPF:\n";
            // 
            // lblDescricao
            // 
            lblDescricao.BackColor = Color.Transparent;
            lblDescricao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescricao.ForeColor = Color.FromArgb(201, 137, 120);
            lblDescricao.Location = new Point(55, 120);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(560, 42);
            lblDescricao.TabIndex = 2;
            lblDescricao.Text = "Digite seus dados no campo abaixo para acessar o sistema.";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(201, 137, 120);
            lblTitulo.Location = new Point(55, 58);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(307, 45);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Realize o seu login:";
            // 
            // lblSair
            // 
            lblSair.AutoSize = true;
            lblSair.BackColor = Color.Transparent;
            lblSair.Cursor = Cursors.Hand;
            lblSair.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSair.ForeColor = Color.FromArgb(201, 137, 120);
            lblSair.Location = new Point(1486, 9);
            lblSair.Name = "lblSair";
            lblSair.Size = new Size(43, 47);
            lblSair.TabIndex = 1;
            lblSair.Text = "X";
            // 
            // lblLogin
            // 
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.FromArgb(94, 74, 68);
            lblLogin.Location = new Point(55, 26);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(113, 44);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login";
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 239, 237);
            ClientSize = new Size(1568, 822);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "TelaLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pblogo).EndInit();
            picOlhoSenha.ResumeLayout(false);
            picOlhoSenha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbolhosenha).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblSair;
        private Label lblLogin;
        private Panel picOlhoSenha;
        private Label lblCPF;
        private Label lblDescricao;
        private Label lblTitulo;
        private TextBox txtcpf;
        private TextBox txtSenha;
        private Label lblSenha;
        private Button btnAcessar;
        private Button btnEsqueciSenha;
        private Panel panel4;
        private Label lblSistema;
        private PictureBox pblogo;
        private Label lblDescricaoSistema;
        private PictureBox pbolhosenha;
    }
}