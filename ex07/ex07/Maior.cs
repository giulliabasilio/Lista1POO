using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex07
{
    internal class Maior
    {
        double valorA;
        double valorB;


        public Maior()
        {
            this.valorA = 0;
            this.valorB = 0;


        }

        public void setvalorA(double valorA)
        {


            this.valorA = valorA;

        }

        public void setvalorB(double valorB)
        {


            this.valorB = valorB;

        }


        public double verificaMaior()
        {
            if (this.valorA > this.valorB)
            {
                return this.valorA;

            }
            else
            {
                return this.valorB;
            }
        }
    }
}