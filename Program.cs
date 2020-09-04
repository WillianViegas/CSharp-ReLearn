using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Retangulo calculos
            /* Retangulo ret = new Retangulo();
             Console.WriteLine("Entre a largura e altura do retangulo:");
             ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

             Console.WriteLine("AREA: " + ret.Area().ToString("F2",CultureInfo.InvariantCulture));
             Console.WriteLine("PERIMETRO: " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
             Console.WriteLine("DIAGONAL: " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));*/


            //Calculo salario funcionario
            /* Funcionario f1 = new Funcionario();
             Console.Write("Nome: ");
             f1.Nome = Console.ReadLine();
             Console.Write("Salário bruto: ");
             f1.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             Console.Write("Imposto: ");
             f1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

             Console.WriteLine("Funcionário: " + f1);

             Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
             double perc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             f1.AumentarSalario(perc);

             Console.WriteLine("Funcionário: " + f1);*/

            //nota Aluno
            Aluno aluno = new Aluno();

            Console.Write("Nome do Aluno:");
            aluno.Nome = Console.ReadLine();
            Console.Write("Nota 1: ");
            aluno.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nota 2: ");
            aluno.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nota 3: ");
            aluno.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL: " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            if(aluno.NotaFinal() >= 60.0)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram " 
                    + aluno.PontosFaltantes(aluno.NotaFinal()).ToString("F2", CultureInfo.InvariantCulture)
                     + " Pontos");
            }
        }
    }
}
