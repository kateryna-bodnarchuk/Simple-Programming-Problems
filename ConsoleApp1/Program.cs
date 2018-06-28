using System;
using System.IO;
using System.Collections;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[] { 16, 26, 46, 56, 100, 76 };

            int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers [i];
            //    Console.WriteLine(sum);
            //}

            int i = 0;
            while (i < numbers.Length)
            {
                sum += numbers[i];
                i++;
                Console.WriteLine(sum);
            }
            Console.ReadKey();
        }
    }
}
    
