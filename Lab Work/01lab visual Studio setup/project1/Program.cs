using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace project1
{
    internal class Program
    {
        const int rows = 10;
        static void Main(string[] args)
        {
            for(int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows-i; j++)
                {
                    Console.Write(" ");
                }
                var k = 0;
                while(k != 2 * i - 1)
                {
                    Console.Write("*");
                    k++;
                }
                Console.WriteLine();
            }
        }
    }
}
