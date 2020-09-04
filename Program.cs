using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  string produto1 = "Computador";
              string produto2 = "Mesa de escritório";

              byte idade = 30;
              int codigo = 5290;
              char genero = 'M';

              double preco1 = 2100.0;
              double preco2 = 650.50;
              double medida = 53.234567;

              Console.WriteLine("Produtos:");
              Console.WriteLine($"{produto1}, cujo preço é $ {preco1:F2}");
              Console.WriteLine($"{produto2}, cujo preço é $ {preco2:F2}");
              Console.WriteLine($"\nRegistro: {idade} anos de idade, código {codigo} e gênero: {genero}");
              Console.WriteLine($"\nMedida com oito casas decimais: {medida}");
              Console.WriteLine($"Arredondado (três casas decimais) : {medida:F3}");
              Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));

              int teste = (int) preco1;
              Console.WriteLine(teste);*/

            /*  Console.WriteLine("Entre com seu nome Completo:");
              string nome = Console.ReadLine();
              Console.WriteLine("Quanto quartos tem na sua casa?");
              int quartos = int.Parse(Console.ReadLine());
              Console.WriteLine("Entre com o preço de um produto:");
              double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
              Console.WriteLine("Entre seu último nome, idade e altura (mesma linha)");
              string[] vet = Console.ReadLine().Split(' ');
              string ultimoNome = vet[0];
              int idade = int.Parse(vet[1]);
              string altura = vet[2].ToString(CultureInfo.InvariantCulture);

              Console.WriteLine(nome);
              Console.WriteLine(quartos);
              Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
              Console.WriteLine(ultimoNome);
              Console.WriteLine(idade);
              Console.WriteLine(altura.ToString(CultureInfo.InvariantCulture));*/

            /* int a = 10, b = 11, c = 2;

             int resultado = Maior(a, b, c);
             Console.WriteLine(resultado);*/

            /* int cnt = 0;
             while(cnt <= 20)
             {
                 Console.WriteLine(cnt);
                 cnt++;
             }*/

            /* for(int i= 0; i <= 20; i++)
             {
                 Console.WriteLine(i);
             }*/

            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo x : ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo y : ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("Area de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if(areaX > areaY)
            {
                Console.WriteLine("Maior area : " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Maior area : " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            }
        }

        static int Maior(int a, int b, int c)
        {
            if(a > b && a > c)
            {
                return a;
            }
            else if(b > c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }

    }
}
