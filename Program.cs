using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 100, 1);

            p.Nome = "Tv 4k";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Quantidade);
            Console.WriteLine(p.Preco);
        }
    }
}
