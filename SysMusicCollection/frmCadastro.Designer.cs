namespace SysMusicCollection
{
    partial class frmCadastro
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
            this.tbcCadastro = new System.Windows.Forms.TabControl();
            this.tbpDiscos = new System.Windows.Forms.TabPage();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dtpDataCompra = new System.Windows.Forms.DateTimePicker();
            this.dtpDataAlbum = new System.Windows.Forms.DateTimePicker();
            this.cboMidia = new System.Windows.Forms.ComboBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.txtOrigemCompra = new System.Windows.Forms.TextBox();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtInterprete = new System.Windows.Forms.TextBox();
            this.lblNota = new System.Windows.Forms.Label();
            this.lblObservacoes = new System.Windows.Forms.Label();
            this.lblTipoMidia = new System.Windows.Forms.Label();
            this.lblOrigemCompra = new System.Windows.Forms.Label();
            this.lblDataCompra = new System.Windows.Forms.Label();
            this.lblDataAlbum = new System.Windows.Forms.Label();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblInterprete = new System.Windows.Forms.Label();
            this.tbpAmigos = new System.Windows.Forms.TabPage();
            this.tbcCadastro.SuspendLayout();
            this.tbpDiscos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcCadastro
            // 
            this.tbcCadastro.Controls.Add(this.tbpDiscos);
            this.tbcCadastro.Controls.Add(this.tbpAmigos);
            this.tbcCadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcCadastro.Location = new System.Drawing.Point(0, 0);
            this.tbcCadastro.Name = "tbcCadastro";
            this.tbcCadastro.SelectedIndex = 0;
            this.tbcCadastro.Size = new System.Drawing.Size(454, 302);
            this.tbcCadastro.TabIndex = 0;
            // 
            // tbpDiscos
            // 
            this.tbpDiscos.Controls.Add(this.btnCancelar);
            this.tbpDiscos.Controls.Add(this.btnLimpar);
            this.tbpDiscos.Controls.Add(this.btnSalvar);
            this.tbpDiscos.Controls.Add(this.dtpDataCompra);
            this.tbpDiscos.Controls.Add(this.dtpDataAlbum);
            this.tbpDiscos.Controls.Add(this.cboMidia);
            this.tbpDiscos.Controls.Add(this.txtNota);
            this.tbpDiscos.Controls.Add(this.txtObservacoes);
            this.tbpDiscos.Controls.Add(this.txtOrigemCompra);
            this.tbpDiscos.Controls.Add(this.txtAlbum);
            this.tbpDiscos.Controls.Add(this.txtAutor);
            this.tbpDiscos.Controls.Add(this.txtInterprete);
            this.tbpDiscos.Controls.Add(this.lblNota);
            this.tbpDiscos.Controls.Add(this.lblObservacoes);
            this.tbpDiscos.Controls.Add(this.lblTipoMidia);
            this.tbpDiscos.Controls.Add(this.lblOrigemCompra);
            this.tbpDiscos.Controls.Add(this.lblDataCompra);
            this.tbpDiscos.Controls.Add(this.lblDataAlbum);
            this.tbpDiscos.Controls.Add(this.lblAlbum);
            this.tbpDiscos.Controls.Add(this.lblAutor);
            this.tbpDiscos.Controls.Add(this.lblInterprete);
            this.tbpDiscos.Location = new System.Drawing.Point(4, 22);
            this.tbpDiscos.Name = "tbpDiscos";
            this.tbpDiscos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDiscos.Size = new System.Drawing.Size(446, 276);
            this.tbpDiscos.TabIndex = 0;
            this.tbpDiscos.Text = "Discos";
            this.tbpDiscos.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(359, 241);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(278, 241);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(197, 241);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // dtpDataCompra
            // 
            this.dtpDataCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCompra.Location = new System.Drawing.Point(332, 108);
            this.dtpDataCompra.Name = "dtpDataCompra";
            this.dtpDataCompra.Size = new System.Drawing.Size(102, 20);
            this.dtpDataCompra.TabIndex = 5;
            // 
            // dtpDataAlbum
            // 
            this.dtpDataAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataAlbum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataAlbum.Location = new System.Drawing.Point(197, 108);
            this.dtpDataAlbum.Name = "dtpDataAlbum";
            this.dtpDataAlbum.Size = new System.Drawing.Size(108, 20);
            this.dtpDataAlbum.TabIndex = 4;
            // 
            // cboMidia
            // 
            this.cboMidia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMidia.FormattingEnabled = true;
            this.cboMidia.Items.AddRange(new object[] {
            "Selecione um Tipo...",
            "Vinil",
            "K7",
            "CD",
            "DVD",
            "Digital"});
            this.cboMidia.Location = new System.Drawing.Point(197, 149);
            this.cboMidia.Name = "cboMidia";
            this.cboMidia.Size = new System.Drawing.Size(129, 21);
            this.cboMidia.TabIndex = 7;
            // 
            // txtNota
            // 
            this.txtNota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNota.Location = new System.Drawing.Point(332, 150);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(102, 20);
            this.txtNota.TabIndex = 8;
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservacoes.Location = new System.Drawing.Point(6, 192);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(428, 43);
            this.txtObservacoes.TabIndex = 9;
            // 
            // txtOrigemCompra
            // 
            this.txtOrigemCompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrigemCompra.Location = new System.Drawing.Point(6, 150);
            this.txtOrigemCompra.Name = "txtOrigemCompra";
            this.txtOrigemCompra.Size = new System.Drawing.Size(174, 20);
            this.txtOrigemCompra.TabIndex = 6;
            // 
            // txtAlbum
            // 
            this.txtAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAlbum.Location = new System.Drawing.Point(6, 108);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(174, 20);
            this.txtAlbum.TabIndex = 3;
            // 
            // txtAutor
            // 
            this.txtAutor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAutor.Location = new System.Drawing.Point(6, 64);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(428, 20);
            this.txtAutor.TabIndex = 2;
            // 
            // txtInterprete
            // 
            this.txtInterprete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInterprete.Location = new System.Drawing.Point(6, 22);
            this.txtInterprete.Name = "txtInterprete";
            this.txtInterprete.Size = new System.Drawing.Size(428, 20);
            this.txtInterprete.TabIndex = 1;
            // 
            // lblNota
            // 
            this.lblNota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNota.AutoSize = true;
            this.lblNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota.Location = new System.Drawing.Point(329, 131);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(102, 16);
            this.lblNota.TabIndex = 8;
            this.lblNota.Text = "Nota (de 0 à 10)";
            // 
            // lblObservacoes
            // 
            this.lblObservacoes.AutoSize = true;
            this.lblObservacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacoes.Location = new System.Drawing.Point(6, 173);
            this.lblObservacoes.Name = "lblObservacoes";
            this.lblObservacoes.Size = new System.Drawing.Size(90, 16);
            this.lblObservacoes.TabIndex = 7;
            this.lblObservacoes.Text = "Observações";
            // 
            // lblTipoMidia
            // 
            this.lblTipoMidia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTipoMidia.AutoSize = true;
            this.lblTipoMidia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoMidia.Location = new System.Drawing.Point(194, 131);
            this.lblTipoMidia.Name = "lblTipoMidia";
            this.lblTipoMidia.Size = new System.Drawing.Size(91, 16);
            this.lblTipoMidia.TabIndex = 6;
            this.lblTipoMidia.Text = "Tipo de Mídia";
            // 
            // lblOrigemCompra
            // 
            this.lblOrigemCompra.AutoSize = true;
            this.lblOrigemCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigemCompra.Location = new System.Drawing.Point(6, 131);
            this.lblOrigemCompra.Name = "lblOrigemCompra";
            this.lblOrigemCompra.Size = new System.Drawing.Size(120, 16);
            this.lblOrigemCompra.TabIndex = 5;
            this.lblOrigemCompra.Text = "Origem da compra";
            // 
            // lblDataCompra
            // 
            this.lblDataCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDataCompra.AutoSize = true;
            this.lblDataCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCompra.Location = new System.Drawing.Point(329, 89);
            this.lblDataCompra.Name = "lblDataCompra";
            this.lblDataCompra.Size = new System.Drawing.Size(105, 16);
            this.lblDataCompra.TabIndex = 4;
            this.lblDataCompra.Text = "Data da compra";
            // 
            // lblDataAlbum
            // 
            this.lblDataAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDataAlbum.AutoSize = true;
            this.lblDataAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataAlbum.Location = new System.Drawing.Point(194, 89);
            this.lblDataAlbum.Name = "lblDataAlbum";
            this.lblDataAlbum.Size = new System.Drawing.Size(96, 16);
            this.lblDataAlbum.TabIndex = 3;
            this.lblDataAlbum.Text = "Data do álbum";
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbum.Location = new System.Drawing.Point(6, 89);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(46, 16);
            this.lblAlbum.TabIndex = 2;
            this.lblAlbum.Text = "Álbum";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(6, 45);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(39, 16);
            this.lblAutor.TabIndex = 1;
            this.lblAutor.Text = "Autor";
            this.lblAutor.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblInterprete
            // 
            this.lblInterprete.AutoSize = true;
            this.lblInterprete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterprete.Location = new System.Drawing.Point(6, 3);
            this.lblInterprete.Name = "lblInterprete";
            this.lblInterprete.Size = new System.Drawing.Size(64, 16);
            this.lblInterprete.TabIndex = 0;
            this.lblInterprete.Text = "Intérprete";
            // 
            // tbpAmigos
            // 
            this.tbpAmigos.Location = new System.Drawing.Point(4, 22);
            this.tbpAmigos.Name = "tbpAmigos";
            this.tbpAmigos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAmigos.Size = new System.Drawing.Size(446, 276);
            this.tbpAmigos.TabIndex = 1;
            this.tbpAmigos.Text = "Amigos";
            this.tbpAmigos.UseVisualStyleBackColor = true;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 302);
            this.Controls.Add(this.tbcCadastro);
            this.MaximumSize = new System.Drawing.Size(700, 430);
            this.MinimumSize = new System.Drawing.Size(470, 340);
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Discos/Amigos";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            this.tbcCadastro.ResumeLayout(false);
            this.tbpDiscos.ResumeLayout(false);
            this.tbpDiscos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcCadastro;
        private System.Windows.Forms.TabPage tbpDiscos;
        private System.Windows.Forms.TabPage tbpAmigos;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Label lblObservacoes;
        private System.Windows.Forms.Label lblTipoMidia;
        private System.Windows.Forms.Label lblOrigemCompra;
        private System.Windows.Forms.Label lblDataCompra;
        private System.Windows.Forms.Label lblDataAlbum;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblInterprete;
        private System.Windows.Forms.DateTimePicker dtpDataCompra;
        private System.Windows.Forms.DateTimePicker dtpDataAlbum;
        private System.Windows.Forms.ComboBox cboMidia;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.TextBox txtOrigemCompra;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtInterprete;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpar;
    }
}