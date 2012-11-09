﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SysMusicCollection
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }
        public void DetectaErro()
        {
            foreach (Control tex in this.tbpDiscos.Controls )
            {
                if (tex is TextBox)
                {
                    TextBox t = (TextBox)tex;
                    if (t.Text != "")
                    {
                        if (MessageBox.Show("Campo(s) Preenchido(s), deseja sair:", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            this.Close();
                        }
                    }
                    
                }
            }

            //if (comboBox1.SelectedItem == null)
            //    errorProvider1.SetError(comboBox1, "Digite o(s) Campo(s) Vazio(s)");
            //else
            //    errorProvider1.SetError(comboBox1, "");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            cboMidia.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DetectaErro();
        }

       
    }
}
