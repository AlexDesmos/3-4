using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4
{
    sealed class Two_dimensional<P> : BaseClass
    {
        private P[,] array;
        private static Random rnd = new Random();
        IChoiceEl<P> choice;
        public Two_dimensional(int length, int width, IChoiceEl<P> Choice, bool Person = false) : base(Person)
        {
            choice = Choice;
            array = new P[length, width];
            Init();
        }
        protected override void UserFill()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine("Введите элемент:");
                    array[i, j] = choice.UserEl();
                }
            }
        }

        protected override void RndFill()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = choice.RndEl();
                }
            }
        }

        public override void Print()
        {
            Console.WriteLine("Массив двумерных:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                ;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                
            }

        }
    }
}
