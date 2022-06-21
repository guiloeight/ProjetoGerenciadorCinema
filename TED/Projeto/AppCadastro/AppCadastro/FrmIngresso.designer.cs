namespace AppCadastro
{
    partial class FrmIngresso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIngresso));
            this.lblFilme = new System.Windows.Forms.Label();
            this.cbxSessao = new System.Windows.Forms.ComboBox();
            this.lblHorário = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblQuantidadeDeIngressos = new System.Windows.Forms.Label();
            this.txtQuantidadeDeIngressos = new System.Windows.Forms.TextBox();
            this.lblTotalDaCompra = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxFilme = new System.Windows.Forms.ComboBox();
            this.dtmdia = new System.Windows.Forms.DateTimePicker();
            this.txtSala = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.txtMeias = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.total2 = new System.Windows.Forms.Label();
            this.total1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.meia2 = new System.Windows.Forms.Label();
            this.meia1 = new System.Windows.Forms.Label();
            this.int2 = new System.Windows.Forms.Label();
            this.int1 = new System.Windows.Forms.Label();
            this.preco2 = new System.Windows.Forms.Label();
            this.preco1 = new System.Windows.Forms.Label();
            this.sala2 = new System.Windows.Forms.Label();
            this.sala1 = new System.Windows.Forms.Label();
            this.horario2 = new System.Windows.Forms.Label();
            this.horario1 = new System.Windows.Forms.Label();
            this.filme2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.filme1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtEtaria = new System.Windows.Forms.TextBox();
            this.lbletaria = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFilme
            // 
            this.lblFilme.AutoSize = true;
            this.lblFilme.BackColor = System.Drawing.Color.Transparent;
            this.lblFilme.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFilme.Location = new System.Drawing.Point(9, 26);
            this.lblFilme.Name = "lblFilme";
            this.lblFilme.Size = new System.Drawing.Size(34, 13);
            this.lblFilme.TabIndex = 0;
            this.lblFilme.Text = "Filme:";
            // 
            // cbxSessao
            // 
            this.cbxSessao.FormattingEnabled = true;
            this.cbxSessao.Location = new System.Drawing.Point(57, 50);
            this.cbxSessao.Name = "cbxSessao";
            this.cbxSessao.Size = new System.Drawing.Size(287, 21);
            this.cbxSessao.TabIndex = 3;
            this.cbxSessao.SelectedIndexChanged += new System.EventHandler(this.cbxSessao_SelectedIndexChanged);
            this.cbxSessao.TextChanged += new System.EventHandler(this.btnSessao2);
            // 
            // lblHorário
            // 
            this.lblHorário.AutoSize = true;
            this.lblHorário.BackColor = System.Drawing.Color.Transparent;
            this.lblHorário.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblHorário.Location = new System.Drawing.Point(9, 53);
            this.lblHorário.Name = "lblHorário";
            this.lblHorário.Size = new System.Drawing.Size(45, 13);
            this.lblHorário.TabIndex = 2;
            this.lblHorário.Text = "Sessão:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.BackColor = System.Drawing.Color.Transparent;
            this.lblPreco.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPreco.Location = new System.Drawing.Point(9, 113);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(38, 13);
            this.lblPreco.TabIndex = 4;
            this.lblPreco.Text = "Preço:";
            // 
            // txtPreco
            // 
            this.txtPreco.Enabled = false;
            this.txtPreco.Location = new System.Drawing.Point(56, 111);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(89, 20);
            this.txtPreco.TabIndex = 7;
            this.txtPreco.TextChanged += new System.EventHandler(this.txtPreco_TextChanged_1);
            // 
            // lblQuantidadeDeIngressos
            // 
            this.lblQuantidadeDeIngressos.AutoSize = true;
            this.lblQuantidadeDeIngressos.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantidadeDeIngressos.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblQuantidadeDeIngressos.Location = new System.Drawing.Point(151, 113);
            this.lblQuantidadeDeIngressos.Name = "lblQuantidadeDeIngressos";
            this.lblQuantidadeDeIngressos.Size = new System.Drawing.Size(74, 13);
            this.lblQuantidadeDeIngressos.TabIndex = 8;
            this.lblQuantidadeDeIngressos.Text = "Nº de Inteiras:";
            // 
            // txtQuantidadeDeIngressos
            // 
            this.txtQuantidadeDeIngressos.Location = new System.Drawing.Point(231, 110);
            this.txtQuantidadeDeIngressos.Name = "txtQuantidadeDeIngressos";
            this.txtQuantidadeDeIngressos.Size = new System.Drawing.Size(80, 20);
            this.txtQuantidadeDeIngressos.TabIndex = 9;
            this.txtQuantidadeDeIngressos.Validated += new System.EventHandler(this.btnqnt_Click);
            // 
            // lblTotalDaCompra
            // 
            this.lblTotalDaCompra.AutoSize = true;
            this.lblTotalDaCompra.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalDaCompra.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTotalDaCompra.Location = new System.Drawing.Point(12, 195);
            this.lblTotalDaCompra.Name = "lblTotalDaCompra";
            this.lblTotalDaCompra.Size = new System.Drawing.Size(90, 13);
            this.lblTotalDaCompra.TabIndex = 11;
            this.lblTotalDaCompra.Text = "Total Da Compra:";
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(102, 194);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(123, 50);
            this.lblTotal.TabIndex = 12;
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInserir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInserir.Location = new System.Drawing.Point(13, 144);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(132, 37);
            this.btnInserir.TabIndex = 13;
            this.btnInserir.Text = "Inserir Ingresso";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(157, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nº de Meias:";
            // 
            // cbxFilme
            // 
            this.cbxFilme.FormattingEnabled = true;
            this.cbxFilme.Location = new System.Drawing.Point(57, 23);
            this.cbxFilme.Name = "cbxFilme";
            this.cbxFilme.Size = new System.Drawing.Size(221, 21);
            this.cbxFilme.TabIndex = 18;
            this.cbxFilme.SelectedIndexChanged += new System.EventHandler(this.cbxFilme_SelectedIndexChanged);
            this.cbxFilme.Validated += new System.EventHandler(this.btnSessao_Click);
            // 
            // dtmdia
            // 
            this.dtmdia.Location = new System.Drawing.Point(13, 248);
            this.dtmdia.Name = "dtmdia";
            this.dtmdia.Size = new System.Drawing.Size(216, 20);
            this.dtmdia.TabIndex = 19;
            // 
            // txtSala
            // 
            this.txtSala.Enabled = false;
            this.txtSala.Location = new System.Drawing.Point(213, 80);
            this.txtSala.Name = "txtSala";
            this.txtSala.Size = new System.Drawing.Size(80, 20);
            this.txtSala.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(176, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Sala:";
            // 
            // txtHorario
            // 
            this.txtHorario.Enabled = false;
            this.txtHorario.Location = new System.Drawing.Point(57, 77);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(89, 20);
            this.txtHorario.TabIndex = 22;
            this.txtHorario.Text = "--:--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(10, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Horário:";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_EndPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
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
            // txtMeias
            // 
            this.txtMeias.Location = new System.Drawing.Point(231, 144);
            this.txtMeias.Name = "txtMeias";
            this.txtMeias.Size = new System.Drawing.Size(80, 20);
            this.txtMeias.TabIndex = 25;
            this.txtMeias.Validated += new System.EventHandler(this.btnmeia_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.total2);
            this.groupBox1.Controls.Add(this.total1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.meia2);
            this.groupBox1.Controls.Add(this.meia1);
            this.groupBox1.Controls.Add(this.int2);
            this.groupBox1.Controls.Add(this.int1);
            this.groupBox1.Controls.Add(this.preco2);
            this.groupBox1.Controls.Add(this.preco1);
            this.groupBox1.Controls.Add(this.sala2);
            this.groupBox1.Controls.Add(this.sala1);
            this.groupBox1.Controls.Add(this.horario2);
            this.groupBox1.Controls.Add(this.horario1);
            this.groupBox1.Controls.Add(this.filme2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.filme1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(350, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 307);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Itens";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label10.Location = new System.Drawing.Point(362, 116);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 120;
            this.label10.Text = "010";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label11.Location = new System.Drawing.Point(362, 90);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 119;
            this.label11.Text = "010";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label13.Location = new System.Drawing.Point(287, 116);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 118;
            this.label13.Text = "010";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label14.Location = new System.Drawing.Point(287, 90);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label14.Size = new System.Drawing.Size(28, 13);
            this.label14.TabIndex = 117;
            this.label14.Text = "010";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label15.Location = new System.Drawing.Point(242, 116);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label15.Size = new System.Drawing.Size(28, 13);
            this.label15.TabIndex = 116;
            this.label15.Text = "010";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label16.Location = new System.Drawing.Point(242, 90);
            this.label16.Name = "label16";
            this.label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label16.Size = new System.Drawing.Size(28, 13);
            this.label16.TabIndex = 115;
            this.label16.Text = "010";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label17.Location = new System.Drawing.Point(208, 116);
            this.label17.Name = "label17";
            this.label17.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label17.Size = new System.Drawing.Size(28, 13);
            this.label17.TabIndex = 114;
            this.label17.Text = "010";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label18.Location = new System.Drawing.Point(208, 90);
            this.label18.Name = "label18";
            this.label18.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label18.Size = new System.Drawing.Size(28, 13);
            this.label18.TabIndex = 113;
            this.label18.Text = "010";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label19.Location = new System.Drawing.Point(164, 116);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(28, 13);
            this.label19.TabIndex = 112;
            this.label19.Text = "010";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label20.Location = new System.Drawing.Point(164, 90);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(28, 13);
            this.label20.TabIndex = 111;
            this.label20.Text = "010";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label21.Location = new System.Drawing.Point(121, 116);
            this.label21.Name = "label21";
            this.label21.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label21.Size = new System.Drawing.Size(28, 13);
            this.label21.TabIndex = 110;
            this.label21.Text = "010";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label22.Location = new System.Drawing.Point(121, 90);
            this.label22.Name = "label22";
            this.label22.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label22.Size = new System.Drawing.Size(28, 13);
            this.label22.TabIndex = 109;
            this.label22.Text = "010";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label23.Location = new System.Drawing.Point(6, 116);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(28, 13);
            this.label23.TabIndex = 108;
            this.label23.Text = "010";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label24.Location = new System.Drawing.Point(6, 90);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(28, 13);
            this.label24.TabIndex = 107;
            this.label24.Text = "010";
            // 
            // total2
            // 
            this.total2.AutoSize = true;
            this.total2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.total2.Location = new System.Drawing.Point(362, 68);
            this.total2.Name = "total2";
            this.total2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.total2.Size = new System.Drawing.Size(28, 13);
            this.total2.TabIndex = 106;
            this.total2.Text = "010";
            // 
            // total1
            // 
            this.total1.AutoSize = true;
            this.total1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.total1.Location = new System.Drawing.Point(362, 42);
            this.total1.Name = "total1";
            this.total1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.total1.Size = new System.Drawing.Size(28, 13);
            this.total1.TabIndex = 105;
            this.total1.Text = "010";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(359, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 104;
            this.label12.Text = "Total Filme";
            // 
            // meia2
            // 
            this.meia2.AutoSize = true;
            this.meia2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.meia2.Location = new System.Drawing.Point(287, 68);
            this.meia2.Name = "meia2";
            this.meia2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.meia2.Size = new System.Drawing.Size(28, 13);
            this.meia2.TabIndex = 103;
            this.meia2.Text = "010";
            // 
            // meia1
            // 
            this.meia1.AutoSize = true;
            this.meia1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.meia1.Location = new System.Drawing.Point(287, 42);
            this.meia1.Name = "meia1";
            this.meia1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.meia1.Size = new System.Drawing.Size(28, 13);
            this.meia1.TabIndex = 102;
            this.meia1.Text = "010";
            // 
            // int2
            // 
            this.int2.AutoSize = true;
            this.int2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.int2.Location = new System.Drawing.Point(242, 68);
            this.int2.Name = "int2";
            this.int2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.int2.Size = new System.Drawing.Size(28, 13);
            this.int2.TabIndex = 101;
            this.int2.Text = "010";
            // 
            // int1
            // 
            this.int1.AutoSize = true;
            this.int1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.int1.Location = new System.Drawing.Point(242, 42);
            this.int1.Name = "int1";
            this.int1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.int1.Size = new System.Drawing.Size(28, 13);
            this.int1.TabIndex = 100;
            this.int1.Text = "010";
            // 
            // preco2
            // 
            this.preco2.AutoSize = true;
            this.preco2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.preco2.Location = new System.Drawing.Point(208, 68);
            this.preco2.Name = "preco2";
            this.preco2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.preco2.Size = new System.Drawing.Size(28, 13);
            this.preco2.TabIndex = 99;
            this.preco2.Text = "010";
            // 
            // preco1
            // 
            this.preco1.AutoSize = true;
            this.preco1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.preco1.Location = new System.Drawing.Point(208, 42);
            this.preco1.Name = "preco1";
            this.preco1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.preco1.Size = new System.Drawing.Size(28, 13);
            this.preco1.TabIndex = 98;
            this.preco1.Text = "010";
            // 
            // sala2
            // 
            this.sala2.AutoSize = true;
            this.sala2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.sala2.Location = new System.Drawing.Point(164, 68);
            this.sala2.Name = "sala2";
            this.sala2.Size = new System.Drawing.Size(28, 13);
            this.sala2.TabIndex = 97;
            this.sala2.Text = "010";
            // 
            // sala1
            // 
            this.sala1.AutoSize = true;
            this.sala1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.sala1.Location = new System.Drawing.Point(164, 42);
            this.sala1.Name = "sala1";
            this.sala1.Size = new System.Drawing.Size(28, 13);
            this.sala1.TabIndex = 96;
            this.sala1.Text = "010";
            // 
            // horario2
            // 
            this.horario2.AutoSize = true;
            this.horario2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.horario2.Location = new System.Drawing.Point(121, 68);
            this.horario2.Name = "horario2";
            this.horario2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.horario2.Size = new System.Drawing.Size(28, 13);
            this.horario2.TabIndex = 95;
            this.horario2.Text = "010";
            // 
            // horario1
            // 
            this.horario1.AutoSize = true;
            this.horario1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.horario1.Location = new System.Drawing.Point(121, 42);
            this.horario1.Name = "horario1";
            this.horario1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.horario1.Size = new System.Drawing.Size(28, 13);
            this.horario1.TabIndex = 94;
            this.horario1.Text = "010";
            // 
            // filme2
            // 
            this.filme2.AutoSize = true;
            this.filme2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.filme2.Location = new System.Drawing.Point(6, 68);
            this.filme2.Name = "filme2";
            this.filme2.Size = new System.Drawing.Size(28, 13);
            this.filme2.TabIndex = 87;
            this.filme2.Text = "010";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(198, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 93;
            this.label9.Text = "Preço";
            // 
            // filme1
            // 
            this.filme1.AutoSize = true;
            this.filme1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.filme1.Location = new System.Drawing.Point(6, 42);
            this.filme1.Name = "filme1";
            this.filme1.Size = new System.Drawing.Size(28, 13);
            this.filme1.TabIndex = 86;
            this.filme1.Text = "010";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(278, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 92;
            this.label8.Text = "Nº Meia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(238, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 91;
            this.label7.Text = "Nº Int";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(164, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 90;
            this.label4.Text = "Sala";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 89;
            this.label5.Text = "Horário";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 88;
            this.label6.Text = "Filme";
            // 
            // txttotal
            // 
            this.txttotal.AutoSize = true;
            this.txttotal.Location = new System.Drawing.Point(270, 168);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(0, 13);
            this.txttotal.TabIndex = 79;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 41);
            this.button1.TabIndex = 80;
            this.button1.Text = "Imprimir Ingresso";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // txtEtaria
            // 
            this.txtEtaria.Enabled = false;
            this.txtEtaria.Location = new System.Drawing.Point(264, 181);
            this.txtEtaria.Name = "txtEtaria";
            this.txtEtaria.Size = new System.Drawing.Size(80, 20);
            this.txtEtaria.TabIndex = 82;
            this.txtEtaria.TextChanged += new System.EventHandler(this.txtEtaria_TextChanged);
            // 
            // lbletaria
            // 
            this.lbletaria.AutoSize = true;
            this.lbletaria.BackColor = System.Drawing.Color.Transparent;
            this.lbletaria.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbletaria.Location = new System.Drawing.Point(227, 184);
            this.lbletaria.Name = "lbletaria";
            this.lbletaria.Size = new System.Drawing.Size(37, 13);
            this.lbletaria.TabIndex = 81;
            this.lbletaria.Text = "Etária:";
            // 
            // FrmIngresso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppCadastro.Properties.Resources.teste31;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 418);
            this.Controls.Add(this.txtEtaria);
            this.Controls.Add(this.lbletaria);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtMeias);
            this.Controls.Add(this.txtSala);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtmdia);
            this.Controls.Add(this.cbxFilme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTotalDaCompra);
            this.Controls.Add(this.txtQuantidadeDeIngressos);
            this.Controls.Add(this.lblQuantidadeDeIngressos);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.cbxSessao);
            this.Controls.Add(this.lblHorário);
            this.Controls.Add(this.lblFilme);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmIngresso";
            this.Text = "Novo Ingresso";
            this.Load += new System.EventHandler(this.FrmIngresso_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFilme;
        private System.Windows.Forms.ComboBox cbxSessao;
        private System.Windows.Forms.Label lblHorário;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblQuantidadeDeIngressos;
        private System.Windows.Forms.TextBox txtQuantidadeDeIngressos;
        private System.Windows.Forms.Label lblTotalDaCompra;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxFilme;
        private System.Windows.Forms.DateTimePicker dtmdia;
        private System.Windows.Forms.TextBox txtSala;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TextBox txtMeias;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label meia2;
        private System.Windows.Forms.Label meia1;
        private System.Windows.Forms.Label int2;
        private System.Windows.Forms.Label int1;
        private System.Windows.Forms.Label preco2;
        private System.Windows.Forms.Label preco1;
        private System.Windows.Forms.Label sala2;
        private System.Windows.Forms.Label sala1;
        private System.Windows.Forms.Label horario2;
        private System.Windows.Forms.Label horario1;
        private System.Windows.Forms.Label filme2;
        private System.Windows.Forms.Label filme1;
        private System.Windows.Forms.Label total2;
        private System.Windows.Forms.Label total1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label txttotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtEtaria;
        private System.Windows.Forms.Label lbletaria;
    }
}