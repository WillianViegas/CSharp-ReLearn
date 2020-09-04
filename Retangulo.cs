using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }

        public double Diagonal()
        {
            double larg = Math.Pow(Largura, 2);
            double alt = Math.Pow(Altura, 2);

            return Math.Sqrt(larg + alt);
        }
    }
}
