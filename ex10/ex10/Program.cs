using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IMC calculo = new IMC();


            Console.WriteLine("Digite seu peso em KG:");
            calculo.setPeso(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Digite sua altura em Metros (Utilizar '.' para casas decimais) :");
            calculo.setAltura(Convert.ToDouble(Console.ReadLine()));



            if (calculo.calcularIMC() < 20)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (calculo.calcularIMC() < 25)
            {

                Console.WriteLine("Peso ideal");
            }
            else
            {

                Console.WriteLine("Acima do peso");
            }

            Console.WriteLine("Seu IMC é: {0}", calculo.calcularIMC());
        }
    }
    }

