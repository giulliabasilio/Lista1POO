using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo grandao = new Retangulo();

            Console.WriteLine("Digite o valor da base do retângulo:");
            grandao.setBase(int.Parse(Console.ReadLine()));

            Console.WriteLine("Digite o valor da altura do retângulo:");
            grandao.setAltura(int.Parse(Console.ReadLine()));

            grandao.calcularArea();


            if (grandao.verificaMaior() == true)
            {
                Console.WriteLine("Terreno Grande");
            }
            else
            {
                Console.WriteLine("Terreno Pequeno");
            }
        }
    }
}
