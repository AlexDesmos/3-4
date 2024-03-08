using System;

namespace _3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ElBl bls = new ElBl();
            ElDl dls = new ElDl();
            ElInt ints = new ElInt();
            ElStr strs = new ElStr();

            IPrinter[] array = new IPrinter[8];

            Console.WriteLine("Как вы хотите заполянть массив одномерных в int:");
            bool personint = bool.Parse(Console.ReadLine());
            Console.WriteLine("Кол-во злементов в одномерном масииве в int:");
            int countint = int.Parse(Console.ReadLine());

            One_Dimensional<int> intel = new One_Dimensional<int>(countint, ints, personint);
            array[0] = intel;

            Console.WriteLine("Как вы хотите заполянть массив одномерных в string:");
            bool personstr = bool.Parse(Console.ReadLine());
            Console.WriteLine("Кол-во злементов в одномерном масииве в string:");
            int countstr = int.Parse(Console.ReadLine());

            One_Dimensional<string> strel = new One_Dimensional<string>(countstr, strs, personstr);
            array[1] = strel;

            Console.WriteLine("Как вы хотите заполянть массив одномерных в double:");
            bool persondl = bool.Parse(Console.ReadLine());
            Console.WriteLine("Кол-во злементов в одномерном масииве в double:");
            int countdl = int.Parse(Console.ReadLine());

            One_Dimensional<double> dlel = new One_Dimensional<double>(countdl, dls, persondl);
            array[2] = dlel;

            Console.WriteLine("Как вы хотите заполянть массив одномерных в bool:");
            bool personbl = bool.Parse(Console.ReadLine());
            Console.WriteLine("Кол-во злементов в одномерном масииве в bool:");
            int countbl = int.Parse(Console.ReadLine());

            One_Dimensional<bool>blel = new One_Dimensional<bool>(countbl, bls, personbl);
            array[3] = blel;


            Console.WriteLine("Как вы хотите заполнить массив двухмерных в int:");
            bool person2int = bool.Parse(Console.ReadLine());
            Console.WriteLine("Кол-во строк в двухмерном массиве int:");
            int count2int = int.Parse(Console.ReadLine());
            Console.WriteLine("Кол-во столбцов в двухмерном массиве int:");
            int count22int = int.Parse(Console.ReadLine());

            Two_dimensional<int> intel2 = new Two_dimensional<int>(count2int, count22int, ints, person2int);
            array[4] = intel2;


            Console.WriteLine("Как вы хотите заполнить массив двухмерных в string:");
            bool person2str = bool.Parse(Console.ReadLine());
            Console.WriteLine("Кол-во строк в двухмерном массиве string:");
            int count2str = int.Parse(Console.ReadLine());
            Console.WriteLine("Кол-во столбцов в двухмерном массиве string:");
            int count22str = int.Parse(Console.ReadLine());

            Two_dimensional<string> strel2 = new Two_dimensional<string>(count2str, count22str, strs, person2str);
            array[5] = strel2;

            Console.WriteLine("Как вы хотите заполнить массив двухмерных в double:");
            bool person2dl = bool.Parse(Console.ReadLine());
            Console.WriteLine("Кол-во строк в двухмерном массиве double:");
            int count2dl = int.Parse(Console.ReadLine());
            Console.WriteLine("Кол-во столбцов в двухмерном массиве double:");
            int count22dl = int.Parse(Console.ReadLine());

            Two_dimensional<double> dlel2 = new Two_dimensional<double>(count2dl, count22dl, dls, person2dl);
            array[6] = dlel2;


            Console.WriteLine("Как вы хотите заполнить массив двухмерных в bool:");
            bool person2bl = bool.Parse(Console.ReadLine());
            Console.WriteLine("Кол-во строк в двухмерном массиве bool:");
            int count2bl = int.Parse(Console.ReadLine());
            Console.WriteLine("Кол-во столбцов в двухмерном массиве bool:");
            int count22bl = int.Parse(Console.ReadLine());

            Two_dimensional<bool>blel2 = new Two_dimensional<bool>(count2bl, count22bl, bls, person2bl);
            array[7] = blel2;

            for (int i = 0; i < 8; i++)
            {
                array[i].Print();
            }
        }
    }
}
