/*
 * Problem 6. Sum integers
 * You are given a sequence of positive integer values written into a string, separated by spaces.
 * Write a function that reads these values from given string and calculates their sum.
 */

using System;
using System.Linq;
using System.Text;

class SumIntegers
{
    static void Main()
    {
        Console.WriteLine("Please enter numbers, separated by a space:");
        string strNumbers = Console.ReadLine();
        var numberList = strNumbers.Split(' ');
        var numbers = numberList.Select(x => int.Parse(x.ToString())).ToList();
        Console.WriteLine("The sum of the numbers is: {0}", CalculateSum(numbers));

    }

    private static object CalculateSum(System.Collections.Generic.List<int> numbers)
    {
        int sum = 0;

        foreach(int number in numbers)
        {
            sum += number;
        }
        return sum;
    }
}