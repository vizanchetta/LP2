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
    public partial class frmExercicio4 : Form
    {
        double producao, gratificacao, salario, A, B, C, D;

        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnCalculaSalario_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtProducao.Text, out producao) &&
                double.TryParse(txtGratificacao.Text, out gratificacao) &&
                double.TryParse(txtSalario.Text, out salario))
            {
                if ((salario > 7000) && ( (producao < 150) || (gratificacao == 0) ))
                {
                    MessageBox.Show("If salario > 7000, producao tem que ser > 150 e gratificao != 0");
                    return; 
                }
                A = salario;
                if (producao >= 100)
                    B = 1;
                else
                    B = 0;
                if (producao >= 120)
                    C = 1;
                else
                    C = 0;
                if (producao >= 150)
                    D = 1;
                else
                    D = 0;
                A = A + A * (0.5 * B + 0.1 * C + 0.1 * D) + gratificacao;
                txtSalBruto.Text = A.ToString("F");
            }
        }
    }
}
