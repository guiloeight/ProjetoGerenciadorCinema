namespace AppCadastro
{
    partial class frmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.btnAlterarUs = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnConsultarUs = new System.Windows.Forms.Button();
            this.btnLimparCli = new System.Windows.Forms.Button();
            this.btnExcluirUs = new System.Windows.Forms.Button();
            this.btnCadastrarUs = new System.Windows.Forms.Button();
            this.txtNomeCli = new System.Windows.Forms.TextBox();
            this.txtCodCli = new System.Windows.Forms.TextBox();
            this.lblNomeCli = new System.Windows.Forms.Label();
            this.lblCodCli = new System.Windows.Forms.Label();
            this.txtEndCli = new System.Windows.Forms.TextBox();
            this.lblEndCli = new System.Windows.Forms.Label();
            this.lblTelCli = new System.Windows.Forms.Label();
            this.bntDesabilitar = new System.Windows.Forms.Button();
            this.btnHabilitar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnGrid = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.txtTelCli = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlterarUs
            // 
            this.btnAlterarUs.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAlterarUs.Location = new System.Drawing.Point(426, 12);
            this.btnAlterarUs.Name = "btnAlterarUs";
            this.btnAlterarUs.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarUs.TabIndex = 19;
            this.btnAlterarUs.Text = "&Alterar";
            this.btnAlterarUs.UseVisualStyleBackColor = false;
            this.btnAlterarUs.Click += new System.EventHandler(this.btnAlterarUs_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSair.Location = new System.Drawing.Point(426, 72);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 18;
            this.btnSair.Text = "&Voltar";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnConsultarUs
            // 
            this.btnConsultarUs.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConsultarUs.Location = new System.Drawing.Point(345, 40);
            this.btnConsultarUs.Name = "btnConsultarUs";
            this.btnConsultarUs.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarUs.TabIndex = 17;
            this.btnConsultarUs.Text = "Consultar";
            this.btnConsultarUs.UseVisualStyleBackColor = false;
            this.btnConsultarUs.Click += new System.EventHandler(this.btnConsultarUs_Click);
            // 
            // btnLimparCli
            // 
            this.btnLimparCli.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimparCli.Location = new System.Drawing.Point(345, 72);
            this.btnLimparCli.Name = "btnLimparCli";
            this.btnLimparCli.Size = new System.Drawing.Size(75, 23);
            this.btnLimparCli.TabIndex = 16;
            this.btnLimparCli.Text = "&Limpar";
            this.btnLimparCli.UseVisualStyleBackColor = false;
            this.btnLimparCli.Click += new System.EventHandler(this.btnLimparCli_Click);
            // 
            // btnExcluirUs
            // 
            this.btnExcluirUs.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluirUs.Location = new System.Drawing.Point(426, 43);
            this.btnExcluirUs.Name = "btnExcluirUs";
            this.btnExcluirUs.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirUs.TabIndex = 15;
            this.btnExcluirUs.Text = "&Excluir";
            this.btnExcluirUs.UseVisualStyleBackColor = false;
            this.btnExcluirUs.Click += new System.EventHandler(this.btnExcluirUs_Click);
            // 
            // btnCadastrarUs
            // 
            this.btnCadastrarUs.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCadastrarUs.Location = new System.Drawing.Point(345, 12);
            this.btnCadastrarUs.Name = "btnCadastrarUs";
            this.btnCadastrarUs.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarUs.TabIndex = 14;
            this.btnCadastrarUs.Text = "&Cadastrar ";
            this.btnCadastrarUs.UseVisualStyleBackColor = false;
            this.btnCadastrarUs.Click += new System.EventHandler(this.btnCadastrarUs_Click);
            // 
            // txtNomeCli
            // 
            this.txtNomeCli.Location = new System.Drawing.Point(239, 45);
            this.txtNomeCli.Name = "txtNomeCli";
            this.txtNomeCli.Size = new System.Drawing.Size(100, 20);
            this.txtNomeCli.TabIndex = 13;
            this.txtNomeCli.Tag = "";
            // 
            // txtCodCli
            // 
            this.txtCodCli.Enabled = false;
            this.txtCodCli.Location = new System.Drawing.Point(239, 19);
            this.txtCodCli.Name = "txtCodCli";
            this.txtCodCli.Size = new System.Drawing.Size(100, 20);
            this.txtCodCli.TabIndex = 12;
            // 
            // lblNomeCli
            // 
            this.lblNomeCli.AutoSize = true;
            this.lblNomeCli.Location = new System.Drawing.Point(198, 48);
            this.lblNomeCli.Name = "lblNomeCli";
            this.lblNomeCli.Size = new System.Drawing.Size(38, 13);
            this.lblNomeCli.TabIndex = 11;
            this.lblNomeCli.Text = "Nome:";
            // 
            // lblCodCli
            // 
            this.lblCodCli.AutoSize = true;
            this.lblCodCli.Location = new System.Drawing.Point(193, 22);
            this.lblCodCli.Name = "lblCodCli";
            this.lblCodCli.Size = new System.Drawing.Size(43, 13);
            this.lblCodCli.TabIndex = 10;
            this.lblCodCli.Text = "Código:";
            this.lblCodCli.Click += new System.EventHandler(this.lblCodCli_Click);
            // 
            // txtEndCli
            // 
            this.txtEndCli.Location = new System.Drawing.Point(239, 100);
            this.txtEndCli.Name = "txtEndCli";
            this.txtEndCli.Size = new System.Drawing.Size(262, 20);
            this.txtEndCli.TabIndex = 21;
            this.txtEndCli.Tag = "";
            // 
            // lblEndCli
            // 
            this.lblEndCli.AutoSize = true;
            this.lblEndCli.Location = new System.Drawing.Point(180, 100);
            this.lblEndCli.Name = "lblEndCli";
            this.lblEndCli.Size = new System.Drawing.Size(56, 13);
            this.lblEndCli.TabIndex = 20;
            this.lblEndCli.Text = "Endereço:";
            // 
            // lblTelCli
            // 
            this.lblTelCli.AutoSize = true;
            this.lblTelCli.Location = new System.Drawing.Point(184, 74);
            this.lblTelCli.Name = "lblTelCli";
            this.lblTelCli.Size = new System.Drawing.Size(52, 13);
            this.lblTelCli.TabIndex = 22;
            this.lblTelCli.Tag = "(__)____-____";
            this.lblTelCli.Text = "Telefone:";
            // 
            // bntDesabilitar
            // 
            this.bntDesabilitar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bntDesabilitar.Location = new System.Drawing.Point(426, 126);
            this.bntDesabilitar.Name = "bntDesabilitar";
            this.bntDesabilitar.Size = new System.Drawing.Size(75, 23);
            this.bntDesabilitar.TabIndex = 25;
            this.bntDesabilitar.Text = "&Desabilitar";
            this.bntDesabilitar.UseVisualStyleBackColor = false;
            this.bntDesabilitar.Click += new System.EventHandler(this.bntDesabilitar_Click);
            // 
            // btnHabilitar
            // 
            this.btnHabilitar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHabilitar.Location = new System.Drawing.Point(345, 126);
            this.btnHabilitar.Name = "btnHabilitar";
            this.btnHabilitar.Size = new System.Drawing.Size(75, 23);
            this.btnHabilitar.TabIndex = 24;
            this.btnHabilitar.Text = "&Habilitar ";
            this.btnHabilitar.UseVisualStyleBackColor = false;
            this.btnHabilitar.Click += new System.EventHandler(this.btnHabilitar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnImprimir.Location = new System.Drawing.Point(264, 126);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 27;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnGrid
            // 
            this.btnGrid.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGrid.Location = new System.Drawing.Point(183, 126);
            this.btnGrid.Name = "btnGrid";
            this.btnGrid.Size = new System.Drawing.Size(75, 23);
            this.btnGrid.TabIndex = 26;
            this.btnGrid.Text = "&Grid";
            this.btnGrid.UseVisualStyleBackColor = false;
            this.btnGrid.Click += new System.EventHandler(this.btnGrid_Click);
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
            // txtTelCli
            // 
            this.txtTelCli.Location = new System.Drawing.Point(239, 71);
            this.txtTelCli.Mask = "(00)0000-9999";
            this.txtTelCli.Name = "txtTelCli";
            this.txtTelCli.Size = new System.Drawing.Size(100, 20);
            this.txtTelCli.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppCadastro.Properties.Resources.Actions_contact_new_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(513, 162);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTelCli);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnGrid);
            this.Controls.Add(this.bntDesabilitar);
            this.Controls.Add(this.btnHabilitar);
            this.Controls.Add(this.lblTelCli);
            this.Controls.Add(this.txtEndCli);
            this.Controls.Add(this.lblEndCli);
            this.Controls.Add(this.btnAlterarUs);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnConsultarUs);
            this.Controls.Add(this.btnLimparCli);
            this.Controls.Add(this.btnExcluirUs);
            this.Controls.Add(this.btnCadastrarUs);
            this.Controls.Add(this.txtNomeCli);
            this.Controls.Add(this.txtCodCli);
            this.Controls.Add(this.lblNomeCli);
            this.Controls.Add(this.lblCodCli);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(529, 200);
            this.MinimumSize = new System.Drawing.Size(529, 200);
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlterarUs;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnConsultarUs;
        private System.Windows.Forms.Button btnLimparCli;
        private System.Windows.Forms.Button btnExcluirUs;
        private System.Windows.Forms.Button btnCadastrarUs;
        private System.Windows.Forms.TextBox txtNomeCli;
        private System.Windows.Forms.TextBox txtCodCli;
        private System.Windows.Forms.Label lblNomeCli;
        private System.Windows.Forms.Label lblCodCli;
        private System.Windows.Forms.TextBox txtEndCli;
        private System.Windows.Forms.Label lblEndCli;
        private System.Windows.Forms.Label lblTelCli;
        private System.Windows.Forms.Button bntDesabilitar;
        private System.Windows.Forms.Button btnHabilitar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnGrid;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.MaskedTextBox txtTelCli;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}