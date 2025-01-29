using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3-) Crie um programa que leia dois números inteiros do usuário e calcule a soma, a subtração, a multiplicação e a divisão desses números. Exiba os resultados no console.\n");
            Console.Write("Digite o primeiro número: ");
            double numero1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double numero2 = double.Parse(Console.ReadLine());

            Console.Clear();
            double soma = numero1 + numero2;
            Console.WriteLine($"\nSoma: {soma}");

            double subtracao = numero1 - numero2;
            Console.WriteLine($"\nSubtração: {subtracao}");

            double multiplicacao = numero1 * numero2;
            Console.WriteLine($"\nMultiplicação: {multiplicacao}");

            if (numero2 == 0)
            {
                Console.WriteLine("\nDivisão: Não é possível dividir por zero");
            }
            else
            {
                double divisao = (double)numero1 / numero2;
                Console.WriteLine($"\nDivisão: {divisao}");
            }

            Console.ReadLine();
        }
    }
}
