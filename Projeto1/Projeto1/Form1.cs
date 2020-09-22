using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double raio, altura, volume;

            if ((txtAltura.Text == "") || (txtRaio.Text == ""))
                MessageBox.Show("Faltam valores");
            else
            {
                if (Char.IsDigit(txtAltura.Text, 0) && Char.IsDigit(txtRaio.Text, 0))
                {
                    raio = Int32.Parse(txtRaio.Text);
                    altura = Int32.Parse(txtAltura.Text);
                    volume = 3.14 * (raio * raio) * altura;
                    txtVolume.Text = volume.ToString();
                }
                else
                    MessageBox.Show("Ocorreu um erro na inserção dos dados");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
