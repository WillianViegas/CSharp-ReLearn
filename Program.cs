using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Rooms[] vect = new Rooms[10];

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                string email = Console.ReadLine();
                int quarto = int.Parse(Console.ReadLine());

                vect[quarto] = new Rooms(nome, email, quarto);
            }

            for (int i = 0; i < vect.Length; i++)
            {
                if(vect[i] != null)
                {
                    Console.WriteLine(vect[i]);
                }
            }
        }
    }
}
