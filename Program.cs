﻿using System;
using System.Globalization;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split(' ');
            int m = int.Parse(values[0]);
            int n = int.Parse(values[1]);

            int[,] mat = new int[m, n];

            for(int i =0; i < m; i++)
            {
                values = Console.ReadLine().Split(' ');
                for(int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());


            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(mat[i, j] == x)
                    {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        
                        if(j > 0)
                        {
                        Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if(j < n -1)
                        {
                        Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                       
                        if(i < m -1)
                        {
                        Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                        if(i > 0)
                        {
                        Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                    }
                }
                    Console.WriteLine();
            }
        }
    }
}
/*3 4
10 8 15 12
21 11 23 8
14 5 13 19
8*/

