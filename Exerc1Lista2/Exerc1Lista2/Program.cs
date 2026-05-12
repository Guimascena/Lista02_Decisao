using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc1Lista2
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
            v1 = int.Parse(Console.ReadLine());

            if (v1 > v2)
            {
                Console.WriteLine($"O maior valor é: {v1}");
            }
            else
            {
                Console.WriteLine($"O maior valor é: {v2}");
            }

           


        }
    }
}
