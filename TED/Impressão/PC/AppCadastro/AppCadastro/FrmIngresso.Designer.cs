namespace AppCadastro
{
    partial class FrmIngresso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIngresso));
            this.lblFilme = new System.Windows.Forms.Label();
            this.cbxSessao = new System.Windows.Forms.ComboBox();
            this.lblHorário = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblQuantidadeDeIngressos = new System.Windows.Forms.Label();
            this.txtQuantidadeDeIngressos = new System.Windows.Forms.TextBox();
            this.lblTotalDaCompra = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMeias = new System.Windows.Forms.ComboBox();
            this.cbxFilme = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtSala = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFilme
            // 
            this.lblFilme.AutoSize = true;
            this.lblFilme.Location = new System.Drawing.Point(9, 26);
            this.lblFilme.Name = "lblFilme";
            this.lblFilme.Size = new System.Drawing.Size(34, 13);
            this.lblFilme.TabIndex = 0;
            this.lblFilme.Text = "Filme:";
            // 
            // cbxSessao
            // 
            this.cbxSessao.FormattingEnabled = true;
            this.cbxSessao.Location = new System.Drawing.Point(57, 50);
            this.cbxSessao.Name = "cbxSessao";
            this.cbxSessao.Size = new System.Drawing.Size(287, 21);
            this.cbxSessao.TabIndex = 3;
            this.cbxSessao.Validated += new System.EventHandler(this.btnSessao2);
            // 
            // lblHorário
            // 
            this.lblHorário.AutoSize = true;
            this.lblHorário.Location = new System.Drawing.Point(9, 53);
            this.lblHorário.Name = "lblHorário";
            this.lblHorário.Size = new System.Drawing.Size(45, 13);
            this.lblHorário.TabIndex = 2;
            this.lblHorário.Text = "Sessão:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(9, 113);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(38, 13);
            this.lblPreco.TabIndex = 4;
            this.lblPreco.Text = "Preço:";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(56, 110);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(89, 20);
            this.txtPreco.TabIndex = 7;
            // 
            // lblQuantidadeDeIngressos
            // 
            this.lblQuantidadeDeIngressos.AutoSize = true;
            this.lblQuantidadeDeIngressos.Location = new System.Drawing.Point(151, 113);
            this.lblQuantidadeDeIngressos.Name = "lblQuantidadeDeIngressos";
            this.lblQuantidadeDeIngressos.Size = new System.Drawing.Size(65, 13);
            this.lblQuantidadeDeIngressos.TabIndex = 8;
            this.lblQuantidadeDeIngressos.Text = "Quantidade:";
            // 
            // txtQuantidadeDeIngressos
            // 
            this.txtQuantidadeDeIngressos.Location = new System.Drawing.Point(223, 110);
            this.txtQuantidadeDeIngressos.Name = "txtQuantidadeDeIngressos";
            this.txtQuantidadeDeIngressos.Size = new System.Drawing.Size(80, 20);
            this.txtQuantidadeDeIngressos.TabIndex = 9;
            this.txtQuantidadeDeIngressos.Validated += new System.EventHandler(this.txtQuantidadeDeIngressos_Click);
            // 
            // lblTotalDaCompra
            // 
            this.lblTotalDaCompra.AutoSize = true;
            this.lblTotalDaCompra.Location = new System.Drawing.Point(9, 188);
            this.lblTotalDaCompra.Name = "lblTotalDaCompra";
            this.lblTotalDaCompra.Size = new System.Drawing.Size(90, 13);
            this.lblTotalDaCompra.TabIndex = 11;
            this.lblTotalDaCompra.Text = "Total Da Compra:";
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(114, 183);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(163, 22);
            this.lblTotal.TabIndex = 12;
            // 
            // btnImprimir
            // 
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.Location = new System.Drawing.Point(253, 212);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(83, 45);
            this.btnImprimir.TabIndex = 13;
            this.btnImprimir.Text = "Imprimir Ingresso";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Meias:";
            // 
            // cmbMeias
            // 
            this.cmbMeias.FormattingEnabled = true;
            this.cmbMeias.Location = new System.Drawing.Point(56, 141);
            this.cmbMeias.Name = "cmbMeias";
            this.cmbMeias.Size = new System.Drawing.Size(87, 21);
            this.cmbMeias.TabIndex = 17;
            // 
            // cbxFilme
            // 
            this.cbxFilme.FormattingEnabled = true;
            this.cbxFilme.Location = new System.Drawing.Point(57, 23);
            this.cbxFilme.Name = "cbxFilme";
            this.cbxFilme.Size = new System.Drawing.Size(221, 21);
            this.cbxFilme.TabIndex = 18;
            this.cbxFilme.SelectedIndexChanged += new System.EventHandler(this.cbxFilme_SelectedIndexChanged);
            this.cbxFilme.Validated += new System.EventHandler(this.btnSessao_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 239);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(216, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // txtSala
            // 
            this.txtSala.Location = new System.Drawing.Point(223, 77);
            this.txtSala.Name = "txtSala";
            this.txtSala.Size = new System.Drawing.Size(80, 20);
            this.txtSala.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Sala:";
            // 
            // txtHorario
            // 
            this.txtHorario.Location = new System.Drawing.Point(57, 77);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(89, 20);
            this.txtHorario.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Horário:";
            // 
            // FrmIngresso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 418);
            this.Controls.Add(this.txtSala);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbxFilme);
            this.Controls.Add(this.cmbMeias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTotalDaCompra);
            this.Controls.Add(this.txtQuantidadeDeIngressos);
            this.Controls.Add(this.lblQuantidadeDeIngressos);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.cbxSessao);
            this.Controls.Add(this.lblHorário);
            this.Controls.Add(this.lblFilme);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmIngresso";
            this.Text = "Novo Ingresso";
            this.Load += new System.EventHandler(this.FrmIngresso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFilme;
        private System.Windows.Forms.ComboBox cbxSessao;
        private System.Windows.Forms.Label lblHorário;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblQuantidadeDeIngressos;
        private System.Windows.Forms.TextBox txtQuantidadeDeIngressos;
        private System.Windows.Forms.Label lblTotalDaCompra;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMeias;
        private System.Windows.Forms.ComboBox cbxFilme;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtSala;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.Label label3;
    }
}