using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Choose operation(+,-,/,%");
            char operation = Convert.ToChar(Console.ReadLine());


            Console.WriteLine("Enter another Number: ");
            int num2= Convert.ToInt32(Console.ReadLine());

            switch (operation) { 
            case '+': Console.WriteLine($"{num1} + {num2} = {num1 + num2}");break;
            case '-': Console.WriteLine($"{num1} - {num2} = {num1 - num2}"); break;
            case '*': Console.WriteLine($"{num1} * {num2} = {num1 * num2}"); break;
            case '%': Console.WriteLine($"{num1} % {num2} = {num1 % num2}"); break;
            case '/': Console.WriteLine($"{num1} / {num2} = {num1 / num2}"); break;
            default: Console.WriteLine("Invalid Operation!");break;


            }

        }
    }
}
