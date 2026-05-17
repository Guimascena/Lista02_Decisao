using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc11Lista2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p1 = 0, p2;

            Console.WriteLine("Digite a nota P1:");
            p1 = double.Parse(Console.ReadLine());

            p2 = (15 - p1) / 2;

            Console.WriteLine($"O aluno precisa tirar {p2} na P2 para ser aprovado");
        }
    }
}
