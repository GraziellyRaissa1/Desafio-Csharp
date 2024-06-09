using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//14) Escreva um programa que leia um número e informe se ele é positivo ou negativo.
//Se for positivo, calcule a raiz quadrada; se for negativo, informe o número ao quadrado. 


namespace LogicaDeProgramacaoCsharp
{
    class Exercicio14
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Vamos descobrir se um número é negativo ou positivo!");
            Console.WriteLine("Digite um número:");
            double numero = Convert.ToDouble(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("A Raiz quadrada do número " + numero + " é " + (Math.Sqrt(numero)));
            }
            else
            {
                Console.WriteLine("O número " + numero + " ao quadrado é " + (numero + numero));
            }
        }
    }
}
