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
            this.tbcRel.SuspendLayout();
            this.tbcEmprestados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucao)).BeginInit();
            this.tbcDevolvidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestados)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcRel
            // 
            this.tbcRel.Controls.Add(this.tbcEmprestados);
            this.tbcRel.Controls.Add(this.tbcDevolvidos);
            this.tbcRel.Location = new System.Drawing.Point(12, 12);
            this.tbcRel.Name = "tbcRel";
            this.tbcRel.SelectedIndex = 0;
            this.tbcRel.Size = new System.Drawing.Size(947, 495);
            this.tbcRel.TabIndex = 0;
            this.tbcRel.Enter += new System.EventHandler(this.tabControl1_Enter);
            // 
            // tbcEmprestados
            // 
            this.tbcEmprestados.Controls.Add(this.dgvDevolucao);
            this.tbcEmprestados.Location = new System.Drawing.Point(4, 22);
            this.tbcEmprestados.Name = "tbcEmprestados";
            this.tbcEmprestados.Padding = new System.Windows.Forms.Padding(3);
            this.tbcEmprestados.Size = new System.Drawing.Size(939, 469);
            this.tbcEmprestados.TabIndex = 0;
            this.tbcEmprestados.Text = "Emprestados";
            this.tbcEmprestados.UseVisualStyleBackColor = true;
            this.tbcEmprestados.Enter += new System.EventHandler(this.tbcDevolucao_Enter);
            // 
            // dgvDevolucao
            // 
            this.dgvDevolucao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDevolucao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevolucao.Location = new System.Drawing.Point(6, 99);
            this.dgvDevolucao.Name = "dgvDevolucao";
            this.dgvDevolucao.Size = new System.Drawing.Size(927, 364);
            this.dgvDevolucao.TabIndex = 0;
            // 
            // tbcDevolvidos
            // 
            this.tbcDevolvidos.Controls.Add(this.dgvEmprestados);
            this.tbcDevolvidos.Location = new System.Drawing.Point(4, 22);
            this.tbcDevolvidos.Name = "tbcDevolvidos";
            this.tbcDevolvidos.Padding = new System.Windows.Forms.Padding(3);
            this.tbcDevolvidos.Size = new System.Drawing.Size(939, 469);
            this.tbcDevolvidos.TabIndex = 1;
            this.tbcDevolvidos.Text = "Devolvidos";
            this.tbcDevolvidos.UseVisualStyleBackColor = true;
            this.tbcDevolvidos.Click += new System.EventHandler(this.tbcDevolvidos_Click);
            this.tbcDevolvidos.Enter += new System.EventHandler(this.tbcEmprestados_Enter);
            // 
            // dgvEmprestados
            // 
            this.dgvEmprestados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmprestados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmprestados.Location = new System.Drawing.Point(6, 99);
            this.dgvEmprestados.Name = "dgvEmprestados";
            this.dgvEmprestados.ReadOnly = true;
            this.dgvEmprestados.Size = new System.Drawing.Size(927, 364);
            this.dgvEmprestados.TabIndex = 0;
            // 
            // frmRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcRel;
        private System.Windows.Forms.TabPage tbcEmprestados;
        private System.Windows.Forms.DataGridView dgvDevolucao;
        private System.Windows.Forms.TabPage tbcDevolvidos;
        private System.Windows.Forms.DataGridView dgvEmprestados;
    }
}