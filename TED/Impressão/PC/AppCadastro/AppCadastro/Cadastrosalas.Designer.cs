namespace AppCadastro
{
    partial class Cadastrosalas
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblnumerodesalas = new System.Windows.Forms.Label();
            this.txtnumerodasala = new System.Windows.Forms.TextBox();
            this.lblnumerodelugares = new System.Windows.Forms.Label();
            this.txtnumerodelugares = new System.Windows.Forms.TextBox();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.dgvsala = new System.Windows.Forms.DataGridView();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numerosala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerodelugares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsala)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnumerodesalas
            // 
            this.lblnumerodesalas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumerodesalas.Location = new System.Drawing.Point(12, 18);
            this.lblnumerodesalas.Name = "lblnumerodesalas";
            this.lblnumerodesalas.Size = new System.Drawing.Size(120, 25);
            this.lblnumerodesalas.TabIndex = 0;
            this.lblnumerodesalas.Text = "Número da Sala:";
            // 
            // txtnumerodasala
            // 
            this.txtnumerodasala.Location = new System.Drawing.Point(158, 18);
            this.txtnumerodasala.Name = "txtnumerodasala";
            this.txtnumerodasala.Size = new System.Drawing.Size(133, 20);
            this.txtnumerodasala.TabIndex = 1;
            // 
            // lblnumerodelugares
            // 
            this.lblnumerodelugares.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumerodelugares.Location = new System.Drawing.Point(9, 60);
            this.lblnumerodelugares.Name = "lblnumerodelugares";
            this.lblnumerodelugares.Size = new System.Drawing.Size(143, 25);
            this.lblnumerodelugares.TabIndex = 2;
            this.lblnumerodelugares.Text = "Número de Lugares:";
            // 
            // txtnumerodelugares
            // 
            this.txtnumerodelugares.Location = new System.Drawing.Point(158, 61);
            this.txtnumerodelugares.Name = "txtnumerodelugares";
            this.txtnumerodelugares.Size = new System.Drawing.Size(133, 20);
            this.txtnumerodelugares.TabIndex = 3;
            // 
            // btnadicionar
            // 
            this.btnadicionar.Location = new System.Drawing.Point(315, 12);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(89, 26);
            this.btnadicionar.TabIndex = 4;
            this.btnadicionar.Text = "&Adicionar";
            this.btnadicionar.UseVisualStyleBackColor = true;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(415, 55);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(89, 26);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "&Voltar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(415, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(89, 26);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(315, 55);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(89, 26);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // dgvsala
            // 
            this.dgvsala.AllowUserToAddRows = false;
            this.dgvsala.AllowUserToDeleteRows = false;
            this.dgvsala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsala.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.Numerosala,
            this.numerodelugares});
            this.dgvsala.Enabled = false;
            this.dgvsala.Location = new System.Drawing.Point(114, 97);
            this.dgvsala.Name = "dgvsala";
            this.dgvsala.ReadOnly = true;
            this.dgvsala.Size = new System.Drawing.Size(397, 215);
            this.dgvsala.TabIndex = 9;
            this.dgvsala.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsala_CellContentClick);
            // 
            // btnconsultar
            // 
            this.btnconsultar.Location = new System.Drawing.Point(12, 97);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(89, 55);
            this.btnconsultar.TabIndex = 10;
            this.btnconsultar.Text = "&Consultar";
            this.btnconsultar.UseVisualStyleBackColor = true;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // codigo
            // 
            this.codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 65;
            // 
            // Numerosala
            // 
            this.Numerosala.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Numerosala.HeaderText = "Número da Sala";
            this.Numerosala.Name = "Numerosala";
            this.Numerosala.ReadOnly = true;
            this.Numerosala.Width = 80;
            // 
            // numerodelugares
            // 
            this.numerodelugares.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numerodelugares.HeaderText = "Número de Lugares";
            this.numerodelugares.Name = "numerodelugares";
            this.numerodelugares.ReadOnly = true;
            this.numerodelugares.Width = 115;
            // 
            // Cadastrosalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 324);
            this.Controls.Add(this.btnconsultar);
            this.Controls.Add(this.dgvsala);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.txtnumerodelugares);
            this.Controls.Add(this.lblnumerodelugares);
            this.Controls.Add(this.txtnumerodasala);
            this.Controls.Add(this.lblnumerodesalas);
            this.MaximizeBox = false;
            this.Name = "Cadastrosalas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Salas";
            this.Load += new System.EventHandler(this.Cadastrosalas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsala)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnumerodesalas;
        private System.Windows.Forms.TextBox txtnumerodasala;
        private System.Windows.Forms.Label lblnumerodelugares;
        private System.Windows.Forms.TextBox txtnumerodelugares;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridView dgvsala;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numerosala;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerodelugares;
    }
}