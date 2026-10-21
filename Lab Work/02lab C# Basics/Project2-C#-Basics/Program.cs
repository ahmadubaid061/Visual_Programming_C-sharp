using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_C__Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 0:================================ Data Types in C#
            
            int x = 10;                     // Integer data types

            float y = 3.14f;                // Floating-point data types

            /* double data types are those that can hold decimal values 
             and are more precise than float data types. 
             They can hold up to 15-16 digits of precision. */

            double z = 3.14159;

            bool isTrue = true;             // Boolean data types

            bool isFalse = false;           // Character data types

            string name = "John Doe";       // String data types

            const double pi = 3.14159;      //constant data types

            var a = 10;                     //vriable data types


            // 1:================================ Calculating the area of a circle
             Console.WriteLine("-----------------Calculating Area Of the Circle \n");
            float radius;
            Console.WriteLine("Enter the radius of the circle: ");
            radius = float.Parse(Console.ReadLine());
            double area = pi * radius * radius;
            Console.WriteLine("The area of the circle is: {0}sqm \n\n", area);


            // 2:================================ Calculating Circumference of a circle
            Console.WriteLine("-----------------Calculating Circumference Of the Circle \n");
            double circumference = 2 * pi * radius;
            Console.WriteLine("The circumference of the circle is: {0}m", circumference); 


            // 3:================================ Calculating Student marks percentage
            /* Console.WriteLine("\n\n-----------------Calculating Student Marks Percentage \n");
            const int totalMarks = 500;
            int subject1, subject2, subject3, subject4, subject5;
            Console.WriteLine("Enter marks for 5 subjects:");
            subject1 = int.Parse(Console.ReadLine());
            subject2 = int.Parse(Console.ReadLine());
            subject3 = int.Parse(Console.ReadLine());
            subject4 = int.Parse(Console.ReadLine());
            subject5 = int.Parse(Console.ReadLine());
            int obtainedMarks = subject1 + subject2 + subject3 + subject4 + subject5;
            double obtained_Marks = obtainedMarks; //implicit typecasting
            Console.WriteLine("The total marks obtained is: {0} out of :{1}", obtained_Marks, totalMarks);
            double percentage = obtained_Marks / totalMarks * 100;
            Console.WriteLine("The percentage of marks obtained is: {0}%", percentage); */


            // 4:================================ User data printing 

            /*Console.WriteLine("\n\n-----------------User Data Printing \n");
            string firstName;
            string lastName;
            int age;
            double monthly_income;
            Console.WriteLine("Enter your first name: ");
            firstName =Console.ReadLine();

            Console.WriteLine("Enter your last name: ");
            lastName =Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your monthly income: ");
            monthly_income = double.Parse(Console.ReadLine());

            int annual_income = (int)(monthly_income * 12);
            string full_name = firstName + " " + lastName;

            Console.WriteLine("\n\nUser Data: ");
            Console.WriteLine("Name: {0} ", full_name);
            Console.WriteLine("Age : {0} ", age);
            Console.WriteLine("Monthly Income: {0} ", monthly_income);
            Console.WriteLine("Annual Income: {0} ", annual_income); */



        }
    }
}
