﻿namespace SysMusicCollection
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("DVD", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("CD", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("VHS", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Vinil", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("K7", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Digital", System.Windows.Forms.HorizontalAlignment.Left);
            this.mnsPrincipal = new System.Windows.Forms.MenuStrip();
            this.msiArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.msiRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.msiConfig = new System.Windows.Forms.ToolStripMenuItem();
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
            this.cmsPrincipal = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.tltPrincipal = new System.Windows.Forms.ToolTip(this.components);
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
            this.cmsPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsPrincipal
            // 
            this.mnsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiArquivo,
            this.msiConfig});
            this.mnsPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnsPrincipal.Name = "mnsPrincipal";
            this.mnsPrincipal.Size = new System.Drawing.Size(734, 24);
            this.mnsPrincipal.TabIndex = 0;
            this.mnsPrincipal.Text = "menuStrip1";
            // 
            // msiArquivo
            // 
            this.msiArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiRelatorios});
            this.msiArquivo.Name = "msiArquivo";
            this.msiArquivo.Size = new System.Drawing.Size(61, 20);
            this.msiArquivo.Text = "Arquivo";
            // 
            // msiRelatorios
            // 
            this.msiRelatorios.Name = "msiRelatorios";
            this.msiRelatorios.Size = new System.Drawing.Size(126, 22);
            this.msiRelatorios.Text = "Relatórios";
            this.msiRelatorios.Click += new System.EventHandler(this.relatóriosToolStripMenuItem_Click);
            // 
            // msiConfig
            // 
            this.msiConfig.Name = "msiConfig";
            this.msiConfig.Size = new System.Drawing.Size(96, 20);
            this.msiConfig.Text = "Configurações";
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
            this.tltPrincipal.SetToolTip(this.btnEmprDev, "Emprestar ou devolver mídias");
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
            this.tltPrincipal.SetToolTip(this.btnCadastro, "Cadastrar acervo ou amigos");
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // txbPesquisa
            // 
            this.txbPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPesquisa.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txbPesquisa.Location = new System.Drawing.Point(475, 14);
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
            this.pnlPrincipal.Size = new System.Drawing.Size(703, 376);
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
            this.spcHorizontal.Size = new System.Drawing.Size(703, 376);
            this.spcHorizontal.SplitterDistance = 25;
            this.spcHorizontal.TabIndex = 0;
            // 
            // btnAbaFiltro
            // 
            this.btnAbaFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbaFiltro.Location = new System.Drawing.Point(0, 8);
            this.btnAbaFiltro.Name = "btnAbaFiltro";
            this.btnAbaFiltro.Size = new System.Drawing.Size(703, 14);
            this.btnAbaFiltro.TabIndex = 0;
            this.btnAbaFiltro.Text = "^";
            this.btnAbaFiltro.UseVisualStyleBackColor = true;
            this.btnAbaFiltro.Click += new System.EventHandler(this.button1_Click);
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
            this.lsvPrincipal.Size = new System.Drawing.Size(703, 347);
            this.lsvPrincipal.TabIndex = 0;
            this.lsvPrincipal.UseCompatibleStateImageBehavior = false;
            this.lsvPrincipal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lsvPrincipal_KeyDown);
            // 
            // cmsPrincipal
            // 
            this.cmsPrincipal.AllowDrop = true;
            this.cmsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmiEditar,
            this.cmiExcluir});
            this.cmsPrincipal.Name = "contextMenuStrip1";
            this.cmsPrincipal.Size = new System.Drawing.Size(109, 48);
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
            this.cmsPrincipal.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem msiConfig;
        private System.Windows.Forms.SplitContainer spcHorizontal;
        private System.Windows.Forms.Button btnAbaFiltro;
        private System.Windows.Forms.ListView lsvPrincipal;
        private System.Windows.Forms.ContextMenuStrip cmsPrincipal;
        private System.Windows.Forms.ToolStripMenuItem cmiEditar;
        private System.Windows.Forms.ToolStripMenuItem cmiExcluir;
        private System.Windows.Forms.ToolStripMenuItem msiRelatorios;
        private System.Windows.Forms.Button btnAbaLateral;


    }
}

