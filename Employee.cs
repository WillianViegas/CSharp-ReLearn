using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Course
{
    class Employee
    {
        public int Id { get; }
        public string Nome { get; set; }
        private double _salario { get; set; }

        public Employee()
        {
        }

        public Employee(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            _salario = salario;
        }

        public void increaseSalary(double perc)
        {
            _salario += _salario * (perc / 100);
        }

        public override string ToString()
        {
            return Id + ", " + Nome + ", " + _salario.ToString("N2", CultureInfo.InvariantCulture);
        }
    }
}
