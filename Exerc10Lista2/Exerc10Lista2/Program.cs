using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc10Lista2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p1 = 0, p2 = 0, media;

            Console.WriteLine("Digite a nota P1:");
            p1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota P2:");
            p2 = double.Parse(Console.ReadLine());

            media = (p1 + (2 * p2)) / 3;

            Console.WriteLine($"Média: {media}");

            if (media >= 5)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }

        }
    }
}
