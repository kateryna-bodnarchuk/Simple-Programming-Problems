using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.ListsAndStrings
{
    /// <summary>
    /// Write a function that takes a list of strings an prints them, one per line, in a rectangular frame.
    /// For example the list ["Hello", "World", "in", "a", "frame"] gets printed as:
    /// *********
    /// * Hello *
    /// * World *
    /// * in    *
    /// * a     *
    /// * frame *
    /// *********
    /// </summary>
    [TestClass]
    public class Test19_Frame
    {
        int MaxLength(string[] wordsCollection)
        {
            int max = wordsCollection[0].Length;
            for (int i = 1; i < wordsCollection.Length; i++)
            {
                int currentLength = wordsCollection[i].Length;

                if (currentLength > max)
                {
                    max = currentLength;
                }
            }
            return max;
        }
     
        List<string> PutWordsToLines(string[] wordsCollection)
        {
            var result = new List<string>();
            foreach (var item in wordsCollection)
            {
                int spaceCount = MaxLength(wordsCollection) - item.Length;
                string space = String.Concat(Enumerable.Repeat(" ", spaceCount));
                string line = item + space;
                result.Add(line);
            }
            return result;
        }
        List<string> PutWordsToLinesWithBorder(string[] wordsCollection, char borderChar, int spacesCount)
        {
            var result = new List<string>();
            var rawLines = PutWordsToLines(wordsCollection);
            string space = String.Concat(Enumerable.Repeat(" ", spacesCount));
            foreach (var item in rawLines)
            {
                string line = borderChar.ToString() + space + item + space + borderChar.ToString();
                result.Add(line);
            }
            var fullLength = result[0].Length;
            string starRow = String.Concat(Enumerable.Repeat("*", fullLength));
            result.Insert(0, starRow);
            result.Add(starRow);
            return result;
        }

        [TestMethod]
        public void TestPutWordsToLines()
        {
            var result = PutWordsToLines(new string[] { "Hello", "World", "in", "a", "frame" });
            var resultExpected = new string[]
            {
                "Hello",
                "World",
                "in   ",
                "a    ",
                "frame"
            };
            Assert.IsTrue(result.SequenceEqual(resultExpected));
        }
        [TestMethod]
        public void TestPutWordsToLinesWithBorder()
        {
            var result = PutWordsToLinesWithBorder(
                new string[] { "Hello", "World", "in", "a", "frame" },
                borderChar: '*',
                spacesCount: 1
            );
            var resultExpected = new string[]
            {
                "*********",
                "* Hello *",
                "* World *",
                "* in    *",
                "* a     *",
                "* frame *",
                "*********",
            };
            Assert.IsTrue(result.SequenceEqual(resultExpected));
        }
    }
}
