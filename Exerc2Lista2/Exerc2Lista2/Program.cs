using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc2Lista2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v1 = 0;
            int v2 = 0;

            Console.WriteLine("Digite o primeiro valor:");
            v1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            v2 = int.Parse(Console.ReadLine());

            if (v1 > v2)
            {
                Console.WriteLine($"O maior valor é: {v1}");
            }
            else if (v2 > v1)
            {
                Console.WriteLine($"O maior valor é: {v2}");
            }
            else
            {
                Console.WriteLine("Os números são idênticos");
            }
        }

    }

}