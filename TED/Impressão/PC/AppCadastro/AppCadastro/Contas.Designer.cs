namespace AppCadastro
{
    partial class Contas
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
            this.lblcodigo = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lbltipo = new System.Windows.Forms.Label();
            this.lblvencimento = new System.Windows.Forms.Label();
            this.cbxtipo = new System.Windows.Forms.ComboBox();
            this.mtxtvencimento = new System.Windows.Forms.MaskedTextBox();
            this.mtxtpagamento = new System.Windows.Forms.MaskedTextBox();
            this.lbldatadepagamento = new System.Windows.Forms.Label();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.lblvalor = new System.Windows.Forms.Label();
            this.cbxcredor = new System.Windows.Forms.ComboBox();
            this.lblcredor = new System.Windows.Forms.Label();
            this.txtmulta = new System.Windows.Forms.TextBox();
            this.lblmulta = new System.Windows.Forms.Label();
            this.lbldescricao = new System.Windows.Forms.Label();
            this.rtxtdescricao = new System.Windows.Forms.RichTextBox();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.btnalterar = new System.Windows.Forms.Button();
            this.btndesabilitar = new System.Windows.Forms.Button();
            this.btnhabilitar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.dgvconta = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipodeconta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatadePagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Multa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(24, 30);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(43, 13);
            this.lblcodigo.TabIndex = 0;
            this.lblcodigo.Text = "Código:";
            this.lblcodigo.Click += new System.EventHandler(this.lblcodigo_Click);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Location = new System.Drawing.Point(83, 28);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(108, 20);
            this.txtcodigo.TabIndex = 1;
            this.txtcodigo.TextChanged += new System.EventHandler(this.txtcodigo_TextChanged);
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Location = new System.Drawing.Point(24, 67);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(77, 13);
            this.lbltipo.TabIndex = 2;
            this.lbltipo.Text = "Tipo de Conta:";
            // 
            // lblvencimento
            // 
            this.lblvencimento.AutoSize = true;
            this.lblvencimento.Location = new System.Drawing.Point(24, 103);
            this.lblvencimento.Name = "lblvencimento";
            this.lblvencimento.Size = new System.Drawing.Size(66, 13);
            this.lblvencimento.TabIndex = 4;
            this.lblvencimento.Text = "Vencimento:";
            // 
            // cbxtipo
            // 
            this.cbxtipo.FormattingEnabled = true;
            this.cbxtipo.Items.AddRange(new object[] {
            "Luz",
            "Água",
            "Telefone",
            "Internet",
            "Fornecedores",
            "Outros"});
            this.cbxtipo.Location = new System.Drawing.Point(105, 64);
            this.cbxtipo.Name = "cbxtipo";
            this.cbxtipo.Size = new System.Drawing.Size(86, 21);
            this.cbxtipo.TabIndex = 6;
            // 
            // mtxtvencimento
            // 
            this.mtxtvencimento.Location = new System.Drawing.Point(96, 100);
            this.mtxtvencimento.Mask = "00-00-0000";
            this.mtxtvencimento.Name = "mtxtvencimento";
            this.mtxtvencimento.Size = new System.Drawing.Size(95, 20);
            this.mtxtvencimento.TabIndex = 7;
            // 
            // mtxtpagamento
            // 
            this.mtxtpagamento.Location = new System.Drawing.Point(122, 126);
            this.mtxtpagamento.Mask = "00/00/0000";
            this.mtxtpagamento.Name = "mtxtpagamento";
            this.mtxtpagamento.Size = new System.Drawing.Size(69, 20);
            this.mtxtpagamento.TabIndex = 9;
            this.mtxtpagamento.ValidatingType = typeof(System.DateTime);
            // 
            // lbldatadepagamento
            // 
            this.lbldatadepagamento.AutoSize = true;
            this.lbldatadepagamento.Location = new System.Drawing.Point(22, 129);
            this.lbldatadepagamento.Name = "lbldatadepagamento";
            this.lbldatadepagamento.Size = new System.Drawing.Size(104, 13);
            this.lbldatadepagamento.TabIndex = 8;
            this.lbldatadepagamento.Text = "Data de pagamento:";
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(83, 152);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(108, 20);
            this.txtvalor.TabIndex = 11;
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Location = new System.Drawing.Point(24, 154);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(34, 13);
            this.lblvalor.TabIndex = 10;
            this.lblvalor.Text = "Valor:";
            // 
            // cbxcredor
            // 
            this.cbxcredor.FormattingEnabled = true;
            this.cbxcredor.Items.AddRange(new object[] {
            "Luz",
            "Água",
            "Telefone",
            "Internet",
            "Fornecedores",
            "Outros"});
            this.cbxcredor.Location = new System.Drawing.Point(81, 181);
            this.cbxcredor.Name = "cbxcredor";
            this.cbxcredor.Size = new System.Drawing.Size(110, 21);
            this.cbxcredor.TabIndex = 13;
            this.cbxcredor.SelectedIndexChanged += new System.EventHandler(this.cbxcredor_SelectedIndexChanged);
            // 
            // lblcredor
            // 
            this.lblcredor.AutoSize = true;
            this.lblcredor.Location = new System.Drawing.Point(22, 184);
            this.lblcredor.Name = "lblcredor";
            this.lblcredor.Size = new System.Drawing.Size(41, 13);
            this.lblcredor.TabIndex = 12;
            this.lblcredor.Text = "Credor:";
            // 
            // txtmulta
            // 
            this.txtmulta.Location = new System.Drawing.Point(81, 208);
            this.txtmulta.Name = "txtmulta";
            this.txtmulta.Size = new System.Drawing.Size(108, 20);
            this.txtmulta.TabIndex = 15;
            // 
            // lblmulta
            // 
            this.lblmulta.AutoSize = true;
            this.lblmulta.Location = new System.Drawing.Point(22, 210);
            this.lblmulta.Name = "lblmulta";
            this.lblmulta.Size = new System.Drawing.Size(36, 13);
            this.lblmulta.TabIndex = 14;
            this.lblmulta.Text = "Multa:";
            // 
            // lbldescricao
            // 
            this.lbldescricao.AutoSize = true;
            this.lbldescricao.Location = new System.Drawing.Point(22, 247);
            this.lbldescricao.Name = "lbldescricao";
            this.lbldescricao.Size = new System.Drawing.Size(58, 13);
            this.lbldescricao.TabIndex = 16;
            this.lbldescricao.Text = "Descrição:";
            // 
            // rtxtdescricao
            // 
            this.rtxtdescricao.Location = new System.Drawing.Point(81, 244);
            this.rtxtdescricao.Name = "rtxtdescricao";
            this.rtxtdescricao.Size = new System.Drawing.Size(247, 56);
            this.rtxtdescricao.TabIndex = 17;
            this.rtxtdescricao.Text = "";
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(572, 274);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(107, 28);
            this.btnvoltar.TabIndex = 86;
            this.btnvoltar.Text = "&Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnconsultar
            // 
            this.btnconsultar.Location = new System.Drawing.Point(464, 239);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(102, 28);
            this.btnconsultar.TabIndex = 85;
            this.btnconsultar.Text = "&Consultar";
            this.btnconsultar.UseVisualStyleBackColor = true;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // btnalterar
            // 
            this.btnalterar.Location = new System.Drawing.Point(572, 240);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(107, 28);
            this.btnalterar.TabIndex = 84;
            this.btnalterar.Text = "&Alterar";
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // btndesabilitar
            // 
            this.btndesabilitar.Location = new System.Drawing.Point(120, 3);
            this.btndesabilitar.Name = "btndesabilitar";
            this.btndesabilitar.Size = new System.Drawing.Size(102, 19);
            this.btndesabilitar.TabIndex = 83;
            this.btndesabilitar.Text = "&Desabilitar";
            this.btndesabilitar.UseVisualStyleBackColor = true;
            this.btndesabilitar.Click += new System.EventHandler(this.btndesabilitar_Click);
            // 
            // btnhabilitar
            // 
            this.btnhabilitar.Location = new System.Drawing.Point(12, 3);
            this.btnhabilitar.Name = "btnhabilitar";
            this.btnhabilitar.Size = new System.Drawing.Size(102, 19);
            this.btnhabilitar.TabIndex = 82;
            this.btnhabilitar.Text = "&Habilitar";
            this.btnhabilitar.UseVisualStyleBackColor = true;
            this.btnhabilitar.Click += new System.EventHandler(this.btnhabilitar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(459, 274);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(107, 28);
            this.btnlimpar.TabIndex = 81;
            this.btnlimpar.Text = "&Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(346, 274);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(107, 28);
            this.btnexcluir.TabIndex = 80;
            this.btnexcluir.Text = "&Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btncadastrar
            // 
            this.btncadastrar.Location = new System.Drawing.Point(346, 240);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(107, 28);
            this.btncadastrar.TabIndex = 79;
            this.btncadastrar.Text = "&Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // dgvconta
            // 
            this.dgvconta.AllowUserToAddRows = false;
            this.dgvconta.AllowUserToDeleteRows = false;
            this.dgvconta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvconta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.Tipodeconta,
            this.Vencimento,
            this.DatadePagamento,
            this.Valor,
            this.Credor,
            this.Multa,
            this.Descricao});
            this.dgvconta.Enabled = false;
            this.dgvconta.Location = new System.Drawing.Point(277, 12);
            this.dgvconta.Name = "dgvconta";
            this.dgvconta.ReadOnly = true;
            this.dgvconta.Size = new System.Drawing.Size(448, 209);
            this.dgvconta.TabIndex = 87;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // Tipodeconta
            // 
            this.Tipodeconta.HeaderText = "Tipo de Conta";
            this.Tipodeconta.Name = "Tipodeconta";
            this.Tipodeconta.ReadOnly = true;
            // 
            // Vencimento
            // 
            this.Vencimento.HeaderText = "Vencimento";
            this.Vencimento.Name = "Vencimento";
            this.Vencimento.ReadOnly = true;
            // 
            // DatadePagamento
            // 
            this.DatadePagamento.HeaderText = "Data de Pagamento";
            this.DatadePagamento.Name = "DatadePagamento";
            this.DatadePagamento.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Credor
            // 
            this.Credor.HeaderText = "Credor";
            this.Credor.Name = "Credor";
            this.Credor.ReadOnly = true;
            // 
            // Multa
            // 
            this.Multa.HeaderText = "Multa";
            this.Multa.Name = "Multa";
            this.Multa.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // Contas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 317);
            this.Controls.Add(this.dgvconta);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnconsultar);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.btndesabilitar);
            this.Controls.Add(this.btnhabilitar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.rtxtdescricao);
            this.Controls.Add(this.lbldescricao);
            this.Controls.Add(this.txtmulta);
            this.Controls.Add(this.lblmulta);
            this.Controls.Add(this.cbxcredor);
            this.Controls.Add(this.lblcredor);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.lblvalor);
            this.Controls.Add(this.mtxtpagamento);
            this.Controls.Add(this.lbldatadepagamento);
            this.Controls.Add(this.mtxtvencimento);
            this.Controls.Add(this.cbxtipo);
            this.Controls.Add(this.lblvencimento);
            this.Controls.Add(this.lbltipo);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.lblcodigo);
            this.Name = "Contas";
            this.Text = "Contas";
            this.Load += new System.EventHandler(this.Contas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvconta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.Label lblvencimento;
        private System.Windows.Forms.ComboBox cbxtipo;
        private System.Windows.Forms.MaskedTextBox mtxtvencimento;
        private System.Windows.Forms.MaskedTextBox mtxtpagamento;
        private System.Windows.Forms.Label lbldatadepagamento;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.ComboBox cbxcredor;
        private System.Windows.Forms.Label lblcredor;
        private System.Windows.Forms.TextBox txtmulta;
        private System.Windows.Forms.Label lblmulta;
        private System.Windows.Forms.Label lbldescricao;
        private System.Windows.Forms.RichTextBox rtxtdescricao;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Button btndesabilitar;
        private System.Windows.Forms.Button btnhabilitar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.DataGridView dgvconta;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipodeconta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatadePagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Multa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
    }
}