using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//12) Escreva um programa que leia um número e verifique se ele é maior que 100. Se não for, informe o dobro desse número. 

namespace LogicaDeProgramacaoCsharp
{
    internal class Exercicio12
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Por favor, digite um número:");

            int numero = Convert.ToInt32(Console.ReadLine());

            if(numero > 100)
            {
                Console.WriteLine("Esse número é maior que 100 não é possível informar o dobro deste valor!");
            }

            else if(numero < 100)
            {
                int dobro = numero * 2;
                Console.WriteLine( "O dobro do " + numero+ " é " + dobro);
            }
            else
            {
                Console.WriteLine("");
            }
        }

    }
}
