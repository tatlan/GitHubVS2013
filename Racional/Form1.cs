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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt16(textBox1.Text);
            int d1 = Convert.ToInt16(textBox2.Text);
            int n2 = Convert.ToInt16(textBox3.Text);
            int d2 = Convert.ToInt16(textBox4.Text);

            Racional r1 = new Racional(n1, d1);
            Racional r2 = new Racional(n2, d2);
            Racional producto = r1.multiplicar(r2);
            textBox5.Text = producto.getNumerador().ToString();
            textBox6.Text = producto.getDenominador().ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dividir_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt16(textBox1.Text);
            int d1 = Convert.ToInt16(textBox2.Text);
            int n2 = Convert.ToInt16(textBox3.Text);
            int d2 = Convert.ToInt16(textBox4.Text);
            Racional r1 = new Racional(n1, d1);
            Racional r2 = new Racional(n2, d2);
            Racional division = r1.dividir(r2);
            textBox5.Text = division.getNumerador().ToString();
            textBox6.Text = division.getDenominador().ToString();
        }

        private void equivalencia_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt16(textBox1.Text);
            int d1 = Convert.ToInt16(textBox2.Text);
            int n2 = Convert.ToInt16(textBox3.Text);
            int d2 = Convert.ToInt16(textBox4.Text);
            Racional r1 = new Racional(n1, d1);
            Racional r2 = new Racional(n2, d2);
            string equivalente = r1.equivalencia(r2);
            textBox7.Text = equivalente;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Fsumas frm = new Fsumas();

            frm.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt16(textBox1.Text);
            int d1 = Convert.ToInt16(textBox2.Text);
            int n2 = Convert.ToInt16(textBox3.Text);
            int d2 = Convert.ToInt16(textBox4.Text);

            Racional r1 = new Racional(n1, d1);
            Racional r2 = new Racional(n2, d2);
            Racional producto = r1.sumar(r2);
            textBox5.Text = producto.getNumerador().ToString();
            textBox6.Text = producto.getDenominador().ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void sumasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fsumas frm = new Fsumas();

            frm.Show();
        }

        

  

    



    

        
    }
}
