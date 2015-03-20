using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racionales
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void ir_a_sumas_Click(object sender, EventArgs e)
        {
            Fsumas frm = new Fsumas();

            frm.Show();
        }

        private void ir_a_calculadora_Click(object sender, EventArgs e)
        {
            Calculadora frm = new Calculadora();

            frm.Show();
        }

        private void ir_a_restas_Click(object sender, EventArgs e)
        {
            Frestas frm = new Frestas();

            frm.Show();
        }

        private void ir_a_multiplicar_Click(object sender, EventArgs e)
        {
            Fmultiplicaciones frm = new Fmultiplicaciones();

            frm.Show();
        }

        private void ir_a_divisiones_Click(object sender, EventArgs e)
        {
            Fdivisiones frm = new Fdivisiones();

            frm.Show();
        }
    }
}
