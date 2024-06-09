using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//8) Escreva um programa que leia a nota de um aluno e converta-a para conceito:
//A(nota >= 9), B(7 <= nota < 9), C(5 <= nota < 7), D(3 <= nota < 5) e F(nota< 3). 

namespace LogicaDeProgramacaoCsharp
{
    internal class Exercicio08
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a nota do aluno para obter a sua classificação entre A,B,C.D E F");

            Console.WriteLine("Digite a nota do aluno:");

            int nota = Convert.ToInt32(Console.ReadLine());

            if (nota >= 9)
            {
                Console.WriteLine("Nota A.");
            }

            else if (7 <= nota && nota < 9)
            {
                Console.WriteLine("Nota B.");
            }

            else if (5 <= nota && nota < 7)
            {
                Console.WriteLine("Nota C.");
            }

            else if (3 <= nota && nota < 5)
            {
                Console.WriteLine("Nota D.");
            }
            else
            {
                Console.WriteLine("Nota F.");
            } 
          

        }
        
    }
}
