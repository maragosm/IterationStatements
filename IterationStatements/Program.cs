using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //List and list value declarations
            var numbers = new List<int>();
            var num = 0;

            //Iteration Statements and Console Output
            Console.WriteLine($"The number {num} will now increase to 100");
            Console.WriteLine();

            do
            {
                num++;
                numbers.Add(num);
                Console.WriteLine($"The number is now {num}");
            } while (num < 100);

            Console.WriteLine();
            Console.WriteLine($"The number {num} will now increase to 200");
            Console.WriteLine();

            while (num < 200 && num > 99)
            {
                num++;
                numbers.Add(num);
                Console.WriteLine($"The number is now {num}");
            }

            Console.WriteLine();
            Console.WriteLine("The console will now output all list values");
            Console.WriteLine();

            foreach (var numplace in numbers)
            {
                Console.WriteLine($"foreach output: {numplace}");
            }

            Console.WriteLine();
            Console.WriteLine("The console will now output all list values in reverse");
            Console.WriteLine();

            for (int i = 199; i <= numbers.Count && i >= 0; i--)
            {
                Console.WriteLine($"Reverse output: {numbers[i]}");
            }
        }
    }
}
