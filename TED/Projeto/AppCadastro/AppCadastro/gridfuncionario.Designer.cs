namespace AppCadastro
{
    partial class gridfuncionario
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
            this.btnsair = new System.Windows.Forms.Button();
            this.dgvfuncionario = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estadocivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acesso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsair.Location = new System.Drawing.Point(338, 311);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(82, 33);
            this.btnsair.TabIndex = 4;
            this.btnsair.Text = "&Sair";
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // dgvfuncionario
            // 
            this.dgvfuncionario.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvfuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nome,
            this.sexo,
            this.CPF,
            this.RG,
            this.endereco,
            this.cidade,
            this.numero,
            this.complemento,
            this.bairro,
            this.Estado,
            this.Estadocivil,
            this.Email,
            this.Telefone1,
            this.Telefone2,
            this.acesso});
            this.dgvfuncionario.Location = new System.Drawing.Point(42, 12);
            this.dgvfuncionario.Name = "dgvfuncionario";
            this.dgvfuncionario.Size = new System.Drawing.Size(683, 291);
            this.dgvfuncionario.TabIndex = 3;
            this.dgvfuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvfuncionario_CellContentClick);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            // 
            // sexo
            // 
            this.sexo.HeaderText = "Sexo";
            this.sexo.Name = "sexo";
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            // 
            // RG
            // 
            this.RG.HeaderText = "RG";
            this.RG.Name = "RG";
            // 
            // endereco
            // 
            this.endereco.HeaderText = "Endereço";
            this.endereco.Name = "endereco";
            // 
            // cidade
            // 
            this.cidade.HeaderText = "Cidade";
            this.cidade.Name = "cidade";
            // 
            // numero
            // 
            this.numero.HeaderText = "Número";
            this.numero.Name = "numero";
            // 
            // complemento
            // 
            this.complemento.HeaderText = "Complemento";
            this.complemento.Name = "complemento";
            // 
            // bairro
            // 
            this.bairro.HeaderText = "Bairro";
            this.bairro.Name = "bairro";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // Estadocivil
            // 
            this.Estadocivil.HeaderText = "Estado Civil";
            this.Estadocivil.Name = "Estadocivil";
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
            // acesso
            // 
            this.acesso.HeaderText = "Estilo de Acesso";
            this.acesso.Name = "acesso";
            // 
            // gridfuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::AppCadastro.Properties.Resources.teste33;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(763, 364);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.dgvfuncionario);
            this.DoubleBuffered = true;
            this.Name = "gridfuncionario";
            this.Text = "Consulta Funcionário";
            this.Load += new System.EventHandler(this.gridfuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfuncionario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.DataGridView dgvfuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn RG;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn complemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estadocivil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone2;
        private System.Windows.Forms.DataGridViewTextBoxColumn acesso;
    }
}