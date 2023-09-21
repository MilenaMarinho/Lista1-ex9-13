using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex9
{
    internal class Maior
    {
        private double v1;
        private double v2;
        private string maior;


        public void setV1(double n)
        {
            v1 = n;
        }
        public void setV2(double n)
        {
            v2 = n;
        }

        public double getV1()
        {
            return v1;
        }

        public double getV2()
        {
            return v2;
        }

        public string getMaior()
        {
            return maior;
        }

        public void calcular()
        {
            if (v1 == v2)
            {
               maior="Valores Idênticos";
            }
            else
            {
                if (v1 > v2)
                {
                    maior = "O 1º Valor é o Maior";
                }
                else
                {
                    maior = "O 2º Valor é o Maior"; 
                }
            }
        }
    }
}
