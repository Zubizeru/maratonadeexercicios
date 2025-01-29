using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4-) Crie um programa que calcule a área de um círculo, dado o valor do raio fornecido pelo usuário. Utilize a constante PI para o cálculo da área (A = π * r²).");
            const double pi = 3.14159;
            Console.WriteLine("\nInforme o raio do círculo para o cálculo: ");
            double raio = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nA área do circulo é: {pi * raio}");
            Console.ReadLine();
        }
    }
}
