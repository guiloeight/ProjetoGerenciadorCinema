namespace AppCadastro
{
    partial class GridFunc
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
            this.dgvFunc = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeFunc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BairroFunc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroEndfunc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone1Func = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone2Func = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Func = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexFunc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadocivilFunc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endFunc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFunc
            // 
            this.dgvFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.cidadeFunc,
            this.BairroFunc,
            this.numeroEndfunc,
            this.telefone1Func,
            this.telefone2Func,
            this.Func,
            this.sexFunc,
            this.estadocivilFunc,
            this.endFunc});
            this.dgvFunc.Location = new System.Drawing.Point(48, 21);
            this.dgvFunc.Name = "dgvFunc";
            this.dgvFunc.Size = new System.Drawing.Size(643, 277);
            this.dgvFunc.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "CodFun";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // cidadeFunc
            // 
            this.cidadeFunc.HeaderText = "Cidade";
            this.cidadeFunc.Name = "cidadeFunc";
            // 
            // BairroFunc
            // 
            this.BairroFunc.HeaderText = "Bairro";
            this.BairroFunc.Name = "BairroFunc";
            // 
            // numeroEndfunc
            // 
            this.numeroEndfunc.HeaderText = "Número";
            this.numeroEndfunc.Name = "numeroEndfunc";
            // 
            // telefone1Func
            // 
            this.telefone1Func.HeaderText = "Telefone1";
            this.telefone1Func.Name = "telefone1Func";
            // 
            // telefone2Func
            // 
            this.telefone2Func.HeaderText = "Telefone2";
            this.telefone2Func.Name = "telefone2Func";
            // 
            // Func
            // 
            this.Func.HeaderText = "Funcionário";
            this.Func.Name = "Func";
            // 
            // sexFunc
            // 
            this.sexFunc.HeaderText = "Sexo";
            this.sexFunc.Name = "sexFunc";
            // 
            // estadocivilFunc
            // 
            this.estadocivilFunc.HeaderText = "Estado Civil";
            this.estadocivilFunc.Name = "estadocivilFunc";
            // 
            // endFunc
            // 
            this.endFunc.HeaderText = "Endereço";
            this.endFunc.Name = "endFunc";
            // 
            // GridFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(719, 371);
            this.Controls.Add(this.dgvFunc);
            this.Name = "GridFunc";
            this.Text = "Funcionário";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeFunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn BairroFunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroEndfunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone1Func;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone2Func;
        private System.Windows.Forms.DataGridViewTextBoxColumn Func;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexFunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadocivilFunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn endFunc;
    }
}