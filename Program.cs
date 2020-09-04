using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome:");
            p1.Nome = Console.ReadLine();
            Console.Write("Preço:");
            p1.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade:");
            p1.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados produto: " + p1);

            Console.WriteLine("Digite o número de produtos a serem adicionados ao estoque: ");
            int n = int.Parse(Console.ReadLine());
            p1.AdicionarProdutos(n);

            Console.WriteLine("Dados produto: " + p1);

            Console.WriteLine("Digite o número de produtos a serem removidos do estoque: ");
            n = int.Parse(Console.ReadLine());
            p1.RemoverProdutos(n);

            Console.WriteLine("Dados produto: " + p1);
        }
    }
}
