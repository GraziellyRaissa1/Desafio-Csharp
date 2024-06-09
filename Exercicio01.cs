using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeProgramacaoCsharp
{
    internal class Exercicio01
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número para saber se é Par ou Ímpar!");

            Console.WriteLine(" Por favor,  digite um número:");

            int numero = Convert.ToInt32(Console.ReadLine());
            if (numero % 2 == 0)
            {
                Console.WriteLine("O número " + numero + " é par!");
            }
            else
            {
                Console.WriteLine("O número " + numero + " é ímpar!");
            }
        }
    }
}

