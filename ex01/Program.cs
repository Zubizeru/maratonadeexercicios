using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 25;
            const double pi = 3.14159;

            Console.WriteLine("1-) Declare uma variável idade do tipo inteiro e uma constante PI do tipo double.");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Valor de PI: {pi}");
            Console.ReadLine();
        }
    }
}
