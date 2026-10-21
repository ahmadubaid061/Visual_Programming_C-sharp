using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] arrOFarrays = new int[8][];
            arrOFarrays[0] = new int[] { 1, 2};
            arrOFarrays[1] = new int[] { 2, 4, 6, 8 };
            arrOFarrays[2] = new int[] { 3, 6, 9, 12, 15, 18};
            arrOFarrays[3] = new int[] { 4, 8, 12, 16, 20, 24, 28, 32 };
            arrOFarrays[4] = new int[] { 5, 10, 15, 20, 25, 30, 35, 40 };
            arrOFarrays[5] = new int[] { 6, 12, 18, 24, 30, 36};
            arrOFarrays[6] = new int[] { 7, 14, 21, 28};
            arrOFarrays[7] = new int[] { 8, 16};

            for(int i = 0; i < arrOFarrays.Length; i++)
            {
                for (int j = 0; j < arrOFarrays[i].Length; j++)
                {
                    Console.Write(arrOFarrays[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            //int size = 8;

            //for (int i = 1; i <= size; i++)
            //{
            //    int columns;

            //    if (i <= 4)
            //        columns = 2 * i;
            //    else
            //        columns = 2 * (size - i + 1);

            //    for (int j = 1; j <= columns; j++)
            //    {
            //        int val = i * j;
            //        Console.Write("{0} ", val);
            //    }

            //    Console.WriteLine();
            //}
        }
    }
}
