namespace AppCadastro
{
    partial class cadastrofuncionario
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
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.btndesabilitar = new System.Windows.Forms.Button();
            this.btnhabilitar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.mtxttelefone2 = new System.Windows.Forms.MaskedTextBox();
            this.mtxttelefone1 = new System.Windows.Forms.MaskedTextBox();
            this.lbltelefone2 = new System.Windows.Forms.Label();
            this.lbltelefone1 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.lblcidade = new System.Windows.Forms.Label();
            this.mtxtcpf = new System.Windows.Forms.MaskedTextBox();
            this.lblcep = new System.Windows.Forms.Label();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.lblbairro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcomplemento = new System.Windows.Forms.TextBox();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.lblendereco = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.cbxestado = new System.Windows.Forms.ComboBox();
            this.cbxestadocivil = new System.Windows.Forms.ComboBox();
            this.lblestadocivil = new System.Windows.Forms.Label();
            this.cbxsexo = new System.Windows.Forms.ComboBox();
            this.lblsexo = new System.Windows.Forms.Label();
            this.lblcomplemento = new System.Windows.Forms.Label();
            this.lblnumero = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txtrg = new System.Windows.Forms.TextBox();
            this.lblrg = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnc = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.btngrid = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Location = new System.Drawing.Point(382, 148);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(140, 20);
            this.txtcodigo.TabIndex = 63;
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(321, 151);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(43, 13);
            this.lblcodigo.TabIndex = 62;
            this.lblcodigo.Text = "Código:";
            // 
            // btndesabilitar
            // 
            this.btndesabilitar.Location = new System.Drawing.Point(305, 185);
            this.btndesabilitar.Name = "btndesabilitar";
            this.btndesabilitar.Size = new System.Drawing.Size(102, 19);
            this.btndesabilitar.TabIndex = 61;
            this.btndesabilitar.Text = "&Desabilitar";
            this.btndesabilitar.UseVisualStyleBackColor = true;
            this.btndesabilitar.Click += new System.EventHandler(this.btndesabilitar_Click);
            // 
            // btnhabilitar
            // 
            this.btnhabilitar.Location = new System.Drawing.Point(413, 185);
            this.btnhabilitar.Name = "btnhabilitar";
            this.btnhabilitar.Size = new System.Drawing.Size(102, 19);
            this.btnhabilitar.TabIndex = 60;
            this.btnhabilitar.Text = "&Habilitar";
            this.btnhabilitar.UseVisualStyleBackColor = true;
            this.btnhabilitar.Click += new System.EventHandler(this.btnhabilitar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(408, 260);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(107, 46);
            this.btnlimpar.TabIndex = 59;
            this.btnlimpar.Text = "&Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(295, 260);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(107, 46);
            this.btnexcluir.TabIndex = 58;
            this.btnexcluir.Text = "&Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btncadastrar
            // 
            this.btncadastrar.Location = new System.Drawing.Point(295, 211);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(107, 46);
            this.btncadastrar.TabIndex = 56;
            this.btncadastrar.Text = "&Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // mtxttelefone2
            // 
            this.mtxttelefone2.Location = new System.Drawing.Point(73, 280);
            this.mtxttelefone2.Mask = "(00)9999-9999";
            this.mtxttelefone2.Name = "mtxttelefone2";
            this.mtxttelefone2.Size = new System.Drawing.Size(100, 20);
            this.mtxttelefone2.TabIndex = 55;
            // 
            // mtxttelefone1
            // 
            this.mtxttelefone1.Location = new System.Drawing.Point(73, 254);
            this.mtxttelefone1.Mask = "(00)9999-9999";
            this.mtxttelefone1.Name = "mtxttelefone1";
            this.mtxttelefone1.Size = new System.Drawing.Size(100, 20);
            this.mtxttelefone1.TabIndex = 54;
            // 
            // lbltelefone2
            // 
            this.lbltelefone2.AutoSize = true;
            this.lbltelefone2.Location = new System.Drawing.Point(6, 283);
            this.lbltelefone2.Name = "lbltelefone2";
            this.lbltelefone2.Size = new System.Drawing.Size(61, 13);
            this.lbltelefone2.TabIndex = 53;
            this.lbltelefone2.Text = "Telefone 2:";
            // 
            // lbltelefone1
            // 
            this.lbltelefone1.AutoSize = true;
            this.lbltelefone1.Location = new System.Drawing.Point(6, 257);
            this.lbltelefone1.Name = "lbltelefone1";
            this.lbltelefone1.Size = new System.Drawing.Size(61, 13);
            this.lbltelefone1.TabIndex = 52;
            this.lbltelefone1.Text = "Telefone 1:";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(45, 228);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(140, 20);
            this.txtemail.TabIndex = 51;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(4, 228);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(35, 13);
            this.lblemail.TabIndex = 50;
            this.lblemail.Text = "Email:";
            // 
            // txtcidade
            // 
            this.txtcidade.Location = new System.Drawing.Point(290, 93);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(140, 20);
            this.txtcidade.TabIndex = 49;
            // 
            // lblcidade
            // 
            this.lblcidade.AutoSize = true;
            this.lblcidade.Location = new System.Drawing.Point(229, 96);
            this.lblcidade.Name = "lblcidade";
            this.lblcidade.Size = new System.Drawing.Size(43, 13);
            this.lblcidade.TabIndex = 48;
            this.lblcidade.Text = "Cidade:";
            // 
            // mtxtcpf
            // 
            this.mtxtcpf.Location = new System.Drawing.Point(232, 45);
            this.mtxtcpf.Mask = "999.999.999-99";
            this.mtxtcpf.Name = "mtxtcpf";
            this.mtxtcpf.Size = new System.Drawing.Size(100, 20);
            this.mtxtcpf.TabIndex = 47;
            this.mtxtcpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtcpf_MaskInputRejected);
            // 
            // lblcep
            // 
            this.lblcep.AutoSize = true;
            this.lblcep.Location = new System.Drawing.Point(195, 48);
            this.lblcep.Name = "lblcep";
            this.lblcep.Size = new System.Drawing.Size(30, 13);
            this.lblcep.TabIndex = 46;
            this.lblcep.Text = "CPF:";
            this.lblcep.Click += new System.EventHandler(this.lblcep_Click);
            // 
            // txtbairro
            // 
            this.txtbairro.Location = new System.Drawing.Point(60, 176);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(140, 20);
            this.txtbairro.TabIndex = 45;
            // 
            // lblbairro
            // 
            this.lblbairro.AutoSize = true;
            this.lblbairro.Location = new System.Drawing.Point(6, 179);
            this.lblbairro.Name = "lblbairro";
            this.lblbairro.Size = new System.Drawing.Size(37, 13);
            this.lblbairro.TabIndex = 44;
            this.lblbairro.Text = "Bairro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Estado:";
            // 
            // txtcomplemento
            // 
            this.txtcomplemento.Location = new System.Drawing.Point(100, 151);
            this.txtcomplemento.Name = "txtcomplemento";
            this.txtcomplemento.Size = new System.Drawing.Size(140, 20);
            this.txtcomplemento.TabIndex = 41;
            // 
            // txtendereco
            // 
            this.txtendereco.Location = new System.Drawing.Point(77, 99);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(140, 20);
            this.txtendereco.TabIndex = 40;
            // 
            // lblendereco
            // 
            this.lblendereco.AutoSize = true;
            this.lblendereco.Location = new System.Drawing.Point(6, 102);
            this.lblendereco.Name = "lblendereco";
            this.lblendereco.Size = new System.Drawing.Size(56, 13);
            this.lblendereco.TabIndex = 39;
            this.lblendereco.Text = "Endereço:";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(48, 19);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(304, 20);
            this.txtnome.TabIndex = 38;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(4, 22);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(38, 13);
            this.lblnome.TabIndex = 37;
            this.lblnome.Text = "Nome:";
            // 
            // cbxestado
            // 
            this.cbxestado.FormattingEnabled = true;
            this.cbxestado.Items.AddRange(new object[] {
            "Acre - AC",
            "Alagoas - AL",
            "Amapá - AP",
            "Amazonas - AM",
            "Bahia  - BA",
            "Ceará - CE",
            "Distrito Federal  - DF",
            "Espírito Santo - ES",
            "Goiás - GO",
            "Maranhão - MA",
            "Mato Grosso - MT",
            "Mato Grosso do Sul - MS",
            "Minas Gerais - MG",
            "Pará - PA",
            "Paraíba - PB",
            "Paraná - PR",
            "Pernambuco - PE",
            "Piauí - PI",
            "Rio de Janeiro - RJ",
            "Rio Grande do Norte - RN",
            "Rio Grande do Sul - RS",
            "Rondônia - RO",
            "Roraima - RR",
            "Santa Catarina - SC",
            "São Paulo - SP",
            "Sergipe - SE",
            "Tocantins - TO"});
            this.cbxestado.Location = new System.Drawing.Point(65, 202);
            this.cbxestado.Name = "cbxestado";
            this.cbxestado.Size = new System.Drawing.Size(130, 21);
            this.cbxestado.TabIndex = 64;
            // 
            // cbxestadocivil
            // 
            this.cbxestadocivil.FormattingEnabled = true;
            this.cbxestadocivil.Items.AddRange(new object[] {
            "Solteiro(a) ",
            "Casado(a)",
            "Divorciado(a)",
            "Viúvo(a) "});
            this.cbxestadocivil.Location = new System.Drawing.Point(71, 72);
            this.cbxestadocivil.Name = "cbxestadocivil";
            this.cbxestadocivil.Size = new System.Drawing.Size(130, 21);
            this.cbxestadocivil.TabIndex = 68;
            // 
            // lblestadocivil
            // 
            this.lblestadocivil.AutoSize = true;
            this.lblestadocivil.Location = new System.Drawing.Point(6, 75);
            this.lblestadocivil.Name = "lblestadocivil";
            this.lblestadocivil.Size = new System.Drawing.Size(65, 13);
            this.lblestadocivil.TabIndex = 67;
            this.lblestadocivil.Text = "Estado Civil:";
            // 
            // cbxsexo
            // 
            this.cbxsexo.FormattingEnabled = true;
            this.cbxsexo.Items.AddRange(new object[] {
            "Feminino ",
            "Masculino"});
            this.cbxsexo.Location = new System.Drawing.Point(46, 45);
            this.cbxsexo.Name = "cbxsexo";
            this.cbxsexo.Size = new System.Drawing.Size(130, 21);
            this.cbxsexo.TabIndex = 70;
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.Location = new System.Drawing.Point(6, 48);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(34, 13);
            this.lblsexo.TabIndex = 69;
            this.lblsexo.Text = "Sexo:";
            // 
            // lblcomplemento
            // 
            this.lblcomplemento.AutoSize = true;
            this.lblcomplemento.Location = new System.Drawing.Point(6, 154);
            this.lblcomplemento.Name = "lblcomplemento";
            this.lblcomplemento.Size = new System.Drawing.Size(74, 13);
            this.lblcomplemento.TabIndex = 71;
            this.lblcomplemento.Text = "Complemento:";
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Location = new System.Drawing.Point(6, 127);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(47, 13);
            this.lblnumero.TabIndex = 73;
            this.lblnumero.Text = "Número:";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(95, 124);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(140, 20);
            this.txtnumero.TabIndex = 72;
            // 
            // txtrg
            // 
            this.txtrg.Location = new System.Drawing.Point(385, 45);
            this.txtrg.Name = "txtrg";
            this.txtrg.Size = new System.Drawing.Size(166, 20);
            this.txtrg.TabIndex = 75;
            this.txtrg.TextChanged += new System.EventHandler(this.txtrg_TextChanged);
            // 
            // lblrg
            // 
            this.lblrg.AutoSize = true;
            this.lblrg.Location = new System.Drawing.Point(348, 48);
            this.lblrg.Name = "lblrg";
            this.lblrg.Size = new System.Drawing.Size(26, 13);
            this.lblrg.TabIndex = 74;
            this.lblrg.Text = "RG:";
            this.lblrg.Click += new System.EventHandler(this.lblrg_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(521, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 46);
            this.button1.TabIndex = 76;
            this.button1.Text = "&Alterar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnc
            // 
            this.btnc.Location = new System.Drawing.Point(413, 210);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(102, 46);
            this.btnc.TabIndex = 77;
            this.btnc.Text = "&Consultar";
            this.btnc.UseVisualStyleBackColor = true;
            this.btnc.Click += new System.EventHandler(this.btnc_Click);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(521, 260);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(107, 46);
            this.btnsair.TabIndex = 78;
            this.btnsair.Text = "&Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btngrid
            // 
            this.btngrid.Location = new System.Drawing.Point(528, 148);
            this.btngrid.Name = "btngrid";
            this.btngrid.Size = new System.Drawing.Size(102, 46);
            this.btngrid.TabIndex = 79;
            this.btngrid.Text = "&Grid";
            this.btngrid.UseVisualStyleBackColor = true;
            // 
            // cadastrofuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 321);
            this.Controls.Add(this.btngrid);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtrg);
            this.Controls.Add(this.lblrg);
            this.Controls.Add(this.lblnumero);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.lblcomplemento);
            this.Controls.Add(this.cbxsexo);
            this.Controls.Add(this.lblsexo);
            this.Controls.Add(this.cbxestadocivil);
            this.Controls.Add(this.lblestadocivil);
            this.Controls.Add(this.cbxestado);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.btndesabilitar);
            this.Controls.Add(this.btnhabilitar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.mtxttelefone2);
            this.Controls.Add(this.mtxttelefone1);
            this.Controls.Add(this.lbltelefone2);
            this.Controls.Add(this.lbltelefone1);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.txtcidade);
            this.Controls.Add(this.lblcidade);
            this.Controls.Add(this.mtxtcpf);
            this.Controls.Add(this.lblcep);
            this.Controls.Add(this.txtbairro);
            this.Controls.Add(this.lblbairro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcomplemento);
            this.Controls.Add(this.txtendereco);
            this.Controls.Add(this.lblendereco);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblnome);
            this.Name = "cadastrofuncionario";
            this.Text = "Cadastro Funcionário";
            this.Load += new System.EventHandler(this.cadastrofuncionario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Button btndesabilitar;
        private System.Windows.Forms.Button btnhabilitar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.MaskedTextBox mtxttelefone2;
        private System.Windows.Forms.MaskedTextBox mtxttelefone1;
        private System.Windows.Forms.Label lbltelefone2;
        private System.Windows.Forms.Label lbltelefone1;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.Label lblcidade;
        private System.Windows.Forms.MaskedTextBox mtxtcpf;
        private System.Windows.Forms.Label lblcep;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.Label lblbairro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcomplemento;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.Label lblendereco;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.ComboBox cbxestado;
        private System.Windows.Forms.ComboBox cbxestadocivil;
        private System.Windows.Forms.Label lblestadocivil;
        private System.Windows.Forms.ComboBox cbxsexo;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.Label lblcomplemento;
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.TextBox txtrg;
        private System.Windows.Forms.Label lblrg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btngrid;

    }
}