using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.ListsAndStrings
{
    /// <summary>
    /// Write functions that add, subtract, and multiply two numbers in their digit-list 
    ///representation(and return a new digit list). If you’re ambitious you can implement
    ///Karatsuba multiplication.Try different bases.What is the best base if you care about speed?
    ///If you couldn’t completely solve the prime number exercise above due to the lack of large
    ///numbers in your language, you can now use your own library for this task.
    /// </summary>
    [TestClass]
    public class Test15_DigitsManipulation
    {
        int Max (int a, int b)
        {
            if (a > b) return a;
            else return b;
        }

        List<int> GetDigits(int value)
        {
            var digits = new List<int>();
            do
            {
                digits.Insert(0, value % 10);
                value = value / 10;
            }
            while (value > 0);
            return digits;
        }

        List<int> Sum(int v1, int v2)
        {
            var a = GetDigits(v1);
            var b = GetDigits(v2);
            var length = Max(a.Count, b.Count);
            var sumList = new List<int>();
            for (int i = 0; i <= length; i++)
            {
                int sum = 0;
                sum = a[i] + b[i];

               
            }

            return sumList;
        }
        List<int> Diference(int v1, int v2)
        {
            var a = GetDigits(v1);
            var b = GetDigits(v2);
            var diferenceList = new List<int>();
            for (int i = 0; i < Max(a.Count, b.Count); i++)
            {
                int diference = 0; 
                if (a[i] < b[i])
                {
                    diference = b[i] - a[i];
                }
                else
                {
                    diference = a[i] - b[i];
                }
                diferenceList.Add(diference);
            }
            return diferenceList;
        }

        List<int> Product(int v1, int v2)
        {
            var a = GetDigits(v1);
            var b = GetDigits(v2);
            var productList = new List<int>();
            for (int i = 0; i < Max(a.Count, b.Count); i++)
            {
                int product = a[i] * b[i];
                productList.Add(product);
            }
            return productList;
        }

        [TestMethod]
        public void TestMethod1()
        {
            var v1 = 12;
            var v2 = 456;
            var s = Sum(v1, v2);
            var d = Diference(v1, v2);
            var p = Product(v1, v2);
            Assert.IsTrue(s.SequenceEqual(new int[] { 5, 7, 11}));
            Assert.IsTrue(d.SequenceEqual(new int[] { 3, 3, 1}));
            Assert.IsTrue(p.SequenceEqual(new int[] { 4, 10, 30 }));
        }
    }
}
