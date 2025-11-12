using System;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // For loop: sum from 1 to N
            Console.Write("Enter a number N: ");
            int N = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= N; i++)
                sum += i;

            Console.WriteLine($"Sum from 1 to {N} = {sum}");

            // While loop: print 1–20, skip multiples of 4, stop at 15
            Console.WriteLine("\nNumbers from 1 to 20 (skip multiples of 4, stop at 15):");
            int num = 1;
            while (num <= 20)
            {
                if (num % 4 == 0)
                {
                    num++;
                    continue;
                }

                if (num == 15)
                    break;

                Console.WriteLine(num);
                num++;
            }

            // Foreach loop: sum of array elements
            int[] arr = { 1, 2, 3, 4, 5 };
            int arrSum = 0;

            foreach (int item in arr)
                arrSum += item;

            Console.WriteLine($"\nSum of array elements: {arrSum}");
        }
    }
}
