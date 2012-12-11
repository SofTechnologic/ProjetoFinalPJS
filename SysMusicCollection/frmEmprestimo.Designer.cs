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
            this.tbcEmprestimo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEmprestar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cboNomeMidia = new System.Windows.Forms.ComboBox();
            this.lblNomeMidia = new System.Windows.Forms.Label();
            this.dgvEmprestimo = new System.Windows.Forms.DataGridView();
            this.CL01 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDataEmprestimo = new System.Windows.Forms.Label();
            this.dtpDataEmprestimo = new System.Windows.Forms.DateTimePicker();
            this.lblNome = new System.Windows.Forms.Label();
            this.cboNomeAmigo = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbldtDevolucao = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.dgvDevolucao = new System.Windows.Forms.DataGridView();
            this.CL1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cboDevolver = new System.Windows.Forms.ComboBox();
            this.ckbMidias = new System.Windows.Forms.CheckBox();
            this.ckbAmigos = new System.Windows.Forms.CheckBox();
            this.tbcEmprestimo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimo)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucao)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcEmprestimo
            // 
            this.tbcEmprestimo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcEmprestimo.Controls.Add(this.tabPage1);
            this.tbcEmprestimo.Controls.Add(this.tabPage2);
            this.tbcEmprestimo.Location = new System.Drawing.Point(12, 12);
            this.tbcEmprestimo.Name = "tbcEmprestimo";
            this.tbcEmprestimo.SelectedIndex = 0;
            this.tbcEmprestimo.Size = new System.Drawing.Size(453, 335);
            this.tbcEmprestimo.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage1.Controls.Add(this.btnCancelar);
            this.tabPage1.Controls.Add(this.btnEmprestar);
            this.tabPage1.Controls.Add(this.btnPesquisar);
            this.tabPage1.Controls.Add(this.cboNomeMidia);
            this.tabPage1.Controls.Add(this.lblNomeMidia);
            this.tabPage1.Controls.Add(this.dgvEmprestimo);
            this.tabPage1.Controls.Add(this.lblDataEmprestimo);
            this.tabPage1.Controls.Add(this.dtpDataEmprestimo);
            this.tabPage1.Controls.Add(this.lblNome);
            this.tabPage1.Controls.Add(this.cboNomeAmigo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(445, 309);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Empréstimo";
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(364, 280);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEmprestar
            // 
            this.btnEmprestar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEmprestar.Location = new System.Drawing.Point(283, 280);
            this.btnEmprestar.Name = "btnEmprestar";
            this.btnEmprestar.Size = new System.Drawing.Size(75, 23);
            this.btnEmprestar.TabIndex = 19;
            this.btnEmprestar.Text = "Emprestar";
            this.btnEmprestar.UseVisualStyleBackColor = true;
            this.btnEmprestar.Click += new System.EventHandler(this.btnEmprestar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.Location = new System.Drawing.Point(409, 121);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(27, 23);
            this.btnPesquisar.TabIndex = 18;
            this.btnPesquisar.Text = "...";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // cboNomeMidia
            // 
            this.cboNomeMidia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboNomeMidia.FormattingEnabled = true;
            this.cboNomeMidia.Location = new System.Drawing.Point(6, 123);
            this.cboNomeMidia.Name = "cboNomeMidia";
            this.cboNomeMidia.Size = new System.Drawing.Size(401, 21);
            this.cboNomeMidia.TabIndex = 17;
            this.cboNomeMidia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboNomeMidia_KeyPress);
            // 
            // lblNomeMidia
            // 
            this.lblNomeMidia.AutoSize = true;
            this.lblNomeMidia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeMidia.Location = new System.Drawing.Point(6, 104);
            this.lblNomeMidia.Name = "lblNomeMidia";
            this.lblNomeMidia.Size = new System.Drawing.Size(103, 16);
            this.lblNomeMidia.TabIndex = 16;
            this.lblNomeMidia.Text = "Nome da Mídia:";
            // 
            // dgvEmprestimo
            // 
            this.dgvEmprestimo.AllowUserToAddRows = false;
            this.dgvEmprestimo.AllowUserToDeleteRows = false;
            this.dgvEmprestimo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmprestimo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmprestimo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmprestimo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CL01});
            this.dgvEmprestimo.Location = new System.Drawing.Point(6, 150);
            this.dgvEmprestimo.Name = "dgvEmprestimo";
            this.dgvEmprestimo.ReadOnly = true;
            this.dgvEmprestimo.Size = new System.Drawing.Size(430, 124);
            this.dgvEmprestimo.TabIndex = 15;
            // 
            // CL01
            // 
            this.CL01.HeaderText = "Discos Emprestados";
            this.CL01.Name = "CL01";
            this.CL01.ReadOnly = true;
            // 
            // lblDataEmprestimo
            // 
            this.lblDataEmprestimo.AutoSize = true;
            this.lblDataEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEmprestimo.Location = new System.Drawing.Point(6, 54);
            this.lblDataEmprestimo.Name = "lblDataEmprestimo";
            this.lblDataEmprestimo.Size = new System.Drawing.Size(134, 16);
            this.lblDataEmprestimo.TabIndex = 14;
            this.lblDataEmprestimo.Text = "Data do Empréstimo:";
            // 
            // dtpDataEmprestimo
            // 
            this.dtpDataEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataEmprestimo.Location = new System.Drawing.Point(6, 73);
            this.dtpDataEmprestimo.Name = "dtpDataEmprestimo";
            this.dtpDataEmprestimo.Size = new System.Drawing.Size(278, 22);
            this.dtpDataEmprestimo.TabIndex = 13;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(6, 3);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(109, 16);
            this.lblNome.TabIndex = 12;
            this.lblNome.Text = "Nome do Amigo:";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboNomeAmigo
            // 
            this.cboNomeAmigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboNomeAmigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboNomeAmigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboNomeAmigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboNomeAmigo.FormattingEnabled = true;
            this.cboNomeAmigo.Location = new System.Drawing.Point(6, 22);
            this.cboNomeAmigo.Name = "cboNomeAmigo";
            this.cboNomeAmigo.Size = new System.Drawing.Size(430, 21);
            this.cboNomeAmigo.TabIndex = 11;
            this.cboNomeAmigo.Leave += new System.EventHandler(this.cboNomeAmigo_Leave);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage2.Controls.Add(this.lbldtDevolucao);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.btnLimpar);
            this.tabPage2.Controls.Add(this.btnDevolver);
            this.tabPage2.Controls.Add(this.dgvDevolucao);
            this.tabPage2.Controls.Add(this.cboDevolver);
            this.tabPage2.Controls.Add(this.ckbMidias);
            this.tabPage2.Controls.Add(this.ckbAmigos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(445, 309);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Devolução";
            // 
            // lbldtDevolucao
            // 
            this.lbldtDevolucao.AutoSize = true;
            this.lbldtDevolucao.Location = new System.Drawing.Point(6, 74);
            this.lbldtDevolucao.Name = "lbldtDevolucao";
            this.lbldtDevolucao.Size = new System.Drawing.Size(103, 13);
            this.lbldtDevolucao.TabIndex = 7;
            this.lbldtDevolucao.Text = "Data de Devolução:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 90);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(315, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.Location = new System.Drawing.Point(364, 280);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnDevolver
            // 
            this.btnDevolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDevolver.Location = new System.Drawing.Point(283, 280);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(75, 23);
            this.btnDevolver.TabIndex = 4;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // dgvDevolucao
            // 
            this.dgvDevolucao.AllowUserToAddRows = false;
            this.dgvDevolucao.AllowUserToDeleteRows = false;
            this.dgvDevolucao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDevolucao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevolucao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CL1});
            this.dgvDevolucao.Location = new System.Drawing.Point(6, 116);
            this.dgvDevolucao.Name = "dgvDevolucao";
            this.dgvDevolucao.Size = new System.Drawing.Size(433, 158);
            this.dgvDevolucao.TabIndex = 3;
            // 
            // CL1
            // 
            this.CL1.HeaderText = "Devolver";
            this.CL1.Name = "CL1";
            this.CL1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CL1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cboDevolver
            // 
            this.cboDevolver.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDevolver.FormattingEnabled = true;
            this.cboDevolver.Location = new System.Drawing.Point(6, 50);
            this.cboDevolver.Name = "cboDevolver";
            this.cboDevolver.Size = new System.Drawing.Size(433, 21);
            this.cboDevolver.TabIndex = 2;
            this.cboDevolver.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboDevolver_KeyPress);
            // 
            // ckbMidias
            // 
            this.ckbMidias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbMidias.AutoSize = true;
            this.ckbMidias.Location = new System.Drawing.Point(217, 27);
            this.ckbMidias.Name = "ckbMidias";
            this.ckbMidias.Size = new System.Drawing.Size(56, 17);
            this.ckbMidias.TabIndex = 1;
            this.ckbMidias.Text = "Midias";
            this.ckbMidias.UseVisualStyleBackColor = true;
            this.ckbMidias.CheckedChanged += new System.EventHandler(this.ckbMidias_CheckedChanged);
            // 
            // ckbAmigos
            // 
            this.ckbAmigos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbAmigos.AutoSize = true;
            this.ckbAmigos.Location = new System.Drawing.Point(131, 27);
            this.ckbAmigos.Name = "ckbAmigos";
            this.ckbAmigos.Size = new System.Drawing.Size(60, 17);
            this.ckbAmigos.TabIndex = 0;
            this.ckbAmigos.Text = "Amigos";
            this.ckbAmigos.UseVisualStyleBackColor = true;
            this.ckbAmigos.CheckedChanged += new System.EventHandler(this.ckbAmigos_CheckedChanged);
            // 
            // frmEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(472, 351);
            this.Controls.Add(this.tbcEmprestimo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximumSize = new System.Drawing.Size(700, 430);
            this.MinimumSize = new System.Drawing.Size(470, 355);
            this.Name = "frmEmprestimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empréstimo de Discos";
            this.Load += new System.EventHandler(this.frmEmprestimo_Load);
            this.tbcEmprestimo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimo)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcEmprestimo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEmprestar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ComboBox cboNomeMidia;
        private System.Windows.Forms.Label lblNomeMidia;
        private System.Windows.Forms.DataGridView dgvEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CL01;
        private System.Windows.Forms.Label lblDataEmprestimo;
        private System.Windows.Forms.DateTimePicker dtpDataEmprestimo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ComboBox cboNomeAmigo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.DataGridView dgvDevolucao;
        private System.Windows.Forms.ComboBox cboDevolver;
        private System.Windows.Forms.CheckBox ckbMidias;
        private System.Windows.Forms.CheckBox ckbAmigos;
        private System.Windows.Forms.Label lbldtDevolucao;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CL1;

    }
}