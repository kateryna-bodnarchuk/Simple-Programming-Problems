using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject1.ListsAndStrings
{
    /// <summary>
    /// Write three functions that compute the sum of the numbers in a list: using a for-loop, a while-loop and recursion. 
    /// (Subject to availability of these constructs in your language of choice.)
    /// </summary>
    [TestClass]
    public class Test07_Recursion
    {
        int ForLoopSum(List<int> a)
        {
            List<int> list = new List<int>();
            int sum = 0;
            for (int i = 0; i < a.Count; i++)
            {
                sum += a[i];
            }
            return sum;
        }
        int WhileLoopSum(List <int> a)
        {
            int i = 0;
            int sum = 0;
            while ( i < a.Count)
            {
                sum += a[i];
                i++;
            }
            return sum;
        }

        int RecursionSum(List<int> list, int startIndex)
        {
            var current = list[startIndex];

            if (startIndex < list.Count - 1)
            {
                var next = RecursionSum(list, startIndex + 1);
                return current + next;
            }
            else return current;
        }
        [TestMethod]
        public void TestMethod1()
        {
            var a = new List<int>() { 5, 21, 63, 10, 47, 95, 57 };
            var b = ForLoopSum(a);
            var c = WhileLoopSum(a);
            var d = RecursionSum(a, 0);
            Assert.IsTrue(ForLoopSum(a).Equals(298));
            Assert.IsTrue(WhileLoopSum(a).Equals(298));
            Assert.IsTrue(RecursionSum(a, 0).Equals(298));
        }
    }
}
