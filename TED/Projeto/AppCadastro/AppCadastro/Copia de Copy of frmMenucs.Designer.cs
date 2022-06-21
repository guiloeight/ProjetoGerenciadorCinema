namespace AppCadastro
{
    partial class frmMenucs3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenucs3));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.filmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sessõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tooladm1 = new System.Windows.Forms.ToolStrip();
            this.tsbCadastrarCliente = new System.Windows.Forms.ToolStripButton();
            this.tsbLogout = new System.Windows.Forms.ToolStripButton();
            this.tsbSair = new System.Windows.Forms.ToolStripButton();
            this.pcbVenda = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblcadastrosessoes = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblcadastrodeprodutos = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.timerhora = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stbHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslhora = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslData = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblcaixa = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.tooladm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadastrar,
            this.sairToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.backupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1325, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // tsmCadastrar
            // 
            this.tsmCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.tsmCadastrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbUsuario,
            this.tsbCliente,
            this.filmeToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.sessõesToolStripMenuItem,
            this.salasToolStripMenuItem});
            this.tsmCadastrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmCadastrar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsmCadastrar.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsmCadastrar.Name = "tsmCadastrar";
            this.tsmCadastrar.Size = new System.Drawing.Size(77, 21);
            this.tsmCadastrar.Text = "Cadastrar";
            // 
            // tsbUsuario
            // 
            this.tsbUsuario.BackColor = System.Drawing.Color.Transparent;
            this.tsbUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsbUsuario.Image = global::AppCadastro.Properties.Resources.user_add_icon;
            this.tsbUsuario.ImageTransparentColor = System.Drawing.Color.Chocolate;
            this.tsbUsuario.Name = "tsbUsuario";
            this.tsbUsuario.Size = new System.Drawing.Size(129, 22);
            this.tsbUsuario.Text = "Usuário";
            // 
            // tsbCliente
            // 
            this.tsbCliente.BackColor = System.Drawing.Color.Transparent;
            this.tsbCliente.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsbCliente.Image = global::AppCadastro.Properties.Resources.Actions_contact_new_icon;
            this.tsbCliente.ImageTransparentColor = System.Drawing.Color.Chocolate;
            this.tsbCliente.Name = "tsbCliente";
            this.tsbCliente.Size = new System.Drawing.Size(129, 22);
            this.tsbCliente.Text = "Cliente";
            // 
            // filmeToolStripMenuItem
            // 
            this.filmeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.filmeToolStripMenuItem.Name = "filmeToolStripMenuItem";
            this.filmeToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.filmeToolStripMenuItem.Text = "Filme";
            this.filmeToolStripMenuItem.Click += new System.EventHandler(this.filmeToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // sessõesToolStripMenuItem
            // 
            this.sessõesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.sessõesToolStripMenuItem.Name = "sessõesToolStripMenuItem";
            this.sessõesToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.sessõesToolStripMenuItem.Text = "Sessões";
            this.sessõesToolStripMenuItem.Click += new System.EventHandler(this.sessõesToolStripMenuItem_Click);
            // 
            // salasToolStripMenuItem
            // 
            this.salasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.salasToolStripMenuItem.Name = "salasToolStripMenuItem";
            this.salasToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.salasToolStripMenuItem.Text = "Salas";
            this.salasToolStripMenuItem.Click += new System.EventHandler(this.salasToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripMenuItem});
            this.backupToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.backupToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.backupToolStripMenuItem.Text = "Backup";
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.salvarToolStripMenuItem.Image = global::AppCadastro.Properties.Resources._1370306693_download_database;
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // tooladm1
            // 
            this.tooladm1.BackColor = System.Drawing.Color.Transparent;
            this.tooladm1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tooladm1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.tooladm1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCadastrarCliente,
            this.tsbLogout,
            this.tsbSair});
            this.tooladm1.Location = new System.Drawing.Point(0, 25);
            this.tooladm1.Name = "tooladm1";
            this.tooladm1.Size = new System.Drawing.Size(55, 595);
            this.tooladm1.TabIndex = 1;
            this.tooladm1.Text = "toolStrip1";
            // 
            // tsbCadastrarCliente
            // 
            this.tsbCadastrarCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCadastrarCliente.Image = ((System.Drawing.Image)(resources.GetObject("tsbCadastrarCliente.Image")));
            this.tsbCadastrarCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCadastrarCliente.Name = "tsbCadastrarCliente";
            this.tsbCadastrarCliente.Size = new System.Drawing.Size(52, 54);
            this.tsbCadastrarCliente.Text = "Cadastrar Cliente";
            this.tsbCadastrarCliente.Click += new System.EventHandler(this.toolStripButton2_Click);
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
            // pictureBox1
            // 
            this.pictureBox1.AccessibleName = "";
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::AppCadastro.Properties.Resources.cadSala;
            this.pictureBox1.Location = new System.Drawing.Point(1107, 265);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Nova Venda";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(1143, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cadastro de Salas";
            // 
            // pictureBox2
            // 
            this.pictureBox2.AccessibleName = "";
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::AppCadastro.Properties.Resources._1370296829_movie;
            this.pictureBox2.Location = new System.Drawing.Point(112, 255);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(186, 145);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "Nova Venda";
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(144, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cadastro de Filme";
            // 
            // lblcadastrosessoes
            // 
            this.lblcadastrosessoes.AutoSize = true;
            this.lblcadastrosessoes.BackColor = System.Drawing.Color.Transparent;
            this.lblcadastrosessoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcadastrosessoes.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblcadastrosessoes.Location = new System.Drawing.Point(1134, 46);
            this.lblcadastrosessoes.Name = "lblcadastrosessoes";
            this.lblcadastrosessoes.Size = new System.Drawing.Size(139, 16);
            this.lblcadastrosessoes.TabIndex = 15;
            this.lblcadastrosessoes.Text = "Cadastro de Sessões";
            // 
            // pictureBox4
            // 
            this.pictureBox4.AccessibleName = "";
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::AppCadastro.Properties.Resources.sessoes;
            this.pictureBox4.Location = new System.Drawing.Point(1107, 71);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(186, 145);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "Nova Venda";
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // lblcadastrodeprodutos
            // 
            this.lblcadastrodeprodutos.AutoSize = true;
            this.lblcadastrodeprodutos.BackColor = System.Drawing.Color.Transparent;
            this.lblcadastrodeprodutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcadastrodeprodutos.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblcadastrodeprodutos.Location = new System.Drawing.Point(1131, 425);
            this.lblcadastrodeprodutos.Name = "lblcadastrodeprodutos";
            this.lblcadastrodeprodutos.Size = new System.Drawing.Size(139, 16);
            this.lblcadastrodeprodutos.TabIndex = 17;
            this.lblcadastrodeprodutos.Text = "Cadastro de Produtos";
            // 
            // pictureBox5
            // 
            this.pictureBox5.AccessibleName = "";
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::AppCadastro.Properties.Resources._1370296250_cinema;
            this.pictureBox5.Location = new System.Drawing.Point(1107, 450);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(186, 145);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "Nova Venda";
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // timerhora
            // 
            this.timerhora.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
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
            this.tsslhora.Click += new System.EventHandler(this.tsslhora_Click);
            // 
            // tsslData
            // 
            this.tsslData.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsslData.Name = "tsslData";
            this.tsslData.Size = new System.Drawing.Size(34, 17);
            this.tsslData.Text = "Data:";
            this.tsslData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsslData.Click += new System.EventHandler(this.tsslData_Click);
            // 
            // lblcaixa
            // 
            this.lblcaixa.AutoSize = true;
            this.lblcaixa.BackColor = System.Drawing.Color.Transparent;
            this.lblcaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcaixa.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblcaixa.Location = new System.Drawing.Point(177, 411);
            this.lblcaixa.Name = "lblcaixa";
            this.lblcaixa.Size = new System.Drawing.Size(42, 16);
            this.lblcaixa.TabIndex = 23;
            this.lblcaixa.Text = "Caixa";
            this.lblcaixa.Click += new System.EventHandler(this.lblcaixa_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.AccessibleName = "";
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::AppCadastro.Properties.Resources.Cash_register_icon3;
            this.pictureBox7.Location = new System.Drawing.Point(112, 431);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(186, 145);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 22;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "Nova Venda";
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // frmMenucs3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::AppCadastro.Properties.Resources.logo5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1325, 620);
            this.Controls.Add(this.lblcaixa);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblcadastrodeprodutos);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.lblcadastrosessoes);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbVenda);
            this.Controls.Add(this.tooladm1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenucs3";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenucs_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tooladm1.ResumeLayout(false);
            this.tooladm1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tooladm1;
        private System.Windows.Forms.ToolStripButton tsbCadastrarCliente;
        private System.Windows.Forms.ToolStripButton tsbLogout;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbSair;
        private System.Windows.Forms.PictureBox pcbVenda;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastrar;
        private System.Windows.Forms.ToolStripMenuItem tsbUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsbCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblcadastrosessoes;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblcadastrodeprodutos;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.Timer timerhora;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stbHora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        internal System.Windows.Forms.ToolStripStatusLabel tsslhora;
        internal System.Windows.Forms.ToolStripStatusLabel tsslData;
        private System.Windows.Forms.Label lblcaixa;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sessõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salasToolStripMenuItem;
    }
}