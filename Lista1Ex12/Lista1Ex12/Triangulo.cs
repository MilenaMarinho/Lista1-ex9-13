using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex12
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
            if ((v1 + v2) > v3)
            {
                if ((v2 + v3) > v1)
                {
                    if ((v1 + v3) > v2)
                    {
                        if (v1 == v2)
                        {
                            if (v2 == v3)
                            {
                                classificacao = "Triângulo Equilatero";
                            }
                            else
                            {
                                classificacao = "Triângulo Isósceles";
                            }
                        }
                        else
                        {
                            if (v1 == v3)
                            {
                                classificacao = "Triângulo Isósceles";
                            }
                            else
                            {
                                if (v2 == v3)
                                {
                                    classificacao = "Triângulo Isósceles";
                                }
                                else
                                {
                                    classificacao = "Triângulo Escaleno";
                                }
                            }
                        }
                    }
                    else
                    {
                        classificacao = "Não Formam um Triângulo";
                    }
                }
                else
                {
                    classificacao = "Não Formam um Triângulo";
                }
            }
            else
            {
                classificacao = "Não Formam um Triângulo";
            }
        }
    }
}
