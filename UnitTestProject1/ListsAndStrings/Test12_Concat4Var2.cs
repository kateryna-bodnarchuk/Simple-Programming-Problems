using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.ListsAndStrings
{
    /// <summary>
    /// Write a function that rotates a list by k elements. For example [1,2,3,4,5,6] rotated by two becomes [3,4,5,6,1,2].
    /// Try solving this without creating a copy of the list.
    /// </summary>
    [TestClass]
    public class Test12_Concat4Var2
    {
        int CalculateDestinationIndex(int sourceIndex, int k, int n)
        {
            int destinationIndex = sourceIndex + k;
            {// Adjust destination
                if (destinationIndex >= n)
                {
                    destinationIndex = destinationIndex - n;
                }
            }
            return destinationIndex;
        }

        T[] MyConcat<T>(T[] a)
        {
            int n = a.Length;
            T[] result = new T[n];
            int k = 4;
            int movements = 0;

            for (int startIndex = 0; movements < n; startIndex++)
            {
                int sourceIndex = startIndex;
                T sourceValue = a[sourceIndex];
                do
                {
                    int destinationIndex = CalculateDestinationIndex(sourceIndex, k, n);
                    T tempValue = a[destinationIndex];
                    a[destinationIndex] = sourceValue;
                    sourceIndex = destinationIndex;
                    sourceValue = tempValue;
                    movements++;
                }
                while (sourceIndex != startIndex);
            }
            return result;
        } 
        [TestMethod]
        public void TestMethod1()
        {
            string [] a = new string [] { "a", "b", "c", "d", "e", "f" };
            var c = MyConcat<string>(a);
            Assert.IsTrue(c.SequenceEqual(new string []{ "c", "d", "e", "f", "a", "b" }));
        }
    }
}
