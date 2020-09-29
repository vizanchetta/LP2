using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PesoIdealPessoa
{
    public partial class Form1 : Form
    {
        double altura, peso, ideal;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (checaNumeros())
            { 
                if (rdbtnMasc.Checked)
                    ideal = (72.7 * altura) - 58.0;
                if (rdbtnFem.Checked)
                    ideal = (62.1 * altura) - 44.7;
                if (peso < ideal)
                    MessageBox.Show("Coma muitas massas e doces!");
                if (peso == ideal)
                    MessageBox.Show("Você está no peso ideal!");
                if (peso > ideal)
                    MessageBox.Show("Regime obrigatório ja!");
            }
        }

        private bool checaNumeros()
        {
            if ((double.TryParse(txtAltura.Text, out altura)) && (double.TryParse(txtPeso.Text, out peso)))
                return true;
            else
                MessageBox.Show("Erro na insercao de valores");
            return false;

        }
    }
}
