using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("7-) Crie um programa que leia a idade de uma pessoa e exiba uma mensagem de \r\nacordo com a faixa etária:");
            Console.WriteLine("Se a idade for menor que 12, exiba Criança");
            Console.WriteLine("Se a idade estiver entre 12 e 18, exiba Adolescente");
            Console.WriteLine("Se a idade for maior que 18, exiba Adulto.\n");
            Console.WriteLine("Qual é a sua idade?");
            int idade = int.Parse(Console.ReadLine());
            if (idade < 12)
            {
                Console.WriteLine("Criança.");
            }
            else if (idade >= 12 && idade <= 18)
            {
                Console.WriteLine("Adolescente.");
            }
            else
            {
                Console.WriteLine("Adulto.");
            }
            Console.ReadLine();
        }
    }
}
