using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex13
{
    internal class Triangulo
    {
        private double v1;
        private double v2;
        private double v3;
        private string classificacao;

        public void setV1(double n)
        {
            v1 = n;
        }
        public void setV2(double n)
        {
            v2 = n;
        }
        public void setV3(double n)
        {
            v3 = n;
        }

        public double getV1()
        {
            return v1;
        }
        public double getV2()
        {
            return v2;
        }
        public double getV3()
        {
            return v3;
        }
        public string getClassificacao()
        {
            return classificacao;
        }
        public void calcular()
        {
            v1 = Math.Pow(v1, 2);
            v2 = Math.Pow(v2, 2);
            v3 = Math.Pow(v3, 2);

            if ((v1 + v2) == v3)
            {
                classificacao = "Formam um Triângulo Retângulo";
            }
            else
            {
                if ((v3 + v2) == v1)
                {
                    classificacao = "Formam um Triângulo Retângulo";
                }
                else
                {
                    if ((v1 + v3) == v2)
                    {
                        classificacao = "Formam um Triângulo Retângulo";
                    }
                    else
                    {
                        classificacao = "Não Formam um Triângulo Retângulo";
                    }
                }
            }
        }
    }
}
