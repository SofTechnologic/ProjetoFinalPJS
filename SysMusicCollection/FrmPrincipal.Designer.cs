namespace SysMusicCollection
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("DVD", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("CD", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("VHS", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Vinil", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("K7", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Digital", System.Windows.Forms.HorizontalAlignment.Left);
            this.mnsPrincipal = new System.Windows.Forms.MenuStrip();
            this.msiArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.msiRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.msiSair = new System.Windows.Forms.ToolStripMenuItem();
            this.stsPrincipal = new System.Windows.Forms.StatusStrip();
            this.spcPrincipal = new System.Windows.Forms.SplitContainer();
            this.btnAbaLateral = new System.Windows.Forms.Button();
            this.pbxImgLateral = new System.Windows.Forms.PictureBox();
            this.btnEmprDev = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.txbPesquisa = new System.Windows.Forms.TextBox();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.spcHorizontal = new System.Windows.Forms.SplitContainer();
            this.btnAbaFiltro = new System.Windows.Forms.Button();
            this.dtpDataCompra2 = new System.Windows.Forms.DateTimePicker();
            this.lbla2 = new System.Windows.Forms.Label();
            this.dtpDataCompra1 = new System.Windows.Forms.DateTimePicker();
            this.ckbDataCompra = new System.Windows.Forms.CheckBox();
            this.dtpDataAlbum2 = new System.Windows.Forms.DateTimePicker();
            this.lbla1 = new System.Windows.Forms.Label();
            this.dtpDataAlbum1 = new System.Windows.Forms.DateTimePicker();
            this.txbOrigem1 = new System.Windows.Forms.TextBox();
            this.txbAutor1 = new System.Windows.Forms.TextBox();
            this.cbxTipoMidia1 = new System.Windows.Forms.ComboBox();
            this.txbIterprete1 = new System.Windows.Forms.TextBox();
            this.ckbDataAlbMus = new System.Windows.Forms.CheckBox();
            this.ckbOrigemCompra = new System.Windows.Forms.CheckBox();
            this.ckbAutor = new System.Windows.Forms.CheckBox();
            this.ckbInterprete = new System.Windows.Forms.CheckBox();
            this.ckbTipoMidia = new System.Windows.Forms.CheckBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lsvPrincipal = new System.Windows.Forms.ListView();
            this.cmsPrincipal = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.eprError = new System.Windows.Forms.ErrorProvider(this.components);
            this.mnsPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcPrincipal)).BeginInit();
            this.spcPrincipal.Panel1.SuspendLayout();
            this.spcPrincipal.Panel2.SuspendLayout();
            this.spcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgLateral)).BeginInit();
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcHorizontal)).BeginInit();
            this.spcHorizontal.Panel1.SuspendLayout();
            this.spcHorizontal.Panel2.SuspendLayout();
            this.spcHorizontal.SuspendLayout();
            this.cmsPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eprError)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsPrincipal
            // 
            this.mnsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiArquivo});
            this.mnsPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnsPrincipal.Name = "mnsPrincipal";
            this.mnsPrincipal.Size = new System.Drawing.Size(934, 24);
            this.mnsPrincipal.TabIndex = 0;
            this.mnsPrincipal.Text = "menuStrip1";
            // 
            // msiArquivo
            // 
            this.msiArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiRelatorios,
            this.msiSair});
            this.msiArquivo.Name = "msiArquivo";
            this.msiArquivo.Size = new System.Drawing.Size(61, 20);
            this.msiArquivo.Text = "Arquivo";
            // 
            // msiRelatorios
            // 
            this.msiRelatorios.Image = ((System.Drawing.Image)(resources.GetObject("msiRelatorios.Image")));
            this.msiRelatorios.Name = "msiRelatorios";
            this.msiRelatorios.Size = new System.Drawing.Size(126, 22);
            this.msiRelatorios.Text = "Relatórios";
            this.msiRelatorios.Click += new System.EventHandler(this.relatóriosToolStripMenuItem_Click);
            // 
            // msiSair
            // 
            this.msiSair.Image = ((System.Drawing.Image)(resources.GetObject("msiSair.Image")));
            this.msiSair.Name = "msiSair";
            this.msiSair.Size = new System.Drawing.Size(126, 22);
            this.msiSair.Text = "Sair";
            this.msiSair.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // stsPrincipal
            // 
            this.stsPrincipal.Location = new System.Drawing.Point(0, 540);
            this.stsPrincipal.Name = "stsPrincipal";
            this.stsPrincipal.Size = new System.Drawing.Size(934, 22);
            this.stsPrincipal.TabIndex = 1;
            this.stsPrincipal.Text = "statusStrip1";
            // 
            // spcPrincipal
            // 
            this.spcPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.spcPrincipal.Location = new System.Drawing.Point(0, 24);
            this.spcPrincipal.Name = "spcPrincipal";
            // 
            // spcPrincipal.Panel1
            // 
            this.spcPrincipal.Panel1.Controls.Add(this.btnAbaLateral);
            this.spcPrincipal.Panel1.Controls.Add(this.pbxImgLateral);
            this.spcPrincipal.Panel1.Controls.Add(this.btnEmprDev);
            this.spcPrincipal.Panel1.Controls.Add(this.btnCadastro);
            // 
            // spcPrincipal.Panel2
            // 
            this.spcPrincipal.Panel2.Controls.Add(this.txbPesquisa);
            this.spcPrincipal.Panel2.Controls.Add(this.pnlPrincipal);
            this.spcPrincipal.Size = new System.Drawing.Size(934, 516);
            this.spcPrincipal.SplitterDistance = 25;
            this.spcPrincipal.TabIndex = 2;
            // 
            // btnAbaLateral
            // 
            this.btnAbaLateral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbaLateral.Location = new System.Drawing.Point(1, 2);
            this.btnAbaLateral.Name = "btnAbaLateral";
            this.btnAbaLateral.Size = new System.Drawing.Size(25, 513);
            this.btnAbaLateral.TabIndex = 2;
            this.btnAbaLateral.Text = "Funções";
            this.btnAbaLateral.UseVisualStyleBackColor = true;
            this.btnAbaLateral.Click += new System.EventHandler(this.btnAbaLateral_Click);
            // 
            // pbxImgLateral
            // 
            this.pbxImgLateral.Location = new System.Drawing.Point(12, 139);
            this.pbxImgLateral.Name = "pbxImgLateral";
            this.pbxImgLateral.Size = new System.Drawing.Size(120, 265);
            this.pbxImgLateral.TabIndex = 3;
            this.pbxImgLateral.TabStop = false;
            // 
            // btnEmprDev
            // 
            this.btnEmprDev.Location = new System.Drawing.Point(12, 89);
            this.btnEmprDev.Name = "btnEmprDev";
            this.btnEmprDev.Size = new System.Drawing.Size(120, 40);
            this.btnEmprDev.TabIndex = 1;
            this.btnEmprDev.Text = "Emprestar / Devolver";
            this.btnEmprDev.UseVisualStyleBackColor = true;
            this.btnEmprDev.Visible = false;
            this.btnEmprDev.Click += new System.EventHandler(this.btnEmprDev_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(12, 43);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(120, 40);
            this.btnCadastro.TabIndex = 0;
            this.btnCadastro.Tag = "";
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Visible = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // txbPesquisa
            // 
            this.txbPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPesquisa.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txbPesquisa.Location = new System.Drawing.Point(639, 14);
            this.txbPesquisa.Name = "txbPesquisa";
            this.txbPesquisa.Size = new System.Drawing.Size(260, 20);
            this.txbPesquisa.TabIndex = 1;
            this.txbPesquisa.Text = "Pesquisar";
            this.txbPesquisa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txbPesquisa_MouseClick);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPrincipal.Controls.Add(this.spcHorizontal);
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 40);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(902, 476);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // spcHorizontal
            // 
            this.spcHorizontal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcHorizontal.Location = new System.Drawing.Point(0, 0);
            this.spcHorizontal.Name = "spcHorizontal";
            this.spcHorizontal.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcHorizontal.Panel1
            // 
            this.spcHorizontal.Panel1.Controls.Add(this.btnAbaFiltro);
            this.spcHorizontal.Panel1.Controls.Add(this.dtpDataCompra2);
            this.spcHorizontal.Panel1.Controls.Add(this.lbla2);
            this.spcHorizontal.Panel1.Controls.Add(this.dtpDataCompra1);
            this.spcHorizontal.Panel1.Controls.Add(this.ckbDataCompra);
            this.spcHorizontal.Panel1.Controls.Add(this.dtpDataAlbum2);
            this.spcHorizontal.Panel1.Controls.Add(this.lbla1);
            this.spcHorizontal.Panel1.Controls.Add(this.dtpDataAlbum1);
            this.spcHorizontal.Panel1.Controls.Add(this.txbOrigem1);
            this.spcHorizontal.Panel1.Controls.Add(this.txbAutor1);
            this.spcHorizontal.Panel1.Controls.Add(this.cbxTipoMidia1);
            this.spcHorizontal.Panel1.Controls.Add(this.txbIterprete1);
            this.spcHorizontal.Panel1.Controls.Add(this.ckbDataAlbMus);
            this.spcHorizontal.Panel1.Controls.Add(this.ckbOrigemCompra);
            this.spcHorizontal.Panel1.Controls.Add(this.ckbAutor);
            this.spcHorizontal.Panel1.Controls.Add(this.ckbInterprete);
            this.spcHorizontal.Panel1.Controls.Add(this.ckbTipoMidia);
            this.spcHorizontal.Panel1.Controls.Add(this.btnFiltrar);
            // 
            // spcHorizontal.Panel2
            // 
            this.spcHorizontal.Panel2.Controls.Add(this.lsvPrincipal);
            this.spcHorizontal.Size = new System.Drawing.Size(902, 476);
            this.spcHorizontal.SplitterDistance = 25;
            this.spcHorizontal.TabIndex = 0;
            // 
            // btnAbaFiltro
            // 
            this.btnAbaFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbaFiltro.Location = new System.Drawing.Point(0, 0);
            this.btnAbaFiltro.Name = "btnAbaFiltro";
            this.btnAbaFiltro.Size = new System.Drawing.Size(902, 22);
            this.btnAbaFiltro.TabIndex = 3;
            this.btnAbaFiltro.Text = "Filtro";
            this.btnAbaFiltro.UseVisualStyleBackColor = true;
            this.btnAbaFiltro.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpDataCompra2
            // 
            this.dtpDataCompra2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpDataCompra2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCompra2.Location = new System.Drawing.Point(556, 99);
            this.dtpDataCompra2.Name = "dtpDataCompra2";
            this.dtpDataCompra2.Size = new System.Drawing.Size(126, 20);
            this.dtpDataCompra2.TabIndex = 17;
            this.dtpDataCompra2.Value = new System.DateTime(2012, 12, 14, 0, 0, 0, 0);
            this.dtpDataCompra2.Visible = false;
            // 
            // lbla2
            // 
            this.lbla2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbla2.AutoSize = true;
            this.lbla2.Location = new System.Drawing.Point(537, 104);
            this.lbla2.Name = "lbla2";
            this.lbla2.Size = new System.Drawing.Size(13, 13);
            this.lbla2.TabIndex = 16;
            this.lbla2.Text = "à";
            this.lbla2.Visible = false;
            // 
            // dtpDataCompra1
            // 
            this.dtpDataCompra1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpDataCompra1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCompra1.Location = new System.Drawing.Point(405, 98);
            this.dtpDataCompra1.Name = "dtpDataCompra1";
            this.dtpDataCompra1.Size = new System.Drawing.Size(126, 20);
            this.dtpDataCompra1.TabIndex = 15;
            this.dtpDataCompra1.Value = new System.DateTime(2012, 12, 14, 0, 0, 0, 0);
            this.dtpDataCompra1.Visible = false;
            // 
            // ckbDataCompra
            // 
            this.ckbDataCompra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ckbDataCompra.AutoSize = true;
            this.ckbDataCompra.Location = new System.Drawing.Point(405, 79);
            this.ckbDataCompra.Name = "ckbDataCompra";
            this.ckbDataCompra.Size = new System.Drawing.Size(103, 17);
            this.ckbDataCompra.TabIndex = 14;
            this.ckbDataCompra.Text = "Data de Compra";
            this.ckbDataCompra.UseVisualStyleBackColor = true;
            this.ckbDataCompra.Visible = false;
            this.ckbDataCompra.CheckedChanged += new System.EventHandler(this.ckbDataCompra_CheckedChanged);
            // 
            // dtpDataAlbum2
            // 
            this.dtpDataAlbum2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpDataAlbum2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataAlbum2.Location = new System.Drawing.Point(271, 97);
            this.dtpDataAlbum2.Name = "dtpDataAlbum2";
            this.dtpDataAlbum2.Size = new System.Drawing.Size(126, 20);
            this.dtpDataAlbum2.TabIndex = 13;
            this.dtpDataAlbum2.Visible = false;
            // 
            // lbla1
            // 
            this.lbla1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbla1.AutoSize = true;
            this.lbla1.Location = new System.Drawing.Point(250, 103);
            this.lbla1.Name = "lbla1";
            this.lbla1.Size = new System.Drawing.Size(13, 13);
            this.lbla1.TabIndex = 12;
            this.lbla1.Text = "à";
            this.lbla1.Visible = false;
            // 
            // dtpDataAlbum1
            // 
            this.dtpDataAlbum1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpDataAlbum1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataAlbum1.Location = new System.Drawing.Point(113, 96);
            this.dtpDataAlbum1.Name = "dtpDataAlbum1";
            this.dtpDataAlbum1.Size = new System.Drawing.Size(126, 20);
            this.dtpDataAlbum1.TabIndex = 11;
            this.dtpDataAlbum1.Value = new System.DateTime(2012, 12, 14, 0, 0, 0, 0);
            this.dtpDataAlbum1.Visible = false;
            // 
            // txbOrigem1
            // 
            this.txbOrigem1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbOrigem1.Location = new System.Drawing.Point(619, 53);
            this.txbOrigem1.Name = "txbOrigem1";
            this.txbOrigem1.Size = new System.Drawing.Size(180, 20);
            this.txbOrigem1.TabIndex = 10;
            this.txbOrigem1.Visible = false;
            // 
            // txbAutor1
            // 
            this.txbAutor1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbAutor1.Location = new System.Drawing.Point(433, 53);
            this.txbAutor1.Name = "txbAutor1";
            this.txbAutor1.Size = new System.Drawing.Size(180, 20);
            this.txbAutor1.TabIndex = 9;
            this.txbAutor1.Visible = false;
            // 
            // cbxTipoMidia1
            // 
            this.cbxTipoMidia1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxTipoMidia1.FormattingEnabled = true;
            this.cbxTipoMidia1.Location = new System.Drawing.Point(113, 52);
            this.cbxTipoMidia1.Name = "cbxTipoMidia1";
            this.cbxTipoMidia1.Size = new System.Drawing.Size(126, 21);
            this.cbxTipoMidia1.TabIndex = 8;
            this.cbxTipoMidia1.Visible = false;
            // 
            // txbIterprete1
            // 
            this.txbIterprete1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbIterprete1.Location = new System.Drawing.Point(247, 53);
            this.txbIterprete1.Name = "txbIterprete1";
            this.txbIterprete1.Size = new System.Drawing.Size(180, 20);
            this.txbIterprete1.TabIndex = 7;
            this.txbIterprete1.Visible = false;
            // 
            // ckbDataAlbMus
            // 
            this.ckbDataAlbMus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ckbDataAlbMus.AutoSize = true;
            this.ckbDataAlbMus.Location = new System.Drawing.Point(113, 79);
            this.ckbDataAlbMus.Name = "ckbDataAlbMus";
            this.ckbDataAlbMus.Size = new System.Drawing.Size(96, 17);
            this.ckbDataAlbMus.TabIndex = 6;
            this.ckbDataAlbMus.Text = "Data do Álbum";
            this.ckbDataAlbMus.UseVisualStyleBackColor = true;
            this.ckbDataAlbMus.Visible = false;
            this.ckbDataAlbMus.CheckedChanged += new System.EventHandler(this.ckbDataAlbMus_CheckedChanged);
            // 
            // ckbOrigemCompra
            // 
            this.ckbOrigemCompra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ckbOrigemCompra.AutoSize = true;
            this.ckbOrigemCompra.Location = new System.Drawing.Point(619, 30);
            this.ckbOrigemCompra.Name = "ckbOrigemCompra";
            this.ckbOrigemCompra.Size = new System.Drawing.Size(113, 17);
            this.ckbOrigemCompra.TabIndex = 5;
            this.ckbOrigemCompra.Text = "Origem da Compra";
            this.ckbOrigemCompra.UseVisualStyleBackColor = true;
            this.ckbOrigemCompra.Visible = false;
            this.ckbOrigemCompra.CheckedChanged += new System.EventHandler(this.ckbOrigemCompra_CheckedChanged);
            // 
            // ckbAutor
            // 
            this.ckbAutor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ckbAutor.AutoSize = true;
            this.ckbAutor.Location = new System.Drawing.Point(433, 30);
            this.ckbAutor.Name = "ckbAutor";
            this.ckbAutor.Size = new System.Drawing.Size(51, 17);
            this.ckbAutor.TabIndex = 4;
            this.ckbAutor.Text = "Autor";
            this.ckbAutor.UseVisualStyleBackColor = true;
            this.ckbAutor.Visible = false;
            this.ckbAutor.CheckedChanged += new System.EventHandler(this.ckbAutor_CheckedChanged);
            // 
            // ckbInterprete
            // 
            this.ckbInterprete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ckbInterprete.AutoSize = true;
            this.ckbInterprete.Location = new System.Drawing.Point(247, 30);
            this.ckbInterprete.Name = "ckbInterprete";
            this.ckbInterprete.Size = new System.Drawing.Size(71, 17);
            this.ckbInterprete.TabIndex = 3;
            this.ckbInterprete.Text = "Intérprete";
            this.ckbInterprete.UseVisualStyleBackColor = true;
            this.ckbInterprete.Visible = false;
            this.ckbInterprete.CheckedChanged += new System.EventHandler(this.ckbInterprete_CheckedChanged);
            // 
            // ckbTipoMidia
            // 
            this.ckbTipoMidia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ckbTipoMidia.AutoSize = true;
            this.ckbTipoMidia.Location = new System.Drawing.Point(113, 30);
            this.ckbTipoMidia.Name = "ckbTipoMidia";
            this.ckbTipoMidia.Size = new System.Drawing.Size(92, 17);
            this.ckbTipoMidia.TabIndex = 2;
            this.ckbTipoMidia.Text = "Tipo de Mídia";
            this.ckbTipoMidia.UseVisualStyleBackColor = true;
            this.ckbTipoMidia.Visible = false;
            this.ckbTipoMidia.CheckedChanged += new System.EventHandler(this.ckbTipoMidia_CheckedChanged);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFiltrar.Location = new System.Drawing.Point(688, 97);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(111, 23);
            this.btnFiltrar.TabIndex = 1;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Visible = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // lsvPrincipal
            // 
            this.lsvPrincipal.ContextMenuStrip = this.cmsPrincipal;
            this.lsvPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewGroup1.Header = "DVD";
            listViewGroup1.Name = "DVD";
            listViewGroup2.Header = "CD";
            listViewGroup2.Name = "CD";
            listViewGroup3.Header = "VHS";
            listViewGroup3.Name = "VHS";
            listViewGroup4.Header = "Vinil";
            listViewGroup4.Name = "Vinil";
            listViewGroup5.Header = "K7";
            listViewGroup5.Name = "K7";
            listViewGroup6.Header = "Digital";
            listViewGroup6.Name = "Digital";
            this.lsvPrincipal.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5,
            listViewGroup6});
            this.lsvPrincipal.Location = new System.Drawing.Point(0, 0);
            this.lsvPrincipal.Name = "lsvPrincipal";
            this.lsvPrincipal.Size = new System.Drawing.Size(902, 447);
            this.lsvPrincipal.TabIndex = 0;
            this.lsvPrincipal.UseCompatibleStateImageBehavior = false;
            this.lsvPrincipal.SelectedIndexChanged += new System.EventHandler(this.lsvPrincipal_SelectedIndexChanged);
            this.lsvPrincipal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lsvPrincipal_KeyDown);
            // 
            // cmsPrincipal
            // 
            this.cmsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmiExcluir,
            this.cmiEditar});
            this.cmsPrincipal.Name = "contextMenuStrip1";
            this.cmsPrincipal.Size = new System.Drawing.Size(109, 48);
            // 
            // cmiExcluir
            // 
            this.cmiExcluir.Image = ((System.Drawing.Image)(resources.GetObject("cmiExcluir.Image")));
            this.cmiExcluir.Name = "cmiExcluir";
            this.cmiExcluir.Size = new System.Drawing.Size(108, 22);
            this.cmiExcluir.Text = "Excluir";
            this.cmiExcluir.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click_1);
            // 
            // cmiEditar
            // 
            this.cmiEditar.Image = ((System.Drawing.Image)(resources.GetObject("cmiEditar.Image")));
            this.cmiEditar.Name = "cmiEditar";
            this.cmiEditar.Size = new System.Drawing.Size(108, 22);
            this.cmiEditar.Text = "Editar";
            this.cmiEditar.Click += new System.EventHandler(this.ediarToolStripMenuItem_Click);
            // 
            // eprError
            // 
            this.eprError.ContainerControl = this;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(934, 562);
            this.Controls.Add(this.spcPrincipal);
            this.Controls.Add(this.stsPrincipal);
            this.Controls.Add(this.mnsPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnsPrincipal;
            this.MinimumSize = new System.Drawing.Size(950, 599);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sys Music Collection";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.Resize += new System.EventHandler(this.frmPrincipal_Resize);
            this.mnsPrincipal.ResumeLayout(false);
            this.mnsPrincipal.PerformLayout();
            this.spcPrincipal.Panel1.ResumeLayout(false);
            this.spcPrincipal.Panel2.ResumeLayout(false);
            this.spcPrincipal.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcPrincipal)).EndInit();
            this.spcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgLateral)).EndInit();
            this.pnlPrincipal.ResumeLayout(false);
            this.spcHorizontal.Panel1.ResumeLayout(false);
            this.spcHorizontal.Panel1.PerformLayout();
            this.spcHorizontal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcHorizontal)).EndInit();
            this.spcHorizontal.ResumeLayout(false);
            this.cmsPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eprError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsPrincipal;
        private System.Windows.Forms.StatusStrip stsPrincipal;
        private System.Windows.Forms.SplitContainer spcPrincipal;
        private System.Windows.Forms.Button btnEmprDev;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.ToolTip tltPrincipal;
        private System.Windows.Forms.TextBox txbPesquisa;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.ToolStripMenuItem msiArquivo;
        private System.Windows.Forms.SplitContainer spcHorizontal;
        private System.Windows.Forms.Button btnAbaFiltro;
        private System.Windows.Forms.ListView lsvPrincipal;
        private System.Windows.Forms.ToolStripMenuItem msiRelatorios;
        private System.Windows.Forms.Button btnAbaLateral;
        private System.Windows.Forms.ContextMenuStrip cmsPrincipal;
        private System.Windows.Forms.ToolStripMenuItem cmiExcluir;
        private System.Windows.Forms.ToolStripMenuItem cmiEditar;
        private System.Windows.Forms.ToolStripMenuItem msiSair;
        private System.Windows.Forms.DateTimePicker dtpDataCompra2;
        private System.Windows.Forms.Label lbla2;
        private System.Windows.Forms.DateTimePicker dtpDataCompra1;
        private System.Windows.Forms.CheckBox ckbDataCompra;
        private System.Windows.Forms.DateTimePicker dtpDataAlbum2;
        private System.Windows.Forms.Label lbla1;
        private System.Windows.Forms.DateTimePicker dtpDataAlbum1;
        private System.Windows.Forms.TextBox txbOrigem1;
        private System.Windows.Forms.TextBox txbAutor1;
        private System.Windows.Forms.ComboBox cbxTipoMidia1;
        private System.Windows.Forms.TextBox txbIterprete1;
        private System.Windows.Forms.CheckBox ckbDataAlbMus;
        private System.Windows.Forms.CheckBox ckbOrigemCompra;
        private System.Windows.Forms.CheckBox ckbAutor;
        private System.Windows.Forms.CheckBox ckbInterprete;
        private System.Windows.Forms.CheckBox ckbTipoMidia;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.PictureBox pbxImgLateral;
        private System.Windows.Forms.ErrorProvider eprError;


    }
}

