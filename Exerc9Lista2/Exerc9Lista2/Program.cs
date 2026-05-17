using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc9Lista2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso = 0, altura = 0, r;
            char sexo;

            Console.WriteLine("Digite o peso:");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura:");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o sexo (M/F):");
            sexo = char.Parse(Console.ReadLine());

            r = peso / Math.Pow(altura, 2);

            if (sexo == 'F' || sexo == 'f')
            {
                if (r < 19)
                {
                    Console.WriteLine("Abaixo peso");
                }
                else if (r >= 19 && r < 24)
                {
                    Console.WriteLine("Peso ideal");
                }
                else
                {
                    Console.WriteLine("Acima peso");
                }
            }
            else if (sexo == 'M' || sexo == 'm')
            {
                if (r < 20)
                {
                    Console.WriteLine("Abaixo peso");
                }
                else if (r >= 20 && r < 25)
                {
                    Console.WriteLine("Peso ideal");
                }
                else
                {
                    Console.WriteLine("Acima peso");
                }
            }
        }
    }
}
