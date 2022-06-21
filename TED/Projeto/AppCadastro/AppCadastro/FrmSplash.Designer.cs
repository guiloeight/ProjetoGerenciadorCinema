namespace AppCadastro
{
    partial class FrmSplash2
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pcbSplash = new System.Windows.Forms.PictureBox();
            this.pgbsplash = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSplash)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pcbSplash
            // 
            this.pcbSplash.Image = global::AppCadastro.Properties.Resources.logo61;
            this.pcbSplash.Location = new System.Drawing.Point(1, 1);
            this.pcbSplash.Name = "pcbSplash";
            this.pcbSplash.Size = new System.Drawing.Size(538, 303);
            this.pcbSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSplash.TabIndex = 0;
            this.pcbSplash.TabStop = false;
            this.pcbSplash.Click += new System.EventHandler(this.pcbSplash_Click);
            // 
            // pgbsplash
            // 
            this.pgbsplash.ForeColor = System.Drawing.Color.Red;
            this.pgbsplash.Location = new System.Drawing.Point(12, 270);
            this.pgbsplash.Name = "pgbsplash";
            this.pgbsplash.Size = new System.Drawing.Size(517, 23);
            this.pgbsplash.TabIndex = 3;
            this.pgbsplash.Click += new System.EventHandler(this.pgbsplash_Click);
            // 
            // FrmSplash2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 306);
            this.Controls.Add(this.pgbsplash);
            this.Controls.Add(this.pcbSplash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSplash2";
            this.Text = "FrmSplash";
            this.Load += new System.EventHandler(this.FrmSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbSplash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbSplash;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar pgbsplash;
    }
}