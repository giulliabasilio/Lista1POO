using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Maior thatFace = new Maior();


            Console.WriteLine("Digite o valor A: ");
            thatFace.setvalorA(double.Parse(Console.ReadLine()));

            Console.WriteLine("Digite o valor B: ");
            thatFace.setvalorB(double.Parse(Console.ReadLine()));

            Console.WriteLine("O maior valor é: {0} ", thatFace.verificaMaior());
        }
    }
}
