using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PesoIdeal peso1;
            peso1 = new PesoIdeal();

            Console.WriteLine("\n---------Exercício 11 da Lista 1---------\n");

            Console.Write("Insira o Peso(Kg): ");
            peso1.setPeso(double.Parse(Console.ReadLine()));

            Console.Write("Insira a Altura(m): ");
            peso1.setAltura(double.Parse(Console.ReadLine()));

            peso1.calcular();

            Console.WriteLine("");

            Console.WriteLine("{0}", peso1.getClassificacao()); 
        }
    }
}
