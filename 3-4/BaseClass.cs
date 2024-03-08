using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4
{
    abstract class BaseClass : IBase
    {
        private bool person { get; set; }

        protected BaseClass(bool Person)
        {
            person = Person;
        }

        public abstract void Print();

        protected abstract void UserFill();
        protected abstract void RndFill();

        public void Init()
        {
            if (person)
                UserFill();
            else
                RndFill();
        }
    }
}
