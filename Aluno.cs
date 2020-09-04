using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class Aluno
    {
        public string Nome;
        public double N1;
        public double N2;
        public double N3;

        public double NotaFinal()
        {
            return N1 + N2 + N3;
        }

        public double PontosFaltantes(double notaFinal)
        {
            return 60.0 - notaFinal;
        }
    }
}
