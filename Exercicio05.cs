using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//5) Escreva um programa que leia três notas de um aluno e calcule a média.
//Informe se o aluno está aprovado (média >= 7), em recuperação (5 <= média < 7) ou reprovado (média < 5). 

namespace LogicaDeProgramacaoCsharp
{
    internal class Exercicio05
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Informe as três notas de um aluno para calcular a sua média");
            Console.WriteLine("Digite a primeira nota do aluno:");
            int nota1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota do aluno");
            int nota2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota do aluno");
            int nota3 = Convert.ToInt32(Console.ReadLine());
            int media = (nota1 + nota2 + nota3) / 3;

            if (media >= 7)
            {
                Console.WriteLine("O aluno está aprovado!");
            }

           else if (media >= 5)
            {
                Console.WriteLine("O aluno está em recuperação!");    
            }

            else
            {
                Console.WriteLine("O aluno está reprovado!");
            }

        }
    }
}
