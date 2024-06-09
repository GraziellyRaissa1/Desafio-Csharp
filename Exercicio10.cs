using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//10) Escreva um programa que leia dois números e uma operação (adição, subtração, multiplicação ou divisão)
//e realize a operação correspondente. 

namespace LogicaDeProgramacaoCsharp
{
    internal class Exercicio10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite dois números e a operação que deseja realizar!");

            Console.WriteLine("Por favor, digite um número:");

            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Por favor, digite um segundo número:");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Agora escolha a operação que deseja realizar:");
            Console.WriteLine("Digite / para divisão.");
            Console.WriteLine("Digite * para multiplicação.");
            Console.WriteLine("Digite + para adição.");
            Console.WriteLine("Digite - para subtração.");

            string? operacao =  Console.ReadLine();

            if (operacao == "+")
            {
                double soma = numero1 + numero2;

                Console.WriteLine("O resultado dessa soma é " + soma + ".");
            } 

            else if(operacao == "-")

            {
                 double subtracao = numero1 - numero2;

                Console.WriteLine("O resultado dessa subtração é " + subtracao + ".");
            }
            else if (operacao == "*") {
                
                double multiplicacao = numero1 * numero2;

                Console.WriteLine("O resultado desta multiplicação é " + multiplicacao + ".");
            
            }

            else if (operacao == "/")
            {
                double divisao = numero1 / numero2;

                Console.WriteLine("O resultado desta divisão é " + divisao + ".");
            }
             else
            {
                Console.WriteLine("Operação inválida!");
            }

            }
        }
    }

