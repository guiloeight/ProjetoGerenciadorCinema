namespace AppCadastro
{
    partial class chave
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtchave = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(23, 51);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(206, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Não possuei a Chave? Acesse nosso site.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chave:";
            // 
            // txtchave
            // 
            this.txtchave.Location = new System.Drawing.Point(68, 18);
            this.txtchave.Name = "txtchave";
            this.txtchave.PasswordChar = '*';
            this.txtchave.Size = new System.Drawing.Size(151, 20);
            this.txtchave.TabIndex = 2;
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(257, 15);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(81, 25);
            this.btnok.TabIndex = 3;
            this.btnok.Text = "&OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "&Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppCadastro.Properties.Resources.jachegaBg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(439, 73);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txtchave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.DoubleBuffered = true;
            this.Name = "chave";
            this.Text = "Chave de Cadastro";
            this.Load += new System.EventHandler(this.chave_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtchave;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button button1;
    }
}