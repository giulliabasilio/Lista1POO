using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado quadradao = new Quadrado();

            Console.WriteLine("Digite o valor da aresta do quadrado:");

            quadradao.setLado(int.Parse(Console.ReadLine()));

            quadradao.calcularArea();

            Console.WriteLine(quadradao.getArea());


        }
    }
}
