using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4
{
    class ElInt : IChoiceEl<int>
    {
        private static Random rnd = new Random();
        public int UserEl()
        {
            return int.Parse(Console.ReadLine());
        }
        public int RndEl()
        {
            return rnd.Next(-100, 101);
        }
    }
}
