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
            double peso = 0, altura = 0, r;

            Console.WriteLine("Digite o peso:");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura:");
            altura = double.Parse(Console.ReadLine());

            r = peso / Math.Pow(altura, 2);

            if (r < 20)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (r >= 20 && r < 25)
            {
                Console.WriteLine("Peso ideal");
            }
            else
            {
                Console.WriteLine("Acima do peso");
            }
        }
    }
}
