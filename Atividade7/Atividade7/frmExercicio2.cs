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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double N, H, x;
            if (double.TryParse(txtEntraN.Text, out N))
            {
                H = 1;
                for (x=2; x <= N; x++)
                {
                    H += 1 / x; 
                }
                MessageBox.Show(H.ToString());
            }
        }
    }
}
