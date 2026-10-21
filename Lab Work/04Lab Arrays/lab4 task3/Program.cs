using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_task3
{
    internal class Program
    {
        static int CalculateBill(string name)
        {
            int total = 0;

            for (int i = 1; i <= 3; i++)
            {
                Console.Write("Enter cost of dish " + i + " for " + name + ": ");
                int cost = int.Parse(Console.ReadLine());

                total += cost;
            }

            return total;
        }

        static void Main(string[] args)
        {
            int abdullahBill = CalculateBill("Abdullah");
            int aliBill = CalculateBill("Ali");
            int sherazBill = CalculateBill("Sheraz");

            Console.WriteLine("\nAbdullah's bill: " + abdullahBill);
            Console.WriteLine("Ali's bill: " + aliBill);
            Console.WriteLine("Sheraz's bill: " + sherazBill);

            int[] bills = { abdullahBill, aliBill, sherazBill };
            int maximumBill = bills.Max();
            if(maximumBill == abdullahBill)
            {
                Console.WriteLine("Abdullah has the maximum bill.");
            }
            else if (maximumBill == aliBill)
            {
                Console.WriteLine("Ali has the maximum bill.");
            }
            else
            {
                Console.WriteLine("Sheraz has the maximum bill.");
            }
            Console.ReadLine();
        }
    }
}
