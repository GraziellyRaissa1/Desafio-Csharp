using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//7) Escreva um programa que leia a idade de uma pessoa
//e informe se ela é uma criança (0-12 anos), adolescente (13 - 17 anos),
//adulto (18 - 59 anos) ou idoso (60 anos ou mais). 

namespace LogicaDeProgramacaoCsharp
{
    internal class Exercicio07
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a idade:");
            int idade = Convert.ToInt32(Console.ReadLine());
            if(idade <= 0)
            {
                Console.WriteLine("Idade inválida!");
            }
            else if(idade <= 12)
            {
                Console.WriteLine("A pessoa que pertence a essa idade é uma criança.");
            }

           else if(idade <= 17)
            {
                Console.WriteLine("A pessoa que pertence a essa idade é uma adolescente.");
            }  

            else if(idade <= 59) {
                Console.WriteLine("A pessoa que pertence a essa idade é um adulto.");
                    }
            else
            {
                Console.WriteLine("A pessoaque pertence a essa idade é um idoso.");
            }
        }
       
    }
}
