using System;
using System.IO;
using System.Collections;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;
using ClassLibrary1;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game(secret: 5, log: Console.WriteLine);

            Console.WriteLine("Guess number from 1 to 9");

            while (true)
            {
                string userValue = Console.ReadLine();
                int input = int.Parse(userValue);

                if (game.Match(input)) break;
            }
            Console.WriteLine();
        }
    }
}