using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex11
{
    internal class PesoIdeal
    {
        private double peso;
        private double altura;
        private double relacaoPesoAltura;
        private string classificacao;

        public void setPeso(double n)
        {
            peso = n;
        }
        public void setAltura(double n)
        {
            altura = n;
        }
        public double getPeso()
        {
            return peso;
        }
        public double setAltura()
        {
            return altura;
        }
        public string getClassificacao()
        {
            return classificacao;
        }
        public void calcular()
        {
            relacaoPesoAltura = peso / Math.Pow(altura,2);

            if (relacaoPesoAltura < 20)
            {
               classificacao = "Abaixo do Peso";
            }
            else
            {
                if (relacaoPesoAltura < 25)
                {
                    classificacao = "Peso Ideal";
                }
                else
                {
                    classificacao = "Acima do Peso";
                }
            }
        }
    }
}
