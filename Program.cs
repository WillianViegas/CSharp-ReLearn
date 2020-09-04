using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pessoa Mais velha
             Pessoa p1, p2;
             p1 = new Pessoa();
             p2 = new Pessoa();

             Console.WriteLine("Dados da primeira pessoa:");
             p1.Nome = Console.ReadLine();
             p1.Idade = int.Parse(Console.ReadLine());

             Console.WriteLine("Dados da segunda pessoa:");
             p2.Nome = Console.ReadLine();
             p2.Idade = int.Parse(Console.ReadLine());

             if(p1.Idade > p2.Idade)
             {
                 Console.WriteLine("O mais velho é : " + p1.Nome);
             }
             else if(p1.Idade < p2.Idade)
             {
                 Console.WriteLine("O mais velho é : " + p2.Nome);
             }
             else
             {
                 Console.WriteLine("Ambos tem a mesma idade!");
             }

            //Media salarios
            Funcionario f1, f2;
            f1 = new Funcionario();
            f2 = new Funcionario();
            Console.WriteLine("Dados do primeiro funcionario: ");
            f1.Nome = Console.ReadLine();
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionario: ");
            f2.Nome = Console.ReadLine();
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double mediaSal = (f1.Salario + f2.Salario) / 2.0;

            Console.WriteLine(mediaSal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
