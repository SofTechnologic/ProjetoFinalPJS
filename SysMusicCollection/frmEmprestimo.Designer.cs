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
            this.btn_OK = new System.Windows.Forms.Button();
            this.lbldtDevolucao = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar2 = new System.Windows.Forms.Button();
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
            this.tbcEmprestimo.Controls.Add(this.tabPage1);
            this.tbcEmprestimo.Controls.Add(this.tabPage2);
            this.tbcEmprestimo.Location = new System.Drawing.Point(16, 15);
            this.tbcEmprestimo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbcEmprestimo.Name = "tbcEmprestimo";
            this.tbcEmprestimo.SelectedIndex = 0;
            this.tbcEmprestimo.Size = new System.Drawing.Size(604, 412);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(596, 383);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Empréstimo";
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(485, 345);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEmprestar
            // 
            this.btnEmprestar.Location = new System.Drawing.Point(377, 345);
            this.btnEmprestar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEmprestar.Name = "btnEmprestar";
            this.btnEmprestar.Size = new System.Drawing.Size(100, 28);
            this.btnEmprestar.TabIndex = 19;
            this.btnEmprestar.Text = "Emprestar";
            this.btnEmprestar.UseVisualStyleBackColor = true;
            this.btnEmprestar.Click += new System.EventHandler(this.btnEmprestar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(537, 151);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(48, 28);
            this.btnPesquisar.TabIndex = 18;
            this.btnPesquisar.Text = "OK";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click_1);
            // 
            // cboNomeMidia
            // 
            this.cboNomeMidia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboNomeMidia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboNomeMidia.FormattingEnabled = true;
            this.cboNomeMidia.Location = new System.Drawing.Point(8, 151);
            this.cboNomeMidia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboNomeMidia.Name = "cboNomeMidia";
            this.cboNomeMidia.Size = new System.Drawing.Size(524, 24);
            this.cboNomeMidia.TabIndex = 17;
            this.cboNomeMidia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboNomeMidia_KeyPress);
            this.cboNomeMidia.Leave += new System.EventHandler(this.cboNomeMidia_Leave);
            // 
            // lblNomeMidia
            // 
            this.lblNomeMidia.AutoSize = true;
            this.lblNomeMidia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeMidia.Location = new System.Drawing.Point(8, 128);
            this.lblNomeMidia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeMidia.Name = "lblNomeMidia";
            this.lblNomeMidia.Size = new System.Drawing.Size(126, 20);
            this.lblNomeMidia.TabIndex = 16;
            this.lblNomeMidia.Text = "Nome da Mídia:";
            // 
            // dgvEmprestimo
            // 
            this.dgvEmprestimo.AllowUserToAddRows = false;
            this.dgvEmprestimo.AllowUserToDeleteRows = false;
            this.dgvEmprestimo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmprestimo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmprestimo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CL01});
            this.dgvEmprestimo.Location = new System.Drawing.Point(8, 185);
            this.dgvEmprestimo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvEmprestimo.Name = "dgvEmprestimo";
            this.dgvEmprestimo.ReadOnly = true;
            this.dgvEmprestimo.Size = new System.Drawing.Size(573, 153);
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
            this.lblDataEmprestimo.Location = new System.Drawing.Point(8, 66);
            this.lblDataEmprestimo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataEmprestimo.Name = "lblDataEmprestimo";
            this.lblDataEmprestimo.Size = new System.Drawing.Size(168, 20);
            this.lblDataEmprestimo.TabIndex = 14;
            this.lblDataEmprestimo.Text = "Data do Empréstimo:";
            // 
            // dtpDataEmprestimo
            // 
            this.dtpDataEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataEmprestimo.Location = new System.Drawing.Point(8, 90);
            this.dtpDataEmprestimo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDataEmprestimo.Name = "dtpDataEmprestimo";
            this.dtpDataEmprestimo.Size = new System.Drawing.Size(369, 26);
            this.dtpDataEmprestimo.TabIndex = 13;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(8, 4);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(133, 20);
            this.lblNome.TabIndex = 12;
            this.lblNome.Text = "Nome do Amigo:";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboNomeAmigo
            // 
            this.cboNomeAmigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboNomeAmigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboNomeAmigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboNomeAmigo.FormattingEnabled = true;
            this.cboNomeAmigo.Location = new System.Drawing.Point(8, 27);
            this.cboNomeAmigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboNomeAmigo.Name = "cboNomeAmigo";
            this.cboNomeAmigo.Size = new System.Drawing.Size(572, 25);
            this.cboNomeAmigo.TabIndex = 11;
            this.cboNomeAmigo.Leave += new System.EventHandler(this.cboNomeAmigo_Leave);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage2.Controls.Add(this.btn_OK);
            this.tabPage2.Controls.Add(this.lbldtDevolucao);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.btnCancelar2);
            this.tabPage2.Controls.Add(this.btnDevolver);
            this.tabPage2.Controls.Add(this.dgvDevolucao);
            this.tabPage2.Controls.Add(this.cboDevolver);
            this.tabPage2.Controls.Add(this.ckbMidias);
            this.tabPage2.Controls.Add(this.ckbAmigos);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(596, 383);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Devolução";
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(533, 62);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(52, 28);
            this.btn_OK.TabIndex = 8;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lbldtDevolucao
            // 
            this.lbldtDevolucao.AutoSize = true;
            this.lbldtDevolucao.Location = new System.Drawing.Point(8, 91);
            this.lbldtDevolucao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldtDevolucao.Name = "lbldtDevolucao";
            this.lbldtDevolucao.Size = new System.Drawing.Size(133, 17);
            this.lbldtDevolucao.TabIndex = 7;
            this.lbldtDevolucao.Text = "Data de Devolução:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(8, 111);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(419, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // btnCancelar2
            // 
            this.btnCancelar2.Location = new System.Drawing.Point(485, 345);
            this.btnCancelar2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar2.Name = "btnCancelar2";
            this.btnCancelar2.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar2.TabIndex = 5;
            this.btnCancelar2.Text = "Cancelar";
            this.btnCancelar2.UseVisualStyleBackColor = true;
            this.btnCancelar2.Click += new System.EventHandler(this.btnCancelar2_Click);
            // 
            // btnDevolver
            // 
            this.btnDevolver.Location = new System.Drawing.Point(377, 345);
            this.btnDevolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(100, 28);
            this.btnDevolver.TabIndex = 4;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // dgvDevolucao
            // 
            this.dgvDevolucao.AllowUserToAddRows = false;
            this.dgvDevolucao.AllowUserToDeleteRows = false;
            this.dgvDevolucao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevolucao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CL1});
            this.dgvDevolucao.Location = new System.Drawing.Point(8, 143);
            this.dgvDevolucao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDevolucao.Name = "dgvDevolucao";
            this.dgvDevolucao.Size = new System.Drawing.Size(577, 194);
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
            this.cboDevolver.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboDevolver.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboDevolver.FormattingEnabled = true;
            this.cboDevolver.Location = new System.Drawing.Point(8, 62);
            this.cboDevolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboDevolver.Name = "cboDevolver";
            this.cboDevolver.Size = new System.Drawing.Size(516, 24);
            this.cboDevolver.TabIndex = 2;
            this.cboDevolver.TabStop = false;
            this.cboDevolver.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboDevolver_KeyPress);
            this.cboDevolver.Leave += new System.EventHandler(this.cboDevolver_Leave);
            // 
            // ckbMidias
            // 
            this.ckbMidias.AutoSize = true;
            this.ckbMidias.Location = new System.Drawing.Point(289, 33);
            this.ckbMidias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbMidias.Name = "ckbMidias";
            this.ckbMidias.Size = new System.Drawing.Size(70, 21);
            this.ckbMidias.TabIndex = 1;
            this.ckbMidias.Text = "Midias";
            this.ckbMidias.UseVisualStyleBackColor = true;
            this.ckbMidias.CheckedChanged += new System.EventHandler(this.ckbMidias_CheckedChanged);
            // 
            // ckbAmigos
            // 
            this.ckbAmigos.AutoSize = true;
            this.ckbAmigos.Location = new System.Drawing.Point(175, 33);
            this.ckbAmigos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbAmigos.Name = "ckbAmigos";
            this.ckbAmigos.Size = new System.Drawing.Size(76, 21);
            this.ckbAmigos.TabIndex = 0;
            this.ckbAmigos.Text = "Amigos";
            this.ckbAmigos.UseVisualStyleBackColor = true;
            this.ckbAmigos.CheckedChanged += new System.EventHandler(this.ckbAmigos_CheckedChanged);
            // 
            // frmEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(629, 432);
            this.Controls.Add(this.tbcEmprestimo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(927, 519);
            this.MinimumSize = new System.Drawing.Size(621, 427);
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
        private System.Windows.Forms.Button btnCancelar2;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.DataGridView dgvDevolucao;
        private System.Windows.Forms.ComboBox cboDevolver;
        private System.Windows.Forms.CheckBox ckbMidias;
        private System.Windows.Forms.CheckBox ckbAmigos;
        private System.Windows.Forms.Label lbldtDevolucao;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CL1;
        private System.Windows.Forms.Button btn_OK;

    }
}