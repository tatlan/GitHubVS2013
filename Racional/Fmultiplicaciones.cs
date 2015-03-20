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
    public partial class Fmultiplicaciones : Form
    {
        public Fmultiplicaciones()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cuentaaciertos.Text = "0";
            cuentafallos.Text = "0";
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
            int n3 = Convert.ToInt16(respuestanumerador1.Text);
            int d3 = Convert.ToInt16(respuestadenominador1.Text);

            Racional r1 = new Racional(n1, d1);
            Racional r2 = new Racional(n2, d2);
            Racional multiplica = r1.multiplicar(r2);
            Racional r3 = new Racional(n3,d3);
            resultadonumerador2.Text = multiplica.getNumerador().ToString();
            resultadodenominador2.Text = multiplica.getDenominador().ToString();

            if (r3.equivalencia(multiplica)==true){
                int aciertos = Convert.ToInt16(cuentaaciertos.Text) + 1;
                cuentaaciertos.Text=aciertos.ToString();
                
                
            }
            else if (r3.equivalencia(multiplica)==false){
                int fallos = Convert.ToInt16(cuentafallos.Text) + 1;
                cuentafallos.Text = fallos.ToString();
            }
        }
    }
}
