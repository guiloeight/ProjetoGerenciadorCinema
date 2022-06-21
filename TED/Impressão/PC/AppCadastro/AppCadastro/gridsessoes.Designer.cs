namespace AppCadastro
{
    partial class gridsessoes
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
            this.dgvfornecedor = new System.Windows.Forms.DataGridView();
            this.filme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(215, 310);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(82, 33);
            this.btnsair.TabIndex = 5;
            this.btnsair.Text = "&Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // dgvfornecedor
            // 
            this.dgvfornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filme,
            this.horario,
            this.sala,
            this.d3});
            this.dgvfornecedor.Location = new System.Drawing.Point(44, 11);
            this.dgvfornecedor.Name = "dgvfornecedor";
            this.dgvfornecedor.Size = new System.Drawing.Size(446, 291);
            this.dgvfornecedor.TabIndex = 3;
            // 
            // filme
            // 
            this.filme.HeaderText = "Filme";
            this.filme.Name = "filme";
            // 
            // horario
            // 
            this.horario.HeaderText = "Horário";
            this.horario.Name = "horario";
            // 
            // sala
            // 
            this.sala.HeaderText = "Sala";
            this.sala.Name = "sala";
            // 
            // d3
            // 
            this.d3.HeaderText = "3D";
            this.d3.Name = "d3";
            // 
            // gridsessoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(551, 355);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.dgvfornecedor);
            this.Name = "gridsessoes";
            this.Text = "Sessões";
            this.Load += new System.EventHandler(this.gridsessoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfornecedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.DataGridView dgvfornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn filme;
        private System.Windows.Forms.DataGridViewTextBoxColumn horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn sala;
        private System.Windows.Forms.DataGridViewTextBoxColumn d3;
    }
}