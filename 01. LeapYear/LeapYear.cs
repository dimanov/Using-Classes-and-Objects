/*
 * Problem 1. Leap year
 * Write a program that reads a year from the console and checks whether it is a leap one.
 * Use System.DateTime
 */

using System;


class LeapYear
{
    static void Main()
    {
        Console.WriteLine("Please enter a 4-digit year: ");
        var strYear = Console.ReadLine();
        var loadedDate = DateTime.ParseExact(strYear, "yyyy", null);

        int year = loadedDate.Year;

        CheckLeapYear(year);
    }

    private static void CheckLeapYear(int year)
    {
        //var checkedYear = Convert.ToDateTime(strYear).Year;

        //Console.WriteLine(year);

        if (year % 4 != 0)
        {
            Console.WriteLine("The {0} is a common year", year);
        }
        else if (year % 100 !=0)
        {
            Console.WriteLine("The {0} is a leap year", year);
        }
        else if (year % 400 != 0)
        {
            Console.WriteLine("The {0} is a common year", year);
        }
        else 
        {
            Console.WriteLine("The {0} is a leap year", year);
        }
    }
}
