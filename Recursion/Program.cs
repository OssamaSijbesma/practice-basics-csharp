using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program in C# Sharp to print the first n natural number using recursion.
            Console.WriteLine(" === Ex1 print natural === \n");

            int[] n1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            printNatural(0);

            void printNatural(int i)
            {
                if (i >= n1.Length)
                    return;

                Console.Write($"{n1[i]} ");
                printNatural(i + 1);
            }

            // Write a program in C# Sharp to print the first n natural number using recursion.
            Console.WriteLine("\n\n === Ex2 print backwards === \n");

            int[] n2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            printBackwards(0);

            void printBackwards(int i)
            {
                if (i >= n2.Length)
                    return;

                printBackwards(i + 1);
                Console.Write($"{n2[i]} ");
            }

            // Write a program in C# Sharp to find the sum of first n natural numbers using recursion.
            Console.WriteLine("\n\n === Ex3 natural numbers sum === \n");

            Console.WriteLine($"The sum of first 10 natural numbers is : {naturalSum(1, 10)}");

            int naturalSum(int min, int val)
            {
                if (min == val)
                    return min;

                return val + naturalSum(min, val - 1);
            }

            // Write a program in C# Sharp to display the individual digits of a given number using recursion.
            Console.WriteLine("\n === Ex4 all numbers === \n");
            
            separateDigits(1234);

            void separateDigits(int n)
            {
                if (n < 10)
                {
                    Console.Write($"{n} ");
                    return;
                }

                separateDigits(n / 10);
                Console.Write("{0} ", n % 10);
            }
        }
    }
}
