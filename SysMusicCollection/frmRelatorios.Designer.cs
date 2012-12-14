namespace SysMusicCollection
{
    partial class frmRelatorios
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
            this.tbcRel = new System.Windows.Forms.TabControl();
            this.tbcEmprestados = new System.Windows.Forms.TabPage();
            this.dgvDevolucao = new System.Windows.Forms.DataGridView();
            this.tbcDevolvidos = new System.Windows.Forms.TabPage();
            this.dgvEmprestados = new System.Windows.Forms.DataGridView();
            this.tbcAmigos = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.dgvAmigos = new System.Windows.Forms.DataGridView();
            this.tbcRel.SuspendLayout();
            this.tbcEmprestados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucao)).BeginInit();
            this.tbcDevolvidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestados)).BeginInit();
            this.tbcAmigos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmigos)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcRel
            // 
            this.tbcRel.Controls.Add(this.tbcEmprestados);
            this.tbcRel.Controls.Add(this.tbcDevolvidos);
            this.tbcRel.Controls.Add(this.tbcAmigos);
            this.tbcRel.Location = new System.Drawing.Point(12, 12);
            this.tbcRel.Name = "tbcRel";
            this.tbcRel.SelectedIndex = 0;
            this.tbcRel.Size = new System.Drawing.Size(947, 495);
            this.tbcRel.TabIndex = 0;
            // 
            // tbcEmprestados
            // 
            this.tbcEmprestados.BackColor = System.Drawing.Color.AliceBlue;
            this.tbcEmprestados.Controls.Add(this.dgvDevolucao);
            this.tbcEmprestados.Location = new System.Drawing.Point(4, 22);
            this.tbcEmprestados.Name = "tbcEmprestados";
            this.tbcEmprestados.Padding = new System.Windows.Forms.Padding(3);
            this.tbcEmprestados.Size = new System.Drawing.Size(939, 469);
            this.tbcEmprestados.TabIndex = 0;
            this.tbcEmprestados.Text = "Emprestados";
            this.tbcEmprestados.Enter += new System.EventHandler(this.tbcDevolucao_Enter);
            // 
            // dgvDevolucao
            // 
            this.dgvDevolucao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDevolucao.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvDevolucao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevolucao.Location = new System.Drawing.Point(6, 99);
            this.dgvDevolucao.Name = "dgvDevolucao";
            this.dgvDevolucao.ReadOnly = true;
            this.dgvDevolucao.RowHeadersVisible = false;
            this.dgvDevolucao.Size = new System.Drawing.Size(927, 364);
            this.dgvDevolucao.TabIndex = 0;
            // 
            // tbcDevolvidos
            // 
            this.tbcDevolvidos.BackColor = System.Drawing.Color.AliceBlue;
            this.tbcDevolvidos.Controls.Add(this.dgvEmprestados);
            this.tbcDevolvidos.Location = new System.Drawing.Point(4, 22);
            this.tbcDevolvidos.Name = "tbcDevolvidos";
            this.tbcDevolvidos.Padding = new System.Windows.Forms.Padding(3);
            this.tbcDevolvidos.Size = new System.Drawing.Size(939, 469);
            this.tbcDevolvidos.TabIndex = 1;
            this.tbcDevolvidos.Text = "Devolvidos";
            this.tbcDevolvidos.UseVisualStyleBackColor = true;
            this.tbcDevolvidos.Enter += new System.EventHandler(this.tbcEmprestados_Enter);
            // 
            // dgvEmprestados
            // 
            this.dgvEmprestados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmprestados.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvEmprestados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmprestados.Location = new System.Drawing.Point(6, 99);
            this.dgvEmprestados.Name = "dgvEmprestados";
            this.dgvEmprestados.ReadOnly = true;
            this.dgvEmprestados.RowHeadersVisible = false;
            this.dgvEmprestados.Size = new System.Drawing.Size(927, 364);
            this.dgvEmprestados.TabIndex = 0;
            // 
            // tbcAmigos
            // 
            this.tbcAmigos.Controls.Add(this.textBox1);
            this.tbcAmigos.Controls.Add(this.btnPesquisa);
            this.tbcAmigos.Controls.Add(this.dgvAmigos);
            this.tbcAmigos.Location = new System.Drawing.Point(4, 22);
            this.tbcAmigos.Name = "tbcAmigos";
            this.tbcAmigos.Padding = new System.Windows.Forms.Padding(3);
            this.tbcAmigos.Size = new System.Drawing.Size(939, 469);
            this.tbcAmigos.TabIndex = 2;
            this.tbcAmigos.Text = "Amigos";
            this.tbcAmigos.UseVisualStyleBackColor = true;
            this.tbcAmigos.Enter += new System.EventHandler(this.tbcAmigos_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(263, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(419, 34);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisa.TabIndex = 1;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // dgvAmigos
            // 
            this.dgvAmigos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAmigos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAmigos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAmigos.Location = new System.Drawing.Point(0, 67);
            this.dgvAmigos.Name = "dgvAmigos";
            this.dgvAmigos.ReadOnly = true;
            this.dgvAmigos.Size = new System.Drawing.Size(936, 399);
            this.dgvAmigos.TabIndex = 0;
            // 
            // frmRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(971, 510);
            this.Controls.Add(this.tbcRel);
            this.Name = "frmRelatorios";
            this.Text = "Relatórios";
            this.Load += new System.EventHandler(this.frmRelatorios_Load);
            this.tbcRel.ResumeLayout(false);
            this.tbcEmprestados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucao)).EndInit();
            this.tbcDevolvidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestados)).EndInit();
            this.tbcAmigos.ResumeLayout(false);
            this.tbcAmigos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmigos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcRel;
        private System.Windows.Forms.TabPage tbcEmprestados;
        private System.Windows.Forms.DataGridView dgvDevolucao;
        private System.Windows.Forms.TabPage tbcDevolvidos;
        private System.Windows.Forms.DataGridView dgvEmprestados;
        private System.Windows.Forms.TabPage tbcAmigos;
        private System.Windows.Forms.DataGridView dgvAmigos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPesquisa;
    }
}