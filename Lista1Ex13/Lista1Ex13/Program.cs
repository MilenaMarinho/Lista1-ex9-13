using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo formato;
            formato = new Triangulo();

            Console.WriteLine("\n---------Exercício 13 da Lista 1---------\n");

            Console.Write("Digite o 1º Valor: ");
            formato.setV1(double.Parse(Console.ReadLine()));

            Console.Write("Digite o 2º Valor: ");
            formato.setV2(double.Parse(Console.ReadLine()));

            Console.Write("Digite o 3º Valor: ");
            formato.setV3(double.Parse(Console.ReadLine()));

            formato.calcular();

            Console.WriteLine("");

            Console.WriteLine("{0}", formato.getClassificacao());
        }
    }
}
