using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_Task1
{
    internal class Program
    {
        static bool isPass(int[] arr)
        {
            int passCOunt = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 40)
                {
                    passCOunt += 1;
                }
            }
            if (passCOunt < 2)
            {
                return false;
            }
           
            return true;
        }
        static int FailCOunt(int[] arr)
        {
            
            if (!isPass(arr))
            {
                return 1;
            }
            return 0;
        }
        static int[] EnterMarks(int[] arr)
        {
            Console.Write("Enter marks in 3 Subjects: ");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
           
            return arr;
        }
        static void Main(string[] args)
        {
            int[] marks1 = new int[3];
            int[] marks2 = new int[3];
            int[] marks3 = new int[3];
            Console.WriteLine("--------------------Student 1:");
            marks1 = EnterMarks(marks1);
            Console.WriteLine("--------------------Student 2:");
            marks2 = EnterMarks(marks2);
            Console.WriteLine("--------------------Student 3:");
            marks3 = EnterMarks(marks3);

            int failed = 0;
            failed += FailCOunt(marks1);
            failed += FailCOunt(marks2);
            failed += FailCOunt(marks3);

            Console.WriteLine("total Failed are: {0}", failed);
            Console.ReadLine();
        }
    }
}
