using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program in C# Sharp to shows how the three parts of a query operation execute.
            Console.WriteLine(" === Ex1 modulo 2 === \n");

            int[] n1 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            IEnumerable<int> r1 = 
                from n in n1 
                where n%2 == 0
                select n;

            foreach (int n in r1)
                Console.Write($"{n} ");

            // Write a program in C# Sharp to find the +ve numbers from a list of numbers using two where conditions in LINQ Query.
            Console.WriteLine("\n\n === Ex2 positive numbers === \n");
            int[] n2 = {
                1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14
            };

            IEnumerable<int> r2 =
                from n in n2
                where n > 0
                where n < 12
                select n;

            foreach (int n in r2)
                Console.Write($"{n} ");

            // Write a program in C# Sharp to find the number of an array and the square of each number.
            Console.WriteLine("\n\n === Ex3 number & square === \n");

            int[] n3 = { 3, 9, 2, 8, 6, 5 };

            var r3 =
                from n in n3
                let sqr = n * n
                where sqr > 20
                select new { n, sqr };

            foreach (var n in r3)
                Console.WriteLine($"{n}");

            // Write a program in C# Sharp to display the number and frequency of number from giving array.
            Console.WriteLine("\n === Ex4 number & occurances === \n");

            int[] n4 = { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            IEnumerable<IGrouping<int, int>> r4 =
                from n in n4
                group n by n into nGroup
                select nGroup;

            foreach (var n in r4)
                Console.WriteLine($"Number {n.Key} appears {n.Count()} times");

            // Write a program in C# Sharp to display the characters and frequency of character from giving string.
            Console.WriteLine("\n === Ex5 letters & occurances === \n");

            string s5 = "apple";
            IEnumerable<IGrouping<char, char>> r5 =
                from s in s5
                group s by s into sGroup
                select sGroup;

            foreach (var s in r5)
                Console.WriteLine($"Character {s.Key}: {s.Count()} times");
        }
    }
}
