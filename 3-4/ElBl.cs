using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4
{
    class ElBl : IChoiceEl<bool>
    {
        private static Random rnd = new Random();
        public bool UserEl()
        {
            return bool.Parse(Console.ReadLine());
        }
        public bool RndEl()
        {
            bool[] bl = { false, true };
            bool el = bl[rnd.Next(0, 2)];
            return el;
        }
    }
}
