using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Racionales.Model
{
    class Racional
    {
        private int numerador;
        private int denominador;


        public Racional(int numerador, int denominador) {
            this.numerador = numerador;
            this.denominador = denominador;
        
        }
        public int getNumerador()
        {
            return this.numerador;
        }

        public void setNumerador(int numerador)
        {
            this.numerador = numerador;
        }

        public int getDenominador()
        {
            return this.denominador;
        }

        public void setDenominador(int denominador)
        {
            if (denominador == 0)
            {
                throw new Exception("Forbidden value");
            }
            this.denominador = denominador;
        }

        public Racional sumar(Racional r)
        {
            int denominador1 = this.denominador;
            int denominador2 = r.getDenominador();
            if (denominador1 == denominador2)
            {
                int numerador3 = this.numerador + r.getNumerador();
                int denominador3 = this.denominador;
                return new Racional(numerador3, denominador3);

            }
            int numerador = this.numerador * r.getDenominador()+this.denominador * r.getNumerador();
            int denominador = this.denominador * r.getDenominador();
            return new Racional(numerador, denominador);
        }

        public Racional restar(Racional r)
        {
            int denominador1 = this.denominador;
            int denominador2 = r.getDenominador();
            if (denominador1 == denominador2)
            {
                int numerador3 = this.numerador - r.getNumerador();
                int denominador3 = this.denominador;
                return new Racional(numerador3, denominador3);

            }
            int numerador = this.numerador * r.getDenominador() - this.denominador * r.getNumerador();
            int denominador = this.denominador * r.getDenominador();
            return new Racional(numerador, denominador);
        }
        
        public Racional multiplicar(Racional r)
        {
            int numerador   = this.numerador * r.getNumerador();
            int denominador = this.denominador * r.getDenominador();
            return new Racional(numerador, denominador);
        }
        
        
        public Racional dividir(Racional r)
        {
            int numerador = this.numerador * r.getDenominador();
            int denominador = this.denominador * r.getNumerador();
            return new Racional(numerador, denominador);

            /*this.setNumerador(this.numerador * r.getDenominador());
            this.setDenominador(this.denominador * r.getNumerador());
            return new Racional(this.numerador, this.denominador);*/

        }
        public Boolean equivalencia(Racional r)
        {
            int numerador = this.numerador * r.getDenominador();
            int denominador = this.denominador * r.getNumerador();
            if (numerador == denominador)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public String equivalencia2(Racional r)
        {
            int numerador = this.numerador * r.getDenominador();
            int denominador = this.denominador * r.getNumerador();
            if (numerador==denominador){
                return "es equivalente";
            }
            else{
            return "no es equivalente";
            }
            



        }




    }
}
