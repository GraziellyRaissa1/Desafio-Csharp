using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeProgramacaoCsharp
{
    internal class Exercicio02
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Por favor, digite um número para saber se ele é positivo negativo ou zero!");

            Console.WriteLine("Digite um número:");

            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero == 0)
            {
                Console.WriteLine("O número " + numero + " é Zero!");
            }
            else if (numero > 0)
            {
                Console.WriteLine("O número " + numero + " é positivo!");
            }
            else
            {
                Console.WriteLine("O número " + numero + " é negativo!");
            }
        }
    }
}
