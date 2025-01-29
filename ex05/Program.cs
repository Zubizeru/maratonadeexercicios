using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5-) Crie um programa que utilize o laço for para exibir os números de 1 a 10 no console.");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i} ");
            }
            Console.ReadLine();
        }
    }
}
