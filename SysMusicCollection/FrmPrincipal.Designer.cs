﻿namespace SysMusicCollection
{
    partial class frmPrincipal
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
            this.mnsPrincipal = new System.Windows.Forms.MenuStrip();
            this.stsPrincipal = new System.Windows.Forms.StatusStrip();
            this.spcPrincipal = new System.Windows.Forms.SplitContainer();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnEmprDev = new System.Windows.Forms.Button();
            this.tltPrincipal = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.spcPrincipal)).BeginInit();
            this.spcPrincipal.Panel1.SuspendLayout();
            this.spcPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsPrincipal
            // 
            this.mnsPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnsPrincipal.Name = "mnsPrincipal";
            this.mnsPrincipal.Size = new System.Drawing.Size(734, 24);
            this.mnsPrincipal.TabIndex = 0;
            this.mnsPrincipal.Text = "menuStrip1";
            // 
            // stsPrincipal
            // 
            this.stsPrincipal.Location = new System.Drawing.Point(0, 440);
            this.stsPrincipal.Name = "stsPrincipal";
            this.stsPrincipal.Size = new System.Drawing.Size(734, 22);
            this.stsPrincipal.TabIndex = 1;
            this.stsPrincipal.Text = "statusStrip1";
            // 
            // spcPrincipal
            // 
            this.spcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcPrincipal.Location = new System.Drawing.Point(0, 24);
            this.spcPrincipal.Name = "spcPrincipal";
            // 
            // spcPrincipal.Panel1
            // 
            this.spcPrincipal.Panel1.Controls.Add(this.btnEmprDev);
            this.spcPrincipal.Panel1.Controls.Add(this.btnCadastro);
            this.spcPrincipal.Size = new System.Drawing.Size(734, 416);
            this.spcPrincipal.SplitterDistance = 194;
            this.spcPrincipal.TabIndex = 2;
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(38, 123);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(120, 40);
            this.btnCadastro.TabIndex = 0;
            this.btnCadastro.Tag = "";
            this.btnCadastro.Text = "Cadastrar";
            this.tltPrincipal.SetToolTip(this.btnCadastro, "Cadastrar acervo ou amigos");
            this.btnCadastro.UseVisualStyleBackColor = true;
            // 
            // btnEmprDev
            // 
            this.btnEmprDev.Location = new System.Drawing.Point(38, 169);
            this.btnEmprDev.Name = "btnEmprDev";
            this.btnEmprDev.Size = new System.Drawing.Size(120, 40);
            this.btnEmprDev.TabIndex = 1;
            this.btnEmprDev.Text = "Emprestar / Devolver";
            this.tltPrincipal.SetToolTip(this.btnEmprDev, "Emprestar ou devolver mídias");
            this.btnEmprDev.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.spcPrincipal);
            this.Controls.Add(this.stsPrincipal);
            this.Controls.Add(this.mnsPrincipal);
            this.MainMenuStrip = this.mnsPrincipal;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sys Music Collection";
            this.spcPrincipal.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcPrincipal)).EndInit();
            this.spcPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsPrincipal;
        private System.Windows.Forms.StatusStrip stsPrincipal;
        private System.Windows.Forms.SplitContainer spcPrincipal;
        private System.Windows.Forms.Button btnEmprDev;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.ToolTip tltPrincipal;


    }
}
