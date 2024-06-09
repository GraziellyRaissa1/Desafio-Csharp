using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*15) Escreva um programa que leia o peso e a altura de uma pessoa, calcule o IMC e informe a categoria: 

Abaixo do peso: IMC < 18.5

Peso normal: 18.5 <= IMC < 24.9

Sobrepeso: 25 <= IMC < 29.9

Obesidade grau I: 30 <= IMC < 34.9

Obesidade grau II: 35 <= IMC < 39.9

Obesidade grau III: IMC >= 40*/


namespace LogicaDeProgramacaoCsharp
{
    internal class Exercicio15
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Informe seu peso e sua altura para descobrir o seu IMC!");

            Console.WriteLine("Digite seu peso:");

            double peso = double.Parse(Console.ReadLine());


            Console.WriteLine("Digite sua altura");

            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);
            if (imc < 18.5)
            {
                Console.WriteLine("Seu IMC é " + imc + ", você está abaixo do peso!");
            }
            else if (imc >= 18.5 && imc < 24.9)
            {
                Console.WriteLine("Seu IMC é " + imc + ", você seu peso está normal!");
            }
            else if (imc >= 25 && imc < 29.9)
            {
                Console.WriteLine("Seu IMC é " + imc + ", você está com sobrepeso!");
            }
            else if (imc >= 30 && imc <= 34.9)
            {
                Console.WriteLine("Seu IMC é " + imc + ", você está com grau de obesidade I !");
            }
            else if (imc >= 35 && imc <= 39.9)
            {
                Console.WriteLine("Seu IMC é " + imc + ", você está com grau de obesidade II !");
            }
            else if (imc >= 40)
            {
                Console.WriteLine("Seu IMC é " + imc + ", você está com grau de obesidade III !");
            }
        }
    }
}

