using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double perc)
        {
            perc /= 100;
            SalarioBruto += SalarioBruto * perc;
        }

        public override string ToString()
        {
            return Nome + ", " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
