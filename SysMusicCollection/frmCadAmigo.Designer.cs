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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpCadastro = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblInterprete = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.lblDataAlbum = new System.Windows.Forms.Label();
            this.lblDataCompra = new System.Windows.Forms.Label();
            this.lblOrigemCompra = new System.Windows.Forms.Label();
            this.lblTipoMidia = new System.Windows.Forms.Label();
            this.lblObservações = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tbpCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpCadastro);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(696, 420);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpCadastro
            // 
            this.tbpCadastro.Controls.Add(this.dateTimePicker2);
            this.tbpCadastro.Controls.Add(this.dateTimePicker1);
            this.tbpCadastro.Controls.Add(this.comboBox1);
            this.tbpCadastro.Controls.Add(this.textBox6);
            this.tbpCadastro.Controls.Add(this.textBox5);
            this.tbpCadastro.Controls.Add(this.textBox4);
            this.tbpCadastro.Controls.Add(this.textBox3);
            this.tbpCadastro.Controls.Add(this.textBox2);
            this.tbpCadastro.Controls.Add(this.textBox1);
            this.tbpCadastro.Controls.Add(this.lblNota);
            this.tbpCadastro.Controls.Add(this.lblObservações);
            this.tbpCadastro.Controls.Add(this.lblTipoMidia);
            this.tbpCadastro.Controls.Add(this.lblOrigemCompra);
            this.tbpCadastro.Controls.Add(this.lblDataCompra);
            this.tbpCadastro.Controls.Add(this.lblDataAlbum);
            this.tbpCadastro.Controls.Add(this.lblAlbum);
            this.tbpCadastro.Controls.Add(this.lblAutor);
            this.tbpCadastro.Controls.Add(this.lblInterprete);
            this.tbpCadastro.Location = new System.Drawing.Point(4, 22);
            this.tbpCadastro.Name = "tbpCadastro";
            this.tbpCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCadastro.Size = new System.Drawing.Size(688, 394);
            this.tbpCadastro.TabIndex = 0;
            this.tbpCadastro.Text = "Discos";
            this.tbpCadastro.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(688, 394);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Amigos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblInterprete
            // 
            this.lblInterprete.AutoSize = true;
            this.lblInterprete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterprete.Location = new System.Drawing.Point(8, 20);
            this.lblInterprete.Name = "lblInterprete";
            this.lblInterprete.Size = new System.Drawing.Size(64, 16);
            this.lblInterprete.TabIndex = 0;
            this.lblInterprete.Text = "Intérprete";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(8, 71);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(39, 16);
            this.lblAutor.TabIndex = 1;
            this.lblAutor.Text = "Autor";
            this.lblAutor.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbum.Location = new System.Drawing.Point(8, 118);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(46, 16);
            this.lblAlbum.TabIndex = 2;
            this.lblAlbum.Text = "Álbum";
            // 
            // lblDataAlbum
            // 
            this.lblDataAlbum.AutoSize = true;
            this.lblDataAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataAlbum.Location = new System.Drawing.Point(8, 168);
            this.lblDataAlbum.Name = "lblDataAlbum";
            this.lblDataAlbum.Size = new System.Drawing.Size(96, 16);
            this.lblDataAlbum.TabIndex = 3;
            this.lblDataAlbum.Text = "Data do álbum";
            // 
            // lblDataCompra
            // 
            this.lblDataCompra.AutoSize = true;
            this.lblDataCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCompra.Location = new System.Drawing.Point(8, 205);
            this.lblDataCompra.Name = "lblDataCompra";
            this.lblDataCompra.Size = new System.Drawing.Size(105, 16);
            this.lblDataCompra.TabIndex = 4;
            this.lblDataCompra.Text = "Data da compra";
            // 
            // lblOrigemCompra
            // 
            this.lblOrigemCompra.AutoSize = true;
            this.lblOrigemCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigemCompra.Location = new System.Drawing.Point(8, 247);
            this.lblOrigemCompra.Name = "lblOrigemCompra";
            this.lblOrigemCompra.Size = new System.Drawing.Size(120, 16);
            this.lblOrigemCompra.TabIndex = 5;
            this.lblOrigemCompra.Text = "Origem da compra";
            // 
            // lblTipoMidia
            // 
            this.lblTipoMidia.AutoSize = true;
            this.lblTipoMidia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoMidia.Location = new System.Drawing.Point(8, 289);
            this.lblTipoMidia.Name = "lblTipoMidia";
            this.lblTipoMidia.Size = new System.Drawing.Size(91, 16);
            this.lblTipoMidia.TabIndex = 6;
            this.lblTipoMidia.Text = "Tipo de Mídia";
            // 
            // lblObservações
            // 
            this.lblObservações.AutoSize = true;
            this.lblObservações.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservações.Location = new System.Drawing.Point(5, 331);
            this.lblObservações.Name = "lblObservações";
            this.lblObservações.Size = new System.Drawing.Size(90, 16);
            this.lblObservações.TabIndex = 7;
            this.lblObservações.Text = "Observações";
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota.Location = new System.Drawing.Point(185, 331);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(102, 16);
            this.lblNota.TabIndex = 8;
            this.lblNota.Text = "Nota (de 0 à 10)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(8, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(8, 137);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(8, 266);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(8, 350);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 8;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(188, 350);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(8, 308);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(105, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 182);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(97, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(11, 225);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(97, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 420);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Discos/Amigos";
            this.tabControl1.ResumeLayout(false);
            this.tbpCadastro.ResumeLayout(false);
            this.tbpCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpCadastro;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Label lblObservações;
        private System.Windows.Forms.Label lblTipoMidia;
        private System.Windows.Forms.Label lblOrigemCompra;
        private System.Windows.Forms.Label lblDataCompra;
        private System.Windows.Forms.Label lblDataAlbum;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblInterprete;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}