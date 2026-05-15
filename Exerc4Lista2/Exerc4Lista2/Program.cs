using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc4Lista2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b = 0, h = 0, area;

            Console.WriteLine("Digite a base do retângulo:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura do retângulo:");
            h = int.Parse(Console.ReadLine());

            area = b * h;

            if (area > 100)
            {
                Console.WriteLine("Terreno grande");
            }
            else
            {
                Console.WriteLine("Terreno pequeno");
            }
        }
    }
}
