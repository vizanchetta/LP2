using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int checaNumeros()
        {
            double numero1;
            double numero2;
            if ((double.TryParse(txtValor1.Text, out numero1) && double.TryParse(txtValor1.Text, out numero2)))
                return 0;
            else
                return 1;
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor1.Text = "";
            txtValor2.Text = "";
            txtResult.Text = "";
        }
        private void btnSoma_Click(object sender, EventArgs e)
        {
            if (checaNumeros() == 1)
                MessageBox.Show("Houve algum erro na introdução dos valores");
            else
            {
                double result;
                result = Double.Parse(txtValor1.Text) + Double.Parse(txtValor2.Text);
                txtResult.Text = result.ToString();
            }
        }
        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (checaNumeros() == 1)
                MessageBox.Show("Houve algum erro na introdução dos valores");
            else
            {
                double result;
                result = Double.Parse(txtValor1.Text) - Double.Parse(txtValor2.Text);
                txtResult.Text = result.ToString();
            }
        }
        private void btnMultip_Click(object sender, EventArgs e)
        {
            if (checaNumeros() == 1)
                MessageBox.Show("Houve algum erro na introdução dos valores");
            else
            {
                double result;
                result = Double.Parse(txtValor1.Text) * Double.Parse(txtValor2.Text);
                txtResult.Text = result.ToString();
            }
        }
        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if ((checaNumeros() == 1) || (double.Parse(txtValor2.Text) == 0))
                MessageBox.Show("Houve algum erro na introdução dos valores");
            else
            {
                double result;
                result = Double.Parse(txtValor1.Text) / Double.Parse(txtValor2.Text);
                txtResult.Text = result.ToString();
            }
        }
    }
}
