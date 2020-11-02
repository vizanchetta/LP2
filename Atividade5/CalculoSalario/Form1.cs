using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoSalario
{
    public partial class Form1 : Form
    {
        Int16 filhos;
        double bruto, INSS, IRPF, aliqINSS, aliqIRPF, salFamilia, liquido;
        string informacoes, nome;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnVerifica_Click(object sender, EventArgs e)
        {
            if (ChecaEntradas())
            {
                CalculoINSS();
                CalculoIRPF();
                CalculoSalFamilia();
                PreencheCampos();
            }
        }
        private bool ChecaEntradas()
        {
            if ((double.TryParse(mskbxBruto.Text, out bruto))
                && (Int16.TryParse(mskbxFilhos.Text, out filhos))
                && (txtNome.Text != ""))
                return true;
            MessageBox.Show("Houve algum erro na insercao de valores");
            return false;
        }
        private void CalculoINSS()
        {
            if (bruto < 800.48)
            {
                aliqINSS = 7.65;
                INSS = bruto * 0.0765;
            }
            else if (bruto < 1050.01)
            {
                INSS = bruto * 0.0865;
                aliqINSS = 8.65;
            }
            else if (bruto < 1400.78)
            {
                INSS = bruto * 0.09;
                aliqINSS = 9;
            }
            else if (bruto < 2801.56)
            {
                INSS = bruto * 0.11;
                aliqINSS = 11;
            }
            else
            {
                INSS = 308.17;
                aliqINSS = 00;
            }
        }
        private void CalculoIRPF()
        {
            if (bruto < 1257.12)
            {
                IRPF = 0;
                aliqIRPF = 0;
            }
            if (bruto < 2512.09)
            {
                IRPF = bruto * 0.15;
                aliqIRPF = 15;
            }
            else
            {
                IRPF = bruto * 0.275;
                aliqIRPF = 27.5;
            }
        }
        private void CalculoSalFamilia()
        {
            if ((filhos != 0) && (bruto < 654.61))
            {
                salFamilia = (bruto < 435.32 ? filhos * 22.33 : filhos * 15.74);
            }
        }
        private void PreencheCampos()
        {
            mskbxAliqINSS.Text = aliqINSS.ToString();
            mskbxAliqIRPF.Text = aliqIRPF.ToString();
            mskbxFamilia.Text = salFamilia.ToString();
            mskbxDescINSS.Text = INSS.ToString();
            mskbxDescIRPF.Text = IRPF.ToString();
            liquido = (bruto + salFamilia - INSS - IRPF);
            mskbxLiquido.Text = liquido.ToString();
            nome = txtNome.Text;
            ConstroeString();
            lblTextoResultado.Text = informacoes;
        }
        private void ConstroeString()
        {
            informacoes = "Os descontos do Salário d";
            if ((chkCasado.Checked) && (rdbtnMasc.Checked))
                informacoes += "o senhor "+nome+"\nque é casado ";
            else if ((!chkCasado.Checked) && (rdbtnMasc.Checked))
                informacoes += "o senhor " + nome + "\nque é solteiro ";
            else if ((chkCasado.Checked) && (rdbtnFem.Checked))
                informacoes += "a senhora " + nome + "\nque é casada ";
            else if ((!chkCasado.Checked) && (rdbtnFem.Checked))
                informacoes += "a senhorita " + nome + "\nque é solteira ";
            if (filhos == 0)
                informacoes += "e não possuí filhos é:";
            else
                informacoes += "e possuí " + filhos.ToString() + " filhos é:";
        }
    }
}
