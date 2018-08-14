using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace UnitTestProject1.ListsAndStrings
{
    /// <summary>
    /// rite a function that takes a number and returns a list of its digits.
    /// </summary>
    [TestClass]
    public class Test14_DigitsListVar1
    {
        List <int> GetDigits(int number)
        {
            var digits = new List<int>();
            do
            {
                digits.Insert(0, number % 10);
                number = number / 10;
            }
            while (number > 0);
        return digits;
        }
        [TestMethod]
        public void TestMethod1()
        {
            var n = 123;
            Assert.IsTrue(GetDigits(n).SequenceEqual(new int[] { 1, 2, 3 }));
        }
    }
}
