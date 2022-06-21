namespace AppCadastro
{
    partial class dtvfornecedor
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
            this.dgvfornecedor = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Natureza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nomefantasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Complemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvfornecedor
            // 
            this.dgvfornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Natureza,
            this.Nomefantasia,
            this.Cnpj,
            this.Endereco,
            this.Cidade,
            this.Complemento,
            this.Bairro,
            this.Estado,
            this.Cep,
            this.Email,
            this.Telefone1,
            this.Telefone2});
            this.dgvfornecedor.Location = new System.Drawing.Point(12, 2);
            this.dgvfornecedor.Name = "dgvfornecedor";
            this.dgvfornecedor.Size = new System.Drawing.Size(633, 291);
            this.dgvfornecedor.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Natureza
            // 
            this.Natureza.HeaderText = "Natureza";
            this.Natureza.Name = "Natureza";
            // 
            // Nomefantasia
            // 
            this.Nomefantasia.HeaderText = "Nome Fantasia";
            this.Nomefantasia.Name = "Nomefantasia";
            // 
            // Cnpj
            // 
            this.Cnpj.HeaderText = "Cnpj";
            this.Cnpj.Name = "Cnpj";
            // 
            // Endereco
            // 
            this.Endereco.HeaderText = "Endereço";
            this.Endereco.Name = "Endereco";
            // 
            // Cidade
            // 
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            // 
            // Complemento
            // 
            this.Complemento.HeaderText = "Complemento";
            this.Complemento.Name = "Complemento";
            // 
            // Bairro
            // 
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.Name = "Bairro";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // Cep
            // 
            this.Cep.HeaderText = "Cep";
            this.Cep.Name = "Cep";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Telefone1
            // 
            this.Telefone1.HeaderText = "Telefone 1";
            this.Telefone1.Name = "Telefone1";
            // 
            // Telefone2
            // 
            this.Telefone2.HeaderText = "Telefone 2";
            this.Telefone2.Name = "Telefone2";
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(261, 318);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(82, 33);
            this.btnsair.TabIndex = 2;
            this.btnsair.Text = "&Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // dtvfornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(660, 363);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.dgvfornecedor);
            this.MaximizeBox = false;
            this.Name = "dtvfornecedor";
            this.Text = "Fornecedor";
            this.Load += new System.EventHandler(this.dtvfornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfornecedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvfornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Natureza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomefantasia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Complemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone2;
        private System.Windows.Forms.Button btnsair;
    }
}