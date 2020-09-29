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
            

            if ((txtAltura.Text == "") || (txtRaio.Text == ""))
                MessageBox.Show("Faltam valores");
            else
            {
                double raio, volume, altura;
                raio = 0;
                volume = 0;
                altura = 0;


                if (Double.IsNaN(Double.Parse(txtAltura.Text)) && (Double.IsNaN(Double.Parse(txtRaio.Text))))
                {
                    MessageBox.Show("Ocorreu um erro.");
                }
                else
                    raio = Double.Parse(txtRaio.Text);
                    altura = Double.Parse(txtAltura.Text);
                    volume = 3.14 * (raio * raio) * altura;
                    txtVolume.Text = (volume.ToString("F"));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
