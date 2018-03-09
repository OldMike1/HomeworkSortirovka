using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkSortirovka
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 7, 8, 3, 2, 4, 6, 12, 100 };
            int a;
            int b;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        a = array[i];
                        b = array[j];
                        array[i] = b;
                        array[j] = a;
                    }
                }
            }
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
        }
    }
}
