using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//6) Escreva um programa que leia um ano e verifique se ele é bissexto.
//Um ano é bissexto se for divisível por 4, mas não por 100, exceto se for divisível por 400. 

namespace LogicaDeProgramacaoCsharp
{
    internal class Exercicio06
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um ano para saber se ele é bissexto");
            Console.WriteLine("Digite o ano que desejar:");
            int ano = Convert.ToInt32(Console.ReadLine());
            if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0))
            {
                Console.WriteLine("É ano bisexto!");
            }
            else
            {
                Console.WriteLine("Não é um ano bissexto!");
            }
        }
    }
}
