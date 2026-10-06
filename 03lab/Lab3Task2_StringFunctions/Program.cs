using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Task2_StringFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Full Name: ");
            String name = Console.ReadLine();

            Console.WriteLine($"Full Name in UPPERCASE is: {name.ToUpper()}");
            Console.WriteLine($"Full Name in lowercase is: {name.ToLower()}");
            Console.WriteLine($"Total No of Charactors is: {name.Length}");
            Console.WriteLine($"Full Name (space filled by '_'): {name.Replace(' ', '_')}");
            Console.ReadLine();
        }
        
    }
}
