using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade7
{
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnCheca_Click(object sender, EventArgs e)
        {
            string trasFrente = "";
            char[] tras;
            txtPalindromo.Text = txtPalindromo.Text.Replace(" ", "");
            txtB.Text = txtPalindromo.Text;
            txtPalindromo.Text = txtPalindromo.Text.ToUpper();
            txtC.Text = txtPalindromo.Text;
            if (txtPalindromo.Text != "")
            {
                tras = txtPalindromo.Text.ToCharArray();
                Array.Reverse(tras);
                foreach (char c in tras)
                    trasFrente += c;
                txtD.Text = trasFrente;
                if (txtPalindromo.Text == trasFrente)
                    MessageBox.Show("É um palindromo!");
                else
                    MessageBox.Show("Não é um palindromo");
            }
        }
    }
}
