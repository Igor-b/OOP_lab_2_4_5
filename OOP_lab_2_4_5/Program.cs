﻿using System;

namespace OOP_lab_2_4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int[,] a = new int[n, m];

            var random = new Random();

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    a[i, j] = random.Next(-100, 100);
                }
            }

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    Console.Write("{0} ", a[i, j]);
                }
                Console.WriteLine();
            }

            int sum = 0;

            for (int i = 0; i < n; ++i)
            {
                int max = a[i, 0] = 0;

                for (int j = 0; j < m; ++j)
                {
                    if (a[i, j] >= max)
                    {
                        max = a[i, j];
                    }
                }

                sum += max;
            }

            Console.WriteLine();
            
            Console.WriteLine("Сума найбiльших елементiв матрицi: {0}", sum);
        }
    }
}
