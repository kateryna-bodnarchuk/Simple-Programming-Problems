﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace UnitTestProject1.ListsAndStrings
{
    [TestClass]
    public class Test14_Digits
    {
        List <int> Count (int number)
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
            Assert.IsTrue(Count(n).SequenceEqual(new int[] { 1, 2, 3 }));
        }
    }
}
