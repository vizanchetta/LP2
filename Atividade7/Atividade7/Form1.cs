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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms[""];
            if (fc != null)
            {
                fc.Close();
            }
            frmExercicio1 frmExercicio1 = new frmExercicio1();
            frmExercicio1.MdiParent = this;
            frmExercicio1.WindowState = FormWindowState.Maximized;
            frmExercicio1.Show();
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms[""];
            if (fc != null)
            {
                fc.Close();
            }
            frmExercicio2 frmExercicio2 = new frmExercicio2();
            frmExercicio2.MdiParent = this;
            frmExercicio2.WindowState = FormWindowState.Maximized;
            frmExercicio2.Show();
        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms[""];
            if (fc != null)
            {
                fc.Close();
            }
            frmExercicio3 frmExercicio3 = new frmExercicio3();
            frmExercicio3.MdiParent = this;
            frmExercicio3.WindowState = FormWindowState.Maximized;
            frmExercicio3.Show();
        }

        private void form4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms[""];
            if (fc != null)
            {
                fc.Close();
            }
            frmExercicio4 frmExercicio4 = new frmExercicio4();
            frmExercicio4.MdiParent = this;
            frmExercicio4.WindowState = FormWindowState.Maximized;
            frmExercicio4.Show();
        }
    }
}
