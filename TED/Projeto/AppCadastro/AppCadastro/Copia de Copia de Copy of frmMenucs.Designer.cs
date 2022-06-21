namespace AppCadastro
{
    partial class frmMenucs4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenucs4));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tooladm1 = new System.Windows.Forms.ToolStrip();
            this.tsbLogout = new System.Windows.Forms.ToolStripButton();
            this.tsbSair = new System.Windows.Forms.ToolStripButton();
            this.pcbVenda = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timerhora = new System.Windows.Forms.Timer(this.components);
            this.novoIngressoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblcaixa = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stbHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslhora = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslData = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.tooladm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.novoIngressoToolStripMenuItem,
            this.caixaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1325, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(42, 25);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(61, 25);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // tooladm1
            // 
            this.tooladm1.BackColor = System.Drawing.Color.Transparent;
            this.tooladm1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tooladm1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.tooladm1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLogout,
            this.tsbSair});
            this.tooladm1.Location = new System.Drawing.Point(0, 29);
            this.tooladm1.Name = "tooladm1";
            this.tooladm1.Size = new System.Drawing.Size(55, 591);
            this.tooladm1.TabIndex = 1;
            this.tooladm1.Text = "toolStrip1";
            // 
            // tsbLogout
            // 
            this.tsbLogout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLogout.Image = ((System.Drawing.Image)(resources.GetObject("tsbLogout.Image")));
            this.tsbLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLogout.Name = "tsbLogout";
            this.tsbLogout.Size = new System.Drawing.Size(52, 54);
            this.tsbLogout.Text = "Logout";
            this.tsbLogout.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // tsbSair
            // 
            this.tsbSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSair.Image = global::AppCadastro.Properties.Resources._1370307064_Windows_Turn_Off;
            this.tsbSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSair.Name = "tsbSair";
            this.tsbSair.Size = new System.Drawing.Size(52, 54);
            this.tsbSair.Text = "Sair";
            this.tsbSair.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // pcbVenda
            // 
            this.pcbVenda.AccessibleName = "";
            this.pcbVenda.BackColor = System.Drawing.Color.Transparent;
            this.pcbVenda.Image = global::AppCadastro.Properties.Resources._1370296126_create_ticket1;
            this.pcbVenda.Location = new System.Drawing.Point(111, 71);
            this.pcbVenda.Name = "pcbVenda";
            this.pcbVenda.Size = new System.Drawing.Size(186, 145);
            this.pcbVenda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbVenda.TabIndex = 2;
            this.pcbVenda.TabStop = false;
            this.pcbVenda.Tag = "Nova Venda";
            this.pcbVenda.Click += new System.EventHandler(this.pcbVenda_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(155, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Novo Ingresso";
            // 
            // timerhora
            // 
            this.timerhora.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // novoIngressoToolStripMenuItem
            // 
            this.novoIngressoToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.novoIngressoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.novoIngressoToolStripMenuItem.Name = "novoIngressoToolStripMenuItem";
            this.novoIngressoToolStripMenuItem.Size = new System.Drawing.Size(123, 25);
            this.novoIngressoToolStripMenuItem.Text = "Novo Ingresso";
            // 
            // caixaToolStripMenuItem
            // 
            this.caixaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            this.caixaToolStripMenuItem.Size = new System.Drawing.Size(59, 25);
            this.caixaToolStripMenuItem.Text = "Caixa";
            // 
            // lblcaixa
            // 
            this.lblcaixa.AutoSize = true;
            this.lblcaixa.BackColor = System.Drawing.Color.Transparent;
            this.lblcaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcaixa.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblcaixa.Location = new System.Drawing.Point(387, 51);
            this.lblcaixa.Name = "lblcaixa";
            this.lblcaixa.Size = new System.Drawing.Size(42, 16);
            this.lblcaixa.TabIndex = 25;
            this.lblcaixa.Text = "Caixa";
            this.lblcaixa.Click += new System.EventHandler(this.lblcaixa_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.AccessibleName = "";
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::AppCadastro.Properties.Resources.Cash_register_icon3;
            this.pictureBox7.Location = new System.Drawing.Point(322, 71);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(186, 145);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 24;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "Nova Venda";
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stbHora,
            this.toolStripStatusLabel1,
            this.tsslhora,
            this.tsslData});
            this.statusStrip1.Location = new System.Drawing.Point(55, 598);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1270, 22);
            this.statusStrip1.TabIndex = 26;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stbHora
            // 
            this.stbHora.Name = "stbHora";
            this.stbHora.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // tsslhora
            // 
            this.tsslhora.AutoSize = false;
            this.tsslhora.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsslhora.Name = "tsslhora";
            this.tsslhora.Size = new System.Drawing.Size(100, 17);
            this.tsslhora.Text = "Hora:";
            this.tsslhora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsslhora.Click += new System.EventHandler(this.tsslhora_Click_1);
            // 
            // tsslData
            // 
            this.tsslData.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsslData.Name = "tsslData";
            this.tsslData.Size = new System.Drawing.Size(34, 17);
            this.tsslData.Text = "Data:";
            this.tsslData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsslData.Click += new System.EventHandler(this.tsslData_Click_1);
            // 
            // frmMenucs4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::AppCadastro.Properties.Resources.logo5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1325, 620);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblcaixa);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbVenda);
            this.Controls.Add(this.tooladm1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenucs4";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenucs_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tooladm1.ResumeLayout(false);
            this.tooladm1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tooladm1;
        private System.Windows.Forms.ToolStripButton tsbLogout;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbSair;
        private System.Windows.Forms.PictureBox pcbVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerhora;
        private System.Windows.Forms.ToolStripMenuItem novoIngressoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caixaToolStripMenuItem;
        private System.Windows.Forms.Label lblcaixa;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stbHora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        internal System.Windows.Forms.ToolStripStatusLabel tsslhora;
        internal System.Windows.Forms.ToolStripStatusLabel tsslData;
    }
}