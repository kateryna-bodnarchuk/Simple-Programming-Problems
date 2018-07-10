using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (int number in GetPerfectSquare (n: 0, count: 15000))
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
        static List<int> GetPerfectSquare(int n, int count)
        {
            var list = new List<int>();
            for (int i = 1; i <= count; i++)
            {
                if (PerfectSquare(i)) list.Add(i);
            }
            return list;
        }
        static bool PerfectSquare(int n)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
            {
                if (n == i * i) return true;
            }
            return false;
        }
    }
}



