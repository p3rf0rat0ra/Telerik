﻿using System;



    class Calculate
    {
        static int Factorial(int i)
        {
            if (i <= 1)
                return 1;
            return i * Factorial(i - 1);
        }

        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            double X = double.Parse(Console.ReadLine());
            double sum = 1;
            for (int i = 1; i <= N; i++)
            {
                sum += Factorial(i) / Math.Pow(X, i);
            }
            Console.WriteLine("{0:F5}", sum);
        }
    }
