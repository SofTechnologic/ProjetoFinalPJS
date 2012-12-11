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
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("DVD", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("CD", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup9 = new System.Windows.Forms.ListViewGroup("VHS", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup10 = new System.Windows.Forms.ListViewGroup("Vinil", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup11 = new System.Windows.Forms.ListViewGroup("K7", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup12 = new System.Windows.Forms.ListViewGroup("Digital", System.Windows.Forms.HorizontalAlignment.Left);
            this.mnsPrincipal = new System.Windows.Forms.MenuStrip();
            this.msiArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.msiRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.stsPrincipal = new System.Windows.Forms.StatusStrip();
            this.spcPrincipal = new System.Windows.Forms.SplitContainer();
            this.btnAbaLateral = new System.Windows.Forms.Button();
            this.btnEmprDev = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.txbPesquisa = new System.Windows.Forms.TextBox();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.spcHorizontal = new System.Windows.Forms.SplitContainer();
            this.btnAbaFiltro = new System.Windows.Forms.Button();
            this.lsvPrincipal = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcPrincipal)).BeginInit();
            this.spcPrincipal.Panel1.SuspendLayout();
            this.spcPrincipal.Panel2.SuspendLayout();
            this.spcPrincipal.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcHorizontal)).BeginInit();
            this.spcHorizontal.Panel1.SuspendLayout();
            this.spcHorizontal.Panel2.SuspendLayout();
            this.spcHorizontal.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsPrincipal
            // 
            this.mnsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiArquivo});
            this.mnsPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnsPrincipal.Name = "mnsPrincipal";
            this.mnsPrincipal.Size = new System.Drawing.Size(734, 24);
            this.mnsPrincipal.TabIndex = 0;
            this.mnsPrincipal.Text = "menuStrip1";
            // 
            // msiArquivo
            // 
            this.msiArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiRelatorios,
            this.sairToolStripMenuItem});
            this.msiArquivo.Name = "msiArquivo";
            this.msiArquivo.Size = new System.Drawing.Size(61, 20);
            this.msiArquivo.Text = "Arquivo";
            // 
            // msiRelatorios
            // 
            this.msiRelatorios.Name = "msiRelatorios";
            this.msiRelatorios.Size = new System.Drawing.Size(152, 22);
            this.msiRelatorios.Text = "Relatórios";
            this.msiRelatorios.Click += new System.EventHandler(this.relatóriosToolStripMenuItem_Click);
            // 
            // stsPrincipal
            // 
            this.stsPrincipal.Location = new System.Drawing.Point(0, 440);
            this.stsPrincipal.Name = "stsPrincipal";
            this.stsPrincipal.Size = new System.Drawing.Size(734, 22);
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
            this.spcPrincipal.Panel1.Controls.Add(this.btnEmprDev);
            this.spcPrincipal.Panel1.Controls.Add(this.btnCadastro);
            // 
            // spcPrincipal.Panel2
            // 
            this.spcPrincipal.Panel2.Controls.Add(this.txbPesquisa);
            this.spcPrincipal.Panel2.Controls.Add(this.pnlPrincipal);
            this.spcPrincipal.Size = new System.Drawing.Size(734, 416);
            this.spcPrincipal.SplitterDistance = 25;
            this.spcPrincipal.TabIndex = 2;
            // 
            // btnAbaLateral
            // 
            this.btnAbaLateral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbaLateral.Location = new System.Drawing.Point(1, 3);
            this.btnAbaLateral.Name = "btnAbaLateral";
            this.btnAbaLateral.Size = new System.Drawing.Size(25, 413);
            this.btnAbaLateral.TabIndex = 2;
            this.btnAbaLateral.Text = "Funções";
            this.btnAbaLateral.UseVisualStyleBackColor = true;
            this.btnAbaLateral.Click += new System.EventHandler(this.btnAbaLateral_Click);
            // 
            // btnEmprDev
            // 
            this.btnEmprDev.Location = new System.Drawing.Point(12, 89);
            this.btnEmprDev.Name = "btnEmprDev";
            this.btnEmprDev.Size = new System.Drawing.Size(120, 40);
            this.btnEmprDev.TabIndex = 1;
            this.btnEmprDev.Text = "Emprestar / Devolver";
            this.btnEmprDev.UseVisualStyleBackColor = true;
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
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // txbPesquisa
            // 
            this.txbPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPesquisa.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txbPesquisa.Location = new System.Drawing.Point(474, 14);
            this.txbPesquisa.Name = "txbPesquisa";
            this.txbPesquisa.Size = new System.Drawing.Size(215, 20);
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
            this.pnlPrincipal.Size = new System.Drawing.Size(702, 376);
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
            // 
            // spcHorizontal.Panel2
            // 
            this.spcHorizontal.Panel2.Controls.Add(this.lsvPrincipal);
            this.spcHorizontal.Size = new System.Drawing.Size(702, 376);
            this.spcHorizontal.SplitterDistance = 25;
            this.spcHorizontal.TabIndex = 0;
            // 
            // btnAbaFiltro
            // 
            this.btnAbaFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbaFiltro.Location = new System.Drawing.Point(0, 8);
            this.btnAbaFiltro.Name = "btnAbaFiltro";
            this.btnAbaFiltro.Size = new System.Drawing.Size(702, 14);
            this.btnAbaFiltro.TabIndex = 0;
            this.btnAbaFiltro.Text = "^";
            this.btnAbaFiltro.UseVisualStyleBackColor = true;
            this.btnAbaFiltro.Click += new System.EventHandler(this.button1_Click);
            // 
            // lsvPrincipal
            // 
            this.lsvPrincipal.ContextMenuStrip = this.contextMenuStrip1;
            this.lsvPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewGroup7.Header = "DVD";
            listViewGroup7.Name = "DVD";
            listViewGroup8.Header = "CD";
            listViewGroup8.Name = "CD";
            listViewGroup9.Header = "VHS";
            listViewGroup9.Name = "VHS";
            listViewGroup10.Header = "Vinil";
            listViewGroup10.Name = "Vinil";
            listViewGroup11.Header = "K7";
            listViewGroup11.Name = "K7";
            listViewGroup12.Header = "Digital";
            listViewGroup12.Name = "Digital";
            this.lsvPrincipal.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup7,
            listViewGroup8,
            listViewGroup9,
            listViewGroup10,
            listViewGroup11,
            listViewGroup12});
            this.lsvPrincipal.Location = new System.Drawing.Point(0, 0);
            this.lsvPrincipal.Name = "lsvPrincipal";
            this.lsvPrincipal.Size = new System.Drawing.Size(702, 347);
            this.lsvPrincipal.TabIndex = 0;
            this.lsvPrincipal.UseCompatibleStateImageBehavior = false;
            this.lsvPrincipal.SelectedIndexChanged += new System.EventHandler(this.lsvPrincipal_SelectedIndexChanged);
            this.lsvPrincipal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lsvPrincipal_KeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excluirToolStripMenuItem,
            this.editarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 48);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click_1);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.ediarToolStripMenuItem_Click);
            // 
            // cmiEditar
            // 
            this.cmiEditar.Name = "cmiEditar";
            this.cmiEditar.Size = new System.Drawing.Size(108, 22);
            this.cmiEditar.Text = "Editar";
            this.cmiEditar.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // cmiExcluir
            // 
            this.cmiExcluir.Name = "cmiExcluir";
            this.cmiExcluir.Size = new System.Drawing.Size(108, 22);
            this.cmiExcluir.Text = "Excluir";
            this.cmiExcluir.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.spcPrincipal);
            this.Controls.Add(this.stsPrincipal);
            this.Controls.Add(this.mnsPrincipal);
            this.MainMenuStrip = this.mnsPrincipal;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sys Music Collection";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mnsPrincipal.ResumeLayout(false);
            this.mnsPrincipal.PerformLayout();
            this.spcPrincipal.Panel1.ResumeLayout(false);
            this.spcPrincipal.Panel2.ResumeLayout(false);
            this.spcPrincipal.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcPrincipal)).EndInit();
            this.spcPrincipal.ResumeLayout(false);
            this.pnlPrincipal.ResumeLayout(false);
            this.spcHorizontal.Panel1.ResumeLayout(false);
            this.spcHorizontal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcHorizontal)).EndInit();
            this.spcHorizontal.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
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
        private System.Windows.Forms.ContextMenuStrip cmsPrincipal;
        private System.Windows.Forms.ToolStripMenuItem cmiEditar;
        private System.Windows.Forms.ToolStripMenuItem cmiExcluir;
        private System.Windows.Forms.ToolStripMenuItem msiRelatorios;
        private System.Windows.Forms.Button btnAbaLateral;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;


    }
}

