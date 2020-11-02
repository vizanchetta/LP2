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
    public partial class frmExercicio3 : Form
    {
        int index   ;
        char[] tras;
        
       
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnInserePala1_Click(object sender, EventArgs e)
        {
            if (txtPalavra1.Text != "" && txtPalavra2.Text != "")
                txtPalavra2.Text = txtPalavra2.Text.Replace(txtPalavra1.Text, "");
        }

        private void btnTrasPraFrente_Click(object sender, EventArgs e)
        {
            string trasFrente = "";
            char[] tras;
            if (txtPalavra1.Text != "")
            {
                tras = txtPalavra1.Text.ToCharArray();
                Array.Reverse(tras);
                foreach (char c in tras)
                    trasFrente += c;
                txtPalavra2.Text = trasFrente;
                
            }
        }

        private void btnIndexOfSubstringLength_Click(object sender, EventArgs e)
        {
            if (txtPalavra1.Text != "" && txtPalavra2.Text != "")
            {
                index = txtPalavra2.Text.IndexOf(txtPalavra1.Text);
                while (index >= 0)
                {
                    txtPalavra2.Text = txtPalavra2.Text.Substring(0, index) +
                        txtPalavra2.Text.Substring(index + txtPalavra1.Text.Length,
                        txtPalavra2.Text.Length - txtPalavra1.Text.Length - index);
                    index = txtPalavra2.Text.IndexOf(txtPalavra1.Text);
                }
            }
        }
    }
}
