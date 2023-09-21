using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex10
{
    internal class Retangulo
    {
        private double b;
        private double h;
        private double area;
        private string areaClassificacao;

        public void setB(double n)
        {
            b = n;
        }
        public void setH(double n)
        {
            h = n;
        }
        public double getB()
        {
            return b;
        }
        public double getH()
        {
            return h;
        }

        public string getAreaClassificacao()
        {
            return areaClassificacao;
        }
        public void calcular()
        {
            area = b * h;

            if(area > 100)
            {
                areaClassificacao = "Terreno Grande";
            }
            else
            {
                areaClassificacao = "Terreno Pequeno";
            }
        }
    }
}
