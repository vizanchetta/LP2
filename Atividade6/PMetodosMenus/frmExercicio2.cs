using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMetodosMenus
{
    public partial class frmExercicio2 : Form
    {
        Int32 meio = 0;
        string compara, primeira, segunda;

        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnIguais_Click(object sender, EventArgs e)
        {
            compara = (String.Compare(txtPalavra1.Text, txtPalavra2.Text, true) == 0 ? "Ahibaa" : "São diferentes");
            MessageBox.Show(compara);
        }

        private void btnInserePala1_Click(object sender, EventArgs e)
        {
            meio = (txtPalavra2.Text.Length / 2);
            txtPalavra2.Text = txtPalavra2.Text.Substring(0, meio) + txtPalavra1.Text +
                txtPalavra2.Text.Substring(meio, txtPalavra2.Text.Length-meio);
        }
        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            meio = txtPalavra1.Text.Length / 2;
            txtPalavra2.Text = txtPalavra1.Text.Insert(meio, "**");
        }
    }
}
