namespace AppCadastro
{
    partial class AddFilme
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
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblFilme = new System.Windows.Forms.Label();
            this.txtNomeFilme = new System.Windows.Forms.TextBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btngrid = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(77, 68);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(147, 20);
            this.txtPreco.TabIndex = 44;
            this.txtPreco.TextChanged += new System.EventHandler(this.txtPreco_TextChanged);
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(12, 70);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(47, 18);
            this.lblPreco.TabIndex = 43;
            this.lblPreco.Text = "Preço:";
            // 
            // lblFilme
            // 
            this.lblFilme.AutoSize = true;
            this.lblFilme.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilme.Location = new System.Drawing.Point(12, 12);
            this.lblFilme.Name = "lblFilme";
            this.lblFilme.Size = new System.Drawing.Size(47, 18);
            this.lblFilme.TabIndex = 39;
            this.lblFilme.Text = "Filme:";
            // 
            // txtNomeFilme
            // 
            this.txtNomeFilme.Location = new System.Drawing.Point(77, 12);
            this.txtNomeFilme.Name = "txtNomeFilme";
            this.txtNomeFilme.Size = new System.Drawing.Size(147, 20);
            this.txtNomeFilme.TabIndex = 62;
            // 
            // btnIncluir
            // 
            this.btnIncluir.AutoSize = true;
            this.btnIncluir.Location = new System.Drawing.Point(247, 7);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(92, 23);
            this.btnIncluir.TabIndex = 65;
            this.btnIncluir.Text = "Incluir Filme";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.AutoSize = true;
            this.btnExcluir.Location = new System.Drawing.Point(246, 36);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(92, 23);
            this.btnExcluir.TabIndex = 66;
            this.btnExcluir.Text = "Excluir Filme";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.AutoSize = true;
            this.btnAlterar.Location = new System.Drawing.Point(246, 65);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(92, 23);
            this.btnAlterar.TabIndex = 67;
            this.btnAlterar.Text = "Alterar Filme";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(246, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 68;
            this.button1.Text = "&Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(77, 39);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(147, 20);
            this.txtGenero.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 69;
            this.label2.Text = "Gênero:";
            // 
            // btngrid
            // 
            this.btngrid.AutoSize = true;
            this.btngrid.Location = new System.Drawing.Point(132, 94);
            this.btngrid.Name = "btngrid";
            this.btngrid.Size = new System.Drawing.Size(92, 23);
            this.btngrid.TabIndex = 74;
            this.btngrid.Text = "&Grid";
            this.btngrid.UseVisualStyleBackColor = true;
            this.btngrid.Click += new System.EventHandler(this.btngrid_Click);
            // 
            // AddFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 127);
            this.Controls.Add(this.btngrid);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.txtNomeFilme);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblFilme);
            this.Name = "AddFilme";
            this.Text = "AddFilme";
            this.Load += new System.EventHandler(this.AddFilme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblFilme;
        private System.Windows.Forms.TextBox txtNomeFilme;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btngrid;

    }
}