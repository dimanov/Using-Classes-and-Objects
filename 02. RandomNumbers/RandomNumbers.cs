/*
 * Problem 2. Random numbers
 * Write a program that generates and prints to the console 10 random values in the range [100, 200].
 */

using System;

class RandomNumbers
{
    static void Main()
    {
        int startNumber = 100;
        int endNumber = 200;
        int countNumber = 10;
        Console.WriteLine("This program generates {0} random numbers in the range [{1}, {2}]", countNumber, startNumber, endNumber);
        GenerateRandomNumbers(startNumber, endNumber, countNumber);
        Console.WriteLine();
    }

    private static void GenerateRandomNumbers(int start, int end, int count)
    {
        var generator = new Random();

        for (int i = 0; i < count; i++)
        {
            Console.Write("{0} ", generator.Next(start, end+1));
        }

    }
}