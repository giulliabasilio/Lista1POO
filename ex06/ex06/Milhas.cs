using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex06
{
    internal class Milhas
    {
        double milha;
        double km;

        public Milhas()
        {
            this.milha = 0;
            this.km = 0;
        }

        public Milhas(double milha)
        {
            this.milha = milha;
            this.km = 0;
        }

        public void setMilha(double milha)
        {
            this.milha = milha;
        }

        public double getMilha()
        {
            return this.milha;
        }

        public double getKm()
        {
            return this.km;
        }

        public void calcularConversao()
        {
            this.km = (this.milha * 1852) / 1000;
        }
    }
}
    