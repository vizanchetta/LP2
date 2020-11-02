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
    public partial class frmExercicio4 : Form
    {
        int x, i;
        public frmExercicio4()
        {
            InitializeComponent();
        }
        private void btnContaNumeros_Click(object sender, EventArgs e)
        {
            x = 0;
            for (i = 0; i <= txtTexto.Text.Length - 1; i++)
            {
                if (Char.IsNumber(txtTexto.Text[i]))
                    x++;
            }
            MessageBox.Show(x.ToString() + " numeros");
        }
        private void btnPrimeiroBranco_Click(object sender, EventArgs e)
        {
            x = 0;
            while (x >= 0)
            {
                if (txtTexto.Text == "")
                {
                    MessageBox.Show("nao pode estar vazio");
                    break;
                }
                if (Char.IsWhiteSpace(txtTexto.Text[x]))
                {
                    MessageBox.Show("A posicao " + x + " da string eh o primeiro espaco em branco");
                    break;
                }
                else
                {
                    if (x < txtTexto.Text.Length - 1)
                    x++;
                }
                MessageBox.Show("nao ha espaco em branco nesse texto nesse texto");
                break;

            }
        }
        private void btnContaLetras_Click(object sender, EventArgs e)
        {
            x = 0;
            foreach(char c in txtTexto.Text)
            {
                if (Char.IsLetter(c))
                    x++;
            }
            MessageBox.Show(x.ToString()+" letras");
        }

        

        
    }
}
