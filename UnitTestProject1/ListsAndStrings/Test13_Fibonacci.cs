using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.ListsAndStrings
{
    /// <summary>
    /// Write a function that computes the list of the first 100 Fibonacci numbers.
    /// </summary>
    [TestClass]
    public class Test13_Fibonacci
    {
        int[] FibonacciArray(int n)
        {
            int[] fib = new int[n];
            fib[0] = 0;
            fib[1] = 1;

            for (int i = 2; i < n; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }
            return fib;
        }
        int Fibonacci(int x)
        {
            if (x == 0) return 0;
            if (x == 1) return 1;

            int a = 0 ;
            int b = 1;
            int sum = 1;
            for (int i = 2; i < x; i++)
            {
                sum = a + b;
                a = b;
                b = sum;
            }
            return sum;
        }
         [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(FibonacciArray(10).SequenceEqual(new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 }));
            Assert.IsTrue(Fibonacci(10).Equals(34));
        }
    }
}
