using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4
{
    class ElStr : IChoiceEl<string>
    {
        private static Random rnd = new Random();

        public string UserEl()
        {
            return Console.ReadLine();
        }

        public string RndEl()
        {
            string[] alp = { "a", "b", "c", "d", "f", "e", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            int count = rnd.Next(1, 6);
            string str = "";
            for (int i = 1; i < count + 1; i++)
            {
                str += alp[rnd.Next(0, 27)];
            }
            return str;
        }
    }
}
