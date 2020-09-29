using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomaLadosTriangulo
{
    public partial class TRI : Form
    {
        double lado1, lado2, lado3;

        public TRI()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (ChecaNumeros())
             {
                if ((lado1 == lado2) || (lado2 == lado3) || (lado1 == lado3))
                {
                    if ((lado1 == lado2) && (lado2 == lado3))
                        txtTriangulo.Text = "Equilátero";
                    else
                        txtTriangulo.Text = "Isósceles";
                }
                else
                    txtTriangulo.Text = "Escaleno";
             }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool ChecaNumeros()
        {
            if ((double.TryParse(txtLado1.Text, out lado1) && double.TryParse(txtLado2.Text, out lado2)
                && double.TryParse(txtLado3.Text, out lado3)))
            {
                if ((lado1 < lado2 + lado3) && (lado2 < lado1 + lado3) && (lado3 < lado1 + 2))
                    return true;
                else
                {
                    MessageBox.Show("Os valores dos segmentos de retas informados nao formam um triangulo", "ERRO VALORES");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Ocorreu algum erro na inserçao de valores.", "ERRO INSERCAO");
                return false;
            }
        }

    }
}
