namespace SysMusicCollection
{
    partial class frmEmprestimo
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
            this.cboNomeAmigo = new System.Windows.Forms.ComboBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.dtpDataEmprestimo = new System.Windows.Forms.DateTimePicker();
            this.lblDataEmprestimo = new System.Windows.Forms.Label();
            this.dgvEmprestimo = new System.Windows.Forms.DataGridView();
            this.lblNomeMidia = new System.Windows.Forms.Label();
            this.cboNomeMidia = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimo)).BeginInit();
            this.SuspendLayout();
            // 
            // cboNomeAmigo
            // 
            this.cboNomeAmigo.FormattingEnabled = true;
            this.cboNomeAmigo.Location = new System.Drawing.Point(12, 28);
            this.cboNomeAmigo.Name = "cboNomeAmigo";
            this.cboNomeAmigo.Size = new System.Drawing.Size(430, 21);
            this.cboNomeAmigo.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(12, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(109, 16);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome do Amigo:";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpDataEmprestimo
            // 
            this.dtpDataEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataEmprestimo.Location = new System.Drawing.Point(12, 79);
            this.dtpDataEmprestimo.Name = "dtpDataEmprestimo";
            this.dtpDataEmprestimo.Size = new System.Drawing.Size(278, 22);
            this.dtpDataEmprestimo.TabIndex = 2;
            // 
            // lblDataEmprestimo
            // 
            this.lblDataEmprestimo.AutoSize = true;
            this.lblDataEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEmprestimo.Location = new System.Drawing.Point(12, 60);
            this.lblDataEmprestimo.Name = "lblDataEmprestimo";
            this.lblDataEmprestimo.Size = new System.Drawing.Size(134, 16);
            this.lblDataEmprestimo.TabIndex = 3;
            this.lblDataEmprestimo.Text = "Data do Empréstimo:";
            // 
            // dgvEmprestimo
            // 
            this.dgvEmprestimo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmprestimo.Location = new System.Drawing.Point(12, 173);
            this.dgvEmprestimo.Name = "dgvEmprestimo";
            this.dgvEmprestimo.Size = new System.Drawing.Size(430, 117);
            this.dgvEmprestimo.TabIndex = 4;
            // 
            // lblNomeMidia
            // 
            this.lblNomeMidia.AutoSize = true;
            this.lblNomeMidia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeMidia.Location = new System.Drawing.Point(12, 110);
            this.lblNomeMidia.Name = "lblNomeMidia";
            this.lblNomeMidia.Size = new System.Drawing.Size(103, 16);
            this.lblNomeMidia.TabIndex = 6;
            this.lblNomeMidia.Text = "Nome da Mídia:";
            // 
            // cboNomeMidia
            // 
            this.cboNomeMidia.FormattingEnabled = true;
            this.cboNomeMidia.Location = new System.Drawing.Point(12, 129);
            this.cboNomeMidia.Name = "cboNomeMidia";
            this.cboNomeMidia.Size = new System.Drawing.Size(401, 21);
            this.cboNomeMidia.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(415, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 302);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboNomeMidia);
            this.Controls.Add(this.lblNomeMidia);
            this.Controls.Add(this.dgvEmprestimo);
            this.Controls.Add(this.lblDataEmprestimo);
            this.Controls.Add(this.dtpDataEmprestimo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.cboNomeAmigo);
            this.MaximumSize = new System.Drawing.Size(700, 430);
            this.MinimumSize = new System.Drawing.Size(470, 340);
            this.Name = "frmEmprestimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empréstimo de Discos";
            this.Load += new System.EventHandler(this.frmEmprestimo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboNomeAmigo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DateTimePicker dtpDataEmprestimo;
        private System.Windows.Forms.Label lblDataEmprestimo;
        private System.Windows.Forms.DataGridView dgvEmprestimo;
        private System.Windows.Forms.Label lblNomeMidia;
        private System.Windows.Forms.ComboBox cboNomeMidia;
        private System.Windows.Forms.Button button1;
    }
}