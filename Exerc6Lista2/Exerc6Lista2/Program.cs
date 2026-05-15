using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc6Lista2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int angulo = 0;

            Console.WriteLine("Digite o valor do ângulo:");
            angulo = int.Parse(Console.ReadLine());

            if (angulo < 90)
            {
                Console.WriteLine("Ângulo agudo");
            }
            else if (angulo == 90)
            {
                Console.WriteLine("Ângulo reto");
            }
            else
            {
                Console.WriteLine("Ângulo obtuso");
            }
        }
    }
}
