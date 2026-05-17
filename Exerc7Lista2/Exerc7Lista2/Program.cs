using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc7Lista2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0;

            Console.WriteLine("Digite o primeiro lado:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo lado:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro lado:");
            c = int.Parse(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("Triângulo Equilátero");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("Triângulo Isósceles");
                }
                else
                {
                    Console.WriteLine("Triângulo Escaleno");
                }
            }
            else
            {
                Console.WriteLine("Os valores não formam um triângulo");
            }
        }
    }
}
