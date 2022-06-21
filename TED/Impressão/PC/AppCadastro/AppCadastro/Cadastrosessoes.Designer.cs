namespace AppCadastro
{
    partial class Cadastrosessoes
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
            this.lblfilme = new System.Windows.Forms.Label();
            this.cbxfilme = new System.Windows.Forms.ComboBox();
            this.txthorario = new System.Windows.Forms.MaskedTextBox();
            this.lblhorário = new System.Windows.Forms.Label();
            this.lbsala = new System.Windows.Forms.ComboBox();
            this.lblsala = new System.Windows.Forms.Label();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.btngrid = new System.Windows.Forms.Button();
            this.lbl3d = new System.Windows.Forms.Label();
            this.cbx3d = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTRY = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblfilme
            // 
            this.lblfilme.AutoSize = true;
            this.lblfilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfilme.Location = new System.Drawing.Point(5, 13);
            this.lblfilme.Name = "lblfilme";
            this.lblfilme.Size = new System.Drawing.Size(44, 16);
            this.lblfilme.TabIndex = 0;
            this.lblfilme.Text = "Filme:";
            // 
            // cbxfilme
            // 
            this.cbxfilme.FormattingEnabled = true;
            this.cbxfilme.Location = new System.Drawing.Point(78, 13);
            this.cbxfilme.Name = "cbxfilme";
            this.cbxfilme.Size = new System.Drawing.Size(129, 21);
            this.cbxfilme.TabIndex = 1;
            this.cbxfilme.SelectedIndexChanged += new System.EventHandler(this.cbxfilme_SelectedIndexChanged);
            // 
            // txthorario
            // 
            this.txthorario.Location = new System.Drawing.Point(78, 50);
            this.txthorario.Mask = "00:00";
            this.txthorario.Name = "txthorario";
            this.txthorario.Size = new System.Drawing.Size(129, 20);
            this.txthorario.TabIndex = 77;
            this.txthorario.ValidatingType = typeof(System.DateTime);
            // 
            // lblhorário
            // 
            this.lblhorário.AutoSize = true;
            this.lblhorário.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhorário.Location = new System.Drawing.Point(5, 50);
            this.lblhorário.Name = "lblhorário";
            this.lblhorário.Size = new System.Drawing.Size(56, 16);
            this.lblhorário.TabIndex = 76;
            this.lblhorário.Text = "Horário:";
            // 
            // lbsala
            // 
            this.lbsala.FormattingEnabled = true;
            this.lbsala.Location = new System.Drawing.Point(78, 92);
            this.lbsala.Name = "lbsala";
            this.lbsala.Size = new System.Drawing.Size(129, 21);
            this.lbsala.TabIndex = 79;
            this.lbsala.SelectedIndexChanged += new System.EventHandler(this.lbsala_SelectedIndexChanged);
            this.lbsala.Validated += new System.EventHandler(this.TRY_Click);
            // 
            // lblsala
            // 
            this.lblsala.AutoSize = true;
            this.lblsala.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsala.Location = new System.Drawing.Point(5, 92);
            this.lblsala.Name = "lblsala";
            this.lblsala.Size = new System.Drawing.Size(39, 16);
            this.lblsala.TabIndex = 78;
            this.lblsala.Text = "Sala:";
            // 
            // btncadastrar
            // 
            this.btncadastrar.Location = new System.Drawing.Point(226, 13);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(103, 25);
            this.btncadastrar.TabIndex = 81;
            this.btncadastrar.Text = "&Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // btngrid
            // 
            this.btngrid.Location = new System.Drawing.Point(226, 75);
            this.btngrid.Name = "btngrid";
            this.btngrid.Size = new System.Drawing.Size(103, 26);
            this.btngrid.TabIndex = 82;
            this.btngrid.Text = "&Grid";
            this.btngrid.UseVisualStyleBackColor = true;
            this.btngrid.Click += new System.EventHandler(this.btngrid_Click);
            // 
            // lbl3d
            // 
            this.lbl3d.AutoSize = true;
            this.lbl3d.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3d.Location = new System.Drawing.Point(5, 131);
            this.lbl3d.Name = "lbl3d";
            this.lbl3d.Size = new System.Drawing.Size(28, 16);
            this.lbl3d.TabIndex = 83;
            this.lbl3d.Text = "3D:";
            // 
            // cbx3d
            // 
            this.cbx3d.FormattingEnabled = true;
            this.cbx3d.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbx3d.Location = new System.Drawing.Point(78, 130);
            this.cbx3d.Name = "cbx3d";
            this.cbx3d.Size = new System.Drawing.Size(129, 21);
            this.cbx3d.TabIndex = 84;
            this.cbx3d.SelectedIndexChanged += new System.EventHandler(this.cbx3d_SelectedIndexChanged);
            this.cbx3d.Validated += new System.EventHandler(this.gerarNome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 85;
            this.label1.Text = "Nome da Sessão:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(8, 183);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(318, 20);
            this.txtNome.TabIndex = 86;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtTRY
            // 
            this.txtTRY.AutoSize = true;
            this.txtTRY.Location = new System.Drawing.Point(234, 130);
            this.txtTRY.Name = "txtTRY";
            this.txtTRY.Size = new System.Drawing.Size(0, 13);
            this.txtTRY.TabIndex = 87;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(226, 44);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(103, 25);
            this.btnExcluir.TabIndex = 88;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // Cadastrosessoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 218);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.txtTRY);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx3d);
            this.Controls.Add(this.lbl3d);
            this.Controls.Add(this.btngrid);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.lbsala);
            this.Controls.Add(this.lblsala);
            this.Controls.Add(this.txthorario);
            this.Controls.Add(this.lblhorário);
            this.Controls.Add(this.cbxfilme);
            this.Controls.Add(this.lblfilme);
            this.Name = "Cadastrosessoes";
            this.Text = " Cadastro de Sessões";
            this.Load += new System.EventHandler(this.Cadastrosessoes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfilme;
        private System.Windows.Forms.ComboBox cbxfilme;
        private System.Windows.Forms.MaskedTextBox txthorario;
        private System.Windows.Forms.Label lblhorário;
        private System.Windows.Forms.ComboBox lbsala;
        private System.Windows.Forms.Label lblsala;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Button btngrid;
        private System.Windows.Forms.Label lbl3d;
        private System.Windows.Forms.ComboBox cbx3d;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label txtTRY;
        private System.Windows.Forms.Button btnExcluir;
    }
}