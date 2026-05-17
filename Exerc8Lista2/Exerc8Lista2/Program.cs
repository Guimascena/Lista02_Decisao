using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc8Lista2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0;

            Console.WriteLine("Digite o valor de A:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de C:");
            c = int.Parse(Console.ReadLine());

            if ((a * a) == (b * b) + (c * c) ||
                (b * b) == (a * a) + (c * c) ||
                (c * c) == (a * a) + (b * b))
            {
                Console.WriteLine("Forma um triângulo retângulo");
            }
            else
            {
                Console.WriteLine("Não forma um triângulo retângulo");
            }
        }
    }
}
