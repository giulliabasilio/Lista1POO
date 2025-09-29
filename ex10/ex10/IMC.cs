using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10
{
    internal class IMC
    {
        double peso;
        double altura;
        double imc;

        public IMC()
        {
            this.peso = 0;
            this.altura = 0;
            this.imc = 0;
        }



        public void setPeso(double peso)
        {
            this.peso = peso;
        }

        public double getPeso()
        {
            return this.peso;
        }



        public void setAltura(double altura)
        {
            this.altura = altura;
        }




        public double geAltura()
        {
            return this.altura;
        }



        public double getIMC()
        {
            return this.imc;
        }

        public double calcularIMC()
        {
            this.imc = this.peso / Math.Pow(this.altura, 2);

            return this.imc;
        }

    }
}
