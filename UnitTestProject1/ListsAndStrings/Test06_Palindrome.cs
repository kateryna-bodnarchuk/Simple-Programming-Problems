using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace UnitTestProject1.ListsAndStrings
{
    /// <summary>
    /// Write a function that tests whether a string is a palindrome.
    /// </summary>
    [TestClass]
    public class Test06_Palindrome
    {
        bool IsPalindrome(string word)
        {
            char[] array = word.ToCharArray();

            for (int i = 0; i < array.Length / 2; i++)
            {
                int j = array.Length - i - 1;
                if (array[i] != array[j]) return false;
            }
            return true;
        }

        [TestMethod]
        public void TestMethod1()
        {
            var a = "rada";
            var b = "madam";
            Assert.IsFalse(IsPalindrome(a));
            Assert.IsTrue(IsPalindrome(b));
        }
    }
}

