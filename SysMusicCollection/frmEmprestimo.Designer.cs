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
            this.CL01 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNomeMidia = new System.Windows.Forms.Label();
            this.cboNomeMidia = new System.Windows.Forms.ComboBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnEmprestar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimo)).BeginInit();
            this.SuspendLayout();
            // 
            // cboNomeAmigo
            // 
            this.cboNomeAmigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboNomeAmigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboNomeAmigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboNomeAmigo.FormattingEnabled = true;
            this.cboNomeAmigo.Location = new System.Drawing.Point(12, 28);
            this.cboNomeAmigo.Name = "cboNomeAmigo";
            this.cboNomeAmigo.Size = new System.Drawing.Size(430, 21);
            this.cboNomeAmigo.TabIndex = 0;
            this.cboNomeAmigo.Leave += new System.EventHandler(this.cboNomeAmigo_Leave);
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
            this.dgvEmprestimo.AllowUserToAddRows = false;
            this.dgvEmprestimo.AllowUserToDeleteRows = false;
            this.dgvEmprestimo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmprestimo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmprestimo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CL01});
            this.dgvEmprestimo.Location = new System.Drawing.Point(12, 188);
            this.dgvEmprestimo.Name = "dgvEmprestimo";
            this.dgvEmprestimo.ReadOnly = true;
            this.dgvEmprestimo.Size = new System.Drawing.Size(430, 117);
            this.dgvEmprestimo.TabIndex = 4;
            // 
            // CL01
            // 
            this.CL01.HeaderText = "Discos Emprestados";
            this.CL01.Name = "CL01";
            this.CL01.ReadOnly = true;
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
            this.cboNomeMidia.Enter += new System.EventHandler(this.cboNomeMidia_Enter);
            this.cboNomeMidia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboNomeMidia_KeyPress);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(415, 127);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(27, 23);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "...";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnEmprestar
            // 
            this.btnEmprestar.Location = new System.Drawing.Point(286, 159);
            this.btnEmprestar.Name = "btnEmprestar";
            this.btnEmprestar.Size = new System.Drawing.Size(75, 23);
            this.btnEmprestar.TabIndex = 9;
            this.btnEmprestar.Text = "Emprestar";
            this.btnEmprestar.UseVisualStyleBackColor = true;
            this.btnEmprestar.Click += new System.EventHandler(this.btnEmprestar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(367, 159);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 317);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEmprestar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.cboNomeMidia);
            this.Controls.Add(this.lblNomeMidia);
            this.Controls.Add(this.dgvEmprestimo);
            this.Controls.Add(this.lblDataEmprestimo);
            this.Controls.Add(this.dtpDataEmprestimo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.cboNomeAmigo);
            this.MaximumSize = new System.Drawing.Size(700, 430);
            this.MinimumSize = new System.Drawing.Size(470, 355);
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
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnEmprestar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CL01;
    }
}