namespace AppCadastro
{
    partial class frmUsuario0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario0));
            this.lblNvUsuario = new System.Windows.Forms.Label();
            this.lblNvSenha = new System.Windows.Forms.Label();
            this.txtNvUsuario = new System.Windows.Forms.TextBox();
            this.txtNvSenha = new System.Windows.Forms.TextBox();
            this.btnCadastrarUs = new System.Windows.Forms.Button();
            this.btnExcluirUs = new System.Windows.Forms.Button();
            this.btnLimparUs = new System.Windows.Forms.Button();
            this.btnConsultarUs = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAlterarUs = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkAdm = new System.Windows.Forms.CheckBox();
            this.txtfunc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnconfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNvUsuario
            // 
            this.lblNvUsuario.AutoSize = true;
            this.lblNvUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblNvUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNvUsuario.Location = new System.Drawing.Point(151, 38);
            this.lblNvUsuario.Name = "lblNvUsuario";
            this.lblNvUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblNvUsuario.TabIndex = 0;
            this.lblNvUsuario.Text = "Usuário";
            // 
            // lblNvSenha
            // 
            this.lblNvSenha.AutoSize = true;
            this.lblNvSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblNvSenha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNvSenha.Location = new System.Drawing.Point(156, 64);
            this.lblNvSenha.Name = "lblNvSenha";
            this.lblNvSenha.Size = new System.Drawing.Size(38, 13);
            this.lblNvSenha.TabIndex = 1;
            this.lblNvSenha.Text = "Senha";
            // 
            // txtNvUsuario
            // 
            this.txtNvUsuario.Enabled = false;
            this.txtNvUsuario.Location = new System.Drawing.Point(200, 35);
            this.txtNvUsuario.Name = "txtNvUsuario";
            this.txtNvUsuario.Size = new System.Drawing.Size(181, 20);
            this.txtNvUsuario.TabIndex = 2;
            // 
            // txtNvSenha
            // 
            this.txtNvSenha.Enabled = false;
            this.txtNvSenha.Location = new System.Drawing.Point(200, 61);
            this.txtNvSenha.Name = "txtNvSenha";
            this.txtNvSenha.PasswordChar = '•';
            this.txtNvSenha.Size = new System.Drawing.Size(181, 20);
            this.txtNvSenha.TabIndex = 3;
            this.txtNvSenha.Tag = "";
            // 
            // btnCadastrarUs
            // 
            this.btnCadastrarUs.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCadastrarUs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadastrarUs.Location = new System.Drawing.Point(157, 120);
            this.btnCadastrarUs.Name = "btnCadastrarUs";
            this.btnCadastrarUs.Size = new System.Drawing.Size(75, 25);
            this.btnCadastrarUs.TabIndex = 4;
            this.btnCadastrarUs.Text = "&Cadastrar ";
            this.btnCadastrarUs.UseVisualStyleBackColor = false;
            this.btnCadastrarUs.Click += new System.EventHandler(this.btnCadastrarUs_Click);
            // 
            // btnExcluirUs
            // 
            this.btnExcluirUs.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExcluirUs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExcluirUs.Location = new System.Drawing.Point(249, 149);
            this.btnExcluirUs.Name = "btnExcluirUs";
            this.btnExcluirUs.Size = new System.Drawing.Size(75, 25);
            this.btnExcluirUs.TabIndex = 5;
            this.btnExcluirUs.Text = "&Excluir";
            this.btnExcluirUs.UseVisualStyleBackColor = false;
            this.btnExcluirUs.Click += new System.EventHandler(this.btnExcluirUs_Click);
            // 
            // btnLimparUs
            // 
            this.btnLimparUs.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimparUs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimparUs.Location = new System.Drawing.Point(340, 120);
            this.btnLimparUs.Name = "btnLimparUs";
            this.btnLimparUs.Size = new System.Drawing.Size(75, 25);
            this.btnLimparUs.TabIndex = 6;
            this.btnLimparUs.Text = "&Limpar";
            this.btnLimparUs.UseVisualStyleBackColor = false;
            this.btnLimparUs.Click += new System.EventHandler(this.btnLimparUs_Click);
            // 
            // btnConsultarUs
            // 
            this.btnConsultarUs.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConsultarUs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConsultarUs.Location = new System.Drawing.Point(157, 149);
            this.btnConsultarUs.Name = "btnConsultarUs";
            this.btnConsultarUs.Size = new System.Drawing.Size(75, 25);
            this.btnConsultarUs.TabIndex = 7;
            this.btnConsultarUs.Text = "Consultar ";
            this.btnConsultarUs.UseVisualStyleBackColor = false;
            this.btnConsultarUs.Click += new System.EventHandler(this.btnConsultarUs_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSair.Location = new System.Drawing.Point(340, 149);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 25);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "&Voltar";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAlterarUs
            // 
            this.btnAlterarUs.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAlterarUs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAlterarUs.Location = new System.Drawing.Point(249, 120);
            this.btnAlterarUs.Name = "btnAlterarUs";
            this.btnAlterarUs.Size = new System.Drawing.Size(75, 25);
            this.btnAlterarUs.TabIndex = 9;
            this.btnAlterarUs.Text = "&Alterar";
            this.btnAlterarUs.UseVisualStyleBackColor = false;
            this.btnAlterarUs.Click += new System.EventHandler(this.btnAlterarUs_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::AppCadastro.Properties.Resources.user_add_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // chkAdm
            // 
            this.chkAdm.AutoSize = true;
            this.chkAdm.BackColor = System.Drawing.Color.Transparent;
            this.chkAdm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkAdm.Location = new System.Drawing.Point(159, 87);
            this.chkAdm.Name = "chkAdm";
            this.chkAdm.Size = new System.Drawing.Size(89, 17);
            this.chkAdm.TabIndex = 12;
            this.chkAdm.Text = "Administrador";
            this.chkAdm.UseVisualStyleBackColor = false;
            this.chkAdm.CheckedChanged += new System.EventHandler(this.chkAdm_CheckedChanged);
            // 
            // txtfunc
            // 
            this.txtfunc.Location = new System.Drawing.Point(260, 9);
            this.txtfunc.Name = "txtfunc";
            this.txtfunc.Size = new System.Drawing.Size(121, 20);
            this.txtfunc.TabIndex = 14;
            this.txtfunc.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(156, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Código Funcionário";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(421, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 54);
            this.button1.TabIndex = 15;
            this.button1.Text = "Consultar  Funcionários";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnconfirmar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnconfirmar.Location = new System.Drawing.Point(387, 6);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(109, 25);
            this.btnconfirmar.TabIndex = 16;
            this.btnconfirmar.Text = "&Confirmar";
            this.btnconfirmar.UseVisualStyleBackColor = false;
            this.btnconfirmar.Click += new System.EventHandler(this.btnconfirmar_Click);
            // 
            // frmUsuario0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = global::AppCadastro.Properties.Resources.teste43;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(503, 181);
            this.Controls.Add(this.btnconfirmar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtfunc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkAdm);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAlterarUs);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnConsultarUs);
            this.Controls.Add(this.btnLimparUs);
            this.Controls.Add(this.btnExcluirUs);
            this.Controls.Add(this.btnCadastrarUs);
            this.Controls.Add(this.txtNvSenha);
            this.Controls.Add(this.txtNvUsuario);
            this.Controls.Add(this.lblNvSenha);
            this.Controls.Add(this.lblNvUsuario);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsuario0";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Cadastro Usuário";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNvUsuario;
        private System.Windows.Forms.Label lblNvSenha;
        private System.Windows.Forms.TextBox txtNvUsuario;
        private System.Windows.Forms.TextBox txtNvSenha;
        private System.Windows.Forms.Button btnCadastrarUs;
        private System.Windows.Forms.Button btnExcluirUs;
        private System.Windows.Forms.Button btnLimparUs;
        private System.Windows.Forms.Button btnConsultarUs;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAlterarUs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chkAdm;
        private System.Windows.Forms.TextBox txtfunc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnconfirmar;
    }
}