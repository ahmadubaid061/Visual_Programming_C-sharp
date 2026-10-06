using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) { 
            Console.WriteLine("\n\nChoose an operation: \n1: Rounding Off\n2:find Square root\n3:Maximum value \n4:Minimum Value\n0: Exit");
            char operation = Convert.ToChar(Console.ReadLine());

            double roundOff(double x)
            {
                return Math.Round(x);
            }

            double square_root(double x)
            {
                return Math.Sqrt(x);
            }

            double maximum(double x, double y)
            {
                return Math.Max(x, y);
            }

            double minimum(double x, double y)
            {
                return Math.Min(x, y);
            }

                switch (operation)
                {
                    case '1':
                        {
                            Console.Write("Enter Your Number: ");
                            double number = Convert.ToDouble(Console.ReadLine());
                            Console.Write($"{number} ROunded Off to: {roundOff(number)}");
                            break;
                        }
                    case '2':
                        {
                            Console.Write("Enter Your Number: ");
                            double number = Convert.ToDouble(Console.ReadLine());
                            Console.Write($"Square Roort Of {number} is: {square_root(number)}");
                            break;
                        }
                    case '3':
                        {
                            Console.Write("Enter Number 1: ");
                            double num1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter Number 2: ");
                            double num2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"The Maximum Value among {num1} and {num2} is: {maximum(num1, num2)}");
                            break;
                        }
                    case '4':
                        {
                            Console.Write("Enter Number 1: ");
                            double num1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter Number 2: ");
                            double num2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"The Minimum Value among {num1} and {num2} is: {minimum(num1, num2)}");
                            break;
                        }
                    case '0':
                        {
                            Console.WriteLine("Exiting program...");
                            return;
                        }
                    default: Console.WriteLine("Invalid Operation!"); break;
                }
            }
        }
    }
}
