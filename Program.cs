using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorInicial = 0;

            Console.Write("Entre com o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito incial (s/n)?");
            char confirmation = char.Parse(Console.ReadLine());
            
            if(confirmation == 's' || confirmation == 'S')
            {
                Console.Write("Entre o valor de depósito inicial:");
                valorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Conta conta1 = new Conta(numero, titular, valorInicial);
            Console.WriteLine(conta1);

            Console.Write("\nEntre um valor para depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            conta1.Depositar(valorDeposito);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta1);

            Console.Write("\nEntre um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta1.Sacar(valorSaque);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta1);
        }
    }
}
