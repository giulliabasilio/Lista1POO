using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Quadradodiag becoDiagonal = new Quadradodiag();


            Console.WriteLine("Digite o valor da diagonal do quadrado");
            becoDiagonal.setDiag(double.Parse(Console.ReadLine()));

            becoDiagonal.calculaArea();

            Console.WriteLine("O valor da área do quadrado é: {0}", becoDiagonal.getArea());
        }
    }
}
