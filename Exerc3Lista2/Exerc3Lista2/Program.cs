using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc3Lista2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v1 = 0, v2 = 0, v3 = 0;

            Console.WriteLine("Digite o primeiro valor:");
            v1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            v2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor:");
            v3 = int.Parse(Console.ReadLine());

            if (v1 > v2 && v1 > v3)
            {
                Console.WriteLine($"Maior valor: {v1}");
            }
            else if (v2 > v1 && v2 > v3)
            {
                Console.WriteLine($"Maior valor: {v2}");
            }
            else if (v3 > v1 && v3 > v2)
            {
                Console.WriteLine($"Maior valor: {v3}");
            }
            else if (v1 == v2 && v1 > v3)
            {
                Console.WriteLine($"Maiores valores: {v1} e {v2}");
            }
            else if (v1 == v3 && v1 > v2)
            {
                Console.WriteLine($"Maiores valores: {v1} e {v3}");
            }
            else if (v2 == v3 && v2 > v1)
            {
                Console.WriteLine($"Maiores valores: {v2} e {v3}");
            }
            else
            {
                Console.WriteLine("Os três valores são iguais");
            }
        }
    }
}
