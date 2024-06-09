using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*13) Escreva um programa que leia o valor de uma compra e a categoria do cliente (1 para comum, 2 para associado e 3 para VIP). 
 * Aplique os seguintes descontos: 

Comum: Sem desconto

Associado: 10 % de desconto

VIP: 20 % de desconto

Informe o valor final da compra.*/ 

namespace LogicaDeProgramacaoCsharp
{
    internal class Exercicio13
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Informe o código para saber se você se encaixa em alguma categoria e possui algum desconto em sua compra");

            Console.WriteLine("Digite o valor total da compra:");

            double valorCompra = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o número da opção correspondente ao seu código:");

            Console.WriteLine("1 - Comum (sem desconto)");

            Console.WriteLine("2 - Associado (10% de desconto)");

            Console.WriteLine("3 - VIP (20% de desconto)");

            int codigo = Convert.ToInt32(Console.ReadLine());

            double desconto = 0;

            if (codigo == 1)
            {
                desconto = 0;
            }
            else if (codigo == 2)
            {
                desconto = valorCompra * 0.10;
            }
            else if (codigo == 3)
            {
                desconto = valorCompra * 0.20;
            }
            else
            {
                Console.WriteLine("Você não se encaixa em nenhuma categoria! Por favor informe um codigo vãlido para ter desconto na sua compra!");
            }

            double valorFinal = valorCompra - desconto;

            Console.WriteLine("O valor final da sua compra com desconto é de R$ " + valorFinal + ".");
        }
    }
}
