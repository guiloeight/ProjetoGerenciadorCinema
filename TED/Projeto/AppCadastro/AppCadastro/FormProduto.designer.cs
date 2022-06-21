namespace AppCadastro
{
    partial class Produtos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produtos));
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dgProdutos = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemover = new System.Windows.Forms.Button();
            this.lblproduto = new System.Windows.Forms.Label();
            this.lblquantidade = new System.Windows.Forms.Label();
            this.lblvalordavenda = new System.Windows.Forms.Label();
            this.lblvalordacompra = new System.Windows.Forms.Label();
            this.lblcodigodoprduto = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtValorCompra = new System.Windows.Forms.TextBox();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnhabilitar = new System.Windows.Forms.Button();
            this.btndesabilitar = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdicionar.Location = new System.Drawing.Point(56, 223);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 44);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "&Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // dgProdutos
            // 
            this.dgProdutos.AllowUserToOrderColumns = true;
            this.dgProdutos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.Produto,
            this.Quantidade,
            this.ValorCompra,
            this.ValorVenda});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgProdutos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgProdutos.Enabled = false;
            this.dgProdutos.Location = new System.Drawing.Point(395, 26);
            this.dgProdutos.Name = "dgProdutos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgProdutos.Size = new System.Drawing.Size(493, 309);
            this.dgProdutos.TabIndex = 1;
            this.dgProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProdutos_CellContentClick);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.Width = 50;
            // 
            // Produto
            // 
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            // 
            // ValorCompra
            // 
            this.ValorCompra.HeaderText = "Valor da Compra";
            this.ValorCompra.Name = "ValorCompra";
            // 
            // ValorVenda
            // 
            this.ValorVenda.HeaderText = "Valor de Venda";
            this.ValorVenda.Name = "ValorVenda";
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRemover.Location = new System.Drawing.Point(255, 223);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 44);
            this.btnRemover.TabIndex = 2;
            this.btnRemover.Text = "&Excluir";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // lblproduto
            // 
            this.lblproduto.AutoSize = true;
            this.lblproduto.BackColor = System.Drawing.Color.Transparent;
            this.lblproduto.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblproduto.Location = new System.Drawing.Point(84, 77);
            this.lblproduto.Name = "lblproduto";
            this.lblproduto.Size = new System.Drawing.Size(47, 13);
            this.lblproduto.TabIndex = 3;
            this.lblproduto.Text = "Produto:";
            this.lblproduto.Click += new System.EventHandler(this.lblproduto_Click);
            // 
            // lblquantidade
            // 
            this.lblquantidade.AutoSize = true;
            this.lblquantidade.BackColor = System.Drawing.Color.Transparent;
            this.lblquantidade.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblquantidade.Location = new System.Drawing.Point(69, 110);
            this.lblquantidade.Name = "lblquantidade";
            this.lblquantidade.Size = new System.Drawing.Size(65, 13);
            this.lblquantidade.TabIndex = 4;
            this.lblquantidade.Text = "Quantidade:";
            this.lblquantidade.Click += new System.EventHandler(this.lblquantidade_Click);
            // 
            // lblvalordavenda
            // 
            this.lblvalordavenda.AutoSize = true;
            this.lblvalordavenda.BackColor = System.Drawing.Color.Transparent;
            this.lblvalordavenda.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblvalordavenda.Location = new System.Drawing.Point(49, 175);
            this.lblvalordavenda.Name = "lblvalordavenda";
            this.lblvalordavenda.Size = new System.Drawing.Size(83, 13);
            this.lblvalordavenda.TabIndex = 6;
            this.lblvalordavenda.Text = "Valor de Venda:";
            // 
            // lblvalordacompra
            // 
            this.lblvalordacompra.AutoSize = true;
            this.lblvalordacompra.BackColor = System.Drawing.Color.Transparent;
            this.lblvalordacompra.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblvalordacompra.Location = new System.Drawing.Point(43, 143);
            this.lblvalordacompra.Name = "lblvalordacompra";
            this.lblvalordacompra.Size = new System.Drawing.Size(88, 13);
            this.lblvalordacompra.TabIndex = 5;
            this.lblvalordacompra.Text = "Valor de Compra:";
            this.lblvalordacompra.Click += new System.EventHandler(this.lblvalordacompra_Click);
            // 
            // lblcodigodoprduto
            // 
            this.lblcodigodoprduto.AutoSize = true;
            this.lblcodigodoprduto.BackColor = System.Drawing.Color.Transparent;
            this.lblcodigodoprduto.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblcodigodoprduto.Location = new System.Drawing.Point(33, 54);
            this.lblcodigodoprduto.Name = "lblcodigodoprduto";
            this.lblcodigodoprduto.Size = new System.Drawing.Size(98, 13);
            this.lblcodigodoprduto.TabIndex = 7;
            this.lblcodigodoprduto.Text = "Código do Produto:";
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(151, 77);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(188, 20);
            this.txtProduto.TabIndex = 8;
            this.txtProduto.TextChanged += new System.EventHandler(this.txtProduto_TextChanged);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(151, 110);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(188, 20);
            this.txtQuantidade.TabIndex = 9;
            this.txtQuantidade.TextChanged += new System.EventHandler(this.txtQuantidade_TextChanged);
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.Location = new System.Drawing.Point(151, 142);
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Size = new System.Drawing.Size(188, 20);
            this.txtValorCompra.TabIndex = 10;
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.Location = new System.Drawing.Point(151, 175);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(188, 20);
            this.txtValorVenda.TabIndex = 11;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(151, 51);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(188, 20);
            this.txtCodigo.TabIndex = 12;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAlterar.Location = new System.Drawing.Point(151, 223);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 44);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConsultar.Location = new System.Drawing.Point(56, 291);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 44);
            this.btnConsultar.TabIndex = 14;
            this.btnConsultar.Text = "&Atualizar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVoltar.Location = new System.Drawing.Point(151, 291);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 44);
            this.btnVoltar.TabIndex = 15;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnImprimir.Location = new System.Drawing.Point(255, 291);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 44);
            this.btnImprimir.TabIndex = 16;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnhabilitar
            // 
            this.btnhabilitar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnhabilitar.Location = new System.Drawing.Point(146, 12);
            this.btnhabilitar.Name = "btnhabilitar";
            this.btnhabilitar.Size = new System.Drawing.Size(98, 23);
            this.btnhabilitar.TabIndex = 18;
            this.btnhabilitar.Text = "&Habilitar";
            this.btnhabilitar.UseVisualStyleBackColor = false;
            this.btnhabilitar.Click += new System.EventHandler(this.btnhabilitar_Click);
            // 
            // btndesabilitar
            // 
            this.btndesabilitar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btndesabilitar.Location = new System.Drawing.Point(259, 12);
            this.btndesabilitar.Name = "btndesabilitar";
            this.btndesabilitar.Size = new System.Drawing.Size(97, 23);
            this.btndesabilitar.TabIndex = 19;
            this.btndesabilitar.Text = "&Desabilitar";
            this.btndesabilitar.UseVisualStyleBackColor = false;
            this.btndesabilitar.Click += new System.EventHandler(this.btndesabilitar_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_EndPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppCadastro.Properties.Resources.teste22;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(905, 359);
            this.Controls.Add(this.btndesabilitar);
            this.Controls.Add(this.btnhabilitar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtValorVenda);
            this.Controls.Add(this.txtValorCompra);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.lblcodigodoprduto);
            this.Controls.Add(this.lblvalordavenda);
            this.Controls.Add(this.lblvalordacompra);
            this.Controls.Add(this.lblquantidade);
            this.Controls.Add(this.lblproduto);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.dgProdutos);
            this.Controls.Add(this.btnAdicionar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Produtos";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.Produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridView dgProdutos;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label lblproduto;
        private System.Windows.Forms.Label lblquantidade;
        private System.Windows.Forms.Label lblvalordavenda;
        private System.Windows.Forms.Label lblvalordacompra;
        private System.Windows.Forms.Label lblcodigodoprduto;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtValorCompra;
        private System.Windows.Forms.TextBox txtValorVenda;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnhabilitar;
        private System.Windows.Forms.Button btndesabilitar;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorVenda;
    }
}