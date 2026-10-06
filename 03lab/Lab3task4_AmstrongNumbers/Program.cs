using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3task4_AmstrongNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int originalNumber = number;
            int temp = number;
            int digits = 0;
            int sum = 0;

            while (temp != 0)
            {
                digits++;
                temp /= 10; //temp=temp / 10;
            }

            temp = number;

            while (temp != 0)
            {
                int digit = temp % 10;
                sum += (int)Math.Pow(digit, digits); //digit^totalDigits
                temp /= 10;
            }

            if (sum == originalNumber)
            {
                Console.WriteLine($"{originalNumber} is an Armstrong number.");
            }
            else
            {
                Console.WriteLine($"{originalNumber} is not an Armstrong number.");
            }
            Console.ReadLine(); //just to keep the console window open for taking screen shot of the output
        }
    }
}
