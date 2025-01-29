using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2-) Declare uma variável do tipo string chamada nome e uma constante do tipo int chamada numeroMaximo com o valor 100.");
            string nome = "José Elias";
            const int numeromaximo = 100;
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Número maximo constante (não pode ser alterado):): {numeromaximo}");
            Console.ReadLine();
        }
    }
}
