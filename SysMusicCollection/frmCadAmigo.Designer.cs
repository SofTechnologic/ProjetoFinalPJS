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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            this.tbcCadastro = new System.Windows.Forms.TabControl();
            this.tbpDiscos = new System.Windows.Forms.TabPage();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.txtOrigemCompra = new System.Windows.Forms.TextBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.cboAlbum = new System.Windows.Forms.ComboBox();
            this.cboAutor = new System.Windows.Forms.ComboBox();
            this.cboInterprete = new System.Windows.Forms.ComboBox();
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
            this.cboEndereco = new System.Windows.Forms.ComboBox();
            this.cboNomeAmigo = new System.Windows.Forms.ComboBox();
            this.btnCancelarAmigo = new System.Windows.Forms.Button();
            this.btnLimparAmigo = new System.Windows.Forms.Button();
            this.btnSalvarAmigo = new System.Windows.Forms.Button();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblNomeAmigo = new System.Windows.Forms.Label();
            this.erpErro = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbcCadastro.SuspendLayout();
            this.tbpDiscos.SuspendLayout();
            this.tbpAmigos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpErro)).BeginInit();
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
            this.tbcCadastro.Size = new System.Drawing.Size(481, 312);
            this.tbcCadastro.TabIndex = 0;
            // 
            // tbpDiscos
            // 
            this.tbpDiscos.BackColor = System.Drawing.Color.AliceBlue;
            this.tbpDiscos.Controls.Add(this.txtObservacoes);
            this.tbpDiscos.Controls.Add(this.txtOrigemCompra);
            this.tbpDiscos.Controls.Add(this.txtNota);
            this.tbpDiscos.Controls.Add(this.cboAlbum);
            this.tbpDiscos.Controls.Add(this.cboAutor);
            this.tbpDiscos.Controls.Add(this.cboInterprete);
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
            this.tbpDiscos.Size = new System.Drawing.Size(473, 286);
            this.tbpDiscos.TabIndex = 0;
            this.tbpDiscos.Text = "Discos";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservacoes.Location = new System.Drawing.Point(9, 193);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(442, 43);
            this.txtObservacoes.TabIndex = 10;
            // 
            // txtOrigemCompra
            // 
            this.txtOrigemCompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrigemCompra.Location = new System.Drawing.Point(9, 151);
            this.txtOrigemCompra.Name = "txtOrigemCompra";
            this.txtOrigemCompra.Size = new System.Drawing.Size(176, 20);
            this.txtOrigemCompra.TabIndex = 7;
            // 
            // txtNota
            // 
            this.txtNota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNota.Location = new System.Drawing.Point(348, 150);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(103, 20);
            this.txtNota.TabIndex = 9;
            this.txtNota.Leave += new System.EventHandler(this.txtNota_Leave);
            // 
            // cboAlbum
            // 
            this.cboAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboAlbum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboAlbum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboAlbum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboAlbum.FormattingEnabled = true;
            this.cboAlbum.Location = new System.Drawing.Point(9, 106);
            this.cboAlbum.Name = "cboAlbum";
            this.cboAlbum.Size = new System.Drawing.Size(176, 18);
            this.cboAlbum.TabIndex = 4;
            this.cboAlbum.Enter += new System.EventHandler(this.cboAlbum_Enter);
            // 
            // cboAutor
            // 
            this.cboAutor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboAutor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboAutor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboAutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboAutor.FormattingEnabled = true;
            this.cboAutor.Location = new System.Drawing.Point(9, 65);
            this.cboAutor.Name = "cboAutor";
            this.cboAutor.Size = new System.Drawing.Size(442, 18);
            this.cboAutor.TabIndex = 2;
            // 
            // cboInterprete
            // 
            this.cboInterprete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboInterprete.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboInterprete.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboInterprete.BackColor = System.Drawing.SystemColors.Window;
            this.cboInterprete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboInterprete.FormattingEnabled = true;
            this.cboInterprete.Location = new System.Drawing.Point(6, 22);
            this.cboInterprete.Name = "cboInterprete";
            this.cboInterprete.Size = new System.Drawing.Size(446, 18);
            this.cboInterprete.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(376, 257);
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
            this.btnLimpar.Location = new System.Drawing.Point(295, 257);
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
            this.btnSalvar.Location = new System.Drawing.Point(214, 257);
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
            this.dtpDataCompra.Location = new System.Drawing.Point(348, 108);
            this.dtpDataCompra.Name = "dtpDataCompra";
            this.dtpDataCompra.Size = new System.Drawing.Size(103, 20);
            this.dtpDataCompra.TabIndex = 6;
            // 
            // dtpDataAlbum
            // 
            this.dtpDataAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataAlbum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataAlbum.Location = new System.Drawing.Point(213, 108);
            this.dtpDataAlbum.Name = "dtpDataAlbum";
            this.dtpDataAlbum.Size = new System.Drawing.Size(108, 20);
            this.dtpDataAlbum.TabIndex = 5;
            // 
            // cboMidia
            // 
            this.cboMidia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMidia.FormattingEnabled = true;
            this.cboMidia.Location = new System.Drawing.Point(213, 150);
            this.cboMidia.Name = "cboMidia";
            this.cboMidia.Size = new System.Drawing.Size(108, 21);
            this.cboMidia.TabIndex = 8;
            // 
            // lblNota
            // 
            this.lblNota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNota.AutoSize = true;
            this.lblNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota.Location = new System.Drawing.Point(345, 131);
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
            this.lblTipoMidia.Location = new System.Drawing.Point(210, 130);
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
            this.lblDataCompra.Location = new System.Drawing.Point(345, 87);
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
            this.lblDataAlbum.Location = new System.Drawing.Point(210, 87);
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
            this.lblAlbum.Size = new System.Drawing.Size(93, 16);
            this.lblAlbum.TabIndex = 2;
            this.lblAlbum.Text = "Álbum/Musica";
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
            this.tbpAmigos.BackColor = System.Drawing.Color.AliceBlue;
            this.tbpAmigos.Controls.Add(this.cboEndereco);
            this.tbpAmigos.Controls.Add(this.cboNomeAmigo);
            this.tbpAmigos.Controls.Add(this.btnCancelarAmigo);
            this.tbpAmigos.Controls.Add(this.btnLimparAmigo);
            this.tbpAmigos.Controls.Add(this.btnSalvarAmigo);
            this.tbpAmigos.Controls.Add(this.mtbTelefone);
            this.tbpAmigos.Controls.Add(this.lblEndereco);
            this.tbpAmigos.Controls.Add(this.lblTelefone);
            this.tbpAmigos.Controls.Add(this.lblNomeAmigo);
            this.tbpAmigos.Location = new System.Drawing.Point(4, 22);
            this.tbpAmigos.Name = "tbpAmigos";
            this.tbpAmigos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAmigos.Size = new System.Drawing.Size(473, 286);
            this.tbpAmigos.TabIndex = 1;
            this.tbpAmigos.Text = "Amigos";
            // 
            // cboEndereco
            // 
            this.cboEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboEndereco.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboEndereco.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboEndereco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboEndereco.FormattingEnabled = true;
            this.cboEndereco.Location = new System.Drawing.Point(9, 100);
            this.cboEndereco.Margin = new System.Windows.Forms.Padding(2);
            this.cboEndereco.Name = "cboEndereco";
            this.cboEndereco.Size = new System.Drawing.Size(440, 18);
            this.cboEndereco.TabIndex = 2;
            this.cboEndereco.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseClick);
            // 
            // cboNomeAmigo
            // 
            this.cboNomeAmigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboNomeAmigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboNomeAmigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboNomeAmigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboNomeAmigo.FormattingEnabled = true;
            this.cboNomeAmigo.Location = new System.Drawing.Point(8, 37);
            this.cboNomeAmigo.Margin = new System.Windows.Forms.Padding(2);
            this.cboNomeAmigo.Name = "cboNomeAmigo";
            this.cboNomeAmigo.Size = new System.Drawing.Size(441, 18);
            this.cboNomeAmigo.TabIndex = 1;
            this.cboNomeAmigo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cboNomeAmigo_MouseClick);
            // 
            // btnCancelarAmigo
            // 
            this.btnCancelarAmigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarAmigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarAmigo.Location = new System.Drawing.Point(378, 250);
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
            this.btnLimparAmigo.Location = new System.Drawing.Point(297, 250);
            this.btnLimparAmigo.Name = "btnLimparAmigo";
            this.btnLimparAmigo.Size = new System.Drawing.Size(75, 23);
            this.btnLimparAmigo.TabIndex = 5;
            this.btnLimparAmigo.Text = "Limpar";
            this.btnLimparAmigo.UseVisualStyleBackColor = true;
            this.btnLimparAmigo.Click += new System.EventHandler(this.btnLimparAmigo_Click);
            // 
            // btnSalvarAmigo
            // 
            this.btnSalvarAmigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarAmigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarAmigo.Location = new System.Drawing.Point(216, 250);
            this.btnSalvarAmigo.Name = "btnSalvarAmigo";
            this.btnSalvarAmigo.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarAmigo.TabIndex = 4;
            this.btnSalvarAmigo.Text = "Salvar";
            this.btnSalvarAmigo.UseVisualStyleBackColor = true;
            this.btnSalvarAmigo.Click += new System.EventHandler(this.btnSalvarAmigo_Click_1);
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Location = new System.Drawing.Point(7, 171);
            this.mtbTelefone.Mask = "(00)0000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(89, 20);
            this.mtbTelefone.TabIndex = 3;
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
            // erpErro
            // 
            this.erpErro.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erpErro.ContainerControl = this;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(481, 312);
            this.Controls.Add(this.tbcCadastro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(698, 428);
            this.MinimumSize = new System.Drawing.Size(497, 348);
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Discos/Amigos";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            this.tbcCadastro.ResumeLayout(false);
            this.tbpDiscos.ResumeLayout(false);
            this.tbpDiscos.PerformLayout();
            this.tbpAmigos.ResumeLayout(false);
            this.tbpAmigos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpErro)).EndInit();
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
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblNomeAmigo;
        private System.Windows.Forms.Button btnCancelarAmigo;
        private System.Windows.Forms.Button btnLimparAmigo;
        private System.Windows.Forms.Button btnSalvarAmigo;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.ComboBox cboAlbum;
        private System.Windows.Forms.ComboBox cboAutor;
        private System.Windows.Forms.ComboBox cboInterprete;
        private System.Windows.Forms.TextBox txtOrigemCompra;
        private System.Windows.Forms.ErrorProvider erpErro;
        private System.Windows.Forms.ComboBox cboNomeAmigo;
        private System.Windows.Forms.ComboBox cboEndereco;
    }
}