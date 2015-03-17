using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Racionales.Model;

namespace Racionales
{
    public partial class Fsumas : Form
    {
        public Fsumas()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultadonumerador2.Text = "";
            resultadodenominador2.Text = "";
            respuestanumerador1.Text = "";
            respuestadenominador1.Text = "";
            Random r = new Random();
            int aleatorionumerador1 = r.Next(1, 9);
            int aleatoriodenominador1 = r.Next(1, 9);
            int aleatorionumerador2 = r.Next(1, 9);
            int aleatoriodenominador2 = r.Next(1, 9);

            numerador1.Text = aleatorionumerador1.ToString();
            denominador1.Text = aleatoriodenominador1.ToString();
            numerador2.Text = aleatorionumerador2.ToString();
            denominador2.Text = aleatoriodenominador2.ToString();
        }

        private void comprobacion_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt16(numerador1.Text);
            int d1 = Convert.ToInt16(denominador1.Text);
            int n2 = Convert.ToInt16(numerador2.Text);
            int d2 = Convert.ToInt16(denominador2.Text);

            Racional r1 = new Racional(n1, d1);
            Racional r2 = new Racional(n2, d2);
            Racional suma = r1.sumar(r2);
            resultadonumerador2.Text = suma.getNumerador().ToString();
            resultadodenominador2.Text = suma.getDenominador().ToString();
        }
    }
}
