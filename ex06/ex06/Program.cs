using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex06
{
    internal class Program
    {
        static void Main(string[] args)


        {
            Milhas m = new Milhas();

            Console.Write("Digite a quantidade de milhas marítimas: ");
            double valor = double.Parse(Console.ReadLine());

            m.setMilha(valor);
            m.calcularConversao();

            Console.WriteLine(m.getMilha() + " milha(s) marítima(s) equivalem a " + m.getKm() + " km");
        }
    }
}