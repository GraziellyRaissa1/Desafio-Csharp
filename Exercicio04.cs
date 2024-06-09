using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeProgramacaoCsharp
{
    internal class Exercicio04
    {
        public static void Main(string[] args)

        {

            Console.WriteLine("Escreva os três lados do triângulo para verificar se ele é um triângulo válido ou não");

            Console.WriteLine("Digite o valor do primeiro lado do triângulo:");

            int lado1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor do segundo lado do triângulo:");

            int lado2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor do terceiro lado do triângulo:");

            int lado3 = Convert.ToInt32(Console.ReadLine());

            if ((lado1 + lado2 > lado3) && (lado2 + lado3 > lado1) && (lado1 + lado3 > lado2))

            {

                Console.WriteLine("Forma um triângulo Válido!");

            }

        else
            {

                Console.WriteLine("Não forma um triângulo Válido!");

            }

        }
    }
}
