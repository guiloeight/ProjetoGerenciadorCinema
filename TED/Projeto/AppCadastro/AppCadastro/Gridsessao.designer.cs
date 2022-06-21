namespace AppCadastro
{
    partial class Gridsessao
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dvgSessao = new System.Windows.Forms.DataGridView();
            this.Filme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgSessao)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVoltar.Location = new System.Drawing.Point(190, 255);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(91, 23);
            this.btnVoltar.TabIndex = 33;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dvgSessao
            // 
            this.dvgSessao.AllowUserToAddRows = false;
            this.dvgSessao.AllowUserToDeleteRows = false;
            this.dvgSessao.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgSessao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgSessao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgSessao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Filme,
            this.horario,
            this.sala,
            this.d3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgSessao.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvgSessao.Location = new System.Drawing.Point(43, 21);
            this.dvgSessao.Name = "dvgSessao";
            this.dvgSessao.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgSessao.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dvgSessao.Size = new System.Drawing.Size(385, 228);
            this.dvgSessao.TabIndex = 32;
            this.dvgSessao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgSessao_CellContentClick);
            // 
            // Filme
            // 
            this.Filme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Filme.HeaderText = "Filme";
            this.Filme.Name = "Filme";
            this.Filme.ReadOnly = true;
            this.Filme.Width = 56;
            // 
            // horario
            // 
            this.horario.HeaderText = "Horário";
            this.horario.Name = "horario";
            this.horario.ReadOnly = true;
            // 
            // sala
            // 
            this.sala.HeaderText = "Sala";
            this.sala.Name = "sala";
            this.sala.ReadOnly = true;
            // 
            // d3
            // 
            this.d3.HeaderText = "3D";
            this.d3.Name = "d3";
            this.d3.ReadOnly = true;
            // 
            // Gridsessao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppCadastro.Properties.Resources.teste3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(487, 298);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dvgSessao);
            this.DoubleBuffered = true;
            this.Name = "Gridsessao";
            this.Text = "Consulta Sessão";
            this.Load += new System.EventHandler(this.Gridsessao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgSessao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dvgSessao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Filme;
        private System.Windows.Forms.DataGridViewTextBoxColumn horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn sala;
        private System.Windows.Forms.DataGridViewTextBoxColumn d3;
    }
}