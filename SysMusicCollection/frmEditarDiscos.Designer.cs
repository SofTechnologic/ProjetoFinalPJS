namespace SysMusicCollection
{
    partial class frmEditarDiscos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboEditaInterprete = new System.Windows.Forms.ComboBox();
            this.cboEditaAutor = new System.Windows.Forms.ComboBox();
            this.cboEditaAlbumeAutor = new System.Windows.Forms.ComboBox();
            this.cboEditaOrigemCompra = new System.Windows.Forms.ComboBox();
            this.cboEditaTipoMidia = new System.Windows.Forms.ComboBox();
            this.dtpEditaDataAlbum = new System.Windows.Forms.DateTimePicker();
            this.dtpEditaDataCompra = new System.Windows.Forms.DateTimePicker();
            this.txtEditaNota = new System.Windows.Forms.TextBox();
            this.txtEditaObservacoes = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.erpErroEdita = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erpErroEdita)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Interprete";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Album/Musica";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data do àlbum";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data da compra";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 211);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Origem da compra";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 260);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tipo de Mìdia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(168, 260);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nota(de 0 à 10)";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 312);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Observações";
            // 
            // cboEditaInterprete
            // 
            this.cboEditaInterprete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboEditaInterprete.FormattingEnabled = true;
            this.cboEditaInterprete.Location = new System.Drawing.Point(16, 36);
            this.cboEditaInterprete.Margin = new System.Windows.Forms.Padding(4);
            this.cboEditaInterprete.Name = "cboEditaInterprete";
            this.cboEditaInterprete.Size = new System.Drawing.Size(287, 24);
            this.cboEditaInterprete.TabIndex = 1;
            // 
            // cboEditaAutor
            // 
            this.cboEditaAutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboEditaAutor.FormattingEnabled = true;
            this.cboEditaAutor.Location = new System.Drawing.Point(16, 85);
            this.cboEditaAutor.Margin = new System.Windows.Forms.Padding(4);
            this.cboEditaAutor.Name = "cboEditaAutor";
            this.cboEditaAutor.Size = new System.Drawing.Size(287, 24);
            this.cboEditaAutor.TabIndex = 2;
            // 
            // cboEditaAlbumeAutor
            // 
            this.cboEditaAlbumeAutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboEditaAlbumeAutor.FormattingEnabled = true;
            this.cboEditaAlbumeAutor.Location = new System.Drawing.Point(16, 134);
            this.cboEditaAlbumeAutor.Margin = new System.Windows.Forms.Padding(4);
            this.cboEditaAlbumeAutor.Name = "cboEditaAlbumeAutor";
            this.cboEditaAlbumeAutor.Size = new System.Drawing.Size(287, 24);
            this.cboEditaAlbumeAutor.TabIndex = 3;
            // 
            // cboEditaOrigemCompra
            // 
            this.cboEditaOrigemCompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboEditaOrigemCompra.FormattingEnabled = true;
            this.cboEditaOrigemCompra.Location = new System.Drawing.Point(16, 230);
            this.cboEditaOrigemCompra.Margin = new System.Windows.Forms.Padding(4);
            this.cboEditaOrigemCompra.Name = "cboEditaOrigemCompra";
            this.cboEditaOrigemCompra.Size = new System.Drawing.Size(287, 24);
            this.cboEditaOrigemCompra.TabIndex = 6;
            // 
            // cboEditaTipoMidia
            // 
            this.cboEditaTipoMidia.FormattingEnabled = true;
            this.cboEditaTipoMidia.Location = new System.Drawing.Point(16, 280);
            this.cboEditaTipoMidia.Margin = new System.Windows.Forms.Padding(4);
            this.cboEditaTipoMidia.Name = "cboEditaTipoMidia";
            this.cboEditaTipoMidia.Size = new System.Drawing.Size(132, 24);
            this.cboEditaTipoMidia.TabIndex = 7;
            // 
            // dtpEditaDataAlbum
            // 
            this.dtpEditaDataAlbum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEditaDataAlbum.Location = new System.Drawing.Point(16, 185);
            this.dtpEditaDataAlbum.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEditaDataAlbum.Name = "dtpEditaDataAlbum";
            this.dtpEditaDataAlbum.Size = new System.Drawing.Size(132, 22);
            this.dtpEditaDataAlbum.TabIndex = 4;
            // 
            // dtpEditaDataCompra
            // 
            this.dtpEditaDataCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEditaDataCompra.Location = new System.Drawing.Point(156, 185);
            this.dtpEditaDataCompra.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEditaDataCompra.Name = "dtpEditaDataCompra";
            this.dtpEditaDataCompra.Size = new System.Drawing.Size(147, 22);
            this.dtpEditaDataCompra.TabIndex = 5;
            // 
            // txtEditaNota
            // 
            this.txtEditaNota.Location = new System.Drawing.Point(171, 280);
            this.txtEditaNota.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditaNota.Name = "txtEditaNota";
            this.txtEditaNota.Size = new System.Drawing.Size(132, 22);
            this.txtEditaNota.TabIndex = 8;
            this.txtEditaNota.Leave += new System.EventHandler(this.txtEditaNota_Leave);
            // 
            // txtEditaObservacoes
            // 
            this.txtEditaObservacoes.Location = new System.Drawing.Point(19, 332);
            this.txtEditaObservacoes.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditaObservacoes.Multiline = true;
            this.txtEditaObservacoes.Name = "txtEditaObservacoes";
            this.txtEditaObservacoes.Size = new System.Drawing.Size(284, 41);
            this.txtEditaObservacoes.TabIndex = 9;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(203, 381);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(95, 381);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 28);
            this.btnSalvar.TabIndex = 19;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // erpErroEdita
            // 
            this.erpErroEdita.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erpErroEdita.ContainerControl = this;
            // 
            // frmEditarDiscos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 418);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtEditaObservacoes);
            this.Controls.Add(this.txtEditaNota);
            this.Controls.Add(this.dtpEditaDataCompra);
            this.Controls.Add(this.dtpEditaDataAlbum);
            this.Controls.Add(this.cboEditaTipoMidia);
            this.Controls.Add(this.cboEditaOrigemCompra);
            this.Controls.Add(this.cboEditaAlbumeAutor);
            this.Controls.Add(this.cboEditaAutor);
            this.Controls.Add(this.cboEditaInterprete);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditarDiscos";
            this.Text = "frmEditarDiscos";
            this.Load += new System.EventHandler(this.frmEditarDiscos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erpErroEdita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboEditaInterprete;
        private System.Windows.Forms.ComboBox cboEditaAutor;
        private System.Windows.Forms.ComboBox cboEditaAlbumeAutor;
        private System.Windows.Forms.ComboBox cboEditaOrigemCompra;
        private System.Windows.Forms.ComboBox cboEditaTipoMidia;
        private System.Windows.Forms.DateTimePicker dtpEditaDataAlbum;
        private System.Windows.Forms.DateTimePicker dtpEditaDataCompra;
        private System.Windows.Forms.TextBox txtEditaNota;
        private System.Windows.Forms.TextBox txtEditaObservacoes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ErrorProvider erpErroEdita;
    }
}