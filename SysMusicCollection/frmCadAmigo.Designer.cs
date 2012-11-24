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
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.txtOrigemCompra = new System.Windows.Forms.TextBox();
            this.txtMusica = new System.Windows.Forms.TextBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.cboAlbum = new System.Windows.Forms.ComboBox();
            this.cboAutor = new System.Windows.Forms.ComboBox();
            this.cboInterprete = new System.Windows.Forms.ComboBox();
            this.lblMusica = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dtpDataCompra = new System.Windows.Forms.DateTimePicker();
            this.dtpDataAlbum = new System.Windows.Forms.DateTimePicker();
            this.cboMidia = new System.Windows.Forms.ComboBox();
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
            this.btnCancelarAmigo = new System.Windows.Forms.Button();
            this.btnLimparAmigo = new System.Windows.Forms.Button();
            this.btnSalvarAmigo = new System.Windows.Forms.Button();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNomeAmigo = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblNomeAmigo = new System.Windows.Forms.Label();
            this.tbcCadastro.SuspendLayout();
            this.tbpDiscos.SuspendLayout();
            this.tbpAmigos.SuspendLayout();
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
            this.tbpDiscos.Controls.Add(this.txtObservacoes);
            this.tbpDiscos.Controls.Add(this.txtOrigemCompra);
            this.tbpDiscos.Controls.Add(this.txtMusica);
            this.tbpDiscos.Controls.Add(this.txtNota);
            this.tbpDiscos.Controls.Add(this.cboAlbum);
            this.tbpDiscos.Controls.Add(this.cboAutor);
            this.tbpDiscos.Controls.Add(this.cboInterprete);
            this.tbpDiscos.Controls.Add(this.lblMusica);
            this.tbpDiscos.Controls.Add(this.btnCancelar);
            this.tbpDiscos.Controls.Add(this.btnLimpar);
            this.tbpDiscos.Controls.Add(this.btnSalvar);
            this.tbpDiscos.Controls.Add(this.dtpDataCompra);
            this.tbpDiscos.Controls.Add(this.dtpDataAlbum);
            this.tbpDiscos.Controls.Add(this.cboMidia);
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
            this.tbpDiscos.Click += new System.EventHandler(this.tbpDiscos_Click);
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(9, 193);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(427, 42);
            this.txtObservacoes.TabIndex = 10;
            // 
            // txtOrigemCompra
            // 
            this.txtOrigemCompra.Location = new System.Drawing.Point(9, 151);
            this.txtOrigemCompra.Name = "txtOrigemCompra";
            this.txtOrigemCompra.Size = new System.Drawing.Size(171, 20);
            this.txtOrigemCompra.TabIndex = 7;
            // 
            // txtMusica
            // 
            this.txtMusica.Location = new System.Drawing.Point(244, 67);
            this.txtMusica.Name = "txtMusica";
            this.txtMusica.Size = new System.Drawing.Size(192, 20);
            this.txtMusica.TabIndex = 3;
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(322, 151);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(114, 20);
            this.txtNota.TabIndex = 9;
            // 
            // cboAlbum
            // 
            this.cboAlbum.FormattingEnabled = true;
            this.cboAlbum.Location = new System.Drawing.Point(9, 106);
            this.cboAlbum.Name = "cboAlbum";
            this.cboAlbum.Size = new System.Drawing.Size(171, 21);
            this.cboAlbum.TabIndex = 4;
            // 
            // cboAutor
            // 
            this.cboAutor.FormattingEnabled = true;
            this.cboAutor.Location = new System.Drawing.Point(9, 65);
            this.cboAutor.Name = "cboAutor";
            this.cboAutor.Size = new System.Drawing.Size(228, 21);
            this.cboAutor.TabIndex = 2;
            // 
            // cboInterprete
            // 
            this.cboInterprete.FormattingEnabled = true;
            this.cboInterprete.Location = new System.Drawing.Point(9, 21);
            this.cboInterprete.Name = "cboInterprete";
            this.cboInterprete.Size = new System.Drawing.Size(427, 21);
            this.cboInterprete.TabIndex = 1;
            // 
            // lblMusica
            // 
            this.lblMusica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMusica.AutoSize = true;
            this.lblMusica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusica.Location = new System.Drawing.Point(243, 47);
            this.lblMusica.Name = "lblMusica";
            this.lblMusica.Size = new System.Drawing.Size(51, 16);
            this.lblMusica.TabIndex = 14;
            this.lblMusica.Text = "Musica";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(361, 241);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(280, 241);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(199, 241);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dtpDataCompra
            // 
            this.dtpDataCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCompra.Location = new System.Drawing.Point(321, 108);
            this.dtpDataCompra.Name = "dtpDataCompra";
            this.dtpDataCompra.Size = new System.Drawing.Size(117, 20);
            this.dtpDataCompra.TabIndex = 6;
            // 
            // dtpDataAlbum
            // 
            this.dtpDataAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataAlbum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataAlbum.Location = new System.Drawing.Point(186, 108);
            this.dtpDataAlbum.Name = "dtpDataAlbum";
            this.dtpDataAlbum.Size = new System.Drawing.Size(129, 20);
            this.dtpDataAlbum.TabIndex = 5;
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
            this.cboMidia.Location = new System.Drawing.Point(186, 149);
            this.cboMidia.Name = "cboMidia";
            this.cboMidia.Size = new System.Drawing.Size(129, 21);
            this.cboMidia.TabIndex = 8;
            this.cboMidia.SelectedIndexChanged += new System.EventHandler(this.cboMidia_SelectedIndexChanged);
            // 
            // lblNota
            // 
            this.lblNota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNota.AutoSize = true;
            this.lblNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota.Location = new System.Drawing.Point(318, 131);
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
            this.lblTipoMidia.Location = new System.Drawing.Point(183, 130);
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
            this.lblDataCompra.Location = new System.Drawing.Point(318, 87);
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
            this.lblDataAlbum.Location = new System.Drawing.Point(183, 87);
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
            this.tbpAmigos.Controls.Add(this.btnCancelarAmigo);
            this.tbpAmigos.Controls.Add(this.btnLimparAmigo);
            this.tbpAmigos.Controls.Add(this.btnSalvarAmigo);
            this.tbpAmigos.Controls.Add(this.mtbTelefone);
            this.tbpAmigos.Controls.Add(this.txtEndereco);
            this.tbpAmigos.Controls.Add(this.txtNomeAmigo);
            this.tbpAmigos.Controls.Add(this.lblEndereco);
            this.tbpAmigos.Controls.Add(this.lblTelefone);
            this.tbpAmigos.Controls.Add(this.lblNomeAmigo);
            this.tbpAmigos.Location = new System.Drawing.Point(4, 22);
            this.tbpAmigos.Name = "tbpAmigos";
            this.tbpAmigos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAmigos.Size = new System.Drawing.Size(446, 276);
            this.tbpAmigos.TabIndex = 1;
            this.tbpAmigos.Text = "Amigos";
            this.tbpAmigos.UseVisualStyleBackColor = true;
            // 
            // btnCancelarAmigo
            // 
            this.btnCancelarAmigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarAmigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarAmigo.Location = new System.Drawing.Point(363, 247);
            this.btnCancelarAmigo.Name = "btnCancelarAmigo";
            this.btnCancelarAmigo.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarAmigo.TabIndex = 6;
            this.btnCancelarAmigo.Text = "Cancelar";
            this.btnCancelarAmigo.UseVisualStyleBackColor = true;
            this.btnCancelarAmigo.Click += new System.EventHandler(this.btnCancelarAmigo_Click);
            // 
            // btnLimparAmigo
            // 
            this.btnLimparAmigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimparAmigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparAmigo.Location = new System.Drawing.Point(282, 247);
            this.btnLimparAmigo.Name = "btnLimparAmigo";
            this.btnLimparAmigo.Size = new System.Drawing.Size(75, 23);
            this.btnLimparAmigo.TabIndex = 5;
            this.btnLimparAmigo.Text = "LImpar";
            this.btnLimparAmigo.UseVisualStyleBackColor = true;
            this.btnLimparAmigo.Click += new System.EventHandler(this.btnLimparAmigo_Click);
            // 
            // btnSalvarAmigo
            // 
            this.btnSalvarAmigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarAmigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarAmigo.Location = new System.Drawing.Point(201, 247);
            this.btnSalvarAmigo.Name = "btnSalvarAmigo";
            this.btnSalvarAmigo.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarAmigo.TabIndex = 4;
            this.btnSalvarAmigo.Text = "Salvar";
            this.btnSalvarAmigo.UseVisualStyleBackColor = true;
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Location = new System.Drawing.Point(7, 171);
            this.mtbTelefone.Mask = "(00)0000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(89, 20);
            this.mtbTelefone.TabIndex = 3;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEndereco.Location = new System.Drawing.Point(7, 100);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(427, 20);
            this.txtEndereco.TabIndex = 2;
            // 
            // txtNomeAmigo
            // 
            this.txtNomeAmigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeAmigo.Location = new System.Drawing.Point(7, 37);
            this.txtNomeAmigo.Name = "txtNomeAmigo";
            this.txtNomeAmigo.Size = new System.Drawing.Size(427, 20);
            this.txtNomeAmigo.TabIndex = 1;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(4, 81);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(67, 16);
            this.lblEndereco.TabIndex = 2;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(5, 152);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(62, 16);
            this.lblTelefone.TabIndex = 1;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblNomeAmigo
            // 
            this.lblNomeAmigo.AutoSize = true;
            this.lblNomeAmigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeAmigo.Location = new System.Drawing.Point(6, 18);
            this.lblNomeAmigo.Name = "lblNomeAmigo";
            this.lblNomeAmigo.Size = new System.Drawing.Size(45, 16);
            this.lblNomeAmigo.TabIndex = 0;
            this.lblNomeAmigo.Text = "Nome";
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
            this.tbpAmigos.ResumeLayout(false);
            this.tbpAmigos.PerformLayout();
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
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblMusica;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNomeAmigo;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblNomeAmigo;
        private System.Windows.Forms.Button btnCancelarAmigo;
        private System.Windows.Forms.Button btnLimparAmigo;
        private System.Windows.Forms.Button btnSalvarAmigo;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.TextBox txtMusica;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.ComboBox cboAlbum;
        private System.Windows.Forms.ComboBox cboAutor;
        private System.Windows.Forms.ComboBox cboInterprete;
        private System.Windows.Forms.TextBox txtOrigemCompra;
    }
}