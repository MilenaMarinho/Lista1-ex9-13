using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Maior Valores1;
            Valores1 = new Maior();

            Console.WriteLine("\n---------Exercício 9 da Lista 1---------\n");

            Console.Write("Insira o 1º Valor: ");
            Valores1.setV1(double.Parse(Console.ReadLine()));

            Console.Write("Insira o 2º Valor: ");
            Valores1.setV2(double.Parse(Console.ReadLine()));

            Valores1.calcular();

            Console.WriteLine("");

            Console.WriteLine("{0}", Valores1.getMaior());
        }
    }
}
