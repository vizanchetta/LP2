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
    public partial class frmExercicio1 : Form
    {
        int x, count;
        public frmExercicio1()
        {
            InitializeComponent();
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            x = 0;
            count = 0;
            while (x < rtxTexto.Text.Length - 1)
            {
                if (rtxTexto.Text[x] == rtxTexto.Text[x + 1])
                    count++;
                x++;
            }
            MessageBox.Show("Existem " + count + " letras seguidas nesse texto");
            
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            count = 0;
            for (x = 0; x < rtxTexto.Text.Length; x++)
            {
                if ((rtxTexto.Text[x] == 'R') || (rtxTexto.Text[x] == 'r'))
                    count++;
            }
            MessageBox.Show("Existem " + count + " ERRES nesse texto");
        }
        private void btnUm_Click(object sender, EventArgs e)
        {
            count = 0;
            for (x=0; x < rtxTexto.Text.Length; x++)
            {
                if (char.IsWhiteSpace(rtxTexto.Text[x]))
                    count++;
            }
            MessageBox.Show("Existem " + count + " espacos brancos nesse texto");
        }
    }
}
