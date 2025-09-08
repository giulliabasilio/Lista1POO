using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex04_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo();


            Console.WriteLine("Digite o valor da BASE do triângulo:");
            triangulo.setBase1(double.Parse(Console.ReadLine()));

            Console.WriteLine("Digite o valor da ALTURA do triângulo:");
            triangulo.setAltura(double.Parse(Console.ReadLine()));



            triangulo.calculaArea();

            Console.WriteLine("O valor da área do triângulo é: {0}", triangulo.getArea());
        }
    }
}
