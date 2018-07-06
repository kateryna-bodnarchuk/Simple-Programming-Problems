using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Game
    {
        public int Secret = 5;

        public int Count = 0;
        public HashSet<int> Numbers = new HashSet<int>();

        private readonly Action<string> log;

        public Game(int secret, Action<string> log)
        {
            Secret = secret;
            this.log = log;
        }

        public bool Match(int input)
        {
            Count++;
            Numbers.Add(input);

            if (input < Secret)
            {
                log.Invoke("My number is bigger");
                return false;
            }
            else if (input > Secret)
            {
                log.Invoke("My number is lower");
                return false;
            }
            else
            {
                log.Invoke($"You won and had {Count} attempts");
                return true;
            }
        }
    }

}
