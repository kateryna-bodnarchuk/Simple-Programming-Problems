//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace UnitTestProject1.ListsAndStrings
//{
//    /// <summary>
//    /// 
//    /// </summary>
//    [TestClass]
//    public class Test06_Palindrome
//    {
//        bool IsPalindrome(string word)
//        {
//            char[] array = word.ToCharArray();

//            for (int i = 0; i < array.Length / 2; i++)
//            {
//                int j = array.Length - i - 1;
//                if (array[i] != array[j]) return false;
//            }
//            return true;
//        }

//        string GetPalindrome(string word)
//        {
//            string message1 = "This is palindrome";
//            string message2 = "This is not palindrome";
//            if (IsPalindrome(word)) return message1;
//            else return message2;
//        }

//        [TestMethod]
//        public void TestMethod1()
//        {
//            string word = "rada";
           
//    }
//}

