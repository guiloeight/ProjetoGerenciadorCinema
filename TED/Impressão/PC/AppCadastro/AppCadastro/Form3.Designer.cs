namespace AppCadastro
{
    partial class Form3
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
            this.pcbSplash = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbSplash)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbSplash
            // 
            this.pcbSplash.Image = global::AppCadastro.Properties.Resources.Chaplin;
            this.pcbSplash.Location = new System.Drawing.Point(-15, -10);
            this.pcbSplash.Name = "pcbSplash";
            this.pcbSplash.Size = new System.Drawing.Size(503, 369);
            this.pcbSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSplash.TabIndex = 1;
            this.pcbSplash.TabStop = false;
            this.pcbSplash.Click += new System.EventHandler(this.pcbSplash_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 279);
            this.Controls.Add(this.pcbSplash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbSplash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbSplash;
        private System.Windows.Forms.Timer timer1;
    }
}