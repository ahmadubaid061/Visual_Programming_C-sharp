
using System;

namespace Prime_NUmber_Class
{
    internal class Program
    {
        public class primeNumberClass
        {
            private int[] p;
            private int currentNumbersHeld;
            private const int maxNumbers = 100;

            public primeNumberClass()
            {
                p = new int[maxNumbers];
                currentNumbersHeld = 0;
            }

            public int getCurrentNumbers()
            {
                return currentNumbersHeld;
            }

            public bool isPrime(int value)
            {
                if (value < 2)
                {
                    return false;
                }

                for (int i = 2; i <= value / 2; i++)
                {
                    if (value % i == 0)
                    {
                        return false;
                    }
                }

                return true;
            }

            public void generatePrimeNumbers(int n)
            {
                if (n > maxNumbers)
                {
                    Console.WriteLine(
                        "Limit exceeds array capacity (100)"
                    );
                }
                else
                {
                    int count = 0;
                    int value = 2;

                    while (count < n)
                    {
                        if (isPrime(value))
                        {
                            p[count] = value;

                            count++;
                            currentNumbersHeld++;
                        }

                        value++;
                    }
                }
            }

            public void displayPrimes()
            {
                if (currentNumbersHeld > 0)
                {
                    Console.WriteLine("The Prime Numbers are:");

                    for (int i = 0; i < currentNumbersHeld; i++)
                    {
                        Console.WriteLine(
                            "p[{0}] = {1}", i, p[i]
                        );
                    }
                }
                else
                {
                    Console.WriteLine("Array is Empty!");
                }
            }

            static void Main(string[] args)
            {
                primeNumberClass obj = new primeNumberClass();
                Console.Write("Enter the number of prime numbers to generate: ");
                int val = int.Parse(Console.ReadLine());

                obj.generatePrimeNumbers(val);

                obj.displayPrimes();
                Console.WriteLine("current No of PrimeNumbers are: {0}", obj.getCurrentNumbers());
            }
        }
    }
}
