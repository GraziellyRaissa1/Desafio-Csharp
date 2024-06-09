using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeProgramacaoCsharp
{
    internal class Exercicio03
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número para saber qual entre eles é o maior!");

            Console.WriteLine("Digite um número");

            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite um segundo número");

            int numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 < numero2)
            {
                Console.WriteLine("O número " + numero2 + " é maior que o número " + numero1 + ".");
            }
            else
            {
                Console.WriteLine("O número " + numero1 + " é maior que o número " + numero2 + ".");
            }
        }

    }
}
