using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections;

namespace UnitTestProject1.ListsAndStrings
{
    [TestClass]
    public class Test07_Sums
    {
        public void ForLoop()
        {
            List<int> numbers = new List<int>() { 3, 2, 6, 8, 1 };
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
        }
        public void WhileLoop()
        {
            List<int> numbers = new List<int> { 16, 26, 46, 56, 10, 76 };

            int i = 0;
            while (i < numbers.Count)
            {
                //sum += numbers[i];
                //i++;
            }
        }
        int SumRecursive(IList<int> list, int headIndex)
        {
            if ((list.Count - headIndex) == 0) return 0;

            var head = list[headIndex];
            var tail = SumRecursive(list, headIndex + 1);
            return head + tail;
        }

        [TestMethod]
        public void TestMethod()
        {
            var numbers = new List<int>() { 3, 2, 6, 8, 1 };
            //Assert.AreEqual(numbers.Sum(), ForLoop(numbers, 6));
            //Assert.AreEqual(numbers.Sum(), WhileLoop(numbers, 6));
            Assert.AreEqual(numbers.Sum(), SumRecursive(numbers, 0));
        }
    }
}
