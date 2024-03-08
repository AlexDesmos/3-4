using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4
{
    class ElDl : IChoiceEl<double>
    {
        private static Random rnd = new Random();
        public double UserEl()
        {
            return int.Parse(Console.ReadLine());
        }
        public double RndEl()
        {
            return rnd.NextDouble() * (200) - 100;
        }
    }
}
