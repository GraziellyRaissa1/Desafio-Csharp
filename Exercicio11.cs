using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//11) Escreva um programa que leia um número e verifique se ele está no intervalo de 10 a 20 

namespace LogicaDeProgramacaoCsharp
{
    internal class Exercicio11
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");

            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0 && numero < 20) {
                Console.WriteLine("O número " + numero + " está no intervalo entre 10 e 20.");

            }

            else
            {
                Console.WriteLine("O número " + numero + " não está no intervalo entre 10 a 20.");
            }
        }
    }
}
