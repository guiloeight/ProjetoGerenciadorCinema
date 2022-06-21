namespace AppCadastro
{
    partial class vendadeproduto
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
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgProdutos = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnconcluir = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbProduto = new System.Windows.Forms.GroupBox();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtvalortotal = new System.Windows.Forms.TextBox();
            this.lblvalortotal = new System.Windows.Forms.Label();
            this.txtquantidade = new System.Windows.Forms.TextBox();
            this.lblquantidade = new System.Windows.Forms.Label();
            this.txtvalorproduto = new System.Windows.Forms.TextBox();
            this.lblvalorproduto = new System.Windows.Forms.Label();
            this.txtcodigoproduto = new System.Windows.Forms.TextBox();
            this.lblcodigoproduto = new System.Windows.Forms.Label();
            this.txtcodigofuncionario = new System.Windows.Forms.TextBox();
            this.lblcodigofuncionário = new System.Windows.Forms.Label();
            this.gbVenda = new System.Windows.Forms.GroupBox();
            this.txtValorAPagar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxformadepagamento = new System.Windows.Forms.ComboBox();
            this.txttroco = new System.Windows.Forms.TextBox();
            this.lbltroco = new System.Windows.Forms.Label();
            this.txtvalorpago = new System.Windows.Forms.TextBox();
            this.lblvalorpago = new System.Windows.Forms.Label();
            this.lblformadepagamento = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl12 = new System.Windows.Forms.Label();
            this.lbl11 = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.pcb12 = new System.Windows.Forms.PictureBox();
            this.pcb11 = new System.Windows.Forms.PictureBox();
            this.pcb10 = new System.Windows.Forms.PictureBox();
            this.pcb9 = new System.Windows.Forms.PictureBox();
            this.pcb8 = new System.Windows.Forms.PictureBox();
            this.pcb7 = new System.Windows.Forms.PictureBox();
            this.pcb6 = new System.Windows.Forms.PictureBox();
            this.pcb5 = new System.Windows.Forms.PictureBox();
            this.pcb4 = new System.Windows.Forms.PictureBox();
            this.pcb3 = new System.Windows.Forms.PictureBox();
            this.pcb2 = new System.Windows.Forms.PictureBox();
            this.pcb1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).BeginInit();
            this.gbProduto.SuspendLayout();
            this.gbVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(418, 333);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(119, 44);
            this.btnConsultar.TabIndex = 16;
            this.btnConsultar.Text = "&Consultar Produtos";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgProdutos
            // 
            this.dgProdutos.AllowUserToOrderColumns = true;
            this.dgProdutos.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
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
            this.dgProdutos.Location = new System.Drawing.Point(293, 18);
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
            this.dgProdutos.TabIndex = 15;
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
            this.Quantidade.HeaderText = "Quantidade em Estoque";
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
            // btnconcluir
            // 
            this.btnconcluir.Location = new System.Drawing.Point(667, 333);
            this.btnconcluir.Name = "btnconcluir";
            this.btnconcluir.Size = new System.Drawing.Size(119, 44);
            this.btnconcluir.TabIndex = 26;
            this.btnconcluir.Text = "&Concluir Venda";
            this.btnconcluir.UseVisualStyleBackColor = true;
            this.btnconcluir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(542, 333);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(119, 44);
            this.btncancelar.TabIndex = 27;
            this.btncancelar.Text = "&Cancelar Venda";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 44);
            this.button1.TabIndex = 30;
            this.button1.Text = "&Inserir Produto à Venda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // gbProduto
            // 
            this.gbProduto.Controls.Add(this.txtdescricao);
            this.gbProduto.Controls.Add(this.label1);
            this.gbProduto.Controls.Add(this.txtvalortotal);
            this.gbProduto.Controls.Add(this.lblvalortotal);
            this.gbProduto.Controls.Add(this.txtquantidade);
            this.gbProduto.Controls.Add(this.lblquantidade);
            this.gbProduto.Controls.Add(this.txtvalorproduto);
            this.gbProduto.Controls.Add(this.lblvalorproduto);
            this.gbProduto.Controls.Add(this.txtcodigoproduto);
            this.gbProduto.Controls.Add(this.lblcodigoproduto);
            this.gbProduto.Controls.Add(this.txtcodigofuncionario);
            this.gbProduto.Controls.Add(this.lblcodigofuncionário);
            this.gbProduto.Location = new System.Drawing.Point(12, 12);
            this.gbProduto.Name = "gbProduto";
            this.gbProduto.Size = new System.Drawing.Size(263, 207);
            this.gbProduto.TabIndex = 33;
            this.gbProduto.TabStop = false;
            this.gbProduto.Text = "Produto";
            // 
            // txtdescricao
            // 
            this.txtdescricao.Enabled = false;
            this.txtdescricao.Location = new System.Drawing.Point(125, 77);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(120, 20);
            this.txtdescricao.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Descrição:";
            // 
            // txtvalortotal
            // 
            this.txtvalortotal.Enabled = false;
            this.txtvalortotal.Location = new System.Drawing.Point(125, 176);
            this.txtvalortotal.Name = "txtvalortotal";
            this.txtvalortotal.Size = new System.Drawing.Size(120, 20);
            this.txtvalortotal.TabIndex = 39;
            // 
            // lblvalortotal
            // 
            this.lblvalortotal.AutoSize = true;
            this.lblvalortotal.Location = new System.Drawing.Point(18, 183);
            this.lblvalortotal.Name = "lblvalortotal";
            this.lblvalortotal.Size = new System.Drawing.Size(61, 13);
            this.lblvalortotal.TabIndex = 38;
            this.lblvalortotal.Text = "Valor Total:";
            // 
            // txtquantidade
            // 
            this.txtquantidade.Enabled = false;
            this.txtquantidade.Location = new System.Drawing.Point(125, 138);
            this.txtquantidade.Name = "txtquantidade";
            this.txtquantidade.Size = new System.Drawing.Size(120, 20);
            this.txtquantidade.TabIndex = 37;
            this.txtquantidade.Validated += new System.EventHandler(this.txtvalortotal_TextChanged);
            // 
            // lblquantidade
            // 
            this.lblquantidade.AutoSize = true;
            this.lblquantidade.Location = new System.Drawing.Point(18, 141);
            this.lblquantidade.Name = "lblquantidade";
            this.lblquantidade.Size = new System.Drawing.Size(65, 13);
            this.lblquantidade.TabIndex = 36;
            this.lblquantidade.Text = "Quantidade:";
            // 
            // txtvalorproduto
            // 
            this.txtvalorproduto.Enabled = false;
            this.txtvalorproduto.Location = new System.Drawing.Point(125, 103);
            this.txtvalorproduto.Name = "txtvalorproduto";
            this.txtvalorproduto.Size = new System.Drawing.Size(120, 20);
            this.txtvalorproduto.TabIndex = 35;
            // 
            // lblvalorproduto
            // 
            this.lblvalorproduto.AutoSize = true;
            this.lblvalorproduto.Location = new System.Drawing.Point(18, 106);
            this.lblvalorproduto.Name = "lblvalorproduto";
            this.lblvalorproduto.Size = new System.Drawing.Size(89, 13);
            this.lblvalorproduto.TabIndex = 34;
            this.lblvalorproduto.Text = "Valor do Produto:";
            // 
            // txtcodigoproduto
            // 
            this.txtcodigoproduto.Location = new System.Drawing.Point(125, 49);
            this.txtcodigoproduto.Name = "txtcodigoproduto";
            this.txtcodigoproduto.Size = new System.Drawing.Size(120, 20);
            this.txtcodigoproduto.TabIndex = 33;
            this.txtcodigoproduto.Validated += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblcodigoproduto
            // 
            this.lblcodigoproduto.AutoSize = true;
            this.lblcodigoproduto.Location = new System.Drawing.Point(18, 52);
            this.lblcodigoproduto.Name = "lblcodigoproduto";
            this.lblcodigoproduto.Size = new System.Drawing.Size(83, 13);
            this.lblcodigoproduto.TabIndex = 32;
            this.lblcodigoproduto.Text = "Código Produto:";
            // 
            // txtcodigofuncionario
            // 
            this.txtcodigofuncionario.Enabled = false;
            this.txtcodigofuncionario.Location = new System.Drawing.Point(125, 13);
            this.txtcodigofuncionario.Name = "txtcodigofuncionario";
            this.txtcodigofuncionario.Size = new System.Drawing.Size(120, 20);
            this.txtcodigofuncionario.TabIndex = 31;
            // 
            // lblcodigofuncionário
            // 
            this.lblcodigofuncionário.AutoSize = true;
            this.lblcodigofuncionário.Location = new System.Drawing.Point(18, 16);
            this.lblcodigofuncionário.Name = "lblcodigofuncionário";
            this.lblcodigofuncionário.Size = new System.Drawing.Size(101, 13);
            this.lblcodigofuncionário.TabIndex = 30;
            this.lblcodigofuncionário.Text = "Código Funcionário:";
            // 
            // gbVenda
            // 
            this.gbVenda.Controls.Add(this.txtValorAPagar);
            this.gbVenda.Controls.Add(this.label2);
            this.gbVenda.Controls.Add(this.cbxformadepagamento);
            this.gbVenda.Controls.Add(this.txttroco);
            this.gbVenda.Controls.Add(this.lbltroco);
            this.gbVenda.Controls.Add(this.txtvalorpago);
            this.gbVenda.Controls.Add(this.lblvalorpago);
            this.gbVenda.Controls.Add(this.lblformadepagamento);
            this.gbVenda.Enabled = false;
            this.gbVenda.Location = new System.Drawing.Point(12, 225);
            this.gbVenda.Name = "gbVenda";
            this.gbVenda.Size = new System.Drawing.Size(263, 159);
            this.gbVenda.TabIndex = 34;
            this.gbVenda.TabStop = false;
            this.gbVenda.Text = "Venda";
            // 
            // txtValorAPagar
            // 
            this.txtValorAPagar.Enabled = false;
            this.txtValorAPagar.Location = new System.Drawing.Point(125, 21);
            this.txtValorAPagar.Name = "txtValorAPagar";
            this.txtValorAPagar.Size = new System.Drawing.Size(120, 20);
            this.txtValorAPagar.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Valor a Pagar:";
            // 
            // cbxformadepagamento
            // 
            this.cbxformadepagamento.Enabled = false;
            this.cbxformadepagamento.FormattingEnabled = true;
            this.cbxformadepagamento.Location = new System.Drawing.Point(137, 58);
            this.cbxformadepagamento.Name = "cbxformadepagamento";
            this.cbxformadepagamento.Size = new System.Drawing.Size(108, 21);
            this.cbxformadepagamento.TabIndex = 38;
            // 
            // txttroco
            // 
            this.txttroco.Enabled = false;
            this.txttroco.Location = new System.Drawing.Point(125, 126);
            this.txttroco.Name = "txttroco";
            this.txttroco.Size = new System.Drawing.Size(120, 20);
            this.txttroco.TabIndex = 37;
            // 
            // lbltroco
            // 
            this.lbltroco.AutoSize = true;
            this.lbltroco.Location = new System.Drawing.Point(18, 133);
            this.lbltroco.Name = "lbltroco";
            this.lbltroco.Size = new System.Drawing.Size(38, 13);
            this.lbltroco.TabIndex = 36;
            this.lbltroco.Text = "Troco:";
            // 
            // txtvalorpago
            // 
            this.txtvalorpago.Enabled = false;
            this.txtvalorpago.Location = new System.Drawing.Point(125, 95);
            this.txtvalorpago.Name = "txtvalorpago";
            this.txtvalorpago.Size = new System.Drawing.Size(120, 20);
            this.txtvalorpago.TabIndex = 35;
            // 
            // lblvalorpago
            // 
            this.lblvalorpago.AutoSize = true;
            this.lblvalorpago.Location = new System.Drawing.Point(18, 102);
            this.lblvalorpago.Name = "lblvalorpago";
            this.lblvalorpago.Size = new System.Drawing.Size(62, 13);
            this.lblvalorpago.TabIndex = 34;
            this.lblvalorpago.Text = "Valor Pago:";
            // 
            // lblformadepagamento
            // 
            this.lblformadepagamento.AutoSize = true;
            this.lblformadepagamento.Location = new System.Drawing.Point(18, 61);
            this.lblformadepagamento.Name = "lblformadepagamento";
            this.lblformadepagamento.Size = new System.Drawing.Size(113, 13);
            this.lblformadepagamento.TabIndex = 33;
            this.lblformadepagamento.Text = "Forma De Pagamento:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(20, 402);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(0, 13);
            this.lbl1.TabIndex = 36;
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(20, 430);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(0, 13);
            this.lbl2.TabIndex = 38;
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(20, 455);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(0, 13);
            this.lbl3.TabIndex = 56;
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(202, 452);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(0, 13);
            this.lbl6.TabIndex = 62;
            this.lbl6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(202, 427);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(0, 13);
            this.lbl5.TabIndex = 60;
            this.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(202, 399);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(0, 13);
            this.lbl4.TabIndex = 58;
            this.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Location = new System.Drawing.Point(386, 452);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(0, 13);
            this.lbl9.TabIndex = 68;
            this.lbl9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Location = new System.Drawing.Point(386, 427);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(0, 13);
            this.lbl8.TabIndex = 66;
            this.lbl8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(386, 399);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(0, 13);
            this.lbl7.TabIndex = 64;
            this.lbl7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl12
            // 
            this.lbl12.AutoSize = true;
            this.lbl12.Location = new System.Drawing.Point(581, 449);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(0, 13);
            this.lbl12.TabIndex = 74;
            this.lbl12.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lbl11
            // 
            this.lbl11.AutoSize = true;
            this.lbl11.Location = new System.Drawing.Point(581, 424);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(0, 13);
            this.lbl11.TabIndex = 72;
            this.lbl11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.Location = new System.Drawing.Point(581, 396);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(0, 13);
            this.lbl10.TabIndex = 70;
            this.lbl10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pcb12
            // 
            this.pcb12.Location = new System.Drawing.Point(698, 446);
            this.pcb12.Name = "pcb12";
            this.pcb12.Size = new System.Drawing.Size(23, 19);
            this.pcb12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb12.TabIndex = 73;
            this.pcb12.TabStop = false;
            // 
            // pcb11
            // 
            this.pcb11.Location = new System.Drawing.Point(698, 421);
            this.pcb11.Name = "pcb11";
            this.pcb11.Size = new System.Drawing.Size(23, 19);
            this.pcb11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb11.TabIndex = 71;
            this.pcb11.TabStop = false;
            // 
            // pcb10
            // 
            this.pcb10.Location = new System.Drawing.Point(698, 393);
            this.pcb10.Name = "pcb10";
            this.pcb10.Size = new System.Drawing.Size(23, 19);
            this.pcb10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb10.TabIndex = 69;
            this.pcb10.TabStop = false;
            // 
            // pcb9
            // 
            this.pcb9.Location = new System.Drawing.Point(503, 449);
            this.pcb9.Name = "pcb9";
            this.pcb9.Size = new System.Drawing.Size(23, 19);
            this.pcb9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb9.TabIndex = 67;
            this.pcb9.TabStop = false;
            // 
            // pcb8
            // 
            this.pcb8.Location = new System.Drawing.Point(503, 424);
            this.pcb8.Name = "pcb8";
            this.pcb8.Size = new System.Drawing.Size(23, 19);
            this.pcb8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb8.TabIndex = 65;
            this.pcb8.TabStop = false;
            // 
            // pcb7
            // 
            this.pcb7.Location = new System.Drawing.Point(503, 396);
            this.pcb7.Name = "pcb7";
            this.pcb7.Size = new System.Drawing.Size(23, 19);
            this.pcb7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb7.TabIndex = 63;
            this.pcb7.TabStop = false;
            // 
            // pcb6
            // 
            this.pcb6.Location = new System.Drawing.Point(319, 449);
            this.pcb6.Name = "pcb6";
            this.pcb6.Size = new System.Drawing.Size(23, 19);
            this.pcb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb6.TabIndex = 61;
            this.pcb6.TabStop = false;
            // 
            // pcb5
            // 
            this.pcb5.Location = new System.Drawing.Point(319, 424);
            this.pcb5.Name = "pcb5";
            this.pcb5.Size = new System.Drawing.Size(23, 19);
            this.pcb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb5.TabIndex = 59;
            this.pcb5.TabStop = false;
            // 
            // pcb4
            // 
            this.pcb4.Location = new System.Drawing.Point(319, 396);
            this.pcb4.Name = "pcb4";
            this.pcb4.Size = new System.Drawing.Size(23, 19);
            this.pcb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb4.TabIndex = 57;
            this.pcb4.TabStop = false;
            // 
            // pcb3
            // 
            this.pcb3.Location = new System.Drawing.Point(137, 452);
            this.pcb3.Name = "pcb3";
            this.pcb3.Size = new System.Drawing.Size(23, 19);
            this.pcb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb3.TabIndex = 55;
            this.pcb3.TabStop = false;
            // 
            // pcb2
            // 
            this.pcb2.Location = new System.Drawing.Point(137, 427);
            this.pcb2.Name = "pcb2";
            this.pcb2.Size = new System.Drawing.Size(23, 19);
            this.pcb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb2.TabIndex = 37;
            this.pcb2.TabStop = false;
            // 
            // pcb1
            // 
            this.pcb1.Location = new System.Drawing.Point(137, 399);
            this.pcb1.Name = "pcb1";
            this.pcb1.Size = new System.Drawing.Size(23, 19);
            this.pcb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb1.TabIndex = 35;
            this.pcb1.TabStop = false;
            this.pcb1.Click += new System.EventHandler(this.pcb1_Click);
            // 
            // vendadeproduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 483);
            this.Controls.Add(this.lbl12);
            this.Controls.Add(this.pcb12);
            this.Controls.Add(this.lbl11);
            this.Controls.Add(this.pcb11);
            this.Controls.Add(this.lbl10);
            this.Controls.Add(this.pcb10);
            this.Controls.Add(this.lbl9);
            this.Controls.Add(this.pcb9);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.pcb8);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.pcb7);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.pcb6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.pcb5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.pcb4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.pcb3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.pcb2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.pcb1);
            this.Controls.Add(this.gbVenda);
            this.Controls.Add(this.gbProduto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnconcluir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgProdutos);
            this.Name = "vendadeproduto";
            this.Text = "Caixa Produto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.vendadeproduto_FormClosing);
            this.Load += new System.EventHandler(this.vendadeproduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).EndInit();
            this.gbProduto.ResumeLayout(false);
            this.gbProduto.PerformLayout();
            this.gbVenda.ResumeLayout(false);
            this.gbVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorVenda;
        private System.Windows.Forms.Button btnconcluir;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbProduto;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtvalortotal;
        private System.Windows.Forms.Label lblvalortotal;
        private System.Windows.Forms.TextBox txtquantidade;
        private System.Windows.Forms.Label lblquantidade;
        private System.Windows.Forms.TextBox txtvalorproduto;
        private System.Windows.Forms.Label lblvalorproduto;
        private System.Windows.Forms.TextBox txtcodigoproduto;
        private System.Windows.Forms.Label lblcodigoproduto;
        private System.Windows.Forms.TextBox txtcodigofuncionario;
        private System.Windows.Forms.Label lblcodigofuncionário;
        private System.Windows.Forms.GroupBox gbVenda;
        private System.Windows.Forms.TextBox txtValorAPagar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxformadepagamento;
        private System.Windows.Forms.TextBox txttroco;
        private System.Windows.Forms.Label lbltroco;
        private System.Windows.Forms.TextBox txtvalorpago;
        private System.Windows.Forms.Label lblvalorpago;
        private System.Windows.Forms.Label lblformadepagamento;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.PictureBox pcb1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.PictureBox pcb2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.PictureBox pcb3;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.PictureBox pcb6;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.PictureBox pcb5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.PictureBox pcb4;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.PictureBox pcb9;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.PictureBox pcb8;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.PictureBox pcb7;
        private System.Windows.Forms.Label lbl12;
        private System.Windows.Forms.PictureBox pcb12;
        private System.Windows.Forms.Label lbl11;
        private System.Windows.Forms.PictureBox pcb11;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.PictureBox pcb10;
    }
}