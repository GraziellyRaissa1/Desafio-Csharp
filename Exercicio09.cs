using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*9)Escreva um programa que leia o código de um produto e informe a sua categoria: 

1 a 10: Alimento não-perecível 

11 a 20: Alimento perecível 

21 a 30: Vestuário

31 a 40: Eletrônicos

Outros: Código inválido*/

namespace LogicaDeProgramacaoCsharp
{
    internal class Exercicio09
    {
        public static void Main( string [] args)
        {
            Console.WriteLine("Digite um número entre 1 e 40 e descobra a qual categoria ele pertence!");

            Console.WriteLine(" Por favor, digite um número:");

            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero >= 1 && numero <= 10)
            {
                Console.WriteLine("Alimento não-perecível!");
            }

            else if (numero >= 11 && numero <= 20)
            {

                Console.WriteLine("Alimento perecível!");
            }

            else if (numero >= 21 && numero <= 30)
            {
                Console.WriteLine("Vestuário!");
            }

            else if (numero >= 31 && numero <= 40)
            {
                Console.WriteLine("Eletrônicos!");
            }

            else
            {
                Console.WriteLine("Número do produto inválido! digite outro número entre 1 e 40 para obter uma resposta válida!");
            }
        }
    }
}
