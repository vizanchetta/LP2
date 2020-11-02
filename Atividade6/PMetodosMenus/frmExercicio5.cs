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
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                Random random = new Random();
                if (random.Next(0, 2) == 0)
                    button1.Text = textBox1.Text + " ganhou";
                else
                    button1.Text = textBox2.Text + " ganhou";
            }

        }

        private void frmExercicio5_Load(object sender, EventArgs e)
        {
            button1.Text = "random";
        }
    }
}
