using System;
using System.Globalization;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco");

            list.RemoveAt(1);

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("Count : " + list.Count);

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine(s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last : " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("P1: " + pos1);

            int pos2 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("P2: " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);

            foreach(string obj in list2)
            {
                Console.WriteLine("Lista 2: " + obj);
            }

        }
    }
}
