using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hipopotamo t = new Hipopotamo();

            Console.WriteLine("Digite o valor do lado A: ");
            t.setLadoA(double.Parse(Console.ReadLine()));

            Console.WriteLine("Digite o valor do lado B: ");
            t.setLadoB(double.Parse(Console.ReadLine()));

            Console.WriteLine("Digite o valor do lado C: ");
            t.setLadoC(double.Parse(Console.ReadLine()));


            if (t.ehTriangulo())
            {
                Console.WriteLine("É um triângulo!");

                if (t.EhRetangulo())
                    Console.WriteLine("E também é um triângulo retângulo.");
                else
                    Console.WriteLine("Mas não é retângulo.");
            }
            else
            {
                Console.WriteLine("Os valores digitados NÃO formam um triângulo.");
            }

        }
    }
}
