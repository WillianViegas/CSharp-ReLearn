using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Pi: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));*/

            /*  Console.Write("Cotacao dolar: ");
              double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
              Console.Write("Quantos dolares vai comprar: ");
              double real = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

              Console.WriteLine("Valor a ser pago em real : " 
                  + ConversorDeMoeda.RealParaDolar(real, dolar).ToString("F2", CultureInfo.InvariantCulture));*/

            Produto produto = new Produto("TV", 2000.00);

            Console.WriteLine(produto);


        }
    }
}
