using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("8-) Crie um programa que leia um número inteiro do usuário e utilize a estrutura switch para exibir uma mensagem de acordo com o valor do número:");
            Console.WriteLine("Se for 1, exiba Domingo.");
            Console.WriteLine("Se for 2, exiba Segunda-feira.");
            Console.WriteLine("Se for 3, exiba Terça-feira.");
            Console.WriteLine("Se for 4, exiba Quarta-feira.");
            Console.WriteLine("Se for 5, exiba Quinta-feira.");
            Console.WriteLine("Se for 6, exiba Sexta-feira.");
            Console.WriteLine("Se for 7, exiba Sábado.");
            Console.WriteLine("Caso contrário, exiba Número inválido.\n");

            Console.WriteLine("Informe um número inteiro");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;

                case 2:

                    Console.WriteLine("Segunda-feira");
                    break;

                case 3:

                    Console.WriteLine("Terça-feira");
                    break;

                case 4:
                    Console.WriteLine("Quarta-feira");
                    break;

                case 5:
                    Console.WriteLine("Quinta-feira");
                    break;

                case 6:

                    Console.WriteLine("Sexta-feira");
                    break;

                case 7:

                    Console.WriteLine("Sábado");
                    break;

                default:
                    Console.WriteLine("Número inválido");
                    break;
            }

            Console.ReadLine();
        }
    }
}
﻿