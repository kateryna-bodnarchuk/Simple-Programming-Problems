using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.Elementary
{
    /// <summary>
    /// Write a program that prints the next 20 leap years.
    /// </summary>
    [TestClass]
    public class Test10_LeapYears
    {
        int GetNearestLeapYear(int currentYear)
        {
            while (true)
            {
                if (DateTime.IsLeapYear(currentYear))
                {
                    return currentYear;
                }
                else
                {
                    currentYear++;
                }
            }
        }
        List<int> GetNextLeapYears(int currentYear, int yearsCount)
        {
            var nearestLeapYear = GetNearestLeapYear(currentYear);

            var resultList = new List<int>();
            for (int i = 0; i < yearsCount; i++)
            {
                var leapYear = nearestLeapYear + (i * 4);
                resultList.Add(leapYear);
            }
            return resultList;
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(GetNearestLeapYear(2018).Equals(2020));
            Assert.IsTrue(GetNextLeapYears(2018, 5).SequenceEqual(new int[] { 2020, 2024, 2028, 2032, 2036 }));
        }
    }
}
