using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SysMusicCollection
{
    public partial class frmPesqMidias : Form
    {
        public frmPesqMidias()
        {
            InitializeComponent();
        }

        private void btnAbaLateral_Click(object sender, EventArgs e)
        {
            if (btnAbaLateral.Text == "<")
            {
                splitContainer1.SplitterDistance = 500;
                btnAbaLateral.Text = ">";
            }
            else
            {
                splitContainer1.SplitterDistance = 700;
                btnAbaLateral.Text = "<";
            }
        }
    }
}
