﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Հաշվե թվային զանգվածի էլեմենտների գումարը։

            Console.WriteLine("введите размер массива");
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            double[] Array = new double[n];
            Console.WriteLine("введите элементы массива");
            for (int i = 0; i < Array.Length; i++)
            {
              Array[i] = double.Parse(Console.ReadLine());
            }
            double SumArray = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                SumArray += Array[i];
            }
            Console.Write("сумма массива - " + SumArray );
            Console.ReadLine();
        }
    }
}
