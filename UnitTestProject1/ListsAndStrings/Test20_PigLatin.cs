using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.ListsAndStrings
{
    /// <summary>
    /// Write function that translates a text to Pig Latin and back. English is translated to Pig Latin 
    /// by taking the first letter of every word, moving it to the end of the word and adding ‘ay’. 
    /// “The quick brown fox” becomes “Hetay uickqay rownbay oxfay”.
    /// </summary>
    [TestClass]
    public class Test20_PigLatin
    {
        string ConvertFistWordToPig(string word)
        {
            char fist = Char.ToLower(word[0]);
            string afterFist = word.Substring(1);
            string afterSecond = afterFist.Substring(1);
            char second = Char.ToUpper(word[1]);
            string pig = second + afterSecond + fist + "ay";
            return pig;
        }
        string ConvertWordToPig(string word)
        {
            char fist = word[0];
            string afterFist = word.Substring(1);
            string pig = afterFist + fist + "ay";
            return pig;
        }
        string ConvertSentenceToPig(string sentence)
        {
            List <string> words = sentence.Split(' ').ToList();
            var result = new List<string>();
            result.Add(ConvertFistWordToPig(words[0]));

            for (int i = 1; i < words.Count; i++)
            {
                result.Add(ConvertWordToPig(words[i]));
            }
            sentence = string.Join(" ", result);
            return sentence;
        }
        [TestMethod]
        public void TestMethod2()
        {
            var a = "The quick brown fox";
            Assert.IsTrue(ConvertSentenceToPig(a).Equals("Hetay uickqay rownbay oxfay"));
        }
    }
}
