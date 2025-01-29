using System;
using System.Collections.Generic;

namespace ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("6-) Crie um programa que utilize o laço foreach para percorrer e exibir todos os \r\nelementos de um array de strings contendo os nomes de 5 cidades.\n");

            List<string> cidades = new List<string> { "Rio de Janeiro", "Salvador", "São Paulo", "Fortaleza", "Natal" };

            foreach (string cidade in cidades) // For Each para percorrer o array
            {
                Console.WriteLine($"{ cidade} "); // Imprime cada nome
            }
            Console.ReadLine();
        }
    }
}
