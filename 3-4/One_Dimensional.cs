using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4
{
    sealed class One_Dimensional<P> : BaseClass
    {
        private P[] array;
        IChoiceEl<P> choice;
        public One_Dimensional(int length, IChoiceEl<P> Choice, bool person = false) : base(person)
        {
            choice = Choice;
            array = new P[length];
            Init();
        }
        protected override void UserFill()
        {

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите элемент");
                array[i] = choice.UserEl();
            }
        }


        protected override void RndFill()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = choice.RndEl();
            }
        }

        public override void Print()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }
        }
    }
}
