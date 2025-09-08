using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex04_
{
    internal class Triangulo
    {
        double base1;
        double altura;
        double area;

        public Triangulo()
        {
            this.base1 = 0;
            this.area = 0;
            this.area = 0;

        }

        public void setBase1(double base1)
        {


            this.base1 = base1;

        }

        public double getBase1()
        {

            return this.base1;

        }
        public void setAltura(double altura)
        {


            this.altura = altura;

        }

        public double getAltura()
        {

            return this.altura;

        }

        public double getArea()
        {

            return this.area;

        }

        public void calculaArea()
        {

            this.area = (this.base1 * this.altura) / 2;
        }
    }
}

