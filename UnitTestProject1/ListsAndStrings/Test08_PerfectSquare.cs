using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.ListsAndStrings
{
    /// <summary>
    /// Write a function on_all that applies a function to every element of a list. 
    /// Use it to print the first twenty perfect squares (a natural number nn is a perfect square if it can be written as 
    /// n=m*mn=m*m for some other natural number mm. 1,4,9,16,251,4,9,16,25 are the first 5).
    /// </summary>
    [TestClass]
    public class Test08_PerfectSquare
    {
        static List<int> GetPerfectSquare(int max)
        {
            var list = new List<int>();
            for (int squaresCount = 0, i = 0; squaresCount < max; i++)
            {
                squaresCount++;
                if (PerfectSquare(squaresCount))
                {
                    list.Add(squaresCount);
                }
            }
            return list;
        }
        static bool PerfectSquare(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (n == i * i) return true;
            }
            return false;
        }

        [TestMethod]
        public void TestMethod1()
        {
            var a = 10;
            Assert.IsTrue(GetPerfectSquare(a).SequenceEqual(new[] { 1, 4, 9}));
        }
    }
}
